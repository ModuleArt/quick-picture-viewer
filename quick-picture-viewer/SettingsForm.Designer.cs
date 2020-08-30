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
			this.restartLabel1 = new System.Windows.Forms.Label();
			this.systemThemeRadio = new QuickLibrary.QlibRadioButton();
			this.darkThemeRadio = new QuickLibrary.QlibRadioButton();
			this.lightThemeRadio = new QuickLibrary.QlibRadioButton();
			this.updatesPage = new System.Windows.Forms.TabPage();
			this.updatesCheckBox = new QuickLibrary.QlibCheckBox();
			this.mousePage = new System.Windows.Forms.TabPage();
			this.zoomWheelCheckBox = new QuickLibrary.QlibCheckBox();
			this.fullscrCursorCheckBox = new QuickLibrary.QlibCheckBox();
			this.slideshowPage = new System.Windows.Forms.TabPage();
			this.slideshowSecondsLabel = new System.Windows.Forms.Label();
			this.slideshowTimeLabel = new System.Windows.Forms.Label();
			this.slideshowTimeNumeric = new QuickLibrary.QlibNumericBox();
			this.slideshowCounterCheckBox = new QuickLibrary.QlibCheckBox();
			this.startupPage = new System.Windows.Forms.TabPage();
			this.startupLabel = new System.Windows.Forms.Label();
			this.startupNothingRadio = new QuickLibrary.QlibRadioButton();
			this.startupPasteRadio = new QuickLibrary.QlibRadioButton();
			this.externalPage = new System.Windows.Forms.TabPage();
			this.browseBtn = new System.Windows.Forms.Button();
			this.favExtTextBox = new QuickLibrary.QlibTextBox();
			this.favExtLabel = new System.Windows.Forms.Label();
			this.langPage = new System.Windows.Forms.TabPage();
			this.langLabel = new System.Windows.Forms.Label();
			this.translatedByLink = new System.Windows.Forms.LinkLabel();
			this.restartLabel2 = new System.Windows.Forms.Label();
			this.langComboBox = new QuickLibrary.QlibComboBox();
			this.titlePanel = new System.Windows.Forms.Panel();
			this.closeBtn = new QuickLibrary.QlibTitlebarButton();
			this.titleLabel = new System.Windows.Forms.Label();
			this.infoTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.settingsTabs.SuspendLayout();
			this.themePage.SuspendLayout();
			this.updatesPage.SuspendLayout();
			this.mousePage.SuspendLayout();
			this.slideshowPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.slideshowTimeNumeric)).BeginInit();
			this.startupPage.SuspendLayout();
			this.externalPage.SuspendLayout();
			this.langPage.SuspendLayout();
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
			this.settingsTabs.Controls.Add(this.mousePage);
			this.settingsTabs.Controls.Add(this.slideshowPage);
			this.settingsTabs.Controls.Add(this.startupPage);
			this.settingsTabs.Controls.Add(this.externalPage);
			this.settingsTabs.Controls.Add(this.langPage);
			this.settingsTabs.EnableDragDrop = false;
			this.settingsTabs.HeaderColor = System.Drawing.SystemColors.ControlLight;
			this.settingsTabs.HorizontalLineColor = System.Drawing.Color.Transparent;
			this.settingsTabs.ItemSize = new System.Drawing.Size(240, 28);
			this.settingsTabs.Location = new System.Drawing.Point(10, 42);
			this.settingsTabs.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.settingsTabs.Multiline = true;
			this.settingsTabs.Name = "settingsTabs";
			this.settingsTabs.Padding = new System.Drawing.Point(0, 0);
			this.settingsTabs.SelectedIndex = 0;
			this.settingsTabs.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.settingsTabs.ShowClosingButton = false;
			this.settingsTabs.ShowClosingMessage = false;
			this.settingsTabs.Size = new System.Drawing.Size(320, 216);
			this.settingsTabs.TabIndex = 1;
			this.settingsTabs.TextColor = System.Drawing.Color.Black;
			// 
			// themePage
			// 
			this.themePage.BackColor = System.Drawing.Color.White;
			this.themePage.Controls.Add(this.restartLabel1);
			this.themePage.Controls.Add(this.systemThemeRadio);
			this.themePage.Controls.Add(this.darkThemeRadio);
			this.themePage.Controls.Add(this.lightThemeRadio);
			this.themePage.Location = new System.Drawing.Point(4, 60);
			this.themePage.Margin = new System.Windows.Forms.Padding(0);
			this.themePage.Name = "themePage";
			this.themePage.Padding = new System.Windows.Forms.Padding(10);
			this.themePage.Size = new System.Drawing.Size(312, 152);
			this.themePage.TabIndex = 0;
			this.themePage.Text = "theme";
			this.themePage.ToolTipText = "App theming";
			// 
			// restartLabel1
			// 
			this.restartLabel1.AutoSize = true;
			this.restartLabel1.Location = new System.Drawing.Point(10, 116);
			this.restartLabel1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.restartLabel1.Name = "restartLabel1";
			this.restartLabel1.Size = new System.Drawing.Size(114, 19);
			this.restartLabel1.TabIndex = 38;
			this.restartLabel1.Text = "* restart required";
			// 
			// systemThemeRadio
			// 
			this.systemThemeRadio.Checked = true;
			this.systemThemeRadio.Location = new System.Drawing.Point(10, 10);
			this.systemThemeRadio.Margin = new System.Windows.Forms.Padding(0);
			this.systemThemeRadio.Name = "systemThemeRadio";
			this.systemThemeRadio.Size = new System.Drawing.Size(292, 32);
			this.systemThemeRadio.TabIndex = 0;
			this.systemThemeRadio.TabStop = true;
			this.systemThemeRadio.Text = "system";
			this.systemThemeRadio.UseVisualStyleBackColor = true;
			this.systemThemeRadio.CheckedChanged += new System.EventHandler(this.systemThemeRadio_CheckedChanged);
			// 
			// darkThemeRadio
			// 
			this.darkThemeRadio.Location = new System.Drawing.Point(10, 74);
			this.darkThemeRadio.Margin = new System.Windows.Forms.Padding(0);
			this.darkThemeRadio.Name = "darkThemeRadio";
			this.darkThemeRadio.Size = new System.Drawing.Size(292, 32);
			this.darkThemeRadio.TabIndex = 2;
			this.darkThemeRadio.Text = "dark";
			this.darkThemeRadio.UseVisualStyleBackColor = true;
			this.darkThemeRadio.CheckedChanged += new System.EventHandler(this.darkThemeRadio_CheckedChanged);
			// 
			// lightThemeRadio
			// 
			this.lightThemeRadio.Location = new System.Drawing.Point(10, 42);
			this.lightThemeRadio.Margin = new System.Windows.Forms.Padding(0);
			this.lightThemeRadio.Name = "lightThemeRadio";
			this.lightThemeRadio.Size = new System.Drawing.Size(292, 32);
			this.lightThemeRadio.TabIndex = 1;
			this.lightThemeRadio.Text = "light";
			this.lightThemeRadio.UseVisualStyleBackColor = true;
			this.lightThemeRadio.CheckedChanged += new System.EventHandler(this.lightThemeRadio_CheckedChanged);
			// 
			// updatesPage
			// 
			this.updatesPage.BackColor = System.Drawing.Color.White;
			this.updatesPage.Controls.Add(this.updatesCheckBox);
			this.updatesPage.Location = new System.Drawing.Point(4, 60);
			this.updatesPage.Margin = new System.Windows.Forms.Padding(0);
			this.updatesPage.Name = "updatesPage";
			this.updatesPage.Padding = new System.Windows.Forms.Padding(10);
			this.updatesPage.Size = new System.Drawing.Size(312, 152);
			this.updatesPage.TabIndex = 1;
			this.updatesPage.Text = "updates";
			this.updatesPage.ToolTipText = "Update checker";
			// 
			// updatesCheckBox
			// 
			this.updatesCheckBox.Location = new System.Drawing.Point(10, 10);
			this.updatesCheckBox.Margin = new System.Windows.Forms.Padding(0);
			this.updatesCheckBox.Name = "updatesCheckBox";
			this.updatesCheckBox.Size = new System.Drawing.Size(292, 32);
			this.updatesCheckBox.TabIndex = 0;
			this.updatesCheckBox.Text = "check for updates on startup";
			this.updatesCheckBox.UseVisualStyleBackColor = true;
			this.updatesCheckBox.CheckedChanged += new System.EventHandler(this.updatesCheckBox_CheckedChanged);
			// 
			// mousePage
			// 
			this.mousePage.BackColor = System.Drawing.Color.White;
			this.mousePage.Controls.Add(this.zoomWheelCheckBox);
			this.mousePage.Controls.Add(this.fullscrCursorCheckBox);
			this.mousePage.Location = new System.Drawing.Point(4, 60);
			this.mousePage.Margin = new System.Windows.Forms.Padding(0);
			this.mousePage.Name = "mousePage";
			this.mousePage.Padding = new System.Windows.Forms.Padding(10);
			this.mousePage.Size = new System.Drawing.Size(312, 152);
			this.mousePage.TabIndex = 2;
			this.mousePage.Text = "mouse";
			this.mousePage.ToolTipText = "Cursor options";
			// 
			// zoomWheelCheckBox
			// 
			this.zoomWheelCheckBox.Location = new System.Drawing.Point(10, 42);
			this.zoomWheelCheckBox.Margin = new System.Windows.Forms.Padding(0);
			this.zoomWheelCheckBox.Name = "zoomWheelCheckBox";
			this.zoomWheelCheckBox.Size = new System.Drawing.Size(292, 32);
			this.zoomWheelCheckBox.TabIndex = 2;
			this.zoomWheelCheckBox.Text = "mouse wheel to zoom";
			this.zoomWheelCheckBox.UseVisualStyleBackColor = true;
			this.zoomWheelCheckBox.CheckedChanged += new System.EventHandler(this.zoomWheelCheckBox_CheckedChanged);
			// 
			// fullscrCursorCheckBox
			// 
			this.fullscrCursorCheckBox.Location = new System.Drawing.Point(10, 10);
			this.fullscrCursorCheckBox.Margin = new System.Windows.Forms.Padding(0);
			this.fullscrCursorCheckBox.Name = "fullscrCursorCheckBox";
			this.fullscrCursorCheckBox.Size = new System.Drawing.Size(292, 32);
			this.fullscrCursorCheckBox.TabIndex = 1;
			this.fullscrCursorCheckBox.Text = "show cursor in fullscreen";
			this.fullscrCursorCheckBox.UseVisualStyleBackColor = true;
			this.fullscrCursorCheckBox.CheckedChanged += new System.EventHandler(this.fullscrCursorCheckBox_CheckedChanged);
			// 
			// slideshowPage
			// 
			this.slideshowPage.BackColor = System.Drawing.Color.White;
			this.slideshowPage.Controls.Add(this.slideshowSecondsLabel);
			this.slideshowPage.Controls.Add(this.slideshowTimeLabel);
			this.slideshowPage.Controls.Add(this.slideshowTimeNumeric);
			this.slideshowPage.Controls.Add(this.slideshowCounterCheckBox);
			this.slideshowPage.Location = new System.Drawing.Point(4, 60);
			this.slideshowPage.Margin = new System.Windows.Forms.Padding(0);
			this.slideshowPage.Name = "slideshowPage";
			this.slideshowPage.Padding = new System.Windows.Forms.Padding(10);
			this.slideshowPage.Size = new System.Drawing.Size(312, 152);
			this.slideshowPage.TabIndex = 5;
			this.slideshowPage.Text = "slideshow";
			// 
			// slideshowSecondsLabel
			// 
			this.slideshowSecondsLabel.AutoSize = true;
			this.slideshowSecondsLabel.Location = new System.Drawing.Point(80, 41);
			this.slideshowSecondsLabel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.slideshowSecondsLabel.Name = "slideshowSecondsLabel";
			this.slideshowSecondsLabel.Size = new System.Drawing.Size(58, 19);
			this.slideshowSecondsLabel.TabIndex = 4;
			this.slideshowSecondsLabel.Text = "seconds";
			// 
			// slideshowTimeLabel
			// 
			this.slideshowTimeLabel.AutoSize = true;
			this.slideshowTimeLabel.Location = new System.Drawing.Point(10, 10);
			this.slideshowTimeLabel.Margin = new System.Windows.Forms.Padding(0);
			this.slideshowTimeLabel.Name = "slideshowTimeLabel";
			this.slideshowTimeLabel.Size = new System.Drawing.Size(100, 19);
			this.slideshowTimeLabel.TabIndex = 3;
			this.slideshowTimeLabel.Text = "switching time:";
			// 
			// slideshowTimeNumeric
			// 
			this.slideshowTimeNumeric.BackColor = System.Drawing.SystemColors.Control;
			this.slideshowTimeNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.slideshowTimeNumeric.Location = new System.Drawing.Point(10, 39);
			this.slideshowTimeNumeric.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.slideshowTimeNumeric.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.slideshowTimeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.slideshowTimeNumeric.Name = "slideshowTimeNumeric";
			this.slideshowTimeNumeric.Size = new System.Drawing.Size(60, 25);
			this.slideshowTimeNumeric.TabIndex = 2;
			this.slideshowTimeNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.slideshowTimeNumeric.ValueChanged += new System.EventHandler(this.slideshowTimeNumeric_ValueChanged);
			// 
			// slideshowCounterCheckBox
			// 
			this.slideshowCounterCheckBox.Location = new System.Drawing.Point(10, 74);
			this.slideshowCounterCheckBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.slideshowCounterCheckBox.Name = "slideshowCounterCheckBox";
			this.slideshowCounterCheckBox.Size = new System.Drawing.Size(292, 32);
			this.slideshowCounterCheckBox.TabIndex = 1;
			this.slideshowCounterCheckBox.Text = "show slideshow counter";
			this.slideshowCounterCheckBox.UseVisualStyleBackColor = true;
			this.slideshowCounterCheckBox.CheckedChanged += new System.EventHandler(this.slideshowCounterCheckBox_CheckedChanged);
			// 
			// startupPage
			// 
			this.startupPage.BackColor = System.Drawing.Color.White;
			this.startupPage.Controls.Add(this.startupLabel);
			this.startupPage.Controls.Add(this.startupNothingRadio);
			this.startupPage.Controls.Add(this.startupPasteRadio);
			this.startupPage.Location = new System.Drawing.Point(4, 60);
			this.startupPage.Margin = new System.Windows.Forms.Padding(0);
			this.startupPage.Name = "startupPage";
			this.startupPage.Padding = new System.Windows.Forms.Padding(10);
			this.startupPage.Size = new System.Drawing.Size(312, 152);
			this.startupPage.TabIndex = 3;
			this.startupPage.Text = "startup";
			this.startupPage.ToolTipText = "App startup action";
			// 
			// startupLabel
			// 
			this.startupLabel.AutoSize = true;
			this.startupLabel.Location = new System.Drawing.Point(10, 10);
			this.startupLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.startupLabel.Name = "startupLabel";
			this.startupLabel.Size = new System.Drawing.Size(97, 19);
			this.startupLabel.TabIndex = 42;
			this.startupLabel.Text = "startup action:";
			// 
			// startupNothingRadio
			// 
			this.startupNothingRadio.Checked = true;
			this.startupNothingRadio.Location = new System.Drawing.Point(10, 39);
			this.startupNothingRadio.Margin = new System.Windows.Forms.Padding(0);
			this.startupNothingRadio.Name = "startupNothingRadio";
			this.startupNothingRadio.Size = new System.Drawing.Size(292, 32);
			this.startupNothingRadio.TabIndex = 39;
			this.startupNothingRadio.TabStop = true;
			this.startupNothingRadio.Text = "nothing";
			this.startupNothingRadio.UseVisualStyleBackColor = true;
			this.startupNothingRadio.CheckedChanged += new System.EventHandler(this.startupNothingRadio_CheckedChanged);
			// 
			// startupPasteRadio
			// 
			this.startupPasteRadio.Location = new System.Drawing.Point(10, 71);
			this.startupPasteRadio.Margin = new System.Windows.Forms.Padding(0);
			this.startupPasteRadio.Name = "startupPasteRadio";
			this.startupPasteRadio.Size = new System.Drawing.Size(292, 32);
			this.startupPasteRadio.TabIndex = 40;
			this.startupPasteRadio.Text = "paste";
			this.startupPasteRadio.UseVisualStyleBackColor = true;
			this.startupPasteRadio.CheckedChanged += new System.EventHandler(this.startupPasteRadio_CheckedChanged);
			// 
			// externalPage
			// 
			this.externalPage.BackColor = System.Drawing.Color.White;
			this.externalPage.Controls.Add(this.browseBtn);
			this.externalPage.Controls.Add(this.favExtTextBox);
			this.externalPage.Controls.Add(this.favExtLabel);
			this.externalPage.Location = new System.Drawing.Point(4, 60);
			this.externalPage.Margin = new System.Windows.Forms.Padding(0);
			this.externalPage.Name = "externalPage";
			this.externalPage.Padding = new System.Windows.Forms.Padding(10);
			this.externalPage.Size = new System.Drawing.Size(312, 152);
			this.externalPage.TabIndex = 4;
			this.externalPage.Text = "external";
			// 
			// browseBtn
			// 
			this.browseBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.browseBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.browseBtn.FlatAppearance.BorderSize = 0;
			this.browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.browseBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.browseBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.browseBtn.Image = ((System.Drawing.Image)(resources.GetObject("browseBtn.Image")));
			this.browseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.browseBtn.Location = new System.Drawing.Point(182, 81);
			this.browseBtn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.browseBtn.Name = "browseBtn";
			this.browseBtn.Size = new System.Drawing.Size(120, 32);
			this.browseBtn.TabIndex = 2;
			this.browseBtn.TabStop = false;
			this.browseBtn.Text = " browse";
			this.browseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.browseBtn.UseVisualStyleBackColor = false;
			this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
			// 
			// favExtTextBox
			// 
			this.favExtTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.favExtTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.favExtTextBox.Location = new System.Drawing.Point(10, 39);
			this.favExtTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.favExtTextBox.Name = "favExtTextBox";
			this.favExtTextBox.ReadOnly = false;
			this.favExtTextBox.Size = new System.Drawing.Size(292, 32);
			this.favExtTextBox.TabIndex = 1;
			this.favExtTextBox.WordWrap = true;
			this.favExtTextBox.TextChanged += new System.EventHandler(this.favExtTextBox_TextChanged);
			// 
			// favExtLabel
			// 
			this.favExtLabel.AutoSize = true;
			this.favExtLabel.Location = new System.Drawing.Point(10, 10);
			this.favExtLabel.Margin = new System.Windows.Forms.Padding(0);
			this.favExtLabel.Name = "favExtLabel";
			this.favExtLabel.Size = new System.Drawing.Size(137, 19);
			this.favExtLabel.TabIndex = 0;
			this.favExtLabel.Text = "favorite external app:";
			// 
			// langPage
			// 
			this.langPage.BackColor = System.Drawing.Color.White;
			this.langPage.Controls.Add(this.langLabel);
			this.langPage.Controls.Add(this.translatedByLink);
			this.langPage.Controls.Add(this.restartLabel2);
			this.langPage.Controls.Add(this.langComboBox);
			this.langPage.Location = new System.Drawing.Point(4, 60);
			this.langPage.Margin = new System.Windows.Forms.Padding(0);
			this.langPage.Name = "langPage";
			this.langPage.Padding = new System.Windows.Forms.Padding(10);
			this.langPage.Size = new System.Drawing.Size(312, 152);
			this.langPage.TabIndex = 6;
			this.langPage.Text = "localization";
			// 
			// langLabel
			// 
			this.langLabel.AutoSize = true;
			this.langLabel.Location = new System.Drawing.Point(10, 10);
			this.langLabel.Margin = new System.Windows.Forms.Padding(0);
			this.langLabel.Name = "langLabel";
			this.langLabel.Size = new System.Drawing.Size(68, 19);
			this.langLabel.TabIndex = 41;
			this.langLabel.Text = "language:";
			// 
			// translatedByLink
			// 
			this.translatedByLink.AutoSize = true;
			this.translatedByLink.Location = new System.Drawing.Point(10, 81);
			this.translatedByLink.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.translatedByLink.Name = "translatedByLink";
			this.translatedByLink.Size = new System.Drawing.Size(89, 19);
			this.translatedByLink.TabIndex = 40;
			this.translatedByLink.TabStop = true;
			this.translatedByLink.Text = "translated by";
			this.translatedByLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.translatedByLink_LinkClicked);
			// 
			// restartLabel2
			// 
			this.restartLabel2.AutoSize = true;
			this.restartLabel2.Location = new System.Drawing.Point(10, 110);
			this.restartLabel2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.restartLabel2.Name = "restartLabel2";
			this.restartLabel2.Size = new System.Drawing.Size(114, 19);
			this.restartLabel2.TabIndex = 39;
			this.restartLabel2.Text = "* restart required";
			// 
			// langComboBox
			// 
			this.langComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.langComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.langComboBox.FormattingEnabled = true;
			this.langComboBox.ItemHeight = 26;
			this.langComboBox.Items.AddRange(new object[] {
            "English",
            "Russian (Русский)",
            "[Beta] Spanish (Española)"});
			this.langComboBox.Location = new System.Drawing.Point(10, 39);
			this.langComboBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.langComboBox.Name = "langComboBox";
			this.langComboBox.Size = new System.Drawing.Size(292, 32);
			this.langComboBox.TabIndex = 0;
			this.langComboBox.SelectedIndexChanged += new System.EventHandler(this.langComboBox_SelectedIndexChanged);
			// 
			// titlePanel
			// 
			this.titlePanel.Controls.Add(this.closeBtn);
			this.titlePanel.Controls.Add(this.titleLabel);
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Margin = new System.Windows.Forms.Padding(0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(340, 32);
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
			this.closeBtn.Location = new System.Drawing.Point(308, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 17;
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(9, 7);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(90, 19);
			this.titleLabel.TabIndex = 16;
			this.titleLabel.Text = "SettingsForm";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "App executable|*.exe";
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.ClientSize = new System.Drawing.Size(340, 268);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.settingsTabs);
			this.Draggable = true;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SettingsForm";
			this.TitleLabel = this.titleLabel;
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
			this.settingsTabs.ResumeLayout(false);
			this.themePage.ResumeLayout(false);
			this.themePage.PerformLayout();
			this.updatesPage.ResumeLayout(false);
			this.mousePage.ResumeLayout(false);
			this.slideshowPage.ResumeLayout(false);
			this.slideshowPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.slideshowTimeNumeric)).EndInit();
			this.startupPage.ResumeLayout(false);
			this.startupPage.PerformLayout();
			this.externalPage.ResumeLayout(false);
			this.externalPage.PerformLayout();
			this.langPage.ResumeLayout(false);
			this.langPage.PerformLayout();
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private QuickLibrary.QlibRadioButton lightThemeRadio;
		private QuickLibrary.QlibRadioButton systemThemeRadio;
		private QuickLibrary.QlibRadioButton darkThemeRadio;
		private QuickLibrary.QlibCheckBox updatesCheckBox;
		private System.Windows.Forms.Label restartLabel1;
		private QuickLibrary.QlibCheckBox fullscrCursorCheckBox;
		private QuickLibrary.QlibTabControl settingsTabs;
		private System.Windows.Forms.TabPage themePage;
		private System.Windows.Forms.TabPage updatesPage;
		private System.Windows.Forms.TabPage mousePage;
		private System.Windows.Forms.Panel titlePanel;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.ToolTip infoTooltip;
		private QuickLibrary.QlibCheckBox zoomWheelCheckBox;
		private QuickLibrary.QlibTitlebarButton closeBtn;
		private System.Windows.Forms.TabPage startupPage;
		private System.Windows.Forms.Label startupLabel;
		private QuickLibrary.QlibRadioButton startupNothingRadio;
		private QuickLibrary.QlibRadioButton startupPasteRadio;
		private System.Windows.Forms.TabPage externalPage;
		private System.Windows.Forms.Label favExtLabel;
		private QuickLibrary.QlibTextBox favExtTextBox;
		private System.Windows.Forms.Button browseBtn;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TabPage slideshowPage;
		private QuickLibrary.QlibCheckBox slideshowCounterCheckBox;
		private QuickLibrary.QlibNumericBox slideshowTimeNumeric;
		private System.Windows.Forms.Label slideshowTimeLabel;
		private System.Windows.Forms.Label slideshowSecondsLabel;
		private System.Windows.Forms.TabPage langPage;
		private QuickLibrary.QlibComboBox langComboBox;
		private System.Windows.Forms.Label restartLabel2;
		private System.Windows.Forms.LinkLabel translatedByLink;
		private System.Windows.Forms.Label langLabel;
	}
}
