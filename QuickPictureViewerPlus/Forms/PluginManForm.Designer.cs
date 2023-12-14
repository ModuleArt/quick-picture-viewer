namespace QuickPictureViewerPlus
{
	partial class PluginManForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginManForm));
			this.listView1 = new QuickLibrary.QlibListView();
			this.pluginNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.descColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.authorsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.versionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new QuickLibrary.QlibContextMenuStrip(this.components);
			this.pluginWebsiteBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.qlibMenuSeparator2 = new QuickLibrary.QlibToolsep();
			this.deleteBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.infoTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.closeBtn = new QuickLibrary.QlibTitlebarButton();
			this.morePluginsBtn = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.addPluginBtn = new System.Windows.Forms.Button();
			this.refreshBtn = new System.Windows.Forms.Button();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.BackColor = System.Drawing.SystemColors.Control;
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pluginNameColumn,
            this.descColumn,
            this.authorsColumn,
            this.versionColumn});
			this.listView1.ContextMenuStrip = this.contextMenuStrip1;
			this.listView1.FullRowSelect = true;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(10, 42);
			this.listView1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.ShowItemToolTips = true;
			this.listView1.Size = new System.Drawing.Size(680, 306);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
			// 
			// pluginNameColumn
			// 
			this.pluginNameColumn.Text = "plugin";
			this.pluginNameColumn.Width = 136;
			// 
			// descColumn
			// 
			this.descColumn.Text = "desc";
			this.descColumn.Width = 272;
			// 
			// authorsColumn
			// 
			this.authorsColumn.Text = "authors";
			this.authorsColumn.Width = 204;
			// 
			// versionColumn
			// 
			this.versionColumn.Text = "version";
			this.versionColumn.Width = 68;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.contextMenuStrip1.DarkMode = false;
			this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.contextMenuStrip1.ForeColor = System.Drawing.Color.Black;
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pluginWebsiteBtn,
            this.qlibMenuSeparator2,
            this.deleteBtn});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(211, 66);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// pluginWebsiteBtn
			// 
			this.pluginWebsiteBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pluginWebsiteBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_website;
			this.pluginWebsiteBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.pluginWebsiteBtn.Name = "pluginWebsiteBtn";
			this.pluginWebsiteBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.pluginWebsiteBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
			this.pluginWebsiteBtn.Size = new System.Drawing.Size(210, 24);
			this.pluginWebsiteBtn.Text = "plugin website";
			this.pluginWebsiteBtn.Click += new System.EventHandler(this.pluginWebsiteBtn_Click);
			// 
			// qlibMenuSeparator2
			// 
			this.qlibMenuSeparator2.AutoSize = false;
			this.qlibMenuSeparator2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.qlibMenuSeparator2.DarkMode = false;
			this.qlibMenuSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.qlibMenuSeparator2.InsideMenu = true;
			this.qlibMenuSeparator2.Margin = new System.Windows.Forms.Padding(4);
			this.qlibMenuSeparator2.Name = "qlibMenuSeparator2";
			this.qlibMenuSeparator2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.qlibMenuSeparator2.Size = new System.Drawing.Size(207, 6);
			// 
			// deleteBtn
			// 
			this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_trash;
			this.deleteBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.deleteBtn.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.deleteBtn.Size = new System.Drawing.Size(210, 24);
			this.deleteBtn.Text = "delete plugin";
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// closeBtn
			// 
			this.closeBtn.DarkImage = global::QuickPictureViewerPlus.Properties.Resources.black_close;
			this.closeBtn.DarkMode = false;
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
			this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.ForeColor = System.Drawing.Color.Black;
			this.closeBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_close;
			this.closeBtn.IsRed = true;
			this.closeBtn.LightImage = global::QuickPictureViewerPlus.Properties.Resources.white_close;
			this.closeBtn.Location = new System.Drawing.Point(668, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 3;
			this.infoTooltip.SetToolTip(this.closeBtn, "Close (Alt+F4)");
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// morePluginsBtn
			// 
			this.morePluginsBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.morePluginsBtn.FlatAppearance.BorderSize = 0;
			this.morePluginsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.morePluginsBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_plugin;
			this.morePluginsBtn.Location = new System.Drawing.Point(490, 358);
			this.morePluginsBtn.Margin = new System.Windows.Forms.Padding(0);
			this.morePluginsBtn.Name = "morePluginsBtn";
			this.morePluginsBtn.Size = new System.Drawing.Size(200, 32);
			this.morePluginsBtn.TabIndex = 2;
			this.morePluginsBtn.Text = " more plugins";
			this.morePluginsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.morePluginsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.infoTooltip.SetToolTip(this.morePluginsBtn, "github.com/ModuleArt/qpv-plugins");
			this.morePluginsBtn.UseVisualStyleBackColor = false;
			this.morePluginsBtn.Click += new System.EventHandler(this.morePluginsBtn_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "QuickPlugins|*.qp.zip";
			this.openFileDialog1.RestoreDirectory = true;
			// 
			// addPluginBtn
			// 
			this.addPluginBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.addPluginBtn.FlatAppearance.BorderSize = 0;
			this.addPluginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addPluginBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_open;
			this.addPluginBtn.Location = new System.Drawing.Point(10, 358);
			this.addPluginBtn.Margin = new System.Windows.Forms.Padding(0);
			this.addPluginBtn.Name = "addPluginBtn";
			this.addPluginBtn.Size = new System.Drawing.Size(200, 32);
			this.addPluginBtn.TabIndex = 1;
			this.addPluginBtn.Text = " browse for plugins";
			this.addPluginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.addPluginBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.addPluginBtn.UseVisualStyleBackColor = false;
			this.addPluginBtn.Click += new System.EventHandler(this.addPluginBtn_Click);
			// 
			// refreshBtn
			// 
			this.refreshBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.refreshBtn.FlatAppearance.BorderSize = 0;
			this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.refreshBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_sync;
			this.refreshBtn.Location = new System.Drawing.Point(220, 358);
			this.refreshBtn.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.refreshBtn.Name = "refreshBtn";
			this.refreshBtn.Size = new System.Drawing.Size(32, 32);
			this.refreshBtn.TabIndex = 17;
			this.refreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.refreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.refreshBtn.UseVisualStyleBackColor = false;
			this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
			// 
			// PluginManForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.ClientSize = new System.Drawing.Size(700, 400);
			this.Controls.Add(this.refreshBtn);
			this.Controls.Add(this.closeBtn);
			this.Controls.Add(this.morePluginsBtn);
			this.Controls.Add(this.addPluginBtn);
			this.Controls.Add(this.listView1);
			this.Draggable = true;
			this.EscToClose = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PluginManForm";
			this.ShowInTaskbar = false;
			this.ShowTitle = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "PluginManForm";
			this.Load += new System.EventHandler(this.PluginManForm_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.PluginManForm_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.PluginManForm_DragEnter);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private QuickLibrary.QlibListView listView1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ColumnHeader pluginNameColumn;
		private System.Windows.Forms.ColumnHeader descColumn;
		private System.Windows.Forms.ToolTip infoTooltip;
		private QuickLibrary.QlibTitlebarButton closeBtn;
		private System.Windows.Forms.Button addPluginBtn;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ColumnHeader authorsColumn;
		private System.Windows.Forms.ColumnHeader versionColumn;
		private QuickLibrary.QlibContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem deleteBtn;
		private System.Windows.Forms.Button morePluginsBtn;
		private System.Windows.Forms.ToolStripMenuItem pluginWebsiteBtn;
		private QuickLibrary.QlibToolsep qlibMenuSeparator2;
		private System.Windows.Forms.Button refreshBtn;
	}
}