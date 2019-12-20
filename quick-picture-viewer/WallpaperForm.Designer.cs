namespace quick_picture_viewer
{
	partial class WallpaperForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WallpaperForm));
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.okButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.fitRadio = new System.Windows.Forms.RadioButton();
			this.fillRadio = new System.Windows.Forms.RadioButton();
			this.stretchedRadio = new System.Windows.Forms.RadioButton();
			this.centeredRadio = new System.Windows.Forms.RadioButton();
			this.tiledRadio = new System.Windows.Forms.RadioButton();
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
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.okButton.Location = new System.Drawing.Point(190, 267);
			this.okButton.Margin = new System.Windows.Forms.Padding(0);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 21;
			this.okButton.Text = "&OK";
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.fitRadio);
			this.groupBox1.Controls.Add(this.fillRadio);
			this.groupBox1.Controls.Add(this.stretchedRadio);
			this.groupBox1.Controls.Add(this.centeredRadio);
			this.groupBox1.Controls.Add(this.tiledRadio);
			this.groupBox1.Location = new System.Drawing.Point(9, 109);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(256, 150);
			this.groupBox1.TabIndex = 31;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Choose a fit";
			// 
			// fitRadio
			// 
			this.fitRadio.AutoSize = true;
			this.fitRadio.Location = new System.Drawing.Point(6, 49);
			this.fitRadio.Name = "fitRadio";
			this.fitRadio.Size = new System.Drawing.Size(36, 17);
			this.fitRadio.TabIndex = 4;
			this.fitRadio.Text = "Fit";
			this.fitRadio.UseVisualStyleBackColor = true;
			// 
			// fillRadio
			// 
			this.fillRadio.AutoSize = true;
			this.fillRadio.Checked = true;
			this.fillRadio.Location = new System.Drawing.Point(6, 26);
			this.fillRadio.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.fillRadio.Name = "fillRadio";
			this.fillRadio.Size = new System.Drawing.Size(37, 17);
			this.fillRadio.TabIndex = 3;
			this.fillRadio.TabStop = true;
			this.fillRadio.Text = "Fill";
			this.fillRadio.UseVisualStyleBackColor = true;
			// 
			// stretchedRadio
			// 
			this.stretchedRadio.AutoSize = true;
			this.stretchedRadio.Location = new System.Drawing.Point(6, 72);
			this.stretchedRadio.Name = "stretchedRadio";
			this.stretchedRadio.Size = new System.Drawing.Size(59, 17);
			this.stretchedRadio.TabIndex = 2;
			this.stretchedRadio.Text = "Stretch";
			this.stretchedRadio.UseVisualStyleBackColor = true;
			// 
			// centeredRadio
			// 
			this.centeredRadio.AutoSize = true;
			this.centeredRadio.Location = new System.Drawing.Point(6, 118);
			this.centeredRadio.Name = "centeredRadio";
			this.centeredRadio.Size = new System.Drawing.Size(56, 17);
			this.centeredRadio.TabIndex = 1;
			this.centeredRadio.Text = "Center";
			this.centeredRadio.UseVisualStyleBackColor = true;
			// 
			// tiledRadio
			// 
			this.tiledRadio.AutoSize = true;
			this.tiledRadio.Location = new System.Drawing.Point(6, 95);
			this.tiledRadio.Name = "tiledRadio";
			this.tiledRadio.Size = new System.Drawing.Size(42, 17);
			this.tiledRadio.TabIndex = 0;
			this.tiledRadio.Text = "Tile";
			this.tiledRadio.UseVisualStyleBackColor = true;
			// 
			// WallpaperForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(274, 299);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.logoPictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "WallpaperForm";
			this.Padding = new System.Windows.Forms.Padding(9);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Set as desktop background";
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton tiledRadio;
		private System.Windows.Forms.RadioButton centeredRadio;
		private System.Windows.Forms.RadioButton stretchedRadio;
		private System.Windows.Forms.RadioButton fitRadio;
		private System.Windows.Forms.RadioButton fillRadio;
	}
}
