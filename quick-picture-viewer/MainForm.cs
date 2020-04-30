using Microsoft.VisualBasic.FileIO;
using Svg;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	public partial class MainForm : Form
	{
		private string openPath;
		private int zoomFactor = 100;
		private int width = 0;
		private int height = 0;
		private Bitmap originalImage;
		private bool autoZoom = true;
		private Point panelMouseDownLocation;
		private bool fullscreen = false;
		private string currentFolder;
		private string currentFile;
		private bool alwaysOnTop = false;
		private bool imageChanged = false;
		private bool darkMode = false;
		private bool checkboardBackground = false;
		private bool slideshow = false;

		private System.Timers.Timer zoomInTimer = new System.Timers.Timer();
		private System.Timers.Timer zoomOutTimer = new System.Timers.Timer();
		private System.Timers.Timer slideshowTimer = new System.Timers.Timer();

		private System.Threading.Timer suggestionTimer;

		public bool printCenterImage = true;

		public MainForm(string openPath, bool darkMode)
		{
			if (darkMode)
			{
				this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			CustomJumplist jumplist = new CustomJumplist(this.Handle);

			this.darkMode = darkMode;
			this.openPath = openPath;

			InitializeComponent();

			settingsButton.ShortcutKeyDisplayString = "Ctrl+Comma";

			zoomInTimer.Elapsed += new ElapsedEventHandler(zoomInTimer_Event);
			zoomInTimer.Interval = 100;

			zoomOutTimer.Elapsed += new ElapsedEventHandler(zoomOutTimer_Event);
			zoomOutTimer.Interval = 100;

			slideshowTimer.Elapsed += new ElapsedEventHandler(slideshowTimer_Event);
			slideshowTimer.Interval += 5000;

			toolStrip1.Renderer = new ToolStripOverride(darkMode);
			picturePanel.MouseWheel += new MouseEventHandler(picturePanel_MouseWheel);
			zoomComboBox.ComboBox.MouseWheel += new MouseEventHandler(zoomComboBox_MouseWheel);

			if (darkMode)
			{
				applyDarkTheme();
			}
		}

		private void zoomInTimer_Event(Object source, ElapsedEventArgs e)
		{
			zoomIn();
		}

		private void zoomOutTimer_Event(Object source, ElapsedEventArgs e)
		{
			zoomOut();
		}

		private void slideshowTimer_Event(Object source, ElapsedEventArgs e)
		{
			nextFile();
		}

		private void openButton_Click_1(object sender, EventArgs e)
		{
			setSlideshow(false);
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				openFile(openFileDialog1.FileName);
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			try
			{
				if (!string.IsNullOrEmpty(openPath))
				{
					if (File.GetAttributes(openPath).HasFlag(FileAttributes.Directory))
					{
						currentFolder = openPath;
						openFirstFileInFolder();
					}
					else
					{
						openFile(openPath);
					}
				}
			}
			catch
			{
				MessageBox.Show("Unable to open this file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			if (Properties.Settings.Default.CheckForUpdates)
			{
				checkForUpdates(false);
			}

			setAlwaysOnTop(Properties.Settings.Default.AlwaysOnTop, false);
			setCheckboardBackground(Properties.Settings.Default.CheckboardBackground, false);
		}

		public async void checkForUpdates(bool showUpToDateDialog)
		{
			try
			{
				UpdateChecker checker = new UpdateChecker("ModuleArt", "quick-picture-viewer");

				bool update = await checker.CheckUpdate();

				if (update == false)
				{
					if (showUpToDateDialog)
					{
						MessageBox.Show("Application is up to date", "Updator", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					UpdateForm updateDialog = new UpdateForm(checker, "Quick Picture Viewer", darkMode);

					if (alwaysOnTop)
					{
						updateDialog.TopMost = true;
					}

					DialogResult result = updateDialog.ShowDialog();
					if (result == DialogResult.Yes)
					{
						DownloadForm downloadBox = new DownloadForm(checker.GetAssetUrl("QuickPictureViewer-Setup.msi"), darkMode);
						downloadBox.Owner = this;
						if (alwaysOnTop)
						{
							downloadBox.TopMost = true;
						}
						downloadBox.ShowDialog();
					}
					else
					{
						updateDialog.Dispose();
					}
				}
			}
			catch
			{
				if (showUpToDateDialog)
				{
					MessageBox.Show("Connection error", "Updator", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void showTypeOpsButton(bool show, string type)
		{
			this.Invoke((MethodInvoker)(() => {
				typeOpsButton.Visible = show;

				if (show)
				{
					typeOpsButton.Text = String.Format("{0} options", type);
					typeOpsButton.Focus();
				}
			}));
		}

		private void openFile(string path)
		{
			try
			{
				string ext = Path.GetExtension(path);
				if (ext == ".webp")
				{
					byte[] rawWebP = File.ReadAllBytes(path);
					using (WebP webp = new WebP())
					{
						//WebPDecoderOptions decoderOptions = new WebPDecoderOptions();
						//decoderOptions.use_threads = 1;
						//decoderOptions.alpha_dithering_strength = 50;

						//openImage(webp.Decode(rawWebP, new WebPDecoderOptions()), Path.GetDirectoryName(path), Path.GetFileName(path));
						openImage(webp.Decode(rawWebP), Path.GetDirectoryName(path), Path.GetFileName(path));
					}

					showTypeOpsButton(false, null);
				} 
				else if (ext == ".ico") 
				{
					Bitmap bmp = new Icon(path, 128, 128).ToBitmap();
					openImage(bmp, Path.GetDirectoryName(path), Path.GetFileName(path));
					showTypeOpsButton(false, null);
				}
				else if (ext == ".svg")
				{
					openSvg(path, -1, -1);
				}
				else
				{
					openImage(new Bitmap(path), Path.GetDirectoryName(path), Path.GetFileName(path));
					showTypeOpsButton(false, null);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unable to open this file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Console.WriteLine(ex);
			}
		}

		public void openSvg(string path, int width, int height)
		{
			try
			{
				Svg.SvgDocument svgDocument = Svg.SvgDocument.Open(path);
				svgDocument.ShapeRendering = SvgShapeRendering.Auto;

				if (width == -1)
				{
					width = Convert.ToInt32(svgDocument.Width.Value);
				}

				if (height == -1)
				{
					height = Convert.ToInt32(svgDocument.Height.Value);
				}

				openImage(svgDocument.Draw(width, height), Path.GetDirectoryName(path), Path.GetFileName(path));

				showTypeOpsButton(true, "SVG");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unable to find SVG file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Console.WriteLine(ex);
			}
		}

		private void openImage(Bitmap bitmap, string directoryName, string fileName)
		{
			if (imageChanged)
			{
				DialogResult window = MessageBox.Show(
					"All unsaved data will be lost.\nAre you sure you want to open new image?",
					"Warning",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question
				);

				if (window == DialogResult.No)
				{
					return;
				}
			}

			setImageChanged(false);

			if (originalImage != null)
			{
				originalImage.Dispose();
				originalImage = null;
				pictureBox.Image.Dispose();
				pictureBox.Image = null;
			}

			originalImage = bitmap;
			pictureBox.Image = originalImage;

			width = pictureBox.Image.Size.Width;
			height = pictureBox.Image.Size.Height;
			fileLabel.Text = "File: " + fileName;

			if(directoryName == null)
			{
				currentFolder = null;
				currentFile = null;
				directoryLabel.Text = "Folder: Not exists";
				sizeLabel.Text = "Size: " + width.ToString() + " x " + height.ToString() + " px";

				nextButton.Enabled = false;
				prevButton.Enabled = false;
				slideshowButton.Enabled = false;
				deleteButton.Enabled = false;
				externalButton.Enabled = false;
				showFileButton.Enabled = false;
				reloadButton.Enabled = false;

				dateCreatedLabel.Visible = false;
				dateModifiedLabel.Visible = false;
			}
			else
			{
				string path = Path.Combine(directoryName, fileName);

				currentFolder = directoryName;
				currentFile = fileName;
				directoryLabel.Text = "Folder: " + directoryName;
				sizeLabel.Text = "Size: " + width.ToString() + " x " + height.ToString() + " px (" + Converter.PathToSize(path) + ")";

				nextButton.Enabled = true;
				prevButton.Enabled = true;
				slideshowButton.Enabled = true;
				deleteButton.Enabled = true;
				externalButton.Enabled = true;
				showFileButton.Enabled = true;
				reloadButton.Enabled = true;

				dateCreatedLabel.Text = "Created: " + File.GetCreationTime(path).ToShortDateString() + " - " + File.GetCreationTime(path).ToLongTimeString();
				dateCreatedLabel.Visible = true;
				dateModifiedLabel.Text = "Modified: " + File.GetLastWriteTime(path).ToShortDateString() + " - " + File.GetLastWriteTime(path).ToLongTimeString();
				dateModifiedLabel.Visible = true;
			}

			this.Invoke((MethodInvoker)(() => this.Text = fileName + " - Quick Picture Viewer"));

			zoomInButton.Enabled = true;
			zoomOutButton.Enabled = true;
			flipVerticalButton.Enabled = true;
			flipHorizontalButton.Enabled = true;
			rotateLeftButton.Enabled = true;
			rotateRightButton.Enabled = true;
			rotate180Button.Enabled = true;
			saveAsButton.Enabled = true;
			copyButton.Enabled = true;
			autoZoomButton.Enabled = true;
			setAsDesktopButton.Enabled = true;
			infoButton.Enabled = true;
			printButton.Enabled = true;
			miniViewButton.Enabled = true;

			zoomComboBox.Enabled = true;

			pleaseOpenLabel.Visible = false;

			setZoomText("Auto");
		}

		private void setImageChanged(bool b)
		{
			imageChanged = b;
			hasChangesLabel.Visible = b;
		}

		private void zoomInButton_Click(object sender, EventArgs e)
		{
			zoomIn();
		}

		private void zoomOutButton_Click(object sender, EventArgs e)
		{
			zoomOut();
		}

		private void zoomIn()
		{
			if (autoZoom)
			{
				zoomToFit();
			}
			setZoomText((zoomFactor + 5).ToString() + "%");
		}

		private void zoomOut()
		{
			if (autoZoom)
			{
				zoomToFit();
			}
			setZoomText((zoomFactor - 5).ToString() + "%");
		}

		private void zoomToFit()
		{
			double zoomFactorX = picturePanel.Width / (double) originalImage.Width;
			double zoomFactorY = picturePanel.Height / (double)originalImage.Height;

			if (zoomFactorX > zoomFactorY)
			{
				zoomFactor = Convert.ToInt32(zoomFactorY * 100);
			}
			else
			{
				zoomFactor = Convert.ToInt32(zoomFactorX * 100);
			}
		}

		private void setZoomFactor(int newZoomFactor)
		{
			zoomFactor = newZoomFactor;

			zoomLabel.Text = "Zoom: " + zoomFactor.ToString() + "%";

			setAutoZoom(false);

			int newWidth = Convert.ToInt32(width * zoomFactor / 100);
			int newHeight = Convert.ToInt32(height * zoomFactor / 100);

			int newScrollH = Convert.ToInt32(picturePanel.HorizontalScroll.Value * zoomFactor / 100);
			int newScrollV = Convert.ToInt32(picturePanel.VerticalScroll.Value * zoomFactor / 100);

			Size newSize = new Size(newWidth, newHeight);

			pictureBox.Size = newSize;

			updatePictureBoxLocation();
		}
						
		private void updatePictureBoxLocation()
		{
			if (pictureBox.Width < picturePanel.Width)
			{
				pictureBox.Left = (picturePanel.Width - pictureBox.Width) / 2;
			}
			else
			{
				pictureBox.Left = 0;
			}

			if (pictureBox.Height < picturePanel.Height)
			{
				pictureBox.Top = (picturePanel.Height - pictureBox.Height) / 2;
			}
			else
			{
				pictureBox.Top = 0;
			}
		}

		private void setZoomText(string text)
		{
			zoomComboBox.ComboBox.Invoke((MethodInvoker)(() => zoomComboBox.Text = text));
		}

		private void setAutoZoom(bool b)
		{
			autoZoom = b;

			autoZoomButton.Checked = b;

			if (b)
			{
				pictureBox.Dock = DockStyle.Fill;

				zoomLabel.Text = "Zoom: Auto";
			}
			else
			{
				pictureBox.Dock = DockStyle.None;
			}
		}

		private void autoZoomButton_Click(object sender, EventArgs e)
		{
			if (zoomComboBox.Text == "Auto")
			{
				zoomToFit();
				setZoomText(zoomFactor + "%");
			}
			else
			{
				setZoomText("Auto");
			}
		}

		private void aboutButton_Click(object sender, EventArgs e)
		{
			AboutForm aboutBox = new AboutForm(darkMode);
			aboutBox.Owner = this;
			if (alwaysOnTop)
			{
				aboutBox.TopMost = true;
			}
			aboutBox.ShowDialog();
		}

		private void setSlideshow(bool b)
		{
			slideshow = b;
			slideshowButton.GetCurrentParent().Invoke((MethodInvoker)(() => slideshowButton.Checked = b));
			if (b)
			{
				setFullscreen(b);
				slideshowTimer.Start();
			}
			else
			{
				slideshowTimer.Stop();
			}
		}

		private void setAlwaysOnTop(bool b, bool saveToDisk)
		{
			alwaysOnTop = b;
			this.TopMost = b;
			onTopButton.Checked = b;

			if(b)
			{
				setFullscreen(false);
			}

			if (saveToDisk)
			{
				Properties.Settings.Default.AlwaysOnTop = b;
				Properties.Settings.Default.Save();
			}
		}

		public void setCheckboardBackground(bool b, bool saveToDisk)
		{
			checkboardBackground = b;
			checkboardButton.Checked = b;

			if (b)
			{
				if (darkMode)
				{
					picturePanel.BackgroundImage = Properties.Resources.checkboard_dark;
				}
				else
				{
					picturePanel.BackgroundImage = Properties.Resources.checkboard_light;
				}
			}
			else
			{
				picturePanel.BackgroundImage = null;
			}

			if (saveToDisk)
			{
				Properties.Settings.Default.CheckboardBackground = b;
				Properties.Settings.Default.Save();
			}
		}

		private void flipVerticalButton_Click(object sender, EventArgs e)
		{
			originalImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
			pictureBox.Image = originalImage;
			setZoomText("Auto");
			setImageChanged(true);
		}

		private void flipHorizontalButton_Click(object sender, EventArgs e)
		{
			originalImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
			pictureBox.Image = originalImage;
			setZoomText("Auto");
			setImageChanged(true);
		}

		private void rotateLeftButton_Click(object sender, EventArgs e)
		{
			originalImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
			pictureBox.Image = originalImage;
			setZoomText("Auto");
			setImageChanged(true);
		}

		private void rotateRightButton_Click(object sender, EventArgs e)
		{
			originalImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
			pictureBox.Image = originalImage;
			setZoomText("Auto");
			setImageChanged(true);
		}

		private void saveAsButton_Click(object sender, EventArgs e)
		{
			setSlideshow(false);
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				System.IO.FileStream fs = (System.IO.FileStream) saveFileDialog1.OpenFile();
				switch (saveFileDialog1.FilterIndex)
				{
					case 1:
						originalImage.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
						break;
					case 2:
						originalImage.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
						break;
					case 3:
						originalImage.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
						break;
					case 4:
						originalImage.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
						break;
					case 5:
						originalImage.Save(fs, System.Drawing.Imaging.ImageFormat.Tiff);
						break;
					case 6:
						//originalImage.Save(fs, System.Drawing.Imaging.ImageFormat.Tiff);
						//Icon icon = Icon.FromHandle(originalImage.GetHicon());
						//icon.Save(fs);
						IcoWrapper.ConvertToIcon(originalImage, fs);
						break;
					case 7:
						using (WebP webp = new WebP())
						{
							byte[] rawWebP = webp.EncodeLossy(originalImage);
							fs.Write(rawWebP, 0, rawWebP.Length);
						}
						break;
				}
				fs.Close();
				openFile(saveFileDialog1.FileName);
			}
		}

		private void copyButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetImage(originalImage);
			showSuggestion("Image is copied to clipboard");
		}

		private void pasteButton_Click(object sender, EventArgs e)
		{
			if (Clipboard.ContainsImage())
			{
				openImage(new Bitmap(Clipboard.GetImage()), null, "From clipboard");
				setImageChanged(true);
			}
			else if (Clipboard.ContainsData(DataFormats.FileDrop))
			{
				string path = ((string[]) Clipboard.GetData(DataFormats.FileDrop))[0];
				openFile(path);
			}
		}

		private void picturePanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && !autoZoom)
			{
				Cursor.Current = Cursors.SizeAll;

				panelMouseDownLocation = new Point(
					this.PointToClient(Cursor.Position).X + picturePanel.HorizontalScroll.Value,
					this.PointToClient(Cursor.Position).Y + picturePanel.VerticalScroll.Value
				);
			}
		}

		private void picturePanel_MouseUp(object sender, MouseEventArgs e)
		{
			Cursor.Current = Cursors.Default;
		}

		private void picturePanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && !autoZoom)
			{
				int newX = panelMouseDownLocation.X - this.PointToClient(Cursor.Position).X;
				int newY = panelMouseDownLocation.Y - this.PointToClient(Cursor.Position).Y;

				if (newX > picturePanel.HorizontalScroll.Minimum)
				{
					if (newX < picturePanel.HorizontalScroll.Maximum)
					{
						picturePanel.HorizontalScroll.Value = newX;
					}
					else
					{
						picturePanel.HorizontalScroll.Value = picturePanel.HorizontalScroll.Maximum;
					}
				}
				else
				{
					picturePanel.HorizontalScroll.Value = picturePanel.HorizontalScroll.Minimum;
				}

				if (newY > picturePanel.VerticalScroll.Minimum)
				{
					if (newY < picturePanel.VerticalScroll.Maximum)
					{
						picturePanel.VerticalScroll.Value = newY;
					}
					else
					{
						picturePanel.VerticalScroll.Value = picturePanel.VerticalScroll.Maximum;
					}
				}
				else
				{
					picturePanel.VerticalScroll.Value = picturePanel.VerticalScroll.Minimum;
				}
			}
		}

		private void zoomComboBox_MouseWheel(object sender, MouseEventArgs e)
		{
			((HandledMouseEventArgs)e).Handled = true;
		}

		private void picturePanel_MouseWheel(object sender, MouseEventArgs e)
		{
			if(Control.ModifierKeys == Keys.Control)
			{
				if (e.Delta > 0)
				{
					zoomIn();
				}
				else if(e.Delta < 0)
				{
					zoomOut();
				}
			}
		}

		private void fullscreenButton_Click(object sender, EventArgs e)
		{
			setFullscreen(!fullscreen);
		}

		private void setFullscreen(bool b)
		{
			fullscreen = b;

			this.WindowState = FormWindowState.Normal;

			toolStrip1.Visible = !b;
			statusStrip1.Visible = !b;

			if (b)
			{
				if (!Properties.Settings.Default.ShowCursorInFullscreen)
				{
					Bitmap bitmap = new Bitmap(1, 1);
					IntPtr ptr = bitmap.GetHicon();
					picturePanel.Cursor = new Cursor(ptr);
				}

				this.FormBorderStyle = FormBorderStyle.None;
				this.WindowState = FormWindowState.Maximized;

				picturePanel.Top = 0;
				picturePanel.Height = this.ClientSize.Height;
				picturePanel.BackColor = Color.Black;

				typeOpsButton.Left = this.ClientRectangle.Width + 26;

				setAlwaysOnTop(false, true);

				suggestionLabel.Location = new Point(9, 9);

				pleaseOpenLabel.ForeColor = Color.White;

				showSuggestion("Press Esc to exit fullscreen mode");
			}
			else
			{
				picturePanel.Cursor = Cursors.Default;

				this.FormBorderStyle = FormBorderStyle.Sizable;

				picturePanel.Top = toolStrip1.Height;
				picturePanel.Height = this.ClientSize.Height - toolStrip1.Height - statusStrip1.Height;
				picturePanel.BackColor = Color.Transparent;

				typeOpsButton.Left = this.ClientRectangle.Width - typeOpsButton.Width - 26;

				suggestionLabel.Location = new Point(9, 43);

				pleaseOpenLabel.ForeColor = this.ForeColor;
			}
		}

		private void zoomComboBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (zoomComboBox.Text == "Auto")
				{
					setAutoZoom(true);
				}
				else
				{
					string substr = zoomComboBox.Text.Replace("%", "");
					int zoom = int.Parse(substr);

					if (zoom < 1)
					{
						zoom = 1;
						setZoomText(zoom.ToString() + "%");
					}
					else
					{
						if (zoom > 1000)
						{
							zoom = 1000;
							setZoomText(zoom.ToString() + "%");
						}
						else
						{
							setZoomFactor(zoom);
						}
					}
				}				
			}
			catch
			{

			}
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control)
			{
				if (e.Shift)
				{
					if (e.KeyCode == Keys.E)
					{
						showFileButton.PerformClick();
					}
					else if (e.KeyCode == Keys.C)
					{
						checkboardButton.PerformClick();
					}
					else if (e.KeyCode == Keys.S)
					{
						slideshowButton.PerformClick();
					}
					else if (e.KeyCode == Keys.P)
					{
						miniViewButton.PerformClick();
					}
				}
				else
				{
					if (e.KeyCode == Keys.O)
					{
						openButton.PerformClick();
					}
					else if (e.KeyCode == Keys.S)
					{
						saveAsButton.PerformClick();
					}
					else if (e.KeyCode == Keys.A)
					{
						autoZoomButton.PerformClick();
					}
					else if (e.KeyCode == Keys.C)
					{
						copyButton.PerformClick();
					}
					else if (e.KeyCode == Keys.V)
					{
						pasteButton.PerformClick();
					}
					else if (e.KeyCode == Keys.Oemplus)
					{
						zoomInButton.PerformClick();
					}
					else if (e.KeyCode == Keys.OemMinus)
					{
						zoomOutButton.PerformClick();
					}
					else if (e.KeyCode == Keys.T)
					{
						onTopButton.PerformClick();
					}
					else if (e.KeyCode == Keys.I)
					{
						infoButton.PerformClick();
					}
					else if (e.KeyCode == Keys.E)
					{
						externalButton.PerformClick();
					}
					else if (e.KeyCode == Keys.P)
					{
						printButton.PerformClick();
					}
				}
			}
			else if (e.Alt)
			{
				if (e.KeyCode == Keys.Enter)
				{
					fullscreenButton.PerformClick();
				}
				else if (e.KeyCode == Keys.Down)
				{
					int newVerticalValue = picturePanel.VerticalScroll.Value + picturePanel.VerticalScroll.LargeChange;
					
					if (newVerticalValue >= picturePanel.VerticalScroll.Maximum)
					{
						picturePanel.VerticalScroll.Value = picturePanel.VerticalScroll.Maximum;
					}
					else
					{
						picturePanel.VerticalScroll.Value = newVerticalValue;
					}
				}
				else if (e.KeyCode == Keys.Up)
				{
					int newVerticalValue = picturePanel.VerticalScroll.Value - picturePanel.VerticalScroll.LargeChange;

					if (newVerticalValue <= picturePanel.VerticalScroll.Minimum)
					{
						picturePanel.VerticalScroll.Value = picturePanel.VerticalScroll.Minimum;
					}
					else
					{
						picturePanel.VerticalScroll.Value = newVerticalValue;
					}
				}
				else if (e.KeyCode == Keys.Left)
				{
					int newHorizontalValue = picturePanel.HorizontalScroll.Value - picturePanel.HorizontalScroll.LargeChange;

					if (newHorizontalValue <= picturePanel.HorizontalScroll.Minimum)
					{
						picturePanel.HorizontalScroll.Value = picturePanel.HorizontalScroll.Minimum;
					}
					else
					{
						picturePanel.HorizontalScroll.Value = newHorizontalValue;
					}
				}
				else if (e.KeyCode == Keys.Right)
				{
					int newHorizontalValue = picturePanel.HorizontalScroll.Value + picturePanel.HorizontalScroll.LargeChange;

					if (newHorizontalValue >= picturePanel.HorizontalScroll.Maximum)
					{
						picturePanel.HorizontalScroll.Value = picturePanel.HorizontalScroll.Maximum;
					}
					else
					{
						picturePanel.HorizontalScroll.Value = newHorizontalValue;
					}
				}
			}
			else
			{
				if (e.KeyCode == Keys.F || e.KeyCode == Keys.F11)
				{
					fullscreenButton.PerformClick();
				}
				else if (e.KeyCode == Keys.F12)
				{
					screenshotButton.PerformClick();
				}
				else if (e.KeyCode == Keys.Delete)
				{
					deleteButton.PerformClick();
				}
				else if (e.KeyCode == Keys.Left)
				{
					prevButton.PerformClick();
				}
				else if (e.KeyCode == Keys.Right)
				{
					nextButton.PerformClick();
				}
				else if (e.KeyCode == Keys.Escape)
				{
					setFullscreen(false);
				}
				else if (e.KeyCode == Keys.Down)
				{
					zoomOut();
				}
				else if (e.KeyCode == Keys.Up)
				{
					zoomIn();
				}
			}
		}

		private void MainForm_DragDrop(object sender, DragEventArgs e)
		{
			Bitmap bitmap = e.Data.GetData(DataFormats.Bitmap) as Bitmap;
			string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];

			if (bitmap != null)
			{
				openImage(bitmap, null, "Dragged image");
				setImageChanged(true);
			}
			else if (files.Length > 0)
			{
				string path = files[0];
				openFile(path);
			}
		}

		private void MainForm_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent(DataFormats.Bitmap))
			{
				e.Effect = DragDropEffects.All;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void onTopButton_Click(object sender, EventArgs e)
		{
			setAlwaysOnTop(!alwaysOnTop, true);
		}

		private void screenshotButton_Click(object sender, EventArgs e)
		{
			this.Hide();

			System.Threading.Thread.Sleep(250);

			Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
			using (Graphics g = Graphics.FromImage(bmp))
			{
				g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);

				openImage(bmp, null, "Captured screen");
				setImageChanged(true);
			}

			this.Show();
		}

		private int nextFile()
		{
			string[] filePaths = getCurrentFiles();

			int currentIndex = -1;
			for (int i = 0; i < filePaths.Length; i++)
			{
				if (filePaths[i].ToLower() == Path.Combine(currentFolder, currentFile).ToLower())
				{
					currentIndex = i;
					break;
				}
			}

			if (currentIndex == -1)
			{
				setSlideshow(false);
				MessageBox.Show("Current file could not be found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return 0;
			}
			else
			{
				if (currentIndex == filePaths.Length - 1)
				{
					openFile(filePaths[0]);
				}
				else
				{
					openFile(filePaths[currentIndex + 1]);
				}

				return filePaths.Length;
			}
		}

		private void nextButton_Click(object sender, EventArgs e)
		{
			nextFile();
		}

		private void prevFile()
		{
			string[] filePaths = getCurrentFiles();

			int currentIndex = -1;
			for (int i = 0; i < filePaths.Length; i++)
			{
				if (filePaths[i].ToLower() == Path.Combine(currentFolder, currentFile).ToLower())
				{
					currentIndex = i;
					break;
				}
			}

			if (currentIndex == -1)
			{
				MessageBox.Show("Current file could not be found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (currentIndex == 0)
				{
					openFile(filePaths[filePaths.Length - 1]);
				}
				else
				{
					openFile(filePaths[currentIndex - 1]);
				}
			}
		}

		private void prevButton_Click(object sender, EventArgs e)
		{
			prevFile();
		}

		private string[] getCurrentFiles()
		{
			string[] exts = { ".png", ".jpg", ".jpeg", ".jpe", ".jfif", ".exif", ".gif", ".bmp", ".dib", ".rle", ".ico", ".webp", ".svg" };
			List<string> arlist = new List<string>();

			string[] allFiles = Directory.GetFiles(currentFolder);
			for(int i = 0; i < allFiles.Length; i++)
			{
				string ext = Path.GetExtension(allFiles[i]).ToLower();
				if (exts.Contains(ext))
				{
					arlist.Add(allFiles[i]);
				}
			}

			return arlist.ToArray();
		}

		private void openFirstFileInFolder()
		{
			string[] filePaths = getCurrentFiles();

			if(filePaths.Length > 0)
			{
				openFile(filePaths[0]);
			}
			else
			{
				MessageBox.Show("Directory is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void setAsDesktopButton_Click(object sender, EventArgs e)
		{
			WallpaperForm wallpaperForm = new WallpaperForm(originalImage, darkMode);
			if (alwaysOnTop)
			{
				wallpaperForm.TopMost = true;
			}
			wallpaperForm.ShowDialog();
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			DialogResult d = MessageBox.Show(
				"Are you sure you want to move this file to the Recyble Bin?",
				"Delete file",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (d == DialogResult.Yes)
			{
				string path = Path.Combine(currentFolder, currentFile);
				if (FileSystem.FileExists(path))
				{
					originalImage.Dispose();
					originalImage = null;
					pictureBox.Image.Dispose();
					pictureBox.Image = null;

					if (nextFile() <= 1)
					{
						closeFile();
					}
					FileSystem.DeleteFile(path, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin, UICancelOption.DoNothing);
				}
				else
				{
					MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void closeFile()
		{
			originalImage.Dispose();
			originalImage = null;
			pictureBox.Image.Dispose();
			pictureBox.Image = null;

			saveAsButton.Enabled = false;
			deleteButton.Enabled = false;
			prevButton.Enabled = false;
			nextButton.Enabled = false;
			slideshowButton.Enabled = false;
			autoZoomButton.Enabled = false;
			zoomInButton.Enabled = false;
			zoomOutButton.Enabled = false;
			rotateLeftButton.Enabled = false;
			rotateRightButton.Enabled = false;
			rotate180Button.Enabled = false;
			flipHorizontalButton.Enabled = false;
			flipVerticalButton.Enabled = false;
			copyButton.Enabled = false;
			setAsDesktopButton.Enabled = false;
			reloadButton.Enabled = false;
			infoButton.Enabled = false;
			externalButton.Enabled = false;
			printButton.Enabled = false;
			showFileButton.Enabled = false;
			miniViewButton.Enabled = false;

			zoomComboBox.Enabled = false;

			pleaseOpenLabel.Visible = true;

			directoryLabel.Text = "Folder: Empty";
			fileLabel.Text = "File: Empty";
			sizeLabel.Text = "Size: 0 x 0 px";
			dateCreatedLabel.Visible = false;
			dateModifiedLabel.Visible = false;

			setZoomText("Auto");
			setSlideshow(false);
			setFullscreen(false);
		}

		private void infoButton_Click(object sender, EventArgs e)
		{
			InfoForm infoForm = new InfoForm(originalImage, currentFolder, currentFile, darkMode);
			if (alwaysOnTop)
			{
				infoForm.TopMost = true;
			}
			infoForm.ShowDialog();
		}

		private void picturePanel_DoubleClick(object sender, EventArgs e)
		{
			fullscreenButton.PerformClick();
		}

		private void showOpenWithDialog(string path)
		{
			string args = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "shell32.dll");
			args += ",OpenAs_RunDLL " + path;
			Process.Start("rundll32.exe", args);
		}

		private void externalButton_Click(object sender, EventArgs e)
		{
			showOpenWithDialog(Path.Combine(currentFolder, currentFile));
		}

		private void applyDarkTheme()
		{
			ThemeManager.setDarkModeToControl(picturePanel.Handle);

			this.ForeColor = Color.White;
			this.BackColor = ThemeManager.BackColorDark;
			toolStrip1.BackColor = ThemeManager.MainColorDark;
			statusStrip1.BackColor = ThemeManager.SecondColorDark;

			openButton.Image = Properties.Resources.white_open;
			saveAsButton.Image = Properties.Resources.white_saveas;
			printButton.Image = Properties.Resources.white_print;
			deleteButton.Image = Properties.Resources.white_trash;
			externalButton.Image = Properties.Resources.white_popup;

			prevButton.Image = Properties.Resources.white_prev;
			showFileButton.Image = Properties.Resources.white_picfolder;
			nextButton.Image = Properties.Resources.white_next;
			slideshowButton.Image = Properties.Resources.white_slideshow;

			autoZoomButton.Image = Properties.Resources.white_autozoom;
			zoomInButton.Image = Properties.Resources.white_zoomin;
			zoomOutButton.Image = Properties.Resources.white_zoomout;

			editButton.Image = Properties.Resources.white_edit;
			editButton.DropDown.BackColor = ThemeManager.SecondColorDark;
			editButton.DropDown.ForeColor = Color.White;
			rotateLeftButton.Image = Properties.Resources.white_rotatel;
			rotateRightButton.Image = Properties.Resources.white_rotater;
			flipHorizontalButton.Image = Properties.Resources.white_fliph;
			flipVerticalButton.Image = Properties.Resources.white_flipv;
			rotate180Button.Image = Properties.Resources.white_degree;
			resizeButton.Image = Properties.Resources.white_size;
			cropButton.Image = Properties.Resources.white_crop;

			screenshotButton.Image = Properties.Resources.white_screenshot;
			infoButton.Image = Properties.Resources.white_info;
			copyButton.Image = Properties.Resources.white_copy;
			pasteButton.Image = Properties.Resources.white_paste;

			checkboardButton.Image = Properties.Resources.white_grid;
			fullscreenButton.Image = Properties.Resources.white_fullscreen;
			onTopButton.Image = Properties.Resources.white_ontop;
			miniViewButton.Image = Properties.Resources.white_miniview;

			moreButton.Image = Properties.Resources.white_more;
			moreButton.DropDown.BackColor = ThemeManager.SecondColorDark;
			moreButton.DropDown.ForeColor = Color.White;
			setAsDesktopButton.Image = Properties.Resources.white_desktop;
			aboutButton.Image = Properties.Resources.white_about;
			reloadButton.Image = Properties.Resources.white_sync;
			newWindowButton.Image = Properties.Resources.white_newwindow;
			settingsButton.Image = Properties.Resources.white_settings;

			directoryLabel.Image = Properties.Resources.white_picfolder;
			fileLabel.Image = Properties.Resources.white_imgfile;
			sizeLabel.Image = Properties.Resources.white_size;
			zoomLabel.Image = Properties.Resources.white_zoom;
			dateCreatedLabel.Image = Properties.Resources.white_clock;
			dateModifiedLabel.Image = Properties.Resources.white_history;
			hasChangesLabel.Image = Properties.Resources.white_erase;

			typeOpsButton.Image = Properties.Resources.white_options;
			typeOpsButton.BackColor = ThemeManager.SecondColorDark;
			typeOpsButton.ForeColor = Color.White;
		}

		private void printButton_Click(object sender, EventArgs e)
		{
			setSlideshow(false);
			PrintForm pf = new PrintForm(printDocument1, darkMode);
			pf.Owner = this;
			if (alwaysOnTop)
			{
				pf.TopMost = true;
			}
			if (pf.ShowDialog() == DialogResult.OK)
			{
				if (printDialog1.ShowDialog() == DialogResult.OK)
				{
					printDocument1.Print();
				}
			}
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			RectangleF marginBounds = e.MarginBounds;
			RectangleF printableArea = e.PageSettings.PrintableArea;

			int availableWidth = (int)Math.Floor(printDocument1.OriginAtMargins
				? marginBounds.Width
				: (e.PageSettings.Landscape
					? printableArea.Height
					: printableArea.Width));

			int availableHeight = (int)Math.Floor(printDocument1.OriginAtMargins
				? marginBounds.Height
				: (e.PageSettings.Landscape
					? printableArea.Width
					: printableArea.Height));

			if (availableWidth > originalImage.Width && availableHeight > originalImage.Height)
			{
				int x = 0;
				int y = 0;
				if (printCenterImage)
				{
					x = (availableWidth - originalImage.Width) / 2;
					y = (availableHeight - originalImage.Height) / 2;
				}
				e.Graphics.DrawImage(originalImage, x, y, originalImage.Width, originalImage.Height);
			} 
			else
			{
				double scaleW = availableWidth / (double) originalImage.Width;
				double scaleH = availableHeight / (double) originalImage.Height;

				if (scaleW < scaleH)
				{
					int x = 0;
					int y = 0;
					if (printCenterImage)
					{
						x = (availableWidth - Convert.ToInt32(originalImage.Width * scaleW)) / 2;
						y = (availableHeight - Convert.ToInt32(originalImage.Height * scaleW)) / 2;
					}
					e.Graphics.DrawImage(originalImage, x, y, availableWidth, Convert.ToInt32(originalImage.Height * scaleW));
				}
				else
				{
					int x = 0;
					int y = 0;
					if (printCenterImage)
					{
						x = (availableWidth - Convert.ToInt32(originalImage.Width * scaleH)) / 2;
						y = (availableHeight - Convert.ToInt32(originalImage.Height * scaleH)) / 2;
					}
					e.Graphics.DrawImage(originalImage, x, y, Convert.ToInt32(originalImage.Width * scaleH), availableHeight);
				}
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(imageChanged)
			{
				DialogResult window = MessageBox.Show(
					"All unsaved data will be lost.\nAre you sure you want to close the application?",
					"Warning",
					MessageBoxButtons.YesNo, 
					MessageBoxIcon.Question
				);

				e.Cancel = (window == DialogResult.No);
			}
		}

		private void showFileButton_Click(object sender, EventArgs e)
		{
			string path = Path.Combine(currentFolder, currentFile);
			if (FileSystem.FileExists(path))
			{
				string argument = "/select, \"" + path + "\"";
				Process.Start("explorer.exe", argument);
			}
			else
			{
				MessageBox.Show("Current file could not be found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void checkboardButton_Click(object sender, EventArgs e)
		{
			setCheckboardBackground(!checkboardBackground, true);
		}

		private void zoomInButton_MouseDown(object sender, MouseEventArgs e)
		{
			zoomInTimer.Start();
		}

		private void zoomOutButton_MouseDown(object sender, MouseEventArgs e)
		{
			zoomOutTimer.Start();
		}

		private void zoomOutButton_MouseUp(object sender, EventArgs e)
		{
			zoomOutTimer.Stop();
		}

		private void zoomInButton_MouseUp(object sender, EventArgs e)
		{
			zoomInTimer.Stop();
		}

		private void MainForm_Resize(object sender, EventArgs e)
		{
			if (!autoZoom)
			{
				updatePictureBoxLocation();
			}
		}

		private void showSuggestion(string text)
		{
			suggestionLabel.Text = text;
			suggestionLabel.Visible = true;

			if (suggestionTimer != null)
			{
				suggestionTimer.Dispose();
			}
			suggestionTimer = new System.Threading.Timer((obj) =>
			{
				hideSuggestion();
				
			}, null, 3000, System.Threading.Timeout.Infinite);
		}

		private void hideSuggestion()
		{
			suggestionTimer.Dispose();
			suggestionLabel.Invoke((MethodInvoker)(() => {
				suggestionLabel.Text = string.Empty;
				suggestionLabel.Visible = false;
			}));
		}

		private void slideshowButton_Click(object sender, EventArgs e)
		{
			setSlideshow(!slideshow);
		}

		private void typeOpsButton_Click(object sender, EventArgs e)
		{
			Button b = sender as Button;
			string type = b.Text.Substring(0, b.Text.IndexOf(' ')).ToLower();

			if (type == "svg")
			{
				SvgOpsForm sof = new SvgOpsForm(Path.Combine(currentFolder, currentFile), pictureBox.Image.Width, pictureBox.Image.Height, darkMode);
				sof.Owner = this;
				sof.ShowDialog();
			}
		}

		private void reloadButton_Click(object sender, EventArgs e)
		{
			openFile(Path.Combine(currentFolder, currentFile));
		}

		private void newWindowButton_Click(object sender, EventArgs e)
		{
			NewWindow();
		}

		private void NewWindow()
		{
			Process.Start(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "quick-picture-viewer.exe"));
		}

		private void rotate180Button_Click(object sender, EventArgs e)
		{
			originalImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
			pictureBox.Image = originalImage;
			setZoomText("Auto");
			setImageChanged(true);
		}

		private void miniViewButton_Click(object sender, EventArgs e)
		{
			this.Hide();

			MiniViewForm mvf = new MiniViewForm(originalImage, this.Text, checkboardBackground);
			mvf.Owner = this;
			mvf.Show();
		}

		private void settingsButton_Click(object sender, EventArgs e)
		{
			SettingsForm settingsBox = new SettingsForm(darkMode);
			settingsBox.Owner = this;
			if (alwaysOnTop)
			{
				settingsBox.TopMost = true;
			}
			settingsBox.ShowDialog();
		}

		private void typeOpsButton_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (!e.Alt && !e.Shift && !e.Control)
			{
				if (e.KeyCode == Keys.Left)
				{
					prevButton.PerformClick();
				}
				else if (e.KeyCode == Keys.Right)
				{
					nextButton.PerformClick();
				}
				else if (e.KeyCode == Keys.Down)
				{
					zoomOut();
				}
				else if (e.KeyCode == Keys.Up)
				{
					zoomIn();
				}
			}
		}

		private void typeOpsButton_VisibleChanged(object sender, EventArgs e)
		{
			if (typeOpsButton.Visible)
			{
				typeOpsButton.Focus();
			}
		}
	}
}
