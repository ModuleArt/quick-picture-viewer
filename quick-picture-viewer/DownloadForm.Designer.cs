namespace quick_picture_viewer
{
	partial class DownloadForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadForm));
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.statusLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.updateButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(9, 123);
			this.progressBar1.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(256, 23);
			this.progressBar1.TabIndex = 0;
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(9, 9);
			this.logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(256, 80);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.logoPictureBox.TabIndex = 13;
			this.logoPictureBox.TabStop = false;
			// 
			// statusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.Location = new System.Drawing.Point(12, 98);
			this.statusLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(99, 13);
			this.statusLabel.TabIndex = 14;
			this.statusLabel.Text = "Download started...";
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.FlatAppearance.BorderSize = 0;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelButton.Location = new System.Drawing.Point(141, 156);
			this.cancelButton.Margin = new System.Windows.Forms.Padding(0);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(124, 23);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = false;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// updateButton
			// 
			this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.updateButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.updateButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.updateButton.FlatAppearance.BorderSize = 0;
			this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updateButton.Location = new System.Drawing.Point(9, 156);
			this.updateButton.Margin = new System.Windows.Forms.Padding(0);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(124, 23);
			this.updateButton.TabIndex = 0;
			this.updateButton.Text = "Update";
			this.updateButton.UseVisualStyleBackColor = false;
			this.updateButton.Visible = false;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// DownloadForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(270, 184);
			this.ControlBox = false;
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.statusLabel);
			this.Controls.Add(this.logoPictureBox);
			this.Controls.Add(this.progressBar1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DownloadForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Update downloader";
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button updateButton;
	}
}