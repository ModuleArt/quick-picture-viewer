using QuickLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	public partial class MiniViewForm : QlibFixedForm
	{
		private Point startPos;
		private Size curSize;
		private float ratio;

		private bool checkboardBackground = false;
		private bool autoZoom = true;
		private int zoomFactor = 100;
		private int width = 0;
		private int height = 0;

		System.Timers.Timer resizeTimer = new System.Timers.Timer();

		Point panelMouseDownLocation;

		public MiniViewForm(Image image, string title, bool checkboardBackground)
		{
			this.Text = title;
			this.checkboardBackground = checkboardBackground;

			InitializeComponent();

			SetDraggableControls(new List<Control>() { moveButton });

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

			pictureBox.Image = image;
			width = image.Width;
			height = image.Height;

			setCheckboardBackground(checkboardBackground);

			resizeTimer.Elapsed += new ElapsedEventHandler(resizeTimer_Elapsed);
			resizeTimer.Interval = 50;

			picturePanel.MouseWheel += new MouseEventHandler(picturePanel_MouseWheel);

			if (ThemeManager.isWindows10())
			{
				ThemeManager.setDarkModeToControl(picturePanel.Handle);
			}
		}

		private void picturePanel_MouseWheel(object sender, MouseEventArgs e)
		{
			if (Control.ModifierKeys == Keys.Control || Properties.Settings.Default.NoCtrlZoom)
			{
				if (e.Delta > 0)
				{
					zoomIn();
				}
				else if (e.Delta < 0)
				{
					zoomOut();
				}
			}
		}

		private void zoomIn()
		{
			if (autoZoom)
			{
				zoomToFit();
			}
			setZoomFactor(zoomFactor + 5);
		}

		private void zoomOut()
		{
			if (autoZoom)
			{
				zoomToFit();
			}
			setZoomFactor(zoomFactor - 5);
		}

		private void setZoomFactor(int newZoomFactor)
		{
			if (newZoomFactor < 1) newZoomFactor = 1;
			if (newZoomFactor > 250) newZoomFactor = 250;

			if (newZoomFactor != zoomFactor)
			{
				zoomFactor = newZoomFactor;

				zoomLabel.Text = "Zoom: " + zoomFactor.ToString() + "%";

				setAutoZoom(false);

				int newWidth = Convert.ToInt32(width * zoomFactor / 100);
				int newHeight = Convert.ToInt32(height * zoomFactor / 100);

				pictureBox.Size = new Size(newWidth, newHeight);

				updatePictureBoxLocation();
			}
		}

		private void updatePictureBoxLocation()
		{
			if (pictureBox.Width < picturePanel.Width)
			{
				pictureBox.Left = (picturePanel.Width - pictureBox.Width) / 2;
			}
			else
			{
				pictureBox.Left = 0;
			}

			if (pictureBox.Height < picturePanel.Height)
			{
				pictureBox.Top = (picturePanel.Height - pictureBox.Height) / 2;
			}
			else
			{
				pictureBox.Top = 0;
			}
		}

		private void zoomToFit()
		{
			double zoomFactorX = picturePanel.Width / (double)width;
			double zoomFactorY = picturePanel.Height / (double)height;

			if (zoomFactorX > zoomFactorY)
			{
				zoomFactor = Convert.ToInt32(zoomFactorY * 100);
			}
			else
			{
				zoomFactor = Convert.ToInt32(zoomFactorX * 100);
			}
		}

		private void resizeTimer_Elapsed(object sender, ElapsedEventArgs e)
		{
			this.Invoke((MethodInvoker)(() => {
				Point curPos = this.PointToClient(Cursor.Position);

				int newWidth = curSize.Width + curPos.X - startPos.X;
				//int newHeight = Convert.ToInt32((float)newWidth / ratio);
				int newHeight = curSize.Height + curPos.Y - startPos.Y;

				this.Size = new Size(newWidth, newHeight);
			}));
		}

		private void MiniViewForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Owner.Show();
		}

		private void MiniViewForm_MouseEnter(object sender, EventArgs e)
		{
			updateUIVisibility(true);
		}

		private void MiniViewForm_MouseLeave(object sender, EventArgs e)
		{
			updateUIVisibility(false);
		}

		private void updateUIVisibility(bool b)
		{
			var relativePoint = this.PointToClient(Cursor.Position);
			if (relativePoint.X > 27 && relativePoint.X < this.Width - 27)
			{
				if (relativePoint.Y > 27 && relativePoint.Y < this.Height - 27)
				{
					b = true;
				}
			}

			showUI(b);
		}

		private void showUI(bool b)
		{
			if (moveButton.Visible != b)
			{
				moveButton.Visible = b;
				closeBtn.Visible = b;
				zoomLabel.Visible = b;
				autoZoomButton.Visible = b;
				gripButton.Visible = b;
			}
		}

		//private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		//{
		//	if (e.Button == MouseButtons.Left)
		//	{
		//		Point downPos = this.PointToClient(Cursor.Position);
		//		if (downPos.X > gripButton.Location.X && downPos.X < gripButton.Location.X + gripButton.Width &&
		//			downPos.Y > gripButton.Location.Y && downPos.Y < gripButton.Location.Y + gripButton.Height)
		//		{
		//			Cursor.Current = Cursors.SizeNWSE;
		//			startPos = downPos;
		//			curSize = this.Size;
		//			resizeTimer.Start();
		//		}
		//		else
		//		{
		//			Cursor.Current = Cursors.SizeAll;
		//			ReleaseCapture();
		//			SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
		//		}
		//	}
		//	else if (e.Button == MouseButtons.Right)
		//	{
		//		closing = true;
		//	}
		//}

		//private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		//{
		//	resizeTimer.Stop();
		//	Cursor.Current = Cursors.Default;
		//	if (closing)
		//	{
		//		this.Close();
		//	}
		//}

		private void MiniViewForm_Load(object sender, EventArgs e)
		{
			Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
			this.Left = workingArea.Left + workingArea.Width - this.Size.Width - 32;
			this.Top = workingArea.Top + 32;
		}

		private void setCheckboardBackground(bool b)
		{
			checkboardBackground = b;

			if (b)
			{
				pictureBox.BackgroundImage = Properties.Resources.checkboard_dark;
			}
			else
			{
				pictureBox.BackgroundImage = null;
			}
		}

		private void MiniViewForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control)
			{
				if (e.Shift)
				{
					if (e.KeyCode == Keys.C)
					{
						(this.Owner as MainForm).setCheckboardBackground(!checkboardBackground, true);
						setCheckboardBackground(!checkboardBackground);
					}
					else if (e.KeyCode == Keys.P)
					{
						this.Close();
					}
				}
				else
				{
					if (e.KeyCode == Keys.OemMinus)
					{
						zoomOut();
					}
					else if (e.KeyCode == Keys.Oemplus)
					{
						zoomIn();
					}
					else if (e.KeyCode == Keys.A)
					{
						autoZoomButton.PerformClick();
					}
				}
			}
			else
			{
				if (e.KeyCode == Keys.Escape)
				{
					this.Close();
				}
			}
		}

		private void autoZoomButton_Click(object sender, EventArgs e)
		{
			setAutoZoom(true);
		}

		private void setAutoZoom(bool b)
		{
			autoZoom = b;

			if (b)
			{
				pictureBox.Dock = DockStyle.Fill;

				zoomLabel.Text = "Zoom: Auto";
			}
			else
			{
				pictureBox.Dock = DockStyle.None;
			}
		}

		private void picturePanel_DoubleClick(object sender, EventArgs e)
		{
			this.Close();
		}

		private void gripButton_MouseDown(object sender, MouseEventArgs e)
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
		}

		private void gripButton_MouseUp(object sender, MouseEventArgs e)
		{
			resizeTimer.Stop();
			Cursor.Current = Cursors.Default;
		}

		private void MiniViewForm_Resize(object sender, EventArgs e)
		{
			if (!autoZoom)
			{
				updatePictureBoxLocation();
			}
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void picturePanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Cursor.Current = Cursors.SizeAll;
				if (autoZoom)
				{
					NativeMethodsManager.ReleaseCapture();
					NativeMethodsManager.SendMessage(Handle, 0xA1, 0x2, 0);
				}
				else
				{
					panelMouseDownLocation = new Point(
						this.PointToClient(Cursor.Position).X + picturePanel.HorizontalScroll.Value,
						this.PointToClient(Cursor.Position).Y + picturePanel.VerticalScroll.Value
					);
				}
			}
		}

		private void picturePanel_MouseUp(object sender, MouseEventArgs e)
		{
			Cursor.Current = Cursors.Default;
		}

		private void picturePanel_MouseMove(object sender, MouseEventArgs e)
		{
			updateUIVisibility(false);

			if (e.Button == MouseButtons.Left && !autoZoom)
			{
				int newX = panelMouseDownLocation.X - this.PointToClient(Cursor.Position).X;
				int newY = panelMouseDownLocation.Y - this.PointToClient(Cursor.Position).Y;

				if (newX > picturePanel.HorizontalScroll.Minimum)
				{
					if (newX < picturePanel.HorizontalScroll.Maximum)
					{
						picturePanel.HorizontalScroll.Value = newX;
					}
					else
					{
						picturePanel.HorizontalScroll.Value = picturePanel.HorizontalScroll.Maximum;
					}
				}
				else
				{
					picturePanel.HorizontalScroll.Value = picturePanel.HorizontalScroll.Minimum;
				}

				if (newY > picturePanel.VerticalScroll.Minimum)
				{
					if (newY < picturePanel.VerticalScroll.Maximum)
					{
						picturePanel.VerticalScroll.Value = newY;
					}
					else
					{
						picturePanel.VerticalScroll.Value = picturePanel.VerticalScroll.Maximum;
					}
				}
				else
				{
					picturePanel.VerticalScroll.Value = picturePanel.VerticalScroll.Minimum;
				}
			}
		}
	}
}
