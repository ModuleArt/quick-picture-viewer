using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GitHubUpdate;

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

		public MainForm(string openPath)
		{
			InitializeComponent();
			this.openPath = openPath;
		}

		private void openButton_Click_1(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				openFile(openFileDialog1.FileName);
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			if(!string.IsNullOrEmpty(openPath))
			{
				if(File.GetAttributes(openPath).HasFlag(FileAttributes.Directory))
				{
					currentFolder = openPath;
					openFirstFileInFolder();
				}
				else
				{
					openFile(openPath);
				}
			}

			toolStrip1.Renderer = new ToolStripOverride();

			picturePanel.MouseWheel += new MouseEventHandler(picturePanel_MouseWheel);

			if (ThemeManager.isDarkTheme())
			{
				applyDarkTheme();
			}

			checkForUpdates(false);
		}

		public async void checkForUpdates(bool showUpToDateDialog)
		{
			var checker = new UpdateChecker("ModuleArt", "quick-picture-viewer");

			UpdateType update = await checker.CheckUpdate();

			if (update == UpdateType.None)
			{
				if (showUpToDateDialog)
				{
					MessageBox.Show("Application is up to date", "Updator", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				var result = new UpdateNotifyDialog(checker).ShowDialog();
				if (result == DialogResult.Yes)
				{
					checker.DownloadAsset("QuickPictureViewer-Setup.msi");
				}
			}
		}

		private void openFile(string path)
		{
			try
			{
				dateCreatedLabel.Text = "Created: " + File.GetCreationTime(path).ToShortDateString() + " / " + File.GetCreationTime(path).ToLongTimeString();
				dateModifiedLabel.Text = "Modified: " + File.GetLastWriteTime(path).ToShortDateString() + " / " + File.GetLastWriteTime(path).ToLongTimeString();

				openImage(new Bitmap(path), Path.GetDirectoryName(path), Path.GetFileName(path));
			}
			catch
			{
				MessageBox.Show("Unable to open this file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void openImage(Bitmap bitmap, string directoryName, string fileName)
		{
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
				deleteButton.Enabled = false;
				externalButton.Enabled = false;
			}
			else
			{
				currentFolder = directoryName;
				currentFile = fileName;
				directoryLabel.Text = "Folder: " + directoryName;
				sizeLabel.Text = "Size: " + width.ToString() + " x " + height.ToString() + " px (" + bytesToSize(Path.Combine(directoryName, fileName)) + ")";

				nextButton.Enabled = true;
				prevButton.Enabled = true;
				deleteButton.Enabled = true;
				externalButton.Enabled = true;
			}

			this.Text = fileName + " - Quick Picture Viewer";

			zoomInButton.Enabled = true;
			zoomOutButton.Enabled = true;
			flipVerticalButton.Enabled = true;
			flipHorizontalButton.Enabled = true;
			rotateLeftButton.Enabled = true;
			rotateRightButton.Enabled = true;
			saveAsButton.Enabled = true;
			copyButton.Enabled = true;
			autoZoomButton.Enabled = true;
			setAsDesktopButton.Enabled = true;
			infoButton.Enabled = true;
			printButton.Enabled = true;

			zoomComboBox.Enabled = true;

			setZoomText("Auto");
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
			setZoomText((zoomFactor + 5).ToString() + "%");
		}

		private void zoomOut()
		{
			setZoomText((zoomFactor - 5).ToString() + "%");
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
			zoomComboBox.Text = text;
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
				setZoomText("100%");
			}
			else
			{
				setZoomText("Auto");
			}
		}

		private void aboutButton_Click(object sender, EventArgs e)
		{
			setAlwaysOnTop(false);
			AboutForm aboutBox = new AboutForm();
			aboutBox.Owner = this;
			aboutBox.ShowDialog();
		}

		private void setAlwaysOnTop(bool b)
		{
			alwaysOnTop = b;
			this.TopMost = b;
			onTopButton.Checked = b;

			if(b)
			{
				setFullscreen(false);
			}
		}

		private void flipVerticalButton_Click(object sender, EventArgs e)
		{
			originalImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
			pictureBox.Image = originalImage;
			setZoomText("Auto");
		}

		private void flipHorizontalButton_Click(object sender, EventArgs e)
		{
			originalImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
			pictureBox.Image = originalImage;
			setZoomText("Auto");
		}

		private void rotateLeftButton_Click(object sender, EventArgs e)
		{
			originalImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
			pictureBox.Image = originalImage;
			setZoomText("Auto");
		}

		private void rotateRightButton_Click(object sender, EventArgs e)
		{
			originalImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
			pictureBox.Image = originalImage;
			setZoomText("Auto");
		}

		private void saveAsButton_Click(object sender, EventArgs e)
		{
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
				}
				fs.Close();
			}
		}

		private void copyButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetImage(originalImage);
		}

		private void pasteButton_Click(object sender, EventArgs e)
		{
			if (Clipboard.ContainsImage())
			{
				openImage(new Bitmap(Clipboard.GetImage()), null, "From clipboard");
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
				panelMouseDownLocation = new Point(
					this.PointToClient(Cursor.Position).X + picturePanel.HorizontalScroll.Value,
					this.PointToClient(Cursor.Position).Y + picturePanel.VerticalScroll.Value
				);
			}
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
				this.FormBorderStyle = FormBorderStyle.None;
				this.WindowState = FormWindowState.Maximized;

				picturePanel.Dock = DockStyle.Fill;
				pictureBox.BackColor = Color.Black;

				setAlwaysOnTop(false);
			}
			else
			{
				this.FormBorderStyle = FormBorderStyle.Sizable;

				picturePanel.Dock = DockStyle.None;
				pictureBox.BackColor = Color.Transparent;
			}
		}

		private void zoomComboBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (zoomComboBox.Text == "Auto")
				{
					setZoomFactor(100);
					setAutoZoom(true);
				}
				else
				{
					string substr = zoomComboBox.Text.Replace("%", "");
					int zoom = int.Parse(substr);

					if (zoom < 5)
					{
						zoom = 5;
						setZoomText(zoom.ToString() + "%");
					}
					else
					{
						if (zoom > 500)
						{
							zoom = 500;
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
					if (e.KeyCode == Keys.R)
					{
						rotateLeftButton.PerformClick();
					}
					else if (e.KeyCode == Keys.H)
					{
						flipVerticalButton.PerformClick();
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
					else if (e.KeyCode == Keys.R)
					{
						rotateRightButton.PerformClick();
					}
					else if (e.KeyCode == Keys.H)
					{
						flipHorizontalButton.PerformClick();
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
					else if (e.KeyCode == Keys.B)
					{
						setAsDesktopButton.PerformClick();
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
			else
			{
				if (e.KeyCode == Keys.F)
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
				else if (e.KeyCode == Keys.F1)
				{
					aboutButton.PerformClick();
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
			}
		}

		private void MainForm_DragDrop(object sender, DragEventArgs e)
		{
			Bitmap bitmap = e.Data.GetData(DataFormats.Bitmap) as Bitmap;
			string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];

			if (bitmap != null)
			{
				openImage(bitmap, null, "Dragged image");
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
			setAlwaysOnTop(!alwaysOnTop);
		}

		private void screenshotButton_Click(object sender, EventArgs e)
		{
			this.Hide();

			Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
			using (Graphics g = Graphics.FromImage(bmp))
			{
				g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);

				openImage(bmp, null, "Captured screen");
			}

			this.Show();
		}

		private int nextFile()
		{
			string[] filePaths = getCurrentFiles();

			int currentIndex = 0;
			for (int i = 0; i < filePaths.Length; i++)
			{
				if (filePaths[i] == Path.Combine(currentFolder, currentFile))
				{
					currentIndex = i;
					break;
				}
			}

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

		private void nextButton_Click(object sender, EventArgs e)
		{
			nextFile();
		}

		private void prevButton_Click(object sender, EventArgs e)
		{
			string[] filePaths = getCurrentFiles();

			int currentIndex = 0;
			for (int i = 0; i < filePaths.Length; i++)
			{
				if (filePaths[i] == Path.Combine(currentFolder, currentFile))
				{
					currentIndex = i;
					break;
				}
			}

			if (currentIndex == 0)
			{
				openFile(filePaths[filePaths.Length - 1]);
			}
			else
			{
				openFile(filePaths[currentIndex - 1]);
			}
		}

		private string[] getCurrentFiles()
		{
			string[] exts = { ".png", ".jpg", ".jpeg", ".jpe", ".jfif", ".exif", ".gif", ".bmp", ".dib", ".rle" };
			List<string> arlist = new List<string>();

			string[] allFiles = Directory.GetFiles(currentFolder);
			for(int i = 0; i < allFiles.Length; i++)
			{
				string ext = Path.GetExtension(allFiles[i]);
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
			setAlwaysOnTop(false);
			WallpaperForm wallpaperForm = new WallpaperForm(originalImage);
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
			autoZoomButton.Enabled = false;
			zoomInButton.Enabled = false;
			zoomOutButton.Enabled = false;
			rotateLeftButton.Enabled = false;
			rotateRightButton.Enabled = false;
			flipHorizontalButton.Enabled = false;
			flipVerticalButton.Enabled = false;
			copyButton.Enabled = false;
			setAsDesktopButton.Enabled = false;
			infoButton.Enabled = false;
			externalButton.Enabled = false;
			printButton.Enabled = false;

			zoomComboBox.Enabled = false;

			directoryLabel.Text = "Folder: Empty";
			fileLabel.Text = "File: Empty";
			sizeLabel.Text = "Size: 0 x 0 px";
			dateCreatedLabel.Text = "Created: Unknown";
			dateModifiedLabel.Text = "Modified: Unknown";

			setZoomText("Auto");
		}

		private string bytesToSize(string path)
		{
			string[] sizes = { "B", "KB", "MB", "GB", "TB" };
			double len = new FileInfo(path).Length;
			int order = 0;
			while (len >= 1024 && order < sizes.Length - 1)
			{
				order++;
				len = len / 1024;
			}

			return String.Format("{0:0.##} {1}", len, sizes[order]);
		}

		private void infoButton_Click(object sender, EventArgs e)
		{
			setAlwaysOnTop(false);
			InfoForm infoForm = new InfoForm(originalImage, currentFolder, currentFile);
			infoForm.ShowDialog();
		}

		private void picturePanel_DoubleClick(object sender, EventArgs e)
		{
			fullscreenButton.PerformClick();
		}

		private void showOpenWithDialog(string path)
		{
			var args = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "shell32.dll");
			args += ",OpenAs_RunDLL " + path;
			Process.Start("rundll32.exe", args);
		}

		private void externalButton_Click(object sender, EventArgs e)
		{
			showOpenWithDialog(Path.Combine(currentFolder, currentFile));
		}

		private void applyDarkTheme()
		{
			this.BackColor = Color.Black;

			this.ForeColor = Color.White;

			toolStrip1.BackColor = Color.Black;

			picturePanel.BackColor = Color.FromArgb(32, 32, 32);

			statusStrip1.BackColor = Color.FromArgb(51, 51, 51);
		}

		private void MainForm_SizeChanged(object sender, EventArgs e)
		{
			updatePictureBoxLocation();
		}

		private void printButton_Click(object sender, EventArgs e)
		{
			if (printDialog1.ShowDialog() == DialogResult.OK)
			{
				if (currentFile != null) 
				{
					printDocument1.DocumentName = currentFile;
				}
				printDocument1.Print();
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
				e.Graphics.DrawImage(originalImage, 0, 0, originalImage.Width, originalImage.Height);
			} 
			else
			{
				double scaleW = availableWidth / (double) originalImage.Width;
				double scaleH = availableHeight / (double) originalImage.Height;

				Console.WriteLine("scaleW = " + scaleW);
				Console.WriteLine("scaleH = " + scaleH);

				if (scaleW < scaleH)
				{
					e.Graphics.DrawImage(originalImage, 0, 0, availableWidth, Convert.ToInt32(originalImage.Height * scaleW));
				}
				else
				{
					e.Graphics.DrawImage(originalImage, 0, 0, Convert.ToInt32(originalImage.Width * scaleH), availableHeight);
				}
			}
		}
	}
}
