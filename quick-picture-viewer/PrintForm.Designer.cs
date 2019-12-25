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
			this.okButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
			this.marginsCheckBox = new System.Windows.Forms.CheckBox();
			this.horizontalCheckBox = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.okButton.Location = new System.Drawing.Point(190, 361);
			this.okButton.Margin = new System.Windows.Forms.Padding(0);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 21;
			this.okButton.Text = "Print";
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.horizontalCheckBox);
			this.groupBox1.Controls.Add(this.marginsCheckBox);
			this.groupBox1.Location = new System.Drawing.Point(9, 275);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(256, 78);
			this.groupBox1.TabIndex = 31;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Options";
			// 
			// printPreviewControl1
			// 
			this.printPreviewControl1.Location = new System.Drawing.Point(9, 9);
			this.printPreviewControl1.Margin = new System.Windows.Forms.Padding(0);
			this.printPreviewControl1.Name = "printPreviewControl1";
			this.printPreviewControl1.Size = new System.Drawing.Size(256, 256);
			this.printPreviewControl1.TabIndex = 0;
			// 
			// marginsCheckBox
			// 
			this.marginsCheckBox.AutoSize = true;
			this.marginsCheckBox.Checked = true;
			this.marginsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.marginsCheckBox.Location = new System.Drawing.Point(6, 49);
			this.marginsCheckBox.Name = "marginsCheckBox";
			this.marginsCheckBox.Size = new System.Drawing.Size(96, 17);
			this.marginsCheckBox.TabIndex = 0;
			this.marginsCheckBox.Text = "Margin bounds";
			this.marginsCheckBox.UseVisualStyleBackColor = true;
			this.marginsCheckBox.CheckedChanged += new System.EventHandler(this.marginsCheckBox_CheckedChanged);
			// 
			// horizontalCheckBox
			// 
			this.horizontalCheckBox.AutoSize = true;
			this.horizontalCheckBox.Location = new System.Drawing.Point(6, 26);
			this.horizontalCheckBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.horizontalCheckBox.Name = "horizontalCheckBox";
			this.horizontalCheckBox.Size = new System.Drawing.Size(79, 17);
			this.horizontalCheckBox.TabIndex = 1;
			this.horizontalCheckBox.Text = "Landscape";
			this.horizontalCheckBox.UseVisualStyleBackColor = true;
			this.horizontalCheckBox.CheckedChanged += new System.EventHandler(this.horizontalCheckBox_CheckedChanged);
			// 
			// PrintForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(274, 393);
			this.Controls.Add(this.printPreviewControl1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.okButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PrintForm";
			this.Padding = new System.Windows.Forms.Padding(9);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Print preview";
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
	}
}
