using QuickLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuickPictureViewerPlus
{
	partial class WallpaperForm : QlibFixedForm
	{
		private Bitmap bmp;

		public WallpaperForm(Bitmap bmp)
		{
			this.bmp = bmp;

			InitializeComponent();
			SetDraggableControls(new List<Control>() { fitLabel });
		}

		private void SetDarkMode(bool dark)
		{
			if (dark)
			{
				okButton.BackColor = ThemeMan.DarkSecondColor;
				okButton.Image = Properties.Resources.white_desktop;
			}
			DarkMode = dark;
			fitComboBox.DarkMode = dark;
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

		private void closeBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void WallpaperForm_Load(object sender, EventArgs e)
		{
			SetDarkMode(DarkMode);
			InitLanguage();
			fitComboBox.SelectedIndex = 0;
		}

		private void InitLanguage()
		{
			Text = LangMan.Get("set-as-desktop-background");
			fitLabel.Text = LangMan.Get("choose-fit") + ":";
			okButton.Text = " " + LangMan.Get("set-background");
			fitComboBox.Items.Add(LangMan.Get("fill"));
			fitComboBox.Items.Add(LangMan.Get("fit"));
			fitComboBox.Items.Add(LangMan.Get("stretch"));
			fitComboBox.Items.Add(LangMan.Get("tile"));
			fitComboBox.Items.Add(LangMan.Get("center"));
			fitComboBox.Items.Add(LangMan.Get("span"));
			infoTooltip.SetToolTip(closeBtn, NativeMan.GetMessageBoxText(NativeMan.DialogBoxCommandID.IDCLOSE) + " | Alt+F4");
		}
	}
}
