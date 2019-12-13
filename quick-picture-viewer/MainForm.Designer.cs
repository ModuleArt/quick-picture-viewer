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
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.picturePanel = new System.Windows.Forms.Panel();
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.pathLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.sizeLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.zoomLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.openButton = new System.Windows.Forms.ToolStripButton();
			this.saveAsButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.autoZoomButton = new System.Windows.Forms.ToolStripButton();
			this.zoomInButton = new System.Windows.Forms.ToolStripButton();
			this.zoomComboBox = new System.Windows.Forms.ToolStripComboBox();
			this.zoomOutButton = new System.Windows.Forms.ToolStripButton();
			this.fullscreenButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutButton = new System.Windows.Forms.ToolStripButton();
			this.rotateLeftButton = new System.Windows.Forms.ToolStripButton();
			this.rotateRightButton = new System.Windows.Forms.ToolStripButton();
			this.flipHorizontalButton = new System.Windows.Forms.ToolStripButton();
			this.flipVerticalButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.copyButton = new System.Windows.Forms.ToolStripButton();
			this.pasteButton = new System.Windows.Forms.ToolStripButton();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.picturePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox.Enabled = false;
			this.pictureBox.InitialImage = null;
			this.pictureBox.Location = new System.Drawing.Point(0, 0);
			this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(624, 394);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "image";
			this.openFileDialog1.Filter = "Image files (*.png, *.jpg, *.jpeg, *.jpe, *.jfif, *.exif, *.gif, *.bmp, *.dib, *." +
    "rle) | *.png; *.jpg; *.jpeg; *.jpe; *.jfif; *.exif; *.gif; *.bmp, *.dib; *.rle";
			// 
			// picturePanel
			// 
			this.picturePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picturePanel.AutoScroll = true;
			this.picturePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.picturePanel.BackColor = System.Drawing.Color.Transparent;
			this.picturePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.picturePanel.Controls.Add(this.pictureBox);
			this.picturePanel.Location = new System.Drawing.Point(0, 25);
			this.picturePanel.Margin = new System.Windows.Forms.Padding(0);
			this.picturePanel.Name = "picturePanel";
			this.picturePanel.Size = new System.Drawing.Size(624, 394);
			this.picturePanel.TabIndex = 2;
			this.picturePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseDown);
			this.picturePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseMove);
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pathLabel,
            this.sizeLabel,
            this.zoomLabel});
			this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.statusStrip1.Location = new System.Drawing.Point(0, 419);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(624, 22);
			this.statusStrip1.TabIndex = 15;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// pathLabel
			// 
			this.pathLabel.BackColor = System.Drawing.Color.Transparent;
			this.pathLabel.Image = ((System.Drawing.Image)(resources.GetObject("pathLabel.Image")));
			this.pathLabel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.pathLabel.Name = "pathLabel";
			this.pathLabel.Size = new System.Drawing.Size(81, 22);
			this.pathLabel.Text = "File: Empty";
			// 
			// sizeLabel
			// 
			this.sizeLabel.BackColor = System.Drawing.Color.Transparent;
			this.sizeLabel.Image = ((System.Drawing.Image)(resources.GetObject("sizeLabel.Image")));
			this.sizeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.sizeLabel.Name = "sizeLabel";
			this.sizeLabel.Size = new System.Drawing.Size(89, 22);
			this.sizeLabel.Text = "Size: 0 x 0 px";
			// 
			// zoomLabel
			// 
			this.zoomLabel.BackColor = System.Drawing.Color.Transparent;
			this.zoomLabel.Image = ((System.Drawing.Image)(resources.GetObject("zoomLabel.Image")));
			this.zoomLabel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.zoomLabel.Name = "zoomLabel";
			this.zoomLabel.Size = new System.Drawing.Size(87, 22);
			this.zoomLabel.Text = "Zoom: Auto";
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.White;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton,
            this.saveAsButton,
            this.toolStripSeparator1,
            this.autoZoomButton,
            this.zoomInButton,
            this.zoomComboBox,
            this.zoomOutButton,
            this.fullscreenButton,
            this.toolStripSeparator2,
            this.aboutButton,
            this.rotateLeftButton,
            this.rotateRightButton,
            this.flipHorizontalButton,
            this.flipVerticalButton,
            this.toolStripSeparator3,
            this.copyButton,
            this.pasteButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(624, 25);
			this.toolStrip1.TabIndex = 16;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// openButton
			// 
			this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
			this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openButton.Name = "openButton";
			this.openButton.Size = new System.Drawing.Size(23, 22);
			this.openButton.Text = "Open file | Ctrl+O";
			this.openButton.Click += new System.EventHandler(this.openButton_Click_1);
			// 
			// saveAsButton
			// 
			this.saveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveAsButton.Enabled = false;
			this.saveAsButton.Image = ((System.Drawing.Image)(resources.GetObject("saveAsButton.Image")));
			this.saveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveAsButton.Name = "saveAsButton";
			this.saveAsButton.Size = new System.Drawing.Size(23, 22);
			this.saveAsButton.Text = "Save as | Ctrl + S";
			this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// autoZoomButton
			// 
			this.autoZoomButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.autoZoomButton.Image = ((System.Drawing.Image)(resources.GetObject("autoZoomButton.Image")));
			this.autoZoomButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.autoZoomButton.Name = "autoZoomButton";
			this.autoZoomButton.Size = new System.Drawing.Size(23, 22);
			this.autoZoomButton.Text = "Toggle auto zoom | Ctrl + A";
			this.autoZoomButton.Click += new System.EventHandler(this.autoZoomButton_Click);
			// 
			// zoomInButton
			// 
			this.zoomInButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zoomInButton.Enabled = false;
			this.zoomInButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomInButton.Image")));
			this.zoomInButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.zoomInButton.Name = "zoomInButton";
			this.zoomInButton.Size = new System.Drawing.Size(23, 22);
			this.zoomInButton.Text = "Zoom in | Ctrl + =";
			this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
			// 
			// zoomComboBox
			// 
			this.zoomComboBox.DropDownWidth = 75;
			this.zoomComboBox.Enabled = false;
			this.zoomComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.zoomComboBox.Items.AddRange(new object[] {
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
			this.zoomComboBox.Name = "zoomComboBox";
			this.zoomComboBox.Size = new System.Drawing.Size(75, 25);
			this.zoomComboBox.Text = "Auto";
			this.zoomComboBox.ToolTipText = "Zoom";
			this.zoomComboBox.TextChanged += new System.EventHandler(this.zoomComboBox_TextChanged);
			// 
			// zoomOutButton
			// 
			this.zoomOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zoomOutButton.Enabled = false;
			this.zoomOutButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutButton.Image")));
			this.zoomOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.zoomOutButton.Name = "zoomOutButton";
			this.zoomOutButton.Size = new System.Drawing.Size(23, 22);
			this.zoomOutButton.Text = "Zoom out | Ctrl + Minus";
			this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
			// 
			// fullscreenButton
			// 
			this.fullscreenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.fullscreenButton.Image = ((System.Drawing.Image)(resources.GetObject("fullscreenButton.Image")));
			this.fullscreenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.fullscreenButton.Name = "fullscreenButton";
			this.fullscreenButton.Size = new System.Drawing.Size(23, 22);
			this.fullscreenButton.Text = "Toggle fullscreen | F11";
			this.fullscreenButton.Click += new System.EventHandler(this.fullscreenButton_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// aboutButton
			// 
			this.aboutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.aboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
			this.aboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.aboutButton.Name = "aboutButton";
			this.aboutButton.Size = new System.Drawing.Size(23, 22);
			this.aboutButton.Text = "About";
			this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
			// 
			// rotateLeftButton
			// 
			this.rotateLeftButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.rotateLeftButton.Enabled = false;
			this.rotateLeftButton.Image = ((System.Drawing.Image)(resources.GetObject("rotateLeftButton.Image")));
			this.rotateLeftButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.rotateLeftButton.Name = "rotateLeftButton";
			this.rotateLeftButton.Size = new System.Drawing.Size(23, 22);
			this.rotateLeftButton.Text = "Rotate counter-clockwise | Ctrl + Shift + R";
			this.rotateLeftButton.Click += new System.EventHandler(this.rotateLeftButton_Click);
			// 
			// rotateRightButton
			// 
			this.rotateRightButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.rotateRightButton.Enabled = false;
			this.rotateRightButton.Image = ((System.Drawing.Image)(resources.GetObject("rotateRightButton.Image")));
			this.rotateRightButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.rotateRightButton.Name = "rotateRightButton";
			this.rotateRightButton.Size = new System.Drawing.Size(23, 22);
			this.rotateRightButton.Text = "Rotate clockwise | Ctrl + R";
			this.rotateRightButton.Click += new System.EventHandler(this.rotateRightButton_Click);
			// 
			// flipHorizontalButton
			// 
			this.flipHorizontalButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.flipHorizontalButton.Enabled = false;
			this.flipHorizontalButton.Image = ((System.Drawing.Image)(resources.GetObject("flipHorizontalButton.Image")));
			this.flipHorizontalButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.flipHorizontalButton.Name = "flipHorizontalButton";
			this.flipHorizontalButton.Size = new System.Drawing.Size(23, 22);
			this.flipHorizontalButton.Text = "Flip horizontal | Ctrl + H";
			this.flipHorizontalButton.Click += new System.EventHandler(this.flipHorizontalButton_Click);
			// 
			// flipVerticalButton
			// 
			this.flipVerticalButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.flipVerticalButton.Enabled = false;
			this.flipVerticalButton.Image = ((System.Drawing.Image)(resources.GetObject("flipVerticalButton.Image")));
			this.flipVerticalButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.flipVerticalButton.Name = "flipVerticalButton";
			this.flipVerticalButton.Size = new System.Drawing.Size(23, 22);
			this.flipVerticalButton.Text = "Flip vertical | Ctrl + Shift + H";
			this.flipVerticalButton.Click += new System.EventHandler(this.flipVerticalButton_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// copyButton
			// 
			this.copyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.copyButton.Enabled = false;
			this.copyButton.Image = ((System.Drawing.Image)(resources.GetObject("copyButton.Image")));
			this.copyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copyButton.Name = "copyButton";
			this.copyButton.Size = new System.Drawing.Size(23, 22);
			this.copyButton.Text = "Copy image | Ctrl + C";
			this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
			// 
			// pasteButton
			// 
			this.pasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pasteButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteButton.Image")));
			this.pasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pasteButton.Name = "pasteButton";
			this.pasteButton.Size = new System.Drawing.Size(23, 22);
			this.pasteButton.Text = "Paste | Ctrl + V";
			this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "image";
			this.saveFileDialog1.Filter = "PNG (*.png)|*.png|JPEG (*.jpg, *.jpeg, *.jpe, *.jfif, *.exif)|*.jpg|GIF (*.gif)|*" +
    ".gif|BMP (*.bmp, *.dib, *.rle)|*.bmp";
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(624, 441);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.picturePanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(240, 240);
			this.Name = "MainForm";
			this.Text = "Quick Picture Viewer";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.picturePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Panel picturePanel;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel pathLabel;
		private System.Windows.Forms.ToolStripStatusLabel sizeLabel;
		private System.Windows.Forms.ToolStripStatusLabel zoomLabel;
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
	}
}

