namespace quick_picture_viewer
{
	partial class NavForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavForm));
			this.navPanelDrag = new System.Windows.Forms.PictureBox();
			this.navSlideshowBtn = new System.Windows.Forms.Button();
			this.navNextBtn = new System.Windows.Forms.Button();
			this.navPrevBtn = new System.Windows.Forms.Button();
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
			this.navPanelDrag.Size = new System.Drawing.Size(17, 32);
			this.navPanelDrag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.navPanelDrag.TabIndex = 13;
			this.navPanelDrag.TabStop = false;
			// 
			// navSlideshowBtn
			// 
			this.navSlideshowBtn.BackColor = System.Drawing.Color.Black;
			this.navSlideshowBtn.Cursor = System.Windows.Forms.Cursors.Default;
			this.navSlideshowBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
			this.navSlideshowBtn.FlatAppearance.BorderSize = 0;
			this.navSlideshowBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.navSlideshowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.navSlideshowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.navSlideshowBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.navSlideshowBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.navSlideshowBtn.Image = global::quick_picture_viewer.Properties.Resources.white_slideshow;
			this.navSlideshowBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.navSlideshowBtn.Location = new System.Drawing.Point(49, 0);
			this.navSlideshowBtn.Margin = new System.Windows.Forms.Padding(0);
			this.navSlideshowBtn.Name = "navSlideshowBtn";
			this.navSlideshowBtn.Size = new System.Drawing.Size(32, 32);
			this.navSlideshowBtn.TabIndex = 1;
			this.navSlideshowBtn.TabStop = false;
			this.navSlideshowBtn.UseVisualStyleBackColor = false;
			this.navSlideshowBtn.Click += new System.EventHandler(this.navSlideshowBtn_Click);
			// 
			// navNextBtn
			// 
			this.navNextBtn.BackColor = System.Drawing.Color.Black;
			this.navNextBtn.Cursor = System.Windows.Forms.Cursors.Default;
			this.navNextBtn.FlatAppearance.BorderSize = 0;
			this.navNextBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.navNextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.navNextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.navNextBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.navNextBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.navNextBtn.Image = global::quick_picture_viewer.Properties.Resources.white_next;
			this.navNextBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.navNextBtn.Location = new System.Drawing.Point(81, 0);
			this.navNextBtn.Margin = new System.Windows.Forms.Padding(0);
			this.navNextBtn.Name = "navNextBtn";
			this.navNextBtn.Size = new System.Drawing.Size(32, 32);
			this.navNextBtn.TabIndex = 2;
			this.navNextBtn.TabStop = false;
			this.navNextBtn.UseVisualStyleBackColor = false;
			this.navNextBtn.Click += new System.EventHandler(this.navNextBtn_Click);
			// 
			// navPrevBtn
			// 
			this.navPrevBtn.BackColor = System.Drawing.Color.Black;
			this.navPrevBtn.Cursor = System.Windows.Forms.Cursors.Default;
			this.navPrevBtn.FlatAppearance.BorderSize = 0;
			this.navPrevBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.navPrevBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.navPrevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.navPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.navPrevBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.navPrevBtn.Image = global::quick_picture_viewer.Properties.Resources.white_prev;
			this.navPrevBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.navPrevBtn.Location = new System.Drawing.Point(17, 0);
			this.navPrevBtn.Margin = new System.Windows.Forms.Padding(0);
			this.navPrevBtn.Name = "navPrevBtn";
			this.navPrevBtn.Size = new System.Drawing.Size(32, 32);
			this.navPrevBtn.TabIndex = 0;
			this.navPrevBtn.TabStop = false;
			this.navPrevBtn.UseVisualStyleBackColor = false;
			this.navPrevBtn.Click += new System.EventHandler(this.navPrevBtn_Click);
			// 
			// NavForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.Black;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(120, 32);
			this.ControlBox = false;
			this.Controls.Add(this.navPanelDrag);
			this.Controls.Add(this.navSlideshowBtn);
			this.Controls.Add(this.navNextBtn);
			this.Controls.Add(this.navPrevBtn);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NavForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "NavForm";
			((System.ComponentModel.ISupportInitialize)(this.navPanelDrag)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox navPanelDrag;
		private System.Windows.Forms.Button navSlideshowBtn;
		private System.Windows.Forms.Button navNextBtn;
		private System.Windows.Forms.Button navPrevBtn;
	}
}