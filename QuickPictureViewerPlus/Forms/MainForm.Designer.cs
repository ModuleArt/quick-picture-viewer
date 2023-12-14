namespace QuickPictureViewerPlus
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.toolStrip1 = new QuickLibrary.QlibToolbar();
			this.toolStripSeparator4 = new QuickLibrary.QlibToolsep();
			this.toolStripSeparator1 = new QuickLibrary.QlibToolsep();
			this.zoomTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator2 = new QuickLibrary.QlibToolsep();
			this.toolStripSeparator3 = new QuickLibrary.QlibToolsep();
			this.qlibToolsep1 = new QuickLibrary.QlibToolsep();
			this.rmbMenu = new QuickLibrary.QlibContextMenuStrip(this.components);
			this.qlibToolsep5 = new QuickLibrary.QlibToolsep();
			this.qlibToolsep3 = new QuickLibrary.QlibToolsep();
			this.infoTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.suggestionLabel = new System.Windows.Forms.Label();
			this.picturePanel = new QuickPictureViewerPlus.CustomPanel();
			this.pleaseOpenLabel = new System.Windows.Forms.Label();
			this.suggestionIcon = new System.Windows.Forms.PictureBox();
			this.navNextBtn = new System.Windows.Forms.Button();
			this.navPrevBtn = new System.Windows.Forms.Button();
			this.typeOpsButton = new System.Windows.Forms.Button();
			this.selectionLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.directoryLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.fileLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.hasChangesLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.sizeLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.zoomLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.dateCreatedLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.dateModifiedLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.openBtn = new System.Windows.Forms.ToolStripDropDownButton();
			this.openFileBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.openFolderBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.openRecursive = new System.Windows.Forms.ToolStripMenuItem();
			this.saveMenuBtn = new System.Windows.Forms.ToolStripDropDownButton();
			this.saveBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.externalBtn = new System.Windows.Forms.ToolStripDropDownButton();
			this.externalRunBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.externalFavoriteBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.externalChooseBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.infoButton = new System.Windows.Forms.ToolStripButton();
			this.prevButton = new System.Windows.Forms.ToolStripButton();
			this.slideshowButton = new System.Windows.Forms.ToolStripButton();
			this.nextButton = new System.Windows.Forms.ToolStripButton();
			this.autoZoomButton = new System.Windows.Forms.ToolStripButton();
			this.zoomOutButton = new System.Windows.Forms.ToolStripButton();
			this.zoomInButton = new System.Windows.Forms.ToolStripButton();
			this.zoom100Btn = new System.Windows.Forms.ToolStripButton();
			this.selectionBtn = new System.Windows.Forms.ToolStripButton();
			this.editButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.flipHorizontalButton = new System.Windows.Forms.ToolStripMenuItem();
			this.flipVerticalButton = new System.Windows.Forms.ToolStripMenuItem();
			this.qlibToolsep4 = new QuickLibrary.QlibToolsep();
			this.rotateRightButton = new System.Windows.Forms.ToolStripMenuItem();
			this.rotateLeftButton = new System.Windows.Forms.ToolStripMenuItem();
			this.rotate180Button = new System.Windows.Forms.ToolStripMenuItem();
			this.customAngleBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new QuickLibrary.QlibToolsep();
			this.cropBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.filteringModeBtn = new System.Windows.Forms.ToolStripDropDownButton();
			this.bilinearBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.nearestNeighborBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.effectsBtn = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolsBtn = new System.Windows.Forms.ToolStripDropDownButton();
			this.checkboardButton = new System.Windows.Forms.ToolStripButton();
			this.fullscreenBtn = new System.Windows.Forms.ToolStripButton();
			this.miniViewButton = new System.Windows.Forms.ToolStripButton();
			this.moreButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.reloadButton = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.permDeleteBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.printButton = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator9 = new QuickLibrary.QlibToolsep();
			this.backColorBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.backCustomBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.qlibMenuSeparator1 = new QuickLibrary.QlibToolsep();
			this.backClearBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.onTopButton = new System.Windows.Forms.ToolStripMenuItem();
			this.framelessBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.newWindowButton = new System.Windows.Forms.ToolStripMenuItem();
			this.qlibToolsep2 = new QuickLibrary.QlibToolsep();
			this.pluginManBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator10 = new QuickLibrary.QlibToolsep();
			this.settingsButton = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.framelessCloseBtn = new System.Windows.Forms.ToolStripButton();
			this.pictureBox = new QuickPictureViewerPlus.QuickPictureBox();
			this.showMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showNavArrowsBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.showToolbarBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.showStatusbarBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.wallpaperBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.copyBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.copyImageBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.copyFileBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.selectAllBtn = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.rmbMenu.SuspendLayout();
			this.picturePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.suggestionIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "image";
			this.openFileDialog1.RestoreDirectory = true;
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "Image";
			this.saveFileDialog1.Filter = "PNG (*.png)|*.png|JPG (*.jpg, *.jpeg, *.jpe, *.jfif, *.exif)|*.jpg|GIF (*.gif)|*." +
	"gif|BMP (*.bmp, *.dib, *.rle)|*.bmp|TIF (*.tiff, *.tif)|*.tiff|ICO (*.ico)|*.ico" +
	"|WEBP (*.webp)|*.webp";
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(0);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.selectionLabel,
			this.directoryLabel,
			this.fileLabel,
			this.hasChangesLabel,
			this.sizeLabel,
			this.zoomLabel,
			this.dateCreatedLabel,
			this.dateModifiedLabel});
			this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.statusStrip1.Location = new System.Drawing.Point(0, 419);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.ShowItemToolTips = true;
			this.statusStrip1.Size = new System.Drawing.Size(684, 27);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			this.statusStrip1.VisibleChanged += new System.EventHandler(this.statusStrip1_VisibleChanged);
			// 
			// printDialog1
			// 
			this.printDialog1.Document = this.printDocument1;
			this.printDialog1.UseEXDialog = true;
			// 
			// printDocument1
			// 
			this.printDocument1.DocumentName = "";
			this.printDocument1.OriginAtMargins = true;
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// colorDialog1
			// 
			this.colorDialog1.Color = System.Drawing.Color.Blue;
			// 
			// toolStrip1
			// 
			this.toolStrip1.AlternativeAppearance = true;
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.BackColor = System.Drawing.Color.White;
			this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.toolStrip1.CanOverflow = false;
			this.toolStrip1.DarkMode = false;
			this.toolStrip1.DragForm = true;
			this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStrip1.ForeColor = System.Drawing.Color.Black;
			this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.openBtn,
			this.saveMenuBtn,
			this.externalBtn,
			this.infoButton,
			this.toolStripSeparator4,
			this.prevButton,
			this.slideshowButton,
			this.nextButton,
			this.toolStripSeparator1,
			this.autoZoomButton,
			this.zoomOutButton,
			this.zoomTextBox,
			this.zoomInButton,
			this.zoom100Btn,
			this.toolStripSeparator2,
			this.selectionBtn,
			this.editButton,
			this.filteringModeBtn,
			this.effectsBtn,
			this.toolsBtn,
			this.toolStripSeparator3,
			this.checkboardButton,
			this.fullscreenBtn,
			this.miniViewButton,
			this.qlibToolsep1,
			this.moreButton,
			this.framelessCloseBtn});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.toolStrip1.Size = new System.Drawing.Size(684, 32);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.VisibleChanged += new System.EventHandler(this.toolStrip1_VisibleChanged);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.AutoSize = false;
			this.toolStripSeparator4.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStripSeparator4.DarkMode = false;
			this.toolStripSeparator4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.toolStripSeparator4.InsideMenu = false;
			this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.toolStripSeparator4.Size = new System.Drawing.Size(1, 24);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.AutoSize = false;
			this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStripSeparator1.DarkMode = false;
			this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.toolStripSeparator1.InsideMenu = false;
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.toolStripSeparator1.Size = new System.Drawing.Size(1, 24);
			// 
			// zoomTextBox
			// 
			this.zoomTextBox.BackColor = System.Drawing.Color.White;
			this.zoomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.zoomTextBox.Enabled = false;
			this.zoomTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.zoomTextBox.Margin = new System.Windows.Forms.Padding(7, -1, 7, -1);
			this.zoomTextBox.MaxLength = 12;
			this.zoomTextBox.Name = "zoomTextBox";
			this.zoomTextBox.Size = new System.Drawing.Size(44, 24);
			this.zoomTextBox.Text = "Auto";
			this.zoomTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.zoomTextBox.ToolTipText = "Zoom";
			this.zoomTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zoomTextBox_KeyPress);
			this.zoomTextBox.MouseEnter += new System.EventHandler(this.zoomTextBox_MouseEnter);
			this.zoomTextBox.MouseLeave += new System.EventHandler(this.zoomTextBox_MouseLeave);
			this.zoomTextBox.TextChanged += new System.EventHandler(this.zoomComboBox_TextChanged);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.AutoSize = false;
			this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStripSeparator2.DarkMode = false;
			this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.toolStripSeparator2.InsideMenu = false;
			this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.toolStripSeparator2.Size = new System.Drawing.Size(1, 24);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.AutoSize = false;
			this.toolStripSeparator3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStripSeparator3.DarkMode = false;
			this.toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.toolStripSeparator3.InsideMenu = false;
			this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.toolStripSeparator3.Size = new System.Drawing.Size(1, 24);
			// 
			// qlibToolsep1
			// 
			this.qlibToolsep1.AutoSize = false;
			this.qlibToolsep1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.qlibToolsep1.DarkMode = false;
			this.qlibToolsep1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.qlibToolsep1.InsideMenu = false;
			this.qlibToolsep1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.qlibToolsep1.Name = "qlibToolsep1";
			this.qlibToolsep1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.qlibToolsep1.Size = new System.Drawing.Size(1, 24);
			// 
			// rmbMenu
			// 
			this.rmbMenu.BackColor = System.Drawing.SystemColors.ControlLight;
			this.rmbMenu.DarkMode = false;
			this.rmbMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rmbMenu.ForeColor = System.Drawing.Color.Black;
			this.rmbMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.showMenuItem,
			this.qlibToolsep5,
			this.wallpaperBtn,
			this.qlibToolsep3,
			this.copyBtn,
			this.pasteBtn,
			this.selectAllBtn});
			this.rmbMenu.Name = "rmbMenu";
			this.rmbMenu.Size = new System.Drawing.Size(288, 152);
			this.rmbMenu.Opening += new System.ComponentModel.CancelEventHandler(this.rmbMenu_Opening);
			// 
			// qlibToolsep5
			// 
			this.qlibToolsep5.AutoSize = false;
			this.qlibToolsep5.BackColor = System.Drawing.SystemColors.ControlLight;
			this.qlibToolsep5.DarkMode = false;
			this.qlibToolsep5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.qlibToolsep5.InsideMenu = true;
			this.qlibToolsep5.Margin = new System.Windows.Forms.Padding(4);
			this.qlibToolsep5.Name = "qlibToolsep5";
			this.qlibToolsep5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.qlibToolsep5.Size = new System.Drawing.Size(284, 6);
			// 
			// qlibToolsep3
			// 
			this.qlibToolsep3.AutoSize = false;
			this.qlibToolsep3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.qlibToolsep3.DarkMode = false;
			this.qlibToolsep3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.qlibToolsep3.InsideMenu = true;
			this.qlibToolsep3.Margin = new System.Windows.Forms.Padding(4);
			this.qlibToolsep3.Name = "qlibToolsep3";
			this.qlibToolsep3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.qlibToolsep3.Size = new System.Drawing.Size(284, 6);
			// 
			// suggestionLabel
			// 
			this.suggestionLabel.AutoSize = true;
			this.suggestionLabel.BackColor = System.Drawing.Color.Black;
			this.suggestionLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.suggestionLabel.ForeColor = System.Drawing.Color.White;
			this.suggestionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.suggestionLabel.Location = new System.Drawing.Point(53, 59);
			this.suggestionLabel.Margin = new System.Windows.Forms.Padding(0, 27, 0, 0);
			this.suggestionLabel.Name = "suggestionLabel";
			this.suggestionLabel.Padding = new System.Windows.Forms.Padding(0, 3, 3, 4);
			this.suggestionLabel.Size = new System.Drawing.Size(79, 26);
			this.suggestionLabel.TabIndex = 3;
			this.suggestionLabel.Text = "suggestion";
			this.suggestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.suggestionLabel.Visible = false;
			// 
			// picturePanel
			// 
			this.picturePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.picturePanel.AutoScroll = true;
			this.picturePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.picturePanel.BackColor = System.Drawing.Color.Transparent;
			this.picturePanel.Controls.Add(this.pleaseOpenLabel);
			this.picturePanel.Controls.Add(this.pictureBox);
			this.picturePanel.Location = new System.Drawing.Point(0, 32);
			this.picturePanel.Margin = new System.Windows.Forms.Padding(0);
			this.picturePanel.Name = "picturePanel";
			this.picturePanel.Size = new System.Drawing.Size(684, 385);
			this.picturePanel.TabIndex = 2;
			this.picturePanel.SizeChanged += new System.EventHandler(this.picturePanel_SizeChanged);
			this.picturePanel.DoubleClick += new System.EventHandler(this.picturePanel_DoubleClick);
			this.picturePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseClick);
			this.picturePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseDown);
			this.picturePanel.MouseEnter += new System.EventHandler(this.picturePanel_MouseEnter);
			this.picturePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseMove);
			this.picturePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseUp);
			// 
			// pleaseOpenLabel
			// 
			this.pleaseOpenLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pleaseOpenLabel.Enabled = false;
			this.pleaseOpenLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.pleaseOpenLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pleaseOpenLabel.Location = new System.Drawing.Point(0, 0);
			this.pleaseOpenLabel.Margin = new System.Windows.Forms.Padding(0);
			this.pleaseOpenLabel.Name = "pleaseOpenLabel";
			this.pleaseOpenLabel.Size = new System.Drawing.Size(684, 385);
			this.pleaseOpenLabel.TabIndex = 5;
			this.pleaseOpenLabel.Text = "please open image";
			this.pleaseOpenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.pleaseOpenLabel.DoubleClick += new System.EventHandler(this.picturePanel_DoubleClick);
			// 
			// suggestionIcon
			// 
			this.suggestionIcon.BackColor = System.Drawing.Color.Black;
			this.suggestionIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.suggestionIcon.Location = new System.Drawing.Point(27, 59);
			this.suggestionIcon.Margin = new System.Windows.Forms.Padding(27, 27, 0, 0);
			this.suggestionIcon.Name = "suggestionIcon";
			this.suggestionIcon.Size = new System.Drawing.Size(26, 26);
			this.suggestionIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.suggestionIcon.TabIndex = 6;
			this.suggestionIcon.TabStop = false;
			this.suggestionIcon.Visible = false;
			// 
			// navNextBtn
			// 
			this.navNextBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.navNextBtn.BackColor = System.Drawing.Color.Black;
			this.navNextBtn.FlatAppearance.BorderSize = 0;
			this.navNextBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
			this.navNextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.navNextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.navNextBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.navNextBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.navNextBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.white_next;
			this.navNextBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.navNextBtn.Location = new System.Drawing.Point(625, 193);
			this.navNextBtn.Margin = new System.Windows.Forms.Padding(27);
			this.navNextBtn.Name = "navNextBtn";
			this.navNextBtn.Size = new System.Drawing.Size(32, 64);
			this.navNextBtn.TabIndex = 8;
			this.navNextBtn.TabStop = false;
			this.navNextBtn.UseVisualStyleBackColor = false;
			this.navNextBtn.Visible = false;
			this.navNextBtn.Click += new System.EventHandler(this.navNextBtn_Click);
			// 
			// navPrevBtn
			// 
			this.navPrevBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.navPrevBtn.BackColor = System.Drawing.Color.Black;
			this.navPrevBtn.FlatAppearance.BorderSize = 0;
			this.navPrevBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
			this.navPrevBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.navPrevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.navPrevBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.navPrevBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.navPrevBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.white_prev;
			this.navPrevBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.navPrevBtn.Location = new System.Drawing.Point(27, 193);
			this.navPrevBtn.Margin = new System.Windows.Forms.Padding(27);
			this.navPrevBtn.Name = "navPrevBtn";
			this.navPrevBtn.Size = new System.Drawing.Size(32, 64);
			this.navPrevBtn.TabIndex = 7;
			this.navPrevBtn.TabStop = false;
			this.navPrevBtn.UseVisualStyleBackColor = false;
			this.navPrevBtn.Visible = false;
			this.navPrevBtn.Click += new System.EventHandler(this.navPrevBtn_Click);
			// 
			// typeOpsButton
			// 
			this.typeOpsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.typeOpsButton.BackColor = System.Drawing.Color.Black;
			this.typeOpsButton.FlatAppearance.BorderSize = 0;
			this.typeOpsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
			this.typeOpsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.typeOpsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.typeOpsButton.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.typeOpsButton.ForeColor = System.Drawing.Color.White;
			this.typeOpsButton.Image = global::QuickPictureViewerPlus.Properties.Resources.white_options;
			this.typeOpsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.typeOpsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.typeOpsButton.Location = new System.Drawing.Point(537, 358);
			this.typeOpsButton.Margin = new System.Windows.Forms.Padding(27);
			this.typeOpsButton.Name = "typeOpsButton";
			this.typeOpsButton.Size = new System.Drawing.Size(120, 32);
			this.typeOpsButton.TabIndex = 0;
			this.typeOpsButton.TabStop = false;
			this.typeOpsButton.Text = " type options";
			this.typeOpsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.typeOpsButton.UseVisualStyleBackColor = false;
			this.typeOpsButton.Visible = false;
			this.typeOpsButton.Click += new System.EventHandler(this.typeOpsButton_Click);
			// 
			// selectionLabel
			// 
			this.selectionLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.selectionLabel.BackColor = System.Drawing.Color.Transparent;
			this.selectionLabel.Image = global::QuickPictureViewerPlus.Properties.Resources.black_selection;
			this.selectionLabel.IsLink = true;
			this.selectionLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.selectionLabel.LinkColor = System.Drawing.Color.Black;
			this.selectionLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.selectionLabel.Name = "selectionLabel";
			this.selectionLabel.Size = new System.Drawing.Size(75, 17);
			this.selectionLabel.Text = "selection";
			this.selectionLabel.Visible = false;
			this.selectionLabel.VisitedLinkColor = System.Drawing.Color.Black;
			this.selectionLabel.Click += new System.EventHandler(this.selectionLabel_Click);
			// 
			// directoryLabel
			// 
			this.directoryLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.directoryLabel.BackColor = System.Drawing.Color.Transparent;
			this.directoryLabel.Image = global::QuickPictureViewerPlus.Properties.Resources.black_picfolder;
			this.directoryLabel.IsLink = true;
			this.directoryLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.directoryLabel.LinkColor = System.Drawing.Color.Black;
			this.directoryLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.directoryLabel.Name = "directoryLabel";
			this.directoryLabel.Size = new System.Drawing.Size(59, 17);
			this.directoryLabel.Text = "folder";
			this.directoryLabel.Visible = false;
			this.directoryLabel.VisitedLinkColor = System.Drawing.Color.Black;
			this.directoryLabel.Click += new System.EventHandler(this.directoryLabel_Click);
			// 
			// fileLabel
			// 
			this.fileLabel.BackColor = System.Drawing.Color.Transparent;
			this.fileLabel.Image = global::QuickPictureViewerPlus.Properties.Resources.black_imgfile;
			this.fileLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.fileLabel.Name = "fileLabel";
			this.fileLabel.Size = new System.Drawing.Size(41, 17);
			this.fileLabel.Text = "file";
			// 
			// hasChangesLabel
			// 
			this.hasChangesLabel.BackColor = System.Drawing.Color.Transparent;
			this.hasChangesLabel.Image = ((System.Drawing.Image)(resources.GetObject("hasChangesLabel.Image")));
			this.hasChangesLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.hasChangesLabel.Name = "hasChangesLabel";
			this.hasChangesLabel.Size = new System.Drawing.Size(82, 17);
			this.hasChangesLabel.Text = "not-saved";
			this.hasChangesLabel.Visible = false;
			// 
			// sizeLabel
			// 
			this.sizeLabel.BackColor = System.Drawing.Color.Transparent;
			this.sizeLabel.Image = ((System.Drawing.Image)(resources.GetObject("sizeLabel.Image")));
			this.sizeLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.sizeLabel.Name = "sizeLabel";
			this.sizeLabel.Size = new System.Drawing.Size(46, 17);
			this.sizeLabel.Text = "size";
			// 
			// zoomLabel
			// 
			this.zoomLabel.BackColor = System.Drawing.Color.Transparent;
			this.zoomLabel.Image = ((System.Drawing.Image)(resources.GetObject("zoomLabel.Image")));
			this.zoomLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.zoomLabel.Name = "zoomLabel";
			this.zoomLabel.Size = new System.Drawing.Size(57, 17);
			this.zoomLabel.Text = "zoom";
			// 
			// dateCreatedLabel
			// 
			this.dateCreatedLabel.BackColor = System.Drawing.Color.Transparent;
			this.dateCreatedLabel.Image = ((System.Drawing.Image)(resources.GetObject("dateCreatedLabel.Image")));
			this.dateCreatedLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.dateCreatedLabel.Name = "dateCreatedLabel";
			this.dateCreatedLabel.Size = new System.Drawing.Size(68, 17);
			this.dateCreatedLabel.Text = "created";
			this.dateCreatedLabel.Visible = false;
			// 
			// dateModifiedLabel
			// 
			this.dateModifiedLabel.BackColor = System.Drawing.Color.Transparent;
			this.dateModifiedLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.dateModifiedLabel.Image = ((System.Drawing.Image)(resources.GetObject("dateModifiedLabel.Image")));
			this.dateModifiedLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.dateModifiedLabel.Name = "dateModifiedLabel";
			this.dateModifiedLabel.Size = new System.Drawing.Size(76, 17);
			this.dateModifiedLabel.Text = "modified";
			this.dateModifiedLabel.Visible = false;
			// 
			// openBtn
			// 
			this.openBtn.AutoSize = false;
			this.openBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.openFileBtn,
			this.openFolderBtn,
			this.openRecursive});
			this.openBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_open;
			this.openBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.openBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openBtn.Margin = new System.Windows.Forms.Padding(0);
			this.openBtn.Name = "openBtn";
			this.openBtn.Size = new System.Drawing.Size(30, 25);
			// 
			// openFileBtn
			// 
			this.openFileBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.openFileBtn.ForeColor = System.Drawing.Color.Black;
			this.openFileBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_imgfile;
			this.openFileBtn.Name = "openFileBtn";
			this.openFileBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openFileBtn.Size = new System.Drawing.Size(237, 24);
			this.openFileBtn.Text = "open file";
			this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
			// 
			// openFolderBtn
			// 
			this.openFolderBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.openFolderBtn.ForeColor = System.Drawing.Color.Black;
			this.openFolderBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_imgfile;
			this.openFolderBtn.Name = "openFolderBtn";
			this.openFolderBtn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
			| System.Windows.Forms.Keys.O)));
			this.openFolderBtn.Size = new System.Drawing.Size(237, 24);
			this.openFolderBtn.Text = "open folder";
			this.openFolderBtn.Click += new System.EventHandler(this.openFolderBtn_Click);
			// 
			// openRecursive
			// 
			this.openRecursive.BackColor = System.Drawing.SystemColors.ControlLight;
			this.openRecursive.ForeColor = System.Drawing.Color.Black;
			this.openRecursive.Image = global::QuickPictureViewerPlus.Properties.Resources.black_recursive;
			this.openRecursive.Name = "openRecursive";
			this.openRecursive.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
			this.openRecursive.Size = new System.Drawing.Size(237, 24);
			this.openRecursive.Text = "open recursive";
			this.openRecursive.Click += new System.EventHandler(this.openRecursive_Click);
			// 
			// saveMenuBtn
			// 
			this.saveMenuBtn.AutoSize = false;
			this.saveMenuBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveMenuBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.saveBtn,
			this.saveAsBtn});
			this.saveMenuBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_save;
			this.saveMenuBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.saveMenuBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveMenuBtn.Margin = new System.Windows.Forms.Padding(0);
			this.saveMenuBtn.Name = "saveMenuBtn";
			this.saveMenuBtn.Size = new System.Drawing.Size(30, 25);
			// 
			// saveBtn
			// 
			this.saveBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.saveBtn.Enabled = false;
			this.saveBtn.ForeColor = System.Drawing.Color.Black;
			this.saveBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_save;
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveBtn.Size = new System.Drawing.Size(207, 24);
			this.saveBtn.Text = "save";
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// saveAsBtn
			// 
			this.saveAsBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.saveAsBtn.Enabled = false;
			this.saveAsBtn.ForeColor = System.Drawing.Color.Black;
			this.saveAsBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_saveas;
			this.saveAsBtn.Name = "saveAsBtn";
			this.saveAsBtn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
			| System.Windows.Forms.Keys.S)));
			this.saveAsBtn.Size = new System.Drawing.Size(207, 24);
			this.saveAsBtn.Text = "save as";
			this.saveAsBtn.Click += new System.EventHandler(this.saveAsButton_Click);
			// 
			// externalBtn
			// 
			this.externalBtn.AutoSize = false;
			this.externalBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.externalBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.externalRunBtn,
			this.externalFavoriteBtn,
			this.externalChooseBtn});
			this.externalBtn.Image = ((System.Drawing.Image)(resources.GetObject("externalBtn.Image")));
			this.externalBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.externalBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.externalBtn.Margin = new System.Windows.Forms.Padding(0);
			this.externalBtn.Name = "externalBtn";
			this.externalBtn.Size = new System.Drawing.Size(30, 25);
			this.externalBtn.DropDownOpened += new System.EventHandler(this.externalBtn_DropDownOpened);
			// 
			// externalRunBtn
			// 
			this.externalRunBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.externalRunBtn.Enabled = false;
			this.externalRunBtn.ForeColor = System.Drawing.Color.Black;
			this.externalRunBtn.Image = ((System.Drawing.Image)(resources.GetObject("externalRunBtn.Image")));
			this.externalRunBtn.Name = "externalRunBtn";
			this.externalRunBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.externalRunBtn.Size = new System.Drawing.Size(277, 24);
			this.externalRunBtn.Text = "open with default";
			this.externalRunBtn.Click += new System.EventHandler(this.externalRunBtn_Click);
			// 
			// externalFavoriteBtn
			// 
			this.externalFavoriteBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.externalFavoriteBtn.Enabled = false;
			this.externalFavoriteBtn.ForeColor = System.Drawing.Color.Black;
			this.externalFavoriteBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_paint;
			this.externalFavoriteBtn.Name = "externalFavoriteBtn";
			this.externalFavoriteBtn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
			| System.Windows.Forms.Keys.O)));
			this.externalFavoriteBtn.Size = new System.Drawing.Size(277, 24);
			this.externalFavoriteBtn.Text = "open with custom";
			this.externalFavoriteBtn.Click += new System.EventHandler(this.externalFavoriteBtn_Click);
			// 
			// externalChooseBtn
			// 
			this.externalChooseBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.externalChooseBtn.Enabled = false;
			this.externalChooseBtn.ForeColor = System.Drawing.Color.Black;
			this.externalChooseBtn.Image = ((System.Drawing.Image)(resources.GetObject("externalChooseBtn.Image")));
			this.externalChooseBtn.Name = "externalChooseBtn";
			this.externalChooseBtn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
			| System.Windows.Forms.Keys.E)));
			this.externalChooseBtn.Size = new System.Drawing.Size(277, 24);
			this.externalChooseBtn.Text = "choose app";
			this.externalChooseBtn.Click += new System.EventHandler(this.externalButton_Click);
			// 
			// infoButton
			// 
			this.infoButton.AutoSize = false;
			this.infoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.infoButton.Enabled = false;
			this.infoButton.Image = ((System.Drawing.Image)(resources.GetObject("infoButton.Image")));
			this.infoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.infoButton.Margin = new System.Windows.Forms.Padding(0);
			this.infoButton.Name = "infoButton";
			this.infoButton.Size = new System.Drawing.Size(24, 25);
			this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
			// 
			// prevButton
			// 
			this.prevButton.AutoSize = false;
			this.prevButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.prevButton.Enabled = false;
			this.prevButton.Image = ((System.Drawing.Image)(resources.GetObject("prevButton.Image")));
			this.prevButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.prevButton.Margin = new System.Windows.Forms.Padding(0);
			this.prevButton.Name = "prevButton";
			this.prevButton.Size = new System.Drawing.Size(24, 25);
			this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
			// 
			// slideshowButton
			// 
			this.slideshowButton.AutoSize = false;
			this.slideshowButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.slideshowButton.Enabled = false;
			this.slideshowButton.Image = ((System.Drawing.Image)(resources.GetObject("slideshowButton.Image")));
			this.slideshowButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.slideshowButton.Margin = new System.Windows.Forms.Padding(0);
			this.slideshowButton.Name = "slideshowButton";
			this.slideshowButton.Size = new System.Drawing.Size(24, 25);
			this.slideshowButton.Click += new System.EventHandler(this.slideshowButton_Click);
			// 
			// nextButton
			// 
			this.nextButton.AutoSize = false;
			this.nextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.nextButton.Enabled = false;
			this.nextButton.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Image")));
			this.nextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.nextButton.Margin = new System.Windows.Forms.Padding(0);
			this.nextButton.Name = "nextButton";
			this.nextButton.Size = new System.Drawing.Size(24, 25);
			this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
			this.nextButton.EnabledChanged += new System.EventHandler(this.nextButton_EnabledChanged);
			this.nextButton.VisibleChanged += new System.EventHandler(this.nextButton_VisibleChanged);
			// 
			// autoZoomButton
			// 
			this.autoZoomButton.AutoSize = false;
			this.autoZoomButton.Checked = true;
			this.autoZoomButton.CheckState = System.Windows.Forms.CheckState.Checked;
			this.autoZoomButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.autoZoomButton.Enabled = false;
			this.autoZoomButton.Image = ((System.Drawing.Image)(resources.GetObject("autoZoomButton.Image")));
			this.autoZoomButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.autoZoomButton.Margin = new System.Windows.Forms.Padding(0);
			this.autoZoomButton.Name = "autoZoomButton";
			this.autoZoomButton.Size = new System.Drawing.Size(24, 25);
			this.autoZoomButton.Click += new System.EventHandler(this.autoZoomButton_Click);
			// 
			// zoomOutButton
			// 
			this.zoomOutButton.AutoSize = false;
			this.zoomOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zoomOutButton.Enabled = false;
			this.zoomOutButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutButton.Image")));
			this.zoomOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.zoomOutButton.Margin = new System.Windows.Forms.Padding(0);
			this.zoomOutButton.Name = "zoomOutButton";
			this.zoomOutButton.Size = new System.Drawing.Size(24, 25);
			this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
			this.zoomOutButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zoomOutButton_MouseDown);
			this.zoomOutButton.MouseLeave += new System.EventHandler(this.zoomOutButton_MouseLeave);
			this.zoomOutButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zoomOutButton_MouseUp);
			// 
			// zoomInButton
			// 
			this.zoomInButton.AutoSize = false;
			this.zoomInButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zoomInButton.Enabled = false;
			this.zoomInButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomInButton.Image")));
			this.zoomInButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.zoomInButton.Margin = new System.Windows.Forms.Padding(0);
			this.zoomInButton.Name = "zoomInButton";
			this.zoomInButton.Size = new System.Drawing.Size(24, 25);
			this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
			this.zoomInButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zoomInButton_MouseDown);
			this.zoomInButton.MouseLeave += new System.EventHandler(this.zoomInButton_MouseLeave);
			this.zoomInButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zoomInButton_MouseUp);
			// 
			// zoom100Btn
			// 
			this.zoom100Btn.AutoSize = false;
			this.zoom100Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zoom100Btn.Enabled = false;
			this.zoom100Btn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_actualsize;
			this.zoom100Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.zoom100Btn.Margin = new System.Windows.Forms.Padding(0);
			this.zoom100Btn.Name = "zoom100Btn";
			this.zoom100Btn.Size = new System.Drawing.Size(24, 25);
			this.zoom100Btn.Click += new System.EventHandler(this.zoom100Btn_Click);
			// 
			// selectionBtn
			// 
			this.selectionBtn.AutoSize = false;
			this.selectionBtn.CheckOnClick = true;
			this.selectionBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.selectionBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_selection;
			this.selectionBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.selectionBtn.Margin = new System.Windows.Forms.Padding(0);
			this.selectionBtn.Name = "selectionBtn";
			this.selectionBtn.Size = new System.Drawing.Size(24, 25);
			this.selectionBtn.CheckedChanged += new System.EventHandler(this.selectionBtn_CheckedChanged);
			// 
			// editButton
			// 
			this.editButton.AutoSize = false;
			this.editButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.editButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.flipHorizontalButton,
			this.flipVerticalButton,
			this.qlibToolsep4,
			this.rotateRightButton,
			this.rotateLeftButton,
			this.rotate180Button,
			this.customAngleBtn,
			this.toolStripSeparator7,
			this.cropBtn});
			this.editButton.ForeColor = System.Drawing.Color.Black;
			this.editButton.Image = global::QuickPictureViewerPlus.Properties.Resources.black_edit;
			this.editButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.editButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.editButton.Margin = new System.Windows.Forms.Padding(0);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(30, 25);
			// 
			// flipHorizontalButton
			// 
			this.flipHorizontalButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.flipHorizontalButton.Enabled = false;
			this.flipHorizontalButton.ForeColor = System.Drawing.Color.Black;
			this.flipHorizontalButton.Image = ((System.Drawing.Image)(resources.GetObject("flipHorizontalButton.Image")));
			this.flipHorizontalButton.Name = "flipHorizontalButton";
			this.flipHorizontalButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
			this.flipHorizontalButton.Size = new System.Drawing.Size(243, 24);
			this.flipHorizontalButton.Text = "flip horizontal";
			this.flipHorizontalButton.Click += new System.EventHandler(this.flipHorizontalButton_Click);
			// 
			// flipVerticalButton
			// 
			this.flipVerticalButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.flipVerticalButton.Enabled = false;
			this.flipVerticalButton.ForeColor = System.Drawing.Color.Black;
			this.flipVerticalButton.Image = ((System.Drawing.Image)(resources.GetObject("flipVerticalButton.Image")));
			this.flipVerticalButton.Name = "flipVerticalButton";
			this.flipVerticalButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
			| System.Windows.Forms.Keys.H)));
			this.flipVerticalButton.Size = new System.Drawing.Size(243, 24);
			this.flipVerticalButton.Text = "flip vertical";
			this.flipVerticalButton.Click += new System.EventHandler(this.flipVerticalButton_Click);
			// 
			// qlibToolsep4
			// 
			this.qlibToolsep4.AutoSize = false;
			this.qlibToolsep4.BackColor = System.Drawing.SystemColors.ControlLight;
			this.qlibToolsep4.DarkMode = false;
			this.qlibToolsep4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.qlibToolsep4.InsideMenu = true;
			this.qlibToolsep4.Margin = new System.Windows.Forms.Padding(4);
			this.qlibToolsep4.Name = "qlibToolsep4";
			this.qlibToolsep4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.qlibToolsep4.Size = new System.Drawing.Size(240, 6);
			// 
			// rotateRightButton
			// 
			this.rotateRightButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.rotateRightButton.Enabled = false;
			this.rotateRightButton.ForeColor = System.Drawing.Color.Black;
			this.rotateRightButton.Image = global::QuickPictureViewerPlus.Properties.Resources.black_rotater;
			this.rotateRightButton.Name = "rotateRightButton";
			this.rotateRightButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
			this.rotateRightButton.Size = new System.Drawing.Size(243, 24);
			this.rotateRightButton.Text = "rotate right";
			this.rotateRightButton.Click += new System.EventHandler(this.rotateRightButton_Click);
			// 
			// rotateLeftButton
			// 
			this.rotateLeftButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.rotateLeftButton.Enabled = false;
			this.rotateLeftButton.ForeColor = System.Drawing.Color.Black;
			this.rotateLeftButton.Image = ((System.Drawing.Image)(resources.GetObject("rotateLeftButton.Image")));
			this.rotateLeftButton.Name = "rotateLeftButton";
			this.rotateLeftButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
			| System.Windows.Forms.Keys.G)));
			this.rotateLeftButton.Size = new System.Drawing.Size(243, 24);
			this.rotateLeftButton.Text = "rotate left";
			this.rotateLeftButton.Click += new System.EventHandler(this.rotateLeftButton_Click);
			// 
			// rotate180Button
			// 
			this.rotate180Button.BackColor = System.Drawing.SystemColors.ControlLight;
			this.rotate180Button.Enabled = false;
			this.rotate180Button.ForeColor = System.Drawing.Color.Black;
			this.rotate180Button.Image = ((System.Drawing.Image)(resources.GetObject("rotate180Button.Image")));
			this.rotate180Button.Name = "rotate180Button";
			this.rotate180Button.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
			this.rotate180Button.Size = new System.Drawing.Size(243, 24);
			this.rotate180Button.Text = "rotate 180";
			this.rotate180Button.Click += new System.EventHandler(this.rotate180Button_Click);
			// 
			// customAngleBtn
			// 
			this.customAngleBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.customAngleBtn.Enabled = false;
			this.customAngleBtn.ForeColor = System.Drawing.Color.Black;
			this.customAngleBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_angle;
			this.customAngleBtn.Name = "customAngleBtn";
			this.customAngleBtn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
			| System.Windows.Forms.Keys.J)));
			this.customAngleBtn.Size = new System.Drawing.Size(243, 24);
			this.customAngleBtn.Text = "custom angle";
			this.customAngleBtn.Visible = false;
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.AutoSize = false;
			this.toolStripSeparator7.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStripSeparator7.DarkMode = false;
			this.toolStripSeparator7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.toolStripSeparator7.InsideMenu = true;
			this.toolStripSeparator7.Margin = new System.Windows.Forms.Padding(4);
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.toolStripSeparator7.Size = new System.Drawing.Size(240, 6);
			// 
			// cropBtn
			// 
			this.cropBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.cropBtn.ForeColor = System.Drawing.Color.Black;
			this.cropBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_crop;
			this.cropBtn.Name = "cropBtn";
			this.cropBtn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
			| System.Windows.Forms.Keys.X)));
			this.cropBtn.Size = new System.Drawing.Size(243, 24);
			this.cropBtn.Text = "crop";
			this.cropBtn.Click += new System.EventHandler(this.cropBtn_Click);
			// 
			// filteringModeBtn
			// 
			this.filteringModeBtn.AutoSize = false;
			this.filteringModeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.filteringModeBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.bilinearBtn,
			this.nearestNeighborBtn});
			this.filteringModeBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_filtering;
			this.filteringModeBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.filteringModeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.filteringModeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.filteringModeBtn.Name = "filteringModeBtn";
			this.filteringModeBtn.Size = new System.Drawing.Size(30, 25);
			// 
			// bilinearBtn
			// 
			this.bilinearBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.bilinearBtn.ForeColor = System.Drawing.Color.Black;
			this.bilinearBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_bilinear;
			this.bilinearBtn.Name = "bilinearBtn";
			this.bilinearBtn.Size = new System.Drawing.Size(186, 24);
			this.bilinearBtn.Text = "Bilinear";
			this.bilinearBtn.Click += new System.EventHandler(this.bilinearBtn_Click);
			// 
			// nearestNeighborBtn
			// 
			this.nearestNeighborBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.nearestNeighborBtn.ForeColor = System.Drawing.Color.Black;
			this.nearestNeighborBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_nearest_neighbor;
			this.nearestNeighborBtn.Name = "nearestNeighborBtn";
			this.nearestNeighborBtn.Size = new System.Drawing.Size(186, 24);
			this.nearestNeighborBtn.Text = "Nearest Neighbor";
			this.nearestNeighborBtn.Click += new System.EventHandler(this.nearestNeighborBtn_Click);
			// 
			// effectsBtn
			// 
			this.effectsBtn.AutoSize = false;
			this.effectsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.effectsBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_effects;
			this.effectsBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.effectsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.effectsBtn.Margin = new System.Windows.Forms.Padding(0);
			this.effectsBtn.Name = "effectsBtn";
			this.effectsBtn.Size = new System.Drawing.Size(30, 25);
			this.effectsBtn.Visible = false;
			this.effectsBtn.DropDownOpening += new System.EventHandler(this.effectsBtn_DropDownOpening);
			// 
			// toolsBtn
			// 
			this.toolsBtn.AutoSize = false;
			this.toolsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolsBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_tools;
			this.toolsBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolsBtn.Margin = new System.Windows.Forms.Padding(0);
			this.toolsBtn.Name = "toolsBtn";
			this.toolsBtn.Size = new System.Drawing.Size(30, 25);
			this.toolsBtn.Visible = false;
			this.toolsBtn.DropDownOpening += new System.EventHandler(this.effectsBtn_DropDownOpening);
			// 
			// checkboardButton
			// 
			this.checkboardButton.AutoSize = false;
			this.checkboardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.checkboardButton.Image = global::QuickPictureViewerPlus.Properties.Resources.black_grid;
			this.checkboardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.checkboardButton.Margin = new System.Windows.Forms.Padding(0);
			this.checkboardButton.Name = "checkboardButton";
			this.checkboardButton.Size = new System.Drawing.Size(24, 25);
			this.checkboardButton.Click += new System.EventHandler(this.checkboardButton_Click);
			// 
			// fullscreenBtn
			// 
			this.fullscreenBtn.AutoSize = false;
			this.fullscreenBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.fullscreenBtn.Image = ((System.Drawing.Image)(resources.GetObject("fullscreenBtn.Image")));
			this.fullscreenBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.fullscreenBtn.Margin = new System.Windows.Forms.Padding(0);
			this.fullscreenBtn.Name = "fullscreenBtn";
			this.fullscreenBtn.Size = new System.Drawing.Size(24, 25);
			this.fullscreenBtn.Click += new System.EventHandler(this.fullscreenButton_Click);
			// 
			// miniViewButton
			// 
			this.miniViewButton.AutoSize = false;
			this.miniViewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.miniViewButton.Enabled = false;
			this.miniViewButton.Image = ((System.Drawing.Image)(resources.GetObject("miniViewButton.Image")));
			this.miniViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.miniViewButton.Margin = new System.Windows.Forms.Padding(0);
			this.miniViewButton.Name = "miniViewButton";
			this.miniViewButton.Size = new System.Drawing.Size(24, 25);
			this.miniViewButton.Click += new System.EventHandler(this.miniViewButton_Click);
			// 
			// moreButton
			// 
			this.moreButton.AutoSize = false;
			this.moreButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.moreButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.reloadButton,
			this.deleteBtn,
			this.permDeleteBtn,
			this.printButton,
			this.toolStripSeparator9,
			this.backColorBtn,
			this.onTopButton,
			this.framelessBtn,
			this.newWindowButton,
			this.qlibToolsep2,
			this.pluginManBtn,
			this.toolStripSeparator10,
			this.settingsButton,
			this.aboutBtn});
			this.moreButton.Image = ((System.Drawing.Image)(resources.GetObject("moreButton.Image")));
			this.moreButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.moreButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.moreButton.Margin = new System.Windows.Forms.Padding(0);
			this.moreButton.Name = "moreButton";
			this.moreButton.Size = new System.Drawing.Size(30, 25);
			// 
			// reloadButton
			// 
			this.reloadButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.reloadButton.Enabled = false;
			this.reloadButton.ForeColor = System.Drawing.Color.Black;
			this.reloadButton.Image = global::QuickPictureViewerPlus.Properties.Resources.black_sync;
			this.reloadButton.Name = "reloadButton";
			this.reloadButton.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.reloadButton.Size = new System.Drawing.Size(262, 24);
			this.reloadButton.Text = "reload file";
			this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
			// 
			// deleteBtn
			// 
			this.deleteBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.deleteBtn.Enabled = false;
			this.deleteBtn.ForeColor = System.Drawing.Color.Black;
			this.deleteBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_trash;
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.deleteBtn.Size = new System.Drawing.Size(262, 24);
			this.deleteBtn.Text = "move to trash";
			this.deleteBtn.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// permDeleteBtn
			// 
			this.permDeleteBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.permDeleteBtn.Enabled = false;
			this.permDeleteBtn.ForeColor = System.Drawing.Color.Black;
			this.permDeleteBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_permdel;
			this.permDeleteBtn.Name = "permDeleteBtn";
			this.permDeleteBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
			this.permDeleteBtn.Size = new System.Drawing.Size(262, 24);
			this.permDeleteBtn.Text = "permanently delete";
			this.permDeleteBtn.Click += new System.EventHandler(this.permDeleteBtn_Click);
			// 
			// printButton
			// 
			this.printButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.printButton.Enabled = false;
			this.printButton.ForeColor = System.Drawing.Color.Black;
			this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
			this.printButton.Name = "printButton";
			this.printButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.printButton.Size = new System.Drawing.Size(262, 24);
			this.printButton.Text = "print";
			this.printButton.Click += new System.EventHandler(this.printButton_Click);
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.AutoSize = false;
			this.toolStripSeparator9.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStripSeparator9.DarkMode = false;
			this.toolStripSeparator9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.toolStripSeparator9.InsideMenu = true;
			this.toolStripSeparator9.Margin = new System.Windows.Forms.Padding(4);
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.toolStripSeparator9.Size = new System.Drawing.Size(259, 6);
			// 
			// backColorBtn
			// 
			this.backColorBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.backColorBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.backCustomBtn,
			this.qlibMenuSeparator1,
			this.backClearBtn});
			this.backColorBtn.ForeColor = System.Drawing.Color.Black;
			this.backColorBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_palette;
			this.backColorBtn.Name = "backColorBtn";
			this.backColorBtn.Size = new System.Drawing.Size(262, 24);
			this.backColorBtn.Text = "background color";
			// 
			// backCustomBtn
			// 
			this.backCustomBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.backCustomBtn.ForeColor = System.Drawing.Color.Black;
			this.backCustomBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_palette;
			this.backCustomBtn.Name = "backCustomBtn";
			this.backCustomBtn.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.backCustomBtn.Size = new System.Drawing.Size(179, 24);
			this.backCustomBtn.Text = "choose color";
			this.backCustomBtn.Click += new System.EventHandler(this.backCustomBtn_Click);
			// 
			// qlibMenuSeparator1
			// 
			this.qlibMenuSeparator1.AutoSize = false;
			this.qlibMenuSeparator1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.qlibMenuSeparator1.DarkMode = false;
			this.qlibMenuSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.qlibMenuSeparator1.InsideMenu = true;
			this.qlibMenuSeparator1.Margin = new System.Windows.Forms.Padding(4);
			this.qlibMenuSeparator1.Name = "qlibMenuSeparator1";
			this.qlibMenuSeparator1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.qlibMenuSeparator1.Size = new System.Drawing.Size(176, 6);
			// 
			// backClearBtn
			// 
			this.backClearBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.backClearBtn.ForeColor = System.Drawing.Color.Black;
			this.backClearBtn.Image = ((System.Drawing.Image)(resources.GetObject("backClearBtn.Image")));
			this.backClearBtn.Name = "backClearBtn";
			this.backClearBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
			this.backClearBtn.Size = new System.Drawing.Size(179, 24);
			this.backClearBtn.Text = "clear";
			this.backClearBtn.Click += new System.EventHandler(this.backClearBtn_Click);
			// 
			// onTopButton
			// 
			this.onTopButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.onTopButton.ForeColor = System.Drawing.Color.Black;
			this.onTopButton.Image = ((System.Drawing.Image)(resources.GetObject("onTopButton.Image")));
			this.onTopButton.Name = "onTopButton";
			this.onTopButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.onTopButton.Size = new System.Drawing.Size(262, 24);
			this.onTopButton.Text = "always on top";
			this.onTopButton.Click += new System.EventHandler(this.onTopButton_Click);
			// 
			// framelessBtn
			// 
			this.framelessBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.framelessBtn.ForeColor = System.Drawing.Color.Black;
			this.framelessBtn.Image = ((System.Drawing.Image)(resources.GetObject("framelessBtn.Image")));
			this.framelessBtn.Name = "framelessBtn";
			this.framelessBtn.ShortcutKeys = System.Windows.Forms.Keys.F10;
			this.framelessBtn.Size = new System.Drawing.Size(262, 24);
			this.framelessBtn.Text = "frameless mode";
			this.framelessBtn.Click += new System.EventHandler(this.framelessBtn_Click);
			// 
			// newWindowButton
			// 
			this.newWindowButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.newWindowButton.ForeColor = System.Drawing.Color.Black;
			this.newWindowButton.Image = global::QuickPictureViewerPlus.Properties.Resources.black_newwindow;
			this.newWindowButton.Name = "newWindowButton";
			this.newWindowButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newWindowButton.Size = new System.Drawing.Size(262, 24);
			this.newWindowButton.Text = "new window";
			this.newWindowButton.Click += new System.EventHandler(this.newWindowButton_Click);
			// 
			// qlibToolsep2
			// 
			this.qlibToolsep2.AutoSize = false;
			this.qlibToolsep2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.qlibToolsep2.DarkMode = false;
			this.qlibToolsep2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.qlibToolsep2.InsideMenu = true;
			this.qlibToolsep2.Margin = new System.Windows.Forms.Padding(4);
			this.qlibToolsep2.Name = "qlibToolsep2";
			this.qlibToolsep2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.qlibToolsep2.Size = new System.Drawing.Size(259, 6);
			// 
			// pluginManBtn
			// 
			this.pluginManBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pluginManBtn.ForeColor = System.Drawing.Color.Black;
			this.pluginManBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_plugin;
			this.pluginManBtn.Name = "pluginManBtn";
			this.pluginManBtn.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.pluginManBtn.Size = new System.Drawing.Size(262, 24);
			this.pluginManBtn.Text = "plugin manager";
			this.pluginManBtn.Click += new System.EventHandler(this.pluginManBtn_Click_1);
			// 
			// toolStripSeparator10
			// 
			this.toolStripSeparator10.AutoSize = false;
			this.toolStripSeparator10.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStripSeparator10.DarkMode = false;
			this.toolStripSeparator10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.toolStripSeparator10.InsideMenu = true;
			this.toolStripSeparator10.Margin = new System.Windows.Forms.Padding(4);
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.toolStripSeparator10.Size = new System.Drawing.Size(259, 6);
			// 
			// settingsButton
			// 
			this.settingsButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.settingsButton.ForeColor = System.Drawing.Color.Black;
			this.settingsButton.Image = global::QuickPictureViewerPlus.Properties.Resources.black_settings;
			this.settingsButton.Name = "settingsButton";
			this.settingsButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemcomma)));
			this.settingsButton.Size = new System.Drawing.Size(262, 24);
			this.settingsButton.Text = "settings";
			this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
			// 
			// aboutBtn
			// 
			this.aboutBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.aboutBtn.ForeColor = System.Drawing.Color.Black;
			this.aboutBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_about;
			this.aboutBtn.Name = "aboutBtn";
			this.aboutBtn.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.aboutBtn.Size = new System.Drawing.Size(262, 24);
			this.aboutBtn.Text = "about";
			this.aboutBtn.Click += new System.EventHandler(this.aboutButton_Click);
			// 
			// framelessCloseBtn
			// 
			this.framelessCloseBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.framelessCloseBtn.AutoSize = false;
			this.framelessCloseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.framelessCloseBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_close;
			this.framelessCloseBtn.Margin = new System.Windows.Forms.Padding(0);
			this.framelessCloseBtn.Name = "framelessCloseBtn";
			this.framelessCloseBtn.Size = new System.Drawing.Size(24, 25);
			this.framelessCloseBtn.Visible = false;
			this.framelessCloseBtn.Click += new System.EventHandler(this.framelessCloseBtn_Click);
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pictureBox.InitialImage = null;
			this.pictureBox.Location = new System.Drawing.Point(0, 0);
			this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(684, 385);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			this.pictureBox.DoubleClick += new System.EventHandler(this.picturePanel_DoubleClick);
			this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseClick);
			this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseDown);
			this.pictureBox.MouseEnter += new System.EventHandler(this.picturePanel_MouseEnter);
			this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseMove);
			this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picturePanel_MouseUp);
			// 
			// showMenuItem
			// 
			this.showMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
			this.showMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.showNavArrowsBtn,
			this.showToolbarBtn,
			this.showStatusbarBtn});
			this.showMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.showMenuItem.ForeColor = System.Drawing.Color.Black;
			this.showMenuItem.Image = global::QuickPictureViewerPlus.Properties.Resources.black_show;
			this.showMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.showMenuItem.Name = "showMenuItem";
			this.showMenuItem.Size = new System.Drawing.Size(287, 24);
			this.showMenuItem.Text = "view";
			// 
			// showNavArrowsBtn
			// 
			this.showNavArrowsBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.showNavArrowsBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.showNavArrowsBtn.ForeColor = System.Drawing.Color.Black;
			this.showNavArrowsBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_arrows;
			this.showNavArrowsBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.showNavArrowsBtn.Name = "showNavArrowsBtn";
			this.showNavArrowsBtn.ShortcutKeys = System.Windows.Forms.Keys.F6;
			this.showNavArrowsBtn.Size = new System.Drawing.Size(205, 24);
			this.showNavArrowsBtn.Text = "show nav arrows";
			this.showNavArrowsBtn.Click += new System.EventHandler(this.showNavArrowsBtn_Click);
			// 
			// showToolbarBtn
			// 
			this.showToolbarBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.showToolbarBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.showToolbarBtn.ForeColor = System.Drawing.Color.Black;
			this.showToolbarBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_toolbar;
			this.showToolbarBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.showToolbarBtn.Name = "showToolbarBtn";
			this.showToolbarBtn.ShortcutKeys = System.Windows.Forms.Keys.F7;
			this.showToolbarBtn.Size = new System.Drawing.Size(205, 24);
			this.showToolbarBtn.Text = "show toolbar";
			this.showToolbarBtn.Click += new System.EventHandler(this.showToolbarBtn_Click);
			// 
			// showStatusbarBtn
			// 
			this.showStatusbarBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.showStatusbarBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.showStatusbarBtn.ForeColor = System.Drawing.Color.Black;
			this.showStatusbarBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_statusbar;
			this.showStatusbarBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.showStatusbarBtn.Name = "showStatusbarBtn";
			this.showStatusbarBtn.ShortcutKeys = System.Windows.Forms.Keys.F8;
			this.showStatusbarBtn.Size = new System.Drawing.Size(205, 24);
			this.showStatusbarBtn.Text = "show status bar";
			this.showStatusbarBtn.Click += new System.EventHandler(this.showStatusBarBtn_Click);
			// 
			// wallpaperBtn
			// 
			this.wallpaperBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.wallpaperBtn.Enabled = false;
			this.wallpaperBtn.ForeColor = System.Drawing.Color.Black;
			this.wallpaperBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_desktop;
			this.wallpaperBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.wallpaperBtn.Name = "wallpaperBtn";
			this.wallpaperBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
			this.wallpaperBtn.Size = new System.Drawing.Size(287, 24);
			this.wallpaperBtn.Text = "set as desktop background";
			this.wallpaperBtn.Click += new System.EventHandler(this.wallpaperBtn_Click);
			// 
			// copyBtn
			// 
			this.copyBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.copyBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.copyImageBtn,
			this.copyFileBtn});
			this.copyBtn.ForeColor = System.Drawing.Color.Black;
			this.copyBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_copy;
			this.copyBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.copyBtn.Name = "copyBtn";
			this.copyBtn.Size = new System.Drawing.Size(287, 24);
			this.copyBtn.Text = "copy";
			// 
			// copyImageBtn
			// 
			this.copyImageBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.copyImageBtn.ForeColor = System.Drawing.Color.Black;
			this.copyImageBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_image;
			this.copyImageBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.copyImageBtn.Name = "copyImageBtn";
			this.copyImageBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyImageBtn.Size = new System.Drawing.Size(215, 24);
			this.copyImageBtn.Text = "copy image";
			this.copyImageBtn.Click += new System.EventHandler(this.copyImageBtn_Click);
			this.copyImageBtn.EnabledChanged += new System.EventHandler(this.copyImageBtn_EnabledChanged);
			// 
			// copyFileBtn
			// 
			this.copyFileBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.copyFileBtn.ForeColor = System.Drawing.Color.Black;
			this.copyFileBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_imgfile;
			this.copyFileBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.copyFileBtn.Name = "copyFileBtn";
			this.copyFileBtn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
			| System.Windows.Forms.Keys.C)));
			this.copyFileBtn.Size = new System.Drawing.Size(215, 24);
			this.copyFileBtn.Text = "copy file";
			this.copyFileBtn.Click += new System.EventHandler(this.copyFileBtn_Click_1);
			this.copyFileBtn.EnabledChanged += new System.EventHandler(this.copyImageBtn_EnabledChanged);
			// 
			// pasteBtn
			// 
			this.pasteBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pasteBtn.ForeColor = System.Drawing.Color.Black;
			this.pasteBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_paste;
			this.pasteBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.pasteBtn.Name = "pasteBtn";
			this.pasteBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.pasteBtn.Size = new System.Drawing.Size(287, 24);
			this.pasteBtn.Text = "paste";
			this.pasteBtn.Click += new System.EventHandler(this.pasteBtn_Click);
			// 
			// selectAllBtn
			// 
			this.selectAllBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.selectAllBtn.Enabled = false;
			this.selectAllBtn.ForeColor = System.Drawing.Color.Black;
			this.selectAllBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_selectall;
			this.selectAllBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.selectAllBtn.Name = "selectAllBtn";
			this.selectAllBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.selectAllBtn.Size = new System.Drawing.Size(287, 24);
			this.selectAllBtn.Text = "select all";
			this.selectAllBtn.Click += new System.EventHandler(this.selectAllBtn_Click);
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(684, 446);
			this.Controls.Add(this.suggestionIcon);
			this.Controls.Add(this.suggestionLabel);
			this.Controls.Add(this.navNextBtn);
			this.Controls.Add(this.navPrevBtn);
			this.Controls.Add(this.typeOpsButton);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.picturePanel);
			this.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(420, 320);
			this.Name = "MainForm";
			this.Text = "Quick Picture Viewer";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.rmbMenu.ResumeLayout(false);
			this.picturePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.suggestionIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private QuickPictureBox pictureBox;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private QuickLibrary.QlibToolbar toolStrip1;
		private QuickLibrary.QlibToolsep toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton zoomInButton;
		private System.Windows.Forms.ToolStripButton zoomOutButton;
		private System.Windows.Forms.ToolStripButton autoZoomButton;
		private QuickLibrary.QlibToolsep toolStripSeparator2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStripButton framelessCloseBtn;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel directoryLabel;
		private System.Windows.Forms.ToolStripStatusLabel fileLabel;
		private System.Windows.Forms.ToolStripStatusLabel sizeLabel;
		private System.Windows.Forms.ToolStripStatusLabel zoomLabel;
		private System.Windows.Forms.ToolStripButton nextButton;
		private QuickLibrary.QlibToolsep toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton prevButton;
		private System.Windows.Forms.ToolStripStatusLabel dateCreatedLabel;
		private System.Windows.Forms.ToolStripStatusLabel dateModifiedLabel;
		private System.Windows.Forms.ToolStripButton infoButton;
		private CustomPanel picturePanel;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.ToolStripStatusLabel hasChangesLabel;
		private System.Windows.Forms.ToolStripButton checkboardButton;
		private System.Windows.Forms.Label suggestionLabel;
		private System.Windows.Forms.ToolStripButton slideshowButton;
		private System.Windows.Forms.ToolStripDropDownButton moreButton;
		private System.Windows.Forms.Button typeOpsButton;
		private System.Windows.Forms.ToolStripMenuItem reloadButton;
		private System.Windows.Forms.ToolStripDropDownButton editButton;
		private System.Windows.Forms.ToolStripMenuItem rotateLeftButton;
		private System.Windows.Forms.ToolStripMenuItem rotateRightButton;
		private System.Windows.Forms.ToolStripMenuItem flipHorizontalButton;
		private System.Windows.Forms.ToolStripMenuItem flipVerticalButton;
		private System.Windows.Forms.ToolStripMenuItem newWindowButton;
		private System.Windows.Forms.ToolStripMenuItem rotate180Button;
		private System.Windows.Forms.ToolStripButton miniViewButton;
		private System.Windows.Forms.ToolStripMenuItem settingsButton;
		private System.Windows.Forms.Label pleaseOpenLabel;
		private QuickLibrary.QlibToolsep toolStripSeparator7;
		private QuickLibrary.QlibToolsep toolStripSeparator9;
		private QuickLibrary.QlibToolsep toolStripSeparator10;
		private System.Windows.Forms.ToolStripMenuItem printButton;
		private System.Windows.Forms.ToolStripMenuItem onTopButton;
		private System.Windows.Forms.ToolStripTextBox zoomTextBox;
		private System.Windows.Forms.ToolStripDropDownButton externalBtn;
		private System.Windows.Forms.ToolStripMenuItem externalRunBtn;
		private System.Windows.Forms.ToolStripMenuItem externalChooseBtn;
		private System.Windows.Forms.ToolStripMenuItem externalFavoriteBtn;
		private System.Windows.Forms.ToolStripMenuItem backColorBtn;
		private System.Windows.Forms.ToolStripMenuItem backClearBtn;
		private QuickLibrary.QlibToolsep qlibMenuSeparator1;
		private System.Windows.Forms.ToolStripMenuItem backCustomBtn;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.ToolStripMenuItem deleteBtn;
		private System.Windows.Forms.ToolStripMenuItem aboutBtn;
		private System.Windows.Forms.ToolStripMenuItem framelessBtn;
		private System.Windows.Forms.ToolStripMenuItem customAngleBtn;
		private QuickLibrary.QlibToolsep toolStripSeparator3;
		private System.Windows.Forms.ToolStripDropDownButton effectsBtn;
		private System.Windows.Forms.PictureBox suggestionIcon;
		private System.Windows.Forms.ToolStripDropDownButton toolsBtn;
		private QuickLibrary.QlibToolsep qlibToolsep1;
		private System.Windows.Forms.ToolStripButton fullscreenBtn;
		private QuickLibrary.QlibContextMenuStrip rmbMenu;
		private System.Windows.Forms.ToolStripMenuItem showMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showStatusbarBtn;
		private System.Windows.Forms.ToolStripMenuItem showToolbarBtn;
		private System.Windows.Forms.ToolStripMenuItem pasteBtn;
		private System.Windows.Forms.ToolStripMenuItem pluginManBtn;
		private QuickLibrary.QlibToolsep qlibToolsep2;
		private System.Windows.Forms.ToolStripMenuItem copyBtn;
		private System.Windows.Forms.ToolStripMenuItem copyImageBtn;
		private System.Windows.Forms.ToolStripMenuItem copyFileBtn;
		private QuickLibrary.QlibToolsep qlibToolsep3;
		private System.Windows.Forms.ToolStripDropDownButton openBtn;
		private System.Windows.Forms.ToolStripMenuItem openFileBtn;
		private System.Windows.Forms.ToolStripMenuItem openRecursive;
		private System.Windows.Forms.ToolStripButton selectionBtn;
		private QuickLibrary.QlibToolsep qlibToolsep4;
		private System.Windows.Forms.ToolStripMenuItem cropBtn;
		private System.Windows.Forms.ToolStripStatusLabel selectionLabel;
		private System.Windows.Forms.Button navPrevBtn;
		private System.Windows.Forms.Button navNextBtn;
		private System.Windows.Forms.ToolStripMenuItem showNavArrowsBtn;
		private System.Windows.Forms.ToolStripMenuItem selectAllBtn;
		private System.Windows.Forms.ToolStripButton zoom100Btn;
		private QuickLibrary.QlibToolsep qlibToolsep5;
		private System.Windows.Forms.ToolStripMenuItem wallpaperBtn;
		private System.Windows.Forms.ToolTip infoTooltip;
		private System.Windows.Forms.ToolStripMenuItem permDeleteBtn;
		private System.Windows.Forms.ToolStripMenuItem openFolderBtn;
		private System.Windows.Forms.ToolStripDropDownButton saveMenuBtn;
		private System.Windows.Forms.ToolStripMenuItem saveBtn;
		private System.Windows.Forms.ToolStripMenuItem saveAsBtn;
		private System.Windows.Forms.ToolStripDropDownButton filteringModeBtn;
		private System.Windows.Forms.ToolStripMenuItem bilinearBtn;
		private System.Windows.Forms.ToolStripMenuItem nearestNeighborBtn;
	}
}