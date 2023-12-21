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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			settingsTabs = new QuickLibrary.QlibTabs();
			themePage = new System.Windows.Forms.TabPage();
			restartLabel1 = new System.Windows.Forms.Label();
			systemThemeRadio = new QuickLibrary.QlibRadio();
			darkThemeRadio = new QuickLibrary.QlibRadio();
			lightThemeRadio = new QuickLibrary.QlibRadio();
			themeRestart = new System.Windows.Forms.LinkLabel();
			mousePage = new System.Windows.Forms.TabPage();
			mouseWheelActionRadio3 = new QuickLibrary.QlibRadio();
			mouseWheelActionRadio2 = new QuickLibrary.QlibRadio();
			mouseWheelActionRadio1 = new QuickLibrary.QlibRadio();
			mouseWheelActionLabel = new System.Windows.Forms.Label();
			escToExitCheckBox = new QuickLibrary.QlibCheckBox();
			fullscrCursorCheckBox = new QuickLibrary.QlibCheckBox();
			slideshowPage = new System.Windows.Forms.TabPage();
			slideshowSecondsLabel = new System.Windows.Forms.Label();
			slideshowTimeLabel = new System.Windows.Forms.Label();
			slideshowTimeNumeric = new QuickLibrary.QlibNumeric();
			slideshowCounterCheckBox = new QuickLibrary.QlibCheckBox();
			startupPage = new System.Windows.Forms.TabPage();
			startupBoundsCheckBox = new QuickLibrary.QlibCheckBox();
			updatesCheckBox = new QuickLibrary.QlibCheckBox();
			startupPasteCheckBox = new QuickLibrary.QlibCheckBox();
			startupLabel = new System.Windows.Forms.Label();
			externalPage = new System.Windows.Forms.TabPage();
			makeDefaultBtn = new System.Windows.Forms.Button();
			browseWithCheckBox = new QuickLibrary.QlibCheckBox();
			contextMenuLabel = new System.Windows.Forms.Label();
			openWithCheckBox = new QuickLibrary.QlibCheckBox();
			browseBtn = new System.Windows.Forms.Button();
			favExtTextBox = new QuickLibrary.QlibTextBox();
			favExtLabel = new System.Windows.Forms.Label();
			langPage = new System.Windows.Forms.TabPage();
			helpTranslateBtn = new System.Windows.Forms.Button();
			translateAuthorsPanel = new System.Windows.Forms.Panel();
			translatedByLabel = new System.Windows.Forms.Label();
			langLabel = new System.Windows.Forms.Label();
			restartLabel2 = new System.Windows.Forms.Label();
			langComboBox = new QuickLibrary.QlibComboBox();
			localizationRestart = new System.Windows.Forms.LinkLabel();
			closeBtn = new QuickLibrary.QlibTitlebarButton();
			infoTooltip = new System.Windows.Forms.ToolTip(components);
			openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			settingsTabs.SuspendLayout();
			themePage.SuspendLayout();
			mousePage.SuspendLayout();
			slideshowPage.SuspendLayout();
			startupPage.SuspendLayout();
			externalPage.SuspendLayout();
			langPage.SuspendLayout();
			SuspendLayout();
			// 
			// settingsTabs
			// 
			settingsTabs.CausesValidation = false;
			settingsTabs.Controls.Add(themePage);
			settingsTabs.Controls.Add(mousePage);
			settingsTabs.Controls.Add(slideshowPage);
			settingsTabs.Controls.Add(startupPage);
			settingsTabs.Controls.Add(externalPage);
			settingsTabs.Controls.Add(langPage);
			settingsTabs.DarkMode = false;
			settingsTabs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			settingsTabs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			settingsTabs.ItemSize = new System.Drawing.Size(28, 28);
			settingsTabs.Location = new System.Drawing.Point(10, 42);
			settingsTabs.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			settingsTabs.Multiline = true;
			settingsTabs.Name = "settingsTabs";
			settingsTabs.Padding = new System.Drawing.Point(0, 0);
			settingsTabs.RightToLeft = System.Windows.Forms.RightToLeft.No;
			settingsTabs.SelectedIndex = 0;
			settingsTabs.Size = new System.Drawing.Size(400, 290);
			settingsTabs.TabIndex = 0;
			// 
			// themePage
			// 
			themePage.BackColor = System.Drawing.SystemColors.Control;
			themePage.Controls.Add(restartLabel1);
			themePage.Controls.Add(systemThemeRadio);
			themePage.Controls.Add(darkThemeRadio);
			themePage.Controls.Add(lightThemeRadio);
			themePage.Controls.Add(themeRestart);
			themePage.Location = new System.Drawing.Point(4, 60);
			themePage.Margin = new System.Windows.Forms.Padding(0);
			themePage.Name = "themePage";
			themePage.Padding = new System.Windows.Forms.Padding(10);
			themePage.Size = new System.Drawing.Size(392, 226);
			themePage.TabIndex = 0;
			themePage.Text = "theme";
			themePage.ToolTipText = "App theming";
			// 
			// restartLabel1
			// 
			restartLabel1.AutoSize = true;
			restartLabel1.Location = new System.Drawing.Point(10, 197);
			restartLabel1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			restartLabel1.Name = "restartLabel1";
			restartLabel1.Size = new System.Drawing.Size(114, 19);
			restartLabel1.TabIndex = 38;
			restartLabel1.Text = "* restart required";
			// 
			// systemThemeRadio
			// 
			systemThemeRadio.BackColor = System.Drawing.SystemColors.Control;
			systemThemeRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			systemThemeRadio.CausesValidation = false;
			systemThemeRadio.Checked = true;
			systemThemeRadio.DarkMode = false;
			systemThemeRadio.FlatStyle = System.Windows.Forms.FlatStyle.System;
			systemThemeRadio.ForeColor = System.Drawing.Color.Black;
			systemThemeRadio.Image = null;
			systemThemeRadio.Location = new System.Drawing.Point(10, 10);
			systemThemeRadio.Margin = new System.Windows.Forms.Padding(0);
			systemThemeRadio.Name = "systemThemeRadio";
			systemThemeRadio.RightToLeft = System.Windows.Forms.RightToLeft.No;
			systemThemeRadio.Size = new System.Drawing.Size(372, 32);
			systemThemeRadio.TabIndex = 0;
			systemThemeRadio.TabStop = true;
			systemThemeRadio.Text = "system";
			systemThemeRadio.UseMnemonic = false;
			systemThemeRadio.UseVisualStyleBackColor = true;
			systemThemeRadio.CheckedChanged += systemThemeRadio_CheckedChanged;
			// 
			// darkThemeRadio
			// 
			darkThemeRadio.BackColor = System.Drawing.SystemColors.Control;
			darkThemeRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			darkThemeRadio.CausesValidation = false;
			darkThemeRadio.DarkMode = false;
			darkThemeRadio.FlatStyle = System.Windows.Forms.FlatStyle.System;
			darkThemeRadio.ForeColor = System.Drawing.Color.Black;
			darkThemeRadio.Image = null;
			darkThemeRadio.Location = new System.Drawing.Point(10, 74);
			darkThemeRadio.Margin = new System.Windows.Forms.Padding(0);
			darkThemeRadio.Name = "darkThemeRadio";
			darkThemeRadio.RightToLeft = System.Windows.Forms.RightToLeft.No;
			darkThemeRadio.Size = new System.Drawing.Size(372, 32);
			darkThemeRadio.TabIndex = 2;
			darkThemeRadio.Text = "dark";
			darkThemeRadio.UseMnemonic = false;
			darkThemeRadio.UseVisualStyleBackColor = true;
			darkThemeRadio.CheckedChanged += darkThemeRadio_CheckedChanged;
			// 
			// lightThemeRadio
			// 
			lightThemeRadio.BackColor = System.Drawing.SystemColors.Control;
			lightThemeRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			lightThemeRadio.CausesValidation = false;
			lightThemeRadio.DarkMode = false;
			lightThemeRadio.FlatStyle = System.Windows.Forms.FlatStyle.System;
			lightThemeRadio.ForeColor = System.Drawing.Color.Black;
			lightThemeRadio.Image = null;
			lightThemeRadio.Location = new System.Drawing.Point(10, 42);
			lightThemeRadio.Margin = new System.Windows.Forms.Padding(0);
			lightThemeRadio.Name = "lightThemeRadio";
			lightThemeRadio.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lightThemeRadio.Size = new System.Drawing.Size(372, 32);
			lightThemeRadio.TabIndex = 1;
			lightThemeRadio.Text = "light";
			lightThemeRadio.UseMnemonic = false;
			lightThemeRadio.UseVisualStyleBackColor = true;
			lightThemeRadio.CheckedChanged += lightThemeRadio_CheckedChanged;
			// 
			// themeRestart
			// 
			themeRestart.ActiveLinkColor = System.Drawing.Color.FromArgb(100, 100, 100);
			themeRestart.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			themeRestart.Location = new System.Drawing.Point(10, 197);
			themeRestart.Margin = new System.Windows.Forms.Padding(0);
			themeRestart.Name = "themeRestart";
			themeRestart.Size = new System.Drawing.Size(372, 19);
			themeRestart.TabIndex = 3;
			themeRestart.TabStop = true;
			themeRestart.Text = "restart";
			themeRestart.TextAlign = System.Drawing.ContentAlignment.TopRight;
			themeRestart.LinkClicked += restartLink_LinkClicked;
			// 
			// mousePage
			// 
			mousePage.BackColor = System.Drawing.SystemColors.Control;
			mousePage.Controls.Add(mouseWheelActionRadio3);
			mousePage.Controls.Add(mouseWheelActionRadio2);
			mousePage.Controls.Add(mouseWheelActionRadio1);
			mousePage.Controls.Add(mouseWheelActionLabel);
			mousePage.Controls.Add(escToExitCheckBox);
			mousePage.Controls.Add(fullscrCursorCheckBox);
			mousePage.Location = new System.Drawing.Point(4, 60);
			mousePage.Margin = new System.Windows.Forms.Padding(0);
			mousePage.Name = "mousePage";
			mousePage.Padding = new System.Windows.Forms.Padding(10);
			mousePage.Size = new System.Drawing.Size(392, 226);
			mousePage.TabIndex = 2;
			mousePage.Text = "mouse & keyboard";
			mousePage.ToolTipText = "Cursor options";
			// 
			// mouseWheelActionRadio3
			// 
			mouseWheelActionRadio3.BackColor = System.Drawing.SystemColors.Control;
			mouseWheelActionRadio3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			mouseWheelActionRadio3.CausesValidation = false;
			mouseWheelActionRadio3.DarkMode = false;
			mouseWheelActionRadio3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			mouseWheelActionRadio3.ForeColor = System.Drawing.Color.Black;
			mouseWheelActionRadio3.Image = null;
			mouseWheelActionRadio3.Location = new System.Drawing.Point(10, 177);
			mouseWheelActionRadio3.Margin = new System.Windows.Forms.Padding(0);
			mouseWheelActionRadio3.Name = "mouseWheelActionRadio3";
			mouseWheelActionRadio3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			mouseWheelActionRadio3.Size = new System.Drawing.Size(372, 32);
			mouseWheelActionRadio3.TabIndex = 4;
			mouseWheelActionRadio3.Text = "next / previous image";
			mouseWheelActionRadio3.UseMnemonic = false;
			mouseWheelActionRadio3.UseVisualStyleBackColor = true;
			mouseWheelActionRadio3.CheckedChanged += mouseWheelActionRadio3_CheckedChanged;
			// 
			// mouseWheelActionRadio2
			// 
			mouseWheelActionRadio2.BackColor = System.Drawing.SystemColors.Control;
			mouseWheelActionRadio2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			mouseWheelActionRadio2.CausesValidation = false;
			mouseWheelActionRadio2.DarkMode = false;
			mouseWheelActionRadio2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			mouseWheelActionRadio2.ForeColor = System.Drawing.Color.Black;
			mouseWheelActionRadio2.Image = null;
			mouseWheelActionRadio2.Location = new System.Drawing.Point(10, 145);
			mouseWheelActionRadio2.Margin = new System.Windows.Forms.Padding(0);
			mouseWheelActionRadio2.Name = "mouseWheelActionRadio2";
			mouseWheelActionRadio2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			mouseWheelActionRadio2.Size = new System.Drawing.Size(372, 32);
			mouseWheelActionRadio2.TabIndex = 3;
			mouseWheelActionRadio2.Text = "zoom in / out";
			mouseWheelActionRadio2.UseMnemonic = false;
			mouseWheelActionRadio2.UseVisualStyleBackColor = true;
			mouseWheelActionRadio2.CheckedChanged += mouseWheelActionRadio2_CheckedChanged;
			// 
			// mouseWheelActionRadio1
			// 
			mouseWheelActionRadio1.BackColor = System.Drawing.SystemColors.Control;
			mouseWheelActionRadio1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			mouseWheelActionRadio1.CausesValidation = false;
			mouseWheelActionRadio1.Checked = true;
			mouseWheelActionRadio1.DarkMode = false;
			mouseWheelActionRadio1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			mouseWheelActionRadio1.ForeColor = System.Drawing.Color.Black;
			mouseWheelActionRadio1.Image = null;
			mouseWheelActionRadio1.Location = new System.Drawing.Point(10, 113);
			mouseWheelActionRadio1.Margin = new System.Windows.Forms.Padding(0);
			mouseWheelActionRadio1.Name = "mouseWheelActionRadio1";
			mouseWheelActionRadio1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			mouseWheelActionRadio1.Size = new System.Drawing.Size(372, 32);
			mouseWheelActionRadio1.TabIndex = 2;
			mouseWheelActionRadio1.TabStop = true;
			mouseWheelActionRadio1.Text = "scroll up / down";
			mouseWheelActionRadio1.UseMnemonic = false;
			mouseWheelActionRadio1.UseVisualStyleBackColor = true;
			mouseWheelActionRadio1.CheckedChanged += mouseWheelActionRadio1_CheckedChanged;
			// 
			// mouseWheelActionLabel
			// 
			mouseWheelActionLabel.AutoSize = true;
			mouseWheelActionLabel.Location = new System.Drawing.Point(10, 84);
			mouseWheelActionLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			mouseWheelActionLabel.Name = "mouseWheelActionLabel";
			mouseWheelActionLabel.Size = new System.Drawing.Size(168, 19);
			mouseWheelActionLabel.TabIndex = 42;
			mouseWheelActionLabel.Text = "mouse wheel scroll action:";
			// 
			// escToExitCheckBox
			// 
			escToExitCheckBox.BackColor = System.Drawing.SystemColors.Control;
			escToExitCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			escToExitCheckBox.CausesValidation = false;
			escToExitCheckBox.DarkMode = false;
			escToExitCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			escToExitCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			escToExitCheckBox.ForeColor = System.Drawing.Color.Black;
			escToExitCheckBox.Image = null;
			escToExitCheckBox.Location = new System.Drawing.Point(10, 42);
			escToExitCheckBox.Margin = new System.Windows.Forms.Padding(0);
			escToExitCheckBox.Name = "escToExitCheckBox";
			escToExitCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			escToExitCheckBox.Size = new System.Drawing.Size(372, 32);
			escToExitCheckBox.TabIndex = 1;
			escToExitCheckBox.Text = "press esc to exit";
			escToExitCheckBox.UseMnemonic = false;
			escToExitCheckBox.UseVisualStyleBackColor = true;
			escToExitCheckBox.CheckedChanged += escToExitCheckBox_CheckedChanged;
			// 
			// fullscrCursorCheckBox
			// 
			fullscrCursorCheckBox.BackColor = System.Drawing.SystemColors.Control;
			fullscrCursorCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			fullscrCursorCheckBox.CausesValidation = false;
			fullscrCursorCheckBox.DarkMode = false;
			fullscrCursorCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			fullscrCursorCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			fullscrCursorCheckBox.ForeColor = System.Drawing.Color.Black;
			fullscrCursorCheckBox.Image = null;
			fullscrCursorCheckBox.Location = new System.Drawing.Point(10, 10);
			fullscrCursorCheckBox.Margin = new System.Windows.Forms.Padding(0);
			fullscrCursorCheckBox.Name = "fullscrCursorCheckBox";
			fullscrCursorCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			fullscrCursorCheckBox.Size = new System.Drawing.Size(372, 32);
			fullscrCursorCheckBox.TabIndex = 0;
			fullscrCursorCheckBox.Text = "show cursor in fullscreen";
			fullscrCursorCheckBox.UseMnemonic = false;
			fullscrCursorCheckBox.UseVisualStyleBackColor = true;
			fullscrCursorCheckBox.CheckedChanged += fullscrCursorCheckBox_CheckedChanged;
			// 
			// slideshowPage
			// 
			slideshowPage.BackColor = System.Drawing.SystemColors.Control;
			slideshowPage.Controls.Add(slideshowSecondsLabel);
			slideshowPage.Controls.Add(slideshowTimeLabel);
			slideshowPage.Controls.Add(slideshowTimeNumeric);
			slideshowPage.Controls.Add(slideshowCounterCheckBox);
			slideshowPage.Location = new System.Drawing.Point(4, 60);
			slideshowPage.Margin = new System.Windows.Forms.Padding(0);
			slideshowPage.Name = "slideshowPage";
			slideshowPage.Padding = new System.Windows.Forms.Padding(10);
			slideshowPage.Size = new System.Drawing.Size(392, 226);
			slideshowPage.TabIndex = 5;
			slideshowPage.Text = "slideshow";
			// 
			// slideshowSecondsLabel
			// 
			slideshowSecondsLabel.AutoSize = true;
			slideshowSecondsLabel.Location = new System.Drawing.Point(100, 45);
			slideshowSecondsLabel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			slideshowSecondsLabel.Name = "slideshowSecondsLabel";
			slideshowSecondsLabel.Size = new System.Drawing.Size(58, 19);
			slideshowSecondsLabel.TabIndex = 4;
			slideshowSecondsLabel.Text = "seconds";
			// 
			// slideshowTimeLabel
			// 
			slideshowTimeLabel.AutoSize = true;
			slideshowTimeLabel.Location = new System.Drawing.Point(10, 10);
			slideshowTimeLabel.Margin = new System.Windows.Forms.Padding(0);
			slideshowTimeLabel.Name = "slideshowTimeLabel";
			slideshowTimeLabel.Size = new System.Drawing.Size(100, 19);
			slideshowTimeLabel.TabIndex = 3;
			slideshowTimeLabel.Text = "switching time:";
			// 
			// slideshowTimeNumeric
			// 
			slideshowTimeNumeric.AutoScrollMargin = new System.Drawing.Size(0, 0);
			slideshowTimeNumeric.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			slideshowTimeNumeric.BackColor = System.Drawing.SystemColors.ControlLight;
			slideshowTimeNumeric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			slideshowTimeNumeric.CausesValidation = false;
			slideshowTimeNumeric.Cursor = System.Windows.Forms.Cursors.IBeam;
			slideshowTimeNumeric.DarkMode = false;
			slideshowTimeNumeric.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			slideshowTimeNumeric.ForeColor = System.Drawing.Color.Black;
			slideshowTimeNumeric.Location = new System.Drawing.Point(10, 39);
			slideshowTimeNumeric.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			slideshowTimeNumeric.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
			slideshowTimeNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			slideshowTimeNumeric.Name = "slideshowTimeNumeric";
			slideshowTimeNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
			slideshowTimeNumeric.Size = new System.Drawing.Size(80, 32);
			slideshowTimeNumeric.TabIndex = 0;
			slideshowTimeNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
			slideshowTimeNumeric.ValueChanged += slideshowTimeNumeric_ValueChanged;
			// 
			// slideshowCounterCheckBox
			// 
			slideshowCounterCheckBox.BackColor = System.Drawing.SystemColors.Control;
			slideshowCounterCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			slideshowCounterCheckBox.CausesValidation = false;
			slideshowCounterCheckBox.DarkMode = false;
			slideshowCounterCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			slideshowCounterCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			slideshowCounterCheckBox.ForeColor = System.Drawing.Color.Black;
			slideshowCounterCheckBox.Image = null;
			slideshowCounterCheckBox.Location = new System.Drawing.Point(10, 81);
			slideshowCounterCheckBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			slideshowCounterCheckBox.Name = "slideshowCounterCheckBox";
			slideshowCounterCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			slideshowCounterCheckBox.Size = new System.Drawing.Size(372, 32);
			slideshowCounterCheckBox.TabIndex = 1;
			slideshowCounterCheckBox.Text = "show slideshow counter";
			slideshowCounterCheckBox.UseMnemonic = false;
			slideshowCounterCheckBox.UseVisualStyleBackColor = true;
			slideshowCounterCheckBox.CheckedChanged += slideshowCounterCheckBox_CheckedChanged;
			// 
			// startupPage
			// 
			startupPage.BackColor = System.Drawing.SystemColors.Control;
			startupPage.Controls.Add(startupBoundsCheckBox);
			startupPage.Controls.Add(updatesCheckBox);
			startupPage.Controls.Add(startupPasteCheckBox);
			startupPage.Controls.Add(startupLabel);
			startupPage.Location = new System.Drawing.Point(4, 60);
			startupPage.Margin = new System.Windows.Forms.Padding(0);
			startupPage.Name = "startupPage";
			startupPage.Padding = new System.Windows.Forms.Padding(10);
			startupPage.Size = new System.Drawing.Size(392, 226);
			startupPage.TabIndex = 3;
			startupPage.Text = "startup";
			startupPage.ToolTipText = "App startup action";
			// 
			// startupBoundsCheckBox
			// 
			startupBoundsCheckBox.BackColor = System.Drawing.SystemColors.Control;
			startupBoundsCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			startupBoundsCheckBox.CausesValidation = false;
			startupBoundsCheckBox.DarkMode = false;
			startupBoundsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			startupBoundsCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			startupBoundsCheckBox.ForeColor = System.Drawing.Color.Black;
			startupBoundsCheckBox.Image = null;
			startupBoundsCheckBox.Location = new System.Drawing.Point(10, 71);
			startupBoundsCheckBox.Margin = new System.Windows.Forms.Padding(0);
			startupBoundsCheckBox.Name = "startupBoundsCheckBox";
			startupBoundsCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			startupBoundsCheckBox.Size = new System.Drawing.Size(372, 32);
			startupBoundsCheckBox.TabIndex = 1;
			startupBoundsCheckBox.Text = "bounds";
			startupBoundsCheckBox.UseMnemonic = false;
			startupBoundsCheckBox.UseVisualStyleBackColor = true;
			startupBoundsCheckBox.CheckedChanged += startupBoundsCheckBox_CheckedChanged;
			// 
			// updatesCheckBox
			// 
			updatesCheckBox.BackColor = System.Drawing.SystemColors.Control;
			updatesCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			updatesCheckBox.CausesValidation = false;
			updatesCheckBox.DarkMode = false;
			updatesCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			updatesCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			updatesCheckBox.ForeColor = System.Drawing.Color.Black;
			updatesCheckBox.Image = null;
			updatesCheckBox.Location = new System.Drawing.Point(10, 39);
			updatesCheckBox.Margin = new System.Windows.Forms.Padding(0);
			updatesCheckBox.Name = "updatesCheckBox";
			updatesCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			updatesCheckBox.Size = new System.Drawing.Size(372, 32);
			updatesCheckBox.TabIndex = 0;
			updatesCheckBox.Text = "check for app updates";
			updatesCheckBox.UseMnemonic = false;
			updatesCheckBox.UseVisualStyleBackColor = true;
			updatesCheckBox.CheckedChanged += updatesCheckBox_CheckedChanged;
			// 
			// startupPasteCheckBox
			// 
			startupPasteCheckBox.BackColor = System.Drawing.SystemColors.Control;
			startupPasteCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			startupPasteCheckBox.CausesValidation = false;
			startupPasteCheckBox.DarkMode = false;
			startupPasteCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			startupPasteCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			startupPasteCheckBox.ForeColor = System.Drawing.Color.Black;
			startupPasteCheckBox.Image = null;
			startupPasteCheckBox.Location = new System.Drawing.Point(10, 103);
			startupPasteCheckBox.Margin = new System.Windows.Forms.Padding(0);
			startupPasteCheckBox.Name = "startupPasteCheckBox";
			startupPasteCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			startupPasteCheckBox.Size = new System.Drawing.Size(372, 32);
			startupPasteCheckBox.TabIndex = 2;
			startupPasteCheckBox.Text = "paste";
			startupPasteCheckBox.UseMnemonic = false;
			startupPasteCheckBox.UseVisualStyleBackColor = true;
			startupPasteCheckBox.CheckedChanged += startupPasteCheckBox_CheckedChanged;
			// 
			// startupLabel
			// 
			startupLabel.AutoSize = true;
			startupLabel.Location = new System.Drawing.Point(10, 10);
			startupLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			startupLabel.Name = "startupLabel";
			startupLabel.Size = new System.Drawing.Size(103, 19);
			startupLabel.TabIndex = 42;
			startupLabel.Text = "startup actions:";
			// 
			// externalPage
			// 
			externalPage.BackColor = System.Drawing.SystemColors.Control;
			externalPage.Controls.Add(makeDefaultBtn);
			externalPage.Controls.Add(browseWithCheckBox);
			externalPage.Controls.Add(contextMenuLabel);
			externalPage.Controls.Add(openWithCheckBox);
			externalPage.Controls.Add(browseBtn);
			externalPage.Controls.Add(favExtTextBox);
			externalPage.Controls.Add(favExtLabel);
			externalPage.Location = new System.Drawing.Point(4, 60);
			externalPage.Margin = new System.Windows.Forms.Padding(0);
			externalPage.Name = "externalPage";
			externalPage.Padding = new System.Windows.Forms.Padding(10);
			externalPage.Size = new System.Drawing.Size(392, 226);
			externalPage.TabIndex = 4;
			externalPage.Text = "Windows";
			// 
			// makeDefaultBtn
			// 
			makeDefaultBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			makeDefaultBtn.Enabled = false;
			makeDefaultBtn.FlatAppearance.BorderSize = 0;
			makeDefaultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			makeDefaultBtn.Location = new System.Drawing.Point(10, 10);
			makeDefaultBtn.Margin = new System.Windows.Forms.Padding(0);
			makeDefaultBtn.Name = "makeDefaultBtn";
			makeDefaultBtn.Size = new System.Drawing.Size(372, 32);
			makeDefaultBtn.TabIndex = 0;
			makeDefaultBtn.Text = "set as default photo viewer";
			makeDefaultBtn.UseVisualStyleBackColor = false;
			makeDefaultBtn.Click += makeDefaultBtn_Click;
			// 
			// browseWithCheckBox
			// 
			browseWithCheckBox.BackColor = System.Drawing.SystemColors.Control;
			browseWithCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			browseWithCheckBox.CausesValidation = false;
			browseWithCheckBox.DarkMode = false;
			browseWithCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			browseWithCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			browseWithCheckBox.ForeColor = System.Drawing.Color.Black;
			browseWithCheckBox.Image = null;
			browseWithCheckBox.Location = new System.Drawing.Point(10, 113);
			browseWithCheckBox.Margin = new System.Windows.Forms.Padding(0);
			browseWithCheckBox.Name = "browseWithCheckBox";
			browseWithCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			browseWithCheckBox.Size = new System.Drawing.Size(372, 32);
			browseWithCheckBox.TabIndex = 2;
			browseWithCheckBox.Text = "browse folder with qpv";
			browseWithCheckBox.UseMnemonic = false;
			browseWithCheckBox.UseVisualStyleBackColor = true;
			browseWithCheckBox.CheckedChanged += browseWithCheckBox_CheckedChanged;
			// 
			// contextMenuLabel
			// 
			contextMenuLabel.AutoSize = true;
			contextMenuLabel.Location = new System.Drawing.Point(6, 52);
			contextMenuLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			contextMenuLabel.Name = "contextMenuLabel";
			contextMenuLabel.Size = new System.Drawing.Size(96, 19);
			contextMenuLabel.TabIndex = 45;
			contextMenuLabel.Text = "context menu:";
			// 
			// openWithCheckBox
			// 
			openWithCheckBox.BackColor = System.Drawing.SystemColors.Control;
			openWithCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			openWithCheckBox.CausesValidation = false;
			openWithCheckBox.DarkMode = false;
			openWithCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			openWithCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			openWithCheckBox.ForeColor = System.Drawing.Color.Black;
			openWithCheckBox.Image = null;
			openWithCheckBox.Location = new System.Drawing.Point(10, 81);
			openWithCheckBox.Margin = new System.Windows.Forms.Padding(0);
			openWithCheckBox.Name = "openWithCheckBox";
			openWithCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			openWithCheckBox.Size = new System.Drawing.Size(372, 32);
			openWithCheckBox.TabIndex = 1;
			openWithCheckBox.Text = "open with qpv";
			openWithCheckBox.UseMnemonic = false;
			openWithCheckBox.UseVisualStyleBackColor = true;
			openWithCheckBox.CheckedChanged += openWithCheckBox_CheckedChanged;
			// 
			// browseBtn
			// 
			browseBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			browseBtn.FlatAppearance.BorderSize = 0;
			browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			browseBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			browseBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			browseBtn.Image = Properties.Resources.black_open;
			browseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			browseBtn.Location = new System.Drawing.Point(262, 184);
			browseBtn.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
			browseBtn.Name = "browseBtn";
			browseBtn.Size = new System.Drawing.Size(120, 32);
			browseBtn.TabIndex = 4;
			browseBtn.Text = " browse";
			browseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			browseBtn.UseVisualStyleBackColor = false;
			browseBtn.Click += browseBtn_Click;
			// 
			// favExtTextBox
			// 
			favExtTextBox.AutoScrollMargin = new System.Drawing.Size(0, 0);
			favExtTextBox.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			favExtTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			favExtTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			favExtTextBox.CausesValidation = false;
			favExtTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			favExtTextBox.DarkMode = false;
			favExtTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			favExtTextBox.ForeColor = System.Drawing.Color.Black;
			favExtTextBox.Location = new System.Drawing.Point(10, 184);
			favExtTextBox.Margin = new System.Windows.Forms.Padding(0);
			favExtTextBox.Name = "favExtTextBox";
			favExtTextBox.ReadOnly = false;
			favExtTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			favExtTextBox.Size = new System.Drawing.Size(242, 32);
			favExtTextBox.TabIndex = 3;
			favExtTextBox.WordWrap = true;
			favExtTextBox.TextChanged += favExtTextBox_TextChanged;
			// 
			// favExtLabel
			// 
			favExtLabel.AutoSize = true;
			favExtLabel.Location = new System.Drawing.Point(6, 155);
			favExtLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			favExtLabel.Name = "favExtLabel";
			favExtLabel.Size = new System.Drawing.Size(137, 19);
			favExtLabel.TabIndex = 0;
			favExtLabel.Text = "favorite external app:";
			// 
			// langPage
			// 
			langPage.BackColor = System.Drawing.SystemColors.Control;
			langPage.Controls.Add(helpTranslateBtn);
			langPage.Controls.Add(translateAuthorsPanel);
			langPage.Controls.Add(translatedByLabel);
			langPage.Controls.Add(langLabel);
			langPage.Controls.Add(restartLabel2);
			langPage.Controls.Add(langComboBox);
			langPage.Controls.Add(localizationRestart);
			langPage.Location = new System.Drawing.Point(4, 60);
			langPage.Margin = new System.Windows.Forms.Padding(0);
			langPage.Name = "langPage";
			langPage.Padding = new System.Windows.Forms.Padding(10);
			langPage.Size = new System.Drawing.Size(392, 226);
			langPage.TabIndex = 6;
			langPage.Text = "localization";
			// 
			// helpTranslateBtn
			// 
			helpTranslateBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			helpTranslateBtn.FlatAppearance.BorderSize = 0;
			helpTranslateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			helpTranslateBtn.Location = new System.Drawing.Point(10, 110);
			helpTranslateBtn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			helpTranslateBtn.Name = "helpTranslateBtn";
			helpTranslateBtn.Size = new System.Drawing.Size(372, 32);
			helpTranslateBtn.TabIndex = 2;
			helpTranslateBtn.Text = "help us to translate the app";
			helpTranslateBtn.UseVisualStyleBackColor = false;
			helpTranslateBtn.Click += helpTranslateBtn_Click;
			// 
			// translateAuthorsPanel
			// 
			translateAuthorsPanel.Location = new System.Drawing.Point(102, 81);
			translateAuthorsPanel.Margin = new System.Windows.Forms.Padding(0);
			translateAuthorsPanel.Name = "translateAuthorsPanel";
			translateAuthorsPanel.Size = new System.Drawing.Size(280, 19);
			translateAuthorsPanel.TabIndex = 1;
			// 
			// translatedByLabel
			// 
			translatedByLabel.AutoSize = true;
			translatedByLabel.Location = new System.Drawing.Point(10, 81);
			translatedByLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			translatedByLabel.Name = "translatedByLabel";
			translatedByLabel.Size = new System.Drawing.Size(92, 19);
			translatedByLabel.TabIndex = 42;
			translatedByLabel.Text = "translated by:";
			// 
			// langLabel
			// 
			langLabel.AutoSize = true;
			langLabel.Location = new System.Drawing.Point(10, 10);
			langLabel.Margin = new System.Windows.Forms.Padding(0);
			langLabel.Name = "langLabel";
			langLabel.Size = new System.Drawing.Size(68, 19);
			langLabel.TabIndex = 41;
			langLabel.Text = "language:";
			// 
			// restartLabel2
			// 
			restartLabel2.AutoSize = true;
			restartLabel2.Location = new System.Drawing.Point(10, 197);
			restartLabel2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			restartLabel2.Name = "restartLabel2";
			restartLabel2.Size = new System.Drawing.Size(114, 19);
			restartLabel2.TabIndex = 39;
			restartLabel2.Text = "* restart required";
			// 
			// langComboBox
			// 
			langComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
			langComboBox.CausesValidation = false;
			langComboBox.DarkMode = false;
			langComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			langComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			langComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			langComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			langComboBox.ForeColor = System.Drawing.Color.Black;
			langComboBox.FormattingEnabled = true;
			langComboBox.IntegralHeight = false;
			langComboBox.ItemHeight = 26;
			langComboBox.Items.AddRange(new object[] { "English", "Arabic (عربي)", "Chinese (中文)", "Croatian (Hrvatski)", "French (Français)", "German (Deutsch)", "Hungarian (Magyar)", "Russian (Русский)", "Spanish (Española)", "Turkish (Türkçe)" });
			langComboBox.Location = new System.Drawing.Point(10, 39);
			langComboBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			langComboBox.Name = "langComboBox";
			langComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			langComboBox.Size = new System.Drawing.Size(372, 32);
			langComboBox.TabIndex = 0;
			langComboBox.SelectedIndexChanged += langComboBox_SelectedIndexChanged;
			// 
			// localizationRestart
			// 
			localizationRestart.ActiveLinkColor = System.Drawing.Color.FromArgb(100, 100, 100);
			localizationRestart.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			localizationRestart.Location = new System.Drawing.Point(10, 197);
			localizationRestart.Margin = new System.Windows.Forms.Padding(0);
			localizationRestart.Name = "localizationRestart";
			localizationRestart.Size = new System.Drawing.Size(372, 19);
			localizationRestart.TabIndex = 3;
			localizationRestart.TabStop = true;
			localizationRestart.Text = "restart";
			localizationRestart.TextAlign = System.Drawing.ContentAlignment.TopRight;
			localizationRestart.LinkClicked += restartLink_LinkClicked;
			// 
			// closeBtn
			// 
			closeBtn.DarkImage = Properties.Resources.black_close;
			closeBtn.DarkMode = false;
			closeBtn.FlatAppearance.BorderSize = 0;
			closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(140, 140, 140);
			closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
			closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			closeBtn.ForeColor = System.Drawing.Color.Black;
			closeBtn.Image = Properties.Resources.black_close;
			closeBtn.IsRed = true;
			closeBtn.LightImage = Properties.Resources.white_close;
			closeBtn.Location = new System.Drawing.Point(388, 0);
			closeBtn.Margin = new System.Windows.Forms.Padding(0);
			closeBtn.Name = "closeBtn";
			closeBtn.Size = new System.Drawing.Size(32, 32);
			closeBtn.TabIndex = 1;
			closeBtn.UseVisualStyleBackColor = true;
			closeBtn.Click += closeBtn_Click;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			openFileDialog1.Filter = "App executable|*.exe";
			// 
			// SettingsForm
			// 
			AlternativeAppearance = true;
			AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			ClientSize = new System.Drawing.Size(420, 342);
			Controls.Add(closeBtn);
			Controls.Add(settingsTabs);
			Draggable = true;
			EscToClose = true;
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "SettingsForm";
			ShowIcon = false;
			ShowInTaskbar = false;
			ShowTitle = true;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "SettingsForm";
			Load += SettingsForm_Load;
			settingsTabs.ResumeLayout(false);
			themePage.ResumeLayout(false);
			themePage.PerformLayout();
			mousePage.ResumeLayout(false);
			mousePage.PerformLayout();
			slideshowPage.ResumeLayout(false);
			slideshowPage.PerformLayout();
			startupPage.ResumeLayout(false);
			startupPage.PerformLayout();
			externalPage.ResumeLayout(false);
			externalPage.PerformLayout();
			langPage.ResumeLayout(false);
			langPage.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private QuickLibrary.QlibRadio lightThemeRadio;
		private QuickLibrary.QlibRadio systemThemeRadio;
		private QuickLibrary.QlibRadio darkThemeRadio;
		private System.Windows.Forms.Label restartLabel1;
		private QuickLibrary.QlibCheckBox fullscrCursorCheckBox;
		private QuickLibrary.QlibTabs settingsTabs;
		private System.Windows.Forms.TabPage themePage;
		private System.Windows.Forms.TabPage mousePage;
		private System.Windows.Forms.ToolTip infoTooltip;
		private QuickLibrary.QlibTitlebarButton closeBtn;
		private System.Windows.Forms.TabPage startupPage;
		private System.Windows.Forms.Label startupLabel;
		private System.Windows.Forms.TabPage externalPage;
		private System.Windows.Forms.Label favExtLabel;
		private QuickLibrary.QlibTextBox favExtTextBox;
		private System.Windows.Forms.Button browseBtn;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TabPage slideshowPage;
		private QuickLibrary.QlibCheckBox slideshowCounterCheckBox;
		private QuickLibrary.QlibNumeric slideshowTimeNumeric;
		private System.Windows.Forms.Label slideshowTimeLabel;
		private System.Windows.Forms.Label slideshowSecondsLabel;
		private System.Windows.Forms.TabPage langPage;
		private QuickLibrary.QlibComboBox langComboBox;
		private System.Windows.Forms.Label restartLabel2;
		private System.Windows.Forms.Label langLabel;
		private System.Windows.Forms.Label translatedByLabel;
		private System.Windows.Forms.Panel translateAuthorsPanel;
		private QuickLibrary.QlibCheckBox escToExitCheckBox;
		private System.Windows.Forms.Label mouseWheelActionLabel;
		private QuickLibrary.QlibRadio mouseWheelActionRadio1;
		private QuickLibrary.QlibRadio mouseWheelActionRadio2;
		private QuickLibrary.QlibRadio mouseWheelActionRadio3;
		private System.Windows.Forms.LinkLabel themeRestart;
		private System.Windows.Forms.LinkLabel localizationRestart;
		private QuickLibrary.QlibCheckBox startupPasteCheckBox;
		private QuickLibrary.QlibCheckBox updatesCheckBox;
		private QuickLibrary.QlibCheckBox startupBoundsCheckBox;
		private QuickLibrary.QlibCheckBox openWithCheckBox;
		private System.Windows.Forms.Label contextMenuLabel;
		private QuickLibrary.QlibCheckBox browseWithCheckBox;
		private System.Windows.Forms.Button makeDefaultBtn;
		private System.Windows.Forms.Button helpTranslateBtn;
	}
}
