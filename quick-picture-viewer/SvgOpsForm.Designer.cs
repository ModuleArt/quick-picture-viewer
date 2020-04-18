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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SvgOpsForm));
			this.okButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.widthNumeric = new System.Windows.Forms.NumericUpDown();
			this.heightNumeric = new System.Windows.Forms.NumericUpDown();
			this.aspectRatioCheckbox = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.size128Button = new System.Windows.Forms.Button();
			this.size64Button = new System.Windows.Forms.Button();
			this.defaultSizeButton = new System.Windows.Forms.Button();
			this.size256Button = new System.Windows.Forms.Button();
			this.presetsLabel = new System.Windows.Forms.Label();
			this.size1024Button = new System.Windows.Forms.Button();
			this.size512Button = new System.Windows.Forms.Button();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.heightNumeric)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.okButton.FlatAppearance.BorderSize = 0;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okButton.Location = new System.Drawing.Point(9, 294);
			this.okButton.Margin = new System.Windows.Forms.Padding(0);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(256, 23);
			this.okButton.TabIndex = 8;
			this.okButton.Text = "Resize SVG";
			this.okButton.UseVisualStyleBackColor = false;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 147);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Width:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(137, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Height:";
			// 
			// widthNumeric
			// 
			this.widthNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.widthNumeric.Location = new System.Drawing.Point(55, 145);
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
			this.widthNumeric.Size = new System.Drawing.Size(60, 23);
			this.widthNumeric.TabIndex = 5;
			this.widthNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.widthNumeric.ValueChanged += new System.EventHandler(this.widthNumeric_ValueChanged);
			// 
			// heightNumeric
			// 
			this.heightNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.heightNumeric.Location = new System.Drawing.Point(189, 145);
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
			this.heightNumeric.Size = new System.Drawing.Size(60, 23);
			this.heightNumeric.TabIndex = 7;
			this.heightNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.heightNumeric.ValueChanged += new System.EventHandler(this.heightNumeric_ValueChanged);
			// 
			// aspectRatioCheckbox
			// 
			this.aspectRatioCheckbox.AutoSize = true;
			this.aspectRatioCheckbox.Checked = true;
			this.aspectRatioCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.aspectRatioCheckbox.Location = new System.Drawing.Point(6, 115);
			this.aspectRatioCheckbox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.aspectRatioCheckbox.Name = "aspectRatioCheckbox";
			this.aspectRatioCheckbox.Size = new System.Drawing.Size(137, 19);
			this.aspectRatioCheckbox.TabIndex = 6;
			this.aspectRatioCheckbox.Text = "Maintain aspect ratio";
			this.aspectRatioCheckbox.UseVisualStyleBackColor = true;
			this.aspectRatioCheckbox.CheckedChanged += new System.EventHandler(this.aspectRatioCheckbox_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.size128Button);
			this.groupBox1.Controls.Add(this.size64Button);
			this.groupBox1.Controls.Add(this.defaultSizeButton);
			this.groupBox1.Controls.Add(this.size256Button);
			this.groupBox1.Controls.Add(this.presetsLabel);
			this.groupBox1.Controls.Add(this.size1024Button);
			this.groupBox1.Controls.Add(this.size512Button);
			this.groupBox1.Controls.Add(this.aspectRatioCheckbox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.heightNumeric);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.widthNumeric);
			this.groupBox1.Location = new System.Drawing.Point(9, 99);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(256, 187);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rasterize vector";
			// 
			// size128Button
			// 
			this.size128Button.BackColor = System.Drawing.SystemColors.ControlLight;
			this.size128Button.FlatAppearance.BorderSize = 0;
			this.size128Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.size128Button.Location = new System.Drawing.Point(172, 50);
			this.size128Button.Name = "size128Button";
			this.size128Button.Size = new System.Drawing.Size(77, 23);
			this.size128Button.TabIndex = 2;
			this.size128Button.Text = "128 px";
			this.size128Button.UseVisualStyleBackColor = false;
			this.size128Button.Click += new System.EventHandler(this.size128Button_Click);
			// 
			// size64Button
			// 
			this.size64Button.BackColor = System.Drawing.SystemColors.ControlLight;
			this.size64Button.FlatAppearance.BorderSize = 0;
			this.size64Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.size64Button.Location = new System.Drawing.Point(89, 50);
			this.size64Button.Name = "size64Button";
			this.size64Button.Size = new System.Drawing.Size(77, 23);
			this.size64Button.TabIndex = 1;
			this.size64Button.Text = "64 px";
			this.size64Button.UseVisualStyleBackColor = false;
			this.size64Button.Click += new System.EventHandler(this.size64Button_Click);
			// 
			// defaultSizeButton
			// 
			this.defaultSizeButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.defaultSizeButton.FlatAppearance.BorderSize = 0;
			this.defaultSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.defaultSizeButton.Location = new System.Drawing.Point(6, 50);
			this.defaultSizeButton.Name = "defaultSizeButton";
			this.defaultSizeButton.Size = new System.Drawing.Size(77, 23);
			this.defaultSizeButton.TabIndex = 0;
			this.defaultSizeButton.Text = "Default size";
			this.defaultSizeButton.UseVisualStyleBackColor = false;
			this.defaultSizeButton.Click += new System.EventHandler(this.defaultSizeButton_Click);
			// 
			// size256Button
			// 
			this.size256Button.BackColor = System.Drawing.SystemColors.ControlLight;
			this.size256Button.FlatAppearance.BorderSize = 0;
			this.size256Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.size256Button.Location = new System.Drawing.Point(6, 79);
			this.size256Button.Name = "size256Button";
			this.size256Button.Size = new System.Drawing.Size(77, 23);
			this.size256Button.TabIndex = 3;
			this.size256Button.Text = "256 px";
			this.size256Button.UseVisualStyleBackColor = false;
			this.size256Button.Click += new System.EventHandler(this.size256Button_Click);
			// 
			// presetsLabel
			// 
			this.presetsLabel.AutoSize = true;
			this.presetsLabel.Location = new System.Drawing.Point(7, 29);
			this.presetsLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.presetsLabel.Name = "presetsLabel";
			this.presetsLabel.Size = new System.Drawing.Size(47, 15);
			this.presetsLabel.TabIndex = 35;
			this.presetsLabel.Text = "Presets:";
			// 
			// size1024Button
			// 
			this.size1024Button.BackColor = System.Drawing.SystemColors.ControlLight;
			this.size1024Button.FlatAppearance.BorderSize = 0;
			this.size1024Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.size1024Button.Location = new System.Drawing.Point(172, 79);
			this.size1024Button.Name = "size1024Button";
			this.size1024Button.Size = new System.Drawing.Size(77, 23);
			this.size1024Button.TabIndex = 5;
			this.size1024Button.Text = "1024 px";
			this.size1024Button.UseVisualStyleBackColor = false;
			this.size1024Button.Click += new System.EventHandler(this.size1024Button_Click);
			// 
			// size512Button
			// 
			this.size512Button.BackColor = System.Drawing.SystemColors.ControlLight;
			this.size512Button.FlatAppearance.BorderSize = 0;
			this.size512Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.size512Button.Location = new System.Drawing.Point(89, 79);
			this.size512Button.Name = "size512Button";
			this.size512Button.Size = new System.Drawing.Size(77, 23);
			this.size512Button.TabIndex = 4;
			this.size512Button.Text = "512 px";
			this.size512Button.UseVisualStyleBackColor = false;
			this.size512Button.Click += new System.EventHandler(this.size512Button_Click);
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(9, 9);
			this.logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(255, 80);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.logoPictureBox.TabIndex = 13;
			this.logoPictureBox.TabStop = false;
			// 
			// SvgOpsForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(274, 326);
			this.Controls.Add(this.logoPictureBox);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.okButton);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SvgOpsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SVG options";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SvgOpsForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.heightNumeric)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown widthNumeric;
		private System.Windows.Forms.NumericUpDown heightNumeric;
		private System.Windows.Forms.CheckBox aspectRatioCheckbox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button size512Button;
		private System.Windows.Forms.Button size1024Button;
		private System.Windows.Forms.Label presetsLabel;
		private System.Windows.Forms.Button size256Button;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Button defaultSizeButton;
		private System.Windows.Forms.Button size128Button;
		private System.Windows.Forms.Button size64Button;
	}
}