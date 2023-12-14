namespace QuickPictureViewerPlus
{
	partial class SelectionForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionForm));
			this.cropBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.qlibToolsep5 = new QuickLibrary.QlibToolsep();
			this.selectionCopyBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.selectionSelectAllBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.editSelectionBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.selectionMenu = new QuickLibrary.QlibContextMenuStrip(this.components);
			this.cutBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.selectionMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// cropBtn
			// 
			this.cropBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.cropBtn.ForeColor = System.Drawing.Color.Black;
			this.cropBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_crop;
			this.cropBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.cropBtn.Name = "cropBtn";
			this.cropBtn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
			this.cropBtn.Size = new System.Drawing.Size(201, 24);
			this.cropBtn.Text = "crop";
			this.cropBtn.Click += new System.EventHandler(this.cropBtn_Click);
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
			this.qlibToolsep5.Size = new System.Drawing.Size(198, 6);
			// 
			// selectionCopyBtn
			// 
			this.selectionCopyBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.selectionCopyBtn.ForeColor = System.Drawing.Color.Black;
			this.selectionCopyBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_copy;
			this.selectionCopyBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.selectionCopyBtn.Name = "selectionCopyBtn";
			this.selectionCopyBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.selectionCopyBtn.Size = new System.Drawing.Size(201, 24);
			this.selectionCopyBtn.Text = "copy";
			this.selectionCopyBtn.Click += new System.EventHandler(this.selectionCopyBtn_Click);
			// 
			// selectionSelectAllBtn
			// 
			this.selectionSelectAllBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.selectionSelectAllBtn.ForeColor = System.Drawing.Color.Black;
			this.selectionSelectAllBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_selectall;
			this.selectionSelectAllBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.selectionSelectAllBtn.Name = "selectionSelectAllBtn";
			this.selectionSelectAllBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.selectionSelectAllBtn.Size = new System.Drawing.Size(201, 24);
			this.selectionSelectAllBtn.Text = "select all";
			this.selectionSelectAllBtn.Click += new System.EventHandler(this.selectionSelectAllBtn_Click);
			// 
			// editSelectionBtn
			// 
			this.editSelectionBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.editSelectionBtn.ForeColor = System.Drawing.Color.Black;
			this.editSelectionBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_editsel;
			this.editSelectionBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.editSelectionBtn.Name = "editSelectionBtn";
			this.editSelectionBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
			this.editSelectionBtn.Size = new System.Drawing.Size(201, 24);
			this.editSelectionBtn.Text = "edit selection";
			this.editSelectionBtn.Click += new System.EventHandler(this.editSelectionBtn_Click);
			// 
			// selectionMenu
			// 
			this.selectionMenu.BackColor = System.Drawing.SystemColors.ControlLight;
			this.selectionMenu.DarkMode = false;
			this.selectionMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.selectionMenu.ForeColor = System.Drawing.Color.Black;
			this.selectionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cropBtn,
            this.qlibToolsep5,
            this.cutBtn,
            this.selectionCopyBtn,
            this.selectionSelectAllBtn,
            this.editSelectionBtn});
			this.selectionMenu.Name = "rmbMenu";
			this.selectionMenu.Size = new System.Drawing.Size(202, 138);
			// 
			// cutBtn
			// 
			this.cutBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.cutBtn.ForeColor = System.Drawing.Color.Black;
			this.cutBtn.Image = global::QuickPictureViewerPlus.Properties.Resources.black_cut;
			this.cutBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.cutBtn.Name = "cutBtn";
			this.cutBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.cutBtn.Size = new System.Drawing.Size(201, 24);
			this.cutBtn.Text = "cut";
			this.cutBtn.Click += new System.EventHandler(this.cutBtn_Click);
			// 
			// SelectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.Red;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(128, 128);
			this.ContextMenuStrip = this.selectionMenu;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SelectionForm";
			this.Opacity = 0.5D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "SelectionForm";
			this.TransparencyKey = System.Drawing.Color.Red;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.selectionMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ToolStripMenuItem cropBtn;
		private QuickLibrary.QlibToolsep qlibToolsep5;
		private System.Windows.Forms.ToolStripMenuItem selectionCopyBtn;
		private System.Windows.Forms.ToolStripMenuItem selectionSelectAllBtn;
		private System.Windows.Forms.ToolStripMenuItem editSelectionBtn;
		private QuickLibrary.QlibContextMenuStrip selectionMenu;
		private System.Windows.Forms.ToolStripMenuItem cutBtn;
	}
}