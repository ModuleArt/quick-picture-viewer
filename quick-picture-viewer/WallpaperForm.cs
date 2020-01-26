using System;
using System.Drawing;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	partial class WallpaperForm : Form
	{
		Bitmap bmp;

		public WallpaperForm(Bitmap bmp, bool darkMode)
		{
			if (darkMode)
			{
				this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
				this.Shown += new EventHandler(ThemeManager.formHandleCreated);
			}

			this.bmp = bmp;

			InitializeComponent();
			

			if (darkMode)
			{
				this.BackColor = ThemeManager.BackColorDark;
				this.ForeColor = Color.White;

				groupBox1.ForeColor = Color.White;

				okButton.BackColor = ThemeManager.SecondColorDark;
				okButton.Image = Properties.Resources.white_desktop;
			}
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			if (stretchedRadio.Checked)
			{
				WallpaperManager.Set(bmp, WallpaperManager.Style.Stretch);
			}
			else if (tiledRadio.Checked)
			{
				WallpaperManager.Set(bmp, WallpaperManager.Style.Tile);
			}
			else if (centeredRadio.Checked)
			{
				WallpaperManager.Set(bmp, WallpaperManager.Style.Center);
			}
			else if (fillRadio.Checked)
			{
				WallpaperManager.Set(bmp, WallpaperManager.Style.Fill);
			}
			else if (fitRadio.Checked)
			{
				WallpaperManager.Set(bmp, WallpaperManager.Style.Fit);
			}
			else if (spanRadio.Checked)
			{
				WallpaperManager.Set(bmp, WallpaperManager.Style.Span);
			}
		}

		private void WallpaperForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}
	}
}
