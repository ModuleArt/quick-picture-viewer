using QuickLibrary;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	partial class PrintForm : QlibFixedForm
	{
		private bool darkMode;
		private MainForm owner;

		public PrintForm(PrintDocument pd, bool darkMode, string docTitle)
		{
			if (darkMode)
			{
				HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			this.darkMode = darkMode;

			InitializeComponent();
			SetDraggableControls(new List<Control>() { 
				titlePanel, titleLabel, 
				printPreviewControl1, 
				documentLabel, marginsLabel, leftLabel, rightLabel, topLabel, bottomLabel
			});
			SetDarkMode(darkMode);

			leftMarginTextBox.Value = pd.DefaultPageSettings.Margins.Left;
			topMarginTextBox.Value = pd.DefaultPageSettings.Margins.Top;
			rightMarginTextBox.Value = pd.DefaultPageSettings.Margins.Right;
			bottomMarginTextBox.Value = pd.DefaultPageSettings.Margins.Bottom;

			printPreviewControl1.Document = pd;

			titleTextBox.Text = docTitle;
		}

		private void SetDarkMode(bool dark)
		{
			if (dark)
			{
				ThemeManager.setDarkModeToControl(printPreviewControl1.Handle);

				okButton.BackColor = ThemeManager.DarkSecondColor;
				okButton.Image = Properties.Resources.white_print;

				printPreviewControl1.BackColor = ThemeManager.DarkBackColor;

				okButton.BackColor = ThemeManager.DarkSecondColor;
				okButton.Image = Properties.Resources.white_print;

				setMarginsButton.BackColor = ThemeManager.DarkSecondColor;
			}

			DarkMode = dark;
			marginsCheckBox.DarkMode = dark;
			horizontalCheckBox.DarkMode = dark;
			centerCheckbox.DarkMode = dark;
			closeBtn.DarkMode = dark;
			rightMarginTextBox.DarkMode = dark;
			leftMarginTextBox.DarkMode = dark;
			topMarginTextBox.DarkMode = dark;
			bottomMarginTextBox.DarkMode = dark;
			titleTextBox.DarkMode = dark;
		}

		private void marginsCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			printPreviewControl1.Document.OriginAtMargins = marginsCheckBox.Checked;
			printPreviewControl1.InvalidatePreview();

			leftMarginTextBox.Enabled = marginsCheckBox.Checked;
			topMarginTextBox.Enabled = marginsCheckBox.Checked;
			rightMarginTextBox.Enabled = marginsCheckBox.Checked;
			bottomMarginTextBox.Enabled = marginsCheckBox.Checked;

			setMarginsButton.Visible = marginsCheckBox.Checked;
		}

		private void horizontalCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			printPreviewControl1.Document.DefaultPageSettings.Landscape = horizontalCheckBox.Checked;
			printPreviewControl1.InvalidatePreview();
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			printPreviewControl1.Document.DocumentName = titleTextBox.Text;
			printPreviewControl1.Document.PrinterSettings.PrintFileName = titleTextBox.Text;
			DialogResult = DialogResult.OK;
		}

		private void PrintForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}

		private void centerCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			owner.printCenterImage = centerCheckbox.Checked;
			printPreviewControl1.InvalidatePreview();
		}

		private void setMarginsButton_Click(object sender, EventArgs e)
		{
			try
			{
				printPreviewControl1.Document.DefaultPageSettings.Margins.Left = Convert.ToInt32(leftMarginTextBox.Value);
				printPreviewControl1.Document.DefaultPageSettings.Margins.Top = Convert.ToInt32(topMarginTextBox.Value);
				printPreviewControl1.Document.DefaultPageSettings.Margins.Right = Convert.ToInt32(rightMarginTextBox.Value);
				printPreviewControl1.Document.DefaultPageSettings.Margins.Bottom = Convert.ToInt32(bottomMarginTextBox.Value);
				printPreviewControl1.InvalidatePreview();
			}
			catch
			{
				DialogMan.ShowInfo(
					LangMan.GetString("plugin-not-found"),
					LangMan.GetString("print-margins-error"),
					darkMode
				);
			}
		}

		private void setMarginsButton_EnabledChanged(object sender, EventArgs e)
		{
			if (darkMode)
			{
				Button btn = (Button)sender;

				if (btn.Enabled)
				{
					btn.BackColor = ThemeManager.DarkSecondColor;
				}
				else
				{
					btn.BackColor = ThemeManager.DarkSecondColor;
				}
			}
		}

		private void PrintForm_Load(object sender, EventArgs e)
		{
			owner = Owner as MainForm;

			centerCheckbox.Checked = owner.printCenterImage;
			marginsCheckBox.Checked = printPreviewControl1.Document.OriginAtMargins;
			horizontalCheckBox.Checked = printPreviewControl1.Document.DefaultPageSettings.Landscape;

			InitLanguage();
		}

		private void InitLanguage()
		{
			Text = LangMan.GetString("print-conf");
			setMarginsButton.Text = LangMan.GetString("set-margins-btn");
			okButton.Text = LangMan.GetString("print");
			leftLabel.Text = LangMan.GetString("left") + ":";
			rightLabel.Text = LangMan.GetString("right") + ":";
			topLabel.Text = LangMan.GetString("top") + ":";
			bottomLabel.Text = LangMan.GetString("bottom") + ":";
			documentLabel.Text = LangMan.GetString("title") + ":";
			centerCheckbox.Text = LangMan.GetString("center-image");
			horizontalCheckBox.Text = LangMan.GetString("landscape-orientation");
			marginsLabel.Text = LangMan.GetString("margins") + ":";
			marginsCheckBox.Text = LangMan.GetString("margin-bounds");
			infoTooltip.SetToolTip(closeBtn, NativeMan.GetMessageBoxText(NativeMan.DialogBoxCommandID.IDCLOSE) + " | Alt+F4");
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
