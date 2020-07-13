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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.productLabel = new System.Windows.Forms.Label();
			this.versionLabel = new System.Windows.Forms.Label();
			this.companyLabel = new System.Windows.Forms.Label();
			this.authorLabel = new System.Windows.Forms.Label();
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.websiteLink = new System.Windows.Forms.LinkLabel();
			this.projectLink = new System.Windows.Forms.LinkLabel();
			this.licenseLabel = new System.Windows.Forms.Label();
			this.makeDefaultLink = new System.Windows.Forms.LinkLabel();
			this.updatesLink = new System.Windows.Forms.LinkLabel();
			this.issuesLink = new System.Windows.Forms.LinkLabel();
			this.githubLabel = new System.Windows.Forms.Label();
			this.licenseLink = new System.Windows.Forms.LinkLabel();
			this.aboutTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.closeBtn = new QuickLibrary.QlibTitlebarButton();
			this.titlePanel = new System.Windows.Forms.Panel();
			this.titleLabel = new System.Windows.Forms.Label();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.titlePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// productLabel
			// 
			this.productLabel.AutoSize = true;
			this.productLabel.Location = new System.Drawing.Point(10, 142);
			this.productLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.productLabel.Name = "productLabel";
			this.productLabel.Size = new System.Drawing.Size(135, 19);
			this.productLabel.TabIndex = 27;
			this.productLabel.Text = "Quick Picture Viewer";
			// 
			// versionLabel
			// 
			this.versionLabel.AutoSize = true;
			this.versionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.versionLabel.Location = new System.Drawing.Point(145, 142);
			this.versionLabel.Margin = new System.Windows.Forms.Padding(0);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.versionLabel.Size = new System.Drawing.Size(54, 19);
			this.versionLabel.TabIndex = 28;
			this.versionLabel.Text = "Version";
			this.versionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// companyLabel
			// 
			this.companyLabel.AutoSize = true;
			this.companyLabel.Location = new System.Drawing.Point(10, 315);
			this.companyLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.companyLabel.Name = "companyLabel";
			this.companyLabel.Size = new System.Drawing.Size(76, 19);
			this.companyLabel.TabIndex = 29;
			this.companyLabel.Text = "Created by";
			// 
			// authorLabel
			// 
			this.authorLabel.AutoSize = true;
			this.authorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.authorLabel.Location = new System.Drawing.Point(165, 315);
			this.authorLabel.Margin = new System.Windows.Forms.Padding(0);
			this.authorLabel.Name = "authorLabel";
			this.authorLabel.Size = new System.Drawing.Size(115, 19);
			this.authorLabel.TabIndex = 30;
			this.authorLabel.Text = "(Eugene Volynko)";
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.Location = new System.Drawing.Point(10, 200);
			this.descriptionLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(280, 76);
			this.descriptionLabel.TabIndex = 31;
			this.descriptionLabel.Text = "Lightweight, versatile desktop photo viewer for Windows, built on top of WinForms" +
    " (C#). The best replacement for the default Windows image viewer.";
			// 
			// websiteLink
			// 
			this.websiteLink.AutoSize = true;
			this.websiteLink.Location = new System.Drawing.Point(86, 315);
			this.websiteLink.Margin = new System.Windows.Forms.Padding(0);
			this.websiteLink.Name = "websiteLink";
			this.websiteLink.Size = new System.Drawing.Size(79, 19);
			this.websiteLink.TabIndex = 4;
			this.websiteLink.TabStop = true;
			this.websiteLink.Text = "Module Art";
			this.aboutTooltip.SetToolTip(this.websiteLink, "Open Module Art website");
			this.websiteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.developerLink_LinkClicked);
			// 
			// projectLink
			// 
			this.projectLink.AutoSize = true;
			this.projectLink.Location = new System.Drawing.Point(66, 373);
			this.projectLink.Margin = new System.Windows.Forms.Padding(0);
			this.projectLink.Name = "projectLink";
			this.projectLink.Size = new System.Drawing.Size(85, 19);
			this.projectLink.TabIndex = 6;
			this.projectLink.TabStop = true;
			this.projectLink.Text = "Project page";
			this.aboutTooltip.SetToolTip(this.projectLink, "Open GitHub project page");
			this.projectLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.projectLink_LinkClicked);
			// 
			// licenseLabel
			// 
			this.licenseLabel.AutoSize = true;
			this.licenseLabel.Location = new System.Drawing.Point(10, 344);
			this.licenseLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.licenseLabel.Name = "licenseLabel";
			this.licenseLabel.Size = new System.Drawing.Size(56, 19);
			this.licenseLabel.TabIndex = 37;
			this.licenseLabel.Text = "License:";
			// 
			// makeDefaultLink
			// 
			this.makeDefaultLink.AutoSize = true;
			this.makeDefaultLink.Location = new System.Drawing.Point(10, 286);
			this.makeDefaultLink.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.makeDefaultLink.Name = "makeDefaultLink";
			this.makeDefaultLink.Size = new System.Drawing.Size(175, 19);
			this.makeDefaultLink.TabIndex = 3;
			this.makeDefaultLink.TabStop = true;
			this.makeDefaultLink.Text = "Set as default photo viewer";
			this.aboutTooltip.SetToolTip(this.makeDefaultLink, "Open Windows settings");
			this.makeDefaultLink.Visible = false;
			this.makeDefaultLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.makeDefaultLink_LinkClicked);
			// 
			// updatesLink
			// 
			this.updatesLink.AutoSize = true;
			this.updatesLink.Location = new System.Drawing.Point(10, 171);
			this.updatesLink.Margin = new System.Windows.Forms.Padding(0);
			this.updatesLink.Name = "updatesLink";
			this.updatesLink.Size = new System.Drawing.Size(120, 19);
			this.updatesLink.TabIndex = 2;
			this.updatesLink.TabStop = true;
			this.updatesLink.Text = "Check for updates";
			this.updatesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.updatesLink_LinkClicked);
			// 
			// issuesLink
			// 
			this.issuesLink.AutoSize = true;
			this.issuesLink.Location = new System.Drawing.Point(151, 373);
			this.issuesLink.Margin = new System.Windows.Forms.Padding(0);
			this.issuesLink.Name = "issuesLink";
			this.issuesLink.Size = new System.Drawing.Size(46, 19);
			this.issuesLink.TabIndex = 7;
			this.issuesLink.TabStop = true;
			this.issuesLink.Text = "Issues";
			this.aboutTooltip.SetToolTip(this.issuesLink, "Open GitHub issues page");
			this.issuesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.issuesLink_LinkClicked);
			// 
			// githubLabel
			// 
			this.githubLabel.AutoSize = true;
			this.githubLabel.Location = new System.Drawing.Point(10, 373);
			this.githubLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.githubLabel.Name = "githubLabel";
			this.githubLabel.Size = new System.Drawing.Size(56, 19);
			this.githubLabel.TabIndex = 39;
			this.githubLabel.Text = "GitHub:";
			// 
			// licenseLink
			// 
			this.licenseLink.AutoSize = true;
			this.licenseLink.Location = new System.Drawing.Point(66, 344);
			this.licenseLink.Margin = new System.Windows.Forms.Padding(0);
			this.licenseLink.Name = "licenseLink";
			this.licenseLink.Size = new System.Drawing.Size(59, 19);
			this.licenseLink.TabIndex = 5;
			this.licenseLink.TabStop = true;
			this.licenseLink.Text = "GPL-3.0";
			this.aboutTooltip.SetToolTip(this.licenseLink, "Open GitHub license page");
			this.licenseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.licenseLink_LinkClicked);
			// 
			// closeBtn
			// 
			this.closeBtn.DarkImage = global::quick_picture_viewer.Properties.Resources.black_close;
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.Image = global::quick_picture_viewer.Properties.Resources.black_close;
			this.closeBtn.IsRed = true;
			this.closeBtn.LightImage = global::quick_picture_viewer.Properties.Resources.white_close;
			this.closeBtn.Location = new System.Drawing.Point(268, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 1;
			this.aboutTooltip.SetToolTip(this.closeBtn, "Close (Alt+F4)");
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// titlePanel
			// 
			this.titlePanel.Controls.Add(this.titleLabel);
			this.titlePanel.Controls.Add(this.closeBtn);
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Margin = new System.Windows.Forms.Padding(0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(300, 32);
			this.titlePanel.TabIndex = 0;
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(10, 7);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(47, 19);
			this.titleLabel.TabIndex = 16;
			this.titleLabel.Text = "About";
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(0, 32);
			this.logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(300, 100);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.logoPictureBox.TabIndex = 41;
			this.logoPictureBox.TabStop = false;
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.ClientSize = new System.Drawing.Size(300, 410);
			this.Controls.Add(this.githubLabel);
			this.Controls.Add(this.issuesLink);
			this.Controls.Add(this.projectLink);
			this.Controls.Add(this.licenseLabel);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.websiteLink);
			this.Controls.Add(this.licenseLink);
			this.Controls.Add(this.authorLabel);
			this.Controls.Add(this.companyLabel);
			this.Controls.Add(this.makeDefaultLink);
			this.Controls.Add(this.logoPictureBox);
			this.Controls.Add(this.updatesLink);
			this.Controls.Add(this.descriptionLabel);
			this.Controls.Add(this.versionLabel);
			this.Controls.Add(this.productLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AboutForm_KeyDown);
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label productLabel;
		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.Label companyLabel;
		private System.Windows.Forms.Label authorLabel;
		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.LinkLabel websiteLink;
		private System.Windows.Forms.LinkLabel projectLink;
		private System.Windows.Forms.LinkLabel issuesLink;
		private System.Windows.Forms.LinkLabel updatesLink;
		private System.Windows.Forms.LinkLabel makeDefaultLink;
		private System.Windows.Forms.Label licenseLabel;
		private System.Windows.Forms.LinkLabel licenseLink;
		private System.Windows.Forms.ToolTip aboutTooltip;
		private System.Windows.Forms.Label githubLabel;
		private System.Windows.Forms.Panel titlePanel;
		private System.Windows.Forms.Label titleLabel;
		private QuickLibrary.QlibTitlebarButton closeBtn;
		private System.Windows.Forms.PictureBox logoPictureBox;
	}
}
