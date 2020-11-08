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
			this.infoTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.closeBtn = new QuickLibrary.QlibTitlebarButton();
			this.descTextBox = new System.Windows.Forms.TextBox();
			this.makeDefaultBtn = new System.Windows.Forms.Button();
			this.copyrightLabel = new System.Windows.Forms.Label();
			this.updatesBtn = new System.Windows.Forms.Button();
			this.developerBtn = new System.Windows.Forms.Button();
			this.githubBtn = new System.Windows.Forms.Button();
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
			this.productLabel.Size = new System.Drawing.Size(270, 19);
			this.productLabel.TabIndex = 27;
			this.productLabel.Text = "Quick Picture Viewer";
			this.productLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// versionLabel
			// 
			this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.versionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(21)))));
			this.versionLabel.Location = new System.Drawing.Point(10, 199);
			this.versionLabel.Margin = new System.Windows.Forms.Padding(0);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.versionLabel.Size = new System.Drawing.Size(270, 19);
			this.versionLabel.TabIndex = 28;
			this.versionLabel.Text = "version";
			this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// closeBtn
			// 
			this.closeBtn.DarkImage = global::quick_picture_viewer.Properties.Resources.black_close;
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.Image = global::quick_picture_viewer.Properties.Resources.black_close;
			this.closeBtn.IsRed = true;
			this.closeBtn.LightImage = global::quick_picture_viewer.Properties.Resources.white_close;
			this.closeBtn.Location = new System.Drawing.Point(258, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 1;
			this.infoTooltip.SetToolTip(this.closeBtn, "Close (Alt+F4)");
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// descTextBox
			// 
			this.descTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(173)))), ((int)(((byte)(43)))));
			this.descTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.descTextBox.Location = new System.Drawing.Point(10, 228);
			this.descTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.descTextBox.Multiline = true;
			this.descTextBox.Name = "descTextBox";
			this.descTextBox.Size = new System.Drawing.Size(270, 96);
			this.descTextBox.TabIndex = 42;
			this.descTextBox.Text = "description";
			this.descTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// makeDefaultBtn
			// 
			this.makeDefaultBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(159)))), ((int)(((byte)(39)))));
			this.makeDefaultBtn.FlatAppearance.BorderSize = 0;
			this.makeDefaultBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(32)))));
			this.makeDefaultBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(36)))));
			this.makeDefaultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.makeDefaultBtn.Location = new System.Drawing.Point(10, 418);
			this.makeDefaultBtn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.makeDefaultBtn.Name = "makeDefaultBtn";
			this.makeDefaultBtn.Size = new System.Drawing.Size(270, 32);
			this.makeDefaultBtn.TabIndex = 43;
			this.makeDefaultBtn.Text = "set as default photo viewer";
			this.makeDefaultBtn.UseVisualStyleBackColor = false;
			this.makeDefaultBtn.Visible = false;
			this.makeDefaultBtn.Click += new System.EventHandler(this.makeDefaultBtn_Click);
			// 
			// copyrightLabel
			// 
			this.copyrightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.copyrightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(21)))));
			this.copyrightLabel.Location = new System.Drawing.Point(10, 470);
			this.copyrightLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.copyrightLabel.Name = "copyrightLabel";
			this.copyrightLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.copyrightLabel.Size = new System.Drawing.Size(270, 19);
			this.copyrightLabel.TabIndex = 44;
			this.copyrightLabel.Text = "Copyright © 2020 Module Art";
			this.copyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// updatesBtn
			// 
			this.updatesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(159)))), ((int)(((byte)(39)))));
			this.updatesBtn.FlatAppearance.BorderSize = 0;
			this.updatesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(32)))));
			this.updatesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(36)))));
			this.updatesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updatesBtn.Image = global::quick_picture_viewer.Properties.Resources.black_sync;
			this.updatesBtn.Location = new System.Drawing.Point(10, 334);
			this.updatesBtn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.updatesBtn.Name = "updatesBtn";
			this.updatesBtn.Size = new System.Drawing.Size(270, 32);
			this.updatesBtn.TabIndex = 45;
			this.updatesBtn.Text = " check for updates";
			this.updatesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.updatesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.updatesBtn.UseVisualStyleBackColor = false;
			this.updatesBtn.Click += new System.EventHandler(this.updatesBtn_Click);
			// 
			// developerBtn
			// 
			this.developerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(159)))), ((int)(((byte)(39)))));
			this.developerBtn.FlatAppearance.BorderSize = 0;
			this.developerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(32)))));
			this.developerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(36)))));
			this.developerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.developerBtn.Image = ((System.Drawing.Image)(resources.GetObject("developerBtn.Image")));
			this.developerBtn.Location = new System.Drawing.Point(150, 376);
			this.developerBtn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.developerBtn.Name = "developerBtn";
			this.developerBtn.Size = new System.Drawing.Size(130, 32);
			this.developerBtn.TabIndex = 47;
			this.developerBtn.Text = " Module Art";
			this.developerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.developerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.developerBtn.UseVisualStyleBackColor = false;
			this.developerBtn.Click += new System.EventHandler(this.developerBtn_Click);
			// 
			// githubBtn
			// 
			this.githubBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(159)))), ((int)(((byte)(39)))));
			this.githubBtn.FlatAppearance.BorderSize = 0;
			this.githubBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(132)))), ((int)(((byte)(32)))));
			this.githubBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(145)))), ((int)(((byte)(36)))));
			this.githubBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.githubBtn.Image = ((System.Drawing.Image)(resources.GetObject("githubBtn.Image")));
			this.githubBtn.Location = new System.Drawing.Point(10, 376);
			this.githubBtn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.githubBtn.Name = "githubBtn";
			this.githubBtn.Size = new System.Drawing.Size(130, 32);
			this.githubBtn.TabIndex = 46;
			this.githubBtn.Text = " GitHub";
			this.githubBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.githubBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.githubBtn.UseVisualStyleBackColor = false;
			this.githubBtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(0, 32);
			this.logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(290, 128);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.logoPictureBox.TabIndex = 41;
			this.logoPictureBox.TabStop = false;
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.ClientSize = new System.Drawing.Size(290, 509);
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
			this.CustomBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(173)))), ((int)(((byte)(43)))));
			this.Draggable = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AboutForm";
			this.Load += new System.EventHandler(this.AboutForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AboutForm_KeyDown);
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
