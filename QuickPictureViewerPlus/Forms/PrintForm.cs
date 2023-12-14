using QuickLibrary;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace QuickPictureViewerPlus
{
	partial class PrintForm : QlibFixedForm
	{
		private MainForm owner;

		public PrintForm(PrintDocument pd, string docTitle)
		{
			InitializeComponent();
			SetDraggableControls(new List<Control>() { 
				printPreviewControl1, 
				documentLabel, marginsLabel, leftLabel, rightLabel, topLabel, bottomLabel
			});

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
				ThemeMan.setDarkModeToControl(printPreviewControl1.Handle);

				okButton.BackColor = ThemeMan.DarkSecondColor;
				okButton.Image = Properties.Resources.white_print;

				printPreviewControl1.BackColor = ThemeMan.DarkBackColor;

				okButton.BackColor = ThemeMan.DarkSecondColor;
				okButton.Image = Properties.Resources.white_print;

				setMarginsButton.BackColor = ThemeMan.DarkSecondColor;
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
					this,
					LangMan.Get("plugin-not-found"),
					LangMan.Get("print-margins-error"),
					DarkMode,
					TopMost
				);
			}
		}

		private void setMarginsButton_EnabledChanged(object sender, EventArgs e)
		{
			if (DarkMode)
			{
				Button btn = (Button)sender;

				if (btn.Enabled) btn.BackColor = ThemeMan.DarkSecondColor;
				else btn.BackColor = ThemeMan.DarkSecondColor;
			}
		}

		private void PrintForm_Load(object sender, EventArgs e)
		{
			owner = Owner as MainForm;

			centerCheckbox.Checked = owner.printCenterImage;
			marginsCheckBox.Checked = printPreviewControl1.Document.OriginAtMargins;
			horizontalCheckBox.Checked = printPreviewControl1.Document.DefaultPageSettings.Landscape;

			SetDarkMode(DarkMode);
			InitLanguage();
		}

		private void InitLanguage()
		{
			Text = LangMan.Get("print-conf");
			setMarginsButton.Text = LangMan.Get("set-margins-btn");
			okButton.Text = LangMan.Get("print");
			leftLabel.Text = LangMan.Get("left") + ":";
			rightLabel.Text = LangMan.Get("right") + ":";
			topLabel.Text = LangMan.Get("top") + ":";
			bottomLabel.Text = LangMan.Get("bottom") + ":";
			documentLabel.Text = LangMan.Get("title") + ":";
			centerCheckbox.Text = LangMan.Get("center-image");
			horizontalCheckBox.Text = LangMan.Get("landscape-orientation");
			marginsLabel.Text = LangMan.Get("margins") + ":";
			marginsCheckBox.Text = LangMan.Get("margin-bounds");
			infoTooltip.SetToolTip(closeBtn, NativeMan.GetMessageBoxText(NativeMan.DialogBoxCommandID.IDCLOSE) + " | Alt+F4");
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
