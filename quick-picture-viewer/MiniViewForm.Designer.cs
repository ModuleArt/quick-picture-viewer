namespace quick_picture_viewer
{
	partial class MiniViewForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniViewForm));
			this.infoTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.zoomLabel = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new QuickLibrary.QlibContextMenuStrip(this.components);
			this.checkboardBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.qlibMenuSeparator2 = new QuickLibrary.QlibToolsep();
			this.newWindowBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.quitPipBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.autoZoomBtn = new QuickLibrary.QlibTitlebarButton();
			this.closeBtn = new QuickLibrary.QlibTitlebarButton();
			this.resizeBtn = new QuickLibrary.QlibTitlebarButton();
			this.opacityBtn = new QuickLibrary.QlibTitlebarButton();
			this.picturePanel = new quick_picture_viewer.CustomPanel();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.contextMenuStrip1.SuspendLayout();
			this.picturePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// zoomLabel
			// 
			this.zoomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.zoomLabel.BackColor = System.Drawing.Color.Black;
			this.zoomLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.zoomLabel.ForeColor = System.Drawing.Color.White;
			this.zoomLabel.Location = new System.Drawing.Point(32, 0);
			this.zoomLabel.Margin = new System.Windows.Forms.Padding(0);
			this.zoomLabel.Name = "zoomLabel";
			this.zoomLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.zoomLabel.Size = new System.Drawing.Size(304, 32);
			this.zoomLabel.TabIndex = 4;
			this.zoomLabel.Text = "zoom: auto";
			this.zoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.zoomLabel.Visible = false;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkboardBtn,
            this.qlibMenuSeparator2,
            this.newWindowBtn,
            this.quitPipBtn});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(279, 90);
			// 
			// checkboardBtn
			// 
			this.checkboardBtn.Image = global::quick_picture_viewer.Properties.Resources.white_grid;
			this.checkboardBtn.Name = "checkboardBtn";
			this.checkboardBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.checkboardBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
			this.checkboardBtn.Size = new System.Drawing.Size(278, 24);
			this.checkboardBtn.Text = "checkboard background";
			this.checkboardBtn.Click += new System.EventHandler(this.checkerboardBackgroundToolStripMenuItem_Click);
			// 
			// qlibMenuSeparator2
			// 
			this.qlibMenuSeparator2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.qlibMenuSeparator2.DarkMode = false;
			this.qlibMenuSeparator2.InsideMenu = true;
			this.qlibMenuSeparator2.Margin = new System.Windows.Forms.Padding(4);
			this.qlibMenuSeparator2.Name = "qlibMenuSeparator2";
			this.qlibMenuSeparator2.Size = new System.Drawing.Size(275, 6);
			// 
			// newWindowBtn
			// 
			this.newWindowBtn.Image = global::quick_picture_viewer.Properties.Resources.white_newwindow;
			this.newWindowBtn.Name = "newWindowBtn";
			this.newWindowBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.newWindowBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newWindowBtn.Size = new System.Drawing.Size(278, 24);
			this.newWindowBtn.Text = "new window";
			this.newWindowBtn.Click += new System.EventHandler(this.newWindowBtn_Click);
			// 
			// quitPipBtn
			// 
			this.quitPipBtn.Image = global::quick_picture_viewer.Properties.Resources.white_close;
			this.quitPipBtn.Name = "quitPipBtn";
			this.quitPipBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.quitPipBtn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
			this.quitPipBtn.Size = new System.Drawing.Size(278, 24);
			this.quitPipBtn.Text = "quit picture in picture";
			this.quitPipBtn.Click += new System.EventHandler(this.quitPipBtn_Click);
			// 
			// autoZoomBtn
			// 
			this.autoZoomBtn.Cursor = System.Windows.Forms.Cursors.Default;
			this.autoZoomBtn.DarkImage = null;
			this.autoZoomBtn.DarkMode = true;
			this.autoZoomBtn.FlatAppearance.BorderSize = 0;
			this.autoZoomBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
			this.autoZoomBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
			this.autoZoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.autoZoomBtn.ForeColor = System.Drawing.Color.Black;
			this.autoZoomBtn.Image = global::quick_picture_viewer.Properties.Resources.white_autozoom;
			this.autoZoomBtn.IsRed = false;
			this.autoZoomBtn.LightImage = global::quick_picture_viewer.Properties.Resources.white_autozoom;
			this.autoZoomBtn.Location = new System.Drawing.Point(0, 0);
			this.autoZoomBtn.Margin = new System.Windows.Forms.Padding(0);
			this.autoZoomBtn.Name = "autoZoomBtn";
			this.autoZoomBtn.Size = new System.Drawing.Size(32, 32);
			this.autoZoomBtn.TabIndex = 4;
			this.autoZoomBtn.UseVisualStyleBackColor = false;
			this.autoZoomBtn.Visible = false;
			this.autoZoomBtn.Click += new System.EventHandler(this.autoZoomButton_Click);
			// 
			// closeBtn
			// 
			this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeBtn.DarkImage = null;
			this.closeBtn.DarkMode = true;
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
			this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.ForeColor = System.Drawing.Color.Black;
			this.closeBtn.Image = global::quick_picture_viewer.Properties.Resources.white_close;
			this.closeBtn.IsRed = true;
			this.closeBtn.LightImage = global::quick_picture_viewer.Properties.Resources.white_close;
			this.closeBtn.Location = new System.Drawing.Point(368, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 2;
			this.closeBtn.UseVisualStyleBackColor = false;
			this.closeBtn.Visible = false;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// resizeBtn
			// 
			this.resizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.resizeBtn.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.resizeBtn.DarkImage = null;
			this.resizeBtn.DarkMode = true;
			this.resizeBtn.FlatAppearance.BorderSize = 0;
			this.resizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this.resizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
			this.resizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.resizeBtn.ForeColor = System.Drawing.Color.Black;
			this.resizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("resizeBtn.Image")));
			this.resizeBtn.IsRed = false;
			this.resizeBtn.LightImage = ((System.Drawing.Image)(resources.GetObject("resizeBtn.LightImage")));
			this.resizeBtn.Location = new System.Drawing.Point(382, 382);
			this.resizeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.resizeBtn.Name = "resizeBtn";
			this.resizeBtn.Size = new System.Drawing.Size(17, 17);
			this.resizeBtn.TabIndex = 5;
			this.resizeBtn.UseVisualStyleBackColor = false;
			this.resizeBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizeBtn_MouseDown);
			this.resizeBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resizeBtn_MouseMove);
			this.resizeBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseUp);
			// 
			// opacityBtn
			// 
			this.opacityBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.opacityBtn.Cursor = System.Windows.Forms.Cursors.Default;
			this.opacityBtn.DarkImage = null;
			this.opacityBtn.DarkMode = true;
			this.opacityBtn.FlatAppearance.BorderSize = 0;
			this.opacityBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
			this.opacityBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
			this.opacityBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.opacityBtn.ForeColor = System.Drawing.Color.Black;
			this.opacityBtn.Image = global::quick_picture_viewer.Properties.Resources.white_opacity;
			this.opacityBtn.IsRed = false;
			this.opacityBtn.LightImage = global::quick_picture_viewer.Properties.Resources.white_opacity;
			this.opacityBtn.Location = new System.Drawing.Point(336, 0);
			this.opacityBtn.Margin = new System.Windows.Forms.Padding(0);
			this.opacityBtn.Name = "opacityBtn";
			this.opacityBtn.Size = new System.Drawing.Size(32, 32);
			this.opacityBtn.TabIndex = 5;
			this.opacityBtn.UseVisualStyleBackColor = false;
			this.opacityBtn.Visible = false;
			this.opacityBtn.Click += new System.EventHandler(this.opacityBtn_Click);
			// 
			// picturePanel
			// 
			this.picturePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picturePanel.AutoScroll = true;
			this.picturePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.picturePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.picturePanel.ContextMenuStrip = this.contextMenuStrip1;
			this.picturePanel.Controls.Add(this.pictureBox);
			this.picturePanel.Location = new System.Drawing.Point(1, 1);
			this.picturePanel.Margin = new System.Windows.Forms.Padding(1);
			this.picturePanel.Name = "picturePanel";
			this.picturePanel.Size = new System.Drawing.Size(398, 398);
			this.picturePanel.TabIndex = 5;
			this.picturePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseDown);
			this.picturePanel.MouseEnter += new System.EventHandler(this.MiniViewForm_MouseEnter);
			this.picturePanel.MouseLeave += new System.EventHandler(this.MiniViewForm_MouseLeave);
			this.picturePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseMove);
			this.picturePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseUp);
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox.Location = new System.Drawing.Point(0, 0);
			this.pictureBox.Margin = new System.Windows.Forms.Padding(1);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(398, 398);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseDown);
			this.pictureBox.MouseEnter += new System.EventHandler(this.MiniViewForm_MouseEnter);
			this.pictureBox.MouseLeave += new System.EventHandler(this.MiniViewForm_MouseLeave);
			this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseMove);
			this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseUp);
			// 
			// MiniViewForm
			// 
			this.AlternativeAppearance = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.ClientSize = new System.Drawing.Size(400, 400);
			this.Controls.Add(this.opacityBtn);
			this.Controls.Add(this.zoomLabel);
			this.Controls.Add(this.autoZoomBtn);
			this.Controls.Add(this.closeBtn);
			this.Controls.Add(this.resizeBtn);
			this.Controls.Add(this.picturePanel);
			this.DarkMode = true;
			this.ForeColor = System.Drawing.Color.White;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(160, 160);
			this.Name = "MiniViewForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Quick Picture Viewer";
			this.TopMost = true;
			this.Deactivate += new System.EventHandler(this.MiniViewForm_Deactivate);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MiniViewForm_FormClosed);
			this.Load += new System.EventHandler(this.MiniViewForm_Load);
			this.SizeChanged += new System.EventHandler(this.MiniViewForm_ResizeEnd);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MiniViewForm_KeyDown);
			this.contextMenuStrip1.ResumeLayout(false);
			this.picturePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Label zoomLabel;
		private CustomPanel picturePanel;
		private System.Windows.Forms.ToolTip infoTooltip;
		private QuickLibrary.QlibTitlebarButton closeBtn;
		private QuickLibrary.QlibTitlebarButton autoZoomBtn;
		private QuickLibrary.QlibTitlebarButton resizeBtn;
		private QuickLibrary.QlibContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem checkboardBtn;
		private System.Windows.Forms.ToolStripMenuItem newWindowBtn;
		private QuickLibrary.QlibToolsep qlibMenuSeparator2;
		private QuickLibrary.QlibTitlebarButton opacityBtn;
		private System.Windows.Forms.ToolStripMenuItem quitPipBtn;
	}
}