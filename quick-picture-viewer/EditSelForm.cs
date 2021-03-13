using QuickLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	partial class EditSelForm : QlibFixedForm
	{
		public EditSelForm(Rectangle r)
		{
			InitializeComponent();
			SetSelection(r.X, r.Y, r.Width, r.Height);
		}

		public void SetSelection(int x, int y, int w, int h)
		{
			if (x < xNumeric.Minimum) x = (int)xNumeric.Minimum;
			if (x > xNumeric.Maximum) x = (int)xNumeric.Maximum;
			xNumeric.Value = x;

			if (y < yNumeric.Minimum) y = (int)yNumeric.Minimum;
			if (y > yNumeric.Maximum) y = (int)yNumeric.Maximum;
			yNumeric.Value = y;

			if (w < widthNumeric.Minimum) w = (int)widthNumeric.Minimum;
			if (w > widthNumeric.Maximum) w = (int)widthNumeric.Maximum;
			widthNumeric.Value = w;

			if (h < heightNumeric.Minimum) h = (int)heightNumeric.Minimum;
			if (h > heightNumeric.Maximum) h = (int)heightNumeric.Maximum;
			heightNumeric.Value = h;
		}

		private void SetDarkMode(bool dark)
		{
			if (dark)
			{
				okButton.BackColor = ThemeMan.DarkSecondColor;
			}
			DarkMode = dark;
			xNumeric.DarkMode = dark;
			yNumeric.DarkMode = dark;
			widthNumeric.DarkMode = dark;
			heightNumeric.DarkMode = dark;
			closeBtn.DarkMode = dark;
		}

		private void WallpaperForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape) Close();
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void WallpaperForm_Load(object sender, EventArgs e)
		{
			SetDarkMode(DarkMode);
			InitLanguage();
		}

		private void InitLanguage()
		{
			Text = LangMan.Get("edit-selection");
			widthLabel.Text = LangMan.Get("width") + ":";
			heightLabel.Text = LangMan.Get("height") + ":";
			okButton.Text = NativeMan.GetMessageBoxText(NativeMan.DialogBoxCommandID.IDOK);
			infoTooltip.SetToolTip(closeBtn, NativeMan.GetMessageBoxText(NativeMan.DialogBoxCommandID.IDCLOSE) + " | Alt+F4");
		}

		private void xNumeric_ValueChanged(object sender, EventArgs e)
		{
			if (Owner != null)
			{
				Rectangle r = (Owner as MainForm).SelectSelection(
					(int)xNumeric.Value,
					(int)yNumeric.Value,
					(int)widthNumeric.Value,
					(int)heightNumeric.Value
				);

				if (xNumeric.Value != r.X) xNumeric.Value = r.X;
				if (yNumeric.Value != r.Y) yNumeric.Value = r.Y;
				if (widthNumeric.Value != r.Width) widthNumeric.Value = r.Width;
				if (heightNumeric.Value != r.Height) heightNumeric.Value = r.Height;
			}
		}
	}
}
