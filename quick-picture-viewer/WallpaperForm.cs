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

		public WallpaperForm(Bitmap bmp, bool darkMode)
		{
			if (darkMode)
			{
				HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
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
				okButton.BackColor = ThemeManager.DarkSecondColor;
				okButton.Image = Properties.Resources.white_desktop;
			}

			DarkMode = dark;
			fitComboBox.SetDarkMode(dark);
			closeBtn.DarkMode = dark;
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			switch (fitComboBox.SelectedIndex)
			{
				case 2:
					WallpaperMan.Set(bmp, WallpaperMan.Style.Stretch);
					break;
				case 3:
					WallpaperMan.Set(bmp, WallpaperMan.Style.Tile);
					break;
				case 4:
					WallpaperMan.Set(bmp, WallpaperMan.Style.Center);
					break;
				case 0:
					WallpaperMan.Set(bmp, WallpaperMan.Style.Fill);
					break;
				case 1:
					WallpaperMan.Set(bmp, WallpaperMan.Style.Fit);
					break;
				case 5:
					WallpaperMan.Set(bmp, WallpaperMan.Style.Span);
					break;
			}
		}

		private void WallpaperForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void WallpaperForm_Load(object sender, EventArgs e)
		{
			InitLanguage();
			fitComboBox.SelectedIndex = 0;
		}

		private void InitLanguage()
		{
			Text = LangMan.GetString("set-as-desktop-background");
			fitLabel.Text = LangMan.GetString("choose-fit") + ":";
			okButton.Text = " " + LangMan.GetString("set-background");
			fitComboBox.Items.Add(LangMan.GetString("fill"));
			fitComboBox.Items.Add(LangMan.GetString("fit"));
			fitComboBox.Items.Add(LangMan.GetString("stretch"));
			fitComboBox.Items.Add(LangMan.GetString("tile"));
			fitComboBox.Items.Add(LangMan.GetString("center"));
			fitComboBox.Items.Add(LangMan.GetString("span"));
			infoTooltip.SetToolTip(closeBtn, NativeMan.GetMessageBoxText(NativeMan.DialogBoxCommandID.IDCLOSE) + " | Alt+F4");
		}
	}
}
