using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	partial class WallpaperForm : Form
	{
		Bitmap bmp;

		public WallpaperForm(Bitmap bmp)
		{
			InitializeComponent();
			this.bmp = bmp;

			if (ThemeManager.isDarkTheme())
			{
				this.BackColor = Color.FromArgb(32, 32, 32);
				this.ForeColor = Color.White;
				this.groupBox1.ForeColor = Color.White;
			}
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			if (stretchedRadio.Checked)
			{
				Wallpaper.Set(bmp, Wallpaper.Style.Stretch);
			}
			else if (tiledRadio.Checked)
			{
				Wallpaper.Set(bmp, Wallpaper.Style.Tile);
			}
			else if (centeredRadio.Checked)
			{
				Wallpaper.Set(bmp, Wallpaper.Style.Center);
			}
			else if (fillRadio.Checked)
			{
				Wallpaper.Set(bmp, Wallpaper.Style.Fill);
			}
			else if (fitRadio.Checked)
			{
				Wallpaper.Set(bmp, Wallpaper.Style.Fit);
			}
		}
	}
}
