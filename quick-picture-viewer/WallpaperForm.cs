using QuickLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	partial class WallpaperForm : QlibBorderlessForm
	{
		Bitmap bmp;

		public WallpaperForm(Bitmap bmp, bool darkMode)
		{
			if (darkMode)
			{
				this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			this.bmp = bmp;

			InitializeComponent();

			SetDraggableControls(new List<Control>() { titlePanel, logoPictureBox, titleLabel });

			applyDarkMode(darkMode);

			fitComboBox.SelectedIndex = 0;
		}

		private void applyDarkMode(bool dark)
		{
			if (dark)
			{
				this.BackColor = ThemeManager.DarkBackColor;
				this.ForeColor = Color.White;

				okButton.BackColor = ThemeManager.DarkSecondColor;
				okButton.Image = Properties.Resources.white_desktop;

				closeBtn.Image = Properties.Resources.white_close;
			}

			fitComboBox.SetDarkMode(dark);
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			if (fitComboBox.Text == "Stretch")
			{
				WallpaperManager.Set(bmp, WallpaperManager.Style.Stretch);
			}
			else if (fitComboBox.Text == "Tile")
			{
				WallpaperManager.Set(bmp, WallpaperManager.Style.Tile);
			}
			else if (fitComboBox.Text == "Center")
			{
				WallpaperManager.Set(bmp, WallpaperManager.Style.Center);
			}
			else if (fitComboBox.Text == "Fill")
			{
				WallpaperManager.Set(bmp, WallpaperManager.Style.Fill);
			}
			else if (fitComboBox.Text == "Fit")
			{
				WallpaperManager.Set(bmp, WallpaperManager.Style.Fit);
			}
			else if (fitComboBox.Text == "Span")
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

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
