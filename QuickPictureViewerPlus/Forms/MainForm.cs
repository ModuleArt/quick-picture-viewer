using QuickLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace QuickPictureViewerPlus
{
	public partial class MainForm : Form
	{
		private string openPath = null;
		private int zoomFactor = 100;
		public Bitmap originalImage = null;
		private bool autoZoom = true;
		private Point panelMouseDownLocation;
		private bool fullscreen = false;
		private bool alwaysOnTop = false;
		private bool imageChanged = false;
		private bool darkMode = false;
		private bool checkboardBackground = false;
		private bool slideshow = false;
		private int slideshowCounter = 0;
		private bool dragImage = false;
		private System.Timers.Timer zoomInTimer = new System.Timers.Timer();
		private System.Timers.Timer zoomOutTimer = new System.Timers.Timer();
		private System.Timers.Timer slideshowTimer = new System.Timers.Timer();
		private System.Threading.Timer suggestionTimer;
		private bool framelessMode = false;

		public SelectionForm selForm = null;
		private EditSelForm editSelForm = null;

		private string currentFolder;
		private string recursiveFolder;
		private string currentFile;

		public bool printCenterImage = true;
		public bool restartApp = false;

		public MainForm(string openPath, bool darkMode)
		{
			this.darkMode = darkMode;
			this.openPath = openPath;

			InitializeComponent();

			SetFilteringMode(InterpolationMode.Bilinear);

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
			zoomTextBox.LostFocus += PicturePanel_LostFocus;
			// TODO ContextMenu is no longer supported. Use ContextMenuStrip instead. For more details see https://docs.microsoft.com/en-us/dotnet/core/compatibility/winforms#removed-controls
			zoomTextBox.TextBox.ContextMenuStrip = new ContextMenuStrip();

			SetDarkMode(darkMode);
			InitLanguage();

			toolStrip1.Visible = Properties.Settings.Default.ShowToolbar;
			statusStrip1.Visible = Properties.Settings.Default.ShowStatusBar;

			if (Properties.Settings.Default.StartupRestoreBounds)
			{
				Screen curScreen = Screen.FromPoint(Cursor.Position);
				if (
					Properties.Settings.Default.StartupWindowLocation.X < curScreen.WorkingArea.X - 128 ||
					Properties.Settings.Default.StartupWindowLocation.Y < curScreen.WorkingArea.Y - 128 ||
					Properties.Settings.Default.StartupWindowLocation.X >= curScreen.WorkingArea.X + curScreen.WorkingArea.Width - 128 ||
					Properties.Settings.Default.StartupWindowLocation.Y >= curScreen.WorkingArea.Y + curScreen.WorkingArea.Height - 128
				)
				{
					StartPosition = FormStartPosition.WindowsDefaultLocation;
				}
				else
				{
					StartPosition = FormStartPosition.Manual;
					Location = Properties.Settings.Default.StartupWindowLocation;
				}

				if (Properties.Settings.Default.StartupWindowSize.Width >= MinimumSize.Width && Properties.Settings.Default.StartupWindowSize.Height >= MinimumSize.Height)
				{
					Size = Properties.Settings.Default.StartupWindowSize;
				}
				else
				{
					Properties.Settings.Default.StartupWindowSize = new Size(700, 485);
				}
			}

			ActiveControl = picturePanel;
			picturePanel.LostFocus += PicturePanel_LostFocus;
		}

		protected override void OnHandleCreated(EventArgs e)
		{
			if (darkMode) ThemeMan.ApplyDarkTitlebar(Handle, darkMode);
			closeFile();
			base.OnHandleCreated(e);
		}
		private void PicturePanel_LostFocus(object sender, EventArgs e)
		{
			if (ActiveControl != zoomTextBox.TextBox) ActiveControl = picturePanel;
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if (m.Msg == NativeMan.WM_SYSCOMMAND &&
				(m.WParam == (IntPtr)NativeMan.SC_MAXIMIZE || m.WParam == (IntPtr)NativeMan.SC_RESTORE)) OnResizeEnd(EventArgs.Empty);
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Left)
			{
				PrevFile();
				return true;
			}
			else if (keyData == Keys.Right)
			{
				NextFile();
				return true;
			}
			else if (keyData == Keys.Down)
			{
				zoomOut();
				return true;
			}
			else if (keyData == Keys.Up)
			{
				zoomIn();
				return true;
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void InitLanguage()
		{
			if (string.IsNullOrEmpty(Properties.Settings.Default.Language))
			{
				switch (CultureInfo.CurrentCulture.TwoLetterISOLanguageName)
				{
					case "en":
					case "cn":
					case "de":
					case "es":
					case "fr":
					case "hu":
					case "ru":
						LangMan.Init("QuickPictureViewerPlus", "QuickPictureViewerPlus.languages.lang_" + CultureInfo.CurrentCulture.TwoLetterISOLanguageName);
						Properties.Settings.Default.Language = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
						break;
					default:
						LangMan.Init("QuickPictureViewerPlus");
						Properties.Settings.Default.Language = LangMan.defaultLang;
						break;
				}
				Properties.Settings.Default.Save();
			}
			else
			{
				LangMan.Init("QuickPictureViewerPlus", "QuickPictureViewerPlus.languages.lang_" + Properties.Settings.Default.Language);
			}

			pleaseOpenLabel.Text = LangMan.Get("please-open-image");

			moreButton.Text = LangMan.Get("more-options");
			aboutBtn.Text = LangMan.Get("about") + " ...";
			settingsButton.Text = LangMan.Get("settings") + " ...";
			settingsButton.ShortcutKeyDisplayString = "Ctrl+" + LangMan.Get("comma");
			newWindowButton.Text = LangMan.Get("new-window");
			framelessBtn.Text = LangMan.Get("frameless-mode");
			onTopButton.Text = LangMan.Get("always-on-top");
			backColorBtn.Text = LangMan.Get("background-color");
			backClearBtn.Text = LangMan.Get("clear");
			backCustomBtn.Text = LangMan.Get("choose-color") + " ...";
			wallpaperBtn.Text = LangMan.Get("set-as-desktop-background") + " ...";
			printButton.Text = LangMan.Get("print") + " ...";
			deleteBtn.Text = LangMan.Get("move-to-trash");
			permDeleteBtn.Text = LangMan.Get("perm-delete") + " ...";
			reloadButton.Text = LangMan.Get("reload-file");

			selectionBtn.Text = LangMan.Get("selection-tool") + " | S";

			editButton.Text = LangMan.Get("edit-image");
			flipHorizontalButton.Text = LangMan.Get("flip-horizontal");
			flipVerticalButton.Text = LangMan.Get("flip-vertical");
			rotateRightButton.Text = LangMan.Get("rotate-right");
			rotateLeftButton.Text = LangMan.Get("rotate-left");
			rotate180Button.Text = LangMan.Get("rotate-180");
			cropBtn.Text = LangMan.Get("crop");

			externalBtn.Text = LangMan.Get("open-external");
			externalRunBtn.Text = LangMan.Get("open-with-default");
			externalChooseBtn.Text = LangMan.Get("open-with-choose") + " ...";

			openBtn.Text = LangMan.Get("open");
			openFileBtn.Text = LangMan.Get("open-file");
			openFolderBtn.Text = LangMan.Get("open-folder");
			openRecursive.Text = LangMan.Get("open-recursive");

			saveAsBtn.Text = LangMan.Get("save-as");
			saveMenuBtn.Text = LangMan.Get("save");
			saveBtn.Text = LangMan.Get("save");
			checkboardButton.Text = LangMan.Get("checkboard-background") + " | Ctrl+B";
			fullscreenBtn.Text = LangMan.Get("fullscreen") + " | F";
			miniViewButton.Text = LangMan.Get("picture-in-picture") + " | Ctrl+Shift+P";
			autoZoomButton.Text = LangMan.Get("auto-zoom") + " | Ctrl+Shift+A";
			zoomInButton.Text = LangMan.Get("zoom-in") + " | Ctrl+" + LangMan.Get("plus");
			zoomOutButton.Text = LangMan.Get("zoom-out") + " | Ctrl+" + LangMan.Get("minus");
			zoom100Btn.Text = LangMan.Get("zoom-to-actual-size") + " (100%) | Ctrl+0";
			infoButton.Text = LangMan.Get("image-info") + " | Ctrl+I";
			slideshowButton.Text = LangMan.Get("slideshow") + " | Shift+F5";
			prevButton.Text = LangMan.Get("prev-image") + " | " + LangMan.Get("left-arrow");
			infoTooltip.SetToolTip(navPrevBtn, LangMan.Get("prev-image") + " | " + LangMan.Get("left-arrow"));
			nextButton.Text = LangMan.Get("next-image") + " | " + LangMan.Get("right-arrow");
			infoTooltip.SetToolTip(navNextBtn, LangMan.Get("next-image") + " | " + LangMan.Get("right-arrow"));

			hasChangesLabel.Text = " " + LangMan.Get("not-saved");
			zoomLabel.Text = " " + LangMan.Get("zoom") + ": " + LangMan.Get("auto");
			selectionLabel.ToolTipText = LangMan.Get("edit-selection") + " ... | Alt+S";
			directoryLabel.ToolTipText = LangMan.Get("show-file-explorer") + " | Ctrl+Shift+L";

			effectsBtn.Text = LangMan.Get("effects");
			filteringModeBtn.Text = LangMan.Get("filtering");
			bilinearBtn.Text = LangMan.Get("bilinear");
			nearestNeighborBtn.Text = LangMan.Get("nearest-neighbor");
			toolsBtn.Text = LangMan.Get("tools");
			pluginManBtn.Text = LangMan.Get("plugin-manager") + " ...";

			showMenuItem.Text = LangMan.Get("view");
			showToolbarBtn.Text = LangMan.Get("show-toolbar");
			showStatusbarBtn.Text = LangMan.Get("show-status-bar");
			showNavArrowsBtn.Text = LangMan.Get("show-nav-arrows");
			pasteBtn.Text = LangMan.Get("paste-image");
			copyBtn.Text = LangMan.Get("copy");
			copyImageBtn.Text = LangMan.Get("copy-image");
			copyFileBtn.Text = LangMan.Get("copy-file");
			selectAllBtn.Text = LangMan.Get("select-all");

			framelessCloseBtn.Text = NativeMan.GetMessageBoxText(NativeMan.DialogBoxCommandID.IDCLOSE) + " | Alt+F4";
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
				NextFile();
			}

			if (Properties.Settings.Default.SlideshowCounter)
			{
				if ((Properties.Settings.Default.SlideshowTime - slideshowCounter) <= 1)
				{
					showSuggestion(LangMan.Get("next-image-in-1-second"), SuggestionIcon.Slideshow);
				}
				else
				{
					showSuggestion(string.Format(LangMan.Get("next-image-in-x-seconds"), Properties.Settings.Default.SlideshowTime - slideshowCounter), SuggestionIcon.Slideshow);
				}
			}
		}

		protected override void OnLoad(EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(openPath))
				{

					if (Properties.Settings.Default.StartupPaste && Clipboard.ContainsImage())
					{
						pasteBtn.PerformClick();
						showSuggestion(LangMan.Get("image-pasted-from-clipboard"), SuggestionIcon.Info);
					}
				}
				else
				{
					if (File.GetAttributes(openPath).HasFlag(FileAttributes.Directory)) openFirstFileInFolder(openPath);
					else OpenFile(openPath);
				}
			}
			catch
			{
				showSuggestion(LangMan.Get("unable-open-file"), SuggestionIcon.Warning);
			}

			setAlwaysOnTop(Properties.Settings.Default.AlwaysOnTop, false);
			setCheckboardBackground(Properties.Settings.Default.CheckboardBackground, false);
			nextButton.Visible = !Properties.Settings.Default.ShowNavArrows;

			if (Properties.Settings.Default.StartupMaximize) WindowState = FormWindowState.Maximized;

			if (Properties.Settings.Default.BackColor.Length > 0)
			{
				picturePanel.BackColor = Color.FromArgb(Convert.ToInt32(Properties.Settings.Default.BackColor));
			}

			UpdateMan.Init("adriengivry", "QuickPictureViewerPlus", "QuickPictureViewer-Setup.exe", darkMode, Properties.Settings.Default.SkippedVersion);
			UpdateMan.InitLang(
				LangMan.Get("new-version-available"),
				LangMan.Get("update-text"),
				LangMan.Get("install-now"),
				LangMan.Get("skip-this-version"),
				LangMan.Get("whats-new"),

				LangMan.Get("updating-qpv"),
				LangMan.Get("downloading-update"),
				LangMan.Get("ready-to-install"),
				LangMan.Get("update-failed")
			);
			UpdateMan.UpdateFailed += UpdateMan_UpdateFailed;
			UpdateMan.IsUpToDate += UpdateMan_IsUpToDate;
			UpdateMan.UpdateSkipped += UpdateMan_UpdateSkipped;
			if (Properties.Settings.Default.CheckForUpdates) UpdateMan.CheckForUpdates(false, TopMost, Handle);

			ReloadPlugins();

			base.OnLoad(e);
		}

		private void UpdateMan_UpdateSkipped(object sender, UpdateSkippedEventArgs e)
		{
			Properties.Settings.Default.SkippedVersion = e.SkippedVersion;
		}

		private void UpdateMan_IsUpToDate(object sender, EventArgs e)
		{
			showSuggestion(LangMan.Get("app-is-up-to-date"), SuggestionIcon.Check);
		}

		private void UpdateMan_UpdateFailed(object sender, UpdateFailedEventArgs e)
		{
			showSuggestion(
				LangMan.Get("update-failed") + ": " + (e.Exception.Message.Length > 64 ? e.Exception.Message.Substring(0, 64) + "..." : e.Exception.Message), 
				SuggestionIcon.Warning
			);
		}

		private void showTypeOpsButton(bool show, string type = null)
		{
			typeOpsButton.Invoke((MethodInvoker)(() =>
			{
				typeOpsButton.Visible = show;
				if (show) typeOpsButton.Text = " " + type + " " + LangMan.Get("type-options");
			}));
		}

		public void OpenFile(string path, bool goPrev = false, bool skipIfError = false, bool cantOpenLastError = false, string targetExtension = null)
		{
			FileTypeMan.OpenResult res = FileTypeMan.Open(path, targetExtension);
			showTypeOpsButton(res.ShowTypeOps, res.TypeName);
			if (string.IsNullOrEmpty(res.ErrorMessage))
			{
				openImage(res.Bmp, Path.GetDirectoryName(path), Path.GetFileName(path));
			}
			else
			{
				if (skipIfError)
				{
					if (goPrev ? PrevFile(true) > 0 : NextFile(true, cantOpenLastError) > 0) showSuggestion(
						LangMan.Get("unable-open-file-skipped") + ": " + Path.GetFileName(path),
						goPrev ? SuggestionIcon.Prev : SuggestionIcon.Next
					);
					else showSuggestion(res.ErrorMessage, SuggestionIcon.Warning);
				}
				else
				{
					showSuggestion(res.ErrorMessage, SuggestionIcon.Warning);
				}
			}
		}

		public void openImage(Bitmap bitmap, string directoryName, string fileName)
		{
			if (bitmap != originalImage)
			{
				if (imageChanged)
				{
					DialogResult window = DialogMan.ShowConfirm(
					this,
					LangMan.Get("unsaved-changes-question"),
					windowTitle: LangMan.Get("unsaved-changes"),
					yesBtnText: currentFile != null ? LangMan.Get("save-as") : LangMan.Get("save"),
					yesBtnImage: currentFile != null ? saveAsBtn.Image : saveBtn.Image,
					showNoBtn: true,
					noBtnText: LangMan.Get("dont-save"),
					noBtnImage: permDeleteBtn.Image,
					darkMode: darkMode,
					topMost: TopMost
				);
					if (window == DialogResult.Yes)
					{
						if (currentFile != null) saveAsBtn.PerformClick();
						else saveBtn.PerformClick();
					}
					else if (window != DialogResult.No) return;
				}

				selectionBtn.Checked = false;
				setImageChanged(false);

				if (originalImage != null)
				{
					originalImage.Dispose();
					originalImage = null;
					pictureBox.Image.Dispose();
					pictureBox.Image = null;
				}

				const int exifOrientationID = 0x112; 
				if (bitmap.PropertyIdList.Contains(exifOrientationID))
				{
					var prop = bitmap.GetPropertyItem(exifOrientationID);
					int val = BitConverter.ToUInt16(prop.Value, 0);
					var rot = RotateFlipType.RotateNoneFlipNone;

					if (val == 3 || val == 4) rot = RotateFlipType.Rotate180FlipNone;
					else if (val == 5 || val == 6) rot = RotateFlipType.Rotate90FlipNone;
					else if (val == 7 || val == 8) rot = RotateFlipType.Rotate270FlipNone;
					if (val == 2 || val == 4 || val == 5 || val == 7) rot |= RotateFlipType.RotateNoneFlipX;
					if (rot != RotateFlipType.RotateNoneFlipNone) bitmap.RotateFlip(rot);
				}

				originalImage = bitmap;
				pictureBox.Image = originalImage;

				fileLabel.Text = " " + LangMan.Get("file") + ": " + fileName;

				if (directoryName == null)
				{
					currentFolder = null;
					currentFile = null;
					directoryLabel.Visible = false;
				}
				else
				{
					string path = Path.Combine(directoryName, fileName);

					currentFolder = directoryName;
					currentFile = fileName;

					directoryLabel.Visible = true;
					if (recursiveFolder != null) directoryLabel.Image = darkMode ? Properties.Resources.white_recursive : Properties.Resources.black_recursive;
					else directoryLabel.Image = darkMode ? Properties.Resources.white_picfolder : Properties.Resources.black_picfolder;
					directoryLabel.Text = " " + LangMan.Get("folder") + ": " + directoryName;

					dateCreatedLabel.Text = " " + LangMan.Get("created") + ": " + File.GetCreationTime(path).ToShortDateString() + " - " + File.GetCreationTime(path).ToLongTimeString();
					dateModifiedLabel.Text = " " + LangMan.Get("modified") + ": " + File.GetLastWriteTime(path).ToShortDateString() + " - " + File.GetLastWriteTime(path).ToLongTimeString();
				}
				UpdateSizeLabel();

				nextButton.Enabled = directoryName != null;
				prevButton.Enabled = directoryName != null;
				slideshowButton.Enabled = directoryName != null;
				deleteBtn.Enabled = directoryName != null;
				permDeleteBtn.Enabled = directoryName != null;
				externalRunBtn.Enabled = directoryName != null;
				externalChooseBtn.Enabled = directoryName != null;
				externalFavoriteBtn.Enabled = directoryName != null;
				copyFileBtn.Enabled = directoryName != null;
				reloadButton.Enabled = directoryName != null;
				dateCreatedLabel.Visible = directoryName != null;
				dateModifiedLabel.Visible = directoryName != null;

				Invoke((MethodInvoker)(() => Text = fileName + " - Quick Picture Viewer"));

				zoomInButton.Enabled = true;
				zoomOutButton.Enabled = true;
				zoom100Btn.Enabled = true;
				flipVerticalButton.Enabled = true;
				flipHorizontalButton.Enabled = true;
				rotateLeftButton.Enabled = true;
				rotateRightButton.Enabled = true;
				rotate180Button.Enabled = true;
				cropBtn.Enabled = true;
				saveAsBtn.Enabled = true;
				copyImageBtn.Enabled = true;
				selectAllBtn.Enabled = true;
				autoZoomButton.Enabled = true;
				selectionBtn.Enabled = true;
				wallpaperBtn.Enabled = true;
				infoButton.Enabled = true;
				printButton.Enabled = true;
				miniViewButton.Enabled = true;

				zoomTextBox.Enabled = true;

				pleaseOpenLabel.Invoke((MethodInvoker)(() => pleaseOpenLabel.Visible = false));

				CheckAutoZoomNeeded();
			}
		}

		private void UpdateSizeLabel()
		{
			sizeLabel.Text = " " + LangMan.Get("size") + ": " + originalImage.Width.ToString() + " x " + originalImage.Height.ToString();
			if (currentFolder != null) sizeLabel.Text += " (" + FileMan.GetFileSizeStr(Path.Combine(currentFolder, currentFile)) + ")";
		}

		private void CheckAutoZoomNeeded()
		{
			if (originalImage != null)
			{
				if (!fullscreen && (originalImage.Width < picturePanel.Width - 32) && (originalImage.Height < picturePanel.Height - 32))
				{
					if (zoomTextBox.Text == "100%") setZoomFactor(100);
					else setZoomText("100%");
				}
				else
				{
					setZoomText(LangMan.Get("auto"));
				}
			}
			else
			{
				setZoomText(LangMan.Get("auto"));
			}
		}

		private void setImageChanged(bool b, string fakeName = "")
		{
			imageChanged = b;
			hasChangesLabel.Visible = b;

			Text = string.IsNullOrEmpty(fakeName) ? currentFile + " - Quick Picture Viewer" : fakeName + " - Quick Picture Viewer";

			if (b) Text = "* " + Text;

			saveBtn.Enabled = b;
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
			if (autoZoom) ZoomToFit();
			setZoomText((zoomFactor + 5).ToString() + "%");
		}

		private void zoomOut()
		{
			if (autoZoom) ZoomToFit();
			setZoomText((zoomFactor - 5).ToString() + "%");
		}

		private void ZoomToFit()
		{
			double zoomFactorX = picturePanel.Width / (double)originalImage.Width;
			double zoomFactorY = picturePanel.Height / (double)originalImage.Height;
			zoomFactor = zoomFactorX > zoomFactorY ? (int)(zoomFactorY * 100) : (int)(zoomFactorX * 100);
		}

		private void setZoomFactor(int newZoomFactor)
		{
			zoomFactor = newZoomFactor;

			zoomLabel.Text = " " + LangMan.Get("zoom") + ": " + zoomFactor.ToString() + "%";

			setAutoZoom(false);

			int newWidth = Convert.ToInt32(originalImage.Width * zoomFactor / 100);
			int newHeight = Convert.ToInt32(originalImage.Height * zoomFactor / 100);

			Size newSize = new Size(newWidth, newHeight);

			pictureBox.Invoke((MethodInvoker)(() =>
			{
				pictureBox.Size = newSize;
				pictureBox.UpdatePictureBoxLocation(picturePanel);
			}));
		}

		private void setZoomText(string text)
		{
			if (!string.IsNullOrEmpty(text) && !zoomTextBox.IsDisposed) zoomTextBox.TextBox.Invoke((MethodInvoker)(() => zoomTextBox.Text = text));
		}

		private void setAutoZoom(bool b)
		{
			autoZoom = b;
			autoZoomButton.Checked = b;
			if (b)
			{
				pictureBox.Dock = DockStyle.Fill;
				zoomLabel.Text = " " + LangMan.Get("zoom") + ": " + LangMan.Get("auto");
				selectionBtn.Checked = false;
			}
			else
			{
				pictureBox.Dock = DockStyle.None;
			}
		}

		private void autoZoomButton_Click(object sender, EventArgs e)
		{
			if (zoomTextBox.Text == LangMan.Get("auto"))
			{
				ZoomToFit();
				setZoomText(zoomFactor + "%");
			}
			else
			{
				setZoomText(LangMan.Get("auto"));
			}
		}

		private void aboutButton_Click(object sender, EventArgs e)
		{
			AboutForm aboutBox = new AboutForm();
			aboutBox.Owner = this;
			aboutBox.TopMost = alwaysOnTop;
			aboutBox.ShowDialog();
			aboutBox.Dispose();
		}

		public void toggleSlideshow()
		{
			setSlideshow(!slideshow);
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
			TopMost = b;
			onTopButton.Checked = b;

			if (b) setFullscreen(false);

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
					pictureBox.ApplyCheckerboardBackground(true, darkMode);
				}
			}
			else
			{
				pictureBox.ApplyCheckerboardBackground(false);
			}

			if (saveToDisk)
			{
				Properties.Settings.Default.CheckboardBackground = b;
				Properties.Settings.Default.Save();
			}
		}

		private void flipVerticalButton_Click(object sender, EventArgs e)
		{
			if (selForm != null)
			{
				Rectangle r = GetSelectionRect();
				Bitmap cropped = originalImage.Clone(r, originalImage.PixelFormat);
				cropped.RotateFlip(RotateFlipType.RotateNoneFlipX);
				using (Graphics g = Graphics.FromImage(originalImage)) g.DrawImage(cropped, r);
				cropped.Dispose();
				selectionBtn.Checked = false;
			}
			else
			{
				originalImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
			}
			pictureBox.Image = originalImage;
			setImageChanged(true);
		}

		private void flipHorizontalButton_Click(object sender, EventArgs e)
		{
			if (selForm != null)
			{
				Rectangle r = GetSelectionRect();
				Bitmap cropped = originalImage.Clone(r, originalImage.PixelFormat);
				cropped.RotateFlip(RotateFlipType.RotateNoneFlipY);
				using (Graphics g = Graphics.FromImage(originalImage)) g.DrawImage(cropped, r);
				cropped.Dispose();
				selectionBtn.Checked = false;
			}
			else
			{
				originalImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
			}
			pictureBox.Image = originalImage;
			setImageChanged(true);
		}

		private void rotateLeftButton_Click(object sender, EventArgs e)
		{
			originalImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
			pictureBox.Image = originalImage;
			setZoomText(LangMan.Get("auto"));
			setImageChanged(true);
			UpdateSizeLabel();
		}

		private void rotateRightButton_Click(object sender, EventArgs e)
		{
			originalImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
			pictureBox.Image = originalImage;
			setZoomText(LangMan.Get("auto"));
			setImageChanged(true);
			UpdateSizeLabel();
		}

		private void saveAsButton_Click(object sender, EventArgs e)
		{
			setSlideshow(false);

			if (currentFile != null)
			{
				saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(currentFile);
				saveFileDialog1.InitialDirectory = currentFolder;

				switch (Path.GetExtension(currentFile).ToLower())
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
				string ext = ".png";
				switch (saveFileDialog1.FilterIndex)
				{
					case 2:
						ext = ".jpg";
						break;
					case 3:
						ext = ".gif";
						break;
					case 4:
						ext = ".bmp";
						break;
					case 5:
						ext = ".tif";
						break;
					case 6:
						ext = ".ico";
						break;
					case 7:
						ext = ".webp";
						break;
				}
				SaveFile(saveFileDialog1.FileName, ext, true);

				setImageChanged(false);
				CheckRecursiveFolder(saveFileDialog1.FileName);
				OpenFile(saveFileDialog1.FileName, targetExtension: ext);
			}
			saveFileDialog1.Dispose();
		}

		private void picturePanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (autoZoom || (pictureBox.Width <= picturePanel.Width && pictureBox.Height <= picturePanel.Height))
				{
					AllowDrop = false;
					if (currentFile != null || originalImage != null) dragImage = true;
				}
				else
				{
					Cursor.Current = Cursors.SizeAll;
					panelMouseDownLocation = new Point(
						PointToClient(Cursor.Position).X + picturePanel.HorizontalScroll.Value,
						PointToClient(Cursor.Position).Y + picturePanel.VerticalScroll.Value
					);
				}
			}
		}

		private void picturePanel_MouseUp(object sender, MouseEventArgs e)
		{
			dragImage = false;
			AllowDrop = true;
			Cursor.Current = Cursors.Default;
		}

		private void picturePanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (autoZoom || (pictureBox.Width <= picturePanel.Width && pictureBox.Height <= picturePanel.Height))
				{
					if (dragImage)
					{
						if (currentFile != null)
						{
							string[] paths = { Path.Combine(currentFolder, currentFile) };
							DoDragDrop(new DataObject(DataFormats.FileDrop, paths), DragDropEffects.Copy);
						}
						else if (originalImage != null) DoDragDrop(originalImage, DragDropEffects.Copy);
						dragImage = false;
					}
				}
				else
				{
					int newX = panelMouseDownLocation.X - PointToClient(Cursor.Position).X;
					int newY = panelMouseDownLocation.Y - PointToClient(Cursor.Position).Y;

					if (newX > picturePanel.HorizontalScroll.Minimum)
					{
						picturePanel.HorizontalScroll.Value = newX < picturePanel.HorizontalScroll.Maximum ? newX : picturePanel.HorizontalScroll.Maximum;
					}
					else
					{
						picturePanel.HorizontalScroll.Value = picturePanel.HorizontalScroll.Minimum;
					}

					if (newY > picturePanel.VerticalScroll.Minimum)
					{
						picturePanel.VerticalScroll.Value = newY < picturePanel.VerticalScroll.Maximum ? newY : picturePanel.VerticalScroll.Maximum;
					}
					else
					{
						picturePanel.VerticalScroll.Value = picturePanel.VerticalScroll.Minimum;
					}
					picturePanel.Update();
				}
			}
		}

		private void picturePanel_MouseWheel(object sender, MouseEventArgs e)
		{
			if (originalImage != null)
			{
				if (Control.ModifierKeys == Keys.Control || Properties.Settings.Default.MouseWheelScrollAction == 1)
				{
					if (e.Delta > 0) zoomIn();
					else if (e.Delta < 0) zoomOut();
				}
				else if (Properties.Settings.Default.MouseWheelScrollAction == 2)
				{
					if (e.Delta > 0) PrevFile();
					else if (e.Delta < 0) NextFile();
				}
			}
		}

		private void TextBox_MouseWheel(object sender, MouseEventArgs e)
		{
			if (originalImage != null)
			{
				if (e.Delta > 0) zoomIn();
				else if (e.Delta < 0) zoomOut();
			}
		}

		private void fullscreenButton_Click(object sender, EventArgs e)
		{
			setFullscreen(!fullscreen);
		}

		private void UpdatePicturePanelHeight()
		{
			int topMargin = 0;
			if (toolStrip1.Visible) topMargin += toolStrip1.Height;

			int bottomMargin = 0;
			if (statusStrip1.Visible) bottomMargin += statusStrip1.Height;

			picturePanel.Top = topMargin;
			picturePanel.Height = ClientSize.Height - topMargin - bottomMargin;
		}

		private void setFullscreen(bool b)
		{
			OnResizeBegin(EventArgs.Empty);
			fullscreen = b;
			WindowState = FormWindowState.Normal;

			if (b)
			{
				toolStrip1.Visible = false;
				statusStrip1.Visible = false;

				if (!Properties.Settings.Default.ShowCursorInFullscreen)
				{
					Bitmap bitmap = new Bitmap(1, 1);
					IntPtr ptr = bitmap.GetHicon();
					picturePanel.Cursor = new Cursor(ptr);
				}

				picturePanel.BackColor = Color.Black;
				pictureBox.ApplyCheckerboardBackground(false, darkMode);

				typeOpsButton.Left = ClientRectangle.Width + 27;
				pleaseOpenLabel.ForeColor = Color.White;

				FormBorderStyle = FormBorderStyle.None;
				WindowState = FormWindowState.Maximized;

				setAlwaysOnTop(false, true);

				showSuggestion(string.Format(LangMan.Get("press-to-exit-fullscreen"), "[Esc]"), SuggestionIcon.Fullscreen);

				CheckAutoZoomNeeded();
			}
			else
			{
				toolStrip1.Visible = Properties.Settings.Default.ShowToolbar;
				statusStrip1.Visible = Properties.Settings.Default.ShowStatusBar;

				picturePanel.Cursor = Cursors.Default;

				typeOpsButton.Left = ClientRectangle.Width - typeOpsButton.Width - 27;
				pleaseOpenLabel.ForeColor = ForeColor;

				if (!framelessMode) FormBorderStyle = FormBorderStyle.Sizable;

				if (checkboardBackground)
				{
					picturePanel.BackColor = Color.Transparent;
					pictureBox.ApplyCheckerboardBackground(true, darkMode);
				}
				else
				{
					if (Properties.Settings.Default.BackColor.Length > 0) picturePanel.BackColor = Color.FromArgb(Convert.ToInt32(Properties.Settings.Default.BackColor));
					else picturePanel.BackColor = Color.Transparent;
				}
			}

			OnResizeEnd(EventArgs.Empty);
		}

		private void zoomComboBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (zoomTextBox.Text == LangMan.Get("auto"))
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

		public void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (ActiveControl != zoomTextBox.TextBox)
			{
				if (e.Control)
				{
					if (e.Shift)
					{
						if (e.KeyCode == Keys.L) directoryLabel.PerformClick();
						else if (e.KeyCode == Keys.S) saveAsBtn.PerformClick();
						else if (e.KeyCode == Keys.P) miniViewButton.PerformClick();
						else if (e.KeyCode == Keys.A) autoZoomButton.PerformClick();
					}
					else
					{
						if (e.KeyCode == Keys.B) checkboardButton.PerformClick();
						else if (e.KeyCode == Keys.S) saveBtn.PerformClick();
						else if (e.KeyCode == Keys.Oemplus) zoomInButton.PerformClick();
						else if (e.KeyCode == Keys.OemMinus) zoomOutButton.PerformClick();
						else if (e.KeyCode == Keys.T) onTopButton.PerformClick();
						else if (e.KeyCode == Keys.I) infoButton.PerformClick();
						else if (e.KeyCode == Keys.D0) zoom100Btn.PerformClick();
					}
				}
				else if (e.Shift)
				{
					if (e.KeyCode == Keys.F5) toggleSlideshow();
				}
				else if (e.Alt)
				{
					if (e.KeyCode == Keys.Enter) fullscreenBtn.PerformClick();
					else if (e.KeyCode == Keys.Down)
					{
						int newVerticalValue = picturePanel.VerticalScroll.Value + picturePanel.VerticalScroll.LargeChange;
						picturePanel.VerticalScroll.Value = newVerticalValue >= picturePanel.VerticalScroll.Maximum ? picturePanel.VerticalScroll.Maximum : newVerticalValue;
					}
					else if (e.KeyCode == Keys.Up)
					{
						int newVerticalValue = picturePanel.VerticalScroll.Value - picturePanel.VerticalScroll.LargeChange;
						picturePanel.VerticalScroll.Value = newVerticalValue <= picturePanel.VerticalScroll.Minimum ? picturePanel.VerticalScroll.Minimum : newVerticalValue;
					}
					else if (e.KeyCode == Keys.Left)
					{
						int newHorizontalValue = picturePanel.HorizontalScroll.Value - picturePanel.HorizontalScroll.LargeChange;
						picturePanel.HorizontalScroll.Value = newHorizontalValue <= picturePanel.HorizontalScroll.Minimum ? picturePanel.HorizontalScroll.Minimum : newHorizontalValue;
					}
					else if (e.KeyCode == Keys.Right)
					{
						int newHorizontalValue = picturePanel.HorizontalScroll.Value + picturePanel.HorizontalScroll.LargeChange;
						picturePanel.HorizontalScroll.Value = newHorizontalValue >= picturePanel.HorizontalScroll.Maximum ? picturePanel.HorizontalScroll.Maximum : newHorizontalValue;
					}
					else if (e.KeyCode == Keys.S) selectionLabel_Click(null, EventArgs.Empty);
				}
				else
				{
					if (e.KeyCode == Keys.F || e.KeyCode == Keys.F11) fullscreenBtn.PerformClick();
					else if (e.KeyCode == Keys.Escape)
					{
						if (fullscreen) setFullscreen(false);
						else
						{
							if (selForm != null) selectionBtn.Checked = false;
							else if (Properties.Settings.Default.EscToExit) Close();
						}
					}
					else if (e.KeyCode == Keys.S) selectionBtn.PerformClick();
				}
			}
		}

		protected override void OnDragDrop(DragEventArgs drgevent)
		{
			Bitmap bitmap = drgevent.Data.GetData(DataFormats.Bitmap) as Bitmap;
			string[] files = drgevent.Data.GetData(DataFormats.FileDrop) as string[];

			if (bitmap != null)
			{
				openImage(bitmap, null, LangMan.Get("dragged-image"));
				setImageChanged(true, LangMan.Get("dragged-image"));
			}
			else if (files.Length > 0)
			{
				if (File.GetAttributes(files[0]).HasFlag(FileAttributes.Directory))
				{
					openFirstFileInFolder(files[0]);
				}
				else
				{
					CheckRecursiveFolder(files[0]);
					OpenFile(files[0]);
				}
			}
			base.OnDragDrop(drgevent);
		}

		protected override void OnDragEnter(DragEventArgs drgevent)
		{
			if (drgevent.Data.GetDataPresent(DataFormats.FileDrop) ||
				drgevent.Data.GetDataPresent(DataFormats.Bitmap) ||
				drgevent.Data.GetDataPresent(DataFormats.Dib))
			{
				drgevent.Effect = DragDropEffects.All;
			}
			else
			{
				drgevent.Effect = DragDropEffects.None;
			}
			base.OnDragEnter(drgevent);
		}

		private void onTopButton_Click(object sender, EventArgs e)
		{
			setAlwaysOnTop(!alwaysOnTop, true);
		}

		public int NextFile(bool skipNextFile = false, bool cantOpenLastError = false)
		{
			string[] filePaths = GetCurrentFiles();

			int currentIndex = -1;
			if (currentFile != null)
			{
				for (int i = 0; i < filePaths.Length; i++)
				{
					if (cantOpenLastError && i == filePaths.Length - 1) return 0;

					else if (filePaths[i].ToLower() == Path.Combine(currentFolder, currentFile).ToLower())
					{
						currentIndex = i;
						break;
					}
				}
			}

			if (currentIndex == -1)
			{
				setSlideshow(false);
				showSuggestion(LangMan.Get("cur-file-not-found"), SuggestionIcon.Warning);
				return 0;
			}
			else
			{
				if (skipNextFile) currentIndex++;
				if (currentIndex > filePaths.Length - 1) currentIndex = filePaths.Length - currentIndex;
				if (skipNextFile) currentFile = Path.GetFileName(filePaths[currentIndex]);
				OpenFile(currentIndex == filePaths.Length - 1 ? filePaths[0] : filePaths[currentIndex + 1], skipIfError: true, cantOpenLastError: cantOpenLastError);
				return filePaths.Length;
			}
		}

		private void nextButton_Click(object sender, EventArgs e)
		{
			NextFile();
		}

		public int PrevFile(bool skipPrevFile = false)
		{
			string[] filePaths = GetCurrentFiles();

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
				showSuggestion(LangMan.Get("cur-file-not-found"), SuggestionIcon.Warning);
				return 0;
			}
			else
			{
				if (skipPrevFile) currentIndex--;
				if (currentIndex < 0) currentIndex = filePaths.Length + currentIndex;
				if (skipPrevFile) currentFile = Path.GetFileName(filePaths[currentIndex]);
				OpenFile(currentIndex == 0 ? filePaths[filePaths.Length - 1] : filePaths[currentIndex - 1], true, skipIfError: true);
				return filePaths.Length;
			}
		}

		private void prevButton_Click(object sender, EventArgs e)
		{
			PrevFile();
		}

		private string[] GetCurrentFiles()
		{
			string[] exts = { ".png", ".jpg", ".jpeg", ".jpe", ".jfif", ".exif", ".gif", ".bmp", ".dib", ".rle", ".tiff", ".tif", ".ico", ".webp", ".svg", ".dds", ".tga", ".psd", ".cr2" };
			List<string> arlist = new List<string>();

			if (currentFolder != null)
			{
				string[] allFiles = recursiveFolder != null ? Directory.GetFiles(recursiveFolder, "*", SearchOption.AllDirectories) : Directory.GetFiles(currentFolder);
				for (int i = 0; i < allFiles.Length; i++)
				{
					string ext = Path.GetExtension(allFiles[i]).ToLower();
					if (exts.Contains(ext)) arlist.Add(allFiles[i]);
				}
			}
			return arlist.ToArray();
		}

		private void openFirstFileInFolder(string folderPath)
		{
			currentFolder = folderPath;
			string[] filePaths = GetCurrentFiles();
			if (filePaths.Length > 0)
			{
				currentFile = filePaths[0];
				OpenFile(filePaths[0], skipIfError: true, cantOpenLastError: true);
			}
			else showSuggestion(LangMan.Get("no-files-to-open"), SuggestionIcon.Warning);
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			string path = Path.Combine(currentFolder, currentFile);
			if (File.Exists(path))
			{
				originalImage.Dispose();
				originalImage = null;
				pictureBox.Image.Dispose();
				pictureBox.Image = null;

				if (NextFile() <= 1) closeFile();
				FileMan.MoveFileOrFolderToRecycleBin(path);
				showSuggestion(LangMan.Get("file-moved-to-trash") + ": " + Path.GetFileName(path), SuggestionIcon.Trash);
			}
			else
			{
				showSuggestion(LangMan.Get("cur-file-not-found"), SuggestionIcon.Warning);
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

			currentFile = null;
			currentFolder = null;
			recursiveFolder = null;

			saveAsBtn.Enabled = false;
			saveBtn.Enabled = false;
			deleteBtn.Enabled = false;
			permDeleteBtn.Enabled = false;
			prevButton.Enabled = false;
			nextButton.Enabled = false;
			slideshowButton.Enabled = false;
			autoZoomButton.Enabled = false;
			selectionBtn.Enabled = false;
			zoomInButton.Enabled = false;
			zoomOutButton.Enabled = false;
			zoom100Btn.Enabled = false;
			rotateLeftButton.Enabled = false;
			rotateRightButton.Enabled = false;
			rotate180Button.Enabled = false;
			cropBtn.Enabled = false;
			flipHorizontalButton.Enabled = false;
			flipVerticalButton.Enabled = false;
			copyImageBtn.Enabled = false;
			selectAllBtn.Enabled = false;
			copyFileBtn.Enabled = false;
			wallpaperBtn.Enabled = false;
			reloadButton.Enabled = false;
			infoButton.Enabled = false;
			externalRunBtn.Enabled = false;
			externalChooseBtn.Enabled = false;
			externalFavoriteBtn.Enabled = false;
			printButton.Enabled = false;
			miniViewButton.Enabled = false;

			zoomTextBox.Enabled = false;

			pleaseOpenLabel.Visible = true;

			directoryLabel.Visible = false;
			fileLabel.Text = " " + LangMan.Get("no-file");
			sizeLabel.Text = " " + LangMan.Get("size") + ": 0 x 0";
			dateCreatedLabel.Visible = false;
			dateModifiedLabel.Visible = false;

			showTypeOpsButton(false);

			Text = "Quick Picture Viewer";

			setZoomText(LangMan.Get("auto"));
			setSlideshow(false);
			setFullscreen(false);
		}

		private void infoButton_Click(object sender, EventArgs e)
		{
			InfoForm infoForm = new InfoForm(originalImage, currentFolder, currentFile);
			infoForm.Owner = this;
			infoForm.TopMost = alwaysOnTop;
			infoForm.DarkMode = darkMode;
			infoForm.ShowDialog();
			infoForm.Dispose();
		}

		private void picturePanel_DoubleClick(object sender, EventArgs e)
		{
			fullscreenBtn.PerformClick();
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
				ThemeMan.setDarkModeToControl(picturePanel.Handle);

				ForeColor = Color.White;
				BackColor = ThemeMan.DarkBackColor;
				statusStrip1.BackColor = ThemeMan.DarkSecondColor;

				selectionLabel.LinkColor = Color.White;
				selectionLabel.VisitedLinkColor = Color.White;
				directoryLabel.LinkColor = Color.White;
				directoryLabel.VisitedLinkColor = Color.White;

				openBtn.Image = Properties.Resources.white_open;
				openFileBtn.Image = Properties.Resources.white_imgfile;
				openFolderBtn.Image = Properties.Resources.white_picfolder;
				openRecursive.Image = Properties.Resources.white_recursive;

				saveAsBtn.Image = Properties.Resources.white_saveas;
				saveMenuBtn.Image = Properties.Resources.white_save;
				saveBtn.Image = Properties.Resources.white_save;
				printButton.Image = Properties.Resources.white_print;
				deleteBtn.Image = Properties.Resources.white_trash;
				permDeleteBtn.Image = Properties.Resources.white_permdel;

				externalBtn.Image = Properties.Resources.white_popup;
				externalRunBtn.Image = Properties.Resources.white_exe;
				externalChooseBtn.Image = Properties.Resources.white_list;
				externalFavoriteBtn.Image = Properties.Resources.white_paint;

				prevButton.Image = Properties.Resources.white_prev;
				nextButton.Image = Properties.Resources.white_next;
				slideshowButton.Image = Properties.Resources.white_slideshow;

				autoZoomButton.Image = Properties.Resources.white_autozoom;
				zoomInButton.Image = Properties.Resources.white_zoomin;
				zoomOutButton.Image = Properties.Resources.white_zoomout;
				zoom100Btn.Image = Properties.Resources.white_actualsize;

				selectionBtn.Image = Properties.Resources.white_selection;

				editButton.Image = Properties.Resources.white_edit;
				rotateLeftButton.Image = Properties.Resources.white_rotatel;
				rotateRightButton.Image = Properties.Resources.white_rotater;
				flipHorizontalButton.Image = Properties.Resources.white_fliph;
				flipVerticalButton.Image = Properties.Resources.white_flipv;
				rotate180Button.Image = Properties.Resources.white_degree;
				customAngleBtn.Image = Properties.Resources.white_angle;
				cropBtn.Image = Properties.Resources.white_crop;

				infoButton.Image = Properties.Resources.white_info;

				checkboardButton.Image = Properties.Resources.white_grid;
				fullscreenBtn.Image = Properties.Resources.white_fullscreen;
				onTopButton.Image = Properties.Resources.white_ontop;
				miniViewButton.Image = Properties.Resources.white_miniview;

				moreButton.Image = Properties.Resources.white_more;
				wallpaperBtn.Image = Properties.Resources.white_desktop;
				aboutBtn.Image = Properties.Resources.white_about;
				reloadButton.Image = Properties.Resources.white_sync;
				newWindowButton.Image = Properties.Resources.white_newwindow;
				settingsButton.Image = Properties.Resources.white_settings;
				backColorBtn.Image = Properties.Resources.white_palette;
				backClearBtn.Image = Properties.Resources.white_erase;
				backCustomBtn.Image = Properties.Resources.white_palette;
				framelessBtn.Image = Properties.Resources.white_frame;

				selectionLabel.Image = Properties.Resources.white_selection;
				directoryLabel.Image = Properties.Resources.white_picfolder;
				fileLabel.Image = Properties.Resources.white_imgfile;
				sizeLabel.Image = Properties.Resources.white_size;
				zoomLabel.Image = Properties.Resources.white_zoom;
				dateCreatedLabel.Image = Properties.Resources.white_clock;
				dateModifiedLabel.Image = Properties.Resources.white_history;
				hasChangesLabel.Image = Properties.Resources.white_erase;

				effectsBtn.Image = Properties.Resources.white_effects;
				filteringModeBtn.Image = Properties.Resources.white_filtering;
				bilinearBtn.Image = Properties.Resources.white_bilinear;
				nearestNeighborBtn.Image = Properties.Resources.white_nearest_neighbor;

				toolsBtn.Image = Properties.Resources.white_tools;
				pluginManBtn.Image = Properties.Resources.white_plugin;

				framelessCloseBtn.Image = Properties.Resources.white_close;

				zoomTextBox.BackColor = ThemeMan.DarkMainColor;
				zoomTextBox.ForeColor = Color.White;

				showMenuItem.Image = Properties.Resources.white_show;
				showToolbarBtn.Image = Properties.Resources.white_toolbar;
				showStatusbarBtn.Image = Properties.Resources.white_statusbar;
				showNavArrowsBtn.Image = Properties.Resources.white_arrows;
				pasteBtn.Image = Properties.Resources.white_paste;
				copyBtn.Image = Properties.Resources.white_copy;
				copyImageBtn.Image = Properties.Resources.white_image;
				copyFileBtn.Image = Properties.Resources.white_imgfile;
				selectAllBtn.Image = Properties.Resources.white_selectall;
			}

			rmbMenu.DarkMode = dark;
			toolStrip1.DarkMode = dark;
		}

		private void printButton_Click(object sender, EventArgs e)
		{
			setSlideshow(false);

			string docTitle = LangMan.Get("image") + " 1";
			if (currentFile != null) docTitle = currentFile;

			printDocument1.DocumentName = docTitle;
			printDocument1.PrinterSettings.PrintFileName = docTitle;

			PrintForm pf = new PrintForm(printDocument1, docTitle);
			pf.Owner = this;
			pf.TopMost = alwaysOnTop;
			pf.DarkMode = darkMode;

			if (pf.ShowDialog() == DialogResult.OK && printDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
			pf.Dispose();
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
				int x = 0, y = 0;
				if (printCenterImage)
				{
					x = (availableWidth - originalImage.Width) / 2;
					y = (availableHeight - originalImage.Height) / 2;
				}
				e.Graphics.DrawImage(originalImage, x, y, originalImage.Width, originalImage.Height);
			}
			else
			{
				double scaleW = availableWidth / (double)originalImage.Width;
				double scaleH = availableHeight / (double)originalImage.Height;

				if (scaleW < scaleH)
				{
					int x = 0, y = 0;
					if (printCenterImage)
					{
						x = (availableWidth - Convert.ToInt32(originalImage.Width * scaleW)) / 2;
						y = (availableHeight - Convert.ToInt32(originalImage.Height * scaleW)) / 2;
					}
					e.Graphics.DrawImage(originalImage, x, y, availableWidth, Convert.ToInt32(originalImage.Height * scaleW));
				}
				else
				{
					int x = 0, y = 0;
					if (printCenterImage)
					{
						x = (availableWidth - Convert.ToInt32(originalImage.Width * scaleH)) / 2;
						y = (availableHeight - Convert.ToInt32(originalImage.Height * scaleH)) / 2;
					}
					e.Graphics.DrawImage(originalImage, x, y, Convert.ToInt32(originalImage.Width * scaleH), availableHeight);
				}
			}
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			if (imageChanged)
			{
				DialogResult window = DialogMan.ShowConfirm(
					this,
					LangMan.Get("unsaved-changes-question"),
					windowTitle: LangMan.Get("unsaved-changes"),
					yesBtnText: currentFile != null ? LangMan.Get("save-as") : LangMan.Get("save"),
					yesBtnImage: currentFile != null ? saveAsBtn.Image : saveBtn.Image,
					showNoBtn: true,
					noBtnText: LangMan.Get("dont-save"),
					noBtnImage: permDeleteBtn.Image,
					darkMode: darkMode,
					topMost: TopMost
				);
				if (window == DialogResult.Yes)
				{
					if (currentFile != null) saveAsBtn.PerformClick();
					else saveBtn.PerformClick();
				}
				else if (window != DialogResult.No) e.Cancel = true;
			}

			if (Properties.Settings.Default.StartupRestoreBounds)
			{
				if (WindowState == FormWindowState.Maximized)
				{
					Properties.Settings.Default.StartupMaximize = true;
				}
				else
				{
					Properties.Settings.Default.StartupMaximize = false;
					Properties.Settings.Default.StartupWindowLocation = Location;
					Properties.Settings.Default.StartupWindowSize = Size;
				}
				Properties.Settings.Default.Save();
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

		public enum SuggestionIcon
		{
			Info = 0,
			Check = 1,
			Warning = 2,
			Slideshow = 3,
			Fullscreen = 4,
			Next = 5,
			Prev = 6,
			Trash = 7
		}

		public void showSuggestion(string text, SuggestionIcon icon)
		{
			suggestionLabel.Invoke((MethodInvoker)(() =>
			{
				suggestionLabel.Text = text;
				suggestionLabel.Visible = true;
				switch (icon)
				{
					case SuggestionIcon.Check:
						suggestionIcon.Image = Properties.Resources.white_check;
						break;
					case SuggestionIcon.Warning:
						suggestionIcon.Image = Properties.Resources.white_warning;
						break;
					case SuggestionIcon.Slideshow:
						suggestionIcon.Image = Properties.Resources.white_slideshow;
						break;
					case SuggestionIcon.Fullscreen:
						suggestionIcon.Image = Properties.Resources.white_fullscreen;
						break;
					case SuggestionIcon.Next:
						suggestionIcon.Image = Properties.Resources.white_next;
						break;
					case SuggestionIcon.Prev:
						suggestionIcon.Image = Properties.Resources.white_prev;
						break;
					case SuggestionIcon.Trash:
						suggestionIcon.Image = Properties.Resources.white_trash;
						break;
					default:
						suggestionIcon.Image = Properties.Resources.white_info;
						break;
				}
				suggestionIcon.Height = suggestionLabel.Height;
				suggestionIcon.Visible = true;
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
			suggestionLabel.Invoke((MethodInvoker)(() =>
			{
				suggestionLabel.Text = string.Empty;
				suggestionLabel.Visible = false;
				suggestionIcon.Image.Dispose();
				suggestionIcon.Visible = false;
			}));
		}

		private void slideshowButton_Click(object sender, EventArgs e)
		{
			toggleSlideshow();
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
					picturePanel.Height - 32
				);
				sof.Owner = this;
				sof.DarkMode = darkMode;
				sof.ShowDialog();
				sof.Dispose();
			}
		}

		private void reloadButton_Click(object sender, EventArgs e)
		{
			OpenFile(Path.Combine(currentFolder, currentFile));
			showSuggestion(LangMan.Get("file-reloaded"), SuggestionIcon.Check);
		}

		private void newWindowButton_Click(object sender, EventArgs e)
		{
			NewWindow();
		}

		public void RestartApp()
		{
			restartApp = true;
			Close();
		}

		public void NewWindow()
		{
			Process.Start(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "quick-picture-viewer.exe"));
		}

		private void rotate180Button_Click(object sender, EventArgs e)
		{
			if (selForm != null)
			{
				Rectangle r = GetSelectionRect();
				Bitmap cropped = originalImage.Clone(r, originalImage.PixelFormat);
				cropped.RotateFlip(RotateFlipType.Rotate180FlipNone);
				using (Graphics g = Graphics.FromImage(originalImage)) g.DrawImage(cropped, r);
				cropped.Dispose();
				selectionBtn.Checked = false;
			}
			else
			{
				originalImage.RotateFlip(RotateFlipType.Rotate180FlipNone);	
			}
			pictureBox.Image = originalImage;
			setImageChanged(true);
		}

		private void miniViewButton_Click(object sender, EventArgs e)
		{
			Hide();
			MiniViewForm mvf = new MiniViewForm(originalImage, Text, checkboardBackground);
			mvf.Owner = this;
			mvf.Show();
		}

		private void settingsButton_Click(object sender, EventArgs e)
		{
			setSlideshow(false);
			SettingsForm settingsBox = new SettingsForm();
			settingsBox.Owner = this;
			settingsBox.TopMost = alwaysOnTop;
			settingsBox.DarkMode = darkMode;
			settingsBox.ShowDialog();
			settingsBox.Dispose();
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
				CustomJumplist jumplist = new CustomJumplist(LangMan.Get("new-window"), LangMan.Get("new-window-desc"));
			}
			catch
			{

			}
		}

		private void externalRunBtn_Click(object sender, EventArgs e)
		{
			try
			{
				string ext = "bmp";
				if (currentFile != null) ext = Path.GetExtension(currentFile).Substring(1, Path.GetExtension(currentFile).Length - 1);
				Process.Start(FileAssociation.GetExecFileAssociatedToExtension(ext), '"' + Path.Combine(currentFolder, currentFile) + '"');
			}
			catch
			{
				showSuggestion(LangMan.Get("unable-to-run-external-app"), SuggestionIcon.Warning);
			}
		}

		private void externalFavoriteBtn_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start(Properties.Settings.Default.FavoriteExternalApp, '"' + Path.Combine(currentFolder, currentFile) + '"');
			}
			catch
			{
				showSuggestion(LangMan.Get("unable-to-run-external-app"), SuggestionIcon.Warning);
			}
		}

		private void externalBtn_DropDownOpened(object sender, EventArgs e)
		{
			int lastSlashIndex = Properties.Settings.Default.FavoriteExternalApp.LastIndexOf('/');
			if (lastSlashIndex == -1) lastSlashIndex = Properties.Settings.Default.FavoriteExternalApp.LastIndexOf('\\');

			if (lastSlashIndex >= 0)
			{
				string appName = Properties.Settings.Default.FavoriteExternalApp.Substring(
					lastSlashIndex + 1, 
					Properties.Settings.Default.FavoriteExternalApp.Length - lastSlashIndex - 1
				);
				externalFavoriteBtn.Text = LangMan.Get("open-with") + " \"" + appName + "\"";
			}
			else
			{
				externalFavoriteBtn.Text = LangMan.Get("open-with-custom");
			}
		}

		private void picturePanel_MouseEnter(object sender, EventArgs e)
		{
			if (!dragImage) AllowDrop = true;
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
			colorDialog1.Dispose();
		}

		private void MainForm_ResizeEnd(object sender, EventArgs e)
		{
			if (!autoZoom) pictureBox.UpdatePictureBoxLocation(picturePanel);
		}

		private void zoomTextBox_MouseEnter(object sender, EventArgs e)
		{
			ActiveControl = zoomTextBox.TextBox;
			zoomTextBox.TextBox.SelectAll();
		}

		private void zoomTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				if (!autoZoom) setZoomText(zoomFactor + "%");
				e.Handled = true;
			}
		}

		private void SetFramelessMode(bool b)
		{
			framelessMode = b;
			statusStrip1.SizingGrip = !b;
			framelessBtn.Checked = b;
			framelessCloseBtn.Visible = b;

			if (b) FormBorderStyle = FormBorderStyle.None;
			else if (!fullscreen) FormBorderStyle = FormBorderStyle.Sizable;
		}

		private void framelessBtn_Click(object sender, EventArgs e)
		{
			SetFramelessMode(!framelessMode);
		}

		public void CheckPluginsEnable()
		{
			PluginInfo[] plugins = PluginMan.GetPluginsCache(Properties.Settings.Default.PluginsCache);

			List<PluginInfo.Function> toEffects = new List<PluginInfo.Function>();
			List<PluginInfo.Function> toTools = new List<PluginInfo.Function>();
			for (int i = 0; i < plugins.Length; i++)
			{
				for (int j = 0; j < plugins[i].functions.Length; j++)
				{
					if (plugins[i].functions[j].type == "effect") toEffects.Add(plugins[i].functions[j]);
					else if (plugins[i].functions[j].type == "tool") toTools.Add(plugins[i].functions[j]);
				}
			}
			for (int i = 0; i < toEffects.Count; i++)
			{
				if (toEffects[i].inputRequired) effectsBtn.DropDownItems[i].Enabled = originalImage != null;
			}
			for (int i = 0; i < toTools.Count; i++)
			{
				if (toTools[i].inputRequired) toolsBtn.DropDownItems[i].Enabled = originalImage != null;
			}
		}

		public void ReloadPlugins()
		{
			effectsBtn.DropDownItems.Clear();
			toolsBtn.DropDownItems.Clear();

			PluginMan.pluginsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "plugins");
			PluginMan.inputType = "bitmap";

			PluginInfo[] plugins = PluginMan.GetPluginsCache(Properties.Settings.Default.PluginsCache);

			List<PluginMenuItem> toEffects = new List<PluginMenuItem>();
			List<PluginMenuItem> toTools = new List<PluginMenuItem>();
			for (int i = 0; i < plugins.Length; i++)
			{
				for (int j = 0; j < plugins[i].functions.Length; j++)
				{
					string path = null;
					if (currentFile != null && currentFolder != null) path = Path.Combine(currentFolder, currentFile);
					PluginMenuItem tsmi = new PluginMenuItem(
						plugins[i],
						plugins[i].functions[j],
						Properties.Settings.Default.Language,
						darkMode
					);
					tsmi.Output += Tsmi_Output;
					tsmi.Click += (s, e) => tsmi.ProcessPlugin(originalImage, path, alwaysOnTop, selForm != null ? GetSelectionRect() : Rectangle.Empty, this);

					if (plugins[i].functions[j].type == "effect") toEffects.Add(tsmi);
					else if (plugins[i].functions[j].type == "tool") toTools.Add(tsmi);
				}
			}
			effectsBtn.DropDownItems.AddRange(toEffects.ToArray());
			toolsBtn.DropDownItems.AddRange(toTools.ToArray());

			effectsBtn.Visible = effectsBtn.DropDownItems.Count != 0;
			toolsBtn.Visible = toolsBtn.DropDownItems.Count != 0;
		}

		private void Tsmi_Output(object sender, PluginMan.OutputEventArgs e)
		{
			Show();
			if (e.input != null)
			{
				directoryLabel.Visible = false;
				string title = sender.ToString();
				if (title.Length > 4 && title.Substring(title.Length - 4, 4) == " ...") title = title.Substring(0, title.Length - 4);
				title = string.Format(LangMan.Get("from-format"), title);

				if((sender as PluginMenuItem).OwnerItem.Name == "effectsBtn")
				{
					originalImage = e.input as Bitmap;
					pictureBox.Image = originalImage;
					setImageChanged(true);
				}
				else
				{
					openImage(e.input as Bitmap, null, title);
					setImageChanged(true, title);
				}
			}
		}

		private void zoomTextBox_MouseLeave(object sender, EventArgs e)
		{
			ActiveControl = picturePanel;
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (restartApp) NewWindow();
		}

		private void framelessCloseBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void statusStrip1_VisibleChanged(object sender, EventArgs e)
		{
			showStatusbarBtn.Checked = statusStrip1.Visible;
			UpdatePicturePanelHeight();
			pictureBox.UpdatePictureBoxLocation(picturePanel);
		}

		private void toolStrip1_VisibleChanged(object sender, EventArgs e)
		{
			showToolbarBtn.Checked = toolStrip1.Visible;
			UpdatePicturePanelHeight();
			pictureBox.UpdatePictureBoxLocation(picturePanel);
		}

		private void showStatusBarBtn_Click(object sender, EventArgs e)
		{
			if (!fullscreen) statusStrip1.Visible = !Properties.Settings.Default.ShowStatusBar;
			Properties.Settings.Default.ShowStatusBar = !Properties.Settings.Default.ShowStatusBar;
			Properties.Settings.Default.Save();
		}

		private void showToolbarBtn_Click(object sender, EventArgs e)
		{
			if (!fullscreen) toolStrip1.Visible = !Properties.Settings.Default.ShowToolbar;
			Properties.Settings.Default.ShowToolbar = !Properties.Settings.Default.ShowToolbar;
			Properties.Settings.Default.Save();
		}

		private void pasteBtn_Click(object sender, EventArgs e)
		{
			if (Clipboard.ContainsImage())
			{
				openImage(new Bitmap(Clipboard.GetImage()), null, LangMan.Get("from-clipboard"));
				setImageChanged(true, LangMan.Get("from-clipboard"));
			}
			else if (Clipboard.ContainsData(DataFormats.FileDrop))
			{
				string path = ((string[])Clipboard.GetData(DataFormats.FileDrop))[0];
				CheckRecursiveFolder(path);
				OpenFile(path);
			}
		}

		private void pluginManBtn_Click_1(object sender, EventArgs e)
		{
			PluginManForm pmf = new PluginManForm();
			pmf.Owner = this;
			pmf.TopMost = alwaysOnTop;
			pmf.DarkMode = darkMode;
			pmf.ShowDialog();
			pmf.Dispose();
		}

		private void copyImageBtn_Click(object sender, EventArgs e)
		{
			Clipboard.SetImage(originalImage);
			showSuggestion(LangMan.Get("image-copied-to-clipboard"), SuggestionIcon.Check);
		}

		private void copyFileBtn_Click_1(object sender, EventArgs e)
		{
			try
			{
				string[] filesToCopy = { Path.Combine(currentFolder, currentFile) };
				Clipboard.Clear();
				Clipboard.SetData(DataFormats.FileDrop, filesToCopy);
				showSuggestion(LangMan.Get("file-copied-to-clipboard"), SuggestionIcon.Check);
			}
			catch
			{
				showSuggestion(LangMan.Get("cur-file-not-found"), SuggestionIcon.Warning);
			}
		}

		private void rmbMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			pasteBtn.Enabled = Clipboard.ContainsImage() || Clipboard.ContainsData(DataFormats.FileDrop) || Clipboard.ContainsData(DataFormats.Dib);
		}

		private void copyImageBtn_EnabledChanged(object sender, EventArgs e)
		{
			copyBtn.Enabled = !(!copyImageBtn.Enabled && !copyFileBtn.Enabled);
		}

		private void openFileBtn_Click(object sender, EventArgs e)
		{
			setSlideshow(false);
			openFileDialog1.Title = LangMan.Get("open-file");
			openFileDialog1.Filter = LangMan.Get("all-image-formats") +
				" (*.png, *.jpg, *.jpeg, *.jpe, *.jfif, *.exif, *.gif, *.bmp, *.dib, *.rle, *.tiff, *.tif, *.ico, *.webp, *.svg, *.dds, *.tga, *.psd, *.cr2) | *.png; *.jpg; *.jpeg; *.jpe; *.jfif; *.exif; *.gif; *.bmp, *.dib; *.rle; *.tiff; *.tif; *.ico; *.webp; *.svg; *.dds; *.tga; *.psd; *.cr2; |PNG (*.png)|*.png|JPG (*.jpg, *.jpeg, *.jpe, *.jfif, *.exif)|*.jpg; *.jpeg; *.jpe; *.jfif; *.exif|GIF (*.gif)|*.gif|BMP (*.bmp, *.dib, *.rle)|*.bmp; *.dib; *.rle|TIF (*.tiff, *.tif)|*.tiff; *.tif|ICO (*.ico)|*.ico|WEBP (*.webp)|*.webp|SVG (*.svg)|*.svg|DirectDraw Surface (*.dds)|*.dds|Targa (*.tga)|*.tga|Photoshop Document (*.psd)|*.psd|Canon Digital Camera Raw (*.cr2)|*.cr2|" +
				LangMan.Get("all-files") + " (*.*)|*.*";

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				CheckRecursiveFolder(openFileDialog1.FileName);
				OpenFile(openFileDialog1.FileName);
			}
			openFileDialog1.Dispose();
		}

		private void openRecursive_Click(object sender, EventArgs e)
		{
			setSlideshow(false);
			string p = CustomOpenFolderDialog.GetFolder(LangMan.Get("open-recursive"));
			if (p != null)
			{
				recursiveFolder = p;
				openFirstFileInFolder(p);
			}
		}

		private void CheckRecursiveFolder(string fileToOpen)
		{
			if (recursiveFolder != null && Path.GetDirectoryName(fileToOpen) != Path.GetFullPath(currentFolder)) recursiveFolder = null;
		}

		private void selectionBtn_CheckedChanged(object sender, EventArgs e)
		{
			if (selectionBtn.Checked)
			{
				if (zoomTextBox.Text == LangMan.Get("auto"))
				{
					ZoomToFit();
					setZoomText(zoomFactor + "%");
				}

				if (selForm == null || selForm.IsDisposed)
				{
					selForm = new SelectionForm(picturePanel, darkMode);
					selForm.SizeChanged += SelForm_SizeChanged;
					selForm.LocationChanged += SelForm_SizeChanged;
					selForm.DoubleClick += SelForm_DoubleClick;
					selForm.Owner = this;
					selForm.Show();
					NativeMan.SetParent(selForm.Handle, Handle);
					selForm.Select(pictureBox.Location.X, pictureBox.Location.Y, pictureBox.Width, pictureBox.Height);
				}
			}
			else if (selForm != null && !selForm.IsDisposed)
			{
				selForm.Dispose();
				selForm = null;
			}
			selectionLabel.Visible = selectionBtn.Checked;
		}

		private void SelForm_DoubleClick(object sender, EventArgs e)
		{
			selForm.Select(pictureBox.Location.X, pictureBox.Location.Y, pictureBox.Width, pictureBox.Height);
		}

		private void SelForm_SizeChanged(object sender, EventArgs e)
		{
			Rectangle r = GetSelectionRect();
			selectionLabel.Text = " X: " + r.X + " Y: " + r.Y + " (" + r.Width + " x " + r.Height + ")";
			if (editSelForm != null) editSelForm.SetSelection(r);
		}

		public void cropBtn_Click(object sender, EventArgs e)
		{
			if (selForm != null && originalImage != null)
			{
				originalImage = originalImage.Clone(GetSelectionRect(), originalImage.PixelFormat);
				pictureBox.Image = originalImage;
				setImageChanged(true);
				UpdateSizeLabel();
				pictureBox.UpdatePictureBoxLocation(picturePanel);

				selectionBtn.Checked = false;
			}
			else
			{
				selectionBtn.Checked = true;
			}
		}

		public void bilinearBtn_Click(object sender, EventArgs e)
		{
			SetFilteringMode(InterpolationMode.Bilinear);
		}

		public void nearestNeighborBtn_Click(object sender, EventArgs e)
		{
			SetFilteringMode(InterpolationMode.NearestNeighbor);
		}

		private void SetFilteringMode(InterpolationMode mode)
		{
			pictureBox.SetInterpolationMode(mode);

			bilinearBtn.Checked = mode == InterpolationMode.Bilinear;
			nearestNeighborBtn.Checked = mode == InterpolationMode.NearestNeighbor;
		}

		private Rectangle GetSelectionRect()
		{
			double scale = (double)originalImage.Width / (double)pictureBox.Width;
			Point loc = PointToScreen(ClientRectangle.Location);
			Rectangle result = new Rectangle()
			{
				Width = (int)Math.Round(selForm.Width * scale),
				Height = (int)Math.Round(selForm.Height * scale),
				X = (int)Math.Round((selForm.Location.X - loc.X - pictureBox.Location.X - picturePanel.Location.X) * scale),
				Y = (int)Math.Round((selForm.Location.Y - loc.Y - pictureBox.Location.Y - picturePanel.Location.Y) * scale)
			};

			if (result.X < 0)
			{
				result.Width += result.X;
				result.X = 0;
			}
			else if (result.Width > originalImage.Width - result.X) result.Width = originalImage.Width - result.X;

			if (result.Y < 0) 
			{
				result.Height += result.Y;
				result.Y = 0; 
			}
			else if (result.Height > originalImage.Height - result.Y) result.Height = originalImage.Height - result.Y;

			if (result.Width > originalImage.Width) result.Width = originalImage.Width;
			if (result.Height > originalImage.Height) result.Height = originalImage.Height;

			if (result.X > originalImage.Width - 1) result.X = originalImage.Width - 1;
			if (result.Y > originalImage.Height - 1) result.Y = originalImage.Height - 1;

			if (result.Width < 1) result.Width = 1;
			if (result.Height < 1) result.Height = 1;

			return result;
		}

		private void picturePanel_SizeChanged(object sender, EventArgs e)
		{
			if (WindowState != FormWindowState.Minimized && selForm != null)
			{
				selForm.UpdateContainerRect();
				SelForm_SizeChanged(selForm, EventArgs.Empty);
			}
		}

		private void nextButton_EnabledChanged(object sender, EventArgs e)
		{
			if (!prevButton.Visible) navNextBtn.Visible = nextButton.Enabled;
			navPrevBtn.Visible = navNextBtn.Visible;
		}

		private void navNextBtn_Click(object sender, EventArgs e)
		{
			NextFile();
		}

		private void navPrevBtn_Click(object sender, EventArgs e)
		{
			PrevFile();
		}

		private void nextButton_VisibleChanged(object sender, EventArgs e)
		{
			prevButton.Visible = nextButton.Visible;

			navNextBtn.Visible = !nextButton.Visible && nextButton.Enabled;
			navPrevBtn.Visible = navNextBtn.Visible;
			
			Properties.Settings.Default.ShowNavArrows = !nextButton.Visible;
			Properties.Settings.Default.Save();
			showNavArrowsBtn.Checked = Properties.Settings.Default.ShowNavArrows;
		}

		private void showNavArrowsBtn_Click(object sender, EventArgs e)
		{
			nextButton.Visible = !nextButton.Visible;
		}

		public void selectAllBtn_Click(object sender, EventArgs e)
		{
			if (selForm != null) selForm.Select(pictureBox.Location.X, pictureBox.Location.Y, pictureBox.Width, pictureBox.Height);
			else selectionBtn.PerformClick();
		}

		public void CopySelection()
		{
			if (selForm != null && originalImage != null)
			{
				Bitmap cropped = originalImage.Clone(GetSelectionRect(), originalImage.PixelFormat);
				Clipboard.SetImage(cropped);
				cropped.Dispose();
				showSuggestion(LangMan.Get("image-copied-to-clipboard"), SuggestionIcon.Check);
			}
		}

		public void CutSelection()
		{
			if (selForm != null && originalImage != null)
			{
				Rectangle r = GetSelectionRect();

				Bitmap cropped = originalImage.Clone(r, originalImage.PixelFormat);
				Clipboard.SetImage(cropped);
				cropped.Dispose();
				showSuggestion(LangMan.Get("image-copied-to-clipboard"), SuggestionIcon.Check);

				Rectangle topRect = new Rectangle(0, 0, originalImage.Width, r.Y);
				Bitmap topPart = topRect.Width > 0 && topRect.Height > 0 ? originalImage.Clone(topRect, originalImage.PixelFormat) : null; 

				Rectangle leftRect = new Rectangle(0, r.Y, r.X, r.Height);
				Bitmap leftPart = leftRect.Width > 0 && leftRect.Height > 0 ? originalImage.Clone(leftRect, originalImage.PixelFormat) : null;

				Rectangle rightRect = new Rectangle(r.X + r.Width, r.Y, originalImage.Width - r.X - r.Width, r.Height);
				Bitmap rightPart = rightRect.Width > 0 && rightRect.Height > 0 ? originalImage.Clone(rightRect, originalImage.PixelFormat) : null;

				Rectangle bottomRect = new Rectangle(0, r.Y + r.Height, originalImage.Width, originalImage.Height - r.Y - r.Height);
				Bitmap bottomPart = bottomRect.Width > 0 && bottomRect.Height > 0 ? originalImage.Clone(bottomRect, originalImage.PixelFormat) : null;

				originalImage.MakeTransparent();
				using (Graphics g = Graphics.FromImage(originalImage))
				{
					g.Clear(Color.Transparent);
					if (topPart != null) g.DrawImage(topPart, topRect);
					if (leftPart != null) g.DrawImage(leftPart, leftRect);
					if (rightPart != null) g.DrawImage(rightPart, rightRect);
					if (bottomPart != null) g.DrawImage(bottomPart, bottomRect);
				}
				if (topPart != null) topPart.Dispose();
				if (leftPart != null) leftPart.Dispose();
				if (rightPart != null) rightPart.Dispose();
				if (bottomPart != null) bottomPart.Dispose();

				pictureBox.Image = originalImage;
				selectionBtn.Checked = false;
				setImageChanged(true);

				setCheckboardBackground(true, false);
			}
		}

		private void zoom100Btn_Click(object sender, EventArgs e)
		{
			setZoomText("100%");
		}

		public void selectionLabel_Click(object sender, EventArgs e)
		{
			if (selForm != null && (editSelForm == null || editSelForm.IsDisposed))
			{
				editSelForm = new EditSelForm(GetSelectionRect());
				editSelForm.Owner = this;
				editSelForm.TopMost = alwaysOnTop;
				editSelForm.DarkMode = darkMode;
				editSelForm.ShowDialog();
				editSelForm.Dispose();
			}
		}

		public void SelectSelection(int x, int y, int w, int h)
		{
			double scale = (double)originalImage.Width / (double)pictureBox.Width;
			Rectangle r = new Rectangle()
			{
				Width = (int)Math.Round((double)w / (double)scale),
				Height = (int)Math.Round((double)h / (double)scale),
				X = pictureBox.Location.X + (int)Math.Round((double)x / (double)scale),
				Y = pictureBox.Location.Y + (int)Math.Round((double)y / (double)scale)
			};
			selForm.Select(r.X, r.Y, r.Width, r.Height);
		}

		private void effectsBtn_DropDownOpening(object sender, EventArgs e)
		{
			CheckPluginsEnable();
		}

		private void wallpaperBtn_Click(object sender, EventArgs e)
		{
			WallpaperForm wallpaperForm = new WallpaperForm(originalImage);
			wallpaperForm.Owner = this;
			wallpaperForm.TopMost = alwaysOnTop;
			wallpaperForm.DarkMode = darkMode;
			wallpaperForm.ShowDialog();
			wallpaperForm.Dispose();
		}

		private void directoryLabel_Click(object sender, EventArgs e)
		{
			string path = Path.Combine(currentFolder, currentFile);
			if (File.Exists(path))
			{
				string argument = "/select, \"" + path + "\"";
				Process.Start("explorer.exe", argument);
			}
			else
			{
				showSuggestion(LangMan.Get("cur-file-not-found"), SuggestionIcon.Warning);
			}
		}

		private void permDeleteBtn_Click(object sender, EventArgs e)
		{
			DialogResult d = DialogMan.ShowConfirm(
				this,
				LangMan.Get("sure-perm-delete"),
				yesBtnImage: permDeleteBtn.Image,
				windowTitle: LangMan.Get("delete-file"),
				darkMode: darkMode,
				topMost: TopMost
			);
			if (d == DialogResult.Yes)
			{
				string path = Path.Combine(currentFolder, currentFile);
				if (File.Exists(path))
				{
					originalImage.Dispose();
					originalImage = null;
					pictureBox.Image.Dispose();
					pictureBox.Image = null;

					if (NextFile() <= 1) closeFile();
					File.Delete(path);
				}
				else
				{
					showSuggestion(LangMan.Get("cur-file-not-found"), SuggestionIcon.Warning);
				}
			}
		}

		private void openFolderBtn_Click(object sender, EventArgs e)
		{
			setSlideshow(false);
			string p = CustomOpenFolderDialog.GetFolder(LangMan.Get("open-folder"));
			if (p != null) 
			{
				recursiveFolder = null;
				openFirstFileInFolder(p); 
			}
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			setSlideshow(false);

			bool needSaveAs = true;
			string ext = Path.GetExtension(currentFile).ToLower();
			switch (ext)
			{
				case ".png":
				case ".jpg":
				case ".jpeg":
				case ".jpe":
				case ".jfif":
				case ".exif":
				case ".gif":
				case ".bmp":
				case ".dib":
				case ".rle":
				case ".tiff":
				case ".tif":
				case ".ico":
				case ".webp":
					needSaveAs = false;
					break;
			}
			if (needSaveAs) 
			{
				saveAsBtn.PerformClick();
				return;
			}
			SaveFile(Path.Combine(currentFolder, currentFile), ext, false);
			setImageChanged(false);
		}

		private void SaveFile(string path, string ext, bool dispose)
		{
			using (Bitmap bmpToSave = new Bitmap(originalImage))
			{
				if (dispose)
				{
					originalImage.Dispose();
					originalImage = null;
					pictureBox.Image.Dispose();
					pictureBox.Image = null;
				}
				
				using (MemoryStream memory = new MemoryStream())
				{
					using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
					{
						byte[] bytes;
						switch (ext)
						{
							case ".png":
								bmpToSave.Save(memory, ImageFormat.Png);
								bytes = memory.ToArray();
								fs.Write(bytes, 0, bytes.Length);
								break;
							case ".jpg":
							case ".jpeg":
							case ".jpe":
							case ".jfif":
							case ".exif":
								bmpToSave.Save(memory, ImageFormat.Jpeg);
								bytes = memory.ToArray();
								fs.Write(bytes, 0, bytes.Length);
								break;
							case ".gif":
								bmpToSave.Save(memory, ImageFormat.Gif);
								bytes = memory.ToArray();
								fs.Write(bytes, 0, bytes.Length);
								break;
							case ".bmp":
							case ".dib":
							case ".rle":
								bmpToSave.Save(memory, ImageFormat.Bmp);
								bytes = memory.ToArray();
								fs.Write(bytes, 0, bytes.Length);
								break;
							case ".tiff":
							case ".tif":
								bmpToSave.Save(memory, ImageFormat.Tiff);
								bytes = memory.ToArray();
								fs.Write(bytes, 0, bytes.Length);
								break;
							case ".ico":
								IcoEngine.ConvertToIcon(bmpToSave, memory);
								break;
							case ".webp":
								WebpWrapper.Save(bmpToSave, path);
								break;
						}
					}
				}
			}
		}

		private void picturePanel_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				if (selForm != null &&
					Cursor.Position.X >= selForm.Location.X &&
					Cursor.Position.Y >= selForm.Location.Y &&
					Cursor.Position.X < selForm.Location.X + selForm.Width &&
					Cursor.Position.Y < selForm.Location.Y + selForm.Height
				)
				{
					selForm.ShowContextMenu(Cursor.Position);
				} 
				else
				{
					rmbMenu.Show(Cursor.Position);
				}
			}
		}
	}
}