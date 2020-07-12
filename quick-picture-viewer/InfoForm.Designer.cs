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
			this.okButton = new QuickLibrary.QlibTextButton();
			this.fileGroup = new QuickLibrary.QlibGroupBox();
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
			this.sizeGroup = new QuickLibrary.QlibGroupBox();
			this.ratioLabel = new System.Windows.Forms.Label();
			this.ratioTextBox = new System.Windows.Forms.TextBox();
			this.diskSizeTextBox = new System.Windows.Forms.TextBox();
			this.diskSizeLabel = new System.Windows.Forms.Label();
			this.dateGroup = new QuickLibrary.QlibGroupBox();
			this.modifiedLabel = new System.Windows.Forms.Label();
			this.modifiedTextBox = new System.Windows.Forms.TextBox();
			this.createdLabel = new System.Windows.Forms.Label();
			this.createdTextBox = new System.Windows.Forms.TextBox();
			this.propertiesButton = new System.Windows.Forms.Button();
			this.copyTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.titlePanel = new System.Windows.Forms.Panel();
			this.titleLabel = new System.Windows.Forms.Label();
			this.closeBtn = new QuickLibrary.QlibCloseButton();
			this.fileGroup.SuspendLayout();
			this.sizeGroup.SuspendLayout();
			this.dateGroup.SuspendLayout();
			this.titlePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// fileNameLabel
			// 
			this.fileNameLabel.AutoSize = true;
			this.fileNameLabel.Location = new System.Drawing.Point(47, 29);
			this.fileNameLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fileNameLabel.Name = "fileNameLabel";
			this.fileNameLabel.Size = new System.Drawing.Size(48, 19);
			this.fileNameLabel.TabIndex = 27;
			this.fileNameLabel.Text = "Name:";
			// 
			// okButton
			// 
			this.okButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.FlatAppearance.BorderSize = 0;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okButton.Location = new System.Drawing.Point(523, 435);
			this.okButton.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(130, 23);
			this.okButton.TabIndex = 21;
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
			this.fileGroup.Location = new System.Drawing.Point(9, 169);
			this.fileGroup.Margin = new System.Windows.Forms.Padding(0);
			this.fileGroup.Name = "fileGroup";
			this.fileGroup.Padding = new System.Windows.Forms.Padding(0);
			this.fileGroup.Size = new System.Drawing.Size(356, 162);
			this.fileGroup.TabIndex = 0;
			this.fileGroup.TabStop = false;
			this.fileGroup.Text = "File";
			// 
			// extensionTextBox
			// 
			this.extensionTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.extensionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.extensionTextBox.Location = new System.Drawing.Point(255, 121);
			this.extensionTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.extensionTextBox.Name = "extensionTextBox";
			this.extensionTextBox.ReadOnly = true;
			this.extensionTextBox.Size = new System.Drawing.Size(60, 25);
			this.extensionTextBox.TabIndex = 8;
			this.extensionTextBox.Text = "Unknown";
			// 
			// extensionLabel
			// 
			this.extensionLabel.AutoSize = true;
			this.extensionLabel.Location = new System.Drawing.Point(185, 123);
			this.extensionLabel.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
			this.extensionLabel.Name = "extensionLabel";
			this.extensionLabel.Size = new System.Drawing.Size(70, 19);
			this.extensionLabel.TabIndex = 51;
			this.extensionLabel.Text = "Extension:";
			// 
			// copyPathButton
			// 
			this.copyPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.copyPathButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.copyPathButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.copyPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.copyPathButton.Image = ((System.Drawing.Image)(resources.GetObject("copyPathButton.Image")));
			this.copyPathButton.Location = new System.Drawing.Point(324, 89);
			this.copyPathButton.Margin = new System.Windows.Forms.Padding(0);
			this.copyPathButton.Name = "copyPathButton";
			this.copyPathButton.Size = new System.Drawing.Size(23, 23);
			this.copyPathButton.TabIndex = 6;
			this.copyPathButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.copyPathButton.UseVisualStyleBackColor = false;
			this.copyPathButton.Click += new System.EventHandler(this.copyPathButton_Click);
			// 
			// copyFolderButton
			// 
			this.copyFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.copyFolderButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.copyFolderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.copyFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.copyFolderButton.Image = ((System.Drawing.Image)(resources.GetObject("copyFolderButton.Image")));
			this.copyFolderButton.Location = new System.Drawing.Point(324, 57);
			this.copyFolderButton.Margin = new System.Windows.Forms.Padding(0);
			this.copyFolderButton.Name = "copyFolderButton";
			this.copyFolderButton.Size = new System.Drawing.Size(23, 23);
			this.copyFolderButton.TabIndex = 4;
			this.copyFolderButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.copyFolderButton.UseVisualStyleBackColor = false;
			this.copyFolderButton.Click += new System.EventHandler(this.copyFolderButton_Click);
			// 
			// copyNameButton
			// 
			this.copyNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.copyNameButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.copyNameButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.copyNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.copyNameButton.Image = ((System.Drawing.Image)(resources.GetObject("copyNameButton.Image")));
			this.copyNameButton.Location = new System.Drawing.Point(324, 25);
			this.copyNameButton.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
			this.copyNameButton.Name = "copyNameButton";
			this.copyNameButton.Size = new System.Drawing.Size(23, 23);
			this.copyNameButton.TabIndex = 2;
			this.copyNameButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.copyNameButton.UseVisualStyleBackColor = false;
			this.copyNameButton.Click += new System.EventHandler(this.copyNameButton_Click);
			// 
			// compressionTextBox
			// 
			this.compressionTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.compressionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.compressionTextBox.Location = new System.Drawing.Point(98, 121);
			this.compressionTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.compressionTextBox.Name = "compressionTextBox";
			this.compressionTextBox.ReadOnly = true;
			this.compressionTextBox.Size = new System.Drawing.Size(60, 25);
			this.compressionTextBox.TabIndex = 7;
			// 
			// compressionLabel
			// 
			this.compressionLabel.AutoSize = true;
			this.compressionLabel.Location = new System.Drawing.Point(9, 123);
			this.compressionLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.compressionLabel.Name = "compressionLabel";
			this.compressionLabel.Size = new System.Drawing.Size(92, 19);
			this.compressionLabel.TabIndex = 33;
			this.compressionLabel.Text = "Compression:";
			// 
			// fullPathTextBox
			// 
			this.fullPathTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.fullPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.fullPathTextBox.Location = new System.Drawing.Point(98, 89);
			this.fullPathTextBox.Margin = new System.Windows.Forms.Padding(9);
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
			this.fullPathLabel.Location = new System.Drawing.Point(33, 91);
			this.fullPathLabel.Margin = new System.Windows.Forms.Padding(0);
			this.fullPathLabel.Name = "fullPathLabel";
			this.fullPathLabel.Size = new System.Drawing.Size(65, 19);
			this.fullPathLabel.TabIndex = 31;
			this.fullPathLabel.Text = "Full path:";
			// 
			// folderTextBox
			// 
			this.folderTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.folderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.folderTextBox.Location = new System.Drawing.Point(98, 57);
			this.folderTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.folderTextBox.Name = "folderTextBox";
			this.folderTextBox.ReadOnly = true;
			this.folderTextBox.Size = new System.Drawing.Size(217, 25);
			this.folderTextBox.TabIndex = 3;
			this.folderTextBox.Text = "Not exists";
			// 
			// fileNameTextBox
			// 
			this.fileNameTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.fileNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.fileNameTextBox.Location = new System.Drawing.Point(98, 25);
			this.fileNameTextBox.Margin = new System.Windows.Forms.Padding(9);
			this.fileNameTextBox.Name = "fileNameTextBox";
			this.fileNameTextBox.ReadOnly = true;
			this.fileNameTextBox.Size = new System.Drawing.Size(217, 25);
			this.fileNameTextBox.TabIndex = 1;
			this.fileNameTextBox.Text = "None";
			// 
			// folderLabel
			// 
			this.folderLabel.AutoSize = true;
			this.folderLabel.Location = new System.Drawing.Point(46, 59);
			this.folderLabel.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
			this.folderLabel.Name = "folderLabel";
			this.folderLabel.Size = new System.Drawing.Size(50, 19);
			this.folderLabel.TabIndex = 28;
			this.folderLabel.Text = "Folder:";
			// 
			// sizeTextBox
			// 
			this.sizeTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.sizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.sizeTextBox.Location = new System.Drawing.Point(103, 25);
			this.sizeTextBox.Margin = new System.Windows.Forms.Padding(0, 9, 9, 0);
			this.sizeTextBox.Name = "sizeTextBox";
			this.sizeTextBox.ReadOnly = true;
			this.sizeTextBox.Size = new System.Drawing.Size(189, 25);
			this.sizeTextBox.TabIndex = 13;
			// 
			// sizeLabel
			// 
			this.sizeLabel.AutoSize = true;
			this.sizeLabel.Location = new System.Drawing.Point(40, 27);
			this.sizeLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.sizeLabel.Name = "sizeLabel";
			this.sizeLabel.Size = new System.Drawing.Size(61, 19);
			this.sizeLabel.TabIndex = 35;
			this.sizeLabel.Text = "Size (px):";
			// 
			// megapixelsTextBox
			// 
			this.megapixelsTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.megapixelsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.megapixelsTextBox.Location = new System.Drawing.Point(103, 57);
			this.megapixelsTextBox.Margin = new System.Windows.Forms.Padding(0, 9, 9, 0);
			this.megapixelsTextBox.Name = "megapixelsTextBox";
			this.megapixelsTextBox.ReadOnly = true;
			this.megapixelsTextBox.Size = new System.Drawing.Size(189, 25);
			this.megapixelsTextBox.TabIndex = 14;
			// 
			// megapixelsLabel
			// 
			this.megapixelsLabel.AutoSize = true;
			this.megapixelsLabel.Location = new System.Drawing.Point(35, 59);
			this.megapixelsLabel.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
			this.megapixelsLabel.Name = "megapixelsLabel";
			this.megapixelsLabel.Size = new System.Drawing.Size(67, 19);
			this.megapixelsLabel.TabIndex = 37;
			this.megapixelsLabel.Text = "Size (mp):";
			// 
			// resolutionTextBox
			// 
			this.resolutionTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.resolutionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.resolutionTextBox.Location = new System.Drawing.Point(103, 89);
			this.resolutionTextBox.Margin = new System.Windows.Forms.Padding(0, 9, 9, 0);
			this.resolutionTextBox.Name = "resolutionTextBox";
			this.resolutionTextBox.ReadOnly = true;
			this.resolutionTextBox.Size = new System.Drawing.Size(189, 25);
			this.resolutionTextBox.TabIndex = 15;
			// 
			// resolutionLabel
			// 
			this.resolutionLabel.AutoSize = true;
			this.resolutionLabel.Location = new System.Drawing.Point(28, 91);
			this.resolutionLabel.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
			this.resolutionLabel.Name = "resolutionLabel";
			this.resolutionLabel.Size = new System.Drawing.Size(76, 19);
			this.resolutionLabel.TabIndex = 39;
			this.resolutionLabel.Text = "Resolution:";
			// 
			// inchesTextBox
			// 
			this.inchesTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.inchesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inchesTextBox.Location = new System.Drawing.Point(103, 121);
			this.inchesTextBox.Margin = new System.Windows.Forms.Padding(0, 9, 9, 0);
			this.inchesTextBox.Name = "inchesTextBox";
			this.inchesTextBox.ReadOnly = true;
			this.inchesTextBox.Size = new System.Drawing.Size(189, 25);
			this.inchesTextBox.TabIndex = 16;
			// 
			// inchesLabel
			// 
			this.inchesLabel.AutoSize = true;
			this.inchesLabel.Location = new System.Drawing.Point(16, 123);
			this.inchesLabel.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
			this.inchesLabel.Name = "inchesLabel";
			this.inchesLabel.Size = new System.Drawing.Size(90, 19);
			this.inchesLabel.TabIndex = 41;
			this.inchesLabel.Text = "Print size (in):";
			// 
			// cmTextBox
			// 
			this.cmTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.cmTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmTextBox.Location = new System.Drawing.Point(103, 153);
			this.cmTextBox.Margin = new System.Windows.Forms.Padding(0, 9, 9, 0);
			this.cmTextBox.Name = "cmTextBox";
			this.cmTextBox.ReadOnly = true;
			this.cmTextBox.Size = new System.Drawing.Size(189, 25);
			this.cmTextBox.TabIndex = 17;
			// 
			// cmLabel
			// 
			this.cmLabel.AutoSize = true;
			this.cmLabel.Location = new System.Drawing.Point(9, 155);
			this.cmLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.cmLabel.Name = "cmLabel";
			this.cmLabel.Size = new System.Drawing.Size(97, 19);
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
			this.sizeGroup.Location = new System.Drawing.Point(373, 157);
			this.sizeGroup.Margin = new System.Windows.Forms.Padding(0);
			this.sizeGroup.Name = "sizeGroup";
			this.sizeGroup.Padding = new System.Windows.Forms.Padding(0);
			this.sizeGroup.Size = new System.Drawing.Size(301, 269);
			this.sizeGroup.TabIndex = 12;
			this.sizeGroup.TabStop = false;
			this.sizeGroup.Text = "Size";
			// 
			// ratioLabel
			// 
			this.ratioLabel.AutoSize = true;
			this.ratioLabel.Location = new System.Drawing.Point(21, 219);
			this.ratioLabel.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
			this.ratioLabel.Name = "ratioLabel";
			this.ratioLabel.Size = new System.Drawing.Size(85, 19);
			this.ratioLabel.TabIndex = 48;
			this.ratioLabel.Text = "Aspect ratio:";
			// 
			// ratioTextBox
			// 
			this.ratioTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.ratioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ratioTextBox.Location = new System.Drawing.Point(103, 217);
			this.ratioTextBox.Margin = new System.Windows.Forms.Padding(0, 9, 9, 0);
			this.ratioTextBox.Name = "ratioTextBox";
			this.ratioTextBox.ReadOnly = true;
			this.ratioTextBox.Size = new System.Drawing.Size(189, 25);
			this.ratioTextBox.TabIndex = 19;
			// 
			// diskSizeTextBox
			// 
			this.diskSizeTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.diskSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.diskSizeTextBox.Location = new System.Drawing.Point(103, 185);
			this.diskSizeTextBox.Margin = new System.Windows.Forms.Padding(0, 9, 9, 0);
			this.diskSizeTextBox.Name = "diskSizeTextBox";
			this.diskSizeTextBox.ReadOnly = true;
			this.diskSizeTextBox.Size = new System.Drawing.Size(189, 25);
			this.diskSizeTextBox.TabIndex = 18;
			this.diskSizeTextBox.Text = "Unknown";
			// 
			// diskSizeLabel
			// 
			this.diskSizeLabel.AutoSize = true;
			this.diskSizeLabel.Location = new System.Drawing.Point(40, 187);
			this.diskSizeLabel.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
			this.diskSizeLabel.Name = "diskSizeLabel";
			this.diskSizeLabel.Size = new System.Drawing.Size(64, 19);
			this.diskSizeLabel.TabIndex = 45;
			this.diskSizeLabel.Text = "Disk size:";
			// 
			// dateGroup
			// 
			this.dateGroup.Controls.Add(this.modifiedLabel);
			this.dateGroup.Controls.Add(this.modifiedTextBox);
			this.dateGroup.Controls.Add(this.createdLabel);
			this.dateGroup.Controls.Add(this.createdTextBox);
			this.dateGroup.Location = new System.Drawing.Point(9, 328);
			this.dateGroup.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.dateGroup.Name = "dateGroup";
			this.dateGroup.Padding = new System.Windows.Forms.Padding(0);
			this.dateGroup.Size = new System.Drawing.Size(356, 98);
			this.dateGroup.TabIndex = 9;
			this.dateGroup.TabStop = false;
			this.dateGroup.Text = "Date";
			// 
			// modifiedLabel
			// 
			this.modifiedLabel.AutoSize = true;
			this.modifiedLabel.Location = new System.Drawing.Point(31, 59);
			this.modifiedLabel.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
			this.modifiedLabel.Name = "modifiedLabel";
			this.modifiedLabel.Size = new System.Drawing.Size(66, 19);
			this.modifiedLabel.TabIndex = 39;
			this.modifiedLabel.Text = "Modified:";
			// 
			// modifiedTextBox
			// 
			this.modifiedTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.modifiedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.modifiedTextBox.Location = new System.Drawing.Point(98, 57);
			this.modifiedTextBox.Margin = new System.Windows.Forms.Padding(0, 9, 9, 0);
			this.modifiedTextBox.Name = "modifiedTextBox";
			this.modifiedTextBox.ReadOnly = true;
			this.modifiedTextBox.Size = new System.Drawing.Size(249, 25);
			this.modifiedTextBox.TabIndex = 11;
			this.modifiedTextBox.Text = "Unknown";
			// 
			// createdLabel
			// 
			this.createdLabel.AutoSize = true;
			this.createdLabel.Location = new System.Drawing.Point(38, 27);
			this.createdLabel.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
			this.createdLabel.Name = "createdLabel";
			this.createdLabel.Size = new System.Drawing.Size(60, 19);
			this.createdLabel.TabIndex = 37;
			this.createdLabel.Text = "Created:";
			// 
			// createdTextBox
			// 
			this.createdTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.createdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.createdTextBox.Location = new System.Drawing.Point(98, 25);
			this.createdTextBox.Margin = new System.Windows.Forms.Padding(0, 9, 9, 0);
			this.createdTextBox.Name = "createdTextBox";
			this.createdTextBox.ReadOnly = true;
			this.createdTextBox.Size = new System.Drawing.Size(249, 25);
			this.createdTextBox.TabIndex = 10;
			this.createdTextBox.Text = "Unknown";
			// 
			// propertiesButton
			// 
			this.propertiesButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.propertiesButton.Enabled = false;
			this.propertiesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.propertiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.propertiesButton.Image = ((System.Drawing.Image)(resources.GetObject("propertiesButton.Image")));
			this.propertiesButton.Location = new System.Drawing.Point(14, 435);
			this.propertiesButton.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.propertiesButton.Name = "propertiesButton";
			this.propertiesButton.Size = new System.Drawing.Size(130, 23);
			this.propertiesButton.TabIndex = 20;
			this.propertiesButton.Text = "File properties";
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
			this.titlePanel.Size = new System.Drawing.Size(600, 32);
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
			this.closeBtn.LightImage = global::quick_picture_viewer.Properties.Resources.white_close;
			this.closeBtn.Location = new System.Drawing.Point(568, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 1;
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// InfoForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.ClientSize = new System.Drawing.Size(600, 550);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.propertiesButton);
			this.Controls.Add(this.dateGroup);
			this.Controls.Add(this.sizeGroup);
			this.Controls.Add(this.fileGroup);
			this.Controls.Add(this.okButton);
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
			this.fileGroup.ResumeLayout(false);
			this.fileGroup.PerformLayout();
			this.sizeGroup.ResumeLayout(false);
			this.sizeGroup.PerformLayout();
			this.dateGroup.ResumeLayout(false);
			this.dateGroup.PerformLayout();
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label fileNameLabel;
		private QuickLibrary.QlibTextButton okButton;
		private QuickLibrary.QlibGroupBox fileGroup;
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
		private QuickLibrary.QlibGroupBox sizeGroup;
		private QuickLibrary.QlibGroupBox dateGroup;
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
		private System.Windows.Forms.Panel titlePanel;
		private System.Windows.Forms.Label titleLabel;
		private QuickLibrary.QlibCloseButton closeBtn;
	}
}
