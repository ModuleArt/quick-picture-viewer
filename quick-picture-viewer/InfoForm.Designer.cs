namespace quick_picture_viewer
{
	partial class InfoForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
			this.fileNameLabel = new System.Windows.Forms.Label();
			this.extensionTextBox = new QuickLibrary.QlibTextBox();
			this.extensionLabel = new System.Windows.Forms.Label();
			this.copyPathButton = new System.Windows.Forms.Button();
			this.copyFolderButton = new System.Windows.Forms.Button();
			this.copyNameButton = new System.Windows.Forms.Button();
			this.compressionTextBox = new QuickLibrary.QlibTextBox();
			this.compressionLabel = new System.Windows.Forms.Label();
			this.fullPathTextBox = new QuickLibrary.QlibTextBox();
			this.fullPathLabel = new System.Windows.Forms.Label();
			this.folderTextBox = new QuickLibrary.QlibTextBox();
			this.fileNameTextBox = new QuickLibrary.QlibTextBox();
			this.folderLabel = new System.Windows.Forms.Label();
			this.sizeTextBox = new QuickLibrary.QlibTextBox();
			this.sizeLabel = new System.Windows.Forms.Label();
			this.megapixelsTextBox = new QuickLibrary.QlibTextBox();
			this.megapixelsLabel = new System.Windows.Forms.Label();
			this.resolutionTextBox = new QuickLibrary.QlibTextBox();
			this.resolutionLabel = new System.Windows.Forms.Label();
			this.inchesTextBox = new QuickLibrary.QlibTextBox();
			this.inchesLabel = new System.Windows.Forms.Label();
			this.cmTextBox = new QuickLibrary.QlibTextBox();
			this.cmLabel = new System.Windows.Forms.Label();
			this.ratioLabel = new System.Windows.Forms.Label();
			this.ratioTextBox = new QuickLibrary.QlibTextBox();
			this.diskSizeTextBox = new QuickLibrary.QlibTextBox();
			this.diskSizeLabel = new System.Windows.Forms.Label();
			this.modifiedLabel = new System.Windows.Forms.Label();
			this.modifiedTextBox = new QuickLibrary.QlibTextBox();
			this.createdLabel = new System.Windows.Forms.Label();
			this.createdTextBox = new QuickLibrary.QlibTextBox();
			this.propertiesButton = new System.Windows.Forms.Button();
			this.copyTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.titlePanel = new System.Windows.Forms.Panel();
			this.titleLabel = new System.Windows.Forms.Label();
			this.closeBtn = new QuickLibrary.QlibTitlebarButton();
			this.titlePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// fileNameLabel
			// 
			this.fileNameLabel.AutoSize = true;
			this.fileNameLabel.Location = new System.Drawing.Point(54, 44);
			this.fileNameLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fileNameLabel.Name = "fileNameLabel";
			this.fileNameLabel.Size = new System.Drawing.Size(48, 19);
			this.fileNameLabel.TabIndex = 27;
			this.fileNameLabel.Text = "Name:";
			// 
			// extensionTextBox
			// 
			this.extensionTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.extensionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.extensionTextBox.Location = new System.Drawing.Point(294, 147);
			this.extensionTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.extensionTextBox.Name = "extensionTextBox";
			this.extensionTextBox.ReadOnly = true;
			this.extensionTextBox.Size = new System.Drawing.Size(60, 25);
			this.extensionTextBox.TabIndex = 8;
			this.extensionTextBox.Text = "Unknown";
			// 
			// extensionLabel
			// 
			this.extensionLabel.AutoSize = true;
			this.extensionLabel.Location = new System.Drawing.Point(214, 149);
			this.extensionLabel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.extensionLabel.Name = "extensionLabel";
			this.extensionLabel.Size = new System.Drawing.Size(70, 19);
			this.extensionLabel.TabIndex = 51;
			this.extensionLabel.Text = "Extension:";
			// 
			// copyPathButton
			// 
			this.copyPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.copyPathButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.copyPathButton.FlatAppearance.BorderSize = 0;
			this.copyPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.copyPathButton.Image = ((System.Drawing.Image)(resources.GetObject("copyPathButton.Image")));
			this.copyPathButton.Location = new System.Drawing.Point(329, 112);
			this.copyPathButton.Margin = new System.Windows.Forms.Padding(0);
			this.copyPathButton.Name = "copyPathButton";
			this.copyPathButton.Size = new System.Drawing.Size(25, 25);
			this.copyPathButton.TabIndex = 6;
			this.copyPathButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.copyPathButton.UseVisualStyleBackColor = false;
			this.copyPathButton.Click += new System.EventHandler(this.copyPathButton_Click);
			// 
			// copyFolderButton
			// 
			this.copyFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.copyFolderButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.copyFolderButton.FlatAppearance.BorderSize = 0;
			this.copyFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.copyFolderButton.Image = ((System.Drawing.Image)(resources.GetObject("copyFolderButton.Image")));
			this.copyFolderButton.Location = new System.Drawing.Point(329, 77);
			this.copyFolderButton.Margin = new System.Windows.Forms.Padding(0);
			this.copyFolderButton.Name = "copyFolderButton";
			this.copyFolderButton.Size = new System.Drawing.Size(25, 25);
			this.copyFolderButton.TabIndex = 4;
			this.copyFolderButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.copyFolderButton.UseVisualStyleBackColor = false;
			this.copyFolderButton.Click += new System.EventHandler(this.copyFolderButton_Click);
			// 
			// copyNameButton
			// 
			this.copyNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.copyNameButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.copyNameButton.FlatAppearance.BorderSize = 0;
			this.copyNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.copyNameButton.Image = ((System.Drawing.Image)(resources.GetObject("copyNameButton.Image")));
			this.copyNameButton.Location = new System.Drawing.Point(329, 42);
			this.copyNameButton.Margin = new System.Windows.Forms.Padding(0);
			this.copyNameButton.Name = "copyNameButton";
			this.copyNameButton.Size = new System.Drawing.Size(25, 25);
			this.copyNameButton.TabIndex = 2;
			this.copyNameButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.copyNameButton.UseVisualStyleBackColor = false;
			this.copyNameButton.Click += new System.EventHandler(this.copyNameButton_Click);
			// 
			// compressionTextBox
			// 
			this.compressionTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.compressionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.compressionTextBox.Location = new System.Drawing.Point(112, 147);
			this.compressionTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.compressionTextBox.Name = "compressionTextBox";
			this.compressionTextBox.ReadOnly = true;
			this.compressionTextBox.Size = new System.Drawing.Size(60, 25);
			this.compressionTextBox.TabIndex = 7;
			// 
			// compressionLabel
			// 
			this.compressionLabel.AutoSize = true;
			this.compressionLabel.Location = new System.Drawing.Point(10, 149);
			this.compressionLabel.Margin = new System.Windows.Forms.Padding(0);
			this.compressionLabel.Name = "compressionLabel";
			this.compressionLabel.Size = new System.Drawing.Size(92, 19);
			this.compressionLabel.TabIndex = 33;
			this.compressionLabel.Text = "Compression:";
			// 
			// fullPathTextBox
			// 
			this.fullPathTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.fullPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.fullPathTextBox.Location = new System.Drawing.Point(112, 112);
			this.fullPathTextBox.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.fullPathTextBox.Name = "fullPathTextBox";
			this.fullPathTextBox.ReadOnly = true;
			this.fullPathTextBox.Size = new System.Drawing.Size(217, 25);
			this.fullPathTextBox.TabIndex = 5;
			this.fullPathTextBox.Text = "Unknown";
			this.fullPathTextBox.WordWrap = false;
			// 
			// fullPathLabel
			// 
			this.fullPathLabel.AutoSize = true;
			this.fullPathLabel.Location = new System.Drawing.Point(37, 114);
			this.fullPathLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fullPathLabel.Name = "fullPathLabel";
			this.fullPathLabel.Size = new System.Drawing.Size(65, 19);
			this.fullPathLabel.TabIndex = 31;
			this.fullPathLabel.Text = "Full path:";
			// 
			// folderTextBox
			// 
			this.folderTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.folderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.folderTextBox.Location = new System.Drawing.Point(112, 77);
			this.folderTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.folderTextBox.Name = "folderTextBox";
			this.folderTextBox.ReadOnly = true;
			this.folderTextBox.Size = new System.Drawing.Size(217, 25);
			this.folderTextBox.TabIndex = 3;
			this.folderTextBox.Text = "Not exists";
			// 
			// fileNameTextBox
			// 
			this.fileNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.fileNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.fileNameTextBox.Location = new System.Drawing.Point(112, 42);
			this.fileNameTextBox.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.fileNameTextBox.Name = "fileNameTextBox";
			this.fileNameTextBox.ReadOnly = true;
			this.fileNameTextBox.Size = new System.Drawing.Size(217, 25);
			this.fileNameTextBox.TabIndex = 1;
			this.fileNameTextBox.Text = "None";
			// 
			// folderLabel
			// 
			this.folderLabel.AutoSize = true;
			this.folderLabel.Location = new System.Drawing.Point(52, 79);
			this.folderLabel.Margin = new System.Windows.Forms.Padding(0);
			this.folderLabel.Name = "folderLabel";
			this.folderLabel.Size = new System.Drawing.Size(50, 19);
			this.folderLabel.TabIndex = 28;
			this.folderLabel.Text = "Folder:";
			// 
			// sizeTextBox
			// 
			this.sizeTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.sizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.sizeTextBox.Location = new System.Drawing.Point(481, 42);
			this.sizeTextBox.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.sizeTextBox.Name = "sizeTextBox";
			this.sizeTextBox.ReadOnly = true;
			this.sizeTextBox.Size = new System.Drawing.Size(184, 25);
			this.sizeTextBox.TabIndex = 13;
			// 
			// sizeLabel
			// 
			this.sizeLabel.AutoSize = true;
			this.sizeLabel.Location = new System.Drawing.Point(410, 44);
			this.sizeLabel.Margin = new System.Windows.Forms.Padding(0);
			this.sizeLabel.Name = "sizeLabel";
			this.sizeLabel.Size = new System.Drawing.Size(61, 19);
			this.sizeLabel.TabIndex = 35;
			this.sizeLabel.Text = "Size (px):";
			// 
			// megapixelsTextBox
			// 
			this.megapixelsTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.megapixelsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.megapixelsTextBox.Location = new System.Drawing.Point(481, 77);
			this.megapixelsTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.megapixelsTextBox.Name = "megapixelsTextBox";
			this.megapixelsTextBox.ReadOnly = true;
			this.megapixelsTextBox.Size = new System.Drawing.Size(184, 25);
			this.megapixelsTextBox.TabIndex = 14;
			// 
			// megapixelsLabel
			// 
			this.megapixelsLabel.AutoSize = true;
			this.megapixelsLabel.Location = new System.Drawing.Point(404, 79);
			this.megapixelsLabel.Margin = new System.Windows.Forms.Padding(0);
			this.megapixelsLabel.Name = "megapixelsLabel";
			this.megapixelsLabel.Size = new System.Drawing.Size(67, 19);
			this.megapixelsLabel.TabIndex = 37;
			this.megapixelsLabel.Text = "Size (mp):";
			// 
			// resolutionTextBox
			// 
			this.resolutionTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.resolutionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.resolutionTextBox.Location = new System.Drawing.Point(481, 112);
			this.resolutionTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.resolutionTextBox.Name = "resolutionTextBox";
			this.resolutionTextBox.ReadOnly = true;
			this.resolutionTextBox.Size = new System.Drawing.Size(184, 25);
			this.resolutionTextBox.TabIndex = 15;
			// 
			// resolutionLabel
			// 
			this.resolutionLabel.AutoSize = true;
			this.resolutionLabel.Location = new System.Drawing.Point(395, 114);
			this.resolutionLabel.Margin = new System.Windows.Forms.Padding(0);
			this.resolutionLabel.Name = "resolutionLabel";
			this.resolutionLabel.Size = new System.Drawing.Size(76, 19);
			this.resolutionLabel.TabIndex = 39;
			this.resolutionLabel.Text = "Resolution:";
			// 
			// inchesTextBox
			// 
			this.inchesTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.inchesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inchesTextBox.Location = new System.Drawing.Point(481, 147);
			this.inchesTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.inchesTextBox.Name = "inchesTextBox";
			this.inchesTextBox.ReadOnly = true;
			this.inchesTextBox.Size = new System.Drawing.Size(184, 25);
			this.inchesTextBox.TabIndex = 16;
			// 
			// inchesLabel
			// 
			this.inchesLabel.AutoSize = true;
			this.inchesLabel.Location = new System.Drawing.Point(381, 149);
			this.inchesLabel.Margin = new System.Windows.Forms.Padding(0);
			this.inchesLabel.Name = "inchesLabel";
			this.inchesLabel.Size = new System.Drawing.Size(90, 19);
			this.inchesLabel.TabIndex = 41;
			this.inchesLabel.Text = "Print size (in):";
			// 
			// cmTextBox
			// 
			this.cmTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.cmTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.cmTextBox.Location = new System.Drawing.Point(481, 182);
			this.cmTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.cmTextBox.Name = "cmTextBox";
			this.cmTextBox.ReadOnly = true;
			this.cmTextBox.Size = new System.Drawing.Size(184, 25);
			this.cmTextBox.TabIndex = 17;
			// 
			// cmLabel
			// 
			this.cmLabel.AutoSize = true;
			this.cmLabel.Location = new System.Drawing.Point(374, 184);
			this.cmLabel.Margin = new System.Windows.Forms.Padding(20, 0, 10, 0);
			this.cmLabel.Name = "cmLabel";
			this.cmLabel.Size = new System.Drawing.Size(97, 19);
			this.cmLabel.TabIndex = 43;
			this.cmLabel.Text = "Print size (cm):";
			// 
			// ratioLabel
			// 
			this.ratioLabel.AutoSize = true;
			this.ratioLabel.Location = new System.Drawing.Point(386, 254);
			this.ratioLabel.Margin = new System.Windows.Forms.Padding(0);
			this.ratioLabel.Name = "ratioLabel";
			this.ratioLabel.Size = new System.Drawing.Size(85, 19);
			this.ratioLabel.TabIndex = 48;
			this.ratioLabel.Text = "Aspect ratio:";
			// 
			// ratioTextBox
			// 
			this.ratioTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ratioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ratioTextBox.Location = new System.Drawing.Point(481, 252);
			this.ratioTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.ratioTextBox.Name = "ratioTextBox";
			this.ratioTextBox.ReadOnly = true;
			this.ratioTextBox.Size = new System.Drawing.Size(184, 25);
			this.ratioTextBox.TabIndex = 19;
			// 
			// diskSizeTextBox
			// 
			this.diskSizeTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.diskSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.diskSizeTextBox.Location = new System.Drawing.Point(481, 217);
			this.diskSizeTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.diskSizeTextBox.Name = "diskSizeTextBox";
			this.diskSizeTextBox.ReadOnly = true;
			this.diskSizeTextBox.Size = new System.Drawing.Size(184, 25);
			this.diskSizeTextBox.TabIndex = 18;
			this.diskSizeTextBox.Text = "Unknown";
			// 
			// diskSizeLabel
			// 
			this.diskSizeLabel.AutoSize = true;
			this.diskSizeLabel.Location = new System.Drawing.Point(407, 219);
			this.diskSizeLabel.Margin = new System.Windows.Forms.Padding(0);
			this.diskSizeLabel.Name = "diskSizeLabel";
			this.diskSizeLabel.Size = new System.Drawing.Size(64, 19);
			this.diskSizeLabel.TabIndex = 45;
			this.diskSizeLabel.Text = "Disk size:";
			// 
			// modifiedLabel
			// 
			this.modifiedLabel.AutoSize = true;
			this.modifiedLabel.Location = new System.Drawing.Point(36, 219);
			this.modifiedLabel.Margin = new System.Windows.Forms.Padding(0);
			this.modifiedLabel.Name = "modifiedLabel";
			this.modifiedLabel.Size = new System.Drawing.Size(66, 19);
			this.modifiedLabel.TabIndex = 39;
			this.modifiedLabel.Text = "Modified:";
			// 
			// modifiedTextBox
			// 
			this.modifiedTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.modifiedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.modifiedTextBox.Location = new System.Drawing.Point(112, 217);
			this.modifiedTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.modifiedTextBox.Name = "modifiedTextBox";
			this.modifiedTextBox.ReadOnly = true;
			this.modifiedTextBox.Size = new System.Drawing.Size(242, 25);
			this.modifiedTextBox.TabIndex = 11;
			this.modifiedTextBox.Text = "Unknown";
			// 
			// createdLabel
			// 
			this.createdLabel.AutoSize = true;
			this.createdLabel.Location = new System.Drawing.Point(42, 184);
			this.createdLabel.Margin = new System.Windows.Forms.Padding(0);
			this.createdLabel.Name = "createdLabel";
			this.createdLabel.Size = new System.Drawing.Size(60, 19);
			this.createdLabel.TabIndex = 37;
			this.createdLabel.Text = "Created:";
			// 
			// createdTextBox
			// 
			this.createdTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.createdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.createdTextBox.Location = new System.Drawing.Point(112, 182);
			this.createdTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.createdTextBox.Name = "createdTextBox";
			this.createdTextBox.ReadOnly = true;
			this.createdTextBox.Size = new System.Drawing.Size(242, 25);
			this.createdTextBox.TabIndex = 10;
			this.createdTextBox.Text = "Unknown";
			// 
			// propertiesButton
			// 
			this.propertiesButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.propertiesButton.Enabled = false;
			this.propertiesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.propertiesButton.FlatAppearance.BorderSize = 0;
			this.propertiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.propertiesButton.Image = ((System.Drawing.Image)(resources.GetObject("propertiesButton.Image")));
			this.propertiesButton.Location = new System.Drawing.Point(10, 278);
			this.propertiesButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.propertiesButton.Name = "propertiesButton";
			this.propertiesButton.Size = new System.Drawing.Size(130, 32);
			this.propertiesButton.TabIndex = 20;
			this.propertiesButton.Text = " File properties";
			this.propertiesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.propertiesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.propertiesButton.UseVisualStyleBackColor = false;
			this.propertiesButton.Click += new System.EventHandler(this.propertiesButton_Click);
			this.propertiesButton.Paint += new System.Windows.Forms.PaintEventHandler(this.propertiesButton_Paint);
			// 
			// titlePanel
			// 
			this.titlePanel.Controls.Add(this.titleLabel);
			this.titlePanel.Controls.Add(this.closeBtn);
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Margin = new System.Windows.Forms.Padding(0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(675, 32);
			this.titlePanel.TabIndex = 22;
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(10, 7);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(47, 19);
			this.titleLabel.TabIndex = 16;
			this.titleLabel.Text = "About";
			// 
			// closeBtn
			// 
			this.closeBtn.DarkImage = global::quick_picture_viewer.Properties.Resources.black_close;
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.Image = global::quick_picture_viewer.Properties.Resources.black_close;
			this.closeBtn.IsRed = true;
			this.closeBtn.LightImage = global::quick_picture_viewer.Properties.Resources.white_close;
			this.closeBtn.Location = new System.Drawing.Point(643, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 1;
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// InfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.ClientSize = new System.Drawing.Size(675, 320);
			this.Controls.Add(this.modifiedLabel);
			this.Controls.Add(this.copyPathButton);
			this.Controls.Add(this.modifiedTextBox);
			this.Controls.Add(this.ratioLabel);
			this.Controls.Add(this.createdLabel);
			this.Controls.Add(this.copyFolderButton);
			this.Controls.Add(this.createdTextBox);
			this.Controls.Add(this.extensionLabel);
			this.Controls.Add(this.copyNameButton);
			this.Controls.Add(this.ratioTextBox);
			this.Controls.Add(this.extensionTextBox);
			this.Controls.Add(this.diskSizeLabel);
			this.Controls.Add(this.diskSizeTextBox);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.propertiesButton);
			this.Controls.Add(this.cmTextBox);
			this.Controls.Add(this.inchesTextBox);
			this.Controls.Add(this.sizeTextBox);
			this.Controls.Add(this.resolutionTextBox);
			this.Controls.Add(this.megapixelsTextBox);
			this.Controls.Add(this.sizeLabel);
			this.Controls.Add(this.cmLabel);
			this.Controls.Add(this.inchesLabel);
			this.Controls.Add(this.megapixelsLabel);
			this.Controls.Add(this.resolutionLabel);
			this.Controls.Add(this.compressionTextBox);
			this.Controls.Add(this.fullPathLabel);
			this.Controls.Add(this.fullPathTextBox);
			this.Controls.Add(this.compressionLabel);
			this.Controls.Add(this.fileNameLabel);
			this.Controls.Add(this.folderLabel);
			this.Controls.Add(this.folderTextBox);
			this.Controls.Add(this.fileNameTextBox);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InfoForm";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Image info";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InfoForm_KeyDown);
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label fileNameLabel;
		private System.Windows.Forms.Label folderLabel;
		private QuickLibrary.QlibTextBox fileNameTextBox;
		private QuickLibrary.QlibTextBox folderTextBox;
		private QuickLibrary.QlibTextBox fullPathTextBox;
		private System.Windows.Forms.Label fullPathLabel;
		private QuickLibrary.QlibTextBox compressionTextBox;
		private System.Windows.Forms.Label compressionLabel;
		private QuickLibrary.QlibTextBox sizeTextBox;
		private System.Windows.Forms.Label sizeLabel;
		private QuickLibrary.QlibTextBox megapixelsTextBox;
		private System.Windows.Forms.Label megapixelsLabel;
		private QuickLibrary.QlibTextBox resolutionTextBox;
		private System.Windows.Forms.Label resolutionLabel;
		private QuickLibrary.QlibTextBox inchesTextBox;
		private System.Windows.Forms.Label inchesLabel;
		private QuickLibrary.QlibTextBox cmTextBox;
		private System.Windows.Forms.Label cmLabel;
		private System.Windows.Forms.Label createdLabel;
		private QuickLibrary.QlibTextBox createdTextBox;
		private System.Windows.Forms.Label modifiedLabel;
		private QuickLibrary.QlibTextBox modifiedTextBox;
		private QuickLibrary.QlibTextBox diskSizeTextBox;
		private System.Windows.Forms.Label diskSizeLabel;
		private System.Windows.Forms.Button propertiesButton;
		private System.Windows.Forms.Label ratioLabel;
		private QuickLibrary.QlibTextBox ratioTextBox;
		private System.Windows.Forms.Button copyNameButton;
		private System.Windows.Forms.Button copyFolderButton;
		private System.Windows.Forms.Button copyPathButton;
		private QuickLibrary.QlibTextBox extensionTextBox;
		private System.Windows.Forms.Label extensionLabel;
		private System.Windows.Forms.ToolTip copyTooltip;
		private System.Windows.Forms.Panel titlePanel;
		private System.Windows.Forms.Label titleLabel;
		private QuickLibrary.QlibTitlebarButton closeBtn;
	}
}
