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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WallpaperForm));
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.okButton = new System.Windows.Forms.Button();
			this.titlePanel = new System.Windows.Forms.Panel();
			this.titleLabel = new System.Windows.Forms.Label();
			this.fitLabel = new System.Windows.Forms.Label();
			this.fitComboBox = new QuickLibrary.QlibComboBox();
			this.aboutTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.closeBtn = new QuickLibrary.QlibCloseButton();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.titlePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(0, 32);
			this.logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(256, 100);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.logoPictureBox.TabIndex = 12;
			this.logoPictureBox.TabStop = false;
			// 
			// okButton
			// 
			this.okButton.BackColor = System.Drawing.SystemColors.Control;
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.FlatAppearance.BorderSize = 0;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
			this.okButton.Location = new System.Drawing.Point(10, 211);
			this.okButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(236, 32);
			this.okButton.TabIndex = 3;
			this.okButton.Text = " Set background";
			this.okButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.okButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.okButton.UseVisualStyleBackColor = false;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// titlePanel
			// 
			this.titlePanel.Controls.Add(this.closeBtn);
			this.titlePanel.Controls.Add(this.titleLabel);
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Margin = new System.Windows.Forms.Padding(0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(256, 32);
			this.titlePanel.TabIndex = 0;
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(10, 7);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(175, 19);
			this.titleLabel.TabIndex = 16;
			this.titleLabel.Text = "Set as desktop background";
			// 
			// fitLabel
			// 
			this.fitLabel.AutoSize = true;
			this.fitLabel.Location = new System.Drawing.Point(10, 141);
			this.fitLabel.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
			this.fitLabel.Name = "fitLabel";
			this.fitLabel.Size = new System.Drawing.Size(85, 19);
			this.fitLabel.TabIndex = 15;
			this.fitLabel.Text = "Choose a fit:";
			// 
			// fitComboBox
			// 
			this.fitComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.fitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.fitComboBox.FormattingEnabled = true;
			this.fitComboBox.ItemHeight = 26;
			this.fitComboBox.Items.AddRange(new object[] {
            "Fill",
            "Fit",
            "Stretch",
            "Tile",
            "Center",
            "Span"});
			this.fitComboBox.Location = new System.Drawing.Point(10, 169);
			this.fitComboBox.Margin = new System.Windows.Forms.Padding(0);
			this.fitComboBox.Name = "fitComboBox";
			this.fitComboBox.Size = new System.Drawing.Size(236, 32);
			this.fitComboBox.TabIndex = 2;
			// 
			// closeBtn
			// 
			this.closeBtn.DarkImage = global::quick_picture_viewer.Properties.Resources.black_close;
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.Image = global::quick_picture_viewer.Properties.Resources.black_close;
			this.closeBtn.LightImage = global::quick_picture_viewer.Properties.Resources.white_close;
			this.closeBtn.Location = new System.Drawing.Point(224, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 17;
			this.aboutTooltip.SetToolTip(this.closeBtn, "Close (Alt+F4)");
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// WallpaperForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(256, 253);
			this.Controls.Add(this.fitLabel);
			this.Controls.Add(this.fitComboBox);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.logoPictureBox);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "WallpaperForm";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Set as desktop background";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WallpaperForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Panel titlePanel;
		private QuickLibrary.QlibComboBox fitComboBox;
		private System.Windows.Forms.Label fitLabel;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.ToolTip aboutTooltip;
		private QuickLibrary.QlibCloseButton closeBtn;
	}
}
