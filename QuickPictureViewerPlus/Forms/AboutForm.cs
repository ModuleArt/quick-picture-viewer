using QuickLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace QuickPictureViewerPlus
{
	partial class AboutForm : QlibFixedForm
	{
		public AboutForm()
		{
			InitializeComponent();
			SetDraggableControls(new List<Control>() { logoPictureBox, productLabel, versionLabel, copyrightLabel });

			closeBtn.DarkMode = false;

			string fullVer = Assembly.GetExecutingAssembly().GetName().Version.ToString();
			int lastDotIndex = fullVer.LastIndexOf('.');
			versionLabel.Text = String.Format("v{0}", fullVer.Substring(0, lastDotIndex));

			if (IntPtr.Size == 4) versionLabel.Text += " (x32)";
			else if (IntPtr.Size == 8) versionLabel.Text += " (x64)";

			if (ThemeMan.isWindows10()) makeDefaultBtn.Enabled = true;
		}

		protected override void OnHandleCreated(EventArgs e)
		{
			ThemeMan.ApplyDarkTitlebar(Handle, DarkMode);
			base.OnHandleCreated(e);
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
			Text = LangMan.Get("about");
			updatesBtn.Text = " " + LangMan.Get("check-for-app-updates");
			descTextBox.Text = LangMan.Get("app-description");
			makeDefaultBtn.Text = LangMan.Get("set-as-default-image-viewer");
			infoTooltip.SetToolTip(closeBtn, NativeMan.GetMessageBoxText(NativeMan.DialogBoxCommandID.IDCLOSE) + " | Alt+F4");
		}

		private void makeDefaultBtn_Click(object sender, EventArgs e)
		{
			Process.Start("ms-settings:defaultapps");
		}

		private void updatesBtn_Click(object sender, EventArgs e)
		{
			UpdateMan.CheckForUpdates(true, TopMost, Owner.Handle);
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
