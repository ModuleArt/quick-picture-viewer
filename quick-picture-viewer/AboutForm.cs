using QuickLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	partial class AboutForm : QlibFixedForm
	{
		public AboutForm(bool darkMode)
		{
			if (darkMode)
			{
				this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			InitializeComponent();
			(new DropShadow()).ApplyShadows(this);
			SetDraggableControls(new List<Control>() { titlePanel, logoPictureBox, titleLabel });

			applyDarkMode(darkMode);

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
				makeDefaultLink.Visible = true;
			}

			updatesLink.LinkColor = ThemeManager.AccentColor;
			websiteLink.LinkColor = ThemeManager.AccentColor;
			projectLink.LinkColor = ThemeManager.AccentColor;
			issuesLink.LinkColor = ThemeManager.AccentColor;
			makeDefaultLink.LinkColor = ThemeManager.AccentColor;
			licenseLink.LinkColor = ThemeManager.AccentColor;
		}

		private void applyDarkMode(bool dark)
		{
			if (dark)
			{
				this.BackColor = ThemeManager.DarkBackColor;
				this.ForeColor = Color.White;
			}

			closeBtn.SetDarkMode(dark);
		}

		private void developerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://moduleart.github.io");
		}

		private void projectLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://github.com/ModuleArt/quick-picture-viewer/");
		}

		private void issuesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://github.com/ModuleArt/quick-picture-viewer/issues/");
		}

		private void updatesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MainForm parent = (MainForm) this.Owner;
			parent.checkForUpdates(true);
			this.Close();
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
			Process.Start("https://github.com/ModuleArt/quick-picture-viewer/blob/master/LICENSE.md/");
		}

		[DllImport("User32.dll", CharSet = CharSet.Auto)]
		public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

		[DllImport("User32.dll")]
		private static extern IntPtr GetWindowDC(IntPtr hWnd);

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
