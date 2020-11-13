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
		private MainForm owner;

		public AboutForm()
		{
			HandleCreated += new EventHandler(ThemeManager.formHandleCreated);

			InitializeComponent();
			SetDraggableControls(new List<Control>() { logoPictureBox, productLabel, versionLabel, copyrightLabel });

			closeBtn.SetDarkMode(false);

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
			owner = Owner as MainForm;
			InitLanguage();
		}

		private void InitLanguage()
		{
			Text = owner.resMan.GetString("about");
			updatesBtn.Text = " " + owner.resMan.GetString("check-for-app-updates");
			descTextBox.Text = owner.resMan.GetString("app-description");
			makeDefaultBtn.Text = owner.resMan.GetString("set-as-default-image-viewer");
			infoTooltip.SetToolTip(makeDefaultBtn, owner.resMan.GetString("open-windows-settings"));
			infoTooltip.SetToolTip(closeBtn, NativeMan.GetMessageBoxText(NativeMan.DialogBoxCommandID.IDCLOSE) + " | Alt+F4");
		}

		private void makeDefaultBtn_Click(object sender, EventArgs e)
		{
			Process.Start("ms-settings:defaultapps");
		}

		private void updatesBtn_Click(object sender, EventArgs e)
		{
			MainForm parent = (MainForm)Owner;
			parent.checkForUpdates(true);
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
