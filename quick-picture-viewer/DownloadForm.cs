using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using Microsoft.Win32;

namespace quick_picture_viewer
{
	public partial class DownloadForm : Form
	{
        private string fileName;
        private WebClient wc;

		public DownloadForm(string url, bool darkMode)
		{
            if (darkMode)
            {
                this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
            }

            fileName = Path.Combine(GetDownloadFolderPath(), System.IO.Path.GetFileName(url));

            InitializeComponent();

            if (darkMode)
            {
                this.BackColor = ThemeManager.BackColorDark;
                this.ForeColor = Color.White;

                cancelButton.BackColor = ThemeManager.SecondColorDark;
                updateButton.BackColor = ThemeManager.SecondColorDark;
            }

            wc = new WebClient();

            wc.DownloadProgressChanged += wc_DownloadProgressChanged;
            wc.DownloadFileCompleted += wc_DownloadFileCompleted;

            wc.DownloadFileAsync(new Uri(url), fileName);
        }

        private string GetDownloadFolderPath()
        {
            try
            {
                return Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
            }
            catch
            {
                return "";
            }
        }

        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            statusLabel.Text = string.Format("Downloading... {0}%", e.ProgressPercentage);
        }

        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                statusLabel.Text = "Update failed!";
            }
            else if (e.Cancelled)
            {
                statusLabel.Text = "Update cancelled!";
            }
            else 
            {
                updateButton.Visible = true;
                statusLabel.Text = "Download finished!";
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Process.Start(fileName);
            this.Close();
            this.Owner.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            wc.CancelAsync();
        }
    }
}
