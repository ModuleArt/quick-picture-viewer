using Microsoft.VisualBasic.FileIO;
using QuickLibrary;
using Svg;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using System.Reflection;

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
		private int slideshowCounter = 0;
		private GCHandle tmpGcHandle;
		private bool dragImage = false;
		private System.Timers.Timer zoomInTimer = new System.Timers.Timer();
		private System.Timers.Timer zoomOutTimer = new System.Timers.Timer();
		private System.Timers.Timer slideshowTimer = new System.Timers.Timer();
		private System.Threading.Timer suggestionTimer;

		public bool printCenterImage = true;
		public ResourceManager resMan;

		public MainForm(string openPath, bool darkMode)
		{
			if (darkMode)
			{
				this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			this.darkMode = darkMode;
			this.openPath = openPath;

			InitializeComponent();

			zoomInTimer.Elapsed += new ElapsedEventHandler(zoomInTimer_Event);
			zoomInTimer.Interval = 100;

			zoomOutTimer.Elapsed += new ElapsedEventHandler(zoomOutTimer_Event);
			zoomOutTimer.Interval = 100;

			slideshowTimer.Elapsed += new ElapsedEventHandler(slideshowTimer_Event);
			slideshowTimer.Interval += 1000;

			picturePanel.MouseWheel += picturePanel_MouseWheel;

			zoomTextBox.TextBox.AutoSize = false;
			zoomTextBox.Height = 21;
			zoomTextBox.TextBox.MouseWheel += TextBox_MouseWheel;

			SetDarkMode(darkMode);
			InitLanguage();

			closeFile();
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if (m.Msg == NativeMethodsManager.WM_SYSCOMMAND)
			{
				if (m.WParam == (IntPtr)NativeMethodsManager.SC_MAXIMIZE)
				{
					this.OnResizeEnd(EventArgs.Empty);
				}
			}
		}

		private void InitLanguage()
		{
			if (string.IsNullOrEmpty(Properties.Settings.Default.Language))
			{
				switch(CultureInfo.CurrentCulture.TwoLetterISOLanguageName)
				{
					case "en":
					case "es":
					case "ru":
						resMan = new ResourceManager("quick_picture_viewer.languages.lang_" + CultureInfo.CurrentCulture.TwoLetterISOLanguageName, Assembly.GetExecutingAssembly());
						Properties.Settings.Default.Language = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
						break;
					default:
						resMan = new ResourceManager("quick_picture_viewer.languages.lang_en", Assembly.GetExecutingAssembly());
						Properties.Settings.Default.Language = "en";
						break;
				}

				Properties.Settings.Default.Save();
			}
			else
			{
				resMan = new ResourceManager("quick_picture_viewer.languages.lang_" + Properties.Settings.Default.Language, Assembly.GetExecutingAssembly());
			}

			pleaseOpenLabel.Text = resMan.GetString("please-open-image");

			moreButton.Text = resMan.GetString("more-options");
			aboutBtn.Text = resMan.GetString("about") + " ...";
			settingsButton.Text = resMan.GetString("settings") + " ...";
			settingsButton.ShortcutKeyDisplayString = "Ctrl+" + resMan.GetString("comma");
			newWindowButton.Text = resMan.GetString("new-window");
			framelessBtn.Text = resMan.GetString("frameless-mode");
			onTopButton.Text = resMan.GetString("always-on-top");
			backColorBtn.Text = resMan.GetString("background-color");
			backClearBtn.Text = resMan.GetString("clear");
			backCustomBtn.Text = resMan.GetString("choose-color") + " ...";
			actualSizeBtn.Text = resMan.GetString("zoom-to-actual-size") + " (100%)";
			setAsDesktopButton.Text = resMan.GetString("set-as-desktop-background") + " ...";
			printButton.Text = resMan.GetString("print") + " ...";
			deleteBtn.Text = resMan.GetString("move-to-trash") + " ...";
			reloadButton.Text = resMan.GetString("reload-file");

			editButton.Text = resMan.GetString("edit-image");
			flipHorizontalButton.Text = resMan.GetString("flip-horizontal");
			flipVerticalButton.Text = resMan.GetString("flip-vertical");
			rotateRightButton.Text = resMan.GetString("rotate-right");
			rotateLeftButton.Text = resMan.GetString("rotate-left");
			rotate180Button.Text = resMan.GetString("rotate-180");

			copyButton.Text = resMan.GetString("copy");
			copyImageButton.Text = resMan.GetString("copy-image");
			copyFileBtn.Text = resMan.GetString("copy-file");

			externalBtn.Text = resMan.GetString("open-external");
			externalRunBtn.Text = resMan.GetString("open-with-default");
			externalChooseBtn.Text = resMan.GetString("open-with-choose") + " ...";

			openButton.Text = resMan.GetString("open-file") + " | Ctrl+O";
			saveAsButton.Text = resMan.GetString("save-as") + " | Ctrl+S";
			pasteButton.Text = resMan.GetString("paste-image") + " | Ctrl+V";
			screenshotButton.Text = resMan.GetString("capture-screen") + " | F12";
			checkboardButton.Text = resMan.GetString("checkboard-background") + " | Ctrl+B";
			fullscreenButton.Text = resMan.GetString("fullscreen") + " | F";
			miniViewButton.Text = resMan.GetString("picture-in-picture") + " | Ctrl+Shift+P";
			autoZoomButton.Text = resMan.GetString("auto-zoom") + " | Ctrl+A";
			zoomInButton.Text = resMan.GetString("zoom-in") + " | Ctrl+" + resMan.GetString("plus");
			zoomOutButton.Text = resMan.GetString("zoom-out") + " | Ctrl+" + resMan.GetString("minus");
			infoButton.Text = resMan.GetString("image-info") + " | Ctrl+I";
			slideshowButton.Text = resMan.GetString("slideshow") + " | Ctrl+Shift+S";
			showFileButton.Text = resMan.GetString("show-file-explorer") + " | Ctrl+Shift+L";
			prevButton.Text = resMan.GetString("prev-image") + " | " + resMan.GetString("left-arrow");
			nextButton.Text = resMan.GetString("next-image") + " | " + resMan.GetString("right-arrow");

			hasChangesLabel.Text = resMan.GetString("not-saved");
			zoomLabel.Text = resMan.GetString("zoom") + ": " + resMan.GetString("auto");

			pluginsBtn.Text = resMan.GetString("plugins");
			pluginManBtn.Text = resMan.GetString("plugin-manager");
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
			slideshowCounter++;
			if (slideshowCounter >= Properties.Settings.Default.SlideshowTime)
			{
				slideshowCounter = 0;
				nextFile();
			}

			if (Properties.Settings.Default.SlideshowCounter)
			{
				if ((Properties.Settings.Default.SlideshowTime - slideshowCounter) <= 1)
				{
					showSuggestion(resMan.GetString("next-image-in-1-second"));
				}
				else
				{
					showSuggestion(string.Format(resMan.GetString("next-image-in-x-seconds"), (Properties.Settings.Default.SlideshowTime - slideshowCounter)));
				}
			}
		}

		private void openButton_Click_1(object sender, EventArgs e)
		{
			setSlideshow(false);
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				openFile(openFileDialog1.FileName);
			}
			openFileDialog1.Dispose();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(openPath))
				{
					if (Properties.Settings.Default.StartupAction == 1  && Clipboard.ContainsImage())
					{
						pasteButton.PerformClick();
						showSuggestion(resMan.GetString("image-pasted-from-clipboard"));
					} 
				}
				else
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
				MessageBox.Show(resMan.GetString("unable-to-open-file"), resMan.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			if (Properties.Settings.Default.CheckForUpdates)
			{
				checkForUpdates(false);
			}

			setAlwaysOnTop(Properties.Settings.Default.AlwaysOnTop, false);
			setCheckboardBackground(Properties.Settings.Default.CheckboardBackground, false);

			if (Properties.Settings.Default.BackColor.Length > 0)
			{
				picturePanel.BackColor = Color.FromArgb(Convert.ToInt32(Properties.Settings.Default.BackColor));
			}
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
						MessageBox.Show(resMan.GetString("app-is-up-to-date"), resMan.GetString("updator"), MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					UpdateForm updateDialog = new UpdateForm(checker, "Quick Picture Viewer", darkMode);
					updateDialog.Owner = this;
					updateDialog.TopMost = alwaysOnTop;

					DialogResult result = updateDialog.ShowDialog();
					if (result == DialogResult.Yes)
					{
						DownloadForm downloadBox = new DownloadForm(checker.GetAssetUrl("QuickPictureViewer-Setup.exe"), darkMode);
						downloadBox.Owner = this;
						downloadBox.TopMost = alwaysOnTop;
						downloadBox.ShowDialog();
					}
					else
					{
						updateDialog.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				if (showUpToDateDialog)
				{
					MessageBox.Show(resMan.GetString("update-failed"), resMan.GetString("updator"), MessageBoxButtons.OK, MessageBoxIcon.Information);
					Console.WriteLine(ex);
				}
			}
		}

		private void showTypeOpsButton(bool show, string type)
		{
			typeOpsButton.Invoke((MethodInvoker)(() => {
				typeOpsButton.Visible = show;

				if (show)
				{
					typeOpsButton.Text = " " + type + " " + resMan.GetString("type-options");
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
						WebPDecoderOptions decoderOptions = new WebPDecoderOptions();
						decoderOptions.use_threads = 1;
						decoderOptions.alpha_dithering_strength = 100;
						openImage(webp.Decode(rawWebP, decoderOptions), Path.GetDirectoryName(path), Path.GetFileName(path));
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
				else if (ext == ".dds" || ext == ".tga")
				{
					openDdsOrTga(path);
				}
				else
				{
					if (ext == ".gif")
					{
						openImage(new Bitmap(path), Path.GetDirectoryName(path), Path.GetFileName(path));
					}
					else
					{
						using (Image img = Image.FromFile(path, true))
						{
							openImage(new Bitmap(path), Path.GetDirectoryName(path), Path.GetFileName(path));
						}

						//Stream imageStreamSource = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
						//JpegBitmapDecoder jpegDecoder = new JpegBitmapDecoder(imageStreamSource, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
						//BitmapSource bitmapSource = jpegDecoder.Frames[0];

						//using (MemoryStream outStream = new MemoryStream())
						//{
						//	BitmapEncoder enc = new BmpBitmapEncoder();
						//	enc.Frames.Add(BitmapFrame.Create(bitmapSource));
						//	enc.Save(outStream);
						//	openImage(new Bitmap(outStream), Path.GetDirectoryName(path), Path.GetFileName(path));
						//}
					}

					showTypeOpsButton(false, null);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(resMan.GetString("unable-to-open-file"), resMan.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
				Console.WriteLine(ex);
			}
		}

		public void openDdsOrTga(string path)
		{
			try
			{
				using (var image = Pfim.Pfim.FromFile(path))
				{
					PixelFormat format;

					switch (image.Format)
					{
						case Pfim.ImageFormat.Rgba32:
							format = PixelFormat.Format32bppArgb;
							break;
						case Pfim.ImageFormat.Rgb24:
							format = PixelFormat.Format24bppRgb;
							break;
						case Pfim.ImageFormat.Rgba16:
							format = PixelFormat.Format16bppArgb1555;
							break;
						case Pfim.ImageFormat.Rgb8:
							format = PixelFormat.Format8bppIndexed;
							break;
						default:
							throw new NotImplementedException();
					}

					try
					{
						if (tmpGcHandle != null && tmpGcHandle.IsAllocated)
						{
							tmpGcHandle.Free();
						}

						tmpGcHandle = GCHandle.Alloc(image.Data, GCHandleType.Pinned);
						var data = Marshal.UnsafeAddrOfPinnedArrayElement(image.Data, 0);
						var bitmap = new Bitmap(image.Width, image.Height, image.Stride, format, data);
						openImage(bitmap, Path.GetDirectoryName(path), Path.GetFileName(path));
					}
					catch (Exception ex)
					{
						MessageBox.Show(resMan.GetString("dds-memory-error"), resMan.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
						Console.WriteLine(ex);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(resMan.GetString("unable-open-dds"), resMan.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
				Console.WriteLine(ex);
			}
		}

		public void openSvg(string path, int width, int height)
		{
			try
			{
				SvgDocument svgDocument = SvgDocument.Open(path);
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
				MessageBox.Show(resMan.GetString("unable-open-svg"), resMan.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
				Console.WriteLine(ex);
			}
		}

		private void openImage(Bitmap bitmap, string directoryName, string fileName)
		{
			if (bitmap != originalImage)
			{
				if (imageChanged)
				{
					DialogResult window = MessageBox.Show(
						resMan.GetString("unsaved-data-lost"),
						resMan.GetString("warning"),
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

				const int exifOrientationID = 0x112; //274
				if (bitmap.PropertyIdList.Contains(exifOrientationID))
				{
					var prop = bitmap.GetPropertyItem(exifOrientationID);
					int val = BitConverter.ToUInt16(prop.Value, 0);
					var rot = RotateFlipType.RotateNoneFlipNone;

					if (val == 3 || val == 4)
						rot = RotateFlipType.Rotate180FlipNone;
					else if (val == 5 || val == 6)
						rot = RotateFlipType.Rotate90FlipNone;
					else if (val == 7 || val == 8)
						rot = RotateFlipType.Rotate270FlipNone;

					if (val == 2 || val == 4 || val == 5 || val == 7)
						rot |= RotateFlipType.RotateNoneFlipX;

					if (rot != RotateFlipType.RotateNoneFlipNone)
						bitmap.RotateFlip(rot);
				}

				originalImage = bitmap;
				pictureBox.Image = originalImage;

				width = pictureBox.Image.Size.Width;
				height = pictureBox.Image.Size.Height;
				fileLabel.Text = " " + resMan.GetString("file") + ": " + fileName;

				if (directoryName == null)
				{
					currentFolder = null;
					currentFile = null;
					directoryLabel.Text = " " + resMan.GetString("no-folder");
					sizeLabel.Text = " " + resMan.GetString("size") + ": " + width.ToString() + " x " + height.ToString() + " px";
				}
				else
				{
					string path = Path.Combine(directoryName, fileName);

					currentFolder = directoryName;
					currentFile = fileName;
					directoryLabel.Text = " " + resMan.GetString("folder") + ": " + directoryName;
					sizeLabel.Text = " " + resMan.GetString("size") + ": " + width.ToString() + " x " + height.ToString() + " px (" + Converter.PathToSize(path) + ")";

					dateCreatedLabel.Text = " " + resMan.GetString("created") + ": " + File.GetCreationTime(path).ToShortDateString() + " - " + File.GetCreationTime(path).ToLongTimeString();
					dateModifiedLabel.Text = " " + resMan.GetString("modified") + ": " + File.GetLastWriteTime(path).ToShortDateString() + " - " + File.GetLastWriteTime(path).ToLongTimeString();
				}

				nextButton.Enabled = directoryName != null;
				prevButton.Enabled = directoryName != null;
				slideshowButton.Enabled = directoryName != null;
				deleteBtn.Enabled = directoryName != null;
				externalRunBtn.Enabled = directoryName != null;
				externalChooseBtn.Enabled = directoryName != null;
				externalFavoriteBtn.Enabled = directoryName != null;
				showFileButton.Enabled = directoryName != null;
				copyFileBtn.Enabled = directoryName != null;
				reloadButton.Enabled = directoryName != null;
				dateCreatedLabel.Visible = directoryName != null;
				dateModifiedLabel.Visible = directoryName != null;

				this.Invoke((MethodInvoker)(() => this.Text = fileName + " - Quick Picture Viewer"));

				zoomInButton.Enabled = true;
				zoomOutButton.Enabled = true;
				actualSizeBtn.Enabled = true;
				flipVerticalButton.Enabled = true;
				flipHorizontalButton.Enabled = true;
				rotateLeftButton.Enabled = true;
				rotateRightButton.Enabled = true;
				rotate180Button.Enabled = true;
				saveAsButton.Enabled = true;
				copyImageButton.Enabled = true;
				autoZoomButton.Enabled = true;
				setAsDesktopButton.Enabled = true;
				infoButton.Enabled = true;
				printButton.Enabled = true;
				miniViewButton.Enabled = true;

				zoomTextBox.Enabled = true;

				pleaseOpenLabel.Invoke((MethodInvoker)(() => pleaseOpenLabel.Visible = false));

				if ((originalImage.Width < picturePanel.Width - 32) && (originalImage.Height < picturePanel.Height - 32))
				{
					if (zoomTextBox.Text == "100%")
					{
						setZoomFactor(100);
					}
					else
					{
						setZoomText("100%");
					}
				}
				else
				{
					setZoomText(resMan.GetString("auto"));
				}
			}
		}

		private void setImageChanged(bool b, string fakeName = "")
		{
			imageChanged = b;
			hasChangesLabel.Visible = b;

			if (string.IsNullOrEmpty(fakeName))
			{
				this.Text = currentFile + " - Quick Picture Viewer";
			}
			else
			{
				this.Text = fakeName + " - Quick Picture Viewer";
			}

			if (b)
			{
				this.Text = "* " + this.Text;
			}
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
			double zoomFactorX = picturePanel.Width / (double)originalImage.Width;
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

			zoomLabel.Text = " " + resMan.GetString("zoom") + ": " + zoomFactor.ToString() + "%";

			setAutoZoom(false);

			int newWidth = Convert.ToInt32(width * zoomFactor / 100);
			int newHeight = Convert.ToInt32(height * zoomFactor / 100);

			//int newScrollH = Convert.ToInt32(picturePanel.HorizontalScroll.Value * zoomFactor / 100);
			//int newScrollV = Convert.ToInt32(picturePanel.VerticalScroll.Value * zoomFactor / 100);

			Size newSize = new Size(newWidth, newHeight);

			pictureBox.Invoke((MethodInvoker)(() =>
			{
				pictureBox.Size = newSize;
				updatePictureBoxLocation();
			}));
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
			zoomTextBox.TextBox.Invoke((MethodInvoker)(() => zoomTextBox.Text = text));
		}

		private void setAutoZoom(bool b)
		{
			autoZoom = b;

			autoZoomButton.Checked = b;

			if (b)
			{
				pictureBox.Dock = DockStyle.Fill;

				zoomLabel.Text = " " + resMan.GetString("zoom") + ": " + resMan.GetString("auto");
			}
			else
			{
				pictureBox.Dock = DockStyle.None;
			}
		}

		private void autoZoomButton_Click(object sender, EventArgs e)
		{
			if (zoomTextBox.Text == resMan.GetString("auto"))
			{
				zoomToFit();
				setZoomText(zoomFactor + "%");
			}
			else
			{
				setZoomText(resMan.GetString("auto"));
			}
		}

		private void aboutButton_Click(object sender, EventArgs e)
		{
			AboutForm aboutBox = new AboutForm(darkMode);
			aboutBox.Owner = this;
			aboutBox.TopMost = alwaysOnTop;
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

			if (b)
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
				if (!fullscreen)
				{
					picturePanel.BackColor = Color.Transparent;
					Properties.Settings.Default.BackColor = "";
					Properties.Settings.Default.Save();

					if (darkMode)
					{
						picturePanel.BackgroundImage = Properties.Resources.checkboard_dark;
					}
					else
					{
						picturePanel.BackgroundImage = Properties.Resources.checkboard_light;
					}
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
			setZoomText(resMan.GetString("auto"));
			setImageChanged(true);
		}

		private void flipHorizontalButton_Click(object sender, EventArgs e)
		{
			originalImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
			pictureBox.Image = originalImage;
			setZoomText(resMan.GetString("auto"));
			setImageChanged(true);
		}

		private void rotateLeftButton_Click(object sender, EventArgs e)
		{
			originalImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
			pictureBox.Image = originalImage;
			setZoomText(resMan.GetString("auto"));
			setImageChanged(true);
		}

		private void rotateRightButton_Click(object sender, EventArgs e)
		{
			originalImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
			pictureBox.Image = originalImage;
			setZoomText(resMan.GetString("auto"));
			setImageChanged(true);
		}

		private void saveAsButton_Click(object sender, EventArgs e)
		{
			setSlideshow(false);

			if (currentFile != null)
			{
				saveFileDialog1.FileName = currentFile;
				saveFileDialog1.InitialDirectory = currentFolder;

				switch (Path.GetExtension(currentFile))
				{
					case ".png":
						saveFileDialog1.FilterIndex = 1;
						break;
					case ".jpg":
					case ".jpeg":
					case ".jpe":
					case ".jfif":
					case ".exif":
						saveFileDialog1.FilterIndex = 2;
						break;
					case ".gif":
						saveFileDialog1.FilterIndex = 3;
						break;
					case ".bmp":
					case ".dib":
					case ".rle":
						saveFileDialog1.FilterIndex = 4;
						break;
					case ".tiff":
					case ".tif":
						saveFileDialog1.FilterIndex = 5;
						break;
					case ".ico":
						saveFileDialog1.FilterIndex = 6;
						break;
					case ".webp":
						saveFileDialog1.FilterIndex = 7;
						break;
				}
			}

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				FileStream fs = (FileStream)saveFileDialog1.OpenFile();
				switch (saveFileDialog1.FilterIndex)
				{
					case 1:
						originalImage.Save(fs, ImageFormat.Png);
						break;
					case 2:
						originalImage.Save(fs, ImageFormat.Jpeg);
						break;
					case 3:
						originalImage.Save(fs, ImageFormat.Gif);
						break;
					case 4:
						originalImage.Save(fs, ImageFormat.Bmp);
						break;
					case 5:
						originalImage.Save(fs, ImageFormat.Tiff);
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
			saveFileDialog1.Dispose();
		}

		private void copyButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetImage(originalImage);
			showSuggestion(resMan.GetString("image-copied-to-clipboard"));
		}

		private void pasteButton_Click(object sender, EventArgs e)
		{
			if (Clipboard.ContainsImage())
			{
				openImage(new Bitmap(Clipboard.GetImage()), null, resMan.GetString("from-clipboard"));
				setImageChanged(true, resMan.GetString("from-clipboard"));
			}
			else if (Clipboard.ContainsData(DataFormats.FileDrop))
			{
				string path = ((string[]) Clipboard.GetData(DataFormats.FileDrop))[0];
				openFile(path);
			}
		}

		private void picturePanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (autoZoom)
				{
					this.AllowDrop = false;
					if (currentFile != null || originalImage != null)
					{
						dragImage = true;
					}
				}
				else
				{
					Cursor.Current = Cursors.SizeAll;

					panelMouseDownLocation = new Point(
						this.PointToClient(Cursor.Position).X + picturePanel.HorizontalScroll.Value,
						this.PointToClient(Cursor.Position).Y + picturePanel.VerticalScroll.Value
					);
				}
			}
		}

		private void picturePanel_MouseUp(object sender, MouseEventArgs e)
		{
			this.AllowDrop = true;
			Cursor.Current = Cursors.Default;
		}

		private void picturePanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (autoZoom)
				{
					if (dragImage)
					{
						if (currentFile != null)
						{
							string[] paths = { Path.Combine(currentFolder, currentFile) };
							this.DoDragDrop(new DataObject(DataFormats.FileDrop, paths), DragDropEffects.Copy);
						}
						else if (originalImage != null)
						{
							this.DoDragDrop(originalImage, DragDropEffects.Copy);
						}
						dragImage = false;
					}
				}
				else
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
		}

		private void picturePanel_MouseWheel(object sender, MouseEventArgs e)
		{
			if (originalImage != null)
			{
				if (Control.ModifierKeys == Keys.Control || Properties.Settings.Default.NoCtrlZoom)
				{
					if (e.Delta > 0)
					{
						zoomIn();
					}
					else if (e.Delta < 0)
					{
						zoomOut();
					}
				}
			}
		}

		private void TextBox_MouseWheel(object sender, MouseEventArgs e)
		{
			if (originalImage != null)
			{
				if (e.Delta > 0)
				{
					zoomIn();
				}
				else if (e.Delta < 0)
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

				picturePanel.Top = 0;
				picturePanel.Height = this.ClientSize.Height;
				picturePanel.BackColor = Color.Black;

				typeOpsButton.Left = this.ClientRectangle.Width + 27;
				pleaseOpenLabel.ForeColor = Color.White;

				this.FormBorderStyle = FormBorderStyle.None;
				this.WindowState = FormWindowState.Maximized;

				setAlwaysOnTop(false, true);

				showSuggestion(string.Format(resMan.GetString("press-to-exit-fullscreen"), "Esc"));
			}
			else
			{
				picturePanel.Cursor = Cursors.Default;

				picturePanel.Top = toolStrip1.Height;
				picturePanel.Height = this.ClientSize.Height - toolStrip1.Height - statusStrip1.Height;

				typeOpsButton.Left = this.ClientRectangle.Width - typeOpsButton.Width - 27;
				pleaseOpenLabel.ForeColor = this.ForeColor;

				this.FormBorderStyle = FormBorderStyle.Sizable;

				if (checkboardBackground)
				{
					picturePanel.BackColor = Color.Transparent;
					setCheckboardBackground(true, true);
				}
				else
				{
					if (Properties.Settings.Default.BackColor.Length > 0)
					{
						picturePanel.BackColor = Color.FromArgb(Convert.ToInt32(Properties.Settings.Default.BackColor));
					}
					else
					{
						picturePanel.BackColor = Color.Transparent;
					}
				}
			}

			setZoomText(resMan.GetString("auto"));
		}

		private void zoomComboBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (zoomTextBox.Text == resMan.GetString("auto"))
				{
					setAutoZoom(true);
				}
				else
				{
					string substr = zoomTextBox.Text.Replace("%", "");
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
			if (!zoomTextBox.Focused)
			{
				if (e.Control)
				{
					if (e.Shift)
					{
						if (e.KeyCode == Keys.L)
						{
							showFileButton.PerformClick();
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
						else if (e.KeyCode == Keys.B)
						{
							checkboardButton.PerformClick();
						}
						else if (e.KeyCode == Keys.S)
						{
							saveAsButton.PerformClick();
						}
						else if (e.KeyCode == Keys.A)
						{
							autoZoomButton.PerformClick();
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
					else if (e.KeyCode == Keys.Left)
					{
						prevButton.PerformClick();
					}
					else if (e.KeyCode == Keys.Right)
					{
						Console.WriteLine('r');
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
		}

		private void MainForm_DragDrop(object sender, DragEventArgs e)
		{
			Bitmap bitmap = e.Data.GetData(DataFormats.Bitmap) as Bitmap;
			string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];

			if (bitmap != null)
			{
				openImage(bitmap, null, resMan.GetString("dragged-image"));
				setImageChanged(true, resMan.GetString("dragged-image"));
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

				openImage(bmp, null, resMan.GetString("screenshot"));
				setImageChanged(true, resMan.GetString("screenshot"));
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
				MessageBox.Show(resMan.GetString("cur-file-not-found"), resMan.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				MessageBox.Show(resMan.GetString("cur-file-not-found"), resMan.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			string[] exts = { ".png", ".jpg", ".jpeg", ".jpe", ".jfif", ".exif", ".gif", ".bmp", ".dib", ".rle", ".ico", ".webp", ".svg", ".dds", ".tga" };
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
				MessageBox.Show(resMan.GetString("no-files-to-open"), resMan.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void setAsDesktopButton_Click(object sender, EventArgs e)
		{
			WallpaperForm wallpaperForm = new WallpaperForm(originalImage, darkMode);
			wallpaperForm.Owner = this;
			wallpaperForm.TopMost = alwaysOnTop;
			wallpaperForm.ShowDialog();
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			DialogResult d = MessageBox.Show(
				resMan.GetString("sure-move-to-trash"),
				resMan.GetString("delete-file"),
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
					MessageBox.Show(resMan.GetString("cur-file-not-found"), resMan.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void closeFile()
		{
			if (originalImage != null)
			{
				originalImage.Dispose();
				originalImage = null;
			}
			
			if (pictureBox.Image != null)
			{
				pictureBox.Image.Dispose();
				pictureBox.Image = null;
			}

			saveAsButton.Enabled = false;
			deleteBtn.Enabled = false;
			prevButton.Enabled = false;
			nextButton.Enabled = false;
			slideshowButton.Enabled = false;
			autoZoomButton.Enabled = false;
			zoomInButton.Enabled = false;
			zoomOutButton.Enabled = false;
			actualSizeBtn.Enabled = false;
			rotateLeftButton.Enabled = false;
			rotateRightButton.Enabled = false;
			rotate180Button.Enabled = false;
			flipHorizontalButton.Enabled = false;
			flipVerticalButton.Enabled = false;
			copyImageButton.Enabled = false;
			copyFileBtn.Enabled = false;
			setAsDesktopButton.Enabled = false;
			reloadButton.Enabled = false;
			infoButton.Enabled = false;
			externalRunBtn.Enabled = false;
			externalChooseBtn.Enabled = false;
			externalFavoriteBtn.Enabled = false;
			printButton.Enabled = false;
			showFileButton.Enabled = false;
			miniViewButton.Enabled = false;

			zoomTextBox.Enabled = false;

			pleaseOpenLabel.Visible = true;

			directoryLabel.Text = " " + resMan.GetString("no-folder");
			fileLabel.Text = " " + resMan.GetString("no-file");
			sizeLabel.Text = " " + resMan.GetString("size") + ": 0 x 0 px";
			dateCreatedLabel.Visible = false;
			dateModifiedLabel.Visible = false;

			setZoomText(resMan.GetString("auto"));
			setSlideshow(false);
			setFullscreen(false);
		}

		private void infoButton_Click(object sender, EventArgs e)
		{
			InfoForm infoForm = new InfoForm(originalImage, currentFolder, currentFile, darkMode);
			infoForm.Owner = this;
			infoForm.TopMost = alwaysOnTop;
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

		private void SetDarkMode(bool dark)
		{
			if (dark)
			{
				ThemeManager.setDarkModeToControl(picturePanel.Handle);

				this.ForeColor = Color.White;
				this.BackColor = ThemeManager.DarkBackColor;
				statusStrip1.BackColor = ThemeManager.DarkSecondColor;

				openButton.Image = Properties.Resources.white_open;
				saveAsButton.Image = Properties.Resources.white_saveas;
				printButton.Image = Properties.Resources.white_print;
				deleteBtn.Image = Properties.Resources.white_trash;

				externalBtn.Image = Properties.Resources.white_popup;
				externalBtn.DropDown.BackColor = ThemeManager.DarkSecondColor;
				externalBtn.DropDown.ForeColor = Color.White;
				externalRunBtn.Image = Properties.Resources.white_exe;
				externalChooseBtn.Image = Properties.Resources.white_list;
				externalFavoriteBtn.Image = Properties.Resources.white_paint;

				prevButton.Image = Properties.Resources.white_prev;
				showFileButton.Image = Properties.Resources.white_picfolder;
				nextButton.Image = Properties.Resources.white_next;
				slideshowButton.Image = Properties.Resources.white_slideshow;

				autoZoomButton.Image = Properties.Resources.white_autozoom;
				zoomInButton.Image = Properties.Resources.white_zoomin;
				zoomOutButton.Image = Properties.Resources.white_zoomout;
				actualSizeBtn.Image = Properties.Resources.white_actualsize;

				editButton.Image = Properties.Resources.white_edit;
				editButton.DropDown.BackColor = ThemeManager.DarkSecondColor;
				editButton.DropDown.ForeColor = Color.White;
				rotateLeftButton.Image = Properties.Resources.white_rotatel;
				rotateRightButton.Image = Properties.Resources.white_rotater;
				flipHorizontalButton.Image = Properties.Resources.white_fliph;
				flipVerticalButton.Image = Properties.Resources.white_flipv;
				rotate180Button.Image = Properties.Resources.white_degree;
				customAngleBtn.Image = Properties.Resources.white_angle;

				screenshotButton.Image = Properties.Resources.white_screenshot;
				infoButton.Image = Properties.Resources.white_info;
				copyButton.Image = Properties.Resources.white_copy;
				copyButton.DropDown.BackColor = ThemeManager.DarkSecondColor;
				copyButton.DropDown.ForeColor = Color.White;
				copyImageButton.Image = Properties.Resources.white_image;
				copyFileBtn.Image = Properties.Resources.white_imgfile;
				pasteButton.Image = Properties.Resources.white_paste;

				checkboardButton.Image = Properties.Resources.white_grid;
				fullscreenButton.Image = Properties.Resources.white_fullscreen;
				onTopButton.Image = Properties.Resources.white_ontop;
				miniViewButton.Image = Properties.Resources.white_miniview;

				moreButton.Image = Properties.Resources.white_more;
				moreButton.DropDown.BackColor = ThemeManager.DarkSecondColor;
				moreButton.DropDown.ForeColor = Color.White;
				setAsDesktopButton.Image = Properties.Resources.white_desktop;
				aboutBtn.Image = Properties.Resources.white_about;
				reloadButton.Image = Properties.Resources.white_sync;
				newWindowButton.Image = Properties.Resources.white_newwindow;
				settingsButton.Image = Properties.Resources.white_settings;
				backColorBtn.Image = Properties.Resources.white_palette;
				backColorBtn.DropDown.BackColor = ThemeManager.DarkSecondColor;
				backColorBtn.DropDown.ForeColor = Color.White;
				backClearBtn.Image = Properties.Resources.white_erase;
				backCustomBtn.Image = Properties.Resources.white_palette;
				framelessBtn.Image = Properties.Resources.white_frame;

				directoryLabel.Image = Properties.Resources.white_picfolder;
				fileLabel.Image = Properties.Resources.white_imgfile;
				sizeLabel.Image = Properties.Resources.white_size;
				zoomLabel.Image = Properties.Resources.white_zoom;
				dateCreatedLabel.Image = Properties.Resources.white_clock;
				dateModifiedLabel.Image = Properties.Resources.white_history;
				hasChangesLabel.Image = Properties.Resources.white_erase;

				typeOpsButton.Image = Properties.Resources.white_options;
				typeOpsButton.BackColor = ThemeManager.DarkSecondColor;
				typeOpsButton.ForeColor = Color.White;

				pluginsBtn.Image = Properties.Resources.white_plugin;
				pluginsBtn.DropDown.BackColor = ThemeManager.DarkSecondColor;
				pluginsBtn.DropDown.ForeColor = Color.White;
				pluginManBtn.Image = Properties.Resources.white_plugin;

				zoomTextBox.BackColor = ThemeManager.DarkMainColor;
				zoomTextBox.ForeColor = Color.White;
			}

			toolStrip1.SetDarkMode(dark, true);
		}

		private void printButton_Click(object sender, EventArgs e)
		{
			setSlideshow(false);

			string docTitle = resMan.GetString("image") + " 1";
			if (currentFile != null)
			{
				docTitle = currentFile;
			}

			PrintForm pf = new PrintForm(printDocument1, darkMode, docTitle);
			pf.Owner = this;
			pf.TopMost = alwaysOnTop;

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
					resMan.GetString("sure-close-app"),
					resMan.GetString("warning"),
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
				MessageBox.Show(resMan.GetString("cur-file-not-found"), resMan.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void showSuggestion(string text)
		{
			suggestionLabel.Invoke((MethodInvoker)(() => {
				suggestionLabel.Text = text;
				suggestionLabel.Visible = true;
			}));

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
			string text = b.Text.Substring(1, b.Text.Length - 1);
			string type = text.Substring(0, text.IndexOf(' ')).ToLower();

			if (type == "svg")
			{
				SvgOpsForm sof = new SvgOpsForm(Path.Combine(currentFolder, currentFile), 
					pictureBox.Image.Width, 
					pictureBox.Image.Height,
					picturePanel.Width - 32,
					picturePanel.Height - 32,
					darkMode);
				sof.Owner = this;
				sof.ShowDialog();
			}
		}

		private void reloadButton_Click(object sender, EventArgs e)
		{
			openFile(Path.Combine(currentFolder, currentFile));
			showSuggestion(resMan.GetString("file-reloaded"));
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
			setZoomText(resMan.GetString("auto"));
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
			settingsBox.TopMost = alwaysOnTop;
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

		private void zoomOutButton_MouseLeave(object sender, EventArgs e)
		{
			zoomOutTimer.Stop();
		}

		private void zoomOutButton_MouseUp(object sender, MouseEventArgs e)
		{
			zoomOutTimer.Stop();
		}

		private void zoomInButton_MouseLeave(object sender, EventArgs e)
		{
			zoomInTimer.Stop();
		}

		private void zoomInButton_MouseUp(object sender, MouseEventArgs e)
		{
			zoomInTimer.Stop();
		}

		private void MainForm_Shown(object sender, EventArgs e)
		{
			try
			{
				CustomJumplist jumplist = new CustomJumplist();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private void copyFileBtn_Click(object sender, EventArgs e)
		{
			try
			{
				string[] filesToCopy = { Path.Combine(currentFolder, currentFile) };
				Clipboard.Clear();
				Clipboard.SetData(DataFormats.FileDrop, filesToCopy);
				showSuggestion(resMan.GetString("file-copied-to-clipboard"));
			}
			catch
			{
				MessageBox.Show(resMan.GetString("cur-file-not-found"), resMan.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void maximizeBtn_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Maximized)
			{
				this.WindowState = FormWindowState.Normal;
			}
			else
			{
				this.WindowState = FormWindowState.Maximized;
			}
		}

		private void minimizeBtn_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void externalRunBtn_Click(object sender, EventArgs e)
		{
			try
			{
				string ext = "bmp";
				if (currentFile != null)
				{
					ext = Path.GetExtension(currentFile).Substring(1, Path.GetExtension(currentFile).Length - 1);
				}

				Process.Start(FileAssociation.GetExecFileAssociatedToExtension(ext), Path.Combine(currentFolder, currentFile));
			}
			catch
			{
				MessageBox.Show(resMan.GetString("unable-to-run-external-app"), resMan.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void externalFavoriteBtn_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start(Properties.Settings.Default.FavoriteExternalApp, Path.Combine(currentFolder, currentFile));
			}
			catch
			{
				MessageBox.Show(resMan.GetString("unable-to-run-external-app"), resMan.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void externalBtn_DropDownOpened(object sender, EventArgs e)
		{
			int lastSlashIndex = Properties.Settings.Default.FavoriteExternalApp.LastIndexOf('/');
			if (lastSlashIndex == -1) 
				lastSlashIndex = Properties.Settings.Default.FavoriteExternalApp.LastIndexOf('\\');

			if (lastSlashIndex >= 0)
			{
				string appName = Properties.Settings.Default.FavoriteExternalApp.Substring(lastSlashIndex + 1, Properties.Settings.Default.FavoriteExternalApp.Length - lastSlashIndex - 1);
				externalFavoriteBtn.Text = resMan.GetString("open-with") + " \"" + appName + "\"";
			}
			else
			{
				externalFavoriteBtn.Text = resMan.GetString("open-with-custom");
			}
		}

		private void picturePanel_MouseEnter(object sender, EventArgs e)
		{
			picturePanel.Focus();
			this.AllowDrop = true;
		}

		private void backClearBtn_Click(object sender, EventArgs e)
		{
			picturePanel.BackColor = Color.Transparent;
			Properties.Settings.Default.BackColor = "";
			Properties.Settings.Default.Save();
		}

		private void backCustomBtn_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				setCheckboardBackground(false, true);
				picturePanel.BackColor = colorDialog1.Color;
				Properties.Settings.Default.BackColor = colorDialog1.Color.ToArgb().ToString();
				Properties.Settings.Default.Save();
			}
		}

		private void MainForm_ResizeEnd(object sender, EventArgs e)
		{
			if (!autoZoom)
			{
				updatePictureBoxLocation();
			}
		}

		private void actualSizeBtn_Click(object sender, EventArgs e)
		{
			setZoomText("100%");
		}

		private void zoomTextBox_MouseEnter(object sender, EventArgs e)
		{
			zoomTextBox.Focus();
		}

		private void zoomTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				if (!autoZoom) setZoomText(zoomFactor + "%");
				e.Handled = true;
			}
		}

		private void framelessBtn_Click(object sender, EventArgs e)
		{
			if (this.FormBorderStyle == FormBorderStyle.None)
			{
				this.FormBorderStyle = FormBorderStyle.Sizable;
				statusStrip1.SizingGrip = true;
				framelessBtn.Checked = false;
			}
			else
			{
				this.FormBorderStyle = FormBorderStyle.None;
				statusStrip1.SizingGrip = false;
				framelessBtn.Checked = true;
			}
		}

		private void pluginsBtn_DropDownClosed(object sender, EventArgs e)
		{
			for (int i = pluginsBtn.DropDownItems.Count - 1; i > 0; i--)
			{
				pluginsBtn.DropDownItems.Remove(pluginsBtn.DropDownItems[i]);
			}
		}

		private string GetPropertyValue(object t, string propertyName)
		{
			object val = t.GetType().GetProperties().Single(pi => pi.Name == propertyName).GetValue(t, null);
			return (string)val;
		}

		private void pluginsBtn_DropDownOpening(object sender, EventArgs eventArgs)
		{
			PluginInfo[] plugins = PluginManager.GetPlugins();
			for (int i = 0; i < plugins.Length; i++)
			{
				QlibMenuSeparator separator = new QlibMenuSeparator();
				pluginsBtn.DropDownItems.Add(separator);
				for (int j = 0; j < plugins[i].functions.Length; j++)
				{
					string title = plugins[i].functions[j].title.Get(Properties.Settings.Default.Language);
					if (plugins[i].functions[j].ops.showDialog)
					{
						title += " ...";
					}

					PluginMenuItem tsmi = new PluginMenuItem(title, plugins[i].name, plugins[i].functions[j].name, originalImage != null, darkMode);
					tsmi.Click += (s, e) =>
					{
						IntPtr pluginPtr = PluginManager.LoadLibrary(tsmi.dllPath);
						IntPtr funcPtr = PluginManager.GetProcAddressOrdinal(pluginPtr, tsmi.funcName);
						var callback = Marshal.GetDelegateForFunctionPointer<PluginManager.RunFunction>(funcPtr);
						callback(originalImage, Path.Combine(currentFolder, currentFile), darkMode, Properties.Settings.Default.Language);
					};
					pluginsBtn.DropDownItems.Add(tsmi);
				}
			}
		}
	}
}
