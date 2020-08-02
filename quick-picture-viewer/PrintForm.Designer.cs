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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
			this.okButton = new System.Windows.Forms.Button();
			this.setMarginsButton = new QuickLibrary.QlibTextButton();
			this.bottomLabel = new System.Windows.Forms.Label();
			this.rightLabel = new System.Windows.Forms.Label();
			this.topLabel = new System.Windows.Forms.Label();
			this.centerCheckbox = new QuickLibrary.QlibCheckBox();
			this.leftLabel = new System.Windows.Forms.Label();
			this.bottomMarginTextBox = new QuickLibrary.QlibTextBox();
			this.rightMarginTextBox = new QuickLibrary.QlibTextBox();
			this.topMarginTextBox = new QuickLibrary.QlibTextBox();
			this.marginsLabel = new System.Windows.Forms.Label();
			this.leftMarginTextBox = new QuickLibrary.QlibTextBox();
			this.documentLabel = new System.Windows.Forms.Label();
			this.titleTextBox = new QuickLibrary.QlibTextBox();
			this.horizontalCheckBox = new QuickLibrary.QlibCheckBox();
			this.marginsCheckBox = new QuickLibrary.QlibCheckBox();
			this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
			this.titlePanel = new System.Windows.Forms.Panel();
			this.closeBtn = new QuickLibrary.QlibTitlebarButton();
			this.titleLabel = new System.Windows.Forms.Label();
			this.aboutTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.titlePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// okButton
			// 
			this.okButton.BackColor = System.Drawing.SystemColors.Control;
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.FlatAppearance.BorderSize = 0;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
			this.okButton.Location = new System.Drawing.Point(234, 276);
			this.okButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(214, 32);
			this.okButton.TabIndex = 11;
			this.okButton.Text = "Print";
			this.okButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.okButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.aboutTooltip.SetToolTip(this.okButton, "Choose print method");
			this.okButton.UseVisualStyleBackColor = false;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// setMarginsButton
			// 
			this.setMarginsButton.BackColor = System.Drawing.SystemColors.Control;
			this.setMarginsButton.FlatAppearance.BorderSize = 0;
			this.setMarginsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.setMarginsButton.Location = new System.Drawing.Point(10, 276);
			this.setMarginsButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.setMarginsButton.Name = "setMarginsButton";
			this.setMarginsButton.Size = new System.Drawing.Size(214, 32);
			this.setMarginsButton.TabIndex = 10;
			this.setMarginsButton.Text = "Set margins";
			this.setMarginsButton.UseVisualStyleBackColor = false;
			this.setMarginsButton.EnabledChanged += new System.EventHandler(this.setMarginsButton_EnabledChanged);
			this.setMarginsButton.Click += new System.EventHandler(this.setMarginsButton_Click);
			this.setMarginsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.setMarginsButton_Paint);
			// 
			// bottomLabel
			// 
			this.bottomLabel.AutoSize = true;
			this.bottomLabel.Location = new System.Drawing.Point(174, 212);
			this.bottomLabel.Margin = new System.Windows.Forms.Padding(0);
			this.bottomLabel.Name = "bottomLabel";
			this.bottomLabel.Size = new System.Drawing.Size(33, 19);
			this.bottomLabel.TabIndex = 43;
			this.bottomLabel.Text = "Bot:";
			// 
			// rightLabel
			// 
			this.rightLabel.AutoSize = true;
			this.rightLabel.Location = new System.Drawing.Point(118, 212);
			this.rightLabel.Margin = new System.Windows.Forms.Padding(0);
			this.rightLabel.Name = "rightLabel";
			this.rightLabel.Size = new System.Drawing.Size(44, 19);
			this.rightLabel.TabIndex = 42;
			this.rightLabel.Text = "Right:";
			// 
			// topLabel
			// 
			this.topLabel.AutoSize = true;
			this.topLabel.Location = new System.Drawing.Point(62, 212);
			this.topLabel.Margin = new System.Windows.Forms.Padding(0);
			this.topLabel.Name = "topLabel";
			this.topLabel.Size = new System.Drawing.Size(34, 19);
			this.topLabel.TabIndex = 41;
			this.topLabel.Text = "Top:";
			// 
			// centerCheckbox
			// 
			this.centerCheckbox.Checked = true;
			this.centerCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.centerCheckbox.Location = new System.Drawing.Point(10, 109);
			this.centerCheckbox.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.centerCheckbox.Name = "centerCheckbox";
			this.centerCheckbox.Size = new System.Drawing.Size(214, 32);
			this.centerCheckbox.TabIndex = 4;
			this.centerCheckbox.Text = "Center image";
			this.centerCheckbox.UseVisualStyleBackColor = true;
			this.centerCheckbox.CheckedChanged += new System.EventHandler(this.centerCheckbox_CheckedChanged);
			// 
			// leftLabel
			// 
			this.leftLabel.AutoSize = true;
			this.leftLabel.Location = new System.Drawing.Point(6, 212);
			this.leftLabel.Margin = new System.Windows.Forms.Padding(0);
			this.leftLabel.Name = "leftLabel";
			this.leftLabel.Size = new System.Drawing.Size(35, 19);
			this.leftLabel.TabIndex = 40;
			this.leftLabel.Text = "Left:";
			// 
			// bottomMarginTextBox
			// 
			this.bottomMarginTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.bottomMarginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.bottomMarginTextBox.Location = new System.Drawing.Point(178, 241);
			this.bottomMarginTextBox.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.bottomMarginTextBox.Name = "bottomMarginTextBox";
			this.bottomMarginTextBox.Size = new System.Drawing.Size(46, 25);
			this.bottomMarginTextBox.TabIndex = 9;
			// 
			// rightMarginTextBox
			// 
			this.rightMarginTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.rightMarginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rightMarginTextBox.Location = new System.Drawing.Point(122, 241);
			this.rightMarginTextBox.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.rightMarginTextBox.Name = "rightMarginTextBox";
			this.rightMarginTextBox.Size = new System.Drawing.Size(46, 25);
			this.rightMarginTextBox.TabIndex = 8;
			// 
			// topMarginTextBox
			// 
			this.topMarginTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.topMarginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.topMarginTextBox.Location = new System.Drawing.Point(66, 241);
			this.topMarginTextBox.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.topMarginTextBox.Name = "topMarginTextBox";
			this.topMarginTextBox.Size = new System.Drawing.Size(46, 25);
			this.topMarginTextBox.TabIndex = 7;
			// 
			// marginsLabel
			// 
			this.marginsLabel.AutoSize = true;
			this.marginsLabel.Location = new System.Drawing.Point(6, 183);
			this.marginsLabel.Margin = new System.Windows.Forms.Padding(10);
			this.marginsLabel.Name = "marginsLabel";
			this.marginsLabel.Size = new System.Drawing.Size(62, 19);
			this.marginsLabel.TabIndex = 36;
			this.marginsLabel.Text = "Margins:";
			// 
			// leftMarginTextBox
			// 
			this.leftMarginTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.leftMarginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.leftMarginTextBox.Location = new System.Drawing.Point(10, 241);
			this.leftMarginTextBox.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.leftMarginTextBox.Name = "leftMarginTextBox";
			this.leftMarginTextBox.Size = new System.Drawing.Size(46, 25);
			this.leftMarginTextBox.TabIndex = 6;
			// 
			// documentLabel
			// 
			this.documentLabel.AutoSize = true;
			this.documentLabel.Location = new System.Drawing.Point(6, 44);
			this.documentLabel.Margin = new System.Windows.Forms.Padding(10);
			this.documentLabel.Name = "documentLabel";
			this.documentLabel.Size = new System.Drawing.Size(37, 19);
			this.documentLabel.TabIndex = 34;
			this.documentLabel.Text = "Title:";
			// 
			// titleTextBox
			// 
			this.titleTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.titleTextBox.Location = new System.Drawing.Point(53, 42);
			this.titleTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.Size = new System.Drawing.Size(171, 25);
			this.titleTextBox.TabIndex = 2;
			this.titleTextBox.Text = "Image";
			// 
			// horizontalCheckBox
			// 
			this.horizontalCheckBox.FlatAppearance.BorderSize = 0;
			this.horizontalCheckBox.Location = new System.Drawing.Point(10, 77);
			this.horizontalCheckBox.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
			this.horizontalCheckBox.Name = "horizontalCheckBox";
			this.horizontalCheckBox.Size = new System.Drawing.Size(214, 32);
			this.horizontalCheckBox.TabIndex = 3;
			this.horizontalCheckBox.Text = "Landscape";
			this.horizontalCheckBox.UseVisualStyleBackColor = true;
			this.horizontalCheckBox.CheckedChanged += new System.EventHandler(this.horizontalCheckBox_CheckedChanged);
			// 
			// marginsCheckBox
			// 
			this.marginsCheckBox.Checked = true;
			this.marginsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.marginsCheckBox.Location = new System.Drawing.Point(10, 141);
			this.marginsCheckBox.Margin = new System.Windows.Forms.Padding(0);
			this.marginsCheckBox.Name = "marginsCheckBox";
			this.marginsCheckBox.Size = new System.Drawing.Size(214, 32);
			this.marginsCheckBox.TabIndex = 5;
			this.marginsCheckBox.Text = "Margin bounds";
			this.marginsCheckBox.UseVisualStyleBackColor = true;
			this.marginsCheckBox.CheckedChanged += new System.EventHandler(this.marginsCheckBox_CheckedChanged);
			// 
			// printPreviewControl1
			// 
			this.printPreviewControl1.BackColor = System.Drawing.Color.White;
			this.printPreviewControl1.Location = new System.Drawing.Point(224, 32);
			this.printPreviewControl1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.printPreviewControl1.Name = "printPreviewControl1";
			this.printPreviewControl1.Size = new System.Drawing.Size(233, 244);
			this.printPreviewControl1.TabIndex = 0;
			this.printPreviewControl1.TabStop = false;
			// 
			// titlePanel
			// 
			this.titlePanel.Controls.Add(this.closeBtn);
			this.titlePanel.Controls.Add(this.titleLabel);
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Margin = new System.Windows.Forms.Padding(0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(458, 32);
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
			this.closeBtn.Location = new System.Drawing.Point(426, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 17;
			this.aboutTooltip.SetToolTip(this.closeBtn, "Close (Alt+F4)");
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(9, 7);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(89, 19);
			this.titleLabel.TabIndex = 16;
			this.titleLabel.Text = "Print preview";
			// 
			// PrintForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(458, 318);
			this.Controls.Add(this.setMarginsButton);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.bottomLabel);
			this.Controls.Add(this.printPreviewControl1);
			this.Controls.Add(this.rightLabel);
			this.Controls.Add(this.topLabel);
			this.Controls.Add(this.okButton);
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
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PrintForm";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Print preview";
			this.Load += new System.EventHandler(this.PrintForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrintForm_KeyDown);
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
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
		private QuickLibrary.QlibTextBox leftMarginTextBox;
		private QuickLibrary.QlibTextBox bottomMarginTextBox;
		private QuickLibrary.QlibTextBox rightMarginTextBox;
		private QuickLibrary.QlibTextBox topMarginTextBox;
		private System.Windows.Forms.Label leftLabel;
		private System.Windows.Forms.Label bottomLabel;
		private System.Windows.Forms.Label rightLabel;
		private System.Windows.Forms.Label topLabel;
		private QuickLibrary.QlibTextButton setMarginsButton;
		private System.Windows.Forms.Panel titlePanel;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.ToolTip aboutTooltip;
		private QuickLibrary.QlibTitlebarButton closeBtn;
	}
}
