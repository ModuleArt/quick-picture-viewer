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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.issuesLink = new System.Windows.Forms.LinkLabel();
			this.updatesLink = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.groupBox1.SuspendLayout();
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
			this.productLabel.Location = new System.Drawing.Point(6, 26);
			this.productLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.productLabel.Name = "productLabel";
			this.productLabel.Size = new System.Drawing.Size(106, 13);
			this.productLabel.TabIndex = 27;
			this.productLabel.Text = "Quick Picture Viewer";
			// 
			// versionLabel
			// 
			this.versionLabel.AutoSize = true;
			this.versionLabel.Location = new System.Drawing.Point(6, 45);
			this.versionLabel.Margin = new System.Windows.Forms.Padding(3);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(42, 13);
			this.versionLabel.TabIndex = 28;
			this.versionLabel.Text = "Version";
			// 
			// companyLabel
			// 
			this.companyLabel.AutoSize = true;
			this.companyLabel.Location = new System.Drawing.Point(6, 97);
			this.companyLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.companyLabel.Name = "companyLabel";
			this.companyLabel.Size = new System.Drawing.Size(72, 13);
			this.companyLabel.TabIndex = 29;
			this.companyLabel.Text = "by Module Art";
			// 
			// authorLabel
			// 
			this.authorLabel.AutoSize = true;
			this.authorLabel.Location = new System.Drawing.Point(6, 116);
			this.authorLabel.Margin = new System.Windows.Forms.Padding(3);
			this.authorLabel.Name = "authorLabel";
			this.authorLabel.Size = new System.Drawing.Size(108, 13);
			this.authorLabel.TabIndex = 30;
			this.authorLabel.Text = "Author: Jake Volynko";
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Location = new System.Drawing.Point(6, 142);
			this.descriptionLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(192, 13);
			this.descriptionLabel.TabIndex = 31;
			this.descriptionLabel.Text = "Lightweight picture viewer for Windows";
			// 
			// developerLink
			// 
			this.developerLink.AutoSize = true;
			this.developerLink.Location = new System.Drawing.Point(8, 168);
			this.developerLink.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.developerLink.Name = "developerLink";
			this.developerLink.Size = new System.Drawing.Size(58, 13);
			this.developerLink.TabIndex = 32;
			this.developerLink.TabStop = true;
			this.developerLink.Text = "Module Art";
			this.developerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.developerLink_LinkClicked);
			// 
			// projectLink
			// 
			this.projectLink.AutoSize = true;
			this.projectLink.Location = new System.Drawing.Point(72, 168);
			this.projectLink.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.projectLink.Name = "projectLink";
			this.projectLink.Size = new System.Drawing.Size(67, 13);
			this.projectLink.TabIndex = 33;
			this.projectLink.TabStop = true;
			this.projectLink.Text = "Project page";
			this.projectLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.projectLink_LinkClicked);
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.Location = new System.Drawing.Point(190, 317);
			this.okButton.Margin = new System.Windows.Forms.Padding(0);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 21;
			this.okButton.Text = "&OK";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.updatesLink);
			this.groupBox1.Controls.Add(this.issuesLink);
			this.groupBox1.Controls.Add(this.versionLabel);
			this.groupBox1.Controls.Add(this.projectLink);
			this.groupBox1.Controls.Add(this.companyLabel);
			this.groupBox1.Controls.Add(this.developerLink);
			this.groupBox1.Controls.Add(this.productLabel);
			this.groupBox1.Controls.Add(this.descriptionLabel);
			this.groupBox1.Controls.Add(this.authorLabel);
			this.groupBox1.Location = new System.Drawing.Point(9, 109);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(256, 201);
			this.groupBox1.TabIndex = 34;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Info";
			// 
			// issuesLink
			// 
			this.issuesLink.AutoSize = true;
			this.issuesLink.Location = new System.Drawing.Point(145, 168);
			this.issuesLink.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.issuesLink.Name = "issuesLink";
			this.issuesLink.Size = new System.Drawing.Size(37, 13);
			this.issuesLink.TabIndex = 34;
			this.issuesLink.TabStop = true;
			this.issuesLink.Text = "Issues";
			this.issuesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.issuesLink_LinkClicked);
			// 
			// updatesLink
			// 
			this.updatesLink.AutoSize = true;
			this.updatesLink.Location = new System.Drawing.Point(6, 71);
			this.updatesLink.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.updatesLink.Name = "updatesLink";
			this.updatesLink.Size = new System.Drawing.Size(94, 13);
			this.updatesLink.TabIndex = 35;
			this.updatesLink.TabStop = true;
			this.updatesLink.Text = "Check for updates";
			this.updatesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.updatesLink_LinkClicked);
			// 
			// AboutForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(274, 349);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.logoPictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.Padding = new System.Windows.Forms.Padding(9);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

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
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.LinkLabel issuesLink;
		private System.Windows.Forms.LinkLabel updatesLink;
	}
}
