using QuickLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	partial class WallpaperForm : Form
	{
		Bitmap bmp;

		protected override CreateParams CreateParams
		{
			get
			{
				const int CS_DROPSHADOW = 0x20000;
				CreateParams cp = base.CreateParams;
				cp.ClassStyle |= CS_DROPSHADOW;
				return cp;
			}
		}

		public WallpaperForm(Bitmap bmp, bool darkMode)
		{
			if (darkMode)
			{
				this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			this.bmp = bmp;

			InitializeComponent();

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

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Cursor.Current = Cursors.SizeAll;
				NativeMethodsManager.ReleaseCapture();
				NativeMethodsManager.SendMessage(Handle, 0xA1, 0x2, 0);
			}
		}

		private void titleLabel_MouseDown(object sender, MouseEventArgs e)
		{
			panel1_MouseDown(sender, e);
		}

		private void logoPictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			panel1_MouseDown(sender, e);
		}
	}
}
