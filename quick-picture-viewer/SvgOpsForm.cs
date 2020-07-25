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

		public SvgOpsForm(string path, int imageWidth, int imageHeight, int panelWidth, int panelHeight, bool darkMode)
		{
			if (darkMode)
			{
				this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			this.path = path;
			this.aspectRatio = imageWidth / (float)imageHeight;
			this.panelWidth = panelWidth;
			this.panelHeight = panelHeight;

			InitializeComponent();

			SetDraggableControls(new List<Control>() { titlePanel, logoPictureBox, titleLabel });

			applyDarkMode(darkMode);

			widthNumeric.Value = imageWidth;
			heightNumeric.Value = imageHeight;
		}

		private void applyDarkMode(bool dark)
		{
			if (dark)
			{
				this.BackColor = ThemeManager.DarkBackColor;
				this.ForeColor = Color.White;

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

			widthNumeric.SetDarkMode(dark);
			heightNumeric.SetDarkMode(dark);
			aspectRatioCheckbox.SetDarkMode(dark);
			closeBtn.SetDarkMode(dark);
		}

		private void okButton_Click(object sender, System.EventArgs e)
		{
			MainForm mf = this.Owner as MainForm;

			int width = (int)widthNumeric.Value;
			int height = (int)heightNumeric.Value;

			mf.openSvg(path, width, height);

			this.Close();
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
				this.aspectRatio = (float)widthNumeric.Value / (float)heightNumeric.Value;
			}
		}

		private void SvgOpsForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
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
			this.Close();
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
	}
}
