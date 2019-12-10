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
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.zoomInButton = new System.Windows.Forms.ToolStripButton();
			this.zoomOutButton = new System.Windows.Forms.ToolStripButton();
			this.autoZoomButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutButton = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.picturePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
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
			this.openFileDialog1.FileName = "openFileDialog1";
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
			this.pathLabel.Image = ((System.Drawing.Image)(resources.GetObject("pathLabel.Image")));
			this.pathLabel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.pathLabel.Name = "pathLabel";
			this.pathLabel.Size = new System.Drawing.Size(81, 22);
			this.pathLabel.Text = "File: Empty";
			// 
			// sizeLabel
			// 
			this.sizeLabel.Image = ((System.Drawing.Image)(resources.GetObject("sizeLabel.Image")));
			this.sizeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.sizeLabel.Name = "sizeLabel";
			this.sizeLabel.Size = new System.Drawing.Size(89, 22);
			this.sizeLabel.Text = "Size: 0 x 0 px";
			// 
			// zoomLabel
			// 
			this.zoomLabel.Image = ((System.Drawing.Image)(resources.GetObject("zoomLabel.Image")));
			this.zoomLabel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.zoomLabel.Name = "zoomLabel";
			this.zoomLabel.Size = new System.Drawing.Size(87, 22);
			this.zoomLabel.Text = "Zoom: Auto";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton,
            this.toolStripSeparator1,
            this.zoomInButton,
            this.zoomOutButton,
            this.autoZoomButton,
            this.toolStripSeparator2,
            this.aboutButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
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
			this.openButton.Text = "Open file";
			this.openButton.Click += new System.EventHandler(this.openButton_Click_1);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// zoomInButton
			// 
			this.zoomInButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zoomInButton.Enabled = false;
			this.zoomInButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomInButton.Image")));
			this.zoomInButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.zoomInButton.Name = "zoomInButton";
			this.zoomInButton.Size = new System.Drawing.Size(23, 22);
			this.zoomInButton.Text = "Zoom in";
			this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
			// 
			// zoomOutButton
			// 
			this.zoomOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zoomOutButton.Enabled = false;
			this.zoomOutButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutButton.Image")));
			this.zoomOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.zoomOutButton.Name = "zoomOutButton";
			this.zoomOutButton.Size = new System.Drawing.Size(23, 22);
			this.zoomOutButton.Text = "Zoom out";
			this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
			// 
			// autoZoomButton
			// 
			this.autoZoomButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.autoZoomButton.Image = ((System.Drawing.Image)(resources.GetObject("autoZoomButton.Image")));
			this.autoZoomButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.autoZoomButton.Name = "autoZoomButton";
			this.autoZoomButton.Size = new System.Drawing.Size(23, 22);
			this.autoZoomButton.Text = "Toggle auto zoom";
			this.autoZoomButton.Click += new System.EventHandler(this.autoZoomButton_Click);
			// 
			// toolStripSeparator2
			// 
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 441);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.picturePanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(480, 240);
			this.Name = "MainForm";
			this.Text = "Quick Picture Viewer";
			this.Load += new System.EventHandler(this.MainForm_Load);
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
	}
}

