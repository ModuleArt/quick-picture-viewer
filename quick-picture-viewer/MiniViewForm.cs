using System;
using System.Drawing;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	public partial class MiniViewForm : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		public MiniViewForm(Image image, string title)
		{
			this.Text = title;

			InitializeComponent();

			float ratio = (float)image.Width / (float)image.Height;

			if (image.Width > image.Height)
			{
				this.Width = 400;
				this.Height = Convert.ToInt32(400 * ratio);
			}
			else
			{
				this.Width = Convert.ToInt32(400 * ratio);
				this.Height = 400;
			}

			pictureBox1.Image = image;
		}

		private void MiniViewForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Owner.Show();
		}

		private void MiniViewForm_MouseEnter(object sender, System.EventArgs e)
		{
			showUI(true);
		}

		private void MiniViewForm_MouseLeave(object sender, System.EventArgs e)
		{
			showUI(false);
		}

		private void showUI(bool b)
		{
			suggestionLabel.Visible = b;
		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			Cursor.Current = Cursors.SizeAll;

			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
			else if (e.Button == MouseButtons.Right)
			{
				this.Close();
			}
		}

		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			Cursor.Current = Cursors.Default;
		}

		private void MiniViewForm_Load(object sender, EventArgs e)
		{
			Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
			this.Left = workingArea.Left + workingArea.Width - this.Size.Width - 32;
			this.Top = workingArea.Top + 32;
		}
	}
}
