using QuickLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace QuickPictureViewerPlus
{
	public partial class SvgOpsForm : QlibFixedForm
	{
		private string path;
		private double aspectRatio;
		private int panelWidth;
		private int panelHeight;

		public SvgOpsForm(string path, int imageWidth, int imageHeight, int panelWidth, int panelHeight)
		{
			this.path = path;
			aspectRatio = imageWidth / (double)imageHeight;
			this.panelWidth = panelWidth;
			this.panelHeight = panelHeight;

			InitializeComponent();
			SetDraggableControls(new List<Control>() { presetsLabel, widthLabel, heightLabel });

			widthNumeric.Value = imageWidth;
			heightNumeric.Value = imageHeight;
		}

		private void SetDarkMode(bool dark)
		{
			if (dark)
			{
				defaultSizeButton.BackColor = ThemeMan.DarkSecondColor;
				autoSizeBtn.BackColor = ThemeMan.DarkSecondColor;
				size16Button.BackColor = ThemeMan.DarkSecondColor;
				size32Button.BackColor = ThemeMan.DarkSecondColor;
				size64Button.BackColor = ThemeMan.DarkSecondColor;
				size128Button.BackColor = ThemeMan.DarkSecondColor;
				size256Button.BackColor = ThemeMan.DarkSecondColor;
				size512Button.BackColor = ThemeMan.DarkSecondColor;

				okButton.BackColor = ThemeMan.DarkSecondColor;
				okButton.Image = Properties.Resources.white_size;
			}

			DarkMode = dark;
			widthNumeric.DarkMode = dark;
			heightNumeric.DarkMode = dark;
			aspectRatioCheckbox.DarkMode = dark;
			closeBtn.DarkMode = dark;
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			MainForm mf = Owner as MainForm;
			FileTypeMan.OpenResult res = SvgWrapper.CustomSizeOpen(path, (int)widthNumeric.Value, (int)heightNumeric.Value);
			if (string.IsNullOrEmpty(res.ErrorMessage)) mf.openImage(res.Bmp, Path.GetDirectoryName(path), Path.GetFileName(path));
			else mf.showSuggestion(res.ErrorMessage, MainForm.SuggestionIcon.Warning);
			Close();
		}

		private void widthNumeric_ValueChanged(object sender, EventArgs e)
		{
			if (aspectRatioCheckbox.Checked) heightNumeric.Value = (decimal)((float)widthNumeric.Value / aspectRatio);
		}

		private void heightNumeric_ValueChanged(object sender, EventArgs e)
		{
			if (aspectRatioCheckbox.Checked) widthNumeric.Value = (decimal)((float)heightNumeric.Value * aspectRatio);
		}

		private void size256Button_Click(object sender, EventArgs e)
		{
			setPreset(256);
		}

		private void size512Button_Click(object sender, EventArgs e)
		{
			setPreset(512);
		}

		private void setPreset(int size)
		{
			widthNumeric.Value = size;
			if (!aspectRatioCheckbox.Checked) heightNumeric.Value = size;
		}

		private void aspectRatioCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (aspectRatioCheckbox.Checked) aspectRatio = (double)widthNumeric.Value / (double)heightNumeric.Value;
		}

		private void defaultSizeButton_Click(object sender, EventArgs e)
		{
			Svg.SvgDocument svgDocument = Svg.SvgDocument.Open(path);

			int width = Convert.ToInt32(svgDocument.Width.Value);
			int height = Convert.ToInt32(svgDocument.Height.Value);

			bool aspectChecked = aspectRatioCheckbox.Checked;
			aspectRatioCheckbox.Checked = false;

			widthNumeric.Value = width;
			heightNumeric.Value = height;

			aspectRatioCheckbox.Checked = aspectChecked;
		}

		private void size64Button_Click(object sender, EventArgs e)
		{
			setPreset(64);
		}

		private void size128Button_Click(object sender, EventArgs e)
		{
			setPreset(128);
		}

		private void size32Button_Click(object sender, EventArgs e)
		{
			setPreset(32);
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void size16Button_Click(object sender, EventArgs e)
		{
			setPreset(16);
		}

		private void autoSizeBtn_Click(object sender, EventArgs e)
		{
			double f;
			f = panelWidth < panelHeight ? panelWidth : panelHeight;
			int k = (int)(8 * (Math.Round(f / 8.0)));
			setPreset(k);
		}

		private void SvgOpsForm_Load(object sender, EventArgs e)
		{
			SetDarkMode(DarkMode);
			InitLanguage();
		}

		private void InitLanguage()
		{
			Text = "SVG " + LangMan.Get("type-options");
			presetsLabel.Text = LangMan.Get("presets") + ":";
			widthLabel.Text = LangMan.Get("width") + ":";
			heightLabel.Text = LangMan.Get("height") + ":";
			defaultSizeButton.Text = LangMan.Get("original-size");
			autoSizeBtn.Text = LangMan.Get("auto-size");
			okButton.Text = " " + LangMan.Get("resize-svg");
			aspectRatioCheckbox.Text = LangMan.Get("maintain-aspect-ratio");
			infoTooltip.SetToolTip(closeBtn, NativeMan.GetMessageBoxText(NativeMan.DialogBoxCommandID.IDCLOSE) + " | Alt+F4");
		}
	}
}
