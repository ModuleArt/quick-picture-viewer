namespace quick_picture_viewer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
			this.okButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.setMarginsButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.centerCheckbox = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.bottomMarginTextBox = new System.Windows.Forms.TextBox();
			this.rightMarginTextBox = new System.Windows.Forms.TextBox();
			this.topMarginTextBox = new System.Windows.Forms.TextBox();
			this.marginsLabel = new System.Windows.Forms.Label();
			this.leftMarginTextBox = new System.Windows.Forms.TextBox();
			this.titleLabel = new System.Windows.Forms.Label();
			this.titleTextBox = new System.Windows.Forms.TextBox();
			this.horizontalCheckBox = new System.Windows.Forms.CheckBox();
			this.marginsCheckBox = new System.Windows.Forms.CheckBox();
			this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.FlatAppearance.BorderSize = 0;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
			this.okButton.Location = new System.Drawing.Point(9, 507);
			this.okButton.Margin = new System.Windows.Forms.Padding(0);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(256, 23);
			this.okButton.TabIndex = 21;
			this.okButton.Text = "Print";
			this.okButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.okButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.okButton.UseVisualStyleBackColor = false;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.setMarginsButton);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.centerCheckbox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.bottomMarginTextBox);
			this.groupBox1.Controls.Add(this.rightMarginTextBox);
			this.groupBox1.Controls.Add(this.topMarginTextBox);
			this.groupBox1.Controls.Add(this.marginsLabel);
			this.groupBox1.Controls.Add(this.leftMarginTextBox);
			this.groupBox1.Controls.Add(this.titleLabel);
			this.groupBox1.Controls.Add(this.titleTextBox);
			this.groupBox1.Controls.Add(this.horizontalCheckBox);
			this.groupBox1.Controls.Add(this.marginsCheckBox);
			this.groupBox1.Location = new System.Drawing.Point(9, 274);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(256, 225);
			this.groupBox1.TabIndex = 31;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Options";
			// 
			// setMarginsButton
			// 
			this.setMarginsButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.setMarginsButton.FlatAppearance.BorderSize = 0;
			this.setMarginsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.setMarginsButton.Location = new System.Drawing.Point(105, 183);
			this.setMarginsButton.Name = "setMarginsButton";
			this.setMarginsButton.Size = new System.Drawing.Size(145, 23);
			this.setMarginsButton.TabIndex = 44;
			this.setMarginsButton.Text = "Set margins";
			this.setMarginsButton.UseVisualStyleBackColor = false;
			this.setMarginsButton.Click += new System.EventHandler(this.setMarginsButton_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(226, 136);
			this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(14, 15);
			this.label4.TabIndex = 43;
			this.label4.Text = "B";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(189, 136);
			this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 15);
			this.label3.TabIndex = 42;
			this.label3.Text = "R";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(152, 136);
			this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 15);
			this.label2.TabIndex = 41;
			this.label2.Text = "T";
			// 
			// centerCheckbox
			// 
			this.centerCheckbox.AutoSize = true;
			this.centerCheckbox.Checked = true;
			this.centerCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.centerCheckbox.Location = new System.Drawing.Point(6, 80);
			this.centerCheckbox.Name = "centerCheckbox";
			this.centerCheckbox.Size = new System.Drawing.Size(97, 19);
			this.centerCheckbox.TabIndex = 2;
			this.centerCheckbox.Text = "Center image";
			this.centerCheckbox.UseVisualStyleBackColor = true;
			this.centerCheckbox.CheckedChanged += new System.EventHandler(this.centerCheckbox_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(115, 136);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(13, 15);
			this.label1.TabIndex = 40;
			this.label1.Text = "L";
			// 
			// bottomMarginTextBox
			// 
			this.bottomMarginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.bottomMarginTextBox.Location = new System.Drawing.Point(216, 157);
			this.bottomMarginTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.bottomMarginTextBox.Multiline = true;
			this.bottomMarginTextBox.Name = "bottomMarginTextBox";
			this.bottomMarginTextBox.Size = new System.Drawing.Size(34, 20);
			this.bottomMarginTextBox.TabIndex = 39;
			// 
			// rightMarginTextBox
			// 
			this.rightMarginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rightMarginTextBox.Location = new System.Drawing.Point(179, 157);
			this.rightMarginTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.rightMarginTextBox.Multiline = true;
			this.rightMarginTextBox.Name = "rightMarginTextBox";
			this.rightMarginTextBox.Size = new System.Drawing.Size(34, 20);
			this.rightMarginTextBox.TabIndex = 38;
			// 
			// topMarginTextBox
			// 
			this.topMarginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.topMarginTextBox.Location = new System.Drawing.Point(142, 157);
			this.topMarginTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.topMarginTextBox.Multiline = true;
			this.topMarginTextBox.Name = "topMarginTextBox";
			this.topMarginTextBox.Size = new System.Drawing.Size(34, 20);
			this.topMarginTextBox.TabIndex = 37;
			// 
			// marginsLabel
			// 
			this.marginsLabel.AutoSize = true;
			this.marginsLabel.Location = new System.Drawing.Point(6, 159);
			this.marginsLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.marginsLabel.Name = "marginsLabel";
			this.marginsLabel.Size = new System.Drawing.Size(53, 15);
			this.marginsLabel.TabIndex = 36;
			this.marginsLabel.Text = "Margins:";
			// 
			// leftMarginTextBox
			// 
			this.leftMarginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.leftMarginTextBox.Location = new System.Drawing.Point(105, 157);
			this.leftMarginTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.leftMarginTextBox.Multiline = true;
			this.leftMarginTextBox.Name = "leftMarginTextBox";
			this.leftMarginTextBox.Size = new System.Drawing.Size(34, 20);
			this.leftMarginTextBox.TabIndex = 35;
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(6, 28);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(89, 15);
			this.titleLabel.TabIndex = 34;
			this.titleLabel.Text = "Document title:";
			// 
			// titleTextBox
			// 
			this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.titleTextBox.Location = new System.Drawing.Point(101, 26);
			this.titleTextBox.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
			this.titleTextBox.Multiline = true;
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.Size = new System.Drawing.Size(149, 20);
			this.titleTextBox.TabIndex = 33;
			this.titleTextBox.Text = "Image";
			// 
			// horizontalCheckBox
			// 
			this.horizontalCheckBox.AutoSize = true;
			this.horizontalCheckBox.FlatAppearance.BorderSize = 0;
			this.horizontalCheckBox.Location = new System.Drawing.Point(6, 55);
			this.horizontalCheckBox.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
			this.horizontalCheckBox.Name = "horizontalCheckBox";
			this.horizontalCheckBox.Size = new System.Drawing.Size(82, 19);
			this.horizontalCheckBox.TabIndex = 1;
			this.horizontalCheckBox.Text = "Landscape";
			this.horizontalCheckBox.UseVisualStyleBackColor = true;
			this.horizontalCheckBox.CheckedChanged += new System.EventHandler(this.horizontalCheckBox_CheckedChanged);
			// 
			// marginsCheckBox
			// 
			this.marginsCheckBox.AutoSize = true;
			this.marginsCheckBox.Checked = true;
			this.marginsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.marginsCheckBox.Location = new System.Drawing.Point(6, 105);
			this.marginsCheckBox.Name = "marginsCheckBox";
			this.marginsCheckBox.Size = new System.Drawing.Size(107, 19);
			this.marginsCheckBox.TabIndex = 0;
			this.marginsCheckBox.Text = "Margin bounds";
			this.marginsCheckBox.UseVisualStyleBackColor = true;
			this.marginsCheckBox.CheckedChanged += new System.EventHandler(this.marginsCheckBox_CheckedChanged);
			// 
			// printPreviewControl1
			// 
			this.printPreviewControl1.BackColor = System.Drawing.SystemColors.Control;
			this.printPreviewControl1.Location = new System.Drawing.Point(9, 9);
			this.printPreviewControl1.Margin = new System.Windows.Forms.Padding(0);
			this.printPreviewControl1.Name = "printPreviewControl1";
			this.printPreviewControl1.Size = new System.Drawing.Size(256, 256);
			this.printPreviewControl1.TabIndex = 0;
			this.printPreviewControl1.TabStop = false;
			// 
			// PrintForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(274, 539);
			this.Controls.Add(this.printPreviewControl1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.okButton);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PrintForm";
			this.Padding = new System.Windows.Forms.Padding(9);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Print preview";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrintForm_KeyDown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
		private System.Windows.Forms.CheckBox marginsCheckBox;
		private System.Windows.Forms.CheckBox horizontalCheckBox;
		private System.Windows.Forms.CheckBox centerCheckbox;
		private System.Windows.Forms.TextBox titleTextBox;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label marginsLabel;
		private System.Windows.Forms.TextBox leftMarginTextBox;
		private System.Windows.Forms.TextBox bottomMarginTextBox;
		private System.Windows.Forms.TextBox rightMarginTextBox;
		private System.Windows.Forms.TextBox topMarginTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button setMarginsButton;
	}
}
