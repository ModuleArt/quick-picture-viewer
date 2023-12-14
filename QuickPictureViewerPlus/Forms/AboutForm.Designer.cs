namespace QuickPictureViewerPlus
{
	partial class AboutForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.productLabel = new System.Windows.Forms.Label();
			this.versionLabel = new System.Windows.Forms.Label();
			this.infoTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.closeBtn = new QuickLibrary.QlibTitlebarButton();
			this.developerBtn = new System.Windows.Forms.Button();
			this.githubBtn = new System.Windows.Forms.Button();
			this.descTextBox = new System.Windows.Forms.TextBox();
			this.makeDefaultBtn = new System.Windows.Forms.Button();
			this.copyrightLabel = new System.Windows.Forms.Label();
			this.updatesBtn = new System.Windows.Forms.Button();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// productLabel
			// 
			this.productLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.productLabel.Location = new System.Drawing.Point(10, 170);
			this.productLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.productLabel.Name = "productLabel";
			this.productLabel.Size = new System.Drawing.Size(280, 19);
			this.productLabel.TabIndex = 27;
			this.productLabel.Text = "Quick Picture Viewer";
			this.productLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// versionLabel
			// 
			this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.versionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(124)))), ((int)(((byte)(76)))));
			this.versionLabel.Location = new System.Drawing.Point(10, 199);
			this.versionLabel.Margin = new System.Windows.Forms.Padding(0);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.versionLabel.Size = new System.Drawing.Size(280, 19);
			this.versionLabel.TabIndex = 28;
			this.versionLabel.Text = "version";
			this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// closeBtn
			// 
			this.closeBtn.DarkImage = global::QuickPictureViewerPlus.Properties.Resources.black_close;
			this.closeBtn.DarkMode = false;
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
			this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.ForeColor = System.Drawing.Color.Black;
			this.closeBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_close;
			this.closeBtn.IsRed = true;
			this.closeBtn.LightImage = global::QuickPictureViewerPlus.Properties.Resources.white_close;
			this.closeBtn.Location = new System.Drawing.Point(268, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 4;
			this.infoTooltip.SetToolTip(this.closeBtn, "Close (Alt+F4)");
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// developerBtn
			// 
			this.developerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(184)))), ((int)(((byte)(113)))));
			this.developerBtn.FlatAppearance.BorderSize = 0;
			this.developerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(144)))), ((int)(((byte)(88)))));
			this.developerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(164)))), ((int)(((byte)(101)))));
			this.developerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.developerBtn.Image = ((System.Drawing.Image)(resources.GetObject("developerBtn.Image")));
			this.developerBtn.Location = new System.Drawing.Point(155, 376);
			this.developerBtn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.developerBtn.Name = "developerBtn";
			this.developerBtn.Size = new System.Drawing.Size(135, 32);
			this.developerBtn.TabIndex = 2;
			this.developerBtn.Text = " Module Art";
			this.developerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.developerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.infoTooltip.SetToolTip(this.developerBtn, "moduleart.github.io");
			this.developerBtn.UseVisualStyleBackColor = false;
			this.developerBtn.Click += new System.EventHandler(this.developerBtn_Click);
			// 
			// githubBtn
			// 
			this.githubBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(184)))), ((int)(((byte)(113)))));
			this.githubBtn.FlatAppearance.BorderSize = 0;
			this.githubBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(144)))), ((int)(((byte)(88)))));
			this.githubBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(164)))), ((int)(((byte)(101)))));
			this.githubBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.githubBtn.Image = ((System.Drawing.Image)(resources.GetObject("githubBtn.Image")));
			this.githubBtn.Location = new System.Drawing.Point(10, 376);
			this.githubBtn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.githubBtn.Name = "githubBtn";
			this.githubBtn.Size = new System.Drawing.Size(135, 32);
			this.githubBtn.TabIndex = 1;
			this.githubBtn.Text = " GitHub";
			this.githubBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.githubBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.infoTooltip.SetToolTip(this.githubBtn, "github.com/adriengivry/QuickPictureViewerPlus");
			this.githubBtn.UseVisualStyleBackColor = false;
			this.githubBtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// descTextBox
			// 
			this.descTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(205)))), ((int)(((byte)(126)))));
			this.descTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.descTextBox.Location = new System.Drawing.Point(20, 228);
			this.descTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.descTextBox.Multiline = true;
			this.descTextBox.Name = "descTextBox";
			this.descTextBox.ReadOnly = true;
			this.descTextBox.Size = new System.Drawing.Size(260, 96);
			this.descTextBox.TabIndex = 5;
			this.descTextBox.Text = "description";
			this.descTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// makeDefaultBtn
			// 
			this.makeDefaultBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(184)))), ((int)(((byte)(113)))));
			this.makeDefaultBtn.Enabled = false;
			this.makeDefaultBtn.FlatAppearance.BorderSize = 0;
			this.makeDefaultBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(144)))), ((int)(((byte)(88)))));
			this.makeDefaultBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(164)))), ((int)(((byte)(101)))));
			this.makeDefaultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.makeDefaultBtn.Location = new System.Drawing.Point(10, 418);
			this.makeDefaultBtn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.makeDefaultBtn.Name = "makeDefaultBtn";
			this.makeDefaultBtn.Size = new System.Drawing.Size(280, 32);
			this.makeDefaultBtn.TabIndex = 3;
			this.makeDefaultBtn.Text = "set as default photo viewer";
			this.makeDefaultBtn.UseVisualStyleBackColor = false;
			this.makeDefaultBtn.Click += new System.EventHandler(this.makeDefaultBtn_Click);
			// 
			// copyrightLabel
			// 
			this.copyrightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.copyrightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(124)))), ((int)(((byte)(76)))));
			this.copyrightLabel.Location = new System.Drawing.Point(10, 470);
			this.copyrightLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.copyrightLabel.Name = "copyrightLabel";
			this.copyrightLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.copyrightLabel.Size = new System.Drawing.Size(280, 19);
			this.copyrightLabel.TabIndex = 44;
			this.copyrightLabel.Text = "Copyright © 2021 Module Art";
			this.copyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// updatesBtn
			// 
			this.updatesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(184)))), ((int)(((byte)(113)))));
			this.updatesBtn.FlatAppearance.BorderSize = 0;
			this.updatesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(144)))), ((int)(((byte)(88)))));
			this.updatesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(164)))), ((int)(((byte)(101)))));
			this.updatesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updatesBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_sync;
			this.updatesBtn.Location = new System.Drawing.Point(10, 334);
			this.updatesBtn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.updatesBtn.Name = "updatesBtn";
			this.updatesBtn.Size = new System.Drawing.Size(280, 32);
			this.updatesBtn.TabIndex = 0;
			this.updatesBtn.Text = " check for updates";
			this.updatesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.updatesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.updatesBtn.UseVisualStyleBackColor = false;
			this.updatesBtn.Click += new System.EventHandler(this.updatesBtn_Click);
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(0, 32);
			this.logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(300, 128);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.logoPictureBox.TabIndex = 41;
			this.logoPictureBox.TabStop = false;
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.ClientSize = new System.Drawing.Size(300, 509);
			this.Controls.Add(this.closeBtn);
			this.Controls.Add(this.developerBtn);
			this.Controls.Add(this.githubBtn);
			this.Controls.Add(this.updatesBtn);
			this.Controls.Add(this.copyrightLabel);
			this.Controls.Add(this.makeDefaultBtn);
			this.Controls.Add(this.descTextBox);
			this.Controls.Add(this.logoPictureBox);
			this.Controls.Add(this.versionLabel);
			this.Controls.Add(this.productLabel);
			this.CustomBack = true;
			this.CustomBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(205)))), ((int)(((byte)(126)))));
			this.Draggable = true;
			this.EscToClose = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AboutForm";
			this.Load += new System.EventHandler(this.AboutForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label productLabel;
		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.ToolTip infoTooltip;
		private QuickLibrary.QlibTitlebarButton closeBtn;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.TextBox descTextBox;
		private System.Windows.Forms.Button makeDefaultBtn;
		private System.Windows.Forms.Label copyrightLabel;
		private System.Windows.Forms.Button updatesBtn;
		private System.Windows.Forms.Button githubBtn;
		private System.Windows.Forms.Button developerBtn;
	}
}
