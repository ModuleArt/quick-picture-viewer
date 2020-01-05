using System;
using System.Drawing;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	public partial class UpdateForm : Form
	{
		private readonly UpdateChecker _checker;
		private bool _loadednotes;

		public UpdateForm(UpdateChecker checker, string appName)
		{
			_checker = checker;

			InitializeComponent();

			this.Height = 179;

			label1.Text = string.Format(label1.Text, appName);
			currentLabel.Text = string.Format(currentLabel.Text, _checker.CurrentVersion);
			latestLabel.Text = string.Format(latestLabel.Text, _checker.LatestRelease.TagName);

			if (ThemeManager.isDarkTheme())
			{
				this.BackColor = ThemeManager.BackColorDark;
				this.ForeColor = Color.White;

				buttonYes.BackColor = ThemeManager.SecondColorDark;
				buttonNo.BackColor = ThemeManager.SecondColorDark;
				boxReleaseNotes.BackColor = ThemeManager.SecondColorDark;
			}
		}

		async void boxReleaseNotes_CheckedChanged(object sender, EventArgs e)
		{
			if (boxReleaseNotes.Checked)
			{
				this.Height = 386;
			}
			else
			{
				this.Height = 179;
			}

			ReleaseNotes.Visible = boxReleaseNotes.Checked;

			if (_loadednotes) return;

			ReleaseNotes.DocumentText = await _checker.RenderReleaseNotes();
			_loadednotes = true;
		}
	}
}