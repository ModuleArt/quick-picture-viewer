using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	partial class SettingsForm : Form
	{
		private bool darkMode;

		public SettingsForm(bool darkMode)
		{
			this.darkMode = darkMode;

			InitializeComponent();

			if (darkMode)
			{
				this.BackColor = ThemeManager.BackColorDark;
				this.ForeColor = Color.White;

				okButton.BackColor = ThemeManager.SecondColorDark;

				settingsTabs.BackTabColor = ThemeManager.BackColorDark;
				settingsTabs.BorderColor = ThemeManager.SecondColorDark;
				settingsTabs.ActiveColor = ThemeManager.AccentColorDark;
				settingsTabs.HeaderColor = ThemeManager.SecondColorDark;
				settingsTabs.TextColor = Color.White;
				settingsTabs.HorizontalLineColor = Color.Transparent;

				ThemeManager.enableDarkTitlebar(Handle, true);
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
			fullscrCursorCheckBox.Checked = Properties.Settings.Default.ShowCursorInFullscreen;
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

		private void fullscrCursorCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.ShowCursorInFullscreen = fullscrCursorCheckBox.Checked;
			Properties.Settings.Default.Save();
		}
	}
}
