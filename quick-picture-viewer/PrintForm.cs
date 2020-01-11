using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	partial class PrintForm : Form
	{
		public PrintForm(PrintDocument pd)
		{
			InitializeComponent();

			leftMarginTextBox.Text = pd.DefaultPageSettings.Margins.Left.ToString();
			topMarginTextBox.Text = pd.DefaultPageSettings.Margins.Top.ToString();
			rightMarginTextBox.Text = pd.DefaultPageSettings.Margins.Right.ToString();
			bottomMarginTextBox.Text = pd.DefaultPageSettings.Margins.Bottom.ToString();

			printPreviewControl1.Document = pd;

			if (ThemeManager.isDarkTheme())
			{
				ThemeManager.setDarkModeToControl(printPreviewControl1.Handle);

				this.BackColor = ThemeManager.BackColorDark;
				this.ForeColor = Color.White;

				printPreviewControl1.BackColor = ThemeManager.BackColorDark;

				groupBox1.ForeColor = Color.White;

				titleTextBox.BackColor = ThemeManager.SecondColorDark;
				titleTextBox.ForeColor = Color.White;

				leftMarginTextBox.BackColor = ThemeManager.SecondColorDark;
				leftMarginTextBox.ForeColor = Color.White;

				topMarginTextBox.BackColor = ThemeManager.SecondColorDark;
				topMarginTextBox.ForeColor = Color.White;

				rightMarginTextBox.BackColor = ThemeManager.SecondColorDark;
				rightMarginTextBox.ForeColor = Color.White;

				bottomMarginTextBox.BackColor = ThemeManager.SecondColorDark;
				bottomMarginTextBox.ForeColor = Color.White;

				setMarginsButton.BackColor = ThemeManager.SecondColorDark;

				okButton.BackColor = ThemeManager.SecondColorDark;
				okButton.Image = Properties.Resources.white_print;

				ThemeManager.enableDarkTitlebar(this.Handle, true);
			}
		}

		private void marginsCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			printPreviewControl1.Document.OriginAtMargins = marginsCheckBox.Checked;
			printPreviewControl1.InvalidatePreview();

			leftMarginTextBox.Enabled = marginsCheckBox.Checked;
			topMarginTextBox.Enabled = marginsCheckBox.Checked;
			rightMarginTextBox.Enabled = marginsCheckBox.Checked;
			bottomMarginTextBox.Enabled = marginsCheckBox.Checked;

			setMarginsButton.Enabled = marginsCheckBox.Checked;
		}

		private void horizontalCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			printPreviewControl1.Document.DefaultPageSettings.Landscape = horizontalCheckBox.Checked;
			printPreviewControl1.InvalidatePreview();
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			printPreviewControl1.Document.DocumentName = titleTextBox.Text;
			this.DialogResult = DialogResult.OK;
		}

		private void PrintForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		private void centerCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			(this.Owner as MainForm).printCenterImage = centerCheckbox.Checked;
			printPreviewControl1.InvalidatePreview();
		}

		private void setMarginsButton_Click(object sender, EventArgs e)
		{
			try
			{
				printPreviewControl1.Document.DefaultPageSettings.Margins.Left = Convert.ToInt32(leftMarginTextBox.Text);
				printPreviewControl1.Document.DefaultPageSettings.Margins.Top = Convert.ToInt32(topMarginTextBox.Text);
				printPreviewControl1.Document.DefaultPageSettings.Margins.Right = Convert.ToInt32(rightMarginTextBox.Text);
				printPreviewControl1.Document.DefaultPageSettings.Margins.Bottom = Convert.ToInt32(bottomMarginTextBox.Text);
				printPreviewControl1.InvalidatePreview();
			}
			catch
			{
				MessageBox.Show("Unable to parse document margins", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
