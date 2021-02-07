using QuickLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	partial class AboutForm : QlibFixedForm
	{
		private bool darkMode = false;

		public AboutForm(bool darkMode)
		{
			this.darkMode = darkMode;

			HandleCreated += new EventHandler(ThemeMan.formHandleCreated);

			InitializeComponent();
			SetDraggableControls(new List<Control>() { logoPictureBox, productLabel, versionLabel, copyrightLabel });

			closeBtn.DarkMode = false;

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

			if (ThemeMan.isWindows10())
			{
				makeDefaultBtn.Enabled = true;
			}
		}

		private void AboutForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void AboutForm_Load(object sender, EventArgs e)
		{
			InitLanguage();
		}

		private void InitLanguage()
		{
			Text = LangMan.GetString("about");
			updatesBtn.Text = " " + LangMan.GetString("check-for-app-updates");
			descTextBox.Text = LangMan.GetString("app-description");
			makeDefaultBtn.Text = LangMan.GetString("set-as-default-image-viewer");
			infoTooltip.SetToolTip(closeBtn, NativeMan.GetMessageBoxText(NativeMan.DialogBoxCommandID.IDCLOSE) + " | Alt+F4");
		}

		private void makeDefaultBtn_Click(object sender, EventArgs e)
		{
			Process.Start("ms-settings:defaultapps");
		}

		private void updatesBtn_Click(object sender, EventArgs e)
		{
			UpdateMan.CheckForUpdates(true, TopMost, darkMode, Owner.Handle);
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/ModuleArt/quick-picture-viewer/");
		}

		private void developerBtn_Click(object sender, EventArgs e)
		{
			Process.Start("https://moduleart.github.io");
		}
	}
}
