using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	partial class SettingsForm : Form
	{
		private bool darkMode;

		public SettingsForm(bool darkMode)
		{
			this.darkMode = darkMode;

			if (darkMode)
			{
				this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			InitializeComponent();

			if (darkMode)
			{
				this.BackColor = ThemeManager.BackColorDark;
				this.ForeColor = Color.White;

				for(int i = 0; i < tabControl1.TabPages.Count; i++)
				{
					tabControl1.TabPages[i].ForeColor = Color.Black;
				}

				okButton.BackColor = ThemeManager.SecondColorDark;
			}

			int theme = Properties.Settings.Default.Theme;
			if (theme == 0)
			{
				systemThemeRadio.Checked = true;
			}
			else if (theme == 1)
			{
				lightThemeRadio.Checked = true;
			}
			else
			{
				darkThemeRadio.Checked = true;
			}

			updatesCheckBox.Checked = Properties.Settings.Default.CheckForUpdates;
		}

		private void SettingsForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		private void updatesCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.CheckForUpdates = updatesCheckBox.Checked;
			Properties.Settings.Default.Save();
		}

		private void systemThemeRadio_CheckedChanged(object sender, EventArgs e)
		{
			if (systemThemeRadio.Checked)
			{
				Properties.Settings.Default.Theme = 0;
				Properties.Settings.Default.Save();
			}
		}

		private void lightThemeRadio_CheckedChanged(object sender, EventArgs e)
		{
			if (lightThemeRadio.Checked)
			{
				Properties.Settings.Default.Theme = 1;
				Properties.Settings.Default.Save();
			}
		}

		private void darkThemeRadio_CheckedChanged(object sender, EventArgs e)
		{
			if (darkThemeRadio.Checked)
			{
				Properties.Settings.Default.Theme = 2;
				Properties.Settings.Default.Save();
			}
		}

		private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
		{
			Graphics g = e.Graphics;
			Brush _textBrush;

			// Get the item from the collection.
			TabPage _tabPage = tabControl1.TabPages[e.Index];

			// Get the real bounds for the tab rectangle.
			Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

			if (e.State == DrawItemState.Selected)
			{
				// Draw a different background color, and don't paint a focus rectangle.
				_textBrush = new SolidBrush(Color.White);

				g.FillRectangle(Brushes.Gray, e.Bounds);
			}
			else
			{	_textBrush = new System.Drawing.SolidBrush(e.ForeColor);
				e.DrawBackground();
			}

			// Use our own font.
			Font _tabFont = this.Font;

			// Draw string. Center the text.
			StringFormat _stringFlags = new StringFormat();
			_stringFlags.Alignment = StringAlignment.Center;
			_stringFlags.LineAlignment = StringAlignment.Center;
			g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
		}
	}
}
