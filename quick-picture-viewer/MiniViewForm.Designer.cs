namespace quick_picture_viewer
{
	partial class MiniViewForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniViewForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.suggestionLabel = new System.Windows.Forms.Label();
			this.gripButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(400, 400);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
			this.pictureBox1.MouseEnter += new System.EventHandler(this.MiniViewForm_MouseEnter);
			this.pictureBox1.MouseLeave += new System.EventHandler(this.MiniViewForm_MouseLeave);
			this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
			// 
			// suggestionLabel
			// 
			this.suggestionLabel.AutoSize = true;
			this.suggestionLabel.BackColor = System.Drawing.Color.Black;
			this.suggestionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.suggestionLabel.ForeColor = System.Drawing.Color.White;
			this.suggestionLabel.Location = new System.Drawing.Point(9, 9);
			this.suggestionLabel.Margin = new System.Windows.Forms.Padding(9);
			this.suggestionLabel.Name = "suggestionLabel";
			this.suggestionLabel.Padding = new System.Windows.Forms.Padding(3);
			this.suggestionLabel.Size = new System.Drawing.Size(127, 21);
			this.suggestionLabel.TabIndex = 2;
			this.suggestionLabel.Text = "Right click to go back";
			this.suggestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.suggestionLabel.Visible = false;
			// 
			// gripButton
			// 
			this.gripButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.gripButton.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.gripButton.FlatAppearance.BorderSize = 0;
			this.gripButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gripButton.Image = ((System.Drawing.Image)(resources.GetObject("gripButton.Image")));
			this.gripButton.Location = new System.Drawing.Point(370, 370);
			this.gripButton.Margin = new System.Windows.Forms.Padding(9);
			this.gripButton.Name = "gripButton";
			this.gripButton.Size = new System.Drawing.Size(21, 21);
			this.gripButton.TabIndex = 3;
			this.gripButton.TabStop = false;
			this.gripButton.UseVisualStyleBackColor = true;
			this.gripButton.Visible = false;
			// 
			// MiniViewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(400, 400);
			this.Controls.Add(this.gripButton);
			this.Controls.Add(this.suggestionLabel);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(200, 200);
			this.Name = "MiniViewForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Quick Picture Viewer";
			this.TopMost = true;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MiniViewForm_FormClosed);
			this.Load += new System.EventHandler(this.MiniViewForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MiniViewForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label suggestionLabel;
		private System.Windows.Forms.Button gripButton;
	}
}