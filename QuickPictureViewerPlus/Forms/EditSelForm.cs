using QuickLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuickPictureViewerPlus
{
	partial class EditSelForm : QlibFixedForm
	{
		public EditSelForm(Rectangle r)
		{
			InitializeComponent();
			SetSelection(r);
		}

		public void SetSelection(Rectangle r)
		{
			if (r.X < xNumeric.Minimum) r.X = (int)xNumeric.Minimum;
			if (r.X > xNumeric.Maximum) r.X = (int)xNumeric.Maximum;
			xNumeric.Value = r.X;

			if (r.Y < yNumeric.Minimum) r.Y = (int)yNumeric.Minimum;
			if (r.Y > yNumeric.Maximum) r.Y = (int)yNumeric.Maximum;
			yNumeric.Value = r.Y;

			if (r.Width < widthNumeric.Minimum) r.Width = (int)widthNumeric.Minimum;
			if (r.Width > widthNumeric.Maximum) r.Width = (int)widthNumeric.Maximum;
			widthNumeric.Value = r.Width;

			if (r.Height < heightNumeric.Minimum) r.Height = (int)heightNumeric.Minimum;
			if (r.Height > heightNumeric.Maximum) r.Height = (int)heightNumeric.Maximum;
			heightNumeric.Value = r.Height;
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
			if (Owner != null) (Owner as MainForm).SelectSelection(
				(int)xNumeric.Value,
				(int)yNumeric.Value,
				(int)widthNumeric.Value,
				(int)heightNumeric.Value
			);
		}
	}
}
