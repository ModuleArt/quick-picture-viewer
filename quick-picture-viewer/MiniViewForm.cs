using System;
using System.Drawing;
using System.Timers;
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

		private Point startPos;
		private Size curSize;
		private float ratio;
		private bool closing = false;

		System.Timers.Timer resizeTimer = new System.Timers.Timer();

		public MiniViewForm(Image image, string title)
		{
			this.Text = title;

			InitializeComponent();

			this.MaximumSize = new Size(
				Convert.ToInt32(Screen.FromHandle(this.Handle).WorkingArea.Width / 1.25f),
				Convert.ToInt32(Screen.FromHandle(this.Handle).WorkingArea.Height / 1.25f)
			);

			ratio = (float)image.Width / (float)image.Height;

			if (image.Width > image.Height)
			{
				this.Width = 400;
				this.Height = Convert.ToInt32(400 / ratio);
			}
			else
			{
				this.Width = Convert.ToInt32(400 * ratio);
				this.Height = 400;
			}

			if (this.Width <= 200)
			{
				this.Height = Convert.ToInt32(this.Width / ratio);
			}

			pictureBox1.Image = image;

			resizeTimer.Elapsed += new ElapsedEventHandler(resizeTimer_Elapsed);
			resizeTimer.Interval = 50;
		}

		private void resizeTimer_Elapsed(object sender, ElapsedEventArgs e)
		{
			this.Invoke((MethodInvoker)(() => {
				Point curPos = this.PointToClient(Cursor.Position);

				int newWidth = curSize.Width + curPos.X - startPos.X;
				int newHeight = Convert.ToInt32((float)newWidth / ratio);

				this.Size = new Size(newWidth, newHeight);
			}));
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
			gripButton.Visible = b;
		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Point downPos = this.PointToClient(Cursor.Position);
				if (downPos.X > gripButton.Location.X && downPos.X < gripButton.Location.X + gripButton.Width &&
					downPos.Y > gripButton.Location.Y && downPos.Y < gripButton.Location.Y + gripButton.Height)
				{
					Cursor.Current = Cursors.SizeNWSE;
					startPos = downPos;
					curSize = this.Size;
					resizeTimer.Start();
				}
				else
				{
					Cursor.Current = Cursors.SizeAll;
					ReleaseCapture();
					SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
				}
			}
			else if (e.Button == MouseButtons.Right)
			{
				closing = true;
			}
		}

		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			resizeTimer.Stop();
			Cursor.Current = Cursors.Default;
			if (closing)
			{
				this.Close();
			}
		}

		private void MiniViewForm_Load(object sender, EventArgs e)
		{
			Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
			this.Left = workingArea.Left + workingArea.Width - this.Size.Width - 32;
			this.Top = workingArea.Top + 32;
		}
	}
}
