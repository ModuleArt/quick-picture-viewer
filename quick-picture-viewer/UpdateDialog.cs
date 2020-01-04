using System;
using System.Drawing;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	public partial class UpdateDialog : Form
	{
		private readonly UpdateChecker _checker;
		private bool _loadednotes;

		public UpdateDialog(UpdateChecker checker, string appName)
		{
			_checker = checker;

			InitializeComponent();

			label1.Text = string.Format(label1.Text, appName);

			if (ThemeManager.isDarkTheme())
			{
				this.BackColor = ThemeManager.BackColorDark;
				this.ForeColor = Color.White;

				buttonYes.BackColor = ThemeManager.SecondColorDark;
				buttonNo.BackColor = ThemeManager.SecondColorDark;
				boxReleaseNotes.BackColor = ThemeManager.SecondColorDark;
			}
		}

		void panel1_Resize(object sender, EventArgs e)
		{
			label1.Left = (panel1.ClientSize.Width - label1.Width) / 2;
			label2.Left = (panel1.ClientSize.Width - label2.Width) / 2;
		}

		async void boxReleaseNotes_CheckedChanged(object sender, EventArgs e)
		{
			ReleaseNotesPanel.Visible = boxReleaseNotes.Checked;

			if (_loadednotes) return;

			ReleaseNotes.DocumentText = await _checker.RenderReleaseNotes();
			_loadednotes = true;
		}
	}
}