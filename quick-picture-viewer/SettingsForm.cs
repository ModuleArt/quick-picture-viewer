using QuickLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	partial class SettingsForm : QlibFixedForm
	{
		public SettingsForm(bool darkMode)
		{
			if (darkMode)
			{
				this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			InitializeComponent();

			SetDraggableControls(new List<Control>() { titlePanel, titleLabel });

			applyDarkMode(darkMode);

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
			zoomWheelCheckBox.Checked = Properties.Settings.Default.NoCtrlZoom;

			int startupAction = Properties.Settings.Default.StartupAction;
			if (startupAction == 0)
			{
				startupNothingRadio.Checked = true;
			}
			else if (startupAction == 1)
			{
				startupPasteRadio.Checked = true;
			}

			favExtTextBox.Text = Properties.Settings.Default.FavoriteExternalApp;
		}

		private void applyDarkMode(bool dark)
		{
			if (dark)
			{
				this.BackColor = ThemeManager.DarkBackColor;
				this.ForeColor = Color.White;

				settingsTabs.BackTabColor = ThemeManager.DarkBackColor;
				settingsTabs.BorderColor = ThemeManager.DarkSecondColor;
				settingsTabs.HeaderColor = ThemeManager.DarkSecondColor;
				settingsTabs.TextColor = Color.White;
				settingsTabs.HorizontalLineColor = Color.Transparent;

				favExtTextBox.BackColor = ThemeManager.DarkSecondColor;
				favExtTextBox.ForeColor = Color.White;

				browseBtn.Image = Properties.Resources.white_options;
				browseBtn.BackColor = ThemeManager.DarkSecondColor;
				browseBtn.ForeColor = Color.White;
			}

			updatesCheckBox.SetDarkMode(dark);
			fullscrCursorCheckBox.SetDarkMode(dark);
			darkThemeRadio.SetDarkMode(dark);
			lightThemeRadio.SetDarkMode(dark);
			systemThemeRadio.SetDarkMode(dark);
			zoomWheelCheckBox.SetDarkMode(dark);
			closeBtn.SetDarkMode(dark);
			startupNothingRadio.SetDarkMode(dark);
			startupPasteRadio.SetDarkMode(dark);
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

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void zoomWheelCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.NoCtrlZoom = zoomWheelCheckBox.Checked;
			Properties.Settings.Default.Save();
		}

		private void startupNothingRadio_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.StartupAction = 0;
			Properties.Settings.Default.Save();
		}

		private void startupPasteRadio_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.StartupAction = 1;
			Properties.Settings.Default.Save();
		}

		private void favExtTextBox_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.FavoriteExternalApp = favExtTextBox.Text;
			Properties.Settings.Default.Save();
		}

		private void browseBtn_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				favExtTextBox.Text = openFileDialog1.FileName;
			}
		}
	}
}
