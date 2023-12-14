namespace QuickPictureViewerPlus
{
	partial class PrintForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
			this.okButton = new System.Windows.Forms.Button();
			this.setMarginsButton = new System.Windows.Forms.Button();
			this.bottomLabel = new System.Windows.Forms.Label();
			this.rightLabel = new System.Windows.Forms.Label();
			this.topLabel = new System.Windows.Forms.Label();
			this.centerCheckbox = new QuickLibrary.QlibCheckBox();
			this.leftLabel = new System.Windows.Forms.Label();
			this.bottomMarginTextBox = new QuickLibrary.QlibNumeric();
			this.rightMarginTextBox = new QuickLibrary.QlibNumeric();
			this.topMarginTextBox = new QuickLibrary.QlibNumeric();
			this.marginsLabel = new System.Windows.Forms.Label();
			this.leftMarginTextBox = new QuickLibrary.QlibNumeric();
			this.documentLabel = new System.Windows.Forms.Label();
			this.titleTextBox = new QuickLibrary.QlibTextBox();
			this.horizontalCheckBox = new QuickLibrary.QlibCheckBox();
			this.marginsCheckBox = new QuickLibrary.QlibCheckBox();
			this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
			this.closeBtn = new QuickLibrary.QlibTitlebarButton();
			this.infoTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// okButton
			// 
			this.okButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.FlatAppearance.BorderSize = 0;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
			this.okButton.Location = new System.Drawing.Point(314, 290);
			this.okButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(294, 32);
			this.okButton.TabIndex = 10;
			this.okButton.Text = "print";
			this.okButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.okButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.infoTooltip.SetToolTip(this.okButton, "Choose print method");
			this.okButton.UseVisualStyleBackColor = false;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// setMarginsButton
			// 
			this.setMarginsButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.setMarginsButton.FlatAppearance.BorderSize = 0;
			this.setMarginsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.setMarginsButton.Location = new System.Drawing.Point(10, 290);
			this.setMarginsButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.setMarginsButton.Name = "setMarginsButton";
			this.setMarginsButton.Size = new System.Drawing.Size(294, 32);
			this.setMarginsButton.TabIndex = 8;
			this.setMarginsButton.Text = "set margins";
			this.setMarginsButton.UseVisualStyleBackColor = false;
			this.setMarginsButton.EnabledChanged += new System.EventHandler(this.setMarginsButton_EnabledChanged);
			this.setMarginsButton.Click += new System.EventHandler(this.setMarginsButton_Click);
			// 
			// bottomLabel
			// 
			this.bottomLabel.AutoSize = true;
			this.bottomLabel.Location = new System.Drawing.Point(234, 219);
			this.bottomLabel.Margin = new System.Windows.Forms.Padding(0);
			this.bottomLabel.Name = "bottomLabel";
			this.bottomLabel.Size = new System.Drawing.Size(58, 19);
			this.bottomLabel.TabIndex = 43;
			this.bottomLabel.Text = "bottom:";
			// 
			// rightLabel
			// 
			this.rightLabel.AutoSize = true;
			this.rightLabel.Location = new System.Drawing.Point(158, 219);
			this.rightLabel.Margin = new System.Windows.Forms.Padding(0);
			this.rightLabel.Name = "rightLabel";
			this.rightLabel.Size = new System.Drawing.Size(41, 19);
			this.rightLabel.TabIndex = 42;
			this.rightLabel.Text = "right:";
			// 
			// topLabel
			// 
			this.topLabel.AutoSize = true;
			this.topLabel.Location = new System.Drawing.Point(82, 219);
			this.topLabel.Margin = new System.Windows.Forms.Padding(0);
			this.topLabel.Name = "topLabel";
			this.topLabel.Size = new System.Drawing.Size(33, 19);
			this.topLabel.TabIndex = 41;
			this.topLabel.Text = "top:";
			// 
			// centerCheckbox
			// 
			this.centerCheckbox.BackColor = System.Drawing.SystemColors.Control;
			this.centerCheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.centerCheckbox.CausesValidation = false;
			this.centerCheckbox.Checked = true;
			this.centerCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.centerCheckbox.Cursor = System.Windows.Forms.Cursors.Default;
			this.centerCheckbox.DarkMode = false;
			this.centerCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.centerCheckbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.centerCheckbox.ForeColor = System.Drawing.Color.Black;
			this.centerCheckbox.Image = null;
			this.centerCheckbox.Location = new System.Drawing.Point(10, 116);
			this.centerCheckbox.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.centerCheckbox.Name = "centerCheckbox";
			this.centerCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.centerCheckbox.Size = new System.Drawing.Size(294, 32);
			this.centerCheckbox.TabIndex = 2;
			this.centerCheckbox.Text = "center image";
			this.centerCheckbox.UseMnemonic = false;
			this.centerCheckbox.UseVisualStyleBackColor = true;
			this.centerCheckbox.CheckedChanged += new System.EventHandler(this.centerCheckbox_CheckedChanged);
			// 
			// leftLabel
			// 
			this.leftLabel.AutoSize = true;
			this.leftLabel.Location = new System.Drawing.Point(10, 219);
			this.leftLabel.Margin = new System.Windows.Forms.Padding(0);
			this.leftLabel.Name = "leftLabel";
			this.leftLabel.Size = new System.Drawing.Size(31, 19);
			this.leftLabel.TabIndex = 40;
			this.leftLabel.Text = "left:";
			// 
			// bottomMarginTextBox
			// 
			this.bottomMarginTextBox.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.bottomMarginTextBox.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.bottomMarginTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.bottomMarginTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.bottomMarginTextBox.CausesValidation = false;
			this.bottomMarginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bottomMarginTextBox.DarkMode = false;
			this.bottomMarginTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bottomMarginTextBox.ForeColor = System.Drawing.Color.Black;
			this.bottomMarginTextBox.Location = new System.Drawing.Point(238, 248);
			this.bottomMarginTextBox.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.bottomMarginTextBox.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.bottomMarginTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.bottomMarginTextBox.Name = "bottomMarginTextBox";
			this.bottomMarginTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bottomMarginTextBox.Size = new System.Drawing.Size(66, 32);
			this.bottomMarginTextBox.TabIndex = 7;
			this.bottomMarginTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// rightMarginTextBox
			// 
			this.rightMarginTextBox.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.rightMarginTextBox.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.rightMarginTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.rightMarginTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.rightMarginTextBox.CausesValidation = false;
			this.rightMarginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.rightMarginTextBox.DarkMode = false;
			this.rightMarginTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rightMarginTextBox.ForeColor = System.Drawing.Color.Black;
			this.rightMarginTextBox.Location = new System.Drawing.Point(162, 248);
			this.rightMarginTextBox.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.rightMarginTextBox.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.rightMarginTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.rightMarginTextBox.Name = "rightMarginTextBox";
			this.rightMarginTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.rightMarginTextBox.Size = new System.Drawing.Size(66, 32);
			this.rightMarginTextBox.TabIndex = 6;
			this.rightMarginTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// topMarginTextBox
			// 
			this.topMarginTextBox.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.topMarginTextBox.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.topMarginTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.topMarginTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.topMarginTextBox.CausesValidation = false;
			this.topMarginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.topMarginTextBox.DarkMode = false;
			this.topMarginTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.topMarginTextBox.ForeColor = System.Drawing.Color.Black;
			this.topMarginTextBox.Location = new System.Drawing.Point(86, 248);
			this.topMarginTextBox.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.topMarginTextBox.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.topMarginTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.topMarginTextBox.Name = "topMarginTextBox";
			this.topMarginTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.topMarginTextBox.Size = new System.Drawing.Size(66, 32);
			this.topMarginTextBox.TabIndex = 5;
			this.topMarginTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// marginsLabel
			// 
			this.marginsLabel.AutoSize = true;
			this.marginsLabel.Location = new System.Drawing.Point(10, 190);
			this.marginsLabel.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
			this.marginsLabel.Name = "marginsLabel";
			this.marginsLabel.Size = new System.Drawing.Size(61, 19);
			this.marginsLabel.TabIndex = 36;
			this.marginsLabel.Text = "margins:";
			// 
			// leftMarginTextBox
			// 
			this.leftMarginTextBox.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.leftMarginTextBox.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.leftMarginTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.leftMarginTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.leftMarginTextBox.CausesValidation = false;
			this.leftMarginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.leftMarginTextBox.DarkMode = false;
			this.leftMarginTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.leftMarginTextBox.ForeColor = System.Drawing.Color.Black;
			this.leftMarginTextBox.Location = new System.Drawing.Point(10, 248);
			this.leftMarginTextBox.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.leftMarginTextBox.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.leftMarginTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.leftMarginTextBox.Name = "leftMarginTextBox";
			this.leftMarginTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.leftMarginTextBox.Size = new System.Drawing.Size(66, 32);
			this.leftMarginTextBox.TabIndex = 4;
			this.leftMarginTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// documentLabel
			// 
			this.documentLabel.Location = new System.Drawing.Point(10, 49);
			this.documentLabel.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
			this.documentLabel.Name = "documentLabel";
			this.documentLabel.Size = new System.Drawing.Size(84, 19);
			this.documentLabel.TabIndex = 34;
			this.documentLabel.Text = "title:";
			this.documentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// titleTextBox
			// 
			this.titleTextBox.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.titleTextBox.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.titleTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.titleTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.titleTextBox.CausesValidation = false;
			this.titleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.titleTextBox.DarkMode = false;
			this.titleTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.titleTextBox.ForeColor = System.Drawing.Color.Black;
			this.titleTextBox.Location = new System.Drawing.Point(104, 42);
			this.titleTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.ReadOnly = false;
			this.titleTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.titleTextBox.Size = new System.Drawing.Size(200, 32);
			this.titleTextBox.TabIndex = 0;
			this.titleTextBox.WordWrap = true;
			// 
			// horizontalCheckBox
			// 
			this.horizontalCheckBox.BackColor = System.Drawing.SystemColors.Control;
			this.horizontalCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.horizontalCheckBox.CausesValidation = false;
			this.horizontalCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
			this.horizontalCheckBox.DarkMode = false;
			this.horizontalCheckBox.FlatAppearance.BorderSize = 0;
			this.horizontalCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.horizontalCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.horizontalCheckBox.ForeColor = System.Drawing.Color.Black;
			this.horizontalCheckBox.Image = null;
			this.horizontalCheckBox.Location = new System.Drawing.Point(10, 84);
			this.horizontalCheckBox.Margin = new System.Windows.Forms.Padding(0);
			this.horizontalCheckBox.Name = "horizontalCheckBox";
			this.horizontalCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.horizontalCheckBox.Size = new System.Drawing.Size(294, 32);
			this.horizontalCheckBox.TabIndex = 1;
			this.horizontalCheckBox.Text = "landscape";
			this.horizontalCheckBox.UseMnemonic = false;
			this.horizontalCheckBox.UseVisualStyleBackColor = true;
			this.horizontalCheckBox.CheckedChanged += new System.EventHandler(this.horizontalCheckBox_CheckedChanged);
			// 
			// marginsCheckBox
			// 
			this.marginsCheckBox.BackColor = System.Drawing.SystemColors.Control;
			this.marginsCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.marginsCheckBox.CausesValidation = false;
			this.marginsCheckBox.Checked = true;
			this.marginsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.marginsCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
			this.marginsCheckBox.DarkMode = false;
			this.marginsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.marginsCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.marginsCheckBox.ForeColor = System.Drawing.Color.Black;
			this.marginsCheckBox.Image = null;
			this.marginsCheckBox.Location = new System.Drawing.Point(10, 148);
			this.marginsCheckBox.Margin = new System.Windows.Forms.Padding(0);
			this.marginsCheckBox.Name = "marginsCheckBox";
			this.marginsCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.marginsCheckBox.Size = new System.Drawing.Size(294, 32);
			this.marginsCheckBox.TabIndex = 3;
			this.marginsCheckBox.Text = "margin bounds";
			this.marginsCheckBox.UseMnemonic = false;
			this.marginsCheckBox.UseVisualStyleBackColor = true;
			this.marginsCheckBox.CheckedChanged += new System.EventHandler(this.marginsCheckBox_CheckedChanged);
			// 
			// printPreviewControl1
			// 
			this.printPreviewControl1.BackColor = System.Drawing.SystemColors.Control;
			this.printPreviewControl1.Location = new System.Drawing.Point(308, 36);
			this.printPreviewControl1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.printPreviewControl1.Name = "printPreviewControl1";
			this.printPreviewControl1.Size = new System.Drawing.Size(309, 252);
			this.printPreviewControl1.TabIndex = 9;
			this.printPreviewControl1.TabStop = false;
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
			this.closeBtn.Location = new System.Drawing.Point(586, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 11;
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// PrintForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.ClientSize = new System.Drawing.Size(618, 332);
			this.Controls.Add(this.closeBtn);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.setMarginsButton);
			this.Controls.Add(this.bottomLabel);
			this.Controls.Add(this.printPreviewControl1);
			this.Controls.Add(this.rightLabel);
			this.Controls.Add(this.topLabel);
			this.Controls.Add(this.leftLabel);
			this.Controls.Add(this.centerCheckbox);
			this.Controls.Add(this.bottomMarginTextBox);
			this.Controls.Add(this.titleTextBox);
			this.Controls.Add(this.rightMarginTextBox);
			this.Controls.Add(this.topMarginTextBox);
			this.Controls.Add(this.documentLabel);
			this.Controls.Add(this.marginsLabel);
			this.Controls.Add(this.horizontalCheckBox);
			this.Controls.Add(this.leftMarginTextBox);
			this.Controls.Add(this.marginsCheckBox);
			this.Draggable = true;
			this.EscToClose = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PrintForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "PrintForm";
			this.Load += new System.EventHandler(this.PrintForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
		private QuickLibrary.QlibCheckBox marginsCheckBox;
		private QuickLibrary.QlibCheckBox horizontalCheckBox;
		private QuickLibrary.QlibCheckBox centerCheckbox;
		private QuickLibrary.QlibTextBox titleTextBox;
		private System.Windows.Forms.Label documentLabel;
		private System.Windows.Forms.Label marginsLabel;
		private QuickLibrary.QlibNumeric leftMarginTextBox;
		private QuickLibrary.QlibNumeric bottomMarginTextBox;
		private QuickLibrary.QlibNumeric rightMarginTextBox;
		private QuickLibrary.QlibNumeric topMarginTextBox;
		private System.Windows.Forms.Label leftLabel;
		private System.Windows.Forms.Label bottomLabel;
		private System.Windows.Forms.Label rightLabel;
		private System.Windows.Forms.Label topLabel;
		private System.Windows.Forms.Button setMarginsButton;
		private System.Windows.Forms.ToolTip infoTooltip;
		private QuickLibrary.QlibTitlebarButton closeBtn;
	}
}
