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
			this.directoryLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.fileLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.sizeLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.zoomLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.hasChangesLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.dateCreatedLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.dateModifiedLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.toolStrip1 = new QuickLibrary.QlibToolbar();
			this.openButton = new System.Windows.Forms.ToolStripButton();
			this.saveAsButton = new System.Windows.Forms.ToolStripButton();
			this.externalBtn = new System.Windows.Forms.ToolStripDropDownButton();
			this.externalRunBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.externalFavoriteBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.externalChooseBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new QuickLibrary.QlibToolsep();
			this.infoButton = new System.Windows.Forms.ToolStripButton();
			this.prevButton = new System.Windows.Forms.ToolStripButton();
			this.slideshowButton = new System.Windows.Forms.ToolStripButton();
			this.nextButton = new System.Windows.Forms.ToolStripButton();
			this.showFileButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new QuickLibrary.QlibToolsep();
			this.autoZoomButton = new System.Windows.Forms.ToolStripButton();
			this.zoomOutButton = new System.Windows.Forms.ToolStripButton();
			this.zoomTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.zoomInButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new QuickLibrary.QlibToolsep();
			this.editButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.flipHorizontalButton = new System.Windows.Forms.ToolStripMenuItem();
			this.flipVerticalButton = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new QuickLibrary.QlibToolsep();
			this.rotateRightButton = new System.Windows.Forms.ToolStripMenuItem();
			this.rotateLeftButton = new System.Windows.Forms.ToolStripMenuItem();
			this.rotate180Button = new System.Windows.Forms.ToolStripMenuItem();
			this.customAngleBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.copyButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.copyImageButton = new System.Windows.Forms.ToolStripMenuItem();
			this.copyFileBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new QuickLibrary.QlibToolsep();
			this.checkboardButton = new System.Windows.Forms.ToolStripButton();
			this.fullscreenBtn = new System.Windows.Forms.ToolStripButton();
			this.miniViewButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new QuickLibrary.QlibToolsep();
			this.effectsBtn = new System.Windows.Forms.ToolStripDropDownButton();
			this.pluginManBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsBtn = new System.Windows.Forms.ToolStripDropDownButton();
			this.pluginManBtn2 = new System.Windows.Forms.ToolStripMenuItem();
			this.qlibToolsep1 = new QuickLibrary.QlibToolsep();
			this.moreButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.reloadButton = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.printButton = new System.Windows.Forms.ToolStripMenuItem();
			this.setAsDesktopButton = new System.Windows.Forms.ToolStripMenuItem();
			this.qlibMenuSeparator2 = new QuickLibrary.QlibToolsep();
			this.actualSizeBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator9 = new QuickLibrary.QlibToolsep();
			this.backColorBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.backClearBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.qlibMenuSeparator1 = new QuickLibrary.QlibToolsep();
			this.backCustomBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.onTopButton = new System.Windows.Forms.ToolStripMenuItem();
			this.framelessBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.newWindowButton = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator10 = new QuickLibrary.QlibToolsep();
			this.settingsButton = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.framelessCloseBtn = new System.Windows.Forms.ToolStripButton();
			this.picturePanel = new quick_picture_viewer.CustomPanel();
			this.rmbMenu = new QuickLibrary.QlibContextMenuStrip(this.components);
			this.showMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showStatusBarBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.suggestionIcon = new System.Windows.Forms.PictureBox();
			this.suggestionLabel = new System.Windows.Forms.Label();
			this.pleaseOpenLabel = new System.Windows.Forms.Label();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.typeOpsButton = new System.Windows.Forms.Button();
			this.showToolbarBtn = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.picturePanel.SuspendLayout();
			this.rmbMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.suggestionIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "image";
			resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
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
            this.directoryLabel,
            this.fileLabel,
            this.sizeLabel,
            this.zoomLabel,
            this.hasChangesLabel,
            this.dateCreatedLabel,
            this.dateModifiedLabel});
			this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.ShowItemToolTips = true;
			this.statusStrip1.VisibleChanged += new System.EventHandler(this.statusStrip1_VisibleChanged);
			// 
			// directoryLabel
			// 
			this.directoryLabel.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.directoryLabel, "directoryLabel");
			this.directoryLabel.Margin = new System.Windows.Forms.Padding(6, 6, 0, 6);
			this.directoryLabel.Name = "directoryLabel";
			// 
			// fileLabel
			// 
			this.fileLabel.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.fileLabel, "fileLabel");
			this.fileLabel.Margin = new System.Windows.Forms.Padding(6, 6, 0, 6);
			this.fileLabel.Name = "fileLabel";
			// 
			// sizeLabel
			// 
			this.sizeLabel.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.sizeLabel, "sizeLabel");
			this.sizeLabel.Margin = new System.Windows.Forms.Padding(6, 6, 0, 6);
			this.sizeLabel.Name = "sizeLabel";
			// 
			// zoomLabel
			// 
			this.zoomLabel.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.zoomLabel, "zoomLabel");
			this.zoomLabel.Margin = new System.Windows.Forms.Padding(6, 6, 0, 6);
			this.zoomLabel.Name = "zoomLabel";
			// 
			// hasChangesLabel
			// 
			this.hasChangesLabel.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.hasChangesLabel, "hasChangesLabel");
			this.hasChangesLabel.Margin = new System.Windows.Forms.Padding(6, 6, 0, 6);
			this.hasChangesLabel.Name = "hasChangesLabel";
			// 
			// dateCreatedLabel
			// 
			this.dateCreatedLabel.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.dateCreatedLabel, "dateCreatedLabel");
			this.dateCreatedLabel.Margin = new System.Windows.Forms.Padding(6, 6, 0, 6);
			this.dateCreatedLabel.Name = "dateCreatedLabel";
			// 
			// dateModifiedLabel
			// 
			this.dateModifiedLabel.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.dateModifiedLabel, "dateModifiedLabel");
			this.dateModifiedLabel.Margin = new System.Windows.Forms.Padding(6, 6, 0, 6);
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
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton,
            this.saveAsButton,
            this.externalBtn,
            this.toolStripSeparator4,
            this.infoButton,
            this.prevButton,
            this.slideshowButton,
            this.nextButton,
            this.showFileButton,
            this.toolStripSeparator1,
            this.autoZoomButton,
            this.zoomOutButton,
            this.zoomTextBox,
            this.zoomInButton,
            this.toolStripSeparator2,
            this.editButton,
            this.copyButton,
            this.pasteButton,
            this.toolStripSeparator3,
            this.checkboardButton,
            this.fullscreenBtn,
            this.miniViewButton,
            this.toolStripSeparator5,
            this.effectsBtn,
            this.toolsBtn,
            this.qlibToolsep1,
            this.moreButton,
            this.framelessCloseBtn});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.VisibleChanged += new System.EventHandler(this.toolStrip1_VisibleChanged);
			// 
			// openButton
			// 
			resources.ApplyResources(this.openButton, "openButton");
			this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openButton.Image = global::quick_picture_viewer.Properties.Resources.black_open;
			this.openButton.Margin = new System.Windows.Forms.Padding(0);
			this.openButton.Name = "openButton";
			this.openButton.Click += new System.EventHandler(this.openButton_Click_1);
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
			this.toolStripSeparator4.InsideMenu = false;
			this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			// 
			// infoButton
			// 
			resources.ApplyResources(this.infoButton, "infoButton");
			this.infoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.infoButton.Margin = new System.Windows.Forms.Padding(0);
			this.infoButton.Name = "infoButton";
			this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
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
			// 
			// showFileButton
			// 
			resources.ApplyResources(this.showFileButton, "showFileButton");
			this.showFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.showFileButton.Margin = new System.Windows.Forms.Padding(0);
			this.showFileButton.Name = "showFileButton";
			this.showFileButton.Click += new System.EventHandler(this.showFileButton_Click);
			// 
			// toolStripSeparator1
			// 
			resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
			this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStripSeparator1.DarkMode = false;
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
			// toolStripSeparator2
			// 
			resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
			this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStripSeparator2.DarkMode = false;
			this.toolStripSeparator2.InsideMenu = false;
			this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			// 
			// editButton
			// 
			resources.ApplyResources(this.editButton, "editButton");
			this.editButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.editButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipHorizontalButton,
            this.flipVerticalButton,
            this.toolStripSeparator7,
            this.rotateRightButton,
            this.rotateLeftButton,
            this.rotate180Button,
            this.customAngleBtn});
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
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStripSeparator7.DarkMode = false;
			this.toolStripSeparator7.InsideMenu = true;
			this.toolStripSeparator7.Margin = new System.Windows.Forms.Padding(4);
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
			// 
			// rotateRightButton
			// 
			this.rotateRightButton.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this.rotateRightButton, "rotateRightButton");
			this.rotateRightButton.ForeColor = System.Drawing.Color.Black;
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
			// copyButton
			// 
			resources.ApplyResources(this.copyButton, "copyButton");
			this.copyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.copyButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyImageButton,
            this.copyFileBtn});
			this.copyButton.Margin = new System.Windows.Forms.Padding(0);
			this.copyButton.Name = "copyButton";
			// 
			// copyImageButton
			// 
			this.copyImageButton.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this.copyImageButton, "copyImageButton");
			this.copyImageButton.ForeColor = System.Drawing.Color.Black;
			this.copyImageButton.Name = "copyImageButton";
			this.copyImageButton.Click += new System.EventHandler(this.copyButton_Click);
			// 
			// copyFileBtn
			// 
			this.copyFileBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this.copyFileBtn, "copyFileBtn");
			this.copyFileBtn.ForeColor = System.Drawing.Color.Black;
			this.copyFileBtn.Name = "copyFileBtn";
			this.copyFileBtn.Click += new System.EventHandler(this.copyFileBtn_Click);
			// 
			// pasteButton
			// 
			resources.ApplyResources(this.pasteButton, "pasteButton");
			this.pasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pasteButton.Margin = new System.Windows.Forms.Padding(0);
			this.pasteButton.Name = "pasteButton";
			this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
			// 
			// toolStripSeparator3
			// 
			resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
			this.toolStripSeparator3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStripSeparator3.DarkMode = false;
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
			// toolStripSeparator5
			// 
			resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
			this.toolStripSeparator5.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStripSeparator5.DarkMode = false;
			this.toolStripSeparator5.InsideMenu = false;
			this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			// 
			// effectsBtn
			// 
			resources.ApplyResources(this.effectsBtn, "effectsBtn");
			this.effectsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.effectsBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pluginManBtn});
			this.effectsBtn.Image = global::quick_picture_viewer.Properties.Resources.black_effects;
			this.effectsBtn.Margin = new System.Windows.Forms.Padding(0);
			this.effectsBtn.Name = "effectsBtn";
			this.effectsBtn.DropDownOpening += new System.EventHandler(this.effectsBtn_DropDownOpening);
			// 
			// pluginManBtn
			// 
			this.pluginManBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pluginManBtn.ForeColor = System.Drawing.Color.Black;
			this.pluginManBtn.Image = global::quick_picture_viewer.Properties.Resources.black_plugin;
			this.pluginManBtn.Name = "pluginManBtn";
			resources.ApplyResources(this.pluginManBtn, "pluginManBtn");
			this.pluginManBtn.Click += new System.EventHandler(this.pluginManBtn_Click);
			// 
			// toolsBtn
			// 
			resources.ApplyResources(this.toolsBtn, "toolsBtn");
			this.toolsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolsBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pluginManBtn2});
			this.toolsBtn.Image = global::quick_picture_viewer.Properties.Resources.black_tools;
			this.toolsBtn.Margin = new System.Windows.Forms.Padding(0);
			this.toolsBtn.Name = "toolsBtn";
			this.toolsBtn.DropDownOpening += new System.EventHandler(this.effectsBtn_DropDownOpening);
			// 
			// pluginManBtn2
			// 
			this.pluginManBtn2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pluginManBtn2.ForeColor = System.Drawing.Color.Black;
			this.pluginManBtn2.Image = global::quick_picture_viewer.Properties.Resources.black_plugin;
			this.pluginManBtn2.Name = "pluginManBtn2";
			resources.ApplyResources(this.pluginManBtn2, "pluginManBtn2");
			this.pluginManBtn2.Click += new System.EventHandler(this.pluginManBtn_Click);
			// 
			// qlibToolsep1
			// 
			resources.ApplyResources(this.qlibToolsep1, "qlibToolsep1");
			this.qlibToolsep1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.qlibToolsep1.DarkMode = false;
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
            this.setAsDesktopButton,
            this.qlibMenuSeparator2,
            this.actualSizeBtn,
            this.toolStripSeparator9,
            this.backColorBtn,
            this.onTopButton,
            this.framelessBtn,
            this.newWindowButton,
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
			// setAsDesktopButton
			// 
			this.setAsDesktopButton.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this.setAsDesktopButton, "setAsDesktopButton");
			this.setAsDesktopButton.ForeColor = System.Drawing.Color.Black;
			this.setAsDesktopButton.Name = "setAsDesktopButton";
			this.setAsDesktopButton.Click += new System.EventHandler(this.setAsDesktopButton_Click);
			// 
			// qlibMenuSeparator2
			// 
			this.qlibMenuSeparator2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.qlibMenuSeparator2.DarkMode = false;
			this.qlibMenuSeparator2.InsideMenu = true;
			this.qlibMenuSeparator2.Margin = new System.Windows.Forms.Padding(4);
			this.qlibMenuSeparator2.Name = "qlibMenuSeparator2";
			resources.ApplyResources(this.qlibMenuSeparator2, "qlibMenuSeparator2");
			// 
			// actualSizeBtn
			// 
			this.actualSizeBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			resources.ApplyResources(this.actualSizeBtn, "actualSizeBtn");
			this.actualSizeBtn.ForeColor = System.Drawing.Color.Black;
			this.actualSizeBtn.Name = "actualSizeBtn";
			this.actualSizeBtn.Click += new System.EventHandler(this.actualSizeBtn_Click);
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStripSeparator9.DarkMode = false;
			this.toolStripSeparator9.InsideMenu = true;
			this.toolStripSeparator9.Margin = new System.Windows.Forms.Padding(4);
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
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
			this.qlibMenuSeparator1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.qlibMenuSeparator1.DarkMode = false;
			this.qlibMenuSeparator1.InsideMenu = true;
			this.qlibMenuSeparator1.Margin = new System.Windows.Forms.Padding(4);
			this.qlibMenuSeparator1.Name = "qlibMenuSeparator1";
			resources.ApplyResources(this.qlibMenuSeparator1, "qlibMenuSeparator1");
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
			// toolStripSeparator10
			// 
			this.toolStripSeparator10.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStripSeparator10.DarkMode = false;
			this.toolStripSeparator10.InsideMenu = true;
			this.toolStripSeparator10.Margin = new System.Windows.Forms.Padding(4);
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
			// 
			// settingsButton
			// 
			this.settingsButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.settingsButton.ForeColor = System.Drawing.Color.Black;
			resources.ApplyResources(this.settingsButton, "settingsButton");
			this.settingsButton.Name = "settingsButton";
			this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
			// 
			// aboutBtn
			// 
			this.aboutBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.aboutBtn.ForeColor = System.Drawing.Color.Black;
			resources.ApplyResources(this.aboutBtn, "aboutBtn");
			this.aboutBtn.Name = "aboutBtn";
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
			this.picturePanel.DoubleClick += new System.EventHandler(this.picturePanel_DoubleClick);
			this.picturePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseDown);
			this.picturePanel.MouseEnter += new System.EventHandler(this.picturePanel_MouseEnter);
			this.picturePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseMove);
			this.picturePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseUp);
			// 
			// rmbMenu
			// 
			resources.ApplyResources(this.rmbMenu, "rmbMenu");
			this.rmbMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMenuItem});
			this.rmbMenu.Name = "rmbMenu";
			// 
			// showMenuItem
			// 
			this.showMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
			this.showMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolbarBtn,
            this.showStatusBarBtn});
			resources.ApplyResources(this.showMenuItem, "showMenuItem");
			this.showMenuItem.ForeColor = System.Drawing.Color.Black;
			this.showMenuItem.Image = global::quick_picture_viewer.Properties.Resources.black_show;
			this.showMenuItem.Name = "showMenuItem";
			this.showMenuItem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			// 
			// showStatusBarBtn
			// 
			this.showStatusBarBtn.Image = global::quick_picture_viewer.Properties.Resources.black_statusbar;
			this.showStatusBarBtn.Name = "showStatusBarBtn";
			this.showStatusBarBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			resources.ApplyResources(this.showStatusBarBtn, "showStatusBarBtn");
			this.showStatusBarBtn.Click += new System.EventHandler(this.showStatusBarBtn_Click);
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
			// typeOpsButton
			// 
			resources.ApplyResources(this.typeOpsButton, "typeOpsButton");
			this.typeOpsButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.typeOpsButton.FlatAppearance.BorderSize = 0;
			this.typeOpsButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.typeOpsButton.Name = "typeOpsButton";
			this.typeOpsButton.TabStop = false;
			this.typeOpsButton.UseVisualStyleBackColor = false;
			this.typeOpsButton.VisibleChanged += new System.EventHandler(this.typeOpsButton_VisibleChanged);
			this.typeOpsButton.Click += new System.EventHandler(this.typeOpsButton_Click);
			// 
			// showToolbarBtn
			// 
			this.showToolbarBtn.Image = global::quick_picture_viewer.Properties.Resources.black_toolbar;
			this.showToolbarBtn.Name = "showToolbarBtn";
			this.showToolbarBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			resources.ApplyResources(this.showToolbarBtn, "showToolbarBtn");
			this.showToolbarBtn.Click += new System.EventHandler(this.showToolbarBtn_Click);
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.typeOpsButton);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.picturePanel);
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
			this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.picturePanel.ResumeLayout(false);
			this.picturePanel.PerformLayout();
			this.rmbMenu.ResumeLayout(false);
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
		private System.Windows.Forms.ToolStripButton openButton;
		private QuickLibrary.QlibToolsep toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton zoomInButton;
		private System.Windows.Forms.ToolStripButton zoomOutButton;
		private System.Windows.Forms.ToolStripButton autoZoomButton;
		private QuickLibrary.QlibToolsep toolStripSeparator2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStripButton pasteButton;
		private System.Windows.Forms.ToolStripButton framelessCloseBtn;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel directoryLabel;
		private System.Windows.Forms.ToolStripStatusLabel fileLabel;
		private System.Windows.Forms.ToolStripStatusLabel sizeLabel;
		private System.Windows.Forms.ToolStripStatusLabel zoomLabel;
		private System.Windows.Forms.ToolStripButton nextButton;
		private QuickLibrary.QlibToolsep toolStripSeparator4;
		private QuickLibrary.QlibToolsep toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton prevButton;
		private System.Windows.Forms.ToolStripStatusLabel dateCreatedLabel;
		private System.Windows.Forms.ToolStripStatusLabel dateModifiedLabel;
		private System.Windows.Forms.ToolStripButton infoButton;
		private CustomPanel picturePanel;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.ToolStripStatusLabel hasChangesLabel;
		private System.Windows.Forms.ToolStripButton showFileButton;
		private System.Windows.Forms.ToolStripButton checkboardButton;
		private System.Windows.Forms.ToolStripButton saveAsButton;
		private System.Windows.Forms.Label suggestionLabel;
		private System.Windows.Forms.ToolStripButton slideshowButton;
		private System.Windows.Forms.ToolStripDropDownButton moreButton;
		private System.Windows.Forms.ToolStripMenuItem setAsDesktopButton;
		private System.Windows.Forms.ToolStripMenuItem actualSizeBtn;
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
		private System.Windows.Forms.ToolStripDropDownButton copyButton;
		private System.Windows.Forms.ToolStripMenuItem copyImageButton;
		private System.Windows.Forms.ToolStripMenuItem copyFileBtn;
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
		private QuickLibrary.QlibToolsep qlibMenuSeparator2;
		private System.Windows.Forms.ToolStripMenuItem aboutBtn;
		private System.Windows.Forms.ToolStripMenuItem framelessBtn;
		private System.Windows.Forms.ToolStripMenuItem customAngleBtn;
		private QuickLibrary.QlibToolsep toolStripSeparator3;
		private System.Windows.Forms.ToolStripDropDownButton effectsBtn;
		private System.Windows.Forms.ToolStripMenuItem pluginManBtn;
		private System.Windows.Forms.PictureBox suggestionIcon;
		private System.Windows.Forms.ToolStripDropDownButton toolsBtn;
		private System.Windows.Forms.ToolStripMenuItem pluginManBtn2;
		private QuickLibrary.QlibToolsep qlibToolsep1;
		private System.Windows.Forms.ToolStripButton fullscreenBtn;
		private QuickLibrary.QlibContextMenuStrip rmbMenu;
		private System.Windows.Forms.ToolStripMenuItem showMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showStatusBarBtn;
		private System.Windows.Forms.ToolStripMenuItem showToolbarBtn;
	}
}
