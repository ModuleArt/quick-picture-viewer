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
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.fileNameLabel = new System.Windows.Forms.Label();
			this.okButton = new System.Windows.Forms.Button();
			this.fileGroup = new System.Windows.Forms.GroupBox();
			this.extensionTextBox = new System.Windows.Forms.TextBox();
			this.extensionLabel = new System.Windows.Forms.Label();
			this.copyPathButton = new System.Windows.Forms.Button();
			this.copyFolderButton = new System.Windows.Forms.Button();
			this.copyNameButton = new System.Windows.Forms.Button();
			this.compressionTextBox = new System.Windows.Forms.TextBox();
			this.compressionLabel = new System.Windows.Forms.Label();
			this.fullPathTextBox = new System.Windows.Forms.TextBox();
			this.fullPathLabel = new System.Windows.Forms.Label();
			this.folderTextBox = new System.Windows.Forms.TextBox();
			this.fileNameTextBox = new System.Windows.Forms.TextBox();
			this.folderLabel = new System.Windows.Forms.Label();
			this.sizeTextBox = new System.Windows.Forms.TextBox();
			this.sizeLabel = new System.Windows.Forms.Label();
			this.megapixelsTextBox = new System.Windows.Forms.TextBox();
			this.megapixelsLabel = new System.Windows.Forms.Label();
			this.resolutionTextBox = new System.Windows.Forms.TextBox();
			this.resolutionLabel = new System.Windows.Forms.Label();
			this.inchesTextBox = new System.Windows.Forms.TextBox();
			this.inchesLabel = new System.Windows.Forms.Label();
			this.cmTextBox = new System.Windows.Forms.TextBox();
			this.cmLabel = new System.Windows.Forms.Label();
			this.sizeGroup = new System.Windows.Forms.GroupBox();
			this.ratioLabel = new System.Windows.Forms.Label();
			this.ratioTextBox = new System.Windows.Forms.TextBox();
			this.diskSizeTextBox = new System.Windows.Forms.TextBox();
			this.diskSizeLabel = new System.Windows.Forms.Label();
			this.dateGroup = new System.Windows.Forms.GroupBox();
			this.modifiedLabel = new System.Windows.Forms.Label();
			this.modifiedTextBox = new System.Windows.Forms.TextBox();
			this.createdLabel = new System.Windows.Forms.Label();
			this.createdTextBox = new System.Windows.Forms.TextBox();
			this.propertiesButton = new System.Windows.Forms.Button();
			this.copyTooltip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.fileGroup.SuspendLayout();
			this.sizeGroup.SuspendLayout();
			this.dateGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(9, 9);
			this.logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(356, 80);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.logoPictureBox.TabIndex = 12;
			this.logoPictureBox.TabStop = false;
			// 
			// fileNameLabel
			// 
			this.fileNameLabel.AutoSize = true;
			this.fileNameLabel.Location = new System.Drawing.Point(6, 28);
			this.fileNameLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
			this.fileNameLabel.Name = "fileNameLabel";
			this.fileNameLabel.Size = new System.Drawing.Size(42, 15);
			this.fileNameLabel.TabIndex = 27;
			this.fileNameLabel.Text = "Name:";
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.FlatAppearance.BorderSize = 0;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okButton.Location = new System.Drawing.Point(241, 579);
			this.okButton.Margin = new System.Windows.Forms.Padding(0);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(124, 23);
			this.okButton.TabIndex = 18;
			this.okButton.Text = "Close";
			this.okButton.UseVisualStyleBackColor = false;
			// 
			// fileGroup
			// 
			this.fileGroup.Controls.Add(this.extensionTextBox);
			this.fileGroup.Controls.Add(this.extensionLabel);
			this.fileGroup.Controls.Add(this.copyPathButton);
			this.fileGroup.Controls.Add(this.copyFolderButton);
			this.fileGroup.Controls.Add(this.copyNameButton);
			this.fileGroup.Controls.Add(this.compressionTextBox);
			this.fileGroup.Controls.Add(this.compressionLabel);
			this.fileGroup.Controls.Add(this.fullPathTextBox);
			this.fileGroup.Controls.Add(this.fullPathLabel);
			this.fileGroup.Controls.Add(this.folderTextBox);
			this.fileGroup.Controls.Add(this.fileNameTextBox);
			this.fileGroup.Controls.Add(this.folderLabel);
			this.fileGroup.Controls.Add(this.fileNameLabel);
			this.fileGroup.Location = new System.Drawing.Point(9, 98);
			this.fileGroup.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.fileGroup.Name = "fileGroup";
			this.fileGroup.Size = new System.Drawing.Size(356, 143);
			this.fileGroup.TabIndex = 34;
			this.fileGroup.TabStop = false;
			this.fileGroup.Text = "File";
			// 
			// extensionTextBox
			// 
			this.extensionTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.extensionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.extensionTextBox.Location = new System.Drawing.Point(252, 104);
			this.extensionTextBox.Multiline = true;
			this.extensionTextBox.Name = "extensionTextBox";
			this.extensionTextBox.ReadOnly = true;
			this.extensionTextBox.Size = new System.Drawing.Size(70, 20);
			this.extensionTextBox.TabIndex = 7;
			this.extensionTextBox.Text = "Unknown";
			// 
			// extensionLabel
			// 
			this.extensionLabel.AutoSize = true;
			this.extensionLabel.Location = new System.Drawing.Point(180, 106);
			this.extensionLabel.Margin = new System.Windows.Forms.Padding(3);
			this.extensionLabel.Name = "extensionLabel";
			this.extensionLabel.Size = new System.Drawing.Size(61, 15);
			this.extensionLabel.TabIndex = 51;
			this.extensionLabel.Text = "Extension:";
			// 
			// copyPathButton
			// 
			this.copyPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.copyPathButton.BackColor = System.Drawing.SystemColors.Control;
			this.copyPathButton.FlatAppearance.BorderSize = 0;
			this.copyPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.copyPathButton.Image = ((System.Drawing.Image)(resources.GetObject("copyPathButton.Image")));
			this.copyPathButton.Location = new System.Drawing.Point(324, 75);
			this.copyPathButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.copyPathButton.Name = "copyPathButton";
			this.copyPathButton.Size = new System.Drawing.Size(26, 25);
			this.copyPathButton.TabIndex = 5;
			this.copyPathButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.copyPathButton.UseVisualStyleBackColor = false;
			this.copyPathButton.Click += new System.EventHandler(this.copyPathButton_Click);
			// 
			// copyFolderButton
			// 
			this.copyFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.copyFolderButton.BackColor = System.Drawing.SystemColors.Control;
			this.copyFolderButton.FlatAppearance.BorderSize = 0;
			this.copyFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.copyFolderButton.Image = ((System.Drawing.Image)(resources.GetObject("copyFolderButton.Image")));
			this.copyFolderButton.Location = new System.Drawing.Point(324, 49);
			this.copyFolderButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.copyFolderButton.Name = "copyFolderButton";
			this.copyFolderButton.Size = new System.Drawing.Size(26, 25);
			this.copyFolderButton.TabIndex = 3;
			this.copyFolderButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.copyFolderButton.UseVisualStyleBackColor = false;
			this.copyFolderButton.Click += new System.EventHandler(this.copyFolderButton_Click);
			// 
			// copyNameButton
			// 
			this.copyNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.copyNameButton.BackColor = System.Drawing.SystemColors.Control;
			this.copyNameButton.FlatAppearance.BorderSize = 0;
			this.copyNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.copyNameButton.Image = ((System.Drawing.Image)(resources.GetObject("copyNameButton.Image")));
			this.copyNameButton.Location = new System.Drawing.Point(324, 23);
			this.copyNameButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.copyNameButton.Name = "copyNameButton";
			this.copyNameButton.Size = new System.Drawing.Size(26, 25);
			this.copyNameButton.TabIndex = 1;
			this.copyNameButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.copyNameButton.UseVisualStyleBackColor = false;
			this.copyNameButton.Click += new System.EventHandler(this.copyNameButton_Click);
			// 
			// compressionTextBox
			// 
			this.compressionTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.compressionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.compressionTextBox.Location = new System.Drawing.Point(97, 104);
			this.compressionTextBox.Multiline = true;
			this.compressionTextBox.Name = "compressionTextBox";
			this.compressionTextBox.ReadOnly = true;
			this.compressionTextBox.Size = new System.Drawing.Size(70, 20);
			this.compressionTextBox.TabIndex = 6;
			// 
			// compressionLabel
			// 
			this.compressionLabel.AutoSize = true;
			this.compressionLabel.Location = new System.Drawing.Point(6, 106);
			this.compressionLabel.Margin = new System.Windows.Forms.Padding(3);
			this.compressionLabel.Name = "compressionLabel";
			this.compressionLabel.Size = new System.Drawing.Size(80, 15);
			this.compressionLabel.TabIndex = 33;
			this.compressionLabel.Text = "Compression:";
			// 
			// fullPathTextBox
			// 
			this.fullPathTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.fullPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.fullPathTextBox.Location = new System.Drawing.Point(97, 78);
			this.fullPathTextBox.Multiline = true;
			this.fullPathTextBox.Name = "fullPathTextBox";
			this.fullPathTextBox.ReadOnly = true;
			this.fullPathTextBox.Size = new System.Drawing.Size(225, 20);
			this.fullPathTextBox.TabIndex = 4;
			this.fullPathTextBox.Text = "Unknown";
			this.fullPathTextBox.WordWrap = false;
			// 
			// fullPathLabel
			// 
			this.fullPathLabel.AutoSize = true;
			this.fullPathLabel.Location = new System.Drawing.Point(6, 80);
			this.fullPathLabel.Margin = new System.Windows.Forms.Padding(3);
			this.fullPathLabel.Name = "fullPathLabel";
			this.fullPathLabel.Size = new System.Drawing.Size(56, 15);
			this.fullPathLabel.TabIndex = 31;
			this.fullPathLabel.Text = "Full path:";
			// 
			// folderTextBox
			// 
			this.folderTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.folderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.folderTextBox.Location = new System.Drawing.Point(97, 52);
			this.folderTextBox.Multiline = true;
			this.folderTextBox.Name = "folderTextBox";
			this.folderTextBox.ReadOnly = true;
			this.folderTextBox.Size = new System.Drawing.Size(225, 20);
			this.folderTextBox.TabIndex = 2;
			this.folderTextBox.Text = "Not exists";
			// 
			// fileNameTextBox
			// 
			this.fileNameTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.fileNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.fileNameTextBox.Location = new System.Drawing.Point(97, 26);
			this.fileNameTextBox.Margin = new System.Windows.Forms.Padding(3, 9, 0, 3);
			this.fileNameTextBox.Multiline = true;
			this.fileNameTextBox.Name = "fileNameTextBox";
			this.fileNameTextBox.ReadOnly = true;
			this.fileNameTextBox.Size = new System.Drawing.Size(225, 20);
			this.fileNameTextBox.TabIndex = 0;
			this.fileNameTextBox.Text = "None";
			// 
			// folderLabel
			// 
			this.folderLabel.AutoSize = true;
			this.folderLabel.Location = new System.Drawing.Point(6, 54);
			this.folderLabel.Margin = new System.Windows.Forms.Padding(3);
			this.folderLabel.Name = "folderLabel";
			this.folderLabel.Size = new System.Drawing.Size(43, 15);
			this.folderLabel.TabIndex = 28;
			this.folderLabel.Text = "Folder:";
			// 
			// sizeTextBox
			// 
			this.sizeTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.sizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.sizeTextBox.Location = new System.Drawing.Point(97, 26);
			this.sizeTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 9, 3);
			this.sizeTextBox.Multiline = true;
			this.sizeTextBox.Name = "sizeTextBox";
			this.sizeTextBox.ReadOnly = true;
			this.sizeTextBox.Size = new System.Drawing.Size(249, 20);
			this.sizeTextBox.TabIndex = 8;
			// 
			// sizeLabel
			// 
			this.sizeLabel.AutoSize = true;
			this.sizeLabel.Location = new System.Drawing.Point(6, 28);
			this.sizeLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
			this.sizeLabel.Name = "sizeLabel";
			this.sizeLabel.Size = new System.Drawing.Size(54, 15);
			this.sizeLabel.TabIndex = 35;
			this.sizeLabel.Text = "Size (px):";
			// 
			// megapixelsTextBox
			// 
			this.megapixelsTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.megapixelsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.megapixelsTextBox.Location = new System.Drawing.Point(97, 52);
			this.megapixelsTextBox.Multiline = true;
			this.megapixelsTextBox.Name = "megapixelsTextBox";
			this.megapixelsTextBox.ReadOnly = true;
			this.megapixelsTextBox.Size = new System.Drawing.Size(249, 20);
			this.megapixelsTextBox.TabIndex = 9;
			// 
			// megapixelsLabel
			// 
			this.megapixelsLabel.AutoSize = true;
			this.megapixelsLabel.Location = new System.Drawing.Point(6, 54);
			this.megapixelsLabel.Margin = new System.Windows.Forms.Padding(3);
			this.megapixelsLabel.Name = "megapixelsLabel";
			this.megapixelsLabel.Size = new System.Drawing.Size(59, 15);
			this.megapixelsLabel.TabIndex = 37;
			this.megapixelsLabel.Text = "Size (mp):";
			// 
			// resolutionTextBox
			// 
			this.resolutionTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.resolutionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.resolutionTextBox.Location = new System.Drawing.Point(97, 78);
			this.resolutionTextBox.Multiline = true;
			this.resolutionTextBox.Name = "resolutionTextBox";
			this.resolutionTextBox.ReadOnly = true;
			this.resolutionTextBox.Size = new System.Drawing.Size(249, 20);
			this.resolutionTextBox.TabIndex = 10;
			// 
			// resolutionLabel
			// 
			this.resolutionLabel.AutoSize = true;
			this.resolutionLabel.Location = new System.Drawing.Point(6, 80);
			this.resolutionLabel.Margin = new System.Windows.Forms.Padding(3);
			this.resolutionLabel.Name = "resolutionLabel";
			this.resolutionLabel.Size = new System.Drawing.Size(66, 15);
			this.resolutionLabel.TabIndex = 39;
			this.resolutionLabel.Text = "Resolution:";
			// 
			// inchesTextBox
			// 
			this.inchesTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.inchesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inchesTextBox.Location = new System.Drawing.Point(97, 104);
			this.inchesTextBox.Multiline = true;
			this.inchesTextBox.Name = "inchesTextBox";
			this.inchesTextBox.ReadOnly = true;
			this.inchesTextBox.Size = new System.Drawing.Size(249, 20);
			this.inchesTextBox.TabIndex = 11;
			// 
			// inchesLabel
			// 
			this.inchesLabel.AutoSize = true;
			this.inchesLabel.Location = new System.Drawing.Point(6, 106);
			this.inchesLabel.Margin = new System.Windows.Forms.Padding(3);
			this.inchesLabel.Name = "inchesLabel";
			this.inchesLabel.Size = new System.Drawing.Size(78, 15);
			this.inchesLabel.TabIndex = 41;
			this.inchesLabel.Text = "Print size (in):";
			// 
			// cmTextBox
			// 
			this.cmTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.cmTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmTextBox.Location = new System.Drawing.Point(97, 130);
			this.cmTextBox.Multiline = true;
			this.cmTextBox.Name = "cmTextBox";
			this.cmTextBox.ReadOnly = true;
			this.cmTextBox.Size = new System.Drawing.Size(249, 20);
			this.cmTextBox.TabIndex = 12;
			// 
			// cmLabel
			// 
			this.cmLabel.AutoSize = true;
			this.cmLabel.Location = new System.Drawing.Point(6, 132);
			this.cmLabel.Margin = new System.Windows.Forms.Padding(3);
			this.cmLabel.Name = "cmLabel";
			this.cmLabel.Size = new System.Drawing.Size(85, 15);
			this.cmLabel.TabIndex = 43;
			this.cmLabel.Text = "Print size (cm):";
			// 
			// sizeGroup
			// 
			this.sizeGroup.Controls.Add(this.ratioLabel);
			this.sizeGroup.Controls.Add(this.ratioTextBox);
			this.sizeGroup.Controls.Add(this.diskSizeTextBox);
			this.sizeGroup.Controls.Add(this.diskSizeLabel);
			this.sizeGroup.Controls.Add(this.cmTextBox);
			this.sizeGroup.Controls.Add(this.sizeLabel);
			this.sizeGroup.Controls.Add(this.cmLabel);
			this.sizeGroup.Controls.Add(this.sizeTextBox);
			this.sizeGroup.Controls.Add(this.inchesTextBox);
			this.sizeGroup.Controls.Add(this.megapixelsTextBox);
			this.sizeGroup.Controls.Add(this.inchesLabel);
			this.sizeGroup.Controls.Add(this.megapixelsLabel);
			this.sizeGroup.Controls.Add(this.resolutionTextBox);
			this.sizeGroup.Controls.Add(this.resolutionLabel);
			this.sizeGroup.Location = new System.Drawing.Point(9, 250);
			this.sizeGroup.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.sizeGroup.Name = "sizeGroup";
			this.sizeGroup.Size = new System.Drawing.Size(356, 221);
			this.sizeGroup.TabIndex = 45;
			this.sizeGroup.TabStop = false;
			this.sizeGroup.Text = "Size";
			// 
			// ratioLabel
			// 
			this.ratioLabel.AutoSize = true;
			this.ratioLabel.Location = new System.Drawing.Point(6, 184);
			this.ratioLabel.Margin = new System.Windows.Forms.Padding(3);
			this.ratioLabel.Name = "ratioLabel";
			this.ratioLabel.Size = new System.Drawing.Size(73, 15);
			this.ratioLabel.TabIndex = 48;
			this.ratioLabel.Text = "Aspect ratio:";
			// 
			// ratioTextBox
			// 
			this.ratioTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.ratioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ratioTextBox.Location = new System.Drawing.Point(97, 182);
			this.ratioTextBox.Multiline = true;
			this.ratioTextBox.Name = "ratioTextBox";
			this.ratioTextBox.ReadOnly = true;
			this.ratioTextBox.Size = new System.Drawing.Size(249, 20);
			this.ratioTextBox.TabIndex = 14;
			// 
			// diskSizeTextBox
			// 
			this.diskSizeTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.diskSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.diskSizeTextBox.Location = new System.Drawing.Point(97, 156);
			this.diskSizeTextBox.Multiline = true;
			this.diskSizeTextBox.Name = "diskSizeTextBox";
			this.diskSizeTextBox.ReadOnly = true;
			this.diskSizeTextBox.Size = new System.Drawing.Size(249, 20);
			this.diskSizeTextBox.TabIndex = 13;
			this.diskSizeTextBox.Text = "Unknown";
			// 
			// diskSizeLabel
			// 
			this.diskSizeLabel.AutoSize = true;
			this.diskSizeLabel.Location = new System.Drawing.Point(6, 158);
			this.diskSizeLabel.Margin = new System.Windows.Forms.Padding(3);
			this.diskSizeLabel.Name = "diskSizeLabel";
			this.diskSizeLabel.Size = new System.Drawing.Size(54, 15);
			this.diskSizeLabel.TabIndex = 45;
			this.diskSizeLabel.Text = "Disk size:";
			// 
			// dateGroup
			// 
			this.dateGroup.Controls.Add(this.modifiedLabel);
			this.dateGroup.Controls.Add(this.modifiedTextBox);
			this.dateGroup.Controls.Add(this.createdLabel);
			this.dateGroup.Controls.Add(this.createdTextBox);
			this.dateGroup.Location = new System.Drawing.Point(9, 480);
			this.dateGroup.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.dateGroup.Name = "dateGroup";
			this.dateGroup.Size = new System.Drawing.Size(356, 91);
			this.dateGroup.TabIndex = 46;
			this.dateGroup.TabStop = false;
			this.dateGroup.Text = "Date";
			// 
			// modifiedLabel
			// 
			this.modifiedLabel.AutoSize = true;
			this.modifiedLabel.Location = new System.Drawing.Point(6, 54);
			this.modifiedLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.modifiedLabel.Name = "modifiedLabel";
			this.modifiedLabel.Size = new System.Drawing.Size(58, 15);
			this.modifiedLabel.TabIndex = 39;
			this.modifiedLabel.Text = "Modified:";
			// 
			// modifiedTextBox
			// 
			this.modifiedTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.modifiedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.modifiedTextBox.Location = new System.Drawing.Point(97, 52);
			this.modifiedTextBox.Multiline = true;
			this.modifiedTextBox.Name = "modifiedTextBox";
			this.modifiedTextBox.ReadOnly = true;
			this.modifiedTextBox.Size = new System.Drawing.Size(249, 20);
			this.modifiedTextBox.TabIndex = 16;
			this.modifiedTextBox.Text = "Unknown";
			// 
			// createdLabel
			// 
			this.createdLabel.AutoSize = true;
			this.createdLabel.Location = new System.Drawing.Point(6, 28);
			this.createdLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
			this.createdLabel.Name = "createdLabel";
			this.createdLabel.Size = new System.Drawing.Size(51, 15);
			this.createdLabel.TabIndex = 37;
			this.createdLabel.Text = "Created:";
			// 
			// createdTextBox
			// 
			this.createdTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.createdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.createdTextBox.Location = new System.Drawing.Point(97, 26);
			this.createdTextBox.Multiline = true;
			this.createdTextBox.Name = "createdTextBox";
			this.createdTextBox.ReadOnly = true;
			this.createdTextBox.Size = new System.Drawing.Size(249, 20);
			this.createdTextBox.TabIndex = 15;
			this.createdTextBox.Text = "Unknown";
			// 
			// propertiesButton
			// 
			this.propertiesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.propertiesButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.propertiesButton.Enabled = false;
			this.propertiesButton.FlatAppearance.BorderSize = 0;
			this.propertiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.propertiesButton.Image = ((System.Drawing.Image)(resources.GetObject("propertiesButton.Image")));
			this.propertiesButton.Location = new System.Drawing.Point(9, 579);
			this.propertiesButton.Margin = new System.Windows.Forms.Padding(0);
			this.propertiesButton.Name = "propertiesButton";
			this.propertiesButton.Size = new System.Drawing.Size(124, 23);
			this.propertiesButton.TabIndex = 17;
			this.propertiesButton.Text = "File properties";
			this.propertiesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.propertiesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.propertiesButton.UseVisualStyleBackColor = false;
			this.propertiesButton.Click += new System.EventHandler(this.propertiesButton_Click);
			this.propertiesButton.Paint += new System.Windows.Forms.PaintEventHandler(this.propertiesButton_Paint);
			// 
			// InfoForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(374, 611);
			this.Controls.Add(this.propertiesButton);
			this.Controls.Add(this.dateGroup);
			this.Controls.Add(this.sizeGroup);
			this.Controls.Add(this.fileGroup);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.logoPictureBox);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InfoForm";
			this.Padding = new System.Windows.Forms.Padding(9);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Image info";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InfoForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.fileGroup.ResumeLayout(false);
			this.fileGroup.PerformLayout();
			this.sizeGroup.ResumeLayout(false);
			this.sizeGroup.PerformLayout();
			this.dateGroup.ResumeLayout(false);
			this.dateGroup.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Label fileNameLabel;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.GroupBox fileGroup;
		private System.Windows.Forms.Label folderLabel;
		private System.Windows.Forms.TextBox fileNameTextBox;
		private System.Windows.Forms.TextBox folderTextBox;
		private System.Windows.Forms.TextBox fullPathTextBox;
		private System.Windows.Forms.Label fullPathLabel;
		private System.Windows.Forms.TextBox compressionTextBox;
		private System.Windows.Forms.Label compressionLabel;
		private System.Windows.Forms.TextBox sizeTextBox;
		private System.Windows.Forms.Label sizeLabel;
		private System.Windows.Forms.TextBox megapixelsTextBox;
		private System.Windows.Forms.Label megapixelsLabel;
		private System.Windows.Forms.TextBox resolutionTextBox;
		private System.Windows.Forms.Label resolutionLabel;
		private System.Windows.Forms.TextBox inchesTextBox;
		private System.Windows.Forms.Label inchesLabel;
		private System.Windows.Forms.TextBox cmTextBox;
		private System.Windows.Forms.Label cmLabel;
		private System.Windows.Forms.GroupBox sizeGroup;
		private System.Windows.Forms.GroupBox dateGroup;
		private System.Windows.Forms.Label createdLabel;
		private System.Windows.Forms.TextBox createdTextBox;
		private System.Windows.Forms.Label modifiedLabel;
		private System.Windows.Forms.TextBox modifiedTextBox;
		private System.Windows.Forms.TextBox diskSizeTextBox;
		private System.Windows.Forms.Label diskSizeLabel;
		private System.Windows.Forms.Button propertiesButton;
		private System.Windows.Forms.Label ratioLabel;
		private System.Windows.Forms.TextBox ratioTextBox;
		private System.Windows.Forms.Button copyNameButton;
		private System.Windows.Forms.Button copyFolderButton;
		private System.Windows.Forms.Button copyPathButton;
		private System.Windows.Forms.TextBox extensionTextBox;
		private System.Windows.Forms.Label extensionLabel;
		private System.Windows.Forms.ToolTip copyTooltip;
	}
}
