using QuickLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
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
				this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			this.darkMode = darkMode;

			InitializeComponent();
			(new DropShadow()).ApplyShadows(this);
			SetDraggableControls(new List<Control>() { 
				titlePanel, titleLabel, 
				printPreviewControl1, 
				documentLabel, marginsLabel, leftLabel, rightLabel, topLabel, bottomLabel
			});

			applyDarkMode(darkMode);

			leftMarginTextBox.Text = pd.DefaultPageSettings.Margins.Left.ToString();
			topMarginTextBox.Text = pd.DefaultPageSettings.Margins.Top.ToString();
			rightMarginTextBox.Text = pd.DefaultPageSettings.Margins.Right.ToString();
			bottomMarginTextBox.Text = pd.DefaultPageSettings.Margins.Bottom.ToString();

			printPreviewControl1.Document = pd;

			titleTextBox.Text = docTitle;
		}

		private void applyDarkMode(bool dark)
		{
			if (dark)
			{
				ThemeManager.setDarkModeToControl(printPreviewControl1.Handle);

				this.BackColor = ThemeManager.DarkBackColor;
				this.ForeColor = Color.White;

				okButton.BackColor = ThemeManager.DarkSecondColor;
				okButton.Image = Properties.Resources.white_print;

				printPreviewControl1.BackColor = ThemeManager.DarkBackColor;

				titleTextBox.BackColor = ThemeManager.DarkSecondColor;
				titleTextBox.ForeColor = Color.White;
				leftMarginTextBox.BackColor = ThemeManager.DarkSecondColor;
				leftMarginTextBox.ForeColor = Color.White;
				rightMarginTextBox.BackColor = ThemeManager.DarkSecondColor;
				rightMarginTextBox.ForeColor = Color.White;
				topMarginTextBox.BackColor = ThemeManager.DarkSecondColor;
				topMarginTextBox.ForeColor = Color.White;
				bottomMarginTextBox.BackColor = ThemeManager.DarkSecondColor;
				bottomMarginTextBox.ForeColor = Color.White;

				okButton.BackColor = ThemeManager.DarkSecondColor;
				okButton.Image = Properties.Resources.white_print;
			}

			marginsCheckBox.SetDarkMode(dark);
			horizontalCheckBox.SetDarkMode(dark);
			centerCheckbox.SetDarkMode(dark);
			setMarginsButton.SetDarkMode(dark);
			closeBtn.SetDarkMode(dark);
			rightMarginTextBox.SetDarkMode(dark);
			leftMarginTextBox.SetDarkMode(dark);
			topMarginTextBox.SetDarkMode(dark);
			bottomMarginTextBox.SetDarkMode(dark);
			titleTextBox.SetDarkMode(dark);
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
			owner.printCenterImage = centerCheckbox.Checked;
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

		private void setMarginsButton_Paint(object sender, PaintEventArgs e)
		{
			if (darkMode)
			{
				Button btn = (Button)sender;

				btn.Text = string.Empty;
				TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;

				if (btn.Enabled)
				{
					TextRenderer.DrawText(e.Graphics, "Set margins", btn.Font, e.ClipRectangle, Color.White, flags);
				}
				else
				{
					TextRenderer.DrawText(e.Graphics, "Set margins", btn.Font, e.ClipRectangle, ThemeManager.DarkSecondColor, flags);
				}
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
			owner = this.Owner as MainForm;
			
			centerCheckbox.Checked = owner.printCenterImage;
			marginsCheckBox.Checked = printPreviewControl1.Document.OriginAtMargins;
			horizontalCheckBox.Checked = printPreviewControl1.Document.DefaultPageSettings.Landscape;

			InitLanguage();
		}

		private void InitLanguage()
		{
			this.Text = owner.resMan.GetString("print-conf");
			setMarginsButton.Text = owner.resMan.GetString("set-margins-btn");
			okButton.Text = owner.resMan.GetString("print");
			leftLabel.Text = owner.resMan.GetString("left") + ":";
			rightLabel.Text = owner.resMan.GetString("right") + ":";
			topLabel.Text = owner.resMan.GetString("top") + ":";
			bottomLabel.Text = owner.resMan.GetString("bottom") + ":";
			documentLabel.Text = owner.resMan.GetString("title") + ":";
			centerCheckbox.Text = owner.resMan.GetString("center-image");
			horizontalCheckBox.Text = owner.resMan.GetString("landscape-orientation");
			marginsLabel.Text = owner.resMan.GetString("margins") + ":";
			marginsCheckBox.Text = owner.resMan.GetString("margin-bounds");
			infoTooltip.SetToolTip(closeBtn, owner.resMan.GetString("close") + " | Alt+F4");
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
