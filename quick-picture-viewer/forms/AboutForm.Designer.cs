namespace quick_picture_viewer
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			productLabel = new System.Windows.Forms.Label();
			versionLabel = new System.Windows.Forms.Label();
			infoTooltip = new System.Windows.Forms.ToolTip(components);
			closeBtn = new QuickLibrary.QlibTitlebarButton();
			developerBtn = new System.Windows.Forms.Button();
			githubBtn = new System.Windows.Forms.Button();
			descTextBox = new System.Windows.Forms.TextBox();
			makeDefaultBtn = new System.Windows.Forms.Button();
			copyrightLabel = new System.Windows.Forms.Label();
			updatesBtn = new System.Windows.Forms.Button();
			logoPictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
			SuspendLayout();
			// 
			// productLabel
			// 
			productLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			productLabel.Location = new System.Drawing.Point(10, 170);
			productLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			productLabel.Name = "productLabel";
			productLabel.Size = new System.Drawing.Size(280, 19);
			productLabel.TabIndex = 27;
			productLabel.Text = "Quick Picture Viewer";
			productLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// versionLabel
			// 
			versionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			versionLabel.ForeColor = System.Drawing.Color.FromArgb(146, 124, 76);
			versionLabel.Location = new System.Drawing.Point(10, 199);
			versionLabel.Margin = new System.Windows.Forms.Padding(0);
			versionLabel.Name = "versionLabel";
			versionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			versionLabel.Size = new System.Drawing.Size(280, 19);
			versionLabel.TabIndex = 28;
			versionLabel.Text = "version";
			versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// closeBtn
			// 
			closeBtn.DarkImage = Properties.Resources.black_close;
			closeBtn.DarkMode = false;
			closeBtn.FlatAppearance.BorderSize = 0;
			closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(140, 140, 140);
			closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
			closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			closeBtn.ForeColor = System.Drawing.Color.Black;
			closeBtn.Image = Properties.Resources.black_close;
			closeBtn.IsRed = true;
			closeBtn.LightImage = Properties.Resources.white_close;
			closeBtn.Location = new System.Drawing.Point(268, 0);
			closeBtn.Margin = new System.Windows.Forms.Padding(0);
			closeBtn.Name = "closeBtn";
			closeBtn.Size = new System.Drawing.Size(32, 32);
			closeBtn.TabIndex = 4;
			infoTooltip.SetToolTip(closeBtn, "Close (Alt+F4)");
			closeBtn.UseVisualStyleBackColor = true;
			closeBtn.Click += closeBtn_Click;
			// 
			// developerBtn
			// 
			developerBtn.BackColor = System.Drawing.Color.FromArgb(217, 184, 113);
			developerBtn.FlatAppearance.BorderSize = 0;
			developerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(170, 144, 88);
			developerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(193, 164, 101);
			developerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			developerBtn.Image = (System.Drawing.Image)resources.GetObject("developerBtn.Image");
			developerBtn.Location = new System.Drawing.Point(155, 376);
			developerBtn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			developerBtn.Name = "developerBtn";
			developerBtn.Size = new System.Drawing.Size(135, 32);
			developerBtn.TabIndex = 2;
			developerBtn.Text = " Module Art";
			developerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			developerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			infoTooltip.SetToolTip(developerBtn, "moduleart.github.io");
			developerBtn.UseVisualStyleBackColor = false;
			developerBtn.Click += developerBtn_Click;
			// 
			// githubBtn
			// 
			githubBtn.BackColor = System.Drawing.Color.FromArgb(217, 184, 113);
			githubBtn.FlatAppearance.BorderSize = 0;
			githubBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(170, 144, 88);
			githubBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(193, 164, 101);
			githubBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			githubBtn.Image = (System.Drawing.Image)resources.GetObject("githubBtn.Image");
			githubBtn.Location = new System.Drawing.Point(10, 376);
			githubBtn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			githubBtn.Name = "githubBtn";
			githubBtn.Size = new System.Drawing.Size(135, 32);
			githubBtn.TabIndex = 1;
			githubBtn.Text = " GitHub";
			githubBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			githubBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			infoTooltip.SetToolTip(githubBtn, "github.com/ModuleArt/quick-picture-viewer");
			githubBtn.UseVisualStyleBackColor = false;
			githubBtn.Click += button1_Click;
			// 
			// descTextBox
			// 
			descTextBox.BackColor = System.Drawing.Color.FromArgb(241, 205, 126);
			descTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			descTextBox.Location = new System.Drawing.Point(20, 228);
			descTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			descTextBox.Multiline = true;
			descTextBox.Name = "descTextBox";
			descTextBox.ReadOnly = true;
			descTextBox.Size = new System.Drawing.Size(260, 96);
			descTextBox.TabIndex = 5;
			descTextBox.Text = "description";
			descTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// makeDefaultBtn
			// 
			makeDefaultBtn.BackColor = System.Drawing.Color.FromArgb(217, 184, 113);
			makeDefaultBtn.Enabled = false;
			makeDefaultBtn.FlatAppearance.BorderSize = 0;
			makeDefaultBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(170, 144, 88);
			makeDefaultBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(193, 164, 101);
			makeDefaultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			makeDefaultBtn.Location = new System.Drawing.Point(10, 418);
			makeDefaultBtn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			makeDefaultBtn.Name = "makeDefaultBtn";
			makeDefaultBtn.Size = new System.Drawing.Size(280, 32);
			makeDefaultBtn.TabIndex = 3;
			makeDefaultBtn.Text = "set as default photo viewer";
			makeDefaultBtn.UseVisualStyleBackColor = false;
			makeDefaultBtn.Click += makeDefaultBtn_Click;
			// 
			// copyrightLabel
			// 
			copyrightLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			copyrightLabel.ForeColor = System.Drawing.Color.FromArgb(146, 124, 76);
			copyrightLabel.Location = new System.Drawing.Point(10, 470);
			copyrightLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			copyrightLabel.Name = "copyrightLabel";
			copyrightLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			copyrightLabel.Size = new System.Drawing.Size(280, 19);
			copyrightLabel.TabIndex = 44;
			copyrightLabel.Text = "Copyright © 2023 Module Art";
			copyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// updatesBtn
			// 
			updatesBtn.BackColor = System.Drawing.Color.FromArgb(217, 184, 113);
			updatesBtn.FlatAppearance.BorderSize = 0;
			updatesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(170, 144, 88);
			updatesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(193, 164, 101);
			updatesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			updatesBtn.Image = Properties.Resources.black_sync;
			updatesBtn.Location = new System.Drawing.Point(10, 334);
			updatesBtn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			updatesBtn.Name = "updatesBtn";
			updatesBtn.Size = new System.Drawing.Size(280, 32);
			updatesBtn.TabIndex = 0;
			updatesBtn.Text = " check for updates";
			updatesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			updatesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			updatesBtn.UseVisualStyleBackColor = false;
			updatesBtn.Click += updatesBtn_Click;
			// 
			// logoPictureBox
			// 
			logoPictureBox.Image = (System.Drawing.Image)resources.GetObject("logoPictureBox.Image");
			logoPictureBox.Location = new System.Drawing.Point(0, 32);
			logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
			logoPictureBox.Name = "logoPictureBox";
			logoPictureBox.Size = new System.Drawing.Size(300, 128);
			logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			logoPictureBox.TabIndex = 41;
			logoPictureBox.TabStop = false;
			// 
			// AboutForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			ClientSize = new System.Drawing.Size(300, 509);
			Controls.Add(closeBtn);
			Controls.Add(developerBtn);
			Controls.Add(githubBtn);
			Controls.Add(updatesBtn);
			Controls.Add(copyrightLabel);
			Controls.Add(makeDefaultBtn);
			Controls.Add(descTextBox);
			Controls.Add(logoPictureBox);
			Controls.Add(versionLabel);
			Controls.Add(productLabel);
			CustomBack = true;
			CustomBackColor = System.Drawing.Color.FromArgb(241, 205, 126);
			Draggable = true;
			EscToClose = true;
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "AboutForm";
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "AboutForm";
			Load += AboutForm_Load;
			((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
			ResumeLayout(false);
			PerformLayout();
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
