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

			if (ThemeManager.isDarkTheme())
			{
				this.BackColor = ThemeManager.BackColorDark;
				this.ForeColor = Color.White;
				groupBox1.ForeColor = Color.White;
			}

			printPreviewControl1.Document = pd;
		}

		private void marginsCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			printPreviewControl1.Document.OriginAtMargins = marginsCheckBox.Checked;
			printPreviewControl1.InvalidatePreview();
		}

		private void horizontalCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			printPreviewControl1.Document.DefaultPageSettings.Landscape = horizontalCheckBox.Checked;
			printPreviewControl1.InvalidatePreview();
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}
	}
}
