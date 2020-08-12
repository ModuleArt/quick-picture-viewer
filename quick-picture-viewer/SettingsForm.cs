using QuickLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	partial class SettingsForm : QlibFixedForm
	{
		struct Language
		{
			public string Code;
			public string AuthorName;
			public string AuthorLink;
		}

		private Language[] languages = {
			new Language
			{
				Code = "en",
				AuthorName = "Beelink",
				AuthorLink = "https://github.com/Beelink"
			},
			new Language
			{
				Code = "ru",
				AuthorName = "Beelink",
				AuthorLink = "https://github.com/Beelink"
			}
		};

		private MainForm owner;

		public SettingsForm(bool darkMode)
		{
			if (darkMode)
			{
				this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			InitializeComponent();
			(new DropShadow()).ApplyShadows(this);
			SetDraggableControls(new List<Control>() { titlePanel, titleLabel });

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

			slideshowTimeNumeric.Value = Properties.Settings.Default.SlideshowTime;
			slideshowCounterCheckBox.Checked = Properties.Settings.Default.SlideshowCounter;

			for (int i = 0; i < languages.Length; i++)
			{
				if (Properties.Settings.Default.Language == languages[i].Code)
				{
					langComboBox.SelectedIndex = i;
					break;
				}
			}

			translatedByLink.LinkColor = ThemeManager.AccentColor;

			SetDarkMode(darkMode);
		}

		private void InitLanguage()
		{
			this.Text = owner.resMan.GetString("settings");
			titleLabel.Text = owner.resMan.GetString("settings");
			langPage.Text = owner.resMan.GetString("localization");
			startupPage.Text = owner.resMan.GetString("startup");
			restartLabel1.Text = "* " + owner.resMan.GetString("restart-required");
			restartLabel2.Text = "* " + owner.resMan.GetString("restart-required");
			systemThemeRadio.Text = owner.resMan.GetString("use-system-setting");
			lightThemeRadio.Text = owner.resMan.GetString("light");
			darkThemeRadio.Text = owner.resMan.GetString("dark");
			themePage.Text = owner.resMan.GetString("theme");
			startupLabel.Text = owner.resMan.GetString("app-startup-action") + ":";
			startupNothingRadio.Text = owner.resMan.GetString("do-nothing");
			startupPasteRadio.Text = owner.resMan.GetString("paste-from-clipboard");
			updatesPage.Text = owner.resMan.GetString("updates");
			updatesCheckBox.Text = owner.resMan.GetString("check-for-updates-on-startup");
		}

		private void SetDarkMode(bool dark)
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
			slideshowTimeNumeric.SetDarkMode(dark);
			slideshowCounterCheckBox.SetDarkMode(dark);
			langComboBox.SetDarkMode(dark);
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

		private void slideshowCounterCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.SlideshowCounter = slideshowCounterCheckBox.Checked;
			Properties.Settings.Default.Save();
		}

		private void slideshowTimeNumeric_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.SlideshowTime = (int)slideshowTimeNumeric.Value;
			Properties.Settings.Default.Save();
		}

		private void langComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.Language = languages[langComboBox.SelectedIndex].Code;
			Properties.Settings.Default.Save();

			if (owner != null)
			{
				translatedByLink.Text = owner.resMan.GetString("translated-by") + ": " + languages[langComboBox.SelectedIndex].AuthorName;
			}
		}

		private void SettingsForm_Load(object sender, EventArgs e)
		{
			owner = this.Owner as MainForm;
			InitLanguage();
			translatedByLink.Text = owner.resMan.GetString("translated-by") + ": " + languages[langComboBox.SelectedIndex].AuthorName;
		}

		private void translatedByLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(languages[langComboBox.SelectedIndex].AuthorLink);
		}
	}
}
