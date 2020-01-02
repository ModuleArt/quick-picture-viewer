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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.productLabel = new System.Windows.Forms.Label();
			this.versionLabel = new System.Windows.Forms.Label();
			this.companyLabel = new System.Windows.Forms.Label();
			this.authorLabel = new System.Windows.Forms.Label();
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.developerLink = new System.Windows.Forms.LinkLabel();
			this.projectLink = new System.Windows.Forms.LinkLabel();
			this.okButton = new System.Windows.Forms.Button();
			this.infoGroup = new System.Windows.Forms.GroupBox();
			this.makeDefaultLink = new System.Windows.Forms.LinkLabel();
			this.updatesLink = new System.Windows.Forms.LinkLabel();
			this.issuesLink = new System.Windows.Forms.LinkLabel();
			this.pagesGroup = new System.Windows.Forms.GroupBox();
			this.licenseLabel = new System.Windows.Forms.Label();
			this.licenseLink = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.infoGroup.SuspendLayout();
			this.pagesGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(9, 9);
			this.logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(256, 100);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.logoPictureBox.TabIndex = 12;
			this.logoPictureBox.TabStop = false;
			// 
			// productLabel
			// 
			this.productLabel.AutoSize = true;
			this.productLabel.Location = new System.Drawing.Point(6, 28);
			this.productLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
			this.productLabel.Name = "productLabel";
			this.productLabel.Size = new System.Drawing.Size(116, 15);
			this.productLabel.TabIndex = 27;
			this.productLabel.Text = "Quick Picture Viewer";
			// 
			// versionLabel
			// 
			this.versionLabel.AutoSize = true;
			this.versionLabel.Location = new System.Drawing.Point(6, 49);
			this.versionLabel.Margin = new System.Windows.Forms.Padding(3);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(45, 15);
			this.versionLabel.TabIndex = 28;
			this.versionLabel.Text = "Version";
			// 
			// companyLabel
			// 
			this.companyLabel.AutoSize = true;
			this.companyLabel.Location = new System.Drawing.Point(6, 103);
			this.companyLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
			this.companyLabel.Name = "companyLabel";
			this.companyLabel.Size = new System.Drawing.Size(83, 15);
			this.companyLabel.TabIndex = 29;
			this.companyLabel.Text = "by Module Art";
			// 
			// authorLabel
			// 
			this.authorLabel.AutoSize = true;
			this.authorLabel.Location = new System.Drawing.Point(6, 124);
			this.authorLabel.Margin = new System.Windows.Forms.Padding(3);
			this.authorLabel.Name = "authorLabel";
			this.authorLabel.Size = new System.Drawing.Size(134, 15);
			this.authorLabel.TabIndex = 30;
			this.authorLabel.Text = "Author: Eugene Volynko";
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Location = new System.Drawing.Point(6, 151);
			this.descriptionLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(221, 30);
			this.descriptionLabel.TabIndex = 31;
			this.descriptionLabel.Text = "Lightweight desktop photo viewer for\r\nWindows, built on top of WinForms (C#)\r\n";
			// 
			// developerLink
			// 
			this.developerLink.AutoSize = true;
			this.developerLink.Location = new System.Drawing.Point(6, 28);
			this.developerLink.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
			this.developerLink.Name = "developerLink";
			this.developerLink.Size = new System.Drawing.Size(67, 15);
			this.developerLink.TabIndex = 32;
			this.developerLink.TabStop = true;
			this.developerLink.Text = "Module Art";
			this.developerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.developerLink_LinkClicked);
			// 
			// projectLink
			// 
			this.projectLink.AutoSize = true;
			this.projectLink.Location = new System.Drawing.Point(79, 28);
			this.projectLink.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
			this.projectLink.Name = "projectLink";
			this.projectLink.Size = new System.Drawing.Size(73, 15);
			this.projectLink.TabIndex = 33;
			this.projectLink.TabStop = true;
			this.projectLink.Text = "Project page";
			this.projectLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.projectLink_LinkClicked);
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.FlatAppearance.BorderSize = 0;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okButton.Location = new System.Drawing.Point(9, 451);
			this.okButton.Margin = new System.Windows.Forms.Padding(0);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(256, 23);
			this.okButton.TabIndex = 21;
			this.okButton.Text = "Close";
			this.okButton.UseVisualStyleBackColor = false;
			// 
			// infoGroup
			// 
			this.infoGroup.Controls.Add(this.makeDefaultLink);
			this.infoGroup.Controls.Add(this.updatesLink);
			this.infoGroup.Controls.Add(this.versionLabel);
			this.infoGroup.Controls.Add(this.companyLabel);
			this.infoGroup.Controls.Add(this.productLabel);
			this.infoGroup.Controls.Add(this.descriptionLabel);
			this.infoGroup.Controls.Add(this.authorLabel);
			this.infoGroup.Location = new System.Drawing.Point(9, 118);
			this.infoGroup.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.infoGroup.Name = "infoGroup";
			this.infoGroup.Size = new System.Drawing.Size(256, 253);
			this.infoGroup.TabIndex = 34;
			this.infoGroup.TabStop = false;
			this.infoGroup.Text = "Info";
			// 
			// makeDefaultLink
			// 
			this.makeDefaultLink.AutoSize = true;
			this.makeDefaultLink.Location = new System.Drawing.Point(6, 193);
			this.makeDefaultLink.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
			this.makeDefaultLink.Name = "makeDefaultLink";
			this.makeDefaultLink.Size = new System.Drawing.Size(149, 15);
			this.makeDefaultLink.TabIndex = 36;
			this.makeDefaultLink.TabStop = true;
			this.makeDefaultLink.Text = "Set as default photo viewer";
			this.makeDefaultLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.makeDefaultLink_LinkClicked);
			// 
			// updatesLink
			// 
			this.updatesLink.AutoSize = true;
			this.updatesLink.Location = new System.Drawing.Point(6, 76);
			this.updatesLink.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
			this.updatesLink.Name = "updatesLink";
			this.updatesLink.Size = new System.Drawing.Size(103, 15);
			this.updatesLink.TabIndex = 35;
			this.updatesLink.TabStop = true;
			this.updatesLink.Text = "Check for updates";
			this.updatesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.updatesLink_LinkClicked);
			// 
			// issuesLink
			// 
			this.issuesLink.AutoSize = true;
			this.issuesLink.Location = new System.Drawing.Point(158, 28);
			this.issuesLink.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
			this.issuesLink.Name = "issuesLink";
			this.issuesLink.Size = new System.Drawing.Size(38, 15);
			this.issuesLink.TabIndex = 34;
			this.issuesLink.TabStop = true;
			this.issuesLink.Text = "Issues";
			this.issuesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.issuesLink_LinkClicked);
			// 
			// pagesGroup
			// 
			this.pagesGroup.Controls.Add(this.licenseLink);
			this.pagesGroup.Controls.Add(this.developerLink);
			this.pagesGroup.Controls.Add(this.projectLink);
			this.pagesGroup.Controls.Add(this.issuesLink);
			this.pagesGroup.Location = new System.Drawing.Point(9, 380);
			this.pagesGroup.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.pagesGroup.Name = "pagesGroup";
			this.pagesGroup.Size = new System.Drawing.Size(256, 63);
			this.pagesGroup.TabIndex = 37;
			this.pagesGroup.TabStop = false;
			this.pagesGroup.Text = "Links";
			// 
			// licenseLabel
			// 
			this.licenseLabel.AutoSize = true;
			this.licenseLabel.Location = new System.Drawing.Point(15, 338);
			this.licenseLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
			this.licenseLabel.Name = "licenseLabel";
			this.licenseLabel.Size = new System.Drawing.Size(93, 15);
			this.licenseLabel.TabIndex = 37;
			this.licenseLabel.Text = "License: GPL-3.0";
			// 
			// licenseLink
			// 
			this.licenseLink.AutoSize = true;
			this.licenseLink.Location = new System.Drawing.Point(202, 28);
			this.licenseLink.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
			this.licenseLink.Name = "licenseLink";
			this.licenseLink.Size = new System.Drawing.Size(46, 15);
			this.licenseLink.TabIndex = 35;
			this.licenseLink.TabStop = true;
			this.licenseLink.Text = "License";
			this.licenseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.licenseLink_LinkClicked);
			// 
			// AboutForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(274, 483);
			this.Controls.Add(this.licenseLabel);
			this.Controls.Add(this.pagesGroup);
			this.Controls.Add(this.infoGroup);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.logoPictureBox);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.Padding = new System.Windows.Forms.Padding(9);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AboutForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.infoGroup.ResumeLayout(false);
			this.infoGroup.PerformLayout();
			this.pagesGroup.ResumeLayout(false);
			this.pagesGroup.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Label productLabel;
		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.Label companyLabel;
		private System.Windows.Forms.Label authorLabel;
		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.LinkLabel developerLink;
		private System.Windows.Forms.LinkLabel projectLink;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.GroupBox infoGroup;
		private System.Windows.Forms.LinkLabel issuesLink;
		private System.Windows.Forms.LinkLabel updatesLink;
		private System.Windows.Forms.LinkLabel makeDefaultLink;
		private System.Windows.Forms.GroupBox pagesGroup;
		private System.Windows.Forms.Label licenseLabel;
		private System.Windows.Forms.LinkLabel licenseLink;
	}
}
