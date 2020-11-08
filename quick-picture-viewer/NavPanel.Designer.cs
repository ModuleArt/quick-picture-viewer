namespace quick_picture_viewer
{
	partial class NavPanel
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavPanel));
			this.navPanelDrag = new System.Windows.Forms.PictureBox();
			this.navSlideshowBtn = new System.Windows.Forms.Button();
			this.navNextBtn = new System.Windows.Forms.Button();
			this.navPrevBtn = new System.Windows.Forms.Button();
			this.infoTooltip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.navPanelDrag)).BeginInit();
			this.SuspendLayout();
			// 
			// navPanelDrag
			// 
			this.navPanelDrag.Cursor = System.Windows.Forms.Cursors.Default;
			this.navPanelDrag.Enabled = false;
			this.navPanelDrag.Image = ((System.Drawing.Image)(resources.GetObject("navPanelDrag.Image")));
			this.navPanelDrag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.navPanelDrag.Location = new System.Drawing.Point(0, 0);
			this.navPanelDrag.Margin = new System.Windows.Forms.Padding(0);
			this.navPanelDrag.Name = "navPanelDrag";
			this.navPanelDrag.Size = new System.Drawing.Size(20, 32);
			this.navPanelDrag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.navPanelDrag.TabIndex = 9;
			this.navPanelDrag.TabStop = false;
			// 
			// navSlideshowBtn
			// 
			this.navSlideshowBtn.BackColor = System.Drawing.Color.Black;
			this.navSlideshowBtn.Cursor = System.Windows.Forms.Cursors.Default;
			this.navSlideshowBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.navSlideshowBtn.FlatAppearance.BorderSize = 0;
			this.navSlideshowBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.navSlideshowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.navSlideshowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.navSlideshowBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.navSlideshowBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.navSlideshowBtn.Image = global::quick_picture_viewer.Properties.Resources.white_slideshow;
			this.navSlideshowBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.navSlideshowBtn.Location = new System.Drawing.Point(52, 0);
			this.navSlideshowBtn.Margin = new System.Windows.Forms.Padding(0);
			this.navSlideshowBtn.Name = "navSlideshowBtn";
			this.navSlideshowBtn.Size = new System.Drawing.Size(32, 32);
			this.navSlideshowBtn.TabIndex = 8;
			this.navSlideshowBtn.TabStop = false;
			this.navSlideshowBtn.UseVisualStyleBackColor = false;
			this.navSlideshowBtn.Click += new System.EventHandler(this.navSlideshowBtn_Click);
			// 
			// navNextBtn
			// 
			this.navNextBtn.BackColor = System.Drawing.Color.Black;
			this.navNextBtn.Cursor = System.Windows.Forms.Cursors.Default;
			this.navNextBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.navNextBtn.FlatAppearance.BorderSize = 0;
			this.navNextBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.navNextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.navNextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.navNextBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.navNextBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.navNextBtn.Image = global::quick_picture_viewer.Properties.Resources.white_next;
			this.navNextBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.navNextBtn.Location = new System.Drawing.Point(84, 0);
			this.navNextBtn.Margin = new System.Windows.Forms.Padding(0);
			this.navNextBtn.Name = "navNextBtn";
			this.navNextBtn.Size = new System.Drawing.Size(32, 32);
			this.navNextBtn.TabIndex = 7;
			this.navNextBtn.TabStop = false;
			this.navNextBtn.UseVisualStyleBackColor = false;
			this.navNextBtn.Click += new System.EventHandler(this.navNextBtn_Click);
			// 
			// navPrevBtn
			// 
			this.navPrevBtn.BackColor = System.Drawing.Color.Black;
			this.navPrevBtn.Cursor = System.Windows.Forms.Cursors.Default;
			this.navPrevBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.navPrevBtn.FlatAppearance.BorderSize = 0;
			this.navPrevBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.navPrevBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.navPrevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.navPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.navPrevBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.navPrevBtn.Image = global::quick_picture_viewer.Properties.Resources.white_prev;
			this.navPrevBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.navPrevBtn.Location = new System.Drawing.Point(20, 0);
			this.navPrevBtn.Margin = new System.Windows.Forms.Padding(0);
			this.navPrevBtn.Name = "navPrevBtn";
			this.navPrevBtn.Size = new System.Drawing.Size(32, 32);
			this.navPrevBtn.TabIndex = 6;
			this.navPrevBtn.TabStop = false;
			this.navPrevBtn.UseVisualStyleBackColor = false;
			this.navPrevBtn.Click += new System.EventHandler(this.navPrevBtn_Click);
			// 
			// NavPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.Black;
			this.Controls.Add(this.navPanelDrag);
			this.Controls.Add(this.navSlideshowBtn);
			this.Controls.Add(this.navNextBtn);
			this.Controls.Add(this.navPrevBtn);
			this.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "NavPanel";
			this.Size = new System.Drawing.Size(116, 32);
			this.Load += new System.EventHandler(this.NavPanel_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavPanel_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NavPanel_MouseMove);
			((System.ComponentModel.ISupportInitialize)(this.navPanelDrag)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox navPanelDrag;
		private System.Windows.Forms.Button navSlideshowBtn;
		private System.Windows.Forms.Button navNextBtn;
		private System.Windows.Forms.Button navPrevBtn;
		private System.Windows.Forms.ToolTip infoTooltip;
	}
}
