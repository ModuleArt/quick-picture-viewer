using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	partial class AboutForm : Form
	{
		private bool darkMode = ThemeManager.isDarkTheme();

		public AboutForm()
		{
			if (darkMode)
			{
				this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			InitializeComponent();

			versionLabel.Text = String.Format("Version: {0}", Assembly.GetExecutingAssembly().GetName().Version.ToString().Substring(0, 5));

			if (darkMode)
			{
				this.BackColor = ThemeManager.BackColorDark;
				this.ForeColor = Color.White;

				infoGroup.Paint += ThemeManager.PaintDarkGroupBox;
				pagesGroup.Paint += ThemeManager.PaintDarkGroupBox;

				Color linkColor = ThemeManager.AccentColorDark;

				updatesLink.LinkColor = linkColor;
				developerLink.LinkColor = linkColor;
				projectLink.LinkColor = linkColor;
				issuesLink.LinkColor = linkColor;
				makeDefaultLink.LinkColor = linkColor;
				licenseLink.LinkColor = linkColor;

				okButton.BackColor = ThemeManager.SecondColorDark;
			}
		}

		private void developerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://moduleart.github.io/");
		}

		private void projectLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/ModuleArt/quick-picture-viewer/");
		}

		private void issuesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/ModuleArt/quick-picture-viewer/issues/");
		}

		private void updatesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MainForm parent = (MainForm) this.Owner;

			parent.checkForUpdates(true);
		}

		private void makeDefaultLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("ms-settings:defaultapps");
		}

		private void AboutForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		private void licenseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/ModuleArt/quick-picture-viewer/blob/master/LICENSE.md/");
		}
	}
}
