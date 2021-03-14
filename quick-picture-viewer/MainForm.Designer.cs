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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.selectionLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.directoryLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.fileLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.hasChangesLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.sizeLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.zoomLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.dateCreatedLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.dateModifiedLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.toolStrip1 = new QuickLibrary.QlibToolbar();
			this.openBtn = new System.Windows.Forms.ToolStripDropDownButton();
			this.openFileBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.openRecursive = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsButton = new System.Windows.Forms.ToolStripButton();
			this.infoButton = new System.Windows.Forms.ToolStripButton();
			this.externalBtn = new System.Windows.Forms.ToolStripDropDownButton();
			this.externalRunBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.externalFavoriteBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.externalChooseBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new QuickLibrary.QlibToolsep();
			this.prevButton = new System.Windows.Forms.ToolStripButton();
			this.slideshowButton = new System.Windows.Forms.ToolStripButton();
			this.nextButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new QuickLibrary.QlibToolsep();
			this.autoZoomButton = new System.Windows.Forms.ToolStripButton();
			this.zoomOutButton = new System.Windows.Forms.ToolStripButton();
			this.zoomTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.zoomInButton = new System.Windows.Forms.ToolStripButton();
			this.zoom100Btn = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new QuickLibrary.QlibToolsep();
			this.selectionBtn = new System.Windows.Forms.ToolStripButton();
			this.editButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.flipHorizontalButton = new System.Windows.Forms.ToolStripMenuItem();
			this.flipVerticalButton = new System.Windows.Forms.ToolStripMenuItem();
			this.qlibToolsep4 = new QuickLibrary.QlibToolsep();
			this.rotateRightButton = new System.Windows.Forms.ToolStripMenuItem();
			this.rotateLeftButton = new System.Windows.Forms.ToolStripMenuItem();
			this.rotate180Button = new System.Windows.Forms.ToolStripMenuItem();
			this.customAngleBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new QuickLibrary.QlibToolsep();
			this.cropBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.effectsBtn = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolsBtn = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripSeparator3 = new QuickLibrary.QlibToolsep();
			this.checkboardButton = new System.Windows.Forms.ToolStripButton();
			this.fullscreenBtn = new System.Windows.Forms.ToolStripButton();
			this.miniViewButton = new System.Windows.Forms.ToolStripButton();
			this.qlibToolsep1 = new QuickLibrary.QlibToolsep();
			this.moreButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.reloadButton = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.printButton = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator9 = new QuickLibrary.QlibToolsep();
			this.backColorBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.backClearBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.qlibMenuSeparator1 = new QuickLibrary.QlibToolsep();
			this.backCustomBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.onTopButton = new System.Windows.Forms.ToolStripMenuItem();
			this.framelessBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.newWindowButton = new System.Windows.Forms.ToolStripMenuItem();
			this.qlibToolsep2 = new QuickLibrary.QlibToolsep();
			this.pluginManBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator10 = new QuickLibrary.QlibToolsep();
			this.settingsButton = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.framelessCloseBtn = new System.Windows.Forms.ToolStripButton();
			this.rmbMenu = new QuickLibrary.QlibContextMenuStrip(this.components);
			this.showMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showNavArrowsBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.showToolbarBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.showStatusbarBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.qlibToolsep5 = new QuickLibrary.QlibToolsep();
			this.wallpaperBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.qlibToolsep3 = new QuickLibrary.QlibToolsep();
			this.copyBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.copyImageBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.copyFileBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.selectAllBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.navNextBtn = new System.Windows.Forms.Button();
			this.navPrevBtn = new System.Windows.Forms.Button();
			this.typeOpsButton = new System.Windows.Forms.Button();
			this.infoTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.picturePanel = new quick_picture_viewer.CustomPanel();
			this.suggestionIcon = new System.Windows.Forms.PictureBox();
			this.suggestionLabel = new System.Windows.Forms.Label();
			this.pleaseOpenLabel = new System.Windows.Forms.Label();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.rmbMenu.SuspendLayout();
			this.picturePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.suggestionIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "image";
			this.openFileDialog1.RestoreDirectory = true;
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "Image";
			resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this.statusStrip1, "statusStrip1");
			this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(0);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectionLabel,
            this.directoryLabel,
            this.fileLabel,
            this.hasChangesLabel,
            this.sizeLabel,
            this.zoomLabel,
            this.dateCreatedLabel,
            this.dateModifiedLabel});
			this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.ShowItemToolTips = true;
			this.statusStrip1.VisibleChanged += new System.EventHandler(this.statusStrip1_VisibleChanged);
			// 
			// selectionLabel
			// 
			this.selectionLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.selectionLabel.BackColor = System.Drawing.Color.Transparent;
			this.selectionLabel.Image = global::quick_picture_viewer.Properties.Resources.black_selection;
			this.selectionLabel.IsLink = true;
			this.selectionLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.selectionLabel.LinkColor = System.Drawing.Color.Black;
			this.selectionLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.selectionLabel.Name = "selectionLabel";
			resources.ApplyResources(this.selectionLabel, "selectionLabel");
			this.selectionLabel.VisitedLinkColor = System.Drawing.Color.Black;
			this.selectionLabel.Click += new System.EventHandler(this.selectionLabel_Click);
			// 
			// directoryLabel
			// 
			this.directoryLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.directoryLabel.BackColor = System.Drawing.Color.Transparent;
			this.directoryLabel.Image = global::quick_picture_viewer.Properties.Resources.black_picfolder;
			this.directoryLabel.IsLink = true;
			this.directoryLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.directoryLabel.LinkColor = System.Drawing.Color.Black;
			this.directoryLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.directoryLabel.Name = "directoryLabel";
			resources.ApplyResources(this.directoryLabel, "directoryLabel");
			this.directoryLabel.VisitedLinkColor = System.Drawing.Color.Black;
			this.directoryLabel.Click += new System.EventHandler(this.directoryLabel_Click);
			// 
			// fileLabel
			// 
			this.fileLabel.BackColor = System.Drawing.Color.Transparent;
			this.fileLabel.Image = global::quick_picture_viewer.Properties.Resources.black_imgfile;
			this.fileLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.fileLabel.Name = "fileLabel";
			resources.ApplyResources(this.fileLabel, "fileLabel");
			// 
			// hasChangesLabel
			// 
			this.hasChangesLabel.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.hasChangesLabel, "hasChangesLabel");
			this.hasChangesLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.hasChangesLabel.Name = "hasChangesLabel";
			// 
			// sizeLabel
			// 
			this.sizeLabel.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.sizeLabel, "sizeLabel");
			this.sizeLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.sizeLabel.Name = "sizeLabel";
			// 
			// zoomLabel
			// 
			this.zoomLabel.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.zoomLabel, "zoomLabel");
			this.zoomLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.zoomLabel.Name = "zoomLabel";
			// 
			// dateCreatedLabel
			// 
			this.dateCreatedLabel.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.dateCreatedLabel, "dateCreatedLabel");
			this.dateCreatedLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.dateCreatedLabel.Name = "dateCreatedLabel";
			// 
			// dateModifiedLabel
			// 
			this.dateModifiedLabel.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.dateModifiedLabel, "dateModifiedLabel");
			this.dateModifiedLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.dateModifiedLabel.Name = "dateModifiedLabel";
			// 
			// printDialog1
			// 
			this.printDialog1.Document = this.printDocument1;
			this.printDialog1.UseEXDialog = true;
			// 
			// printDocument1
			// 
			this.printDocument1.DocumentName = "";
			this.printDocument1.OriginAtMargins = true;
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// colorDialog1
			// 
			this.colorDialog1.Color = System.Drawing.Color.Blue;
			// 
			// toolStrip1
			// 
			this.toolStrip1.AlternativeAppearance = true;
			resources.ApplyResources(this.toolStrip1, "toolStrip1");
			this.toolStrip1.BackColor = System.Drawing.Color.White;
			this.toolStrip1.CanOverflow = false;
			this.toolStrip1.DarkMode = false;
			this.toolStrip1.DragForm = true;
			this.toolStrip1.ForeColor = System.Drawing.Color.Black;
			this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openBtn,
            this.saveAsButton,
            this.infoButton,
            this.externalBtn,
            this.toolStripSeparator4,
            this.prevButton,
            this.slideshowButton,
            this.nextButton,
            this.toolStripSeparator1,
            this.autoZoomButton,
            this.zoomOutButton,
            this.zoomTextBox,
            this.zoomInButton,
            this.zoom100Btn,
            this.toolStripSeparator2,
            this.selectionBtn,
            this.editButton,
            this.effectsBtn,
            this.toolsBtn,
            this.toolStripSeparator3,
            this.checkboardButton,
            this.fullscreenBtn,
            this.miniViewButton,
            this.qlibToolsep1,
            this.moreButton,
            this.framelessCloseBtn});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.VisibleChanged += new System.EventHandler(this.toolStrip1_VisibleChanged);
			// 
			// openBtn
			// 
			resources.ApplyResources(this.openBtn, "openBtn");
			this.openBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileBtn,
            this.openRecursive});
			this.openBtn.Image = global::quick_picture_viewer.Properties.Resources.black_open;
			this.openBtn.Margin = new System.Windows.Forms.Padding(0);
			this.openBtn.Name = "openBtn";
			// 
			// openFileBtn
			// 
			this.openFileBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.openFileBtn.ForeColor = System.Drawing.Color.Black;
			this.openFileBtn.Image = global::quick_picture_viewer.Properties.Resources.black_imgfile;
			this.openFileBtn.Name = "openFileBtn";
			resources.ApplyResources(this.openFileBtn, "openFileBtn");
			this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
			// 
			// openRecursive
			// 
			this.openRecursive.BackColor = System.Drawing.SystemColors.ControlLight;
			this.openRecursive.ForeColor = System.Drawing.Color.Black;
			this.openRecursive.Image = global::quick_picture_viewer.Properties.Resources.black_recursive;
			this.openRecursive.Name = "openRecursive";
			resources.ApplyResources(this.openRecursive, "openRecursive");
			this.openRecursive.Click += new System.EventHandler(this.openRecursive_Click);
			// 
			// saveAsButton
			// 
			resources.ApplyResources(this.saveAsButton, "saveAsButton");
			this.saveAsButton.BackColor = System.Drawing.Color.Transparent;
			this.saveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveAsButton.Image = global::quick_picture_viewer.Properties.Resources.black_saveas;
			this.saveAsButton.Margin = new System.Windows.Forms.Padding(0);
			this.saveAsButton.Name = "saveAsButton";
			this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
			// 
			// infoButton
			// 
			resources.ApplyResources(this.infoButton, "infoButton");
			this.infoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.infoButton.Margin = new System.Windows.Forms.Padding(0);
			this.infoButton.Name = "infoButton";
			this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
			// 
			// externalBtn
			// 
			resources.ApplyResources(this.externalBtn, "externalBtn");
			this.externalBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.externalBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.externalRunBtn,
            this.externalFavoriteBtn,
            this.externalChooseBtn});
			this.externalBtn.Margin = new System.Windows.Forms.Padding(0);
			this.externalBtn.Name = "externalBtn";
			this.externalBtn.DropDownOpened += new System.EventHandler(this.externalBtn_DropDownOpened);
			// 
			// externalRunBtn
			// 
			this.externalRunBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this.externalRunBtn, "externalRunBtn");
			this.externalRunBtn.ForeColor = System.Drawing.Color.Black;
			this.externalRunBtn.Name = "externalRunBtn";
			this.externalRunBtn.Click += new System.EventHandler(this.externalRunBtn_Click);
			// 
			// externalFavoriteBtn
			// 
			this.externalFavoriteBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this.externalFavoriteBtn, "externalFavoriteBtn");
			this.externalFavoriteBtn.ForeColor = System.Drawing.Color.Black;
			this.externalFavoriteBtn.Image = global::quick_picture_viewer.Properties.Resources.black_paint;
			this.externalFavoriteBtn.Name = "externalFavoriteBtn";
			this.externalFavoriteBtn.Click += new System.EventHandler(this.externalFavoriteBtn_Click);
			// 
			// externalChooseBtn
			// 
			this.externalChooseBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this.externalChooseBtn, "externalChooseBtn");
			this.externalChooseBtn.ForeColor = System.Drawing.Color.Black;
			this.externalChooseBtn.Name = "externalChooseBtn";
			this.externalChooseBtn.Click += new System.EventHandler(this.externalButton_Click);
			// 
			// toolStripSeparator4
			// 
			resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
			this.toolStripSeparator4.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStripSeparator4.DarkMode = false;
			this.toolStripSeparator4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.toolStripSeparator4.InsideMenu = false;
			this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			// 
			// prevButton
			// 
			resources.ApplyResources(this.prevButton, "prevButton");
			this.prevButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.prevButton.Margin = new System.Windows.Forms.Padding(0);
			this.prevButton.Name = "prevButton";
			this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
			// 
			// slideshowButton
			// 
			resources.ApplyResources(this.slideshowButton, "slideshowButton");
			this.slideshowButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.slideshowButton.Margin = new System.Windows.Forms.Padding(0);
			this.slideshowButton.Name = "slideshowButton";
			this.slideshowButton.Click += new System.EventHandler(this.slideshowButton_Click);
			// 
			// nextButton
			// 
			resources.ApplyResources(this.nextButton, "nextButton");
			this.nextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.nextButton.Margin = new System.Windows.Forms.Padding(0);
			this.nextButton.Name = "nextButton";
			this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
			this.nextButton.EnabledChanged += new System.EventHandler(this.nextButton_EnabledChanged);
			this.nextButton.VisibleChanged += new System.EventHandler(this.nextButton_VisibleChanged);
			// 
			// toolStripSeparator1
			// 
			resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
			this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStripSeparator1.DarkMode = false;
			this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.toolStripSeparator1.InsideMenu = false;
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			// 
			// autoZoomButton
			// 
			resources.ApplyResources(this.autoZoomButton, "autoZoomButton");
			this.autoZoomButton.Checked = true;
			this.autoZoomButton.CheckState = System.Windows.Forms.CheckState.Checked;
			this.autoZoomButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.autoZoomButton.Margin = new System.Windows.Forms.Padding(0);
			this.autoZoomButton.Name = "autoZoomButton";
			this.autoZoomButton.Click += new System.EventHandler(this.autoZoomButton_Click);
			// 
			// zoomOutButton
			// 
			resources.ApplyResources(this.zoomOutButton, "zoomOutButton");
			this.zoomOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zoomOutButton.Margin = new System.Windows.Forms.Padding(0);
			this.zoomOutButton.Name = "zoomOutButton";
			this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
			this.zoomOutButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zoomOutButton_MouseDown);
			this.zoomOutButton.MouseLeave += new System.EventHandler(this.zoomOutButton_MouseLeave);
			this.zoomOutButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zoomOutButton_MouseUp);
			// 
			// zoomTextBox
			// 
			this.zoomTextBox.BackColor = System.Drawing.Color.White;
			this.zoomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.zoomTextBox, "zoomTextBox");
			this.zoomTextBox.Margin = new System.Windows.Forms.Padding(7, -1, 7, -1);
			this.zoomTextBox.Name = "zoomTextBox";
			this.zoomTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zoomTextBox_KeyPress);
			this.zoomTextBox.MouseEnter += new System.EventHandler(this.zoomTextBox_MouseEnter);
			this.zoomTextBox.MouseLeave += new System.EventHandler(this.zoomTextBox_MouseLeave);
			this.zoomTextBox.TextChanged += new System.EventHandler(this.zoomComboBox_TextChanged);
			// 
			// zoomInButton
			// 
			resources.ApplyResources(this.zoomInButton, "zoomInButton");
			this.zoomInButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zoomInButton.Margin = new System.Windows.Forms.Padding(0);
			this.zoomInButton.Name = "zoomInButton";
			this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
			this.zoomInButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zoomInButton_MouseDown);
			this.zoomInButton.MouseLeave += new System.EventHandler(this.zoomInButton_MouseLeave);
			this.zoomInButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zoomInButton_MouseUp);
			// 
			// zoom100Btn
			// 
			resources.ApplyResources(this.zoom100Btn, "zoom100Btn");
			this.zoom100Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zoom100Btn.Image = global::quick_picture_viewer.Properties.Resources.black_actualsize;
			this.zoom100Btn.Margin = new System.Windows.Forms.Padding(0);
			this.zoom100Btn.Name = "zoom100Btn";
			this.zoom100Btn.Click += new System.EventHandler(this.zoom100Btn_Click);
			// 
			// toolStripSeparator2
			// 
			resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
			this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStripSeparator2.DarkMode = false;
			this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.toolStripSeparator2.InsideMenu = false;
			this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			// 
			// selectionBtn
			// 
			resources.ApplyResources(this.selectionBtn, "selectionBtn");
			this.selectionBtn.CheckOnClick = true;
			this.selectionBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.selectionBtn.Image = global::quick_picture_viewer.Properties.Resources.black_selection;
			this.selectionBtn.Margin = new System.Windows.Forms.Padding(0);
			this.selectionBtn.Name = "selectionBtn";
			this.selectionBtn.CheckedChanged += new System.EventHandler(this.selectionBtn_CheckedChanged);
			// 
			// editButton
			// 
			resources.ApplyResources(this.editButton, "editButton");
			this.editButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.editButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipHorizontalButton,
            this.flipVerticalButton,
            this.qlibToolsep4,
            this.rotateRightButton,
            this.rotateLeftButton,
            this.rotate180Button,
            this.customAngleBtn,
            this.toolStripSeparator7,
            this.cropBtn});
			this.editButton.ForeColor = System.Drawing.Color.Black;
			this.editButton.Image = global::quick_picture_viewer.Properties.Resources.black_edit;
			this.editButton.Margin = new System.Windows.Forms.Padding(0);
			this.editButton.Name = "editButton";
			// 
			// flipHorizontalButton
			// 
			this.flipHorizontalButton.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this.flipHorizontalButton, "flipHorizontalButton");
			this.flipHorizontalButton.ForeColor = System.Drawing.Color.Black;
			this.flipHorizontalButton.Name = "flipHorizontalButton";
			this.flipHorizontalButton.Click += new System.EventHandler(this.flipHorizontalButton_Click);
			// 
			// flipVerticalButton
			// 
			this.flipVerticalButton.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this.flipVerticalButton, "flipVerticalButton");
			this.flipVerticalButton.ForeColor = System.Drawing.Color.Black;
			this.flipVerticalButton.Name = "flipVerticalButton";
			this.flipVerticalButton.Click += new System.EventHandler(this.flipVerticalButton_Click);
			// 
			// qlibToolsep4
			// 
			resources.ApplyResources(this.qlibToolsep4, "qlibToolsep4");
			this.qlibToolsep4.BackColor = System.Drawing.SystemColors.ControlLight;
			this.qlibToolsep4.DarkMode = false;
			this.qlibToolsep4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.qlibToolsep4.InsideMenu = true;
			this.qlibToolsep4.Margin = new System.Windows.Forms.Padding(4);
			this.qlibToolsep4.Name = "qlibToolsep4";
			// 
			// rotateRightButton
			// 
			this.rotateRightButton.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this.rotateRightButton, "rotateRightButton");
			this.rotateRightButton.ForeColor = System.Drawing.Color.Black;
			this.rotateRightButton.Image = global::quick_picture_viewer.Properties.Resources.black_rotater;
			this.rotateRightButton.Name = "rotateRightButton";
			this.rotateRightButton.Click += new System.EventHandler(this.rotateRightButton_Click);
			// 
			// rotateLeftButton
			// 
			this.rotateLeftButton.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this.rotateLeftButton, "rotateLeftButton");
			this.rotateLeftButton.ForeColor = System.Drawing.Color.Black;
			this.rotateLeftButton.Name = "rotateLeftButton";
			this.rotateLeftButton.Click += new System.EventHandler(this.rotateLeftButton_Click);
			// 
			// rotate180Button
			// 
			this.rotate180Button.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this.rotate180Button, "rotate180Button");
			this.rotate180Button.ForeColor = System.Drawing.Color.Black;
			this.rotate180Button.Name = "rotate180Button";
			this.rotate180Button.Click += new System.EventHandler(this.rotate180Button_Click);
			// 
			// customAngleBtn
			// 
			this.customAngleBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this.customAngleBtn, "customAngleBtn");
			this.customAngleBtn.ForeColor = System.Drawing.Color.Black;
			this.customAngleBtn.Image = global::quick_picture_viewer.Properties.Resources.black_angle;
			this.customAngleBtn.Name = "customAngleBtn";
			// 
			// toolStripSeparator7
			// 
			resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
			this.toolStripSeparator7.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStripSeparator7.DarkMode = false;
			this.toolStripSeparator7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.toolStripSeparator7.InsideMenu = true;
			this.toolStripSeparator7.Margin = new System.Windows.Forms.Padding(4);
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			// 
			// cropBtn
			// 
			this.cropBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.cropBtn.ForeColor = System.Drawing.Color.Black;
			this.cropBtn.Image = global::quick_picture_viewer.Properties.Resources.black_crop;
			this.cropBtn.Name = "cropBtn";
			resources.ApplyResources(this.cropBtn, "cropBtn");
			this.cropBtn.Click += new System.EventHandler(this.cropBtn_Click);
			// 
			// effectsBtn
			// 
			resources.ApplyResources(this.effectsBtn, "effectsBtn");
			this.effectsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.effectsBtn.Image = global::quick_picture_viewer.Properties.Resources.black_effects;
			this.effectsBtn.Margin = new System.Windows.Forms.Padding(0);
			this.effectsBtn.Name = "effectsBtn";
			this.effectsBtn.DropDownOpening += new System.EventHandler(this.effectsBtn_DropDownOpening);
			// 
			// toolsBtn
			// 
			resources.ApplyResources(this.toolsBtn, "toolsBtn");
			this.toolsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolsBtn.Image = global::quick_picture_viewer.Properties.Resources.black_tools;
			this.toolsBtn.Margin = new System.Windows.Forms.Padding(0);
			this.toolsBtn.Name = "toolsBtn";
			this.toolsBtn.DropDownOpening += new System.EventHandler(this.effectsBtn_DropDownOpening);
			// 
			// toolStripSeparator3
			// 
			resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
			this.toolStripSeparator3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStripSeparator3.DarkMode = false;
			this.toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.toolStripSeparator3.InsideMenu = false;
			this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			// 
			// checkboardButton
			// 
			resources.ApplyResources(this.checkboardButton, "checkboardButton");
			this.checkboardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.checkboardButton.Image = global::quick_picture_viewer.Properties.Resources.black_grid;
			this.checkboardButton.Margin = new System.Windows.Forms.Padding(0);
			this.checkboardButton.Name = "checkboardButton";
			this.checkboardButton.Click += new System.EventHandler(this.checkboardButton_Click);
			// 
			// fullscreenBtn
			// 
			resources.ApplyResources(this.fullscreenBtn, "fullscreenBtn");
			this.fullscreenBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.fullscreenBtn.Margin = new System.Windows.Forms.Padding(0);
			this.fullscreenBtn.Name = "fullscreenBtn";
			this.fullscreenBtn.Click += new System.EventHandler(this.fullscreenButton_Click);
			// 
			// miniViewButton
			// 
			resources.ApplyResources(this.miniViewButton, "miniViewButton");
			this.miniViewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.miniViewButton.Margin = new System.Windows.Forms.Padding(0);
			this.miniViewButton.Name = "miniViewButton";
			this.miniViewButton.Click += new System.EventHandler(this.miniViewButton_Click);
			// 
			// qlibToolsep1
			// 
			resources.ApplyResources(this.qlibToolsep1, "qlibToolsep1");
			this.qlibToolsep1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.qlibToolsep1.DarkMode = false;
			this.qlibToolsep1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.qlibToolsep1.InsideMenu = false;
			this.qlibToolsep1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.qlibToolsep1.Name = "qlibToolsep1";
			// 
			// moreButton
			// 
			resources.ApplyResources(this.moreButton, "moreButton");
			this.moreButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.moreButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadButton,
            this.deleteBtn,
            this.printButton,
            this.toolStripSeparator9,
            this.backColorBtn,
            this.onTopButton,
            this.framelessBtn,
            this.newWindowButton,
            this.qlibToolsep2,
            this.pluginManBtn,
            this.toolStripSeparator10,
            this.settingsButton,
            this.aboutBtn});
			this.moreButton.Margin = new System.Windows.Forms.Padding(0);
			this.moreButton.Name = "moreButton";
			// 
			// reloadButton
			// 
			this.reloadButton.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this.reloadButton, "reloadButton");
			this.reloadButton.ForeColor = System.Drawing.Color.Black;
			this.reloadButton.Image = global::quick_picture_viewer.Properties.Resources.black_sync;
			this.reloadButton.Name = "reloadButton";
			this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
			// 
			// deleteBtn
			// 
			this.deleteBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this.deleteBtn, "deleteBtn");
			this.deleteBtn.ForeColor = System.Drawing.Color.Black;
			this.deleteBtn.Image = global::quick_picture_viewer.Properties.Resources.black_trash;
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// printButton
			// 
			this.printButton.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this.printButton, "printButton");
			this.printButton.ForeColor = System.Drawing.Color.Black;
			this.printButton.Name = "printButton";
			this.printButton.Click += new System.EventHandler(this.printButton_Click);
			// 
			// toolStripSeparator9
			// 
			resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
			this.toolStripSeparator9.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStripSeparator9.DarkMode = false;
			this.toolStripSeparator9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.toolStripSeparator9.InsideMenu = true;
			this.toolStripSeparator9.Margin = new System.Windows.Forms.Padding(4);
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			// 
			// backColorBtn
			// 
			this.backColorBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.backColorBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backClearBtn,
            this.qlibMenuSeparator1,
            this.backCustomBtn});
			this.backColorBtn.ForeColor = System.Drawing.Color.Black;
			this.backColorBtn.Image = global::quick_picture_viewer.Properties.Resources.black_palette;
			this.backColorBtn.Name = "backColorBtn";
			resources.ApplyResources(this.backColorBtn, "backColorBtn");
			// 
			// backClearBtn
			// 
			this.backClearBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.backClearBtn.ForeColor = System.Drawing.Color.Black;
			resources.ApplyResources(this.backClearBtn, "backClearBtn");
			this.backClearBtn.Name = "backClearBtn";
			this.backClearBtn.Click += new System.EventHandler(this.backClearBtn_Click);
			// 
			// qlibMenuSeparator1
			// 
			resources.ApplyResources(this.qlibMenuSeparator1, "qlibMenuSeparator1");
			this.qlibMenuSeparator1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.qlibMenuSeparator1.DarkMode = false;
			this.qlibMenuSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.qlibMenuSeparator1.InsideMenu = true;
			this.qlibMenuSeparator1.Margin = new System.Windows.Forms.Padding(4);
			this.qlibMenuSeparator1.Name = "qlibMenuSeparator1";
			// 
			// backCustomBtn
			// 
			this.backCustomBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.backCustomBtn.ForeColor = System.Drawing.Color.Black;
			this.backCustomBtn.Image = global::quick_picture_viewer.Properties.Resources.black_palette;
			this.backCustomBtn.Name = "backCustomBtn";
			resources.ApplyResources(this.backCustomBtn, "backCustomBtn");
			this.backCustomBtn.Click += new System.EventHandler(this.backCustomBtn_Click);
			// 
			// onTopButton
			// 
			this.onTopButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.onTopButton.ForeColor = System.Drawing.Color.Black;
			resources.ApplyResources(this.onTopButton, "onTopButton");
			this.onTopButton.Name = "onTopButton";
			this.onTopButton.Click += new System.EventHandler(this.onTopButton_Click);
			// 
			// framelessBtn
			// 
			this.framelessBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.framelessBtn.ForeColor = System.Drawing.Color.Black;
			resources.ApplyResources(this.framelessBtn, "framelessBtn");
			this.framelessBtn.Name = "framelessBtn";
			this.framelessBtn.Click += new System.EventHandler(this.framelessBtn_Click);
			// 
			// newWindowButton
			// 
			this.newWindowButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.newWindowButton.ForeColor = System.Drawing.Color.Black;
			this.newWindowButton.Image = global::quick_picture_viewer.Properties.Resources.black_newwindow;
			this.newWindowButton.Name = "newWindowButton";
			resources.ApplyResources(this.newWindowButton, "newWindowButton");
			this.newWindowButton.Click += new System.EventHandler(this.newWindowButton_Click);
			// 
			// qlibToolsep2
			// 
			resources.ApplyResources(this.qlibToolsep2, "qlibToolsep2");
			this.qlibToolsep2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.qlibToolsep2.DarkMode = false;
			this.qlibToolsep2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.qlibToolsep2.InsideMenu = true;
			this.qlibToolsep2.Margin = new System.Windows.Forms.Padding(4);
			this.qlibToolsep2.Name = "qlibToolsep2";
			// 
			// pluginManBtn
			// 
			this.pluginManBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pluginManBtn.ForeColor = System.Drawing.Color.Black;
			this.pluginManBtn.Image = global::quick_picture_viewer.Properties.Resources.black_plugin;
			this.pluginManBtn.Name = "pluginManBtn";
			resources.ApplyResources(this.pluginManBtn, "pluginManBtn");
			this.pluginManBtn.Click += new System.EventHandler(this.pluginManBtn_Click_1);
			// 
			// toolStripSeparator10
			// 
			resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
			this.toolStripSeparator10.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStripSeparator10.DarkMode = false;
			this.toolStripSeparator10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.toolStripSeparator10.InsideMenu = true;
			this.toolStripSeparator10.Margin = new System.Windows.Forms.Padding(4);
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			// 
			// settingsButton
			// 
			this.settingsButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.settingsButton.ForeColor = System.Drawing.Color.Black;
			this.settingsButton.Image = global::quick_picture_viewer.Properties.Resources.black_settings;
			this.settingsButton.Name = "settingsButton";
			resources.ApplyResources(this.settingsButton, "settingsButton");
			this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
			// 
			// aboutBtn
			// 
			this.aboutBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.aboutBtn.ForeColor = System.Drawing.Color.Black;
			this.aboutBtn.Image = global::quick_picture_viewer.Properties.Resources.black_about;
			this.aboutBtn.Name = "aboutBtn";
			resources.ApplyResources(this.aboutBtn, "aboutBtn");
			this.aboutBtn.Click += new System.EventHandler(this.aboutButton_Click);
			// 
			// framelessCloseBtn
			// 
			this.framelessCloseBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			resources.ApplyResources(this.framelessCloseBtn, "framelessCloseBtn");
			this.framelessCloseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.framelessCloseBtn.Image = global::quick_picture_viewer.Properties.Resources.black_close;
			this.framelessCloseBtn.Margin = new System.Windows.Forms.Padding(0);
			this.framelessCloseBtn.Name = "framelessCloseBtn";
			this.framelessCloseBtn.Click += new System.EventHandler(this.framelessCloseBtn_Click);
			// 
			// rmbMenu
			// 
			this.rmbMenu.BackColor = System.Drawing.SystemColors.ControlLight;
			this.rmbMenu.DarkMode = false;
			resources.ApplyResources(this.rmbMenu, "rmbMenu");
			this.rmbMenu.ForeColor = System.Drawing.Color.Black;
			this.rmbMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMenuItem,
            this.qlibToolsep5,
            this.wallpaperBtn,
            this.qlibToolsep3,
            this.copyBtn,
            this.pasteBtn,
            this.selectAllBtn});
			this.rmbMenu.Name = "rmbMenu";
			this.rmbMenu.Opening += new System.ComponentModel.CancelEventHandler(this.rmbMenu_Opening);
			// 
			// showMenuItem
			// 
			this.showMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
			this.showMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showNavArrowsBtn,
            this.showToolbarBtn,
            this.showStatusbarBtn});
			resources.ApplyResources(this.showMenuItem, "showMenuItem");
			this.showMenuItem.ForeColor = System.Drawing.Color.Black;
			this.showMenuItem.Image = global::quick_picture_viewer.Properties.Resources.black_show;
			this.showMenuItem.Name = "showMenuItem";
			this.showMenuItem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			// 
			// showNavArrowsBtn
			// 
			this.showNavArrowsBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.showNavArrowsBtn.ForeColor = System.Drawing.Color.Black;
			this.showNavArrowsBtn.Image = global::quick_picture_viewer.Properties.Resources.black_arrows;
			this.showNavArrowsBtn.Name = "showNavArrowsBtn";
			this.showNavArrowsBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			resources.ApplyResources(this.showNavArrowsBtn, "showNavArrowsBtn");
			this.showNavArrowsBtn.Click += new System.EventHandler(this.showNavArrowsBtn_Click);
			// 
			// showToolbarBtn
			// 
			this.showToolbarBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.showToolbarBtn.ForeColor = System.Drawing.Color.Black;
			this.showToolbarBtn.Image = global::quick_picture_viewer.Properties.Resources.black_toolbar;
			this.showToolbarBtn.Name = "showToolbarBtn";
			this.showToolbarBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			resources.ApplyResources(this.showToolbarBtn, "showToolbarBtn");
			this.showToolbarBtn.Click += new System.EventHandler(this.showToolbarBtn_Click);
			// 
			// showStatusbarBtn
			// 
			this.showStatusbarBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.showStatusbarBtn.ForeColor = System.Drawing.Color.Black;
			this.showStatusbarBtn.Image = global::quick_picture_viewer.Properties.Resources.black_statusbar;
			this.showStatusbarBtn.Name = "showStatusbarBtn";
			this.showStatusbarBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			resources.ApplyResources(this.showStatusbarBtn, "showStatusbarBtn");
			this.showStatusbarBtn.Click += new System.EventHandler(this.showStatusBarBtn_Click);
			// 
			// qlibToolsep5
			// 
			resources.ApplyResources(this.qlibToolsep5, "qlibToolsep5");
			this.qlibToolsep5.BackColor = System.Drawing.SystemColors.ControlLight;
			this.qlibToolsep5.DarkMode = false;
			this.qlibToolsep5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.qlibToolsep5.InsideMenu = true;
			this.qlibToolsep5.Margin = new System.Windows.Forms.Padding(4);
			this.qlibToolsep5.Name = "qlibToolsep5";
			// 
			// wallpaperBtn
			// 
			this.wallpaperBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this.wallpaperBtn, "wallpaperBtn");
			this.wallpaperBtn.ForeColor = System.Drawing.Color.Black;
			this.wallpaperBtn.Image = global::quick_picture_viewer.Properties.Resources.black_desktop;
			this.wallpaperBtn.Name = "wallpaperBtn";
			this.wallpaperBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.wallpaperBtn.Click += new System.EventHandler(this.wallpaperBtn_Click);
			// 
			// qlibToolsep3
			// 
			resources.ApplyResources(this.qlibToolsep3, "qlibToolsep3");
			this.qlibToolsep3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.qlibToolsep3.DarkMode = false;
			this.qlibToolsep3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.qlibToolsep3.InsideMenu = true;
			this.qlibToolsep3.Margin = new System.Windows.Forms.Padding(4);
			this.qlibToolsep3.Name = "qlibToolsep3";
			// 
			// copyBtn
			// 
			this.copyBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.copyBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyImageBtn,
            this.copyFileBtn});
			this.copyBtn.ForeColor = System.Drawing.Color.Black;
			this.copyBtn.Image = global::quick_picture_viewer.Properties.Resources.black_copy;
			this.copyBtn.Name = "copyBtn";
			this.copyBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			resources.ApplyResources(this.copyBtn, "copyBtn");
			// 
			// copyImageBtn
			// 
			this.copyImageBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.copyImageBtn.ForeColor = System.Drawing.Color.Black;
			this.copyImageBtn.Image = global::quick_picture_viewer.Properties.Resources.black_image;
			this.copyImageBtn.Name = "copyImageBtn";
			this.copyImageBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			resources.ApplyResources(this.copyImageBtn, "copyImageBtn");
			this.copyImageBtn.Click += new System.EventHandler(this.copyImageBtn_Click);
			this.copyImageBtn.EnabledChanged += new System.EventHandler(this.copyImageBtn_EnabledChanged);
			// 
			// copyFileBtn
			// 
			this.copyFileBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.copyFileBtn.ForeColor = System.Drawing.Color.Black;
			this.copyFileBtn.Image = global::quick_picture_viewer.Properties.Resources.black_imgfile;
			this.copyFileBtn.Name = "copyFileBtn";
			this.copyFileBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			resources.ApplyResources(this.copyFileBtn, "copyFileBtn");
			this.copyFileBtn.Click += new System.EventHandler(this.copyFileBtn_Click_1);
			this.copyFileBtn.EnabledChanged += new System.EventHandler(this.copyImageBtn_EnabledChanged);
			// 
			// pasteBtn
			// 
			this.pasteBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pasteBtn.ForeColor = System.Drawing.Color.Black;
			this.pasteBtn.Image = global::quick_picture_viewer.Properties.Resources.black_paste;
			this.pasteBtn.Name = "pasteBtn";
			this.pasteBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			resources.ApplyResources(this.pasteBtn, "pasteBtn");
			this.pasteBtn.Click += new System.EventHandler(this.pasteBtn_Click);
			// 
			// selectAllBtn
			// 
			this.selectAllBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this.selectAllBtn, "selectAllBtn");
			this.selectAllBtn.ForeColor = System.Drawing.Color.Black;
			this.selectAllBtn.Image = global::quick_picture_viewer.Properties.Resources.black_selectall;
			this.selectAllBtn.Name = "selectAllBtn";
			this.selectAllBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.selectAllBtn.Click += new System.EventHandler(this.selectAllBtn_Click);
			// 
			// navNextBtn
			// 
			resources.ApplyResources(this.navNextBtn, "navNextBtn");
			this.navNextBtn.BackColor = System.Drawing.Color.Black;
			this.navNextBtn.FlatAppearance.BorderSize = 0;
			this.navNextBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
			this.navNextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.navNextBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.navNextBtn.Image = global::quick_picture_viewer.Properties.Resources.white_next;
			this.navNextBtn.Name = "navNextBtn";
			this.navNextBtn.TabStop = false;
			this.navNextBtn.UseVisualStyleBackColor = false;
			this.navNextBtn.Click += new System.EventHandler(this.navNextBtn_Click);
			// 
			// navPrevBtn
			// 
			resources.ApplyResources(this.navPrevBtn, "navPrevBtn");
			this.navPrevBtn.BackColor = System.Drawing.Color.Black;
			this.navPrevBtn.FlatAppearance.BorderSize = 0;
			this.navPrevBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
			this.navPrevBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.navPrevBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.navPrevBtn.Image = global::quick_picture_viewer.Properties.Resources.white_prev;
			this.navPrevBtn.Name = "navPrevBtn";
			this.navPrevBtn.TabStop = false;
			this.navPrevBtn.UseVisualStyleBackColor = false;
			this.navPrevBtn.Click += new System.EventHandler(this.navPrevBtn_Click);
			// 
			// typeOpsButton
			// 
			resources.ApplyResources(this.typeOpsButton, "typeOpsButton");
			this.typeOpsButton.BackColor = System.Drawing.Color.Black;
			this.typeOpsButton.FlatAppearance.BorderSize = 0;
			this.typeOpsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
			this.typeOpsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.typeOpsButton.ForeColor = System.Drawing.Color.White;
			this.typeOpsButton.Image = global::quick_picture_viewer.Properties.Resources.white_options;
			this.typeOpsButton.Name = "typeOpsButton";
			this.typeOpsButton.TabStop = false;
			this.typeOpsButton.UseVisualStyleBackColor = false;
			this.typeOpsButton.Click += new System.EventHandler(this.typeOpsButton_Click);
			// 
			// picturePanel
			// 
			resources.ApplyResources(this.picturePanel, "picturePanel");
			this.picturePanel.BackColor = System.Drawing.Color.Transparent;
			this.picturePanel.ContextMenuStrip = this.rmbMenu;
			this.picturePanel.Controls.Add(this.suggestionIcon);
			this.picturePanel.Controls.Add(this.suggestionLabel);
			this.picturePanel.Controls.Add(this.pleaseOpenLabel);
			this.picturePanel.Controls.Add(this.pictureBox);
			this.picturePanel.Name = "picturePanel";
			this.picturePanel.SizeChanged += new System.EventHandler(this.picturePanel_SizeChanged);
			this.picturePanel.DoubleClick += new System.EventHandler(this.picturePanel_DoubleClick);
			this.picturePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseDown);
			this.picturePanel.MouseEnter += new System.EventHandler(this.picturePanel_MouseEnter);
			this.picturePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseMove);
			this.picturePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseUp);
			// 
			// suggestionIcon
			// 
			this.suggestionIcon.BackColor = System.Drawing.Color.Black;
			resources.ApplyResources(this.suggestionIcon, "suggestionIcon");
			this.suggestionIcon.Name = "suggestionIcon";
			this.suggestionIcon.TabStop = false;
			// 
			// suggestionLabel
			// 
			resources.ApplyResources(this.suggestionLabel, "suggestionLabel");
			this.suggestionLabel.BackColor = System.Drawing.Color.Black;
			this.suggestionLabel.ForeColor = System.Drawing.Color.White;
			this.suggestionLabel.Name = "suggestionLabel";
			// 
			// pleaseOpenLabel
			// 
			resources.ApplyResources(this.pleaseOpenLabel, "pleaseOpenLabel");
			this.pleaseOpenLabel.Name = "pleaseOpenLabel";
			this.pleaseOpenLabel.DoubleClick += new System.EventHandler(this.picturePanel_DoubleClick);
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.pictureBox, "pictureBox");
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.TabStop = false;
			this.pictureBox.DoubleClick += new System.EventHandler(this.picturePanel_DoubleClick);
			this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseDown);
			this.pictureBox.MouseEnter += new System.EventHandler(this.picturePanel_MouseEnter);
			this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseMove);
			this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseUp);
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.navNextBtn);
			this.Controls.Add(this.navPrevBtn);
			this.Controls.Add(this.typeOpsButton);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.picturePanel);
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.rmbMenu.ResumeLayout(false);
			this.picturePanel.ResumeLayout(false);
			this.picturePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.suggestionIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
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
		private System.Windows.Forms.ToolStripButton saveAsButton;
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
	}
}