namespace QuickPictureViewerPlus
{
	partial class EditSelForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSelForm));
			this.okButton = new System.Windows.Forms.Button();
			this.closeBtn = new QuickLibrary.QlibTitlebarButton();
			this.infoTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.heightNumeric = new QuickLibrary.QlibNumeric();
			this.widthLabel = new System.Windows.Forms.Label();
			this.heightLabel = new System.Windows.Forms.Label();
			this.widthNumeric = new QuickLibrary.QlibNumeric();
			this.yNumeric = new QuickLibrary.QlibNumeric();
			this.xLabel = new System.Windows.Forms.Label();
			this.yLabel = new System.Windows.Forms.Label();
			this.xNumeric = new QuickLibrary.QlibNumeric();
			this.SuspendLayout();
			// 
			// okButton
			// 
			this.okButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.FlatAppearance.BorderSize = 0;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okButton.Location = new System.Drawing.Point(10, 177);
			this.okButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(276, 32);
			this.okButton.TabIndex = 4;
			this.okButton.Text = "ok";
			this.okButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.okButton.UseVisualStyleBackColor = false;
			this.okButton.Click += new System.EventHandler(this.closeBtn_Click);
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
			this.closeBtn.Location = new System.Drawing.Point(264, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 5;
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// heightNumeric
			// 
			this.heightNumeric.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.heightNumeric.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.heightNumeric.BackColor = System.Drawing.SystemColors.ControlLight;
			this.heightNumeric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.heightNumeric.CausesValidation = false;
			this.heightNumeric.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.heightNumeric.DarkMode = false;
			this.heightNumeric.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.heightNumeric.ForeColor = System.Drawing.Color.Black;
			this.heightNumeric.Location = new System.Drawing.Point(153, 135);
			this.heightNumeric.Margin = new System.Windows.Forms.Padding(0);
			this.heightNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.heightNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.heightNumeric.Name = "heightNumeric";
			this.heightNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.heightNumeric.Size = new System.Drawing.Size(133, 32);
			this.heightNumeric.TabIndex = 3;
			this.heightNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.heightNumeric.ValueChanged += new System.EventHandler(this.xNumeric_ValueChanged);
			// 
			// widthLabel
			// 
			this.widthLabel.AutoSize = true;
			this.widthLabel.Location = new System.Drawing.Point(10, 106);
			this.widthLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.widthLabel.Name = "widthLabel";
			this.widthLabel.Size = new System.Drawing.Size(46, 19);
			this.widthLabel.TabIndex = 17;
			this.widthLabel.Text = "width:";
			// 
			// heightLabel
			// 
			this.heightLabel.AutoSize = true;
			this.heightLabel.Location = new System.Drawing.Point(145, 106);
			this.heightLabel.Margin = new System.Windows.Forms.Padding(0);
			this.heightLabel.Name = "heightLabel";
			this.heightLabel.Size = new System.Drawing.Size(51, 19);
			this.heightLabel.TabIndex = 18;
			this.heightLabel.Text = "height:";
			// 
			// widthNumeric
			// 
			this.widthNumeric.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.widthNumeric.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.widthNumeric.BackColor = System.Drawing.SystemColors.ControlLight;
			this.widthNumeric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.widthNumeric.CausesValidation = false;
			this.widthNumeric.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.widthNumeric.DarkMode = false;
			this.widthNumeric.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.widthNumeric.ForeColor = System.Drawing.Color.Black;
			this.widthNumeric.Location = new System.Drawing.Point(10, 135);
			this.widthNumeric.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.widthNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.widthNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.widthNumeric.Name = "widthNumeric";
			this.widthNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.widthNumeric.Size = new System.Drawing.Size(133, 32);
			this.widthNumeric.TabIndex = 2;
			this.widthNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.widthNumeric.ValueChanged += new System.EventHandler(this.xNumeric_ValueChanged);
			// 
			// yNumeric
			// 
			this.yNumeric.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.yNumeric.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.yNumeric.BackColor = System.Drawing.SystemColors.ControlLight;
			this.yNumeric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.yNumeric.CausesValidation = false;
			this.yNumeric.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.yNumeric.DarkMode = false;
			this.yNumeric.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.yNumeric.ForeColor = System.Drawing.Color.Black;
			this.yNumeric.Location = new System.Drawing.Point(153, 64);
			this.yNumeric.Margin = new System.Windows.Forms.Padding(0);
			this.yNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.yNumeric.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.yNumeric.Name = "yNumeric";
			this.yNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.yNumeric.Size = new System.Drawing.Size(133, 32);
			this.yNumeric.TabIndex = 1;
			this.yNumeric.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.yNumeric.ValueChanged += new System.EventHandler(this.xNumeric_ValueChanged);
			// 
			// xLabel
			// 
			this.xLabel.AutoSize = true;
			this.xLabel.Location = new System.Drawing.Point(10, 35);
			this.xLabel.Margin = new System.Windows.Forms.Padding(0);
			this.xLabel.Name = "xLabel";
			this.xLabel.Size = new System.Drawing.Size(20, 19);
			this.xLabel.TabIndex = 21;
			this.xLabel.Text = "X:";
			// 
			// yLabel
			// 
			this.yLabel.AutoSize = true;
			this.yLabel.Location = new System.Drawing.Point(149, 35);
			this.yLabel.Margin = new System.Windows.Forms.Padding(0);
			this.yLabel.Name = "yLabel";
			this.yLabel.Size = new System.Drawing.Size(20, 19);
			this.yLabel.TabIndex = 22;
			this.yLabel.Text = "Y:";
			// 
			// xNumeric
			// 
			this.xNumeric.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.xNumeric.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.xNumeric.BackColor = System.Drawing.SystemColors.ControlLight;
			this.xNumeric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.xNumeric.CausesValidation = false;
			this.xNumeric.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.xNumeric.DarkMode = false;
			this.xNumeric.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.xNumeric.ForeColor = System.Drawing.Color.Black;
			this.xNumeric.Location = new System.Drawing.Point(10, 64);
			this.xNumeric.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.xNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.xNumeric.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.xNumeric.Name = "xNumeric";
			this.xNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.xNumeric.Size = new System.Drawing.Size(133, 32);
			this.xNumeric.TabIndex = 0;
			this.xNumeric.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.xNumeric.ValueChanged += new System.EventHandler(this.xNumeric_ValueChanged);
			// 
			// EditSelForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.ClientSize = new System.Drawing.Size(296, 220);
			this.Controls.Add(this.yNumeric);
			this.Controls.Add(this.xLabel);
			this.Controls.Add(this.yLabel);
			this.Controls.Add(this.xNumeric);
			this.Controls.Add(this.heightNumeric);
			this.Controls.Add(this.widthLabel);
			this.Controls.Add(this.heightLabel);
			this.Controls.Add(this.widthNumeric);
			this.Controls.Add(this.closeBtn);
			this.Controls.Add(this.okButton);
			this.Draggable = true;
			this.EscToClose = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditSelForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.ShowTitle = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "EditSelForm";
			this.Load += new System.EventHandler(this.WallpaperForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.ToolTip infoTooltip;
		private QuickLibrary.QlibTitlebarButton closeBtn;
		private QuickLibrary.QlibNumeric heightNumeric;
		private System.Windows.Forms.Label widthLabel;
		private System.Windows.Forms.Label heightLabel;
		private QuickLibrary.QlibNumeric widthNumeric;
		private QuickLibrary.QlibNumeric yNumeric;
		private System.Windows.Forms.Label xLabel;
		private System.Windows.Forms.Label yLabel;
		private QuickLibrary.QlibNumeric xNumeric;
	}
}
