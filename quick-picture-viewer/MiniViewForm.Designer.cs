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
			this.gripButton = new System.Windows.Forms.Button();
			this.zoomLabel = new System.Windows.Forms.Label();
			this.autoZoomButton = new System.Windows.Forms.Button();
			this.moveButton = new System.Windows.Forms.Button();
			this.infoTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.closeBtn = new System.Windows.Forms.Button();
			this.picturePanel = new quick_picture_viewer.CustomPanel();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.picturePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// gripButton
			// 
			this.gripButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.gripButton.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.gripButton.FlatAppearance.BorderSize = 0;
			this.gripButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gripButton.Image = ((System.Drawing.Image)(resources.GetObject("gripButton.Image")));
			this.gripButton.Location = new System.Drawing.Point(350, 350);
			this.gripButton.Margin = new System.Windows.Forms.Padding(0);
			this.gripButton.Name = "gripButton";
			this.gripButton.Size = new System.Drawing.Size(23, 23);
			this.gripButton.TabIndex = 3;
			this.gripButton.TabStop = false;
			this.infoTooltip.SetToolTip(this.gripButton, "Drag here to resize window");
			this.gripButton.UseVisualStyleBackColor = true;
			this.gripButton.Visible = false;
			this.gripButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gripButton_MouseDown);
			this.gripButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gripButton_MouseUp);
			// 
			// zoomLabel
			// 
			this.zoomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.zoomLabel.AutoSize = true;
			this.zoomLabel.BackColor = System.Drawing.Color.Black;
			this.zoomLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.zoomLabel.ForeColor = System.Drawing.Color.White;
			this.zoomLabel.Location = new System.Drawing.Point(60, 350);
			this.zoomLabel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.zoomLabel.Name = "zoomLabel";
			this.zoomLabel.Padding = new System.Windows.Forms.Padding(3);
			this.zoomLabel.Size = new System.Drawing.Size(82, 23);
			this.zoomLabel.TabIndex = 4;
			this.zoomLabel.Text = "Zoom: Auto";
			this.zoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.zoomLabel.Visible = false;
			// 
			// autoZoomButton
			// 
			this.autoZoomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.autoZoomButton.Cursor = System.Windows.Forms.Cursors.Default;
			this.autoZoomButton.FlatAppearance.BorderSize = 0;
			this.autoZoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.autoZoomButton.Image = global::quick_picture_viewer.Properties.Resources.white_autozoom;
			this.autoZoomButton.Location = new System.Drawing.Point(27, 350);
			this.autoZoomButton.Margin = new System.Windows.Forms.Padding(0);
			this.autoZoomButton.Name = "autoZoomButton";
			this.autoZoomButton.Size = new System.Drawing.Size(23, 23);
			this.autoZoomButton.TabIndex = 6;
			this.autoZoomButton.TabStop = false;
			this.infoTooltip.SetToolTip(this.autoZoomButton, "Auto zoom | Ctrl+A");
			this.autoZoomButton.UseVisualStyleBackColor = true;
			this.autoZoomButton.Visible = false;
			this.autoZoomButton.Click += new System.EventHandler(this.autoZoomButton_Click);
			// 
			// moveButton
			// 
			this.moveButton.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.moveButton.FlatAppearance.BorderSize = 0;
			this.moveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.moveButton.Image = global::quick_picture_viewer.Properties.Resources.white_move;
			this.moveButton.Location = new System.Drawing.Point(27, 27);
			this.moveButton.Margin = new System.Windows.Forms.Padding(0);
			this.moveButton.Name = "moveButton";
			this.moveButton.Size = new System.Drawing.Size(23, 23);
			this.moveButton.TabIndex = 7;
			this.moveButton.TabStop = false;
			this.infoTooltip.SetToolTip(this.moveButton, "Drag here to move window");
			this.moveButton.UseVisualStyleBackColor = true;
			this.moveButton.Visible = false;
			// 
			// closeBtn
			// 
			this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeBtn.Cursor = System.Windows.Forms.Cursors.Default;
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.Image = global::quick_picture_viewer.Properties.Resources.white_close;
			this.closeBtn.Location = new System.Drawing.Point(350, 27);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(23, 23);
			this.closeBtn.TabIndex = 8;
			this.closeBtn.TabStop = false;
			this.infoTooltip.SetToolTip(this.closeBtn, "Exit picture in picture | Esc");
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Visible = false;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// picturePanel
			// 
			this.picturePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picturePanel.AutoScroll = true;
			this.picturePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
			// pictureBox
			// 
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
			this.Controls.Add(this.closeBtn);
			this.Controls.Add(this.moveButton);
			this.Controls.Add(this.zoomLabel);
			this.Controls.Add(this.gripButton);
			this.Controls.Add(this.autoZoomButton);
			this.Controls.Add(this.picturePanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(200, 200);
			this.Name = "MiniViewForm";
			this.Padding = new System.Windows.Forms.Padding(27);
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Quick Picture Viewer";
			this.TopMost = true;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MiniViewForm_FormClosed);
			this.Load += new System.EventHandler(this.MiniViewForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MiniViewForm_KeyDown);
			this.Resize += new System.EventHandler(this.MiniViewForm_Resize);
			this.picturePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Button gripButton;
		private System.Windows.Forms.Label zoomLabel;
		private CustomPanel picturePanel;
		private System.Windows.Forms.Button autoZoomButton;
		private System.Windows.Forms.ToolTip infoTooltip;
		private System.Windows.Forms.Button moveButton;
		private System.Windows.Forms.Button closeBtn;
	}
}