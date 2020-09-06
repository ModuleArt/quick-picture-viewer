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
			this.websiteLink = new System.Windows.Forms.LinkLabel();
			this.licenseLabel = new System.Windows.Forms.Label();
			this.makeDefaultLink = new System.Windows.Forms.LinkLabel();
			this.updatesLink = new System.Windows.Forms.LinkLabel();
			this.githubLink = new System.Windows.Forms.LinkLabel();
			this.licenseLink = new System.Windows.Forms.LinkLabel();
			this.infoTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.closeBtn = new QuickLibrary.QlibTitlebarButton();
			this.titlePanel = new System.Windows.Forms.Panel();
			this.titleLabel = new System.Windows.Forms.Label();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.descTextBox = new System.Windows.Forms.TextBox();
			this.titlePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// productLabel
			// 
			this.productLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.productLabel.Location = new System.Drawing.Point(10, 142);
			this.productLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.productLabel.Name = "productLabel";
			this.productLabel.Size = new System.Drawing.Size(300, 19);
			this.productLabel.TabIndex = 27;
			this.productLabel.Text = "Quick Picture Viewer";
			this.productLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// versionLabel
			// 
			this.versionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.versionLabel.Location = new System.Drawing.Point(10, 171);
			this.versionLabel.Margin = new System.Windows.Forms.Padding(0);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.versionLabel.Size = new System.Drawing.Size(300, 19);
			this.versionLabel.TabIndex = 28;
			this.versionLabel.Text = "version";
			this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// companyLabel
			// 
			this.companyLabel.Location = new System.Drawing.Point(10, 364);
			this.companyLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.companyLabel.Name = "companyLabel";
			this.companyLabel.Size = new System.Drawing.Size(150, 19);
			this.companyLabel.TabIndex = 29;
			this.companyLabel.Text = "created by";
			this.companyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// websiteLink
			// 
			this.websiteLink.AutoSize = true;
			this.websiteLink.Location = new System.Drawing.Point(160, 364);
			this.websiteLink.Margin = new System.Windows.Forms.Padding(0);
			this.websiteLink.Name = "websiteLink";
			this.websiteLink.Size = new System.Drawing.Size(79, 19);
			this.websiteLink.TabIndex = 4;
			this.websiteLink.TabStop = true;
			this.websiteLink.Text = "Module Art";
			this.websiteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.developerLink_LinkClicked);
			// 
			// licenseLabel
			// 
			this.licenseLabel.Location = new System.Drawing.Point(10, 393);
			this.licenseLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.licenseLabel.Name = "licenseLabel";
			this.licenseLabel.Size = new System.Drawing.Size(150, 19);
			this.licenseLabel.TabIndex = 37;
			this.licenseLabel.Text = "license:";
			this.licenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// makeDefaultLink
			// 
			this.makeDefaultLink.Location = new System.Drawing.Point(10, 335);
			this.makeDefaultLink.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.makeDefaultLink.Name = "makeDefaultLink";
			this.makeDefaultLink.Size = new System.Drawing.Size(300, 19);
			this.makeDefaultLink.TabIndex = 3;
			this.makeDefaultLink.TabStop = true;
			this.makeDefaultLink.Text = "set as default photo viewer";
			this.makeDefaultLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.makeDefaultLink.Visible = false;
			this.makeDefaultLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.makeDefaultLink_LinkClicked);
			// 
			// updatesLink
			// 
			this.updatesLink.Location = new System.Drawing.Point(10, 200);
			this.updatesLink.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.updatesLink.Name = "updatesLink";
			this.updatesLink.Size = new System.Drawing.Size(300, 19);
			this.updatesLink.TabIndex = 2;
			this.updatesLink.TabStop = true;
			this.updatesLink.Text = "check for updates";
			this.updatesLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.updatesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.updatesLink_LinkClicked);
			// 
			// githubLink
			// 
			this.githubLink.Location = new System.Drawing.Point(10, 422);
			this.githubLink.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.githubLink.Name = "githubLink";
			this.githubLink.Size = new System.Drawing.Size(300, 19);
			this.githubLink.TabIndex = 7;
			this.githubLink.TabStop = true;
			this.githubLink.Text = "GitHub";
			this.githubLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.issuesLink_LinkClicked);
			// 
			// licenseLink
			// 
			this.licenseLink.AutoSize = true;
			this.licenseLink.Location = new System.Drawing.Point(160, 393);
			this.licenseLink.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.licenseLink.Name = "licenseLink";
			this.licenseLink.Size = new System.Drawing.Size(59, 19);
			this.licenseLink.TabIndex = 5;
			this.licenseLink.TabStop = true;
			this.licenseLink.Text = "GPL-3.0";
			this.licenseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.licenseLink_LinkClicked);
			// 
			// closeBtn
			// 
			this.closeBtn.DarkImage = global::quick_picture_viewer.Properties.Resources.black_close;
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.Image = global::quick_picture_viewer.Properties.Resources.black_close;
			this.closeBtn.IsRed = true;
			this.closeBtn.LightImage = global::quick_picture_viewer.Properties.Resources.white_close;
			this.closeBtn.Location = new System.Drawing.Point(288, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 1;
			this.infoTooltip.SetToolTip(this.closeBtn, "Close (Alt+F4)");
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
			this.titlePanel.Size = new System.Drawing.Size(320, 32);
			this.titlePanel.TabIndex = 0;
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(10, 7);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(79, 19);
			this.titleLabel.TabIndex = 16;
			this.titleLabel.Text = "AboutForm";
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(0, 32);
			this.logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(320, 100);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.logoPictureBox.TabIndex = 41;
			this.logoPictureBox.TabStop = false;
			// 
			// descTextBox
			// 
			this.descTextBox.BackColor = System.Drawing.Color.White;
			this.descTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.descTextBox.Location = new System.Drawing.Point(10, 229);
			this.descTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.descTextBox.Multiline = true;
			this.descTextBox.Name = "descTextBox";
			this.descTextBox.Size = new System.Drawing.Size(300, 96);
			this.descTextBox.TabIndex = 42;
			this.descTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(320, 460);
			this.Controls.Add(this.descTextBox);
			this.Controls.Add(this.githubLink);
			this.Controls.Add(this.licenseLabel);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.websiteLink);
			this.Controls.Add(this.licenseLink);
			this.Controls.Add(this.companyLabel);
			this.Controls.Add(this.makeDefaultLink);
			this.Controls.Add(this.logoPictureBox);
			this.Controls.Add(this.updatesLink);
			this.Controls.Add(this.versionLabel);
			this.Controls.Add(this.productLabel);
			this.Draggable = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AboutForm";
			this.TitleLabel = this.titleLabel;
			this.Load += new System.EventHandler(this.AboutForm_Load);
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
		private System.Windows.Forms.LinkLabel websiteLink;
		private System.Windows.Forms.LinkLabel githubLink;
		private System.Windows.Forms.LinkLabel updatesLink;
		private System.Windows.Forms.LinkLabel makeDefaultLink;
		private System.Windows.Forms.Label licenseLabel;
		private System.Windows.Forms.LinkLabel licenseLink;
		private System.Windows.Forms.ToolTip infoTooltip;
		private System.Windows.Forms.Panel titlePanel;
		private System.Windows.Forms.Label titleLabel;
		private QuickLibrary.QlibTitlebarButton closeBtn;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.TextBox descTextBox;
	}
}
