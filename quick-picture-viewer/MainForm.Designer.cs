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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.openButton = new System.Windows.Forms.ToolStripButton();
			this.saveAsButton = new System.Windows.Forms.ToolStripButton();
			this.deleteButton = new System.Windows.Forms.ToolStripButton();
			this.externalButton = new System.Windows.Forms.ToolStripButton();
			this.printButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.prevButton = new System.Windows.Forms.ToolStripButton();
			this.nextButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.autoZoomButton = new System.Windows.Forms.ToolStripButton();
			this.zoomInButton = new System.Windows.Forms.ToolStripButton();
			this.zoomComboBox = new System.Windows.Forms.ToolStripComboBox();
			this.zoomOutButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutButton = new System.Windows.Forms.ToolStripButton();
			this.rotateLeftButton = new System.Windows.Forms.ToolStripButton();
			this.rotateRightButton = new System.Windows.Forms.ToolStripButton();
			this.flipHorizontalButton = new System.Windows.Forms.ToolStripButton();
			this.flipVerticalButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.infoButton = new System.Windows.Forms.ToolStripButton();
			this.copyButton = new System.Windows.Forms.ToolStripButton();
			this.pasteButton = new System.Windows.Forms.ToolStripButton();
			this.screenshotButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.fullscreenButton = new System.Windows.Forms.ToolStripButton();
			this.onTopButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.setAsDesktopButton = new System.Windows.Forms.ToolStripButton();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.directoryLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.fileLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.sizeLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.zoomLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.dateCreatedLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.dateModifiedLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.picturePanel = new quick_picture_viewer.CustomPanel();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
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
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.White;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton,
            this.saveAsButton,
            this.deleteButton,
            this.externalButton,
            this.printButton,
            this.toolStripSeparator4,
            this.prevButton,
            this.nextButton,
            this.toolStripSeparator1,
            this.autoZoomButton,
            this.zoomInButton,
            this.zoomComboBox,
            this.zoomOutButton,
            this.toolStripSeparator2,
            this.aboutButton,
            this.rotateLeftButton,
            this.rotateRightButton,
            this.flipHorizontalButton,
            this.flipVerticalButton,
            this.toolStripSeparator3,
            this.infoButton,
            this.copyButton,
            this.pasteButton,
            this.screenshotButton,
            this.toolStripSeparator6,
            this.fullscreenButton,
            this.onTopButton,
            this.toolStripSeparator5,
            this.setAsDesktopButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.Size = new System.Drawing.Size(714, 35);
			this.toolStrip1.TabIndex = 16;
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
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.AutoSize = false;
			this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 16);
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
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.AutoSize = false;
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 16);
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
			this.autoZoomButton.Text = "Toggle auto zoom | Ctrl + A";
			this.autoZoomButton.Click += new System.EventHandler(this.autoZoomButton_Click);
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
			// 
			// zoomComboBox
			// 
			this.zoomComboBox.AutoSize = false;
			this.zoomComboBox.DropDownWidth = 75;
			this.zoomComboBox.Enabled = false;
			this.zoomComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.zoomComboBox.Items.AddRange(new object[] {
            "Auto",
            "5%",
            "10%",
            "25%",
            "50%",
            "75%",
            "100%",
            "125%",
            "150%",
            "200%",
            "250%",
            "500%"});
			this.zoomComboBox.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.zoomComboBox.Name = "zoomComboBox";
			this.zoomComboBox.Size = new System.Drawing.Size(55, 23);
			this.zoomComboBox.ToolTipText = "Zoom";
			this.zoomComboBox.TextChanged += new System.EventHandler(this.zoomComboBox_TextChanged);
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
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.AutoSize = false;
			this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 16);
			// 
			// aboutButton
			// 
			this.aboutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.aboutButton.AutoSize = false;
			this.aboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
			this.aboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.aboutButton.Margin = new System.Windows.Forms.Padding(0);
			this.aboutButton.Name = "aboutButton";
			this.aboutButton.Size = new System.Drawing.Size(24, 25);
			this.aboutButton.Text = "About | F1";
			this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
			// 
			// rotateLeftButton
			// 
			this.rotateLeftButton.AutoSize = false;
			this.rotateLeftButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.rotateLeftButton.Enabled = false;
			this.rotateLeftButton.Image = ((System.Drawing.Image)(resources.GetObject("rotateLeftButton.Image")));
			this.rotateLeftButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.rotateLeftButton.Margin = new System.Windows.Forms.Padding(0);
			this.rotateLeftButton.Name = "rotateLeftButton";
			this.rotateLeftButton.Size = new System.Drawing.Size(24, 25);
			this.rotateLeftButton.Text = "Rotate counter-clockwise | Ctrl + Shift + R";
			this.rotateLeftButton.Click += new System.EventHandler(this.rotateLeftButton_Click);
			// 
			// rotateRightButton
			// 
			this.rotateRightButton.AutoSize = false;
			this.rotateRightButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.rotateRightButton.Enabled = false;
			this.rotateRightButton.Image = ((System.Drawing.Image)(resources.GetObject("rotateRightButton.Image")));
			this.rotateRightButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.rotateRightButton.Margin = new System.Windows.Forms.Padding(0);
			this.rotateRightButton.Name = "rotateRightButton";
			this.rotateRightButton.Size = new System.Drawing.Size(24, 25);
			this.rotateRightButton.Text = "Rotate clockwise | Ctrl + R";
			this.rotateRightButton.Click += new System.EventHandler(this.rotateRightButton_Click);
			// 
			// flipHorizontalButton
			// 
			this.flipHorizontalButton.AutoSize = false;
			this.flipHorizontalButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.flipHorizontalButton.Enabled = false;
			this.flipHorizontalButton.Image = ((System.Drawing.Image)(resources.GetObject("flipHorizontalButton.Image")));
			this.flipHorizontalButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.flipHorizontalButton.Margin = new System.Windows.Forms.Padding(0);
			this.flipHorizontalButton.Name = "flipHorizontalButton";
			this.flipHorizontalButton.Size = new System.Drawing.Size(24, 25);
			this.flipHorizontalButton.Text = "Flip horizontal | Ctrl + H";
			this.flipHorizontalButton.Click += new System.EventHandler(this.flipHorizontalButton_Click);
			// 
			// flipVerticalButton
			// 
			this.flipVerticalButton.AutoSize = false;
			this.flipVerticalButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.flipVerticalButton.Enabled = false;
			this.flipVerticalButton.Image = ((System.Drawing.Image)(resources.GetObject("flipVerticalButton.Image")));
			this.flipVerticalButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.flipVerticalButton.Margin = new System.Windows.Forms.Padding(0);
			this.flipVerticalButton.Name = "flipVerticalButton";
			this.flipVerticalButton.Size = new System.Drawing.Size(24, 25);
			this.flipVerticalButton.Text = "Flip vertical | Ctrl + Shift + H";
			this.flipVerticalButton.Click += new System.EventHandler(this.flipVerticalButton_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.AutoSize = false;
			this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 16);
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
			this.pasteButton.Text = "Paste | Ctrl + V";
			this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
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
			this.screenshotButton.Text = "toolStripButton1";
			this.screenshotButton.ToolTipText = "Capture screen | F12";
			this.screenshotButton.Click += new System.EventHandler(this.screenshotButton_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
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
			this.fullscreenButton.Text = "Toggle fullscreen | F";
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
			this.onTopButton.Text = "Toggle always on top | Ctrl + T";
			this.onTopButton.Click += new System.EventHandler(this.onTopButton_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.AutoSize = false;
			this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 16);
			// 
			// setAsDesktopButton
			// 
			this.setAsDesktopButton.AutoSize = false;
			this.setAsDesktopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.setAsDesktopButton.Enabled = false;
			this.setAsDesktopButton.Image = ((System.Drawing.Image)(resources.GetObject("setAsDesktopButton.Image")));
			this.setAsDesktopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.setAsDesktopButton.Margin = new System.Windows.Forms.Padding(0);
			this.setAsDesktopButton.Name = "setAsDesktopButton";
			this.setAsDesktopButton.Size = new System.Drawing.Size(24, 25);
			this.setAsDesktopButton.Text = "Set as desktop background | Ctrl + B";
			this.setAsDesktopButton.Click += new System.EventHandler(this.setAsDesktopButton_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "image";
			this.saveFileDialog1.Filter = "PNG (*.png)|*.png|JPEG (*.jpg, *.jpeg, *.jpe, *.jfif, *.exif)|*.jpg|GIF (*.gif)|*" +
    ".gif|BMP (*.bmp, *.dib, *.rle)|*.bmp|TIFF (*.tiff, *.tif)|*.tiff";
			// 
			// directoryLabel
			// 
			this.directoryLabel.BackColor = System.Drawing.Color.Transparent;
			this.directoryLabel.Image = ((System.Drawing.Image)(resources.GetObject("directoryLabel.Image")));
			this.directoryLabel.Margin = new System.Windows.Forms.Padding(5);
			this.directoryLabel.Name = "directoryLabel";
			this.directoryLabel.Size = new System.Drawing.Size(96, 16);
			this.directoryLabel.Text = "Folder: Empty";
			// 
			// fileLabel
			// 
			this.fileLabel.BackColor = System.Drawing.Color.Transparent;
			this.fileLabel.Image = ((System.Drawing.Image)(resources.GetObject("fileLabel.Image")));
			this.fileLabel.Margin = new System.Windows.Forms.Padding(5);
			this.fileLabel.Name = "fileLabel";
			this.fileLabel.Size = new System.Drawing.Size(81, 16);
			this.fileLabel.Text = "File: Empty";
			// 
			// sizeLabel
			// 
			this.sizeLabel.BackColor = System.Drawing.Color.Transparent;
			this.sizeLabel.Image = ((System.Drawing.Image)(resources.GetObject("sizeLabel.Image")));
			this.sizeLabel.Margin = new System.Windows.Forms.Padding(5);
			this.sizeLabel.Name = "sizeLabel";
			this.sizeLabel.Size = new System.Drawing.Size(89, 16);
			this.sizeLabel.Text = "Size: 0 x 0 px";
			// 
			// zoomLabel
			// 
			this.zoomLabel.BackColor = System.Drawing.Color.Transparent;
			this.zoomLabel.Image = ((System.Drawing.Image)(resources.GetObject("zoomLabel.Image")));
			this.zoomLabel.Margin = new System.Windows.Forms.Padding(5);
			this.zoomLabel.Name = "zoomLabel";
			this.zoomLabel.Size = new System.Drawing.Size(87, 16);
			this.zoomLabel.Text = "Zoom: Auto";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directoryLabel,
            this.fileLabel,
            this.sizeLabel,
            this.zoomLabel,
            this.dateCreatedLabel,
            this.dateModifiedLabel});
			this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.statusStrip1.Location = new System.Drawing.Point(0, 437);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(714, 26);
			this.statusStrip1.TabIndex = 15;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// dateCreatedLabel
			// 
			this.dateCreatedLabel.BackColor = System.Drawing.Color.Transparent;
			this.dateCreatedLabel.Image = ((System.Drawing.Image)(resources.GetObject("dateCreatedLabel.Image")));
			this.dateCreatedLabel.Margin = new System.Windows.Forms.Padding(5);
			this.dateCreatedLabel.Name = "dateCreatedLabel";
			this.dateCreatedLabel.Size = new System.Drawing.Size(121, 16);
			this.dateCreatedLabel.Text = "Created: Unknown";
			// 
			// dateModifiedLabel
			// 
			this.dateModifiedLabel.BackColor = System.Drawing.Color.Transparent;
			this.dateModifiedLabel.Image = ((System.Drawing.Image)(resources.GetObject("dateModifiedLabel.Image")));
			this.dateModifiedLabel.Margin = new System.Windows.Forms.Padding(5);
			this.dateModifiedLabel.Name = "dateModifiedLabel";
			this.dateModifiedLabel.Size = new System.Drawing.Size(128, 16);
			this.dateModifiedLabel.Text = "Modified: Unknown";
			// 
			// printDialog1
			// 
			this.printDialog1.Document = this.printDocument1;
			this.printDialog1.UseEXDialog = true;
			// 
			// printDocument1
			// 
			this.printDocument1.OriginAtMargins = true;
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// picturePanel
			// 
			this.picturePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picturePanel.AutoScroll = true;
			this.picturePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.picturePanel.BackColor = System.Drawing.Color.Transparent;
			this.picturePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.picturePanel.Controls.Add(this.pictureBox);
			this.picturePanel.Location = new System.Drawing.Point(0, 35);
			this.picturePanel.Margin = new System.Windows.Forms.Padding(0);
			this.picturePanel.Name = "picturePanel";
			this.picturePanel.Size = new System.Drawing.Size(714, 402);
			this.picturePanel.TabIndex = 2;
			this.picturePanel.DoubleClick += new System.EventHandler(this.picturePanel_DoubleClick);
			this.picturePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseDown);
			this.picturePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseMove);
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox.InitialImage = null;
			this.pictureBox.Location = new System.Drawing.Point(0, 0);
			this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(714, 402);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			this.pictureBox.DoubleClick += new System.EventHandler(this.picturePanel_DoubleClick);
			this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseDown);
			this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseMove);
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(714, 463);
			this.Controls.Add(this.picturePanel);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(240, 240);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quick Picture Viewer";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.picturePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton openButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton zoomInButton;
		private System.Windows.Forms.ToolStripButton zoomOutButton;
		private System.Windows.Forms.ToolStripButton autoZoomButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton aboutButton;
		private System.Windows.Forms.ToolStripButton flipVerticalButton;
		private System.Windows.Forms.ToolStripButton flipHorizontalButton;
		private System.Windows.Forms.ToolStripButton rotateLeftButton;
		private System.Windows.Forms.ToolStripButton rotateRightButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton saveAsButton;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStripButton copyButton;
		private System.Windows.Forms.ToolStripButton pasteButton;
		private System.Windows.Forms.ToolStripComboBox zoomComboBox;
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
		private System.Windows.Forms.ToolStripButton setAsDesktopButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripButton deleteButton;
		private System.Windows.Forms.ToolStripStatusLabel dateCreatedLabel;
		private System.Windows.Forms.ToolStripStatusLabel dateModifiedLabel;
		private System.Windows.Forms.ToolStripButton infoButton;
		private System.Windows.Forms.ToolStripButton externalButton;
		private CustomPanel picturePanel;
		private System.Windows.Forms.ToolStripButton printButton;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
	}
}

