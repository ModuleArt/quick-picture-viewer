namespace quick_picture_viewer
{
	partial class SvgOpsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SvgOpsForm));
			this.okButton = new System.Windows.Forms.Button();
			this.widthLabel = new System.Windows.Forms.Label();
			this.heightLabel = new System.Windows.Forms.Label();
			this.widthNumeric = new QuickLibrary.QlibNumericBox();
			this.heightNumeric = new QuickLibrary.QlibNumericBox();
			this.aspectRatioCheckbox = new QuickLibrary.QlibCheckBox();
			this.size128Button = new System.Windows.Forms.Button();
			this.size64Button = new System.Windows.Forms.Button();
			this.defaultSizeButton = new System.Windows.Forms.Button();
			this.size256Button = new System.Windows.Forms.Button();
			this.presetsLabel = new System.Windows.Forms.Label();
			this.size512Button = new System.Windows.Forms.Button();
			this.titlePanel = new System.Windows.Forms.Panel();
			this.closeBtn = new QuickLibrary.QlibTitlebarButton();
			this.titleLabel = new System.Windows.Forms.Label();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.size32Button = new System.Windows.Forms.Button();
			this.size16Button = new System.Windows.Forms.Button();
			this.autoSizeBtn = new System.Windows.Forms.Button();
			this.infoTooltip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.heightNumeric)).BeginInit();
			this.titlePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// okButton
			// 
			this.okButton.BackColor = System.Drawing.SystemColors.Control;
			this.okButton.FlatAppearance.BorderSize = 0;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
			this.okButton.Location = new System.Drawing.Point(10, 394);
			this.okButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(236, 32);
			this.okButton.TabIndex = 13;
			this.okButton.Text = " resize svg";
			this.okButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.okButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.okButton.UseVisualStyleBackColor = false;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// widthLabel
			// 
			this.widthLabel.AutoSize = true;
			this.widthLabel.Location = new System.Drawing.Point(10, 330);
			this.widthLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.widthLabel.Name = "widthLabel";
			this.widthLabel.Size = new System.Drawing.Size(46, 19);
			this.widthLabel.TabIndex = 3;
			this.widthLabel.Text = "width:";
			// 
			// heightLabel
			// 
			this.heightLabel.AutoSize = true;
			this.heightLabel.Location = new System.Drawing.Point(129, 330);
			this.heightLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.heightLabel.Name = "heightLabel";
			this.heightLabel.Size = new System.Drawing.Size(51, 19);
			this.heightLabel.TabIndex = 4;
			this.heightLabel.Text = "height:";
			// 
			// widthNumeric
			// 
			this.widthNumeric.BackColor = System.Drawing.SystemColors.Control;
			this.widthNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.widthNumeric.Location = new System.Drawing.Point(10, 359);
			this.widthNumeric.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.widthNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.widthNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.widthNumeric.Name = "widthNumeric";
			this.widthNumeric.Size = new System.Drawing.Size(113, 25);
			this.widthNumeric.TabIndex = 11;
			this.widthNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.widthNumeric.ValueChanged += new System.EventHandler(this.widthNumeric_ValueChanged);
			// 
			// heightNumeric
			// 
			this.heightNumeric.BackColor = System.Drawing.SystemColors.Control;
			this.heightNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.heightNumeric.Location = new System.Drawing.Point(133, 359);
			this.heightNumeric.Margin = new System.Windows.Forms.Padding(0);
			this.heightNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.heightNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.heightNumeric.Name = "heightNumeric";
			this.heightNumeric.Size = new System.Drawing.Size(113, 25);
			this.heightNumeric.TabIndex = 12;
			this.heightNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.heightNumeric.ValueChanged += new System.EventHandler(this.heightNumeric_ValueChanged);
			// 
			// aspectRatioCheckbox
			// 
			this.aspectRatioCheckbox.Checked = true;
			this.aspectRatioCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.aspectRatioCheckbox.Location = new System.Drawing.Point(10, 297);
			this.aspectRatioCheckbox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.aspectRatioCheckbox.Name = "aspectRatioCheckbox";
			this.aspectRatioCheckbox.Size = new System.Drawing.Size(236, 23);
			this.aspectRatioCheckbox.TabIndex = 10;
			this.aspectRatioCheckbox.Text = "maintain aspect ratio";
			this.aspectRatioCheckbox.UseVisualStyleBackColor = true;
			this.aspectRatioCheckbox.CheckedChanged += new System.EventHandler(this.aspectRatioCheckbox_CheckedChanged);
			// 
			// size128Button
			// 
			this.size128Button.BackColor = System.Drawing.SystemColors.Control;
			this.size128Button.FlatAppearance.BorderSize = 0;
			this.size128Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.size128Button.Location = new System.Drawing.Point(10, 255);
			this.size128Button.Margin = new System.Windows.Forms.Padding(0);
			this.size128Button.Name = "size128Button";
			this.size128Button.Size = new System.Drawing.Size(72, 32);
			this.size128Button.TabIndex = 6;
			this.size128Button.Text = "128 px";
			this.size128Button.UseVisualStyleBackColor = false;
			this.size128Button.Click += new System.EventHandler(this.size128Button_Click);
			// 
			// size64Button
			// 
			this.size64Button.BackColor = System.Drawing.SystemColors.Control;
			this.size64Button.FlatAppearance.BorderSize = 0;
			this.size64Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.size64Button.Location = new System.Drawing.Point(174, 213);
			this.size64Button.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.size64Button.Name = "size64Button";
			this.size64Button.Size = new System.Drawing.Size(72, 32);
			this.size64Button.TabIndex = 5;
			this.size64Button.Text = "64 px";
			this.size64Button.UseVisualStyleBackColor = false;
			this.size64Button.Click += new System.EventHandler(this.size64Button_Click);
			// 
			// defaultSizeButton
			// 
			this.defaultSizeButton.BackColor = System.Drawing.SystemColors.Control;
			this.defaultSizeButton.FlatAppearance.BorderSize = 0;
			this.defaultSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.defaultSizeButton.Location = new System.Drawing.Point(10, 171);
			this.defaultSizeButton.Margin = new System.Windows.Forms.Padding(0);
			this.defaultSizeButton.Name = "defaultSizeButton";
			this.defaultSizeButton.Size = new System.Drawing.Size(113, 32);
			this.defaultSizeButton.TabIndex = 2;
			this.defaultSizeButton.Text = "original size";
			this.defaultSizeButton.UseVisualStyleBackColor = false;
			this.defaultSizeButton.Click += new System.EventHandler(this.defaultSizeButton_Click);
			// 
			// size256Button
			// 
			this.size256Button.BackColor = System.Drawing.SystemColors.Control;
			this.size256Button.FlatAppearance.BorderSize = 0;
			this.size256Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.size256Button.Location = new System.Drawing.Point(92, 255);
			this.size256Button.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.size256Button.Name = "size256Button";
			this.size256Button.Size = new System.Drawing.Size(72, 32);
			this.size256Button.TabIndex = 7;
			this.size256Button.Text = "256 px";
			this.size256Button.UseVisualStyleBackColor = false;
			this.size256Button.Click += new System.EventHandler(this.size256Button_Click);
			// 
			// presetsLabel
			// 
			this.presetsLabel.AutoSize = true;
			this.presetsLabel.Location = new System.Drawing.Point(10, 142);
			this.presetsLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.presetsLabel.Name = "presetsLabel";
			this.presetsLabel.Size = new System.Drawing.Size(56, 19);
			this.presetsLabel.TabIndex = 35;
			this.presetsLabel.Text = "presets:";
			// 
			// size512Button
			// 
			this.size512Button.BackColor = System.Drawing.SystemColors.Control;
			this.size512Button.FlatAppearance.BorderSize = 0;
			this.size512Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.size512Button.Location = new System.Drawing.Point(174, 255);
			this.size512Button.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.size512Button.Name = "size512Button";
			this.size512Button.Size = new System.Drawing.Size(72, 32);
			this.size512Button.TabIndex = 8;
			this.size512Button.Text = "512 px";
			this.size512Button.UseVisualStyleBackColor = false;
			this.size512Button.Click += new System.EventHandler(this.size512Button_Click);
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
			// closeBtn
			// 
			this.closeBtn.DarkImage = global::quick_picture_viewer.Properties.Resources.black_close;
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.Image = global::quick_picture_viewer.Properties.Resources.black_close;
			this.closeBtn.IsRed = true;
			this.closeBtn.LightImage = global::quick_picture_viewer.Properties.Resources.white_close;
			this.closeBtn.Location = new System.Drawing.Point(224, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 17;
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(9, 7);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(88, 19);
			this.titleLabel.TabIndex = 16;
			this.titleLabel.Text = "SvgOpsForm";
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(0, 32);
			this.logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(256, 100);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.logoPictureBox.TabIndex = 37;
			this.logoPictureBox.TabStop = false;
			// 
			// size32Button
			// 
			this.size32Button.BackColor = System.Drawing.SystemColors.Control;
			this.size32Button.FlatAppearance.BorderSize = 0;
			this.size32Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.size32Button.Location = new System.Drawing.Point(92, 213);
			this.size32Button.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
			this.size32Button.Name = "size32Button";
			this.size32Button.Size = new System.Drawing.Size(72, 32);
			this.size32Button.TabIndex = 4;
			this.size32Button.Text = "32 px";
			this.size32Button.UseVisualStyleBackColor = false;
			this.size32Button.Click += new System.EventHandler(this.size32Button_Click);
			// 
			// size16Button
			// 
			this.size16Button.BackColor = System.Drawing.SystemColors.Control;
			this.size16Button.FlatAppearance.BorderSize = 0;
			this.size16Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.size16Button.Location = new System.Drawing.Point(10, 213);
			this.size16Button.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.size16Button.Name = "size16Button";
			this.size16Button.Size = new System.Drawing.Size(72, 32);
			this.size16Button.TabIndex = 3;
			this.size16Button.Text = "16 px";
			this.size16Button.UseVisualStyleBackColor = false;
			this.size16Button.Click += new System.EventHandler(this.size16Button_Click);
			// 
			// autoSizeBtn
			// 
			this.autoSizeBtn.BackColor = System.Drawing.SystemColors.Control;
			this.autoSizeBtn.FlatAppearance.BorderSize = 0;
			this.autoSizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.autoSizeBtn.Location = new System.Drawing.Point(133, 171);
			this.autoSizeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.autoSizeBtn.Name = "autoSizeBtn";
			this.autoSizeBtn.Size = new System.Drawing.Size(113, 32);
			this.autoSizeBtn.TabIndex = 38;
			this.autoSizeBtn.Text = "auto size";
			this.autoSizeBtn.UseVisualStyleBackColor = false;
			this.autoSizeBtn.Click += new System.EventHandler(this.autoSizeBtn_Click);
			// 
			// SvgOpsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(256, 436);
			this.Controls.Add(this.autoSizeBtn);
			this.Controls.Add(this.size16Button);
			this.Controls.Add(this.heightNumeric);
			this.Controls.Add(this.widthLabel);
			this.Controls.Add(this.heightLabel);
			this.Controls.Add(this.aspectRatioCheckbox);
			this.Controls.Add(this.widthNumeric);
			this.Controls.Add(this.size32Button);
			this.Controls.Add(this.size256Button);
			this.Controls.Add(this.size512Button);
			this.Controls.Add(this.size128Button);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.size64Button);
			this.Controls.Add(this.logoPictureBox);
			this.Controls.Add(this.defaultSizeButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.presetsLabel);
			this.Draggable = true;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SvgOpsForm";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SvgOpsForm";
			this.TitleLabel = this.titleLabel;
			this.Load += new System.EventHandler(this.SvgOpsForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SvgOpsForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.heightNumeric)).EndInit();
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Label widthLabel;
		private System.Windows.Forms.Label heightLabel;
		private QuickLibrary.QlibNumericBox widthNumeric;
		private QuickLibrary.QlibNumericBox heightNumeric;
		private QuickLibrary.QlibCheckBox aspectRatioCheckbox;
		private System.Windows.Forms.Button size512Button;
		private System.Windows.Forms.Label presetsLabel;
		private System.Windows.Forms.Button size256Button;
		private System.Windows.Forms.Button defaultSizeButton;
		private System.Windows.Forms.Button size128Button;
		private System.Windows.Forms.Button size64Button;
		private System.Windows.Forms.Panel titlePanel;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Button size32Button;
		private System.Windows.Forms.Button size16Button;
		private QuickLibrary.QlibTitlebarButton closeBtn;
		private System.Windows.Forms.Button autoSizeBtn;
		private System.Windows.Forms.ToolTip infoTooltip;
	}
}