namespace QuickPictureViewerPlus
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
			this.widthNumeric = new QuickLibrary.QlibNumeric();
			this.heightNumeric = new QuickLibrary.QlibNumeric();
			this.aspectRatioCheckbox = new QuickLibrary.QlibCheckBox();
			this.size128Button = new System.Windows.Forms.Button();
			this.size64Button = new System.Windows.Forms.Button();
			this.defaultSizeButton = new System.Windows.Forms.Button();
			this.size256Button = new System.Windows.Forms.Button();
			this.presetsLabel = new System.Windows.Forms.Label();
			this.size512Button = new System.Windows.Forms.Button();
			this.closeBtn = new QuickLibrary.QlibTitlebarButton();
			this.size32Button = new System.Windows.Forms.Button();
			this.size16Button = new System.Windows.Forms.Button();
			this.autoSizeBtn = new System.Windows.Forms.Button();
			this.infoTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// okButton
			// 
			this.okButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.okButton.FlatAppearance.BorderSize = 0;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
			this.okButton.Location = new System.Drawing.Point(10, 301);
			this.okButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(236, 32);
			this.okButton.TabIndex = 11;
			this.okButton.Text = " resize svg";
			this.okButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.okButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.okButton.UseVisualStyleBackColor = false;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// widthLabel
			// 
			this.widthLabel.AutoSize = true;
			this.widthLabel.Location = new System.Drawing.Point(10, 230);
			this.widthLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.widthLabel.Name = "widthLabel";
			this.widthLabel.Size = new System.Drawing.Size(46, 19);
			this.widthLabel.TabIndex = 3;
			this.widthLabel.Text = "width:";
			// 
			// heightLabel
			// 
			this.heightLabel.AutoSize = true;
			this.heightLabel.Location = new System.Drawing.Point(129, 230);
			this.heightLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.heightLabel.Name = "heightLabel";
			this.heightLabel.Size = new System.Drawing.Size(51, 19);
			this.heightLabel.TabIndex = 4;
			this.heightLabel.Text = "height:";
			// 
			// widthNumeric
			// 
			this.widthNumeric.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.widthNumeric.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.widthNumeric.BackColor = System.Drawing.SystemColors.ControlLight;
			this.widthNumeric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.widthNumeric.CausesValidation = false;
			this.widthNumeric.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.widthNumeric.DarkMode = false;
			this.widthNumeric.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.widthNumeric.ForeColor = System.Drawing.Color.Black;
			this.widthNumeric.Location = new System.Drawing.Point(10, 259);
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
			this.widthNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.widthNumeric.Size = new System.Drawing.Size(113, 32);
			this.widthNumeric.TabIndex = 9;
			this.widthNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.widthNumeric.ValueChanged += new System.EventHandler(this.widthNumeric_ValueChanged);
			// 
			// heightNumeric
			// 
			this.heightNumeric.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.heightNumeric.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.heightNumeric.BackColor = System.Drawing.SystemColors.ControlLight;
			this.heightNumeric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.heightNumeric.CausesValidation = false;
			this.heightNumeric.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.heightNumeric.DarkMode = false;
			this.heightNumeric.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.heightNumeric.ForeColor = System.Drawing.Color.Black;
			this.heightNumeric.Location = new System.Drawing.Point(133, 259);
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
			this.heightNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.heightNumeric.Size = new System.Drawing.Size(113, 32);
			this.heightNumeric.TabIndex = 10;
			this.heightNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.heightNumeric.ValueChanged += new System.EventHandler(this.heightNumeric_ValueChanged);
			// 
			// aspectRatioCheckbox
			// 
			this.aspectRatioCheckbox.BackColor = System.Drawing.SystemColors.Control;
			this.aspectRatioCheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.aspectRatioCheckbox.CausesValidation = false;
			this.aspectRatioCheckbox.Checked = true;
			this.aspectRatioCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.aspectRatioCheckbox.Cursor = System.Windows.Forms.Cursors.Default;
			this.aspectRatioCheckbox.DarkMode = false;
			this.aspectRatioCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.aspectRatioCheckbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.aspectRatioCheckbox.ForeColor = System.Drawing.Color.Black;
			this.aspectRatioCheckbox.Image = null;
			this.aspectRatioCheckbox.Location = new System.Drawing.Point(10, 197);
			this.aspectRatioCheckbox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.aspectRatioCheckbox.Name = "aspectRatioCheckbox";
			this.aspectRatioCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.aspectRatioCheckbox.Size = new System.Drawing.Size(236, 23);
			this.aspectRatioCheckbox.TabIndex = 8;
			this.aspectRatioCheckbox.Text = "maintain aspect ratio";
			this.aspectRatioCheckbox.UseMnemonic = false;
			this.aspectRatioCheckbox.UseVisualStyleBackColor = true;
			this.aspectRatioCheckbox.CheckedChanged += new System.EventHandler(this.aspectRatioCheckbox_CheckedChanged);
			// 
			// size128Button
			// 
			this.size128Button.BackColor = System.Drawing.SystemColors.ControlLight;
			this.size128Button.FlatAppearance.BorderSize = 0;
			this.size128Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.size128Button.Location = new System.Drawing.Point(10, 155);
			this.size128Button.Margin = new System.Windows.Forms.Padding(0);
			this.size128Button.Name = "size128Button";
			this.size128Button.Size = new System.Drawing.Size(72, 32);
			this.size128Button.TabIndex = 5;
			this.size128Button.Text = "128 px";
			this.size128Button.UseVisualStyleBackColor = false;
			this.size128Button.Click += new System.EventHandler(this.size128Button_Click);
			// 
			// size64Button
			// 
			this.size64Button.BackColor = System.Drawing.SystemColors.ControlLight;
			this.size64Button.FlatAppearance.BorderSize = 0;
			this.size64Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.size64Button.Location = new System.Drawing.Point(174, 113);
			this.size64Button.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.size64Button.Name = "size64Button";
			this.size64Button.Size = new System.Drawing.Size(72, 32);
			this.size64Button.TabIndex = 4;
			this.size64Button.Text = "64 px";
			this.size64Button.UseVisualStyleBackColor = false;
			this.size64Button.Click += new System.EventHandler(this.size64Button_Click);
			// 
			// defaultSizeButton
			// 
			this.defaultSizeButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.defaultSizeButton.FlatAppearance.BorderSize = 0;
			this.defaultSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.defaultSizeButton.Location = new System.Drawing.Point(10, 71);
			this.defaultSizeButton.Margin = new System.Windows.Forms.Padding(0);
			this.defaultSizeButton.Name = "defaultSizeButton";
			this.defaultSizeButton.Size = new System.Drawing.Size(113, 32);
			this.defaultSizeButton.TabIndex = 0;
			this.defaultSizeButton.Text = "original size";
			this.defaultSizeButton.UseVisualStyleBackColor = false;
			this.defaultSizeButton.Click += new System.EventHandler(this.defaultSizeButton_Click);
			// 
			// size256Button
			// 
			this.size256Button.BackColor = System.Drawing.SystemColors.ControlLight;
			this.size256Button.FlatAppearance.BorderSize = 0;
			this.size256Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.size256Button.Location = new System.Drawing.Point(92, 155);
			this.size256Button.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.size256Button.Name = "size256Button";
			this.size256Button.Size = new System.Drawing.Size(72, 32);
			this.size256Button.TabIndex = 6;
			this.size256Button.Text = "256 px";
			this.size256Button.UseVisualStyleBackColor = false;
			this.size256Button.Click += new System.EventHandler(this.size256Button_Click);
			// 
			// presetsLabel
			// 
			this.presetsLabel.AutoSize = true;
			this.presetsLabel.Location = new System.Drawing.Point(10, 42);
			this.presetsLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.presetsLabel.Name = "presetsLabel";
			this.presetsLabel.Size = new System.Drawing.Size(56, 19);
			this.presetsLabel.TabIndex = 35;
			this.presetsLabel.Text = "presets:";
			// 
			// size512Button
			// 
			this.size512Button.BackColor = System.Drawing.SystemColors.ControlLight;
			this.size512Button.FlatAppearance.BorderSize = 0;
			this.size512Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.size512Button.Location = new System.Drawing.Point(174, 155);
			this.size512Button.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.size512Button.Name = "size512Button";
			this.size512Button.Size = new System.Drawing.Size(72, 32);
			this.size512Button.TabIndex = 7;
			this.size512Button.Text = "512 px";
			this.size512Button.UseVisualStyleBackColor = false;
			this.size512Button.Click += new System.EventHandler(this.size512Button_Click);
			// 
			// closeBtn
			// 
			this.closeBtn.DarkImage = global::QuickPictureViewerPlus.Properties.Resources.black_close;
			this.closeBtn.DarkMode = false;
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
			this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.ForeColor = System.Drawing.Color.Black;
			this.closeBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_close;
			this.closeBtn.IsRed = true;
			this.closeBtn.LightImage = global::QuickPictureViewerPlus.Properties.Resources.white_close;
			this.closeBtn.Location = new System.Drawing.Point(224, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 12;
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// size32Button
			// 
			this.size32Button.BackColor = System.Drawing.SystemColors.ControlLight;
			this.size32Button.FlatAppearance.BorderSize = 0;
			this.size32Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.size32Button.Location = new System.Drawing.Point(92, 113);
			this.size32Button.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
			this.size32Button.Name = "size32Button";
			this.size32Button.Size = new System.Drawing.Size(72, 32);
			this.size32Button.TabIndex = 3;
			this.size32Button.Text = "32 px";
			this.size32Button.UseVisualStyleBackColor = false;
			this.size32Button.Click += new System.EventHandler(this.size32Button_Click);
			// 
			// size16Button
			// 
			this.size16Button.BackColor = System.Drawing.SystemColors.ControlLight;
			this.size16Button.FlatAppearance.BorderSize = 0;
			this.size16Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.size16Button.Location = new System.Drawing.Point(10, 113);
			this.size16Button.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.size16Button.Name = "size16Button";
			this.size16Button.Size = new System.Drawing.Size(72, 32);
			this.size16Button.TabIndex = 2;
			this.size16Button.Text = "16 px";
			this.size16Button.UseVisualStyleBackColor = false;
			this.size16Button.Click += new System.EventHandler(this.size16Button_Click);
			// 
			// autoSizeBtn
			// 
			this.autoSizeBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.autoSizeBtn.FlatAppearance.BorderSize = 0;
			this.autoSizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.autoSizeBtn.Location = new System.Drawing.Point(133, 71);
			this.autoSizeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.autoSizeBtn.Name = "autoSizeBtn";
			this.autoSizeBtn.Size = new System.Drawing.Size(113, 32);
			this.autoSizeBtn.TabIndex = 1;
			this.autoSizeBtn.Text = "auto size";
			this.autoSizeBtn.UseVisualStyleBackColor = false;
			this.autoSizeBtn.Click += new System.EventHandler(this.autoSizeBtn_Click);
			// 
			// SvgOpsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.ClientSize = new System.Drawing.Size(256, 343);
			this.Controls.Add(this.closeBtn);
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
			this.Controls.Add(this.size64Button);
			this.Controls.Add(this.defaultSizeButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.presetsLabel);
			this.Draggable = true;
			this.EscToClose = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SvgOpsForm";
			this.ShowInTaskbar = false;
			this.ShowTitle = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SvgOpsForm";
			this.Load += new System.EventHandler(this.SvgOpsForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Label widthLabel;
		private System.Windows.Forms.Label heightLabel;
		private QuickLibrary.QlibNumeric widthNumeric;
		private QuickLibrary.QlibNumeric heightNumeric;
		private QuickLibrary.QlibCheckBox aspectRatioCheckbox;
		private System.Windows.Forms.Button size512Button;
		private System.Windows.Forms.Label presetsLabel;
		private System.Windows.Forms.Button size256Button;
		private System.Windows.Forms.Button defaultSizeButton;
		private System.Windows.Forms.Button size128Button;
		private System.Windows.Forms.Button size64Button;
		private System.Windows.Forms.Button size32Button;
		private System.Windows.Forms.Button size16Button;
		private QuickLibrary.QlibTitlebarButton closeBtn;
		private System.Windows.Forms.Button autoSizeBtn;
		private System.Windows.Forms.ToolTip infoTooltip;
	}
}