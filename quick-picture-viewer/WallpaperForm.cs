using QuickLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	partial class WallpaperForm : QlibFixedForm
	{
		private Bitmap bmp;
		private MainForm owner;

		public WallpaperForm(Bitmap bmp, bool darkMode)
		{
			if (darkMode)
			{
				this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			this.bmp = bmp;

			InitializeComponent();
			SetDraggableControls(new List<Control>() { titlePanel, logoPictureBox, titleLabel, fitLabel });
			SetDarkMode(darkMode);
		}

		private void SetDarkMode(bool dark)
		{
			if (dark)
			{
				this.BackColor = ThemeManager.DarkBackColor;
				this.ForeColor = Color.White;

				okButton.BackColor = ThemeManager.DarkSecondColor;
				okButton.Image = Properties.Resources.white_desktop;
			}

			fitComboBox.SetDarkMode(dark);
			closeBtn.SetDarkMode(dark);
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			switch (fitComboBox.SelectedIndex)
			{
				case 2:
					WallpaperManager.Set(bmp, WallpaperManager.Style.Stretch);
					break;
				case 3:
					WallpaperManager.Set(bmp, WallpaperManager.Style.Tile);
					break;
				case 4:
					WallpaperManager.Set(bmp, WallpaperManager.Style.Center);
					break;
				case 0:
					WallpaperManager.Set(bmp, WallpaperManager.Style.Fill);
					break;
				case 1:
					WallpaperManager.Set(bmp, WallpaperManager.Style.Fit);
					break;
				case 5:
					WallpaperManager.Set(bmp, WallpaperManager.Style.Span);
					break;
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

		private void WallpaperForm_Load(object sender, EventArgs e)
		{
			owner = this.Owner as MainForm;
			InitLanguage();
			fitComboBox.SelectedIndex = 0;
		}

		private void InitLanguage()
		{
			this.Text = owner.resMan.GetString("set-as-desktop-background");
			fitLabel.Text = owner.resMan.GetString("choose-fit") + ":";
			okButton.Text = " " + owner.resMan.GetString("set-background");
			fitComboBox.Items.Add(owner.resMan.GetString("fill"));
			fitComboBox.Items.Add(owner.resMan.GetString("fit"));
			fitComboBox.Items.Add(owner.resMan.GetString("stretch"));
			fitComboBox.Items.Add(owner.resMan.GetString("tile"));
			fitComboBox.Items.Add(owner.resMan.GetString("center"));
			fitComboBox.Items.Add(owner.resMan.GetString("span"));
			infoTooltip.SetToolTip(closeBtn, owner.resMan.GetString("close") + " | Alt+F4");
		}
	}
}
