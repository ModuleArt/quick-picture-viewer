namespace quick_picture_viewer
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			statusStrip1 = new System.Windows.Forms.StatusStrip();
			selectionLabel = new System.Windows.Forms.ToolStripStatusLabel();
			directoryLabel = new System.Windows.Forms.ToolStripStatusLabel();
			fileLabel = new System.Windows.Forms.ToolStripStatusLabel();
			hasChangesLabel = new System.Windows.Forms.ToolStripStatusLabel();
			sizeLabel = new System.Windows.Forms.ToolStripStatusLabel();
			zoomLabel = new System.Windows.Forms.ToolStripStatusLabel();
			dateCreatedLabel = new System.Windows.Forms.ToolStripStatusLabel();
			dateModifiedLabel = new System.Windows.Forms.ToolStripStatusLabel();
			printDialog1 = new System.Windows.Forms.PrintDialog();
			printDocument1 = new System.Drawing.Printing.PrintDocument();
			colorDialog1 = new System.Windows.Forms.ColorDialog();
			toolStrip1 = new QuickLibrary.QlibToolbar();
			openBtn = new System.Windows.Forms.ToolStripDropDownButton();
			openFileBtn = new System.Windows.Forms.ToolStripMenuItem();
			openFolderBtn = new System.Windows.Forms.ToolStripMenuItem();
			openRecursive = new System.Windows.Forms.ToolStripMenuItem();
			saveMenuBtn = new System.Windows.Forms.ToolStripDropDownButton();
			saveBtn = new System.Windows.Forms.ToolStripMenuItem();
			saveAsBtn = new System.Windows.Forms.ToolStripMenuItem();
			externalBtn = new System.Windows.Forms.ToolStripDropDownButton();
			externalRunBtn = new System.Windows.Forms.ToolStripMenuItem();
			externalFavoriteBtn = new System.Windows.Forms.ToolStripMenuItem();
			externalChooseBtn = new System.Windows.Forms.ToolStripMenuItem();
			infoButton = new System.Windows.Forms.ToolStripButton();
			toolStripSeparator4 = new QuickLibrary.QlibToolsep();
			prevButton = new System.Windows.Forms.ToolStripButton();
			slideshowButton = new System.Windows.Forms.ToolStripButton();
			nextButton = new System.Windows.Forms.ToolStripButton();
			toolStripSeparator1 = new QuickLibrary.QlibToolsep();
			autoZoomButton = new System.Windows.Forms.ToolStripButton();
			zoomOutButton = new System.Windows.Forms.ToolStripButton();
			zoomTextBox = new System.Windows.Forms.ToolStripTextBox();
			zoomInButton = new System.Windows.Forms.ToolStripButton();
			zoom100Btn = new System.Windows.Forms.ToolStripButton();
			toolStripSeparator2 = new QuickLibrary.QlibToolsep();
			selectionBtn = new System.Windows.Forms.ToolStripButton();
			editButton = new System.Windows.Forms.ToolStripDropDownButton();
			flipHorizontalButton = new System.Windows.Forms.ToolStripMenuItem();
			flipVerticalButton = new System.Windows.Forms.ToolStripMenuItem();
			qlibToolsep4 = new QuickLibrary.QlibToolsep();
			rotateRightButton = new System.Windows.Forms.ToolStripMenuItem();
			rotateLeftButton = new System.Windows.Forms.ToolStripMenuItem();
			rotate180Button = new System.Windows.Forms.ToolStripMenuItem();
			customAngleBtn = new System.Windows.Forms.ToolStripMenuItem();
			toolStripSeparator7 = new QuickLibrary.QlibToolsep();
			cropBtn = new System.Windows.Forms.ToolStripMenuItem();
			filteringModeBtn = new System.Windows.Forms.ToolStripDropDownButton();
			bilinearBtn = new System.Windows.Forms.ToolStripMenuItem();
			nearestNeighborBtn = new System.Windows.Forms.ToolStripMenuItem();
			effectsBtn = new System.Windows.Forms.ToolStripDropDownButton();
			toolsBtn = new System.Windows.Forms.ToolStripDropDownButton();
			toolStripSeparator3 = new QuickLibrary.QlibToolsep();
			checkboardButton = new System.Windows.Forms.ToolStripButton();
			fullscreenBtn = new System.Windows.Forms.ToolStripButton();
			miniViewButton = new System.Windows.Forms.ToolStripButton();
			qlibToolsep1 = new QuickLibrary.QlibToolsep();
			moreButton = new System.Windows.Forms.ToolStripDropDownButton();
			reloadButton = new System.Windows.Forms.ToolStripMenuItem();
			deleteBtn = new System.Windows.Forms.ToolStripMenuItem();
			permDeleteBtn = new System.Windows.Forms.ToolStripMenuItem();
			printButton = new System.Windows.Forms.ToolStripMenuItem();
			toolStripSeparator9 = new QuickLibrary.QlibToolsep();
			backColorBtn = new System.Windows.Forms.ToolStripMenuItem();
			backCustomBtn = new System.Windows.Forms.ToolStripMenuItem();
			qlibMenuSeparator1 = new QuickLibrary.QlibToolsep();
			backClearBtn = new System.Windows.Forms.ToolStripMenuItem();
			onTopButton = new System.Windows.Forms.ToolStripMenuItem();
			framelessBtn = new System.Windows.Forms.ToolStripMenuItem();
			newWindowButton = new System.Windows.Forms.ToolStripMenuItem();
			qlibToolsep2 = new QuickLibrary.QlibToolsep();
			pluginManBtn = new System.Windows.Forms.ToolStripMenuItem();
			toolStripSeparator10 = new QuickLibrary.QlibToolsep();
			settingsButton = new System.Windows.Forms.ToolStripMenuItem();
			aboutBtn = new System.Windows.Forms.ToolStripMenuItem();
			framelessCloseBtn = new System.Windows.Forms.ToolStripButton();
			rmbMenu = new QuickLibrary.QlibContextMenuStrip(components);
			showMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			showNavArrowsBtn = new System.Windows.Forms.ToolStripMenuItem();
			showToolbarBtn = new System.Windows.Forms.ToolStripMenuItem();
			showStatusbarBtn = new System.Windows.Forms.ToolStripMenuItem();
			qlibToolsep5 = new QuickLibrary.QlibToolsep();
			wallpaperBtn = new System.Windows.Forms.ToolStripMenuItem();
			qlibToolsep3 = new QuickLibrary.QlibToolsep();
			copyBtn = new System.Windows.Forms.ToolStripMenuItem();
			copyImageBtn = new System.Windows.Forms.ToolStripMenuItem();
			copyFileBtn = new System.Windows.Forms.ToolStripMenuItem();
			pasteBtn = new System.Windows.Forms.ToolStripMenuItem();
			selectAllBtn = new System.Windows.Forms.ToolStripMenuItem();
			infoTooltip = new System.Windows.Forms.ToolTip(components);
			suggestionLabel = new System.Windows.Forms.Label();
			picturePanel = new CustomPanel();
			pleaseOpenLabel = new System.Windows.Forms.Label();
			pictureBox = new QuickPictureBox();
			suggestionIcon = new System.Windows.Forms.PictureBox();
			navNextBtn = new System.Windows.Forms.Button();
			navPrevBtn = new System.Windows.Forms.Button();
			typeOpsButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
			statusStrip1.SuspendLayout();
			toolStrip1.SuspendLayout();
			rmbMenu.SuspendLayout();
			picturePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)suggestionIcon).BeginInit();
			SuspendLayout();
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "image";
			openFileDialog1.RestoreDirectory = true;
			// 
			// fileSystemWatcher1
			// 
			fileSystemWatcher1.EnableRaisingEvents = true;
			fileSystemWatcher1.SynchronizingObject = this;
			// 
			// saveFileDialog1
			// 
			saveFileDialog1.FileName = "Image";
			saveFileDialog1.Filter = "PNG (*.png)|*.png|JPG (*.jpg, *.jpeg, *.jpe, *.jfif, *.exif)|*.jpg|GIF (*.gif)|*.gif|BMP (*.bmp, *.dib, *.rle)|*.bmp|TIF (*.tiff, *.tif)|*.tiff|ICO (*.ico)|*.ico|WEBP (*.webp)|*.webp";
			// 
			// statusStrip1
			// 
			statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
			statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			statusStrip1.GripMargin = new System.Windows.Forms.Padding(0);
			statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { selectionLabel, directoryLabel, fileLabel, hasChangesLabel, sizeLabel, zoomLabel, dateCreatedLabel, dateModifiedLabel });
			statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			statusStrip1.Location = new System.Drawing.Point(0, 419);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.ShowItemToolTips = true;
			statusStrip1.Size = new System.Drawing.Size(684, 27);
			statusStrip1.TabIndex = 4;
			statusStrip1.Text = "statusStrip1";
			statusStrip1.VisibleChanged += statusStrip1_VisibleChanged;
			// 
			// selectionLabel
			// 
			selectionLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(100, 100, 100);
			selectionLabel.BackColor = System.Drawing.Color.Transparent;
			selectionLabel.Image = Properties.Resources.black_selection;
			selectionLabel.IsLink = true;
			selectionLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			selectionLabel.LinkColor = System.Drawing.Color.Black;
			selectionLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			selectionLabel.Name = "selectionLabel";
			selectionLabel.Size = new System.Drawing.Size(75, 17);
			selectionLabel.Text = "selection";
			selectionLabel.Visible = false;
			selectionLabel.VisitedLinkColor = System.Drawing.Color.Black;
			selectionLabel.Click += selectionLabel_Click;
			// 
			// directoryLabel
			// 
			directoryLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(100, 100, 100);
			directoryLabel.BackColor = System.Drawing.Color.Transparent;
			directoryLabel.Image = Properties.Resources.black_picfolder;
			directoryLabel.IsLink = true;
			directoryLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			directoryLabel.LinkColor = System.Drawing.Color.Black;
			directoryLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			directoryLabel.Name = "directoryLabel";
			directoryLabel.Size = new System.Drawing.Size(59, 17);
			directoryLabel.Text = "folder";
			directoryLabel.Visible = false;
			directoryLabel.VisitedLinkColor = System.Drawing.Color.Black;
			directoryLabel.Click += directoryLabel_Click;
			// 
			// fileLabel
			// 
			fileLabel.BackColor = System.Drawing.Color.Transparent;
			fileLabel.Image = Properties.Resources.black_imgfile;
			fileLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			fileLabel.Name = "fileLabel";
			fileLabel.Size = new System.Drawing.Size(41, 17);
			fileLabel.Text = "file";
			// 
			// hasChangesLabel
			// 
			hasChangesLabel.BackColor = System.Drawing.Color.Transparent;
			hasChangesLabel.Image = (System.Drawing.Image)resources.GetObject("hasChangesLabel.Image");
			hasChangesLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			hasChangesLabel.Name = "hasChangesLabel";
			hasChangesLabel.Size = new System.Drawing.Size(82, 17);
			hasChangesLabel.Text = "not-saved";
			hasChangesLabel.Visible = false;
			// 
			// sizeLabel
			// 
			sizeLabel.BackColor = System.Drawing.Color.Transparent;
			sizeLabel.Image = (System.Drawing.Image)resources.GetObject("sizeLabel.Image");
			sizeLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			sizeLabel.Name = "sizeLabel";
			sizeLabel.Size = new System.Drawing.Size(46, 17);
			sizeLabel.Text = "size";
			// 
			// zoomLabel
			// 
			zoomLabel.BackColor = System.Drawing.Color.Transparent;
			zoomLabel.Image = (System.Drawing.Image)resources.GetObject("zoomLabel.Image");
			zoomLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			zoomLabel.Name = "zoomLabel";
			zoomLabel.Size = new System.Drawing.Size(57, 17);
			zoomLabel.Text = "zoom";
			// 
			// dateCreatedLabel
			// 
			dateCreatedLabel.BackColor = System.Drawing.Color.Transparent;
			dateCreatedLabel.Image = (System.Drawing.Image)resources.GetObject("dateCreatedLabel.Image");
			dateCreatedLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			dateCreatedLabel.Name = "dateCreatedLabel";
			dateCreatedLabel.Size = new System.Drawing.Size(68, 17);
			dateCreatedLabel.Text = "created";
			dateCreatedLabel.Visible = false;
			// 
			// dateModifiedLabel
			// 
			dateModifiedLabel.BackColor = System.Drawing.Color.Transparent;
			dateModifiedLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			dateModifiedLabel.Image = (System.Drawing.Image)resources.GetObject("dateModifiedLabel.Image");
			dateModifiedLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			dateModifiedLabel.Name = "dateModifiedLabel";
			dateModifiedLabel.Size = new System.Drawing.Size(76, 17);
			dateModifiedLabel.Text = "modified";
			dateModifiedLabel.Visible = false;
			// 
			// printDialog1
			// 
			printDialog1.Document = printDocument1;
			printDialog1.UseEXDialog = true;
			// 
			// printDocument1
			// 
			printDocument1.DocumentName = "";
			printDocument1.OriginAtMargins = true;
			printDocument1.PrintPage += printDocument1_PrintPage;
			// 
			// colorDialog1
			// 
			colorDialog1.Color = System.Drawing.Color.Blue;
			// 
			// toolStrip1
			// 
			toolStrip1.AlternativeAppearance = true;
			toolStrip1.AutoSize = false;
			toolStrip1.BackColor = System.Drawing.Color.White;
			toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			toolStrip1.CanOverflow = false;
			toolStrip1.DarkMode = false;
			toolStrip1.DragForm = true;
			toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			toolStrip1.ForeColor = System.Drawing.Color.Black;
			toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
			toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { openBtn, saveMenuBtn, externalBtn, infoButton, toolStripSeparator4, prevButton, slideshowButton, nextButton, toolStripSeparator1, autoZoomButton, zoomOutButton, zoomTextBox, zoomInButton, zoom100Btn, toolStripSeparator2, selectionBtn, editButton, effectsBtn, toolsBtn, toolStripSeparator3, filteringModeBtn, checkboardButton, fullscreenBtn, miniViewButton, qlibToolsep1, moreButton, framelessCloseBtn });
			toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			toolStrip1.Location = new System.Drawing.Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			toolStrip1.Size = new System.Drawing.Size(684, 32);
			toolStrip1.TabIndex = 1;
			toolStrip1.VisibleChanged += toolStrip1_VisibleChanged;
			// 
			// openBtn
			// 
			openBtn.AutoSize = false;
			openBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			openBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openFileBtn, openFolderBtn, openRecursive });
			openBtn.Image = Properties.Resources.black_open;
			openBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			openBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			openBtn.Margin = new System.Windows.Forms.Padding(0);
			openBtn.Name = "openBtn";
			openBtn.Size = new System.Drawing.Size(30, 25);
			// 
			// openFileBtn
			// 
			openFileBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			openFileBtn.ForeColor = System.Drawing.Color.Black;
			openFileBtn.Image = Properties.Resources.black_imgfile;
			openFileBtn.Name = "openFileBtn";
			openFileBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
			openFileBtn.Size = new System.Drawing.Size(237, 24);
			openFileBtn.Text = "open file";
			openFileBtn.Click += openFileBtn_Click;
			// 
			// openFolderBtn
			// 
			openFolderBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			openFolderBtn.ForeColor = System.Drawing.Color.Black;
			openFolderBtn.Image = Properties.Resources.black_imgfile;
			openFolderBtn.Name = "openFolderBtn";
			openFolderBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.O;
			openFolderBtn.Size = new System.Drawing.Size(237, 24);
			openFolderBtn.Text = "open folder";
			openFolderBtn.Click += openFolderBtn_Click;
			// 
			// openRecursive
			// 
			openRecursive.BackColor = System.Drawing.SystemColors.ControlLight;
			openRecursive.ForeColor = System.Drawing.Color.Black;
			openRecursive.Image = Properties.Resources.black_recursive;
			openRecursive.Name = "openRecursive";
			openRecursive.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O;
			openRecursive.Size = new System.Drawing.Size(237, 24);
			openRecursive.Text = "open recursive";
			openRecursive.Click += openRecursive_Click;
			// 
			// saveMenuBtn
			// 
			saveMenuBtn.AutoSize = false;
			saveMenuBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			saveMenuBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { saveBtn, saveAsBtn });
			saveMenuBtn.Image = Properties.Resources.black_save;
			saveMenuBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			saveMenuBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			saveMenuBtn.Margin = new System.Windows.Forms.Padding(0);
			saveMenuBtn.Name = "saveMenuBtn";
			saveMenuBtn.Size = new System.Drawing.Size(30, 25);
			// 
			// saveBtn
			// 
			saveBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			saveBtn.Enabled = false;
			saveBtn.ForeColor = System.Drawing.Color.Black;
			saveBtn.Image = Properties.Resources.black_save;
			saveBtn.Name = "saveBtn";
			saveBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
			saveBtn.Size = new System.Drawing.Size(207, 24);
			saveBtn.Text = "save";
			saveBtn.Click += saveBtn_Click;
			// 
			// saveAsBtn
			// 
			saveAsBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			saveAsBtn.Enabled = false;
			saveAsBtn.ForeColor = System.Drawing.Color.Black;
			saveAsBtn.Image = Properties.Resources.black_saveas;
			saveAsBtn.Name = "saveAsBtn";
			saveAsBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.S;
			saveAsBtn.Size = new System.Drawing.Size(207, 24);
			saveAsBtn.Text = "save as";
			saveAsBtn.Click += saveAsButton_Click;
			// 
			// externalBtn
			// 
			externalBtn.AutoSize = false;
			externalBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			externalBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { externalRunBtn, externalFavoriteBtn, externalChooseBtn });
			externalBtn.Image = (System.Drawing.Image)resources.GetObject("externalBtn.Image");
			externalBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			externalBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			externalBtn.Margin = new System.Windows.Forms.Padding(0);
			externalBtn.Name = "externalBtn";
			externalBtn.Size = new System.Drawing.Size(30, 25);
			externalBtn.DropDownOpened += externalBtn_DropDownOpened;
			// 
			// externalRunBtn
			// 
			externalRunBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			externalRunBtn.Enabled = false;
			externalRunBtn.ForeColor = System.Drawing.Color.Black;
			externalRunBtn.Image = (System.Drawing.Image)resources.GetObject("externalRunBtn.Image");
			externalRunBtn.Name = "externalRunBtn";
			externalRunBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E;
			externalRunBtn.Size = new System.Drawing.Size(277, 24);
			externalRunBtn.Text = "open with default";
			externalRunBtn.Click += externalRunBtn_Click;
			// 
			// externalFavoriteBtn
			// 
			externalFavoriteBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			externalFavoriteBtn.Enabled = false;
			externalFavoriteBtn.ForeColor = System.Drawing.Color.Black;
			externalFavoriteBtn.Image = Properties.Resources.black_paint;
			externalFavoriteBtn.Name = "externalFavoriteBtn";
			externalFavoriteBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.O;
			externalFavoriteBtn.Size = new System.Drawing.Size(277, 24);
			externalFavoriteBtn.Text = "open with custom";
			externalFavoriteBtn.Click += externalFavoriteBtn_Click;
			// 
			// externalChooseBtn
			// 
			externalChooseBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			externalChooseBtn.Enabled = false;
			externalChooseBtn.ForeColor = System.Drawing.Color.Black;
			externalChooseBtn.Image = (System.Drawing.Image)resources.GetObject("externalChooseBtn.Image");
			externalChooseBtn.Name = "externalChooseBtn";
			externalChooseBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.E;
			externalChooseBtn.Size = new System.Drawing.Size(277, 24);
			externalChooseBtn.Text = "choose app";
			externalChooseBtn.Click += externalButton_Click;
			// 
			// infoButton
			// 
			infoButton.AutoSize = false;
			infoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			infoButton.Enabled = false;
			infoButton.Image = (System.Drawing.Image)resources.GetObject("infoButton.Image");
			infoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			infoButton.Margin = new System.Windows.Forms.Padding(0);
			infoButton.Name = "infoButton";
			infoButton.Size = new System.Drawing.Size(24, 25);
			infoButton.Click += infoButton_Click;
			// 
			// toolStripSeparator4
			// 
			toolStripSeparator4.AutoSize = false;
			toolStripSeparator4.BackColor = System.Drawing.SystemColors.ControlLight;
			toolStripSeparator4.DarkMode = false;
			toolStripSeparator4.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
			toolStripSeparator4.InsideMenu = false;
			toolStripSeparator4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			toolStripSeparator4.Name = "toolStripSeparator4";
			toolStripSeparator4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			toolStripSeparator4.Size = new System.Drawing.Size(1, 24);
			// 
			// prevButton
			// 
			prevButton.AutoSize = false;
			prevButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			prevButton.Enabled = false;
			prevButton.Image = (System.Drawing.Image)resources.GetObject("prevButton.Image");
			prevButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			prevButton.Margin = new System.Windows.Forms.Padding(0);
			prevButton.Name = "prevButton";
			prevButton.Size = new System.Drawing.Size(24, 25);
			prevButton.Click += prevButton_Click;
			// 
			// slideshowButton
			// 
			slideshowButton.AutoSize = false;
			slideshowButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			slideshowButton.Enabled = false;
			slideshowButton.Image = (System.Drawing.Image)resources.GetObject("slideshowButton.Image");
			slideshowButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			slideshowButton.Margin = new System.Windows.Forms.Padding(0);
			slideshowButton.Name = "slideshowButton";
			slideshowButton.Size = new System.Drawing.Size(24, 25);
			slideshowButton.Click += slideshowButton_Click;
			// 
			// nextButton
			// 
			nextButton.AutoSize = false;
			nextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			nextButton.Enabled = false;
			nextButton.Image = (System.Drawing.Image)resources.GetObject("nextButton.Image");
			nextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			nextButton.Margin = new System.Windows.Forms.Padding(0);
			nextButton.Name = "nextButton";
			nextButton.Size = new System.Drawing.Size(24, 25);
			nextButton.Click += nextButton_Click;
			nextButton.EnabledChanged += nextButton_EnabledChanged;
			nextButton.VisibleChanged += nextButton_VisibleChanged;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.AutoSize = false;
			toolStripSeparator1.BackColor = System.Drawing.SystemColors.ControlLight;
			toolStripSeparator1.DarkMode = false;
			toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
			toolStripSeparator1.InsideMenu = false;
			toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			toolStripSeparator1.Size = new System.Drawing.Size(1, 24);
			// 
			// autoZoomButton
			// 
			autoZoomButton.AutoSize = false;
			autoZoomButton.Checked = true;
			autoZoomButton.CheckState = System.Windows.Forms.CheckState.Checked;
			autoZoomButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			autoZoomButton.Enabled = false;
			autoZoomButton.Image = (System.Drawing.Image)resources.GetObject("autoZoomButton.Image");
			autoZoomButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			autoZoomButton.Margin = new System.Windows.Forms.Padding(0);
			autoZoomButton.Name = "autoZoomButton";
			autoZoomButton.Size = new System.Drawing.Size(24, 25);
			autoZoomButton.Click += autoZoomButton_Click;
			// 
			// zoomOutButton
			// 
			zoomOutButton.AutoSize = false;
			zoomOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			zoomOutButton.Enabled = false;
			zoomOutButton.Image = (System.Drawing.Image)resources.GetObject("zoomOutButton.Image");
			zoomOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			zoomOutButton.Margin = new System.Windows.Forms.Padding(0);
			zoomOutButton.Name = "zoomOutButton";
			zoomOutButton.Size = new System.Drawing.Size(24, 25);
			zoomOutButton.Click += zoomOutButton_Click;
			zoomOutButton.MouseDown += zoomOutButton_MouseDown;
			zoomOutButton.MouseLeave += zoomOutButton_MouseLeave;
			zoomOutButton.MouseUp += zoomOutButton_MouseUp;
			// 
			// zoomTextBox
			// 
			zoomTextBox.BackColor = System.Drawing.Color.White;
			zoomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			zoomTextBox.Enabled = false;
			zoomTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			zoomTextBox.Margin = new System.Windows.Forms.Padding(7, -1, 7, -1);
			zoomTextBox.MaxLength = 12;
			zoomTextBox.Name = "zoomTextBox";
			zoomTextBox.Size = new System.Drawing.Size(44, 24);
			zoomTextBox.Text = "Auto";
			zoomTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			zoomTextBox.ToolTipText = "Zoom";
			zoomTextBox.KeyPress += zoomTextBox_KeyPress;
			zoomTextBox.MouseEnter += zoomTextBox_MouseEnter;
			zoomTextBox.MouseLeave += zoomTextBox_MouseLeave;
			zoomTextBox.TextChanged += zoomComboBox_TextChanged;
			// 
			// zoomInButton
			// 
			zoomInButton.AutoSize = false;
			zoomInButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			zoomInButton.Enabled = false;
			zoomInButton.Image = (System.Drawing.Image)resources.GetObject("zoomInButton.Image");
			zoomInButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			zoomInButton.Margin = new System.Windows.Forms.Padding(0);
			zoomInButton.Name = "zoomInButton";
			zoomInButton.Size = new System.Drawing.Size(24, 25);
			zoomInButton.Click += zoomInButton_Click;
			zoomInButton.MouseDown += zoomInButton_MouseDown;
			zoomInButton.MouseLeave += zoomInButton_MouseLeave;
			zoomInButton.MouseUp += zoomInButton_MouseUp;
			// 
			// zoom100Btn
			// 
			zoom100Btn.AutoSize = false;
			zoom100Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			zoom100Btn.Enabled = false;
			zoom100Btn.Image = Properties.Resources.black_actualsize;
			zoom100Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
			zoom100Btn.Margin = new System.Windows.Forms.Padding(0);
			zoom100Btn.Name = "zoom100Btn";
			zoom100Btn.Size = new System.Drawing.Size(24, 25);
			zoom100Btn.Click += zoom100Btn_Click;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.AutoSize = false;
			toolStripSeparator2.BackColor = System.Drawing.SystemColors.ControlLight;
			toolStripSeparator2.DarkMode = false;
			toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
			toolStripSeparator2.InsideMenu = false;
			toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			toolStripSeparator2.Size = new System.Drawing.Size(1, 24);
			// 
			// selectionBtn
			// 
			selectionBtn.AutoSize = false;
			selectionBtn.CheckOnClick = true;
			selectionBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			selectionBtn.Image = Properties.Resources.black_selection;
			selectionBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			selectionBtn.Margin = new System.Windows.Forms.Padding(0);
			selectionBtn.Name = "selectionBtn";
			selectionBtn.Size = new System.Drawing.Size(24, 25);
			selectionBtn.CheckedChanged += selectionBtn_CheckedChanged;
			// 
			// editButton
			// 
			editButton.AutoSize = false;
			editButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			editButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { flipHorizontalButton, flipVerticalButton, qlibToolsep4, rotateRightButton, rotateLeftButton, rotate180Button, customAngleBtn, toolStripSeparator7, cropBtn });
			editButton.ForeColor = System.Drawing.Color.Black;
			editButton.Image = Properties.Resources.black_edit;
			editButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			editButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			editButton.Margin = new System.Windows.Forms.Padding(0);
			editButton.Name = "editButton";
			editButton.Size = new System.Drawing.Size(30, 25);
			// 
			// flipHorizontalButton
			// 
			flipHorizontalButton.BackColor = System.Drawing.SystemColors.ControlLight;
			flipHorizontalButton.Enabled = false;
			flipHorizontalButton.ForeColor = System.Drawing.Color.Black;
			flipHorizontalButton.Image = (System.Drawing.Image)resources.GetObject("flipHorizontalButton.Image");
			flipHorizontalButton.Name = "flipHorizontalButton";
			flipHorizontalButton.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H;
			flipHorizontalButton.Size = new System.Drawing.Size(243, 24);
			flipHorizontalButton.Text = "flip horizontal";
			flipHorizontalButton.Click += flipHorizontalButton_Click;
			// 
			// flipVerticalButton
			// 
			flipVerticalButton.BackColor = System.Drawing.SystemColors.ControlLight;
			flipVerticalButton.Enabled = false;
			flipVerticalButton.ForeColor = System.Drawing.Color.Black;
			flipVerticalButton.Image = (System.Drawing.Image)resources.GetObject("flipVerticalButton.Image");
			flipVerticalButton.Name = "flipVerticalButton";
			flipVerticalButton.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.H;
			flipVerticalButton.Size = new System.Drawing.Size(243, 24);
			flipVerticalButton.Text = "flip vertical";
			flipVerticalButton.Click += flipVerticalButton_Click;
			// 
			// qlibToolsep4
			// 
			qlibToolsep4.AutoSize = false;
			qlibToolsep4.BackColor = System.Drawing.SystemColors.ControlLight;
			qlibToolsep4.DarkMode = false;
			qlibToolsep4.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
			qlibToolsep4.InsideMenu = true;
			qlibToolsep4.Margin = new System.Windows.Forms.Padding(4);
			qlibToolsep4.Name = "qlibToolsep4";
			qlibToolsep4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			qlibToolsep4.Size = new System.Drawing.Size(240, 6);
			// 
			// rotateRightButton
			// 
			rotateRightButton.BackColor = System.Drawing.SystemColors.ControlLight;
			rotateRightButton.Enabled = false;
			rotateRightButton.ForeColor = System.Drawing.Color.Black;
			rotateRightButton.Image = Properties.Resources.black_rotater;
			rotateRightButton.Name = "rotateRightButton";
			rotateRightButton.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G;
			rotateRightButton.Size = new System.Drawing.Size(243, 24);
			rotateRightButton.Text = "rotate right";
			rotateRightButton.Click += rotateRightButton_Click;
			// 
			// rotateLeftButton
			// 
			rotateLeftButton.BackColor = System.Drawing.SystemColors.ControlLight;
			rotateLeftButton.Enabled = false;
			rotateLeftButton.ForeColor = System.Drawing.Color.Black;
			rotateLeftButton.Image = (System.Drawing.Image)resources.GetObject("rotateLeftButton.Image");
			rotateLeftButton.Name = "rotateLeftButton";
			rotateLeftButton.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.G;
			rotateLeftButton.Size = new System.Drawing.Size(243, 24);
			rotateLeftButton.Text = "rotate left";
			rotateLeftButton.Click += rotateLeftButton_Click;
			// 
			// rotate180Button
			// 
			rotate180Button.BackColor = System.Drawing.SystemColors.ControlLight;
			rotate180Button.Enabled = false;
			rotate180Button.ForeColor = System.Drawing.Color.Black;
			rotate180Button.Image = (System.Drawing.Image)resources.GetObject("rotate180Button.Image");
			rotate180Button.Name = "rotate180Button";
			rotate180Button.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J;
			rotate180Button.Size = new System.Drawing.Size(243, 24);
			rotate180Button.Text = "rotate 180";
			rotate180Button.Click += rotate180Button_Click;
			// 
			// customAngleBtn
			// 
			customAngleBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			customAngleBtn.Enabled = false;
			customAngleBtn.ForeColor = System.Drawing.Color.Black;
			customAngleBtn.Image = Properties.Resources.black_angle;
			customAngleBtn.Name = "customAngleBtn";
			customAngleBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.J;
			customAngleBtn.Size = new System.Drawing.Size(243, 24);
			customAngleBtn.Text = "custom angle";
			customAngleBtn.Visible = false;
			// 
			// toolStripSeparator7
			// 
			toolStripSeparator7.AutoSize = false;
			toolStripSeparator7.BackColor = System.Drawing.SystemColors.ControlLight;
			toolStripSeparator7.DarkMode = false;
			toolStripSeparator7.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
			toolStripSeparator7.InsideMenu = true;
			toolStripSeparator7.Margin = new System.Windows.Forms.Padding(4);
			toolStripSeparator7.Name = "toolStripSeparator7";
			toolStripSeparator7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			toolStripSeparator7.Size = new System.Drawing.Size(240, 6);
			// 
			// cropBtn
			// 
			cropBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			cropBtn.ForeColor = System.Drawing.Color.Black;
			cropBtn.Image = Properties.Resources.black_crop;
			cropBtn.Name = "cropBtn";
			cropBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.X;
			cropBtn.Size = new System.Drawing.Size(243, 24);
			cropBtn.Text = "crop";
			cropBtn.Click += cropBtn_Click;
			// 
			// filteringModeBtn
			// 
			filteringModeBtn.AutoSize = false;
			filteringModeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			filteringModeBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { bilinearBtn, nearestNeighborBtn });
			filteringModeBtn.Image = Properties.Resources.black_filtering;
			filteringModeBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			filteringModeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			filteringModeBtn.Margin = new System.Windows.Forms.Padding(0);
			filteringModeBtn.Name = "filteringModeBtn";
			filteringModeBtn.Size = new System.Drawing.Size(30, 25);
			// 
			// bilinearBtn
			// 
			bilinearBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			bilinearBtn.ForeColor = System.Drawing.Color.Black;
			bilinearBtn.Image = Properties.Resources.black_bilinear;
			bilinearBtn.Name = "bilinearBtn";
			bilinearBtn.Size = new System.Drawing.Size(186, 24);
			bilinearBtn.Text = "Bilinear";
			bilinearBtn.Click += bilinearBtn_Click;
			// 
			// nearestNeighborBtn
			// 
			nearestNeighborBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			nearestNeighborBtn.ForeColor = System.Drawing.Color.Black;
			nearestNeighborBtn.Image = Properties.Resources.black_nearest_neighbor;
			nearestNeighborBtn.Name = "nearestNeighborBtn";
			nearestNeighborBtn.Size = new System.Drawing.Size(186, 24);
			nearestNeighborBtn.Text = "Nearest Neighbor";
			nearestNeighborBtn.Click += nearestNeighborBtn_Click;
			// 
			// effectsBtn
			// 
			effectsBtn.AutoSize = false;
			effectsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			effectsBtn.Image = Properties.Resources.black_effects;
			effectsBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			effectsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			effectsBtn.Margin = new System.Windows.Forms.Padding(0);
			effectsBtn.Name = "effectsBtn";
			effectsBtn.Size = new System.Drawing.Size(30, 25);
			effectsBtn.Visible = false;
			effectsBtn.DropDownOpening += effectsBtn_DropDownOpening;
			// 
			// toolsBtn
			// 
			toolsBtn.AutoSize = false;
			toolsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			toolsBtn.Image = Properties.Resources.black_tools;
			toolsBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			toolsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			toolsBtn.Margin = new System.Windows.Forms.Padding(0);
			toolsBtn.Name = "toolsBtn";
			toolsBtn.Size = new System.Drawing.Size(30, 25);
			toolsBtn.Visible = false;
			toolsBtn.DropDownOpening += effectsBtn_DropDownOpening;
			// 
			// toolStripSeparator3
			// 
			toolStripSeparator3.AutoSize = false;
			toolStripSeparator3.BackColor = System.Drawing.SystemColors.ControlLight;
			toolStripSeparator3.DarkMode = false;
			toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
			toolStripSeparator3.InsideMenu = false;
			toolStripSeparator3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			toolStripSeparator3.Size = new System.Drawing.Size(1, 24);
			// 
			// checkboardButton
			// 
			checkboardButton.AutoSize = false;
			checkboardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			checkboardButton.Image = Properties.Resources.black_grid;
			checkboardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			checkboardButton.Margin = new System.Windows.Forms.Padding(0);
			checkboardButton.Name = "checkboardButton";
			checkboardButton.Size = new System.Drawing.Size(24, 25);
			checkboardButton.Click += checkboardButton_Click;
			// 
			// fullscreenBtn
			// 
			fullscreenBtn.AutoSize = false;
			fullscreenBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			fullscreenBtn.Image = (System.Drawing.Image)resources.GetObject("fullscreenBtn.Image");
			fullscreenBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			fullscreenBtn.Margin = new System.Windows.Forms.Padding(0);
			fullscreenBtn.Name = "fullscreenBtn";
			fullscreenBtn.Size = new System.Drawing.Size(24, 25);
			fullscreenBtn.Click += fullscreenButton_Click;
			// 
			// miniViewButton
			// 
			miniViewButton.AutoSize = false;
			miniViewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			miniViewButton.Enabled = false;
			miniViewButton.Image = (System.Drawing.Image)resources.GetObject("miniViewButton.Image");
			miniViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			miniViewButton.Margin = new System.Windows.Forms.Padding(0);
			miniViewButton.Name = "miniViewButton";
			miniViewButton.Size = new System.Drawing.Size(24, 25);
			miniViewButton.Click += miniViewButton_Click;
			// 
			// qlibToolsep1
			// 
			qlibToolsep1.AutoSize = false;
			qlibToolsep1.BackColor = System.Drawing.SystemColors.ControlLight;
			qlibToolsep1.DarkMode = false;
			qlibToolsep1.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
			qlibToolsep1.InsideMenu = false;
			qlibToolsep1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			qlibToolsep1.Name = "qlibToolsep1";
			qlibToolsep1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			qlibToolsep1.Size = new System.Drawing.Size(1, 24);
			// 
			// moreButton
			// 
			moreButton.AutoSize = false;
			moreButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			moreButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { reloadButton, deleteBtn, permDeleteBtn, printButton, toolStripSeparator9, backColorBtn, onTopButton, framelessBtn, newWindowButton, qlibToolsep2, pluginManBtn, toolStripSeparator10, settingsButton, aboutBtn });
			moreButton.Image = (System.Drawing.Image)resources.GetObject("moreButton.Image");
			moreButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			moreButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			moreButton.Margin = new System.Windows.Forms.Padding(0);
			moreButton.Name = "moreButton";
			moreButton.Size = new System.Drawing.Size(30, 25);
			// 
			// reloadButton
			// 
			reloadButton.BackColor = System.Drawing.SystemColors.ControlLight;
			reloadButton.Enabled = false;
			reloadButton.ForeColor = System.Drawing.Color.Black;
			reloadButton.Image = Properties.Resources.black_sync;
			reloadButton.Name = "reloadButton";
			reloadButton.ShortcutKeys = System.Windows.Forms.Keys.F5;
			reloadButton.Size = new System.Drawing.Size(262, 24);
			reloadButton.Text = "reload file";
			reloadButton.Click += reloadButton_Click;
			// 
			// deleteBtn
			// 
			deleteBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			deleteBtn.Enabled = false;
			deleteBtn.ForeColor = System.Drawing.Color.Black;
			deleteBtn.Image = Properties.Resources.black_trash;
			deleteBtn.Name = "deleteBtn";
			deleteBtn.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			deleteBtn.Size = new System.Drawing.Size(262, 24);
			deleteBtn.Text = "move to trash";
			deleteBtn.Click += deleteButton_Click;
			// 
			// permDeleteBtn
			// 
			permDeleteBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			permDeleteBtn.Enabled = false;
			permDeleteBtn.ForeColor = System.Drawing.Color.Black;
			permDeleteBtn.Image = Properties.Resources.black_permdel;
			permDeleteBtn.Name = "permDeleteBtn";
			permDeleteBtn.ShortcutKeys = System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete;
			permDeleteBtn.Size = new System.Drawing.Size(262, 24);
			permDeleteBtn.Text = "permanently delete";
			permDeleteBtn.Click += permDeleteBtn_Click;
			// 
			// printButton
			// 
			printButton.BackColor = System.Drawing.SystemColors.ControlLight;
			printButton.Enabled = false;
			printButton.ForeColor = System.Drawing.Color.Black;
			printButton.Image = (System.Drawing.Image)resources.GetObject("printButton.Image");
			printButton.Name = "printButton";
			printButton.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P;
			printButton.Size = new System.Drawing.Size(262, 24);
			printButton.Text = "print";
			printButton.Click += printButton_Click;
			// 
			// toolStripSeparator9
			// 
			toolStripSeparator9.AutoSize = false;
			toolStripSeparator9.BackColor = System.Drawing.SystemColors.ControlLight;
			toolStripSeparator9.DarkMode = false;
			toolStripSeparator9.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
			toolStripSeparator9.InsideMenu = true;
			toolStripSeparator9.Margin = new System.Windows.Forms.Padding(4);
			toolStripSeparator9.Name = "toolStripSeparator9";
			toolStripSeparator9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			toolStripSeparator9.Size = new System.Drawing.Size(259, 6);
			// 
			// backColorBtn
			// 
			backColorBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			backColorBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { backCustomBtn, qlibMenuSeparator1, backClearBtn });
			backColorBtn.ForeColor = System.Drawing.Color.Black;
			backColorBtn.Image = Properties.Resources.black_palette;
			backColorBtn.Name = "backColorBtn";
			backColorBtn.Size = new System.Drawing.Size(262, 24);
			backColorBtn.Text = "background color";
			// 
			// backCustomBtn
			// 
			backCustomBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			backCustomBtn.ForeColor = System.Drawing.Color.Black;
			backCustomBtn.Image = Properties.Resources.black_palette;
			backCustomBtn.Name = "backCustomBtn";
			backCustomBtn.ShortcutKeys = System.Windows.Forms.Keys.F3;
			backCustomBtn.Size = new System.Drawing.Size(179, 24);
			backCustomBtn.Text = "choose color";
			backCustomBtn.Click += backCustomBtn_Click;
			// 
			// qlibMenuSeparator1
			// 
			qlibMenuSeparator1.AutoSize = false;
			qlibMenuSeparator1.BackColor = System.Drawing.SystemColors.ControlLight;
			qlibMenuSeparator1.DarkMode = false;
			qlibMenuSeparator1.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
			qlibMenuSeparator1.InsideMenu = true;
			qlibMenuSeparator1.Margin = new System.Windows.Forms.Padding(4);
			qlibMenuSeparator1.Name = "qlibMenuSeparator1";
			qlibMenuSeparator1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			qlibMenuSeparator1.Size = new System.Drawing.Size(176, 6);
			// 
			// backClearBtn
			// 
			backClearBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			backClearBtn.ForeColor = System.Drawing.Color.Black;
			backClearBtn.Image = (System.Drawing.Image)resources.GetObject("backClearBtn.Image");
			backClearBtn.Name = "backClearBtn";
			backClearBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3;
			backClearBtn.Size = new System.Drawing.Size(179, 24);
			backClearBtn.Text = "clear";
			backClearBtn.Click += backClearBtn_Click;
			// 
			// onTopButton
			// 
			onTopButton.BackColor = System.Drawing.SystemColors.ControlLight;
			onTopButton.ForeColor = System.Drawing.Color.Black;
			onTopButton.Image = (System.Drawing.Image)resources.GetObject("onTopButton.Image");
			onTopButton.Name = "onTopButton";
			onTopButton.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T;
			onTopButton.Size = new System.Drawing.Size(262, 24);
			onTopButton.Text = "always on top";
			onTopButton.Click += onTopButton_Click;
			// 
			// framelessBtn
			// 
			framelessBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			framelessBtn.ForeColor = System.Drawing.Color.Black;
			framelessBtn.Image = (System.Drawing.Image)resources.GetObject("framelessBtn.Image");
			framelessBtn.Name = "framelessBtn";
			framelessBtn.ShortcutKeys = System.Windows.Forms.Keys.F10;
			framelessBtn.Size = new System.Drawing.Size(262, 24);
			framelessBtn.Text = "frameless mode";
			framelessBtn.Click += framelessBtn_Click;
			// 
			// newWindowButton
			// 
			newWindowButton.BackColor = System.Drawing.SystemColors.ControlLight;
			newWindowButton.ForeColor = System.Drawing.Color.Black;
			newWindowButton.Image = Properties.Resources.black_newwindow;
			newWindowButton.Name = "newWindowButton";
			newWindowButton.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
			newWindowButton.Size = new System.Drawing.Size(262, 24);
			newWindowButton.Text = "new window";
			newWindowButton.Click += newWindowButton_Click;
			// 
			// qlibToolsep2
			// 
			qlibToolsep2.AutoSize = false;
			qlibToolsep2.BackColor = System.Drawing.SystemColors.ControlLight;
			qlibToolsep2.DarkMode = false;
			qlibToolsep2.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
			qlibToolsep2.InsideMenu = true;
			qlibToolsep2.Margin = new System.Windows.Forms.Padding(4);
			qlibToolsep2.Name = "qlibToolsep2";
			qlibToolsep2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			qlibToolsep2.Size = new System.Drawing.Size(259, 6);
			// 
			// pluginManBtn
			// 
			pluginManBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			pluginManBtn.ForeColor = System.Drawing.Color.Black;
			pluginManBtn.Image = Properties.Resources.black_plugin;
			pluginManBtn.Name = "pluginManBtn";
			pluginManBtn.ShortcutKeys = System.Windows.Forms.Keys.F2;
			pluginManBtn.Size = new System.Drawing.Size(262, 24);
			pluginManBtn.Text = "plugin manager";
			pluginManBtn.Click += pluginManBtn_Click_1;
			// 
			// toolStripSeparator10
			// 
			toolStripSeparator10.AutoSize = false;
			toolStripSeparator10.BackColor = System.Drawing.SystemColors.ControlLight;
			toolStripSeparator10.DarkMode = false;
			toolStripSeparator10.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
			toolStripSeparator10.InsideMenu = true;
			toolStripSeparator10.Margin = new System.Windows.Forms.Padding(4);
			toolStripSeparator10.Name = "toolStripSeparator10";
			toolStripSeparator10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			toolStripSeparator10.Size = new System.Drawing.Size(259, 6);
			// 
			// settingsButton
			// 
			settingsButton.BackColor = System.Drawing.SystemColors.ControlLight;
			settingsButton.ForeColor = System.Drawing.Color.Black;
			settingsButton.Image = Properties.Resources.black_settings;
			settingsButton.Name = "settingsButton";
			settingsButton.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemcomma;
			settingsButton.Size = new System.Drawing.Size(262, 24);
			settingsButton.Text = "settings";
			settingsButton.Click += settingsButton_Click;
			// 
			// aboutBtn
			// 
			aboutBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			aboutBtn.ForeColor = System.Drawing.Color.Black;
			aboutBtn.Image = Properties.Resources.black_about;
			aboutBtn.Name = "aboutBtn";
			aboutBtn.ShortcutKeys = System.Windows.Forms.Keys.F1;
			aboutBtn.Size = new System.Drawing.Size(262, 24);
			aboutBtn.Text = "about";
			aboutBtn.Click += aboutButton_Click;
			// 
			// framelessCloseBtn
			// 
			framelessCloseBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			framelessCloseBtn.AutoSize = false;
			framelessCloseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			framelessCloseBtn.Image = Properties.Resources.black_close;
			framelessCloseBtn.Margin = new System.Windows.Forms.Padding(0);
			framelessCloseBtn.Name = "framelessCloseBtn";
			framelessCloseBtn.Size = new System.Drawing.Size(24, 25);
			framelessCloseBtn.Visible = false;
			framelessCloseBtn.Click += framelessCloseBtn_Click;
			// 
			// rmbMenu
			// 
			rmbMenu.BackColor = System.Drawing.SystemColors.ControlLight;
			rmbMenu.DarkMode = false;
			rmbMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			rmbMenu.ForeColor = System.Drawing.Color.Black;
			rmbMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { showMenuItem, qlibToolsep5, wallpaperBtn, qlibToolsep3, copyBtn, pasteBtn, selectAllBtn });
			rmbMenu.Name = "rmbMenu";
			rmbMenu.Size = new System.Drawing.Size(288, 152);
			rmbMenu.Opening += rmbMenu_Opening;
			// 
			// showMenuItem
			// 
			showMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
			showMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { showNavArrowsBtn, showToolbarBtn, showStatusbarBtn });
			showMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
			showMenuItem.ForeColor = System.Drawing.Color.Black;
			showMenuItem.Image = Properties.Resources.black_show;
			showMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			showMenuItem.Name = "showMenuItem";
			showMenuItem.Size = new System.Drawing.Size(287, 24);
			showMenuItem.Text = "view";
			// 
			// showNavArrowsBtn
			// 
			showNavArrowsBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			showNavArrowsBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
			showNavArrowsBtn.ForeColor = System.Drawing.Color.Black;
			showNavArrowsBtn.Image = Properties.Resources.black_arrows;
			showNavArrowsBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			showNavArrowsBtn.Name = "showNavArrowsBtn";
			showNavArrowsBtn.ShortcutKeys = System.Windows.Forms.Keys.F6;
			showNavArrowsBtn.Size = new System.Drawing.Size(205, 24);
			showNavArrowsBtn.Text = "show nav arrows";
			showNavArrowsBtn.Click += showNavArrowsBtn_Click;
			// 
			// showToolbarBtn
			// 
			showToolbarBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			showToolbarBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
			showToolbarBtn.ForeColor = System.Drawing.Color.Black;
			showToolbarBtn.Image = Properties.Resources.black_toolbar;
			showToolbarBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			showToolbarBtn.Name = "showToolbarBtn";
			showToolbarBtn.ShortcutKeys = System.Windows.Forms.Keys.F7;
			showToolbarBtn.Size = new System.Drawing.Size(205, 24);
			showToolbarBtn.Text = "show toolbar";
			showToolbarBtn.Click += showToolbarBtn_Click;
			// 
			// showStatusbarBtn
			// 
			showStatusbarBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			showStatusbarBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
			showStatusbarBtn.ForeColor = System.Drawing.Color.Black;
			showStatusbarBtn.Image = Properties.Resources.black_statusbar;
			showStatusbarBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			showStatusbarBtn.Name = "showStatusbarBtn";
			showStatusbarBtn.ShortcutKeys = System.Windows.Forms.Keys.F8;
			showStatusbarBtn.Size = new System.Drawing.Size(205, 24);
			showStatusbarBtn.Text = "show status bar";
			showStatusbarBtn.Click += showStatusBarBtn_Click;
			// 
			// qlibToolsep5
			// 
			qlibToolsep5.AutoSize = false;
			qlibToolsep5.BackColor = System.Drawing.SystemColors.ControlLight;
			qlibToolsep5.DarkMode = false;
			qlibToolsep5.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
			qlibToolsep5.InsideMenu = true;
			qlibToolsep5.Margin = new System.Windows.Forms.Padding(4);
			qlibToolsep5.Name = "qlibToolsep5";
			qlibToolsep5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			qlibToolsep5.Size = new System.Drawing.Size(284, 6);
			// 
			// wallpaperBtn
			// 
			wallpaperBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			wallpaperBtn.Enabled = false;
			wallpaperBtn.ForeColor = System.Drawing.Color.Black;
			wallpaperBtn.Image = Properties.Resources.black_desktop;
			wallpaperBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			wallpaperBtn.Name = "wallpaperBtn";
			wallpaperBtn.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B;
			wallpaperBtn.Size = new System.Drawing.Size(287, 24);
			wallpaperBtn.Text = "set as desktop background";
			wallpaperBtn.Click += wallpaperBtn_Click;
			// 
			// qlibToolsep3
			// 
			qlibToolsep3.AutoSize = false;
			qlibToolsep3.BackColor = System.Drawing.SystemColors.ControlLight;
			qlibToolsep3.DarkMode = false;
			qlibToolsep3.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
			qlibToolsep3.InsideMenu = true;
			qlibToolsep3.Margin = new System.Windows.Forms.Padding(4);
			qlibToolsep3.Name = "qlibToolsep3";
			qlibToolsep3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			qlibToolsep3.Size = new System.Drawing.Size(284, 6);
			// 
			// copyBtn
			// 
			copyBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			copyBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { copyImageBtn, copyFileBtn });
			copyBtn.ForeColor = System.Drawing.Color.Black;
			copyBtn.Image = Properties.Resources.black_copy;
			copyBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			copyBtn.Name = "copyBtn";
			copyBtn.Size = new System.Drawing.Size(287, 24);
			copyBtn.Text = "copy";
			// 
			// copyImageBtn
			// 
			copyImageBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			copyImageBtn.ForeColor = System.Drawing.Color.Black;
			copyImageBtn.Image = Properties.Resources.black_image;
			copyImageBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			copyImageBtn.Name = "copyImageBtn";
			copyImageBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C;
			copyImageBtn.Size = new System.Drawing.Size(215, 24);
			copyImageBtn.Text = "copy image";
			copyImageBtn.Click += copyImageBtn_Click;
			copyImageBtn.EnabledChanged += copyImageBtn_EnabledChanged;
			// 
			// copyFileBtn
			// 
			copyFileBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			copyFileBtn.ForeColor = System.Drawing.Color.Black;
			copyFileBtn.Image = Properties.Resources.black_imgfile;
			copyFileBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			copyFileBtn.Name = "copyFileBtn";
			copyFileBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.C;
			copyFileBtn.Size = new System.Drawing.Size(215, 24);
			copyFileBtn.Text = "copy file";
			copyFileBtn.Click += copyFileBtn_Click_1;
			copyFileBtn.EnabledChanged += copyImageBtn_EnabledChanged;
			// 
			// pasteBtn
			// 
			pasteBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			pasteBtn.ForeColor = System.Drawing.Color.Black;
			pasteBtn.Image = Properties.Resources.black_paste;
			pasteBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			pasteBtn.Name = "pasteBtn";
			pasteBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V;
			pasteBtn.Size = new System.Drawing.Size(287, 24);
			pasteBtn.Text = "paste";
			pasteBtn.Click += pasteBtn_Click;
			// 
			// selectAllBtn
			// 
			selectAllBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			selectAllBtn.Enabled = false;
			selectAllBtn.ForeColor = System.Drawing.Color.Black;
			selectAllBtn.Image = Properties.Resources.black_selectall;
			selectAllBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			selectAllBtn.Name = "selectAllBtn";
			selectAllBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A;
			selectAllBtn.Size = new System.Drawing.Size(287, 24);
			selectAllBtn.Text = "select all";
			selectAllBtn.Click += selectAllBtn_Click;
			// 
			// suggestionLabel
			// 
			suggestionLabel.AutoSize = true;
			suggestionLabel.BackColor = System.Drawing.Color.Black;
			suggestionLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
			suggestionLabel.ForeColor = System.Drawing.Color.White;
			suggestionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			suggestionLabel.Location = new System.Drawing.Point(53, 59);
			suggestionLabel.Margin = new System.Windows.Forms.Padding(0, 27, 0, 0);
			suggestionLabel.Name = "suggestionLabel";
			suggestionLabel.Padding = new System.Windows.Forms.Padding(0, 3, 3, 4);
			suggestionLabel.Size = new System.Drawing.Size(79, 26);
			suggestionLabel.TabIndex = 3;
			suggestionLabel.Text = "suggestion";
			suggestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			suggestionLabel.Visible = false;
			// 
			// picturePanel
			// 
			picturePanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			picturePanel.AutoScroll = true;
			picturePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			picturePanel.BackColor = System.Drawing.Color.Transparent;
			picturePanel.Controls.Add(pleaseOpenLabel);
			picturePanel.Controls.Add(pictureBox);
			picturePanel.Location = new System.Drawing.Point(0, 32);
			picturePanel.Margin = new System.Windows.Forms.Padding(0);
			picturePanel.Name = "picturePanel";
			picturePanel.Size = new System.Drawing.Size(684, 385);
			picturePanel.TabIndex = 2;
			picturePanel.SizeChanged += picturePanel_SizeChanged;
			picturePanel.DoubleClick += picturePanel_DoubleClick;
			picturePanel.MouseClick += picturePanel_MouseClick;
			picturePanel.MouseDown += picturePanel_MouseDown;
			picturePanel.MouseEnter += picturePanel_MouseEnter;
			picturePanel.MouseMove += picturePanel_MouseMove;
			picturePanel.MouseUp += picturePanel_MouseUp;
			// 
			// pleaseOpenLabel
			// 
			pleaseOpenLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			pleaseOpenLabel.Enabled = false;
			pleaseOpenLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
			pleaseOpenLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			pleaseOpenLabel.Location = new System.Drawing.Point(0, 0);
			pleaseOpenLabel.Margin = new System.Windows.Forms.Padding(0);
			pleaseOpenLabel.Name = "pleaseOpenLabel";
			pleaseOpenLabel.Size = new System.Drawing.Size(684, 385);
			pleaseOpenLabel.TabIndex = 5;
			pleaseOpenLabel.Text = "please open image";
			pleaseOpenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			pleaseOpenLabel.DoubleClick += picturePanel_DoubleClick;
			// 
			// pictureBox
			// 
			pictureBox.BackColor = System.Drawing.Color.Transparent;
			pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			pictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			pictureBox.InitialImage = null;
			pictureBox.Location = new System.Drawing.Point(0, 0);
			pictureBox.Margin = new System.Windows.Forms.Padding(0);
			pictureBox.Name = "pictureBox";
			pictureBox.Size = new System.Drawing.Size(684, 385);
			pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox.TabIndex = 0;
			pictureBox.TabStop = false;
			pictureBox.DoubleClick += picturePanel_DoubleClick;
			pictureBox.MouseClick += picturePanel_MouseClick;
			pictureBox.MouseDown += picturePanel_MouseDown;
			pictureBox.MouseEnter += picturePanel_MouseEnter;
			pictureBox.MouseMove += picturePanel_MouseMove;
			pictureBox.MouseUp += picturePanel_MouseUp;
			// 
			// suggestionIcon
			// 
			suggestionIcon.BackColor = System.Drawing.Color.Black;
			suggestionIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			suggestionIcon.Location = new System.Drawing.Point(27, 59);
			suggestionIcon.Margin = new System.Windows.Forms.Padding(27, 27, 0, 0);
			suggestionIcon.Name = "suggestionIcon";
			suggestionIcon.Size = new System.Drawing.Size(26, 26);
			suggestionIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			suggestionIcon.TabIndex = 6;
			suggestionIcon.TabStop = false;
			suggestionIcon.Visible = false;
			// 
			// navNextBtn
			// 
			navNextBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
			navNextBtn.BackColor = System.Drawing.Color.Black;
			navNextBtn.FlatAppearance.BorderSize = 0;
			navNextBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(67, 67, 67);
			navNextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(56, 56, 56);
			navNextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			navNextBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			navNextBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			navNextBtn.Image = Properties.Resources.white_next;
			navNextBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			navNextBtn.Location = new System.Drawing.Point(625, 193);
			navNextBtn.Margin = new System.Windows.Forms.Padding(27);
			navNextBtn.Name = "navNextBtn";
			navNextBtn.Size = new System.Drawing.Size(32, 64);
			navNextBtn.TabIndex = 8;
			navNextBtn.TabStop = false;
			navNextBtn.UseVisualStyleBackColor = false;
			navNextBtn.Visible = false;
			navNextBtn.Click += navNextBtn_Click;
			// 
			// navPrevBtn
			// 
			navPrevBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
			navPrevBtn.BackColor = System.Drawing.Color.Black;
			navPrevBtn.FlatAppearance.BorderSize = 0;
			navPrevBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(67, 67, 67);
			navPrevBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(56, 56, 56);
			navPrevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			navPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			navPrevBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			navPrevBtn.Image = Properties.Resources.white_prev;
			navPrevBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			navPrevBtn.Location = new System.Drawing.Point(27, 193);
			navPrevBtn.Margin = new System.Windows.Forms.Padding(27);
			navPrevBtn.Name = "navPrevBtn";
			navPrevBtn.Size = new System.Drawing.Size(32, 64);
			navPrevBtn.TabIndex = 7;
			navPrevBtn.TabStop = false;
			navPrevBtn.UseVisualStyleBackColor = false;
			navPrevBtn.Visible = false;
			navPrevBtn.Click += navPrevBtn_Click;
			// 
			// typeOpsButton
			// 
			typeOpsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			typeOpsButton.BackColor = System.Drawing.Color.Black;
			typeOpsButton.FlatAppearance.BorderSize = 0;
			typeOpsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(67, 67, 67);
			typeOpsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(56, 56, 56);
			typeOpsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			typeOpsButton.Font = new System.Drawing.Font("Segoe UI", 10F);
			typeOpsButton.ForeColor = System.Drawing.Color.White;
			typeOpsButton.Image = Properties.Resources.white_options;
			typeOpsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			typeOpsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			typeOpsButton.Location = new System.Drawing.Point(537, 358);
			typeOpsButton.Margin = new System.Windows.Forms.Padding(27);
			typeOpsButton.Name = "typeOpsButton";
			typeOpsButton.Size = new System.Drawing.Size(120, 32);
			typeOpsButton.TabIndex = 0;
			typeOpsButton.TabStop = false;
			typeOpsButton.Text = " type options";
			typeOpsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			typeOpsButton.UseVisualStyleBackColor = false;
			typeOpsButton.Visible = false;
			typeOpsButton.Click += typeOpsButton_Click;
			// 
			// MainForm
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(684, 446);
			Controls.Add(suggestionIcon);
			Controls.Add(suggestionLabel);
			Controls.Add(navNextBtn);
			Controls.Add(navPrevBtn);
			Controls.Add(typeOpsButton);
			Controls.Add(statusStrip1);
			Controls.Add(toolStrip1);
			Controls.Add(picturePanel);
			Font = new System.Drawing.Font("Segoe UI", 10F);
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			KeyPreview = true;
			MinimumSize = new System.Drawing.Size(420, 320);
			Name = "MainForm";
			Text = "Quick Picture Viewer";
			FormClosed += MainForm_FormClosed;
			Shown += MainForm_Shown;
			ResizeEnd += MainForm_ResizeEnd;
			KeyDown += MainForm_KeyDown;
			((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			rmbMenu.ResumeLayout(false);
			picturePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
			((System.ComponentModel.ISupportInitialize)suggestionIcon).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private QuickPictureBox pictureBox;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private QuickLibrary.QlibToolbar toolStrip1;
		private QuickLibrary.QlibToolsep toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton zoomInButton;
		private System.Windows.Forms.ToolStripButton zoomOutButton;
		private System.Windows.Forms.ToolStripButton autoZoomButton;
		private QuickLibrary.QlibToolsep toolStripSeparator2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStripButton framelessCloseBtn;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel directoryLabel;
		private System.Windows.Forms.ToolStripStatusLabel fileLabel;
		private System.Windows.Forms.ToolStripStatusLabel sizeLabel;
		private System.Windows.Forms.ToolStripStatusLabel zoomLabel;
		private System.Windows.Forms.ToolStripButton nextButton;
		private QuickLibrary.QlibToolsep toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton prevButton;
		private System.Windows.Forms.ToolStripStatusLabel dateCreatedLabel;
		private System.Windows.Forms.ToolStripStatusLabel dateModifiedLabel;
		private System.Windows.Forms.ToolStripButton infoButton;
		private CustomPanel picturePanel;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.ToolStripStatusLabel hasChangesLabel;
		private System.Windows.Forms.ToolStripButton checkboardButton;
		private System.Windows.Forms.Label suggestionLabel;
		private System.Windows.Forms.ToolStripButton slideshowButton;
		private System.Windows.Forms.ToolStripDropDownButton moreButton;
		private System.Windows.Forms.Button typeOpsButton;
		private System.Windows.Forms.ToolStripMenuItem reloadButton;
		private System.Windows.Forms.ToolStripDropDownButton editButton;
		private System.Windows.Forms.ToolStripMenuItem rotateLeftButton;
		private System.Windows.Forms.ToolStripMenuItem rotateRightButton;
		private System.Windows.Forms.ToolStripMenuItem flipHorizontalButton;
		private System.Windows.Forms.ToolStripMenuItem flipVerticalButton;
		private System.Windows.Forms.ToolStripMenuItem newWindowButton;
		private System.Windows.Forms.ToolStripMenuItem rotate180Button;
		private System.Windows.Forms.ToolStripButton miniViewButton;
		private System.Windows.Forms.ToolStripMenuItem settingsButton;
		private System.Windows.Forms.Label pleaseOpenLabel;
		private QuickLibrary.QlibToolsep toolStripSeparator7;
		private QuickLibrary.QlibToolsep toolStripSeparator9;
		private QuickLibrary.QlibToolsep toolStripSeparator10;
		private System.Windows.Forms.ToolStripMenuItem printButton;
		private System.Windows.Forms.ToolStripMenuItem onTopButton;
		private System.Windows.Forms.ToolStripTextBox zoomTextBox;
		private System.Windows.Forms.ToolStripDropDownButton externalBtn;
		private System.Windows.Forms.ToolStripMenuItem externalRunBtn;
		private System.Windows.Forms.ToolStripMenuItem externalChooseBtn;
		private System.Windows.Forms.ToolStripMenuItem externalFavoriteBtn;
		private System.Windows.Forms.ToolStripMenuItem backColorBtn;
		private System.Windows.Forms.ToolStripMenuItem backClearBtn;
		private QuickLibrary.QlibToolsep qlibMenuSeparator1;
		private System.Windows.Forms.ToolStripMenuItem backCustomBtn;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.ToolStripMenuItem deleteBtn;
		private System.Windows.Forms.ToolStripMenuItem aboutBtn;
		private System.Windows.Forms.ToolStripMenuItem framelessBtn;
		private System.Windows.Forms.ToolStripMenuItem customAngleBtn;
		private QuickLibrary.QlibToolsep toolStripSeparator3;
		private System.Windows.Forms.ToolStripDropDownButton effectsBtn;
		private System.Windows.Forms.PictureBox suggestionIcon;
		private System.Windows.Forms.ToolStripDropDownButton toolsBtn;
		private QuickLibrary.QlibToolsep qlibToolsep1;
		private System.Windows.Forms.ToolStripButton fullscreenBtn;
		private QuickLibrary.QlibContextMenuStrip rmbMenu;
		private System.Windows.Forms.ToolStripMenuItem showMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showStatusbarBtn;
		private System.Windows.Forms.ToolStripMenuItem showToolbarBtn;
		private System.Windows.Forms.ToolStripMenuItem pasteBtn;
		private System.Windows.Forms.ToolStripMenuItem pluginManBtn;
		private QuickLibrary.QlibToolsep qlibToolsep2;
		private System.Windows.Forms.ToolStripMenuItem copyBtn;
		private System.Windows.Forms.ToolStripMenuItem copyImageBtn;
		private System.Windows.Forms.ToolStripMenuItem copyFileBtn;
		private QuickLibrary.QlibToolsep qlibToolsep3;
		private System.Windows.Forms.ToolStripDropDownButton openBtn;
		private System.Windows.Forms.ToolStripMenuItem openFileBtn;
		private System.Windows.Forms.ToolStripMenuItem openRecursive;
		private System.Windows.Forms.ToolStripButton selectionBtn;
		private QuickLibrary.QlibToolsep qlibToolsep4;
		private System.Windows.Forms.ToolStripMenuItem cropBtn;
		private System.Windows.Forms.ToolStripStatusLabel selectionLabel;
		private System.Windows.Forms.Button navPrevBtn;
		private System.Windows.Forms.Button navNextBtn;
		private System.Windows.Forms.ToolStripMenuItem showNavArrowsBtn;
		private System.Windows.Forms.ToolStripMenuItem selectAllBtn;
		private System.Windows.Forms.ToolStripButton zoom100Btn;
		private QuickLibrary.QlibToolsep qlibToolsep5;
		private System.Windows.Forms.ToolStripMenuItem wallpaperBtn;
		private System.Windows.Forms.ToolTip infoTooltip;
		private System.Windows.Forms.ToolStripMenuItem permDeleteBtn;
		private System.Windows.Forms.ToolStripMenuItem openFolderBtn;
		private System.Windows.Forms.ToolStripDropDownButton saveMenuBtn;
		private System.Windows.Forms.ToolStripMenuItem saveBtn;
		private System.Windows.Forms.ToolStripMenuItem saveAsBtn;
		private System.Windows.Forms.ToolStripDropDownButton filteringModeBtn;
		private System.Windows.Forms.ToolStripMenuItem bilinearBtn;
		private System.Windows.Forms.ToolStripMenuItem nearestNeighborBtn;
	}
}