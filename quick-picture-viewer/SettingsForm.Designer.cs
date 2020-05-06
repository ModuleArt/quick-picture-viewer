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
			this.okButton = new System.Windows.Forms.Button();
			this.fullscrCursorCheckBox = new System.Windows.Forms.CheckBox();
			this.licenseLabel = new System.Windows.Forms.Label();
			this.darkThemeRadio = new System.Windows.Forms.RadioButton();
			this.lightThemeRadio = new System.Windows.Forms.RadioButton();
			this.systemThemeRadio = new System.Windows.Forms.RadioButton();
			this.updatesCheckBox = new System.Windows.Forms.CheckBox();
			this.settingsTabs = new quick_picture_viewer.CustomTabControl();
			this.fullscreenPage = new System.Windows.Forms.TabPage();
			this.updatesPage = new System.Windows.Forms.TabPage();
			this.themePage = new System.Windows.Forms.TabPage();
			this.settingsTabs.SuspendLayout();
			this.fullscreenPage.SuspendLayout();
			this.updatesPage.SuspendLayout();
			this.themePage.SuspendLayout();
			this.SuspendLayout();
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.FlatAppearance.BorderSize = 0;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okButton.Location = new System.Drawing.Point(9, 169);
			this.okButton.Margin = new System.Windows.Forms.Padding(0);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(256, 23);
			this.okButton.TabIndex = 0;
			this.okButton.Text = "Close";
			this.okButton.UseVisualStyleBackColor = false;
			// 
			// fullscrCursorCheckBox
			// 
			this.fullscrCursorCheckBox.AutoSize = true;
			this.fullscrCursorCheckBox.Location = new System.Drawing.Point(12, 12);
			this.fullscrCursorCheckBox.Margin = new System.Windows.Forms.Padding(9);
			this.fullscrCursorCheckBox.Name = "fullscrCursorCheckBox";
			this.fullscrCursorCheckBox.Size = new System.Drawing.Size(158, 19);
			this.fullscrCursorCheckBox.TabIndex = 1;
			this.fullscrCursorCheckBox.Text = "Show cursor in fullscreen";
			this.fullscrCursorCheckBox.UseVisualStyleBackColor = true;
			this.fullscrCursorCheckBox.CheckedChanged += new System.EventHandler(this.fullscrCursorCheckBox_CheckedChanged);
			// 
			// licenseLabel
			// 
			this.licenseLabel.AutoSize = true;
			this.licenseLabel.Location = new System.Drawing.Point(9, 99);
			this.licenseLabel.Margin = new System.Windows.Forms.Padding(3);
			this.licenseLabel.Name = "licenseLabel";
			this.licenseLabel.Size = new System.Drawing.Size(120, 15);
			this.licenseLabel.TabIndex = 38;
			this.licenseLabel.Text = "* App restart required";
			// 
			// darkThemeRadio
			// 
			this.darkThemeRadio.AutoSize = true;
			this.darkThemeRadio.Location = new System.Drawing.Point(12, 68);
			this.darkThemeRadio.Margin = new System.Windows.Forms.Padding(9, 0, 9, 9);
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
			this.lightThemeRadio.Location = new System.Drawing.Point(12, 40);
			this.lightThemeRadio.Margin = new System.Windows.Forms.Padding(9, 0, 9, 9);
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
			this.systemThemeRadio.Margin = new System.Windows.Forms.Padding(9);
			this.systemThemeRadio.Name = "systemThemeRadio";
			this.systemThemeRadio.Size = new System.Drawing.Size(123, 19);
			this.systemThemeRadio.TabIndex = 0;
			this.systemThemeRadio.TabStop = true;
			this.systemThemeRadio.Text = "Use system setting";
			this.systemThemeRadio.UseVisualStyleBackColor = true;
			this.systemThemeRadio.CheckedChanged += new System.EventHandler(this.systemThemeRadio_CheckedChanged);
			// 
			// updatesCheckBox
			// 
			this.updatesCheckBox.AutoSize = true;
			this.updatesCheckBox.Location = new System.Drawing.Point(12, 12);
			this.updatesCheckBox.Margin = new System.Windows.Forms.Padding(9);
			this.updatesCheckBox.Name = "updatesCheckBox";
			this.updatesCheckBox.Size = new System.Drawing.Size(202, 19);
			this.updatesCheckBox.TabIndex = 0;
			this.updatesCheckBox.Text = "Check for updates on app startup";
			this.updatesCheckBox.UseVisualStyleBackColor = true;
			this.updatesCheckBox.CheckedChanged += new System.EventHandler(this.updatesCheckBox_CheckedChanged);
			// 
			// settingsTabs
			// 
			this.settingsTabs.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
			this.settingsTabs.AllowDrop = true;
			this.settingsTabs.BackTabColor = System.Drawing.Color.White;
			this.settingsTabs.BorderColor = System.Drawing.SystemColors.ControlLight;
			this.settingsTabs.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
			this.settingsTabs.ClosingMessage = null;
			this.settingsTabs.Controls.Add(this.themePage);
			this.settingsTabs.Controls.Add(this.updatesPage);
			this.settingsTabs.Controls.Add(this.fullscreenPage);
			this.settingsTabs.HeaderColor = System.Drawing.SystemColors.ControlLight;
			this.settingsTabs.HorizontalLineColor = System.Drawing.Color.Transparent;
			this.settingsTabs.ItemSize = new System.Drawing.Size(240, 16);
			this.settingsTabs.Location = new System.Drawing.Point(9, 9);
			this.settingsTabs.Margin = new System.Windows.Forms.Padding(0, 0, 0, 9);
			this.settingsTabs.Name = "settingsTabs";
			this.settingsTabs.SelectedIndex = 0;
			this.settingsTabs.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.settingsTabs.ShowClosingButton = false;
			this.settingsTabs.ShowClosingMessage = false;
			this.settingsTabs.Size = new System.Drawing.Size(256, 151);
			this.settingsTabs.TabIndex = 13;
			this.settingsTabs.TextColor = System.Drawing.Color.Black;
			// 
			// fullscreenPage
			// 
			this.fullscreenPage.BackColor = System.Drawing.Color.White;
			this.fullscreenPage.Controls.Add(this.fullscrCursorCheckBox);
			this.fullscreenPage.Location = new System.Drawing.Point(4, 20);
			this.fullscreenPage.Name = "fullscreenPage";
			this.fullscreenPage.Padding = new System.Windows.Forms.Padding(3);
			this.fullscreenPage.Size = new System.Drawing.Size(248, 127);
			this.fullscreenPage.TabIndex = 2;
			this.fullscreenPage.Text = "Fullscreen";
			// 
			// updatesPage
			// 
			this.updatesPage.BackColor = System.Drawing.Color.White;
			this.updatesPage.Controls.Add(this.updatesCheckBox);
			this.updatesPage.Location = new System.Drawing.Point(4, 20);
			this.updatesPage.Name = "updatesPage";
			this.updatesPage.Padding = new System.Windows.Forms.Padding(3);
			this.updatesPage.Size = new System.Drawing.Size(248, 127);
			this.updatesPage.TabIndex = 1;
			this.updatesPage.Text = "Updates";
			// 
			// themePage
			// 
			this.themePage.BackColor = System.Drawing.Color.White;
			this.themePage.Controls.Add(this.licenseLabel);
			this.themePage.Controls.Add(this.systemThemeRadio);
			this.themePage.Controls.Add(this.darkThemeRadio);
			this.themePage.Controls.Add(this.lightThemeRadio);
			this.themePage.Location = new System.Drawing.Point(4, 20);
			this.themePage.Name = "themePage";
			this.themePage.Padding = new System.Windows.Forms.Padding(3);
			this.themePage.Size = new System.Drawing.Size(248, 127);
			this.themePage.TabIndex = 0;
			this.themePage.Text = "Theme";
			// 
			// SettingsForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(274, 201);
			this.Controls.Add(this.settingsTabs);
			this.Controls.Add(this.okButton);
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
			this.settingsTabs.ResumeLayout(false);
			this.fullscreenPage.ResumeLayout(false);
			this.fullscreenPage.PerformLayout();
			this.updatesPage.ResumeLayout(false);
			this.updatesPage.PerformLayout();
			this.themePage.ResumeLayout(false);
			this.themePage.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.RadioButton lightThemeRadio;
		private System.Windows.Forms.RadioButton systemThemeRadio;
		private System.Windows.Forms.RadioButton darkThemeRadio;
		private System.Windows.Forms.CheckBox updatesCheckBox;
		private System.Windows.Forms.Label licenseLabel;
		private System.Windows.Forms.CheckBox fullscrCursorCheckBox;
		private CustomTabControl settingsTabs;
		private System.Windows.Forms.TabPage themePage;
		private System.Windows.Forms.TabPage updatesPage;
		private System.Windows.Forms.TabPage fullscreenPage;
	}
}
