namespace quick_picture_viewer
{
	partial class UpdateForm
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
			this.buttonNo = new System.Windows.Forms.Button();
			this.buttonYes = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.boxReleaseNotes = new System.Windows.Forms.CheckBox();
			this.ReleaseNotes = new System.Windows.Forms.WebBrowser();
			this.currentLabel = new System.Windows.Forms.Label();
			this.latestLabel = new System.Windows.Forms.Label();
			this.latestReleaseLink = new System.Windows.Forms.LinkLabel();
			this.currentVersionLink = new System.Windows.Forms.LinkLabel();
			this.browserTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// buttonNo
			// 
			this.buttonNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonNo.BackColor = System.Drawing.SystemColors.ControlLight;
			this.buttonNo.DialogResult = System.Windows.Forms.DialogResult.No;
			this.buttonNo.FlatAppearance.BorderSize = 0;
			this.buttonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonNo.Location = new System.Drawing.Point(290, 108);
			this.buttonNo.Margin = new System.Windows.Forms.Padding(0);
			this.buttonNo.Name = "buttonNo";
			this.buttonNo.Size = new System.Drawing.Size(75, 23);
			this.buttonNo.TabIndex = 2;
			this.buttonNo.Text = "Close";
			this.buttonNo.UseVisualStyleBackColor = false;
			// 
			// buttonYes
			// 
			this.buttonYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonYes.BackColor = System.Drawing.SystemColors.ControlLight;
			this.buttonYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.buttonYes.FlatAppearance.BorderSize = 0;
			this.buttonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonYes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonYes.Location = new System.Drawing.Point(205, 108);
			this.buttonYes.Margin = new System.Windows.Forms.Padding(0);
			this.buttonYes.Name = "buttonYes";
			this.buttonYes.Size = new System.Drawing.Size(75, 23);
			this.buttonYes.TabIndex = 1;
			this.buttonYes.Text = "Download";
			this.buttonYes.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(205, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "There is a new version of {0} available!";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 33);
			this.label2.Margin = new System.Windows.Forms.Padding(3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(197, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Would you like to download it now?";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// boxReleaseNotes
			// 
			this.boxReleaseNotes.Appearance = System.Windows.Forms.Appearance.Button;
			this.boxReleaseNotes.BackColor = System.Drawing.SystemColors.ControlLight;
			this.boxReleaseNotes.FlatAppearance.BorderSize = 0;
			this.boxReleaseNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.boxReleaseNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.boxReleaseNotes.Location = new System.Drawing.Point(9, 108);
			this.boxReleaseNotes.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
			this.boxReleaseNotes.Name = "boxReleaseNotes";
			this.boxReleaseNotes.Size = new System.Drawing.Size(83, 23);
			this.boxReleaseNotes.TabIndex = 0;
			this.boxReleaseNotes.Text = "What\'s new?";
			this.boxReleaseNotes.UseVisualStyleBackColor = false;
			this.boxReleaseNotes.CheckedChanged += new System.EventHandler(this.boxReleaseNotes_CheckedChanged);
			// 
			// ReleaseNotes
			// 
			this.ReleaseNotes.AllowNavigation = false;
			this.ReleaseNotes.AllowWebBrowserDrop = false;
			this.ReleaseNotes.IsWebBrowserContextMenuEnabled = false;
			this.ReleaseNotes.Location = new System.Drawing.Point(9, 142);
			this.ReleaseNotes.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
			this.ReleaseNotes.MinimumSize = new System.Drawing.Size(20, 20);
			this.ReleaseNotes.Name = "ReleaseNotes";
			this.ReleaseNotes.ScriptErrorsSuppressed = true;
			this.ReleaseNotes.Size = new System.Drawing.Size(347, 196);
			this.ReleaseNotes.TabIndex = 3;
			this.ReleaseNotes.Visible = false;
			this.ReleaseNotes.WebBrowserShortcutsEnabled = false;
			// 
			// currentLabel
			// 
			this.currentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.currentLabel.AutoSize = true;
			this.currentLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.currentLabel.Location = new System.Drawing.Point(12, 60);
			this.currentLabel.Margin = new System.Windows.Forms.Padding(3, 9, 0, 3);
			this.currentLabel.Name = "currentLabel";
			this.currentLabel.Size = new System.Drawing.Size(91, 15);
			this.currentLabel.TabIndex = 4;
			this.currentLabel.Text = "Current version:";
			this.currentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// latestLabel
			// 
			this.latestLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.latestLabel.AutoSize = true;
			this.latestLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.latestLabel.Location = new System.Drawing.Point(12, 81);
			this.latestLabel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.latestLabel.Name = "latestLabel";
			this.latestLabel.Size = new System.Drawing.Size(80, 15);
			this.latestLabel.TabIndex = 5;
			this.latestLabel.Text = "Latest release:";
			this.latestLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// latestReleaseLink
			// 
			this.latestReleaseLink.AutoSize = true;
			this.latestReleaseLink.Location = new System.Drawing.Point(86, 81);
			this.latestReleaseLink.Margin = new System.Windows.Forms.Padding(0);
			this.latestReleaseLink.Name = "latestReleaseLink";
			this.latestReleaseLink.Size = new System.Drawing.Size(37, 13);
			this.latestReleaseLink.TabIndex = 6;
			this.latestReleaseLink.TabStop = true;
			this.latestReleaseLink.Text = "v0.0.0";
			this.browserTooltip.SetToolTip(this.latestReleaseLink, "Open release page in browser");
			this.latestReleaseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.latestReleaseLink_LinkClicked);
			// 
			// currentVersionLink
			// 
			this.currentVersionLink.AutoSize = true;
			this.currentVersionLink.Location = new System.Drawing.Point(97, 61);
			this.currentVersionLink.Margin = new System.Windows.Forms.Padding(0);
			this.currentVersionLink.Name = "currentVersionLink";
			this.currentVersionLink.Size = new System.Drawing.Size(37, 13);
			this.currentVersionLink.TabIndex = 7;
			this.currentVersionLink.TabStop = true;
			this.currentVersionLink.Text = "v0.0.0";
			this.browserTooltip.SetToolTip(this.currentVersionLink, "Open release page in browser");
			this.currentVersionLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.currentVersionLink_LinkClicked);
			// 
			// UpdateForm
			// 
			this.AcceptButton = this.buttonYes;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CancelButton = this.buttonNo;
			this.ClientSize = new System.Drawing.Size(374, 347);
			this.ControlBox = false;
			this.Controls.Add(this.currentVersionLink);
			this.Controls.Add(this.latestReleaseLink);
			this.Controls.Add(this.buttonNo);
			this.Controls.Add(this.latestLabel);
			this.Controls.Add(this.buttonYes);
			this.Controls.Add(this.ReleaseNotes);
			this.Controls.Add(this.currentLabel);
			this.Controls.Add(this.boxReleaseNotes);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(320, 39);
			this.Name = "UpdateForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Update available!";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdateForm_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox boxReleaseNotes;
		private System.Windows.Forms.WebBrowser ReleaseNotes;
		private System.Windows.Forms.Button buttonNo;
		private System.Windows.Forms.Button buttonYes;
		private System.Windows.Forms.Label latestLabel;
		private System.Windows.Forms.Label currentLabel;
		private System.Windows.Forms.LinkLabel latestReleaseLink;
		private System.Windows.Forms.LinkLabel currentVersionLink;
		private System.Windows.Forms.ToolTip browserTooltip;
	}
}