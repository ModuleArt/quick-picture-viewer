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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.directoryLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.fileLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.sizeLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.zoomLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.hasChangesLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.dateCreatedLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.dateModifiedLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.typeOpsButton = new System.Windows.Forms.Button();
			this.suggestionLabel = new System.Windows.Forms.Label();
			this.toolStrip1 = new QuickLibrary.QlibToolStrip();
			this.openButton = new System.Windows.Forms.ToolStripButton();
			this.saveAsButton = new System.Windows.Forms.ToolStripButton();
			this.printButton = new System.Windows.Forms.ToolStripButton();
			this.deleteButton = new System.Windows.Forms.ToolStripButton();
			this.externalButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.prevButton = new System.Windows.Forms.ToolStripButton();
			this.showFileButton = new System.Windows.Forms.ToolStripButton();
			this.nextButton = new System.Windows.Forms.ToolStripButton();
			this.slideshowButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.autoZoomButton = new System.Windows.Forms.ToolStripButton();
			this.zoomOutButton = new System.Windows.Forms.ToolStripButton();
			this.zoomComboBox = new QuickLibrary.QlibToolStripComboBox();
			this.zoomInButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.editButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.flipHorizontalButton = new System.Windows.Forms.ToolStripMenuItem();
			this.flipVerticalButton = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new QuickLibrary.QlibMenuSeparator();
			this.rotateRightButton = new System.Windows.Forms.ToolStripMenuItem();
			this.rotateLeftButton = new System.Windows.Forms.ToolStripMenuItem();
			this.rotate180Button = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator8 = new QuickLibrary.QlibMenuSeparator();
			this.resizeButton = new System.Windows.Forms.ToolStripMenuItem();
			this.cropButton = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.screenshotButton = new System.Windows.Forms.ToolStripButton();
			this.infoButton = new System.Windows.Forms.ToolStripButton();
			this.copyButton = new System.Windows.Forms.ToolStripButton();
			this.pasteButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.checkboardButton = new System.Windows.Forms.ToolStripButton();
			this.fullscreenButton = new System.Windows.Forms.ToolStripButton();
			this.onTopButton = new System.Windows.Forms.ToolStripButton();
			this.miniViewButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.moreButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.reloadButton = new System.Windows.Forms.ToolStripMenuItem();
			this.setAsDesktopButton = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator9 = new QuickLibrary.QlibMenuSeparator();
			this.newWindowButton = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator10 = new QuickLibrary.QlibMenuSeparator();
			this.settingsButton = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
			this.picturePanel = new quick_picture_viewer.CustomPanel();
			this.pleaseOpenLabel = new System.Windows.Forms.Label();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.picturePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "image";
			this.openFileDialog1.Filter = resources.GetString("openFileDialog1.Filter");
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "image";
			this.saveFileDialog1.Filter = "PNG (*.png)|*.png|JPEG (*.jpg, *.jpeg, *.jpe, *.jfif, *.exif)|*.jpg|GIF (*.gif)|*" +
    ".gif|BMP (*.bmp, *.dib, *.rle)|*.bmp|TIFF (*.tiff, *.tif)|*.tiff|ICO (*.ico)|*.i" +
    "co|WEBP (*.webp)|*.webp";
			// 
			// directoryLabel
			// 
			this.directoryLabel.BackColor = System.Drawing.Color.Transparent;
			this.directoryLabel.Image = ((System.Drawing.Image)(resources.GetObject("directoryLabel.Image")));
			this.directoryLabel.Margin = new System.Windows.Forms.Padding(8);
			this.directoryLabel.Name = "directoryLabel";
			this.directoryLabel.Size = new System.Drawing.Size(104, 17);
			this.directoryLabel.Text = "Folder: Empty";
			// 
			// fileLabel
			// 
			this.fileLabel.BackColor = System.Drawing.Color.Transparent;
			this.fileLabel.Image = ((System.Drawing.Image)(resources.GetObject("fileLabel.Image")));
			this.fileLabel.Margin = new System.Windows.Forms.Padding(8);
			this.fileLabel.Name = "fileLabel";
			this.fileLabel.Size = new System.Drawing.Size(86, 17);
			this.fileLabel.Text = "File: Empty";
			// 
			// sizeLabel
			// 
			this.sizeLabel.BackColor = System.Drawing.Color.Transparent;
			this.sizeLabel.Image = ((System.Drawing.Image)(resources.GetObject("sizeLabel.Image")));
			this.sizeLabel.Margin = new System.Windows.Forms.Padding(8);
			this.sizeLabel.Name = "sizeLabel";
			this.sizeLabel.Size = new System.Drawing.Size(100, 17);
			this.sizeLabel.Text = "Size: 0 x 0 px";
			// 
			// zoomLabel
			// 
			this.zoomLabel.BackColor = System.Drawing.Color.Transparent;
			this.zoomLabel.Image = ((System.Drawing.Image)(resources.GetObject("zoomLabel.Image")));
			this.zoomLabel.Margin = new System.Windows.Forms.Padding(8);
			this.zoomLabel.Name = "zoomLabel";
			this.zoomLabel.Size = new System.Drawing.Size(92, 17);
			this.zoomLabel.Text = "Zoom: Auto";
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directoryLabel,
            this.fileLabel,
            this.sizeLabel,
            this.zoomLabel,
            this.hasChangesLabel,
            this.dateCreatedLabel,
            this.dateModifiedLabel});
			this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.statusStrip1.Location = new System.Drawing.Point(0, 466);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(768, 33);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// hasChangesLabel
			// 
			this.hasChangesLabel.BackColor = System.Drawing.Color.Transparent;
			this.hasChangesLabel.Image = ((System.Drawing.Image)(resources.GetObject("hasChangesLabel.Image")));
			this.hasChangesLabel.Margin = new System.Windows.Forms.Padding(8);
			this.hasChangesLabel.Name = "hasChangesLabel";
			this.hasChangesLabel.Size = new System.Drawing.Size(84, 17);
			this.hasChangesLabel.Text = "Not saved";
			this.hasChangesLabel.Visible = false;
			// 
			// dateCreatedLabel
			// 
			this.dateCreatedLabel.BackColor = System.Drawing.Color.Transparent;
			this.dateCreatedLabel.Image = ((System.Drawing.Image)(resources.GetObject("dateCreatedLabel.Image")));
			this.dateCreatedLabel.Margin = new System.Windows.Forms.Padding(8);
			this.dateCreatedLabel.Name = "dateCreatedLabel";
			this.dateCreatedLabel.Size = new System.Drawing.Size(130, 17);
			this.dateCreatedLabel.Text = "Created: Unknown";
			this.dateCreatedLabel.Visible = false;
			// 
			// dateModifiedLabel
			// 
			this.dateModifiedLabel.BackColor = System.Drawing.Color.Transparent;
			this.dateModifiedLabel.Image = ((System.Drawing.Image)(resources.GetObject("dateModifiedLabel.Image")));
			this.dateModifiedLabel.Margin = new System.Windows.Forms.Padding(8);
			this.dateModifiedLabel.Name = "dateModifiedLabel";
			this.dateModifiedLabel.Size = new System.Drawing.Size(137, 17);
			this.dateModifiedLabel.Text = "Modified: Unknown";
			this.dateModifiedLabel.Visible = false;
			// 
			// printDialog1
			// 
			this.printDialog1.Document = this.printDocument1;
			this.printDialog1.UseEXDialog = true;
			// 
			// printDocument1
			// 
			this.printDocument1.DocumentName = "Image";
			this.printDocument1.OriginAtMargins = true;
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// typeOpsButton
			// 
			this.typeOpsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.typeOpsButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.typeOpsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.typeOpsButton.FlatAppearance.BorderSize = 0;
			this.typeOpsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.typeOpsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.typeOpsButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.typeOpsButton.Image = ((System.Drawing.Image)(resources.GetObject("typeOpsButton.Image")));
			this.typeOpsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.typeOpsButton.Location = new System.Drawing.Point(628, 414);
			this.typeOpsButton.Margin = new System.Windows.Forms.Padding(0);
			this.typeOpsButton.Name = "typeOpsButton";
			this.typeOpsButton.Size = new System.Drawing.Size(113, 32);
			this.typeOpsButton.TabIndex = 0;
			this.typeOpsButton.TabStop = false;
			this.typeOpsButton.Text = "TYPE options";
			this.typeOpsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.typeOpsButton.UseVisualStyleBackColor = false;
			this.typeOpsButton.Visible = false;
			this.typeOpsButton.VisibleChanged += new System.EventHandler(this.typeOpsButton_VisibleChanged);
			this.typeOpsButton.Click += new System.EventHandler(this.typeOpsButton_Click);
			this.typeOpsButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.typeOpsButton_PreviewKeyDown);
			// 
			// suggestionLabel
			// 
			this.suggestionLabel.AutoSize = true;
			this.suggestionLabel.BackColor = System.Drawing.Color.Black;
			this.suggestionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.suggestionLabel.ForeColor = System.Drawing.Color.White;
			this.suggestionLabel.Location = new System.Drawing.Point(10, 44);
			this.suggestionLabel.Margin = new System.Windows.Forms.Padding(10);
			this.suggestionLabel.Name = "suggestionLabel";
			this.suggestionLabel.Padding = new System.Windows.Forms.Padding(3);
			this.suggestionLabel.Size = new System.Drawing.Size(79, 23);
			this.suggestionLabel.TabIndex = 3;
			this.suggestionLabel.Text = "Suggestion";
			this.suggestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.suggestionLabel.Visible = false;
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.White;
			this.toolStrip1.CanOverflow = false;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton,
            this.saveAsButton,
            this.printButton,
            this.deleteButton,
            this.externalButton,
            this.toolStripSeparator4,
            this.prevButton,
            this.showFileButton,
            this.nextButton,
            this.slideshowButton,
            this.toolStripSeparator1,
            this.autoZoomButton,
            this.zoomOutButton,
            this.zoomComboBox,
            this.zoomInButton,
            this.toolStripSeparator2,
            this.editButton,
            this.toolStripSeparator3,
            this.screenshotButton,
            this.infoButton,
            this.copyButton,
            this.pasteButton,
            this.toolStripSeparator5,
            this.checkboardButton,
            this.fullscreenButton,
            this.onTopButton,
            this.miniViewButton,
            this.toolStripSeparator6,
            this.moreButton});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.Size = new System.Drawing.Size(768, 35);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// openButton
			// 
			this.openButton.AutoSize = false;
			this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
			this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openButton.Margin = new System.Windows.Forms.Padding(0);
			this.openButton.Name = "openButton";
			this.openButton.Size = new System.Drawing.Size(24, 25);
			this.openButton.Text = "Open file | Ctrl + O";
			this.openButton.Click += new System.EventHandler(this.openButton_Click_1);
			// 
			// saveAsButton
			// 
			this.saveAsButton.AutoSize = false;
			this.saveAsButton.BackColor = System.Drawing.Color.Transparent;
			this.saveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveAsButton.Enabled = false;
			this.saveAsButton.Image = ((System.Drawing.Image)(resources.GetObject("saveAsButton.Image")));
			this.saveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveAsButton.Margin = new System.Windows.Forms.Padding(0);
			this.saveAsButton.Name = "saveAsButton";
			this.saveAsButton.Size = new System.Drawing.Size(24, 25);
			this.saveAsButton.Text = "Save as | Ctrl + S";
			this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
			// 
			// printButton
			// 
			this.printButton.AutoSize = false;
			this.printButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.printButton.Enabled = false;
			this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
			this.printButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.printButton.Margin = new System.Windows.Forms.Padding(0);
			this.printButton.Name = "printButton";
			this.printButton.Size = new System.Drawing.Size(24, 25);
			this.printButton.Text = "Print | Ctrl + P";
			this.printButton.Click += new System.EventHandler(this.printButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.AutoSize = false;
			this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.deleteButton.Enabled = false;
			this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
			this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.deleteButton.Margin = new System.Windows.Forms.Padding(0);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(24, 25);
			this.deleteButton.Text = "Move file to trash | Delete";
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// externalButton
			// 
			this.externalButton.AutoSize = false;
			this.externalButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.externalButton.Enabled = false;
			this.externalButton.Image = ((System.Drawing.Image)(resources.GetObject("externalButton.Image")));
			this.externalButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.externalButton.Margin = new System.Windows.Forms.Padding(0);
			this.externalButton.Name = "externalButton";
			this.externalButton.Size = new System.Drawing.Size(24, 25);
			this.externalButton.Text = "Open file with external app | Ctrl + E";
			this.externalButton.Click += new System.EventHandler(this.externalButton_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.AutoSize = false;
			this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(2, 16);
			// 
			// prevButton
			// 
			this.prevButton.AutoSize = false;
			this.prevButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.prevButton.Enabled = false;
			this.prevButton.Image = ((System.Drawing.Image)(resources.GetObject("prevButton.Image")));
			this.prevButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.prevButton.Margin = new System.Windows.Forms.Padding(0);
			this.prevButton.Name = "prevButton";
			this.prevButton.Size = new System.Drawing.Size(24, 25);
			this.prevButton.Text = "Previous image in folder | Left arrow";
			this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
			// 
			// showFileButton
			// 
			this.showFileButton.AutoSize = false;
			this.showFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.showFileButton.Enabled = false;
			this.showFileButton.Image = ((System.Drawing.Image)(resources.GetObject("showFileButton.Image")));
			this.showFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.showFileButton.Margin = new System.Windows.Forms.Padding(0);
			this.showFileButton.Name = "showFileButton";
			this.showFileButton.Size = new System.Drawing.Size(24, 25);
			this.showFileButton.Text = "Show file in explorer | Ctrl + Shift + E";
			this.showFileButton.ToolTipText = "Show file in explorer | Ctrl + Shift + E";
			this.showFileButton.Click += new System.EventHandler(this.showFileButton_Click);
			// 
			// nextButton
			// 
			this.nextButton.AutoSize = false;
			this.nextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.nextButton.Enabled = false;
			this.nextButton.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Image")));
			this.nextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.nextButton.Margin = new System.Windows.Forms.Padding(0);
			this.nextButton.Name = "nextButton";
			this.nextButton.Size = new System.Drawing.Size(24, 25);
			this.nextButton.Text = "Next image in folder | Right arrow";
			this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
			// 
			// slideshowButton
			// 
			this.slideshowButton.AutoSize = false;
			this.slideshowButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.slideshowButton.Enabled = false;
			this.slideshowButton.Image = ((System.Drawing.Image)(resources.GetObject("slideshowButton.Image")));
			this.slideshowButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.slideshowButton.Margin = new System.Windows.Forms.Padding(0);
			this.slideshowButton.Name = "slideshowButton";
			this.slideshowButton.Size = new System.Drawing.Size(24, 25);
			this.slideshowButton.Text = "Slideshow | Ctrl + Shift + S";
			this.slideshowButton.Click += new System.EventHandler(this.slideshowButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.AutoSize = false;
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(2, 16);
			// 
			// autoZoomButton
			// 
			this.autoZoomButton.AutoSize = false;
			this.autoZoomButton.Checked = true;
			this.autoZoomButton.CheckState = System.Windows.Forms.CheckState.Checked;
			this.autoZoomButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.autoZoomButton.Enabled = false;
			this.autoZoomButton.Image = ((System.Drawing.Image)(resources.GetObject("autoZoomButton.Image")));
			this.autoZoomButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.autoZoomButton.Margin = new System.Windows.Forms.Padding(0);
			this.autoZoomButton.Name = "autoZoomButton";
			this.autoZoomButton.Size = new System.Drawing.Size(24, 25);
			this.autoZoomButton.Text = "Auto zoom | Ctrl + A";
			this.autoZoomButton.Click += new System.EventHandler(this.autoZoomButton_Click);
			// 
			// zoomOutButton
			// 
			this.zoomOutButton.AutoSize = false;
			this.zoomOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zoomOutButton.Enabled = false;
			this.zoomOutButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutButton.Image")));
			this.zoomOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.zoomOutButton.Margin = new System.Windows.Forms.Padding(0);
			this.zoomOutButton.Name = "zoomOutButton";
			this.zoomOutButton.Size = new System.Drawing.Size(24, 25);
			this.zoomOutButton.Text = "Zoom out | Ctrl + Minus";
			this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
			this.zoomOutButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zoomOutButton_MouseDown);
			this.zoomOutButton.MouseLeave += new System.EventHandler(this.zoomOutButton_MouseLeave);
			this.zoomOutButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zoomOutButton_MouseUp);
			// 
			// zoomComboBox
			// 
			this.zoomComboBox.AutoSize = false;
			this.zoomComboBox.DropDownWidth = 75;
			this.zoomComboBox.Enabled = false;
			this.zoomComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
			this.zoomComboBox.Items.AddRange(new object[] {
            "Auto",
            "1%",
            "2%",
            "3%",
            "4%",
            "5%",
            "6%",
            "7%",
            "8%",
            "10%",
            "13%",
            "17%",
            "20%",
            "25%",
            "33%",
            "50%",
            "67%",
            "100%",
            "150%",
            "200%",
            "300%",
            "400%",
            "500%",
            "600%",
            "800%",
            "1000%"});
			this.zoomComboBox.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.zoomComboBox.Name = "zoomComboBox";
			this.zoomComboBox.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.zoomComboBox.Size = new System.Drawing.Size(60, 24);
			this.zoomComboBox.ToolTipText = "Zoom";
			this.zoomComboBox.TextChanged += new System.EventHandler(this.zoomComboBox_TextChanged);
			// 
			// zoomInButton
			// 
			this.zoomInButton.AutoSize = false;
			this.zoomInButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zoomInButton.Enabled = false;
			this.zoomInButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomInButton.Image")));
			this.zoomInButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.zoomInButton.Margin = new System.Windows.Forms.Padding(0);
			this.zoomInButton.Name = "zoomInButton";
			this.zoomInButton.Size = new System.Drawing.Size(24, 25);
			this.zoomInButton.Text = "Zoom in | Ctrl + =";
			this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
			this.zoomInButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zoomInButton_MouseDown);
			this.zoomInButton.MouseLeave += new System.EventHandler(this.zoomInButton_MouseLeave);
			this.zoomInButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zoomInButton_MouseUp);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.AutoSize = false;
			this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(2, 16);
			// 
			// editButton
			// 
			this.editButton.AutoSize = false;
			this.editButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipHorizontalButton,
            this.flipVerticalButton,
            this.toolStripSeparator7,
            this.rotateRightButton,
            this.rotateLeftButton,
            this.rotate180Button,
            this.toolStripSeparator8,
            this.resizeButton,
            this.cropButton});
			this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
			this.editButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.editButton.Margin = new System.Windows.Forms.Padding(0);
			this.editButton.Name = "editButton";
			this.editButton.ShowDropDownArrow = false;
			this.editButton.Size = new System.Drawing.Size(50, 25);
			this.editButton.Text = " Edit";
			this.editButton.ToolTipText = "Edit image";
			// 
			// flipHorizontalButton
			// 
			this.flipHorizontalButton.Enabled = false;
			this.flipHorizontalButton.Image = ((System.Drawing.Image)(resources.GetObject("flipHorizontalButton.Image")));
			this.flipHorizontalButton.Name = "flipHorizontalButton";
			this.flipHorizontalButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
			this.flipHorizontalButton.Size = new System.Drawing.Size(282, 22);
			this.flipHorizontalButton.Text = "Flip horizontal";
			this.flipHorizontalButton.Click += new System.EventHandler(this.flipHorizontalButton_Click);
			// 
			// flipVerticalButton
			// 
			this.flipVerticalButton.Enabled = false;
			this.flipVerticalButton.Image = ((System.Drawing.Image)(resources.GetObject("flipVerticalButton.Image")));
			this.flipVerticalButton.Name = "flipVerticalButton";
			this.flipVerticalButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
			this.flipVerticalButton.Size = new System.Drawing.Size(282, 22);
			this.flipVerticalButton.Text = "Flip vertical";
			this.flipVerticalButton.Click += new System.EventHandler(this.flipVerticalButton_Click);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Margin = new System.Windows.Forms.Padding(3);
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(279, 6);
			// 
			// rotateRightButton
			// 
			this.rotateRightButton.Enabled = false;
			this.rotateRightButton.Image = ((System.Drawing.Image)(resources.GetObject("rotateRightButton.Image")));
			this.rotateRightButton.Name = "rotateRightButton";
			this.rotateRightButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
			this.rotateRightButton.Size = new System.Drawing.Size(282, 22);
			this.rotateRightButton.Text = "Rotate clockwise";
			this.rotateRightButton.Click += new System.EventHandler(this.rotateRightButton_Click);
			// 
			// rotateLeftButton
			// 
			this.rotateLeftButton.Enabled = false;
			this.rotateLeftButton.Image = ((System.Drawing.Image)(resources.GetObject("rotateLeftButton.Image")));
			this.rotateLeftButton.Name = "rotateLeftButton";
			this.rotateLeftButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
			this.rotateLeftButton.Size = new System.Drawing.Size(282, 22);
			this.rotateLeftButton.Text = "Rotate counter-clockwise";
			this.rotateLeftButton.Click += new System.EventHandler(this.rotateLeftButton_Click);
			// 
			// rotate180Button
			// 
			this.rotate180Button.Enabled = false;
			this.rotate180Button.Image = ((System.Drawing.Image)(resources.GetObject("rotate180Button.Image")));
			this.rotate180Button.Name = "rotate180Button";
			this.rotate180Button.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
			this.rotate180Button.Size = new System.Drawing.Size(282, 22);
			this.rotate180Button.Text = "Rotate 180°";
			this.rotate180Button.Click += new System.EventHandler(this.rotate180Button_Click);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Margin = new System.Windows.Forms.Padding(3);
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(279, 6);
			this.toolStripSeparator8.Visible = false;
			// 
			// resizeButton
			// 
			this.resizeButton.Enabled = false;
			this.resizeButton.Image = ((System.Drawing.Image)(resources.GetObject("resizeButton.Image")));
			this.resizeButton.Name = "resizeButton";
			this.resizeButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.resizeButton.Size = new System.Drawing.Size(282, 22);
			this.resizeButton.Text = "Resize";
			this.resizeButton.Visible = false;
			// 
			// cropButton
			// 
			this.cropButton.Enabled = false;
			this.cropButton.Image = ((System.Drawing.Image)(resources.GetObject("cropButton.Image")));
			this.cropButton.Name = "cropButton";
			this.cropButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
			this.cropButton.Size = new System.Drawing.Size(282, 22);
			this.cropButton.Text = "Crop";
			this.cropButton.Visible = false;
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.AutoSize = false;
			this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(2, 16);
			// 
			// screenshotButton
			// 
			this.screenshotButton.AutoSize = false;
			this.screenshotButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.screenshotButton.Image = ((System.Drawing.Image)(resources.GetObject("screenshotButton.Image")));
			this.screenshotButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.screenshotButton.Margin = new System.Windows.Forms.Padding(0);
			this.screenshotButton.Name = "screenshotButton";
			this.screenshotButton.Size = new System.Drawing.Size(24, 25);
			this.screenshotButton.Text = "Capture screen | F12";
			this.screenshotButton.ToolTipText = "Capture screen | F12";
			this.screenshotButton.Click += new System.EventHandler(this.screenshotButton_Click);
			// 
			// infoButton
			// 
			this.infoButton.AutoSize = false;
			this.infoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.infoButton.Enabled = false;
			this.infoButton.Image = ((System.Drawing.Image)(resources.GetObject("infoButton.Image")));
			this.infoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.infoButton.Margin = new System.Windows.Forms.Padding(0);
			this.infoButton.Name = "infoButton";
			this.infoButton.Size = new System.Drawing.Size(24, 25);
			this.infoButton.Text = "Image info | Ctrl + I";
			this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
			// 
			// copyButton
			// 
			this.copyButton.AutoSize = false;
			this.copyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.copyButton.Enabled = false;
			this.copyButton.Image = ((System.Drawing.Image)(resources.GetObject("copyButton.Image")));
			this.copyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copyButton.Margin = new System.Windows.Forms.Padding(0);
			this.copyButton.Name = "copyButton";
			this.copyButton.Size = new System.Drawing.Size(24, 25);
			this.copyButton.Text = "Copy image | Ctrl + C";
			this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
			// 
			// pasteButton
			// 
			this.pasteButton.AutoSize = false;
			this.pasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pasteButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteButton.Image")));
			this.pasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pasteButton.Margin = new System.Windows.Forms.Padding(0);
			this.pasteButton.Name = "pasteButton";
			this.pasteButton.Size = new System.Drawing.Size(24, 25);
			this.pasteButton.Text = "Paste image | Ctrl + V";
			this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.AutoSize = false;
			this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(2, 16);
			// 
			// checkboardButton
			// 
			this.checkboardButton.AutoSize = false;
			this.checkboardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.checkboardButton.Image = ((System.Drawing.Image)(resources.GetObject("checkboardButton.Image")));
			this.checkboardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.checkboardButton.Margin = new System.Windows.Forms.Padding(0);
			this.checkboardButton.Name = "checkboardButton";
			this.checkboardButton.Size = new System.Drawing.Size(24, 25);
			this.checkboardButton.Text = "Checkboard background | Ctrl + Shift +C";
			this.checkboardButton.ToolTipText = "Checkboard background | Ctrl + Shift +C";
			this.checkboardButton.Click += new System.EventHandler(this.checkboardButton_Click);
			// 
			// fullscreenButton
			// 
			this.fullscreenButton.AutoSize = false;
			this.fullscreenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.fullscreenButton.Image = ((System.Drawing.Image)(resources.GetObject("fullscreenButton.Image")));
			this.fullscreenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.fullscreenButton.Margin = new System.Windows.Forms.Padding(0);
			this.fullscreenButton.Name = "fullscreenButton";
			this.fullscreenButton.Size = new System.Drawing.Size(24, 25);
			this.fullscreenButton.Text = "Fullscreen | F";
			this.fullscreenButton.Click += new System.EventHandler(this.fullscreenButton_Click);
			// 
			// onTopButton
			// 
			this.onTopButton.AutoSize = false;
			this.onTopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.onTopButton.Image = ((System.Drawing.Image)(resources.GetObject("onTopButton.Image")));
			this.onTopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.onTopButton.Margin = new System.Windows.Forms.Padding(0);
			this.onTopButton.Name = "onTopButton";
			this.onTopButton.Size = new System.Drawing.Size(24, 25);
			this.onTopButton.Text = "Always on top | Ctrl + T";
			this.onTopButton.Click += new System.EventHandler(this.onTopButton_Click);
			// 
			// miniViewButton
			// 
			this.miniViewButton.AutoSize = false;
			this.miniViewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.miniViewButton.Enabled = false;
			this.miniViewButton.Image = ((System.Drawing.Image)(resources.GetObject("miniViewButton.Image")));
			this.miniViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.miniViewButton.Margin = new System.Windows.Forms.Padding(0);
			this.miniViewButton.Name = "miniViewButton";
			this.miniViewButton.Size = new System.Drawing.Size(24, 25);
			this.miniViewButton.Text = "Picture in picture | Ctrl + Shift + P";
			this.miniViewButton.ToolTipText = "Picture in picture | Ctrl + Shift + P";
			this.miniViewButton.Click += new System.EventHandler(this.miniViewButton_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.AutoSize = false;
			this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(2, 16);
			// 
			// moreButton
			// 
			this.moreButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.moreButton.AutoSize = false;
			this.moreButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadButton,
            this.setAsDesktopButton,
            this.toolStripSeparator9,
            this.newWindowButton,
            this.toolStripSeparator10,
            this.settingsButton,
            this.aboutButton});
			this.moreButton.Image = ((System.Drawing.Image)(resources.GetObject("moreButton.Image")));
			this.moreButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.moreButton.Margin = new System.Windows.Forms.Padding(0);
			this.moreButton.Name = "moreButton";
			this.moreButton.ShowDropDownArrow = false;
			this.moreButton.Size = new System.Drawing.Size(58, 25);
			this.moreButton.Text = " More";
			this.moreButton.ToolTipText = "More options";
			// 
			// reloadButton
			// 
			this.reloadButton.Enabled = false;
			this.reloadButton.Image = ((System.Drawing.Image)(resources.GetObject("reloadButton.Image")));
			this.reloadButton.Name = "reloadButton";
			this.reloadButton.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.reloadButton.Size = new System.Drawing.Size(257, 22);
			this.reloadButton.Text = "Reload file";
			this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
			// 
			// setAsDesktopButton
			// 
			this.setAsDesktopButton.Enabled = false;
			this.setAsDesktopButton.Image = ((System.Drawing.Image)(resources.GetObject("setAsDesktopButton.Image")));
			this.setAsDesktopButton.Name = "setAsDesktopButton";
			this.setAsDesktopButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
			this.setAsDesktopButton.Size = new System.Drawing.Size(257, 22);
			this.setAsDesktopButton.Text = "Set as desktop background";
			this.setAsDesktopButton.Click += new System.EventHandler(this.setAsDesktopButton_Click);
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.Margin = new System.Windows.Forms.Padding(3);
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new System.Drawing.Size(254, 6);
			// 
			// newWindowButton
			// 
			this.newWindowButton.Image = ((System.Drawing.Image)(resources.GetObject("newWindowButton.Image")));
			this.newWindowButton.Name = "newWindowButton";
			this.newWindowButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newWindowButton.Size = new System.Drawing.Size(257, 22);
			this.newWindowButton.Text = "New window";
			this.newWindowButton.Click += new System.EventHandler(this.newWindowButton_Click);
			// 
			// toolStripSeparator10
			// 
			this.toolStripSeparator10.Margin = new System.Windows.Forms.Padding(3);
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new System.Drawing.Size(254, 6);
			// 
			// settingsButton
			// 
			this.settingsButton.BackColor = System.Drawing.Color.Black;
			this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
			this.settingsButton.Name = "settingsButton";
			this.settingsButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemcomma)));
			this.settingsButton.Size = new System.Drawing.Size(257, 22);
			this.settingsButton.Text = "Settings";
			this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
			// 
			// aboutButton
			// 
			this.aboutButton.BackColor = System.Drawing.Color.Black;
			this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
			this.aboutButton.Name = "aboutButton";
			this.aboutButton.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.aboutButton.Size = new System.Drawing.Size(257, 22);
			this.aboutButton.Text = "About";
			this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
			// 
			// picturePanel
			// 
			this.picturePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picturePanel.AutoScroll = true;
			this.picturePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.picturePanel.BackColor = System.Drawing.Color.Transparent;
			this.picturePanel.Controls.Add(this.pleaseOpenLabel);
			this.picturePanel.Controls.Add(this.pictureBox);
			this.picturePanel.Location = new System.Drawing.Point(0, 35);
			this.picturePanel.Margin = new System.Windows.Forms.Padding(0);
			this.picturePanel.Name = "picturePanel";
			this.picturePanel.Size = new System.Drawing.Size(768, 432);
			this.picturePanel.TabIndex = 2;
			this.picturePanel.DoubleClick += new System.EventHandler(this.picturePanel_DoubleClick);
			this.picturePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseDown);
			this.picturePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseMove);
			this.picturePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseUp);
			// 
			// pleaseOpenLabel
			// 
			this.pleaseOpenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pleaseOpenLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pleaseOpenLabel.Location = new System.Drawing.Point(0, 0);
			this.pleaseOpenLabel.Name = "pleaseOpenLabel";
			this.pleaseOpenLabel.Size = new System.Drawing.Size(768, 432);
			this.pleaseOpenLabel.TabIndex = 5;
			this.pleaseOpenLabel.Text = "Please open an image to view or edit";
			this.pleaseOpenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.pleaseOpenLabel.DoubleClick += new System.EventHandler(this.picturePanel_DoubleClick);
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox.InitialImage = null;
			this.pictureBox.Location = new System.Drawing.Point(0, 0);
			this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(768, 432);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			this.pictureBox.DoubleClick += new System.EventHandler(this.picturePanel_DoubleClick);
			this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseDown);
			this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseMove);
			this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseUp);
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(768, 499);
			this.Controls.Add(this.suggestionLabel);
			this.Controls.Add(this.typeOpsButton);
			this.Controls.Add(this.picturePanel);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(240, 240);
			this.Name = "MainForm";
			this.Text = "Quick Picture Viewer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.picturePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private QuickLibrary.QlibToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton openButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton zoomInButton;
		private System.Windows.Forms.ToolStripButton zoomOutButton;
		private System.Windows.Forms.ToolStripButton autoZoomButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStripButton copyButton;
		private System.Windows.Forms.ToolStripButton pasteButton;
		private QuickLibrary.QlibToolStripComboBox zoomComboBox;
		private System.Windows.Forms.ToolStripButton fullscreenButton;
		private System.Windows.Forms.ToolStripButton onTopButton;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel directoryLabel;
		private System.Windows.Forms.ToolStripStatusLabel fileLabel;
		private System.Windows.Forms.ToolStripStatusLabel sizeLabel;
		private System.Windows.Forms.ToolStripStatusLabel zoomLabel;
		private System.Windows.Forms.ToolStripButton screenshotButton;
		private System.Windows.Forms.ToolStripButton nextButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton prevButton;
		private System.Windows.Forms.ToolStripButton deleteButton;
		private System.Windows.Forms.ToolStripStatusLabel dateCreatedLabel;
		private System.Windows.Forms.ToolStripStatusLabel dateModifiedLabel;
		private System.Windows.Forms.ToolStripButton infoButton;
		private System.Windows.Forms.ToolStripButton externalButton;
		private CustomPanel picturePanel;
		private System.Windows.Forms.ToolStripButton printButton;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripStatusLabel hasChangesLabel;
		private System.Windows.Forms.ToolStripButton showFileButton;
		private System.Windows.Forms.ToolStripButton checkboardButton;
		private System.Windows.Forms.ToolStripButton saveAsButton;
		private System.Windows.Forms.Label suggestionLabel;
		private System.Windows.Forms.ToolStripButton slideshowButton;
		private System.Windows.Forms.ToolStripDropDownButton moreButton;
		private System.Windows.Forms.ToolStripMenuItem setAsDesktopButton;
		private System.Windows.Forms.ToolStripMenuItem aboutButton;
		private System.Windows.Forms.Button typeOpsButton;
		private System.Windows.Forms.ToolStripMenuItem reloadButton;
		private System.Windows.Forms.ToolStripDropDownButton editButton;
		private System.Windows.Forms.ToolStripMenuItem rotateLeftButton;
		private System.Windows.Forms.ToolStripMenuItem rotateRightButton;
		private System.Windows.Forms.ToolStripMenuItem flipHorizontalButton;
		private System.Windows.Forms.ToolStripMenuItem flipVerticalButton;
		private System.Windows.Forms.ToolStripMenuItem newWindowButton;
		private System.Windows.Forms.ToolStripMenuItem resizeButton;
		private System.Windows.Forms.ToolStripMenuItem rotate180Button;
		private System.Windows.Forms.ToolStripMenuItem cropButton;
		private System.Windows.Forms.ToolStripButton miniViewButton;
		private System.Windows.Forms.ToolStripMenuItem settingsButton;
		private System.Windows.Forms.Label pleaseOpenLabel;
		private QuickLibrary.QlibMenuSeparator toolStripSeparator7;
		private QuickLibrary.QlibMenuSeparator toolStripSeparator8;
		private QuickLibrary.QlibMenuSeparator toolStripSeparator9;
		private QuickLibrary.QlibMenuSeparator toolStripSeparator10;
	}
}

