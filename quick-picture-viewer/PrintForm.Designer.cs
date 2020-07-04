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
			this.groupBox1 = new QuickLibrary.QlibGroupBox();
			this.setMarginsButton = new QuickLibrary.QlibTextButton();
			this.label4 = new System.Windows.Forms.Label();
			this.rightLabel = new System.Windows.Forms.Label();
			this.topLabel = new System.Windows.Forms.Label();
			this.centerCheckbox = new QuickLibrary.QlibCheckBox();
			this.leftLabel = new System.Windows.Forms.Label();
			this.bottomMarginTextBox = new System.Windows.Forms.TextBox();
			this.rightMarginTextBox = new System.Windows.Forms.TextBox();
			this.topMarginTextBox = new System.Windows.Forms.TextBox();
			this.marginsLabel = new System.Windows.Forms.Label();
			this.leftMarginTextBox = new System.Windows.Forms.TextBox();
			this.titleLabel = new System.Windows.Forms.Label();
			this.titleTextBox = new System.Windows.Forms.TextBox();
			this.horizontalCheckBox = new QuickLibrary.QlibCheckBox();
			this.marginsCheckBox = new QuickLibrary.QlibCheckBox();
			this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
			this.okButton.Location = new System.Drawing.Point(9, 520);
			this.okButton.Margin = new System.Windows.Forms.Padding(0);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(256, 23);
			this.okButton.TabIndex = 9;
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
			this.groupBox1.Controls.Add(this.rightLabel);
			this.groupBox1.Controls.Add(this.topLabel);
			this.groupBox1.Controls.Add(this.centerCheckbox);
			this.groupBox1.Controls.Add(this.leftLabel);
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
			this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
			this.groupBox1.Size = new System.Drawing.Size(256, 238);
			this.groupBox1.TabIndex = 31;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Options";
			// 
			// setMarginsButton
			// 
			this.setMarginsButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.setMarginsButton.FlatAppearance.BorderSize = 0;
			this.setMarginsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.setMarginsButton.Location = new System.Drawing.Point(84, 197);
			this.setMarginsButton.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.setMarginsButton.Name = "setMarginsButton";
			this.setMarginsButton.Size = new System.Drawing.Size(163, 23);
			this.setMarginsButton.TabIndex = 8;
			this.setMarginsButton.Text = "Set margins";
			this.setMarginsButton.UseVisualStyleBackColor = false;
			this.setMarginsButton.EnabledChanged += new System.EventHandler(this.setMarginsButton_EnabledChanged);
			this.setMarginsButton.Click += new System.EventHandler(this.setMarginsButton_Click);
			this.setMarginsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.setMarginsButton_Paint);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(210, 141);
			this.label4.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(14, 15);
			this.label4.TabIndex = 43;
			this.label4.Text = "B";
			// 
			// rightLabel
			// 
			this.rightLabel.AutoSize = true;
			this.rightLabel.Location = new System.Drawing.Point(167, 141);
			this.rightLabel.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.rightLabel.Name = "rightLabel";
			this.rightLabel.Size = new System.Drawing.Size(14, 15);
			this.rightLabel.TabIndex = 42;
			this.rightLabel.Text = "R";
			// 
			// topLabel
			// 
			this.topLabel.AutoSize = true;
			this.topLabel.Location = new System.Drawing.Point(124, 141);
			this.topLabel.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.topLabel.Name = "topLabel";
			this.topLabel.Size = new System.Drawing.Size(13, 15);
			this.topLabel.TabIndex = 41;
			this.topLabel.Text = "T";
			// 
			// centerCheckbox
			// 
			this.centerCheckbox.Checked = true;
			this.centerCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.centerCheckbox.Location = new System.Drawing.Point(9, 85);
			this.centerCheckbox.Margin = new System.Windows.Forms.Padding(9, 9, 0, 0);
			this.centerCheckbox.Name = "centerCheckbox";
			this.centerCheckbox.Size = new System.Drawing.Size(97, 19);
			this.centerCheckbox.TabIndex = 2;
			this.centerCheckbox.Text = "Center image";
			this.centerCheckbox.UseVisualStyleBackColor = true;
			this.centerCheckbox.CheckedChanged += new System.EventHandler(this.centerCheckbox_CheckedChanged);
			// 
			// leftLabel
			// 
			this.leftLabel.AutoSize = true;
			this.leftLabel.Location = new System.Drawing.Point(81, 141);
			this.leftLabel.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.leftLabel.Name = "leftLabel";
			this.leftLabel.Size = new System.Drawing.Size(13, 15);
			this.leftLabel.TabIndex = 40;
			this.leftLabel.Text = "L";
			// 
			// bottomMarginTextBox
			// 
			this.bottomMarginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.bottomMarginTextBox.Location = new System.Drawing.Point(213, 165);
			this.bottomMarginTextBox.Margin = new System.Windows.Forms.Padding(0, 9, 9, 0);
			this.bottomMarginTextBox.Name = "bottomMarginTextBox";
			this.bottomMarginTextBox.Size = new System.Drawing.Size(34, 23);
			this.bottomMarginTextBox.TabIndex = 7;
			// 
			// rightMarginTextBox
			// 
			this.rightMarginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rightMarginTextBox.Location = new System.Drawing.Point(170, 165);
			this.rightMarginTextBox.Margin = new System.Windows.Forms.Padding(0, 9, 9, 0);
			this.rightMarginTextBox.Name = "rightMarginTextBox";
			this.rightMarginTextBox.Size = new System.Drawing.Size(34, 23);
			this.rightMarginTextBox.TabIndex = 6;
			// 
			// topMarginTextBox
			// 
			this.topMarginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.topMarginTextBox.Location = new System.Drawing.Point(127, 165);
			this.topMarginTextBox.Margin = new System.Windows.Forms.Padding(0, 9, 9, 0);
			this.topMarginTextBox.Name = "topMarginTextBox";
			this.topMarginTextBox.Size = new System.Drawing.Size(34, 23);
			this.topMarginTextBox.TabIndex = 5;
			// 
			// marginsLabel
			// 
			this.marginsLabel.AutoSize = true;
			this.marginsLabel.Location = new System.Drawing.Point(22, 167);
			this.marginsLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.marginsLabel.Name = "marginsLabel";
			this.marginsLabel.Size = new System.Drawing.Size(53, 15);
			this.marginsLabel.TabIndex = 36;
			this.marginsLabel.Text = "Margins:";
			// 
			// leftMarginTextBox
			// 
			this.leftMarginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.leftMarginTextBox.Location = new System.Drawing.Point(84, 165);
			this.leftMarginTextBox.Margin = new System.Windows.Forms.Padding(0, 9, 9, 0);
			this.leftMarginTextBox.Name = "leftMarginTextBox";
			this.leftMarginTextBox.Size = new System.Drawing.Size(34, 23);
			this.leftMarginTextBox.TabIndex = 4;
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(43, 27);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(32, 15);
			this.titleLabel.TabIndex = 34;
			this.titleLabel.Text = "Title:";
			// 
			// titleTextBox
			// 
			this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.titleTextBox.Location = new System.Drawing.Point(84, 25);
			this.titleTextBox.Margin = new System.Windows.Forms.Padding(0, 9, 9, 0);
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.Size = new System.Drawing.Size(163, 23);
			this.titleTextBox.TabIndex = 0;
			this.titleTextBox.Text = "Image";
			// 
			// horizontalCheckBox
			// 
			this.horizontalCheckBox.FlatAppearance.BorderSize = 0;
			this.horizontalCheckBox.Location = new System.Drawing.Point(9, 57);
			this.horizontalCheckBox.Margin = new System.Windows.Forms.Padding(9, 9, 0, 0);
			this.horizontalCheckBox.Name = "horizontalCheckBox";
			this.horizontalCheckBox.Size = new System.Drawing.Size(82, 19);
			this.horizontalCheckBox.TabIndex = 1;
			this.horizontalCheckBox.Text = "Landscape";
			this.horizontalCheckBox.UseVisualStyleBackColor = true;
			this.horizontalCheckBox.CheckedChanged += new System.EventHandler(this.horizontalCheckBox_CheckedChanged);
			// 
			// marginsCheckBox
			// 
			this.marginsCheckBox.Checked = true;
			this.marginsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.marginsCheckBox.Location = new System.Drawing.Point(9, 113);
			this.marginsCheckBox.Margin = new System.Windows.Forms.Padding(9, 9, 0, 0);
			this.marginsCheckBox.Name = "marginsCheckBox";
			this.marginsCheckBox.Size = new System.Drawing.Size(107, 19);
			this.marginsCheckBox.TabIndex = 3;
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
			this.ClientSize = new System.Drawing.Size(274, 552);
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
			this.Load += new System.EventHandler(this.PrintForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrintForm_KeyDown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button okButton;
		private QuickLibrary.QlibGroupBox groupBox1;
		private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
		private QuickLibrary.QlibCheckBox marginsCheckBox;
		private QuickLibrary.QlibCheckBox horizontalCheckBox;
		private QuickLibrary.QlibCheckBox centerCheckbox;
		private System.Windows.Forms.TextBox titleTextBox;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label marginsLabel;
		private System.Windows.Forms.TextBox leftMarginTextBox;
		private System.Windows.Forms.TextBox bottomMarginTextBox;
		private System.Windows.Forms.TextBox rightMarginTextBox;
		private System.Windows.Forms.TextBox topMarginTextBox;
		private System.Windows.Forms.Label leftLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label rightLabel;
		private System.Windows.Forms.Label topLabel;
		private QuickLibrary.QlibTextButton setMarginsButton;
	}
}
