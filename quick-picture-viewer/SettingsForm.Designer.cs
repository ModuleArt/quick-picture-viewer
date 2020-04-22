namespace quick_picture_viewer
{
	partial class SettingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.okButton = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.themeTab = new System.Windows.Forms.TabPage();
			this.darkThemeRadio = new System.Windows.Forms.RadioButton();
			this.lightThemeRadio = new System.Windows.Forms.RadioButton();
			this.systemThemeRadio = new System.Windows.Forms.RadioButton();
			this.updatesTab = new System.Windows.Forms.TabPage();
			this.updatesCheckBox = new System.Windows.Forms.CheckBox();
			this.licenseLabel = new System.Windows.Forms.Label();
			this.fullscreenTab = new System.Windows.Forms.TabPage();
			this.fullscrCursorCheckBox = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.themeTab.SuspendLayout();
			this.updatesTab.SuspendLayout();
			this.fullscreenTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(9, 9);
			this.logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(256, 80);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.logoPictureBox.TabIndex = 12;
			this.logoPictureBox.TabStop = false;
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.FlatAppearance.BorderSize = 0;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okButton.Location = new System.Drawing.Point(9, 258);
			this.okButton.Margin = new System.Windows.Forms.Padding(0);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(256, 23);
			this.okButton.TabIndex = 0;
			this.okButton.Text = "Close";
			this.okButton.UseVisualStyleBackColor = false;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.themeTab);
			this.tabControl1.Controls.Add(this.updatesTab);
			this.tabControl1.Controls.Add(this.fullscreenTab);
			this.tabControl1.ItemSize = new System.Drawing.Size(40, 23);
			this.tabControl1.Location = new System.Drawing.Point(9, 98);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(256, 151);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.TabStop = false;
			this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
			// 
			// themeTab
			// 
			this.themeTab.Controls.Add(this.licenseLabel);
			this.themeTab.Controls.Add(this.darkThemeRadio);
			this.themeTab.Controls.Add(this.lightThemeRadio);
			this.themeTab.Controls.Add(this.systemThemeRadio);
			this.themeTab.Location = new System.Drawing.Point(4, 27);
			this.themeTab.Name = "themeTab";
			this.themeTab.Padding = new System.Windows.Forms.Padding(3);
			this.themeTab.Size = new System.Drawing.Size(248, 120);
			this.themeTab.TabIndex = 1;
			this.themeTab.Text = "Theme";
			this.themeTab.UseVisualStyleBackColor = true;
			// 
			// darkThemeRadio
			// 
			this.darkThemeRadio.AutoSize = true;
			this.darkThemeRadio.Location = new System.Drawing.Point(12, 62);
			this.darkThemeRadio.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
			this.darkThemeRadio.Name = "darkThemeRadio";
			this.darkThemeRadio.Size = new System.Drawing.Size(49, 19);
			this.darkThemeRadio.TabIndex = 2;
			this.darkThemeRadio.Text = "Dark";
			this.darkThemeRadio.UseVisualStyleBackColor = true;
			this.darkThemeRadio.CheckedChanged += new System.EventHandler(this.darkThemeRadio_CheckedChanged);
			// 
			// lightThemeRadio
			// 
			this.lightThemeRadio.AutoSize = true;
			this.lightThemeRadio.Location = new System.Drawing.Point(12, 37);
			this.lightThemeRadio.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
			this.lightThemeRadio.Name = "lightThemeRadio";
			this.lightThemeRadio.Size = new System.Drawing.Size(52, 19);
			this.lightThemeRadio.TabIndex = 1;
			this.lightThemeRadio.Text = "Light";
			this.lightThemeRadio.UseVisualStyleBackColor = true;
			this.lightThemeRadio.CheckedChanged += new System.EventHandler(this.lightThemeRadio_CheckedChanged);
			// 
			// systemThemeRadio
			// 
			this.systemThemeRadio.AutoSize = true;
			this.systemThemeRadio.Checked = true;
			this.systemThemeRadio.Location = new System.Drawing.Point(12, 12);
			this.systemThemeRadio.Margin = new System.Windows.Forms.Padding(9, 9, 3, 3);
			this.systemThemeRadio.Name = "systemThemeRadio";
			this.systemThemeRadio.Size = new System.Drawing.Size(123, 19);
			this.systemThemeRadio.TabIndex = 0;
			this.systemThemeRadio.TabStop = true;
			this.systemThemeRadio.Text = "Use system setting";
			this.systemThemeRadio.UseVisualStyleBackColor = true;
			this.systemThemeRadio.CheckedChanged += new System.EventHandler(this.systemThemeRadio_CheckedChanged);
			// 
			// updatesTab
			// 
			this.updatesTab.Controls.Add(this.updatesCheckBox);
			this.updatesTab.Location = new System.Drawing.Point(4, 27);
			this.updatesTab.Name = "updatesTab";
			this.updatesTab.Padding = new System.Windows.Forms.Padding(3);
			this.updatesTab.Size = new System.Drawing.Size(248, 120);
			this.updatesTab.TabIndex = 0;
			this.updatesTab.Text = "Updates";
			this.updatesTab.UseVisualStyleBackColor = true;
			// 
			// updatesCheckBox
			// 
			this.updatesCheckBox.AutoSize = true;
			this.updatesCheckBox.Location = new System.Drawing.Point(12, 12);
			this.updatesCheckBox.Margin = new System.Windows.Forms.Padding(9, 9, 9, 3);
			this.updatesCheckBox.Name = "updatesCheckBox";
			this.updatesCheckBox.Size = new System.Drawing.Size(202, 19);
			this.updatesCheckBox.TabIndex = 0;
			this.updatesCheckBox.Text = "Check for updates on app startup";
			this.updatesCheckBox.UseVisualStyleBackColor = true;
			this.updatesCheckBox.CheckedChanged += new System.EventHandler(this.updatesCheckBox_CheckedChanged);
			// 
			// licenseLabel
			// 
			this.licenseLabel.AutoSize = true;
			this.licenseLabel.Location = new System.Drawing.Point(9, 93);
			this.licenseLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
			this.licenseLabel.Name = "licenseLabel";
			this.licenseLabel.Size = new System.Drawing.Size(120, 15);
			this.licenseLabel.TabIndex = 38;
			this.licenseLabel.Text = "* App restart required";
			// 
			// fullscreenTab
			// 
			this.fullscreenTab.Controls.Add(this.fullscrCursorCheckBox);
			this.fullscreenTab.Location = new System.Drawing.Point(4, 27);
			this.fullscreenTab.Name = "fullscreenTab";
			this.fullscreenTab.Size = new System.Drawing.Size(248, 120);
			this.fullscreenTab.TabIndex = 2;
			this.fullscreenTab.Text = "Fullscreen";
			this.fullscreenTab.UseVisualStyleBackColor = true;
			// 
			// fullscrCursorCheckBox
			// 
			this.fullscrCursorCheckBox.AutoSize = true;
			this.fullscrCursorCheckBox.Location = new System.Drawing.Point(12, 12);
			this.fullscrCursorCheckBox.Margin = new System.Windows.Forms.Padding(9, 9, 9, 3);
			this.fullscrCursorCheckBox.Name = "fullscrCursorCheckBox";
			this.fullscrCursorCheckBox.Size = new System.Drawing.Size(158, 19);
			this.fullscrCursorCheckBox.TabIndex = 1;
			this.fullscrCursorCheckBox.Text = "Show cursor in fullscreen";
			this.fullscrCursorCheckBox.UseVisualStyleBackColor = true;
			this.fullscrCursorCheckBox.CheckedChanged += new System.EventHandler(this.fullscrCursorCheckBox_CheckedChanged);
			// 
			// SettingsForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(274, 290);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.logoPictureBox);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.Padding = new System.Windows.Forms.Padding(9);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.themeTab.ResumeLayout(false);
			this.themeTab.PerformLayout();
			this.updatesTab.ResumeLayout(false);
			this.updatesTab.PerformLayout();
			this.fullscreenTab.ResumeLayout(false);
			this.fullscreenTab.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage updatesTab;
		private System.Windows.Forms.TabPage themeTab;
		private System.Windows.Forms.RadioButton lightThemeRadio;
		private System.Windows.Forms.RadioButton systemThemeRadio;
		private System.Windows.Forms.RadioButton darkThemeRadio;
		private System.Windows.Forms.CheckBox updatesCheckBox;
		private System.Windows.Forms.Label licenseLabel;
		private System.Windows.Forms.TabPage fullscreenTab;
		private System.Windows.Forms.CheckBox fullscrCursorCheckBox;
	}
}
