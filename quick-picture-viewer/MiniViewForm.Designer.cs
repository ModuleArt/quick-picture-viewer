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
			this.picturePanel = new quick_picture_viewer.CustomPanel();
			this.resizeBtn = new QuickLibrary.QlibTitlebarButton();
			this.zoomLabel = new System.Windows.Forms.Label();
			this.autoZoomBtn = new QuickLibrary.QlibTitlebarButton();
			this.closeBtn = new QuickLibrary.QlibTitlebarButton();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.picturePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// picturePanel
			// 
			this.picturePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picturePanel.AutoScroll = true;
			this.picturePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.picturePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.picturePanel.Controls.Add(this.resizeBtn);
			this.picturePanel.Controls.Add(this.zoomLabel);
			this.picturePanel.Controls.Add(this.autoZoomBtn);
			this.picturePanel.Controls.Add(this.closeBtn);
			this.picturePanel.Controls.Add(this.pictureBox);
			this.picturePanel.Location = new System.Drawing.Point(0, 0);
			this.picturePanel.Margin = new System.Windows.Forms.Padding(0);
			this.picturePanel.Name = "picturePanel";
			this.picturePanel.Size = new System.Drawing.Size(400, 400);
			this.picturePanel.TabIndex = 5;
			this.picturePanel.DoubleClick += new System.EventHandler(this.picturePanel_DoubleClick);
			this.picturePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseDown);
			this.picturePanel.MouseEnter += new System.EventHandler(this.MiniViewForm_MouseEnter);
			this.picturePanel.MouseLeave += new System.EventHandler(this.MiniViewForm_MouseLeave);
			this.picturePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseMove);
			this.picturePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseUp);
			// 
			// resizeBtn
			// 
			this.resizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.resizeBtn.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.resizeBtn.DarkImage = null;
			this.resizeBtn.FlatAppearance.BorderSize = 0;
			this.resizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.resizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("resizeBtn.Image")));
			this.resizeBtn.IsRed = false;
			this.resizeBtn.LightImage = ((System.Drawing.Image)(resources.GetObject("resizeBtn.LightImage")));
			this.resizeBtn.Location = new System.Drawing.Point(368, 368);
			this.resizeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.resizeBtn.Name = "resizeBtn";
			this.resizeBtn.Size = new System.Drawing.Size(32, 32);
			this.resizeBtn.TabIndex = 5;
			this.infoTooltip.SetToolTip(this.resizeBtn, "Drag here to resize window");
			this.resizeBtn.UseVisualStyleBackColor = false;
			this.resizeBtn.Visible = false;
			this.resizeBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizeBtn_MouseDown);
			this.resizeBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseUp);
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
			this.zoomLabel.Size = new System.Drawing.Size(336, 32);
			this.zoomLabel.TabIndex = 4;
			this.zoomLabel.Text = "Zoom: Auto";
			this.zoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.zoomLabel.Visible = false;
			// 
			// autoZoomBtn
			// 
			this.autoZoomBtn.Cursor = System.Windows.Forms.Cursors.Default;
			this.autoZoomBtn.DarkImage = null;
			this.autoZoomBtn.FlatAppearance.BorderSize = 0;
			this.autoZoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.autoZoomBtn.Image = global::quick_picture_viewer.Properties.Resources.white_autozoom;
			this.autoZoomBtn.IsRed = false;
			this.autoZoomBtn.LightImage = global::quick_picture_viewer.Properties.Resources.white_autozoom;
			this.autoZoomBtn.Location = new System.Drawing.Point(0, 0);
			this.autoZoomBtn.Margin = new System.Windows.Forms.Padding(0);
			this.autoZoomBtn.Name = "autoZoomBtn";
			this.autoZoomBtn.Size = new System.Drawing.Size(32, 32);
			this.autoZoomBtn.TabIndex = 4;
			this.infoTooltip.SetToolTip(this.autoZoomBtn, "Auto zoom (Ctrl+A)");
			this.autoZoomBtn.UseVisualStyleBackColor = false;
			this.autoZoomBtn.Visible = false;
			this.autoZoomBtn.Click += new System.EventHandler(this.autoZoomButton_Click);
			// 
			// closeBtn
			// 
			this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeBtn.DarkImage = null;
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.Image = global::quick_picture_viewer.Properties.Resources.white_close;
			this.closeBtn.IsRed = true;
			this.closeBtn.LightImage = global::quick_picture_viewer.Properties.Resources.white_close;
			this.closeBtn.Location = new System.Drawing.Point(368, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 2;
			this.infoTooltip.SetToolTip(this.closeBtn, "Close");
			this.closeBtn.UseVisualStyleBackColor = false;
			this.closeBtn.Visible = false;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox.Location = new System.Drawing.Point(0, 0);
			this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(400, 400);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			this.pictureBox.DoubleClick += new System.EventHandler(this.picturePanel_DoubleClick);
			this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseDown);
			this.pictureBox.MouseEnter += new System.EventHandler(this.MiniViewForm_MouseEnter);
			this.pictureBox.MouseLeave += new System.EventHandler(this.MiniViewForm_MouseLeave);
			this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseMove);
			this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseUp);
			// 
			// MiniViewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(400, 400);
			this.Controls.Add(this.picturePanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(207, 207);
			this.Name = "MiniViewForm";
			this.Padding = new System.Windows.Forms.Padding(27);
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Quick Picture Viewer";
			this.TopMost = true;
			this.Deactivate += new System.EventHandler(this.MiniViewForm_Deactivate);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MiniViewForm_FormClosed);
			this.Load += new System.EventHandler(this.MiniViewForm_Load);
			this.ResizeEnd += new System.EventHandler(this.MiniViewForm_ResizeEnd);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MiniViewForm_KeyDown);
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
	}
}