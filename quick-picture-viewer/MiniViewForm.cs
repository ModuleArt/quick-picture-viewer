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
		private Point panelMouseDownLocation;
		private MainForm owner;
		private System.Timers.Timer resizeTimer = new System.Timers.Timer();

		public MiniViewForm(Image image, string title, bool checkboardBackground)
		{
			if (ThemeManager.isWindows10())
			{
				HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			Text = title;
			this.checkboardBackground = checkboardBackground;

			InitializeComponent();
			SetDraggableControls(new List<Control>() { zoomLabel });

			MaximumSize = new Size(
				Convert.ToInt32(Screen.FromHandle(Handle).WorkingArea.Width / 1.25f),
				Convert.ToInt32(Screen.FromHandle(Handle).WorkingArea.Height / 1.25f)
			);

			ratio = image.Width / image.Height;

			if (image.Width > image.Height)
			{
				Width = 400;
				Height = Convert.ToInt32(400 / ratio);
			}
			else
			{
				Width = Convert.ToInt32(400 * ratio);
				Height = 400;
			}

			if (Width <= 200)
			{
				Height = Convert.ToInt32(Width / ratio);
			}

			pictureBox.Image = image;
			width = image.Width;
			height = image.Height;

			picturePanel.MouseWheel += new MouseEventHandler(picturePanel_MouseWheel);

			closeBtn.SetDarkMode(true);
			autoZoomBtn.SetDarkMode(true);
			resizeBtn.SetDarkMode(true);
			contextMenuStrip1.SetDarkMode(true);
			if (ThemeManager.isWindows10())
			{
				ThemeManager.setDarkModeToControl(picturePanel.Handle);
			}

			resizeTimer.Elapsed += new ElapsedEventHandler(resizeTimer_Elapsed);
			resizeTimer.Interval = 25;
		}

		private void picturePanel_MouseWheel(object sender, MouseEventArgs e)
		{
			if (ModifierKeys == Keys.Control || Properties.Settings.Default.MouseWheelScrollAction == 1)
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

				zoomLabel.Text = owner.resMan.GetString("zoom") + ": " + zoomFactor.ToString() + "%";

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
			try
			{
				Invoke((MethodInvoker)(() => {
					Point curPos = PointToClient(Cursor.Position);

					int newWidth = curSize.Width + curPos.X - startPos.X;
					int newHeight = Convert.ToInt32(newWidth / ratio);

					Size = new Size(newWidth, newHeight);
				}));
			}
			catch
			{

			}
		}

		private void MiniViewForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Owner.Show();
			Owner.Refresh();
		}

		private void MiniViewForm_MouseEnter(object sender, EventArgs e)
		{
			showUI(true);
		}

		private void MiniViewForm_MouseLeave(object sender, EventArgs e)
		{
			Point relativePoint = PointToClient(Cursor.Position);
			if (relativePoint.Y > 32)
			{
				if (!(relativePoint.Y > ClientSize.Height - 32 && relativePoint.X > ClientSize.Width - 32))
				{
					showUI(false);
				}
			}
		}

		private void showUI(bool b)
		{
			if (zoomLabel.Visible != b)
			{
				closeBtn.Visible = b;
				zoomLabel.Visible = b;
				autoZoomBtn.Visible = b;
				resizeBtn.Visible = b;
			}
		}

		private void MiniViewForm_Load(object sender, EventArgs e)
		{
			Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
			Left = workingArea.Left + workingArea.Width - Size.Width - 32;
			Top = workingArea.Top + 32;

			owner = Owner as MainForm;
			InitLanguage();

			setCheckboardBackground(checkboardBackground);
		}

		private void InitLanguage()
		{
			Text = owner.resMan.GetString("picture-in-picture");
			infoTooltip.SetToolTip(closeBtn, owner.resMan.GetString("close") + " | Alt+F4");
			infoTooltip.SetToolTip(autoZoomBtn, owner.resMan.GetString("auto-zoom") + " | Ctrl+A");
			infoTooltip.SetToolTip(resizeBtn, owner.resMan.GetString("drag-here-to-resize"));
			zoomLabel.Text = owner.resMan.GetString("zoom") + ": " + owner.resMan.GetString("auto");
			checkboardBtn.Text = owner.resMan.GetString("checkboard-background");
			newWindowBtn.Text = owner.resMan.GetString("new-window");
		}

		private void setCheckboardBackground(bool b)
		{
			checkboardBackground = b;
			checkboardBtn.Checked = b;

			if (b)
			{
				picturePanel.BackgroundImage = Properties.Resources.checkboard_dark;
			}
			else
			{
				picturePanel.BackgroundImage = null;
			}
		}

		private void MiniViewForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control)
			{
				if (e.Shift)
				{
					if (e.KeyCode == Keys.P)
					{
						Close();
					}
				}
				else
				{
					if (e.KeyCode == Keys.B)
					{
						owner.setCheckboardBackground(!checkboardBackground, true);
						setCheckboardBackground(!checkboardBackground);
					}
					else if (e.KeyCode == Keys.OemMinus)
					{
						zoomOut();
					}
					else if (e.KeyCode == Keys.Oemplus)
					{
						zoomIn();
					}
					else if (e.KeyCode == Keys.A)
					{
						autoZoomBtn.PerformClick();
					}
				}
			}
			else
			{
				if (e.KeyCode == Keys.Escape)
				{
					Close();
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

				zoomLabel.Text = owner.resMan.GetString("zoom") + ": " + owner.resMan.GetString("auto");
			}
			else
			{
				pictureBox.Dock = DockStyle.None;
			}
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			Close();
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
						PointToClient(Cursor.Position).X + picturePanel.HorizontalScroll.Value,
						PointToClient(Cursor.Position).Y + picturePanel.VerticalScroll.Value
					);
				}
			}
		}

		private void picturePanel_MouseUp(object sender, MouseEventArgs e)
		{
			resizeTimer.Stop();
			Cursor.Current = Cursors.Default;
		}

		private void picturePanel_MouseMove(object sender, MouseEventArgs e)
		{
			showUI(true);

			if (e.Button == MouseButtons.Left && !autoZoom)
			{
				int newX = panelMouseDownLocation.X - PointToClient(Cursor.Position).X;
				int newY = panelMouseDownLocation.Y - PointToClient(Cursor.Position).Y;

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

		private void MiniViewForm_ResizeEnd(object sender, EventArgs e)
		{
			if (!autoZoom)
			{
				updatePictureBoxLocation();
			}
		}

		private void MiniViewForm_Deactivate(object sender, EventArgs e)
		{
			showUI(false);
		}

		private void resizeBtn_MouseDown(object sender, MouseEventArgs e)
		{
			Cursor.Current = Cursors.SizeNWSE;
			startPos = PointToClient(Cursor.Position);
			curSize = Size;
			resizeTimer.Start();
		}

		private void checkerboardBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
		{
			owner.setCheckboardBackground(!checkboardBackground, true);
			setCheckboardBackground(!checkboardBackground);
		}

		private void newWindowBtn_Click(object sender, EventArgs e)
		{
			owner.NewWindow();
		}
	}
}
