using QuickLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	public partial class SvgOpsForm : QlibFixedForm
	{
		private string path;
		private float aspectRatio;
		private int panelWidth;
		private int panelHeight;
		private MainForm owner;

		public SvgOpsForm(string path, int imageWidth, int imageHeight, int panelWidth, int panelHeight, bool darkMode)
		{
			if (darkMode)
			{
				HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			this.path = path;
			aspectRatio = imageWidth / (float)imageHeight;
			this.panelWidth = panelWidth;
			this.panelHeight = panelHeight;

			InitializeComponent();
			SetDraggableControls(new List<Control>() { titlePanel, logoPictureBox, titleLabel, presetsLabel, widthLabel, heightLabel });
			SetDarkMode(darkMode);

			widthNumeric.Value = imageWidth;
			heightNumeric.Value = imageHeight;
		}

		private void SetDarkMode(bool dark)
		{
			if (dark)
			{
				defaultSizeButton.BackColor = ThemeManager.DarkSecondColor;
				autoSizeBtn.BackColor = ThemeManager.DarkSecondColor;
				size16Button.BackColor = ThemeManager.DarkSecondColor;
				size32Button.BackColor = ThemeManager.DarkSecondColor;
				size64Button.BackColor = ThemeManager.DarkSecondColor;
				size128Button.BackColor = ThemeManager.DarkSecondColor;
				size256Button.BackColor = ThemeManager.DarkSecondColor;
				size512Button.BackColor = ThemeManager.DarkSecondColor;

				okButton.BackColor = ThemeManager.DarkSecondColor;
				okButton.Image = Properties.Resources.white_size;
			}

			DarkMode = dark;
			widthNumeric.DarkMode = dark;
			heightNumeric.DarkMode = dark;
			aspectRatioCheckbox.DarkMode = dark;
			closeBtn.SetDarkMode(dark);
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			MainForm mf = Owner as MainForm;

			int width = (int)widthNumeric.Value;
			int height = (int)heightNumeric.Value;

			mf.openSvg(path, width, height);

			Close();
		}

		private void widthNumeric_ValueChanged(object sender, EventArgs e)
		{
			if (aspectRatioCheckbox.Checked)
			{
				heightNumeric.Value = (decimal)((float)widthNumeric.Value / aspectRatio);
			}
		}

		private void heightNumeric_ValueChanged(object sender, EventArgs e)
		{
			if (aspectRatioCheckbox.Checked)
			{
				widthNumeric.Value = (decimal)((float)heightNumeric.Value * aspectRatio);
			}
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

			if (!aspectRatioCheckbox.Checked)
			{
				heightNumeric.Value = size;
			}
		}

		private void aspectRatioCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (aspectRatioCheckbox.Checked)
			{
				aspectRatio = (float)widthNumeric.Value / (float)heightNumeric.Value;
			}
		}

		private void SvgOpsForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}

		private void defaultSizeButton_Click(object sender, EventArgs e)
		{
			Svg.SvgDocument svgDocument = Svg.SvgDocument.Open(path);

			int width = Convert.ToInt32(svgDocument.Width.Value);
			int height = Convert.ToInt32(svgDocument.Height.Value);

			bool aspectChecked = aspectRatioCheckbox.Checked;

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
			if (panelWidth < panelHeight)
			{
				f = panelWidth;
			}
			else
			{
				f = panelHeight;
			}
			Console.WriteLine(f);

			int k = (int)(8 * (Math.Round(f / 8.0)));
			Console.WriteLine(k);

			setPreset(k);
		}

		private void SvgOpsForm_Load(object sender, EventArgs e)
		{
			owner = Owner as MainForm;
			InitLanguage();
		}

		private void InitLanguage()
		{
			Text = "SVG " + owner.resMan.GetString("type-options");
			presetsLabel.Text = owner.resMan.GetString("presets") + ":";
			widthLabel.Text = owner.resMan.GetString("width") + ":";
			heightLabel.Text = owner.resMan.GetString("height") + ":";
			defaultSizeButton.Text = owner.resMan.GetString("original-size");
			autoSizeBtn.Text = owner.resMan.GetString("auto-size");
			okButton.Text = " " + owner.resMan.GetString("resize-svg");
			aspectRatioCheckbox.Text = owner.resMan.GetString("maintain-aspect-ratio");
			infoTooltip.SetToolTip(closeBtn, NativeMan.GetMessageBoxText(NativeMan.DialogBoxCommandID.IDCLOSE) + " | Alt+F4");
		}
	}
}
