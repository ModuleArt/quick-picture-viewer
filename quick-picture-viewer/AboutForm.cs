using QuickLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	partial class AboutForm : QlibFixedForm
	{
		private MainForm owner;

		public AboutForm(bool darkMode)
		{
			if (darkMode)
			{
				this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			InitializeComponent();
			SetDraggableControls(new List<Control>() { titlePanel, logoPictureBox, titleLabel, productLabel, versionLabel });
			SetDarkMode(darkMode);

			string fullVer = Assembly.GetExecutingAssembly().GetName().Version.ToString();
			int lastDotIndex = fullVer.LastIndexOf('.');
			versionLabel.Text = String.Format("v{0}", fullVer.Substring(0, lastDotIndex));

			if (IntPtr.Size == 4)
			{
				versionLabel.Text += " (x32)";
			}
			else if (IntPtr.Size == 8)
			{
				versionLabel.Text += " (x64)";
			}

			if (ThemeManager.isWindows10())
			{
				makeDefaultBtn.Visible = true;
			}

			updatesLink.LinkColor = ThemeManager.AccentColor;
			websiteLink.LinkColor = ThemeManager.AccentColor;
			githubLink.LinkColor = ThemeManager.AccentColor;
			licenseLink.LinkColor = ThemeManager.AccentColor;
		}

		private void SetDarkMode(bool dark)
		{
			if (dark)
			{
				this.BackColor = ThemeManager.DarkBackColor;
				this.ForeColor = Color.White;
				descTextBox.BackColor = ThemeManager.DarkBackColor;
				descTextBox.ForeColor = Color.White;
				makeDefaultBtn.BackColor = ThemeManager.DarkSecondColor;
			}

			closeBtn.SetDarkMode(dark);
		}

		private void developerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://moduleart.github.io");
		}

		private void issuesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://github.com/ModuleArt/quick-picture-viewer/");
		}

		private void updatesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MainForm parent = (MainForm) this.Owner;
			parent.checkForUpdates(true);
			this.Close();
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
			Process.Start("https://github.com/ModuleArt/quick-picture-viewer/blob/master/LICENSE.md/");
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void AboutForm_Load(object sender, EventArgs e)
		{
			owner = this.Owner as MainForm;
			InitLanguage();
		}

		private void InitLanguage()
		{
			this.Text = owner.resMan.GetString("about");
			infoTooltip.SetToolTip(closeBtn, owner.resMan.GetString("close") + " | Alt+F4");
			updatesLink.Text = owner.resMan.GetString("check-for-updates");
			descTextBox.Text = owner.resMan.GetString("app-description");
			makeDefaultBtn.Text = owner.resMan.GetString("set-as-default-image-viewer");
			infoTooltip.SetToolTip(makeDefaultBtn, owner.resMan.GetString("open-windows-settings"));
			licenseLabel.Text = owner.resMan.GetString("license") + ":";
			companyLabel.Text = owner.resMan.GetString("created-by");
		}

		private void makeDefaultBtn_Click(object sender, EventArgs e)
		{
			Process.Start("ms-settings:defaultapps");
		}
	}
}
