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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.settingsTabs = new QuickLibrary.QlibTabControl();
			this.themePage = new System.Windows.Forms.TabPage();
			this.licenseLabel = new System.Windows.Forms.Label();
			this.systemThemeRadio = new QuickLibrary.QlibRadioButton();
			this.darkThemeRadio = new QuickLibrary.QlibRadioButton();
			this.lightThemeRadio = new QuickLibrary.QlibRadioButton();
			this.updatesPage = new System.Windows.Forms.TabPage();
			this.updatesCheckBox = new QuickLibrary.QlibCheckBox();
			this.fullscreenPage = new System.Windows.Forms.TabPage();
			this.fullscrCursorCheckBox = new QuickLibrary.QlibCheckBox();
			this.titlePanel = new System.Windows.Forms.Panel();
			this.titleLabel = new System.Windows.Forms.Label();
			this.closeBtn = new System.Windows.Forms.Button();
			this.aboutTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.settingsTabs.SuspendLayout();
			this.themePage.SuspendLayout();
			this.updatesPage.SuspendLayout();
			this.fullscreenPage.SuspendLayout();
			this.titlePanel.SuspendLayout();
			this.SuspendLayout();
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
			this.settingsTabs.Location = new System.Drawing.Point(10, 42);
			this.settingsTabs.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.settingsTabs.Name = "settingsTabs";
			this.settingsTabs.Padding = new System.Drawing.Point(0, 0);
			this.settingsTabs.SelectedIndex = 0;
			this.settingsTabs.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.settingsTabs.ShowClosingButton = false;
			this.settingsTabs.ShowClosingMessage = false;
			this.settingsTabs.Size = new System.Drawing.Size(280, 204);
			this.settingsTabs.TabIndex = 1;
			this.settingsTabs.TextColor = System.Drawing.Color.Black;
			// 
			// themePage
			// 
			this.themePage.BackColor = System.Drawing.Color.White;
			this.themePage.Controls.Add(this.licenseLabel);
			this.themePage.Controls.Add(this.systemThemeRadio);
			this.themePage.Controls.Add(this.darkThemeRadio);
			this.themePage.Controls.Add(this.lightThemeRadio);
			this.themePage.Location = new System.Drawing.Point(4, 20);
			this.themePage.Margin = new System.Windows.Forms.Padding(0);
			this.themePage.Name = "themePage";
			this.themePage.Padding = new System.Windows.Forms.Padding(10);
			this.themePage.Size = new System.Drawing.Size(272, 180);
			this.themePage.TabIndex = 0;
			this.themePage.Text = "Theme";
			// 
			// licenseLabel
			// 
			this.licenseLabel.AutoSize = true;
			this.licenseLabel.Location = new System.Drawing.Point(10, 116);
			this.licenseLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.licenseLabel.Name = "licenseLabel";
			this.licenseLabel.Size = new System.Drawing.Size(143, 19);
			this.licenseLabel.TabIndex = 38;
			this.licenseLabel.Text = "* App restart required";
			// 
			// systemThemeRadio
			// 
			this.systemThemeRadio.Checked = true;
			this.systemThemeRadio.Location = new System.Drawing.Point(10, 10);
			this.systemThemeRadio.Margin = new System.Windows.Forms.Padding(0);
			this.systemThemeRadio.Name = "systemThemeRadio";
			this.systemThemeRadio.Size = new System.Drawing.Size(252, 32);
			this.systemThemeRadio.TabIndex = 0;
			this.systemThemeRadio.TabStop = true;
			this.systemThemeRadio.Text = "Use system setting";
			this.systemThemeRadio.UseVisualStyleBackColor = true;
			this.systemThemeRadio.CheckedChanged += new System.EventHandler(this.systemThemeRadio_CheckedChanged);
			// 
			// darkThemeRadio
			// 
			this.darkThemeRadio.Location = new System.Drawing.Point(10, 74);
			this.darkThemeRadio.Margin = new System.Windows.Forms.Padding(0);
			this.darkThemeRadio.Name = "darkThemeRadio";
			this.darkThemeRadio.Size = new System.Drawing.Size(252, 32);
			this.darkThemeRadio.TabIndex = 2;
			this.darkThemeRadio.Text = "Dark";
			this.darkThemeRadio.UseVisualStyleBackColor = true;
			this.darkThemeRadio.CheckedChanged += new System.EventHandler(this.darkThemeRadio_CheckedChanged);
			// 
			// lightThemeRadio
			// 
			this.lightThemeRadio.Location = new System.Drawing.Point(10, 42);
			this.lightThemeRadio.Margin = new System.Windows.Forms.Padding(0);
			this.lightThemeRadio.Name = "lightThemeRadio";
			this.lightThemeRadio.Size = new System.Drawing.Size(252, 32);
			this.lightThemeRadio.TabIndex = 1;
			this.lightThemeRadio.Text = "Light";
			this.lightThemeRadio.UseVisualStyleBackColor = true;
			this.lightThemeRadio.CheckedChanged += new System.EventHandler(this.lightThemeRadio_CheckedChanged);
			// 
			// updatesPage
			// 
			this.updatesPage.BackColor = System.Drawing.Color.White;
			this.updatesPage.Controls.Add(this.updatesCheckBox);
			this.updatesPage.Location = new System.Drawing.Point(4, 20);
			this.updatesPage.Margin = new System.Windows.Forms.Padding(0);
			this.updatesPage.Name = "updatesPage";
			this.updatesPage.Padding = new System.Windows.Forms.Padding(10);
			this.updatesPage.Size = new System.Drawing.Size(272, 180);
			this.updatesPage.TabIndex = 1;
			this.updatesPage.Text = "Updates";
			// 
			// updatesCheckBox
			// 
			this.updatesCheckBox.Location = new System.Drawing.Point(10, 10);
			this.updatesCheckBox.Margin = new System.Windows.Forms.Padding(0);
			this.updatesCheckBox.Name = "updatesCheckBox";
			this.updatesCheckBox.Size = new System.Drawing.Size(252, 32);
			this.updatesCheckBox.TabIndex = 0;
			this.updatesCheckBox.Text = "Check for updates on app startup";
			this.updatesCheckBox.UseVisualStyleBackColor = true;
			this.updatesCheckBox.CheckedChanged += new System.EventHandler(this.updatesCheckBox_CheckedChanged);
			// 
			// fullscreenPage
			// 
			this.fullscreenPage.BackColor = System.Drawing.Color.White;
			this.fullscreenPage.Controls.Add(this.fullscrCursorCheckBox);
			this.fullscreenPage.Location = new System.Drawing.Point(4, 20);
			this.fullscreenPage.Margin = new System.Windows.Forms.Padding(0);
			this.fullscreenPage.Name = "fullscreenPage";
			this.fullscreenPage.Padding = new System.Windows.Forms.Padding(10);
			this.fullscreenPage.Size = new System.Drawing.Size(272, 180);
			this.fullscreenPage.TabIndex = 2;
			this.fullscreenPage.Text = "Fullscreen";
			// 
			// fullscrCursorCheckBox
			// 
			this.fullscrCursorCheckBox.Location = new System.Drawing.Point(10, 10);
			this.fullscrCursorCheckBox.Margin = new System.Windows.Forms.Padding(0);
			this.fullscrCursorCheckBox.Name = "fullscrCursorCheckBox";
			this.fullscrCursorCheckBox.Size = new System.Drawing.Size(252, 32);
			this.fullscrCursorCheckBox.TabIndex = 1;
			this.fullscrCursorCheckBox.Text = "Show cursor in fullscreen";
			this.fullscrCursorCheckBox.UseVisualStyleBackColor = true;
			this.fullscrCursorCheckBox.CheckedChanged += new System.EventHandler(this.fullscrCursorCheckBox_CheckedChanged);
			// 
			// titlePanel
			// 
			this.titlePanel.Controls.Add(this.titleLabel);
			this.titlePanel.Controls.Add(this.closeBtn);
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Margin = new System.Windows.Forms.Padding(0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(300, 32);
			this.titlePanel.TabIndex = 0;
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(9, 7);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(58, 19);
			this.titleLabel.TabIndex = 16;
			this.titleLabel.Text = "Settings";
			// 
			// closeBtn
			// 
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
			this.closeBtn.Location = new System.Drawing.Point(268, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 1;
			this.aboutTooltip.SetToolTip(this.closeBtn, "Close (Alt+F4)");
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.ClientSize = new System.Drawing.Size(300, 256);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.settingsTabs);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
			this.settingsTabs.ResumeLayout(false);
			this.themePage.ResumeLayout(false);
			this.themePage.PerformLayout();
			this.updatesPage.ResumeLayout(false);
			this.fullscreenPage.ResumeLayout(false);
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private QuickLibrary.QlibRadioButton lightThemeRadio;
		private QuickLibrary.QlibRadioButton systemThemeRadio;
		private QuickLibrary.QlibRadioButton darkThemeRadio;
		private QuickLibrary.QlibCheckBox updatesCheckBox;
		private System.Windows.Forms.Label licenseLabel;
		private QuickLibrary.QlibCheckBox fullscrCursorCheckBox;
		private QuickLibrary.QlibTabControl settingsTabs;
		private System.Windows.Forms.TabPage themePage;
		private System.Windows.Forms.TabPage updatesPage;
		private System.Windows.Forms.TabPage fullscreenPage;
		private System.Windows.Forms.Panel titlePanel;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.ToolTip aboutTooltip;
	}
}
