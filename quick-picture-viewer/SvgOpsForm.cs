using System;
using System.Drawing;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	public partial class SvgOpsForm : Form
	{
		string path;
		float aspectRatio;

		public SvgOpsForm(string path, int width, int height, bool darkMode)
		{
			if (darkMode)
			{
				this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}
			this.path = path;
			this.aspectRatio = width / (float)height;

			InitializeComponent();

			widthNumeric.Value = width;
			heightNumeric.Value = height;

			if (darkMode)
			{
				this.BackColor = ThemeManager.BackColorDark;
				this.ForeColor = Color.White;

				groupBox1.Paint += ThemeManager.PaintDarkGroupBox;

				okButton.BackColor = ThemeManager.SecondColorDark;
				size256Button.BackColor = ThemeManager.SecondColorDark;
				size512Button.BackColor = ThemeManager.SecondColorDark;
				size1024Button.BackColor = ThemeManager.SecondColorDark;
			}
		}

		private void okButton_Click(object sender, System.EventArgs e)
		{
			MainForm mf = this.Owner as MainForm;

			int width = (int)widthNumeric.Value;
			int height = (int)heightNumeric.Value;

			mf.openSvg(path, width, height);

			Properties.Settings.Default.SvgSize = width;
			Properties.Settings.Default.Save();

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

		private void size1024Button_Click(object sender, EventArgs e)
		{
			setPreset(1024);
		}

		private void setPreset(int size)
		{
			bool aspectChecked = aspectRatioCheckbox.Checked;

			aspectRatioCheckbox.Checked = false;
			widthNumeric.Value = size;
			heightNumeric.Value = size;

			aspectRatioCheckbox.Checked = aspectChecked;
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
	}
}
