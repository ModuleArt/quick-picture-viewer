using QuickLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuickPictureViewerPlus
{
	public partial class MiniViewForm : QlibFixedForm
	{
		private Point startPos;
		private Size curSize;
		private double ratio;
		private bool checkboardBackground = false;
		private bool autoZoom = true;
		private int zoomFactor = 100;
		private int width = 0;
		private int height = 0;
		private Point panelMouseDownLocation;
		private MainForm owner;

		public MiniViewForm(Bitmap image, string title, bool checkboardBackground)
		{
			this.checkboardBackground = checkboardBackground;

			InitializeComponent();
			SetDraggableControls(new List<Control>() { zoomLabel });

			Text = title;

			MaximumSize = new Size(
				Convert.ToInt32(Screen.FromHandle(Handle).WorkingArea.Width / 1.25f),
				Convert.ToInt32(Screen.FromHandle(Handle).WorkingArea.Height / 1.25f)
			);

			ratio = (double)image.Width / (double)image.Height;

			if (image.Width < Width) Width = image.Width;

			Height = Convert.ToInt32(Width / ratio);
			if (Height == MaximumSize.Height) Width = Convert.ToInt32(Height * ratio);

			pictureBox.Image = image;
			width = image.Width;
			height = image.Height;

			picturePanel.MouseWheel += new MouseEventHandler(picturePanel_MouseWheel);

			if (ThemeMan.isWindows10()) ThemeMan.setDarkModeToControl(picturePanel.Handle);
			if (Properties.Settings.Default.PipOpacity == 0.25 || Properties.Settings.Default.PipOpacity == 0.75) Opacity = Properties.Settings.Default.PipOpacity;
		}

		private void picturePanel_MouseWheel(object sender, MouseEventArgs e)
		{
			if (ModifierKeys == Keys.Control || Properties.Settings.Default.MouseWheelScrollAction == 1)
			{
				if (e.Delta > 0) zoomIn();
				else if (e.Delta < 0) zoomOut();
			}
		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			Owner.Show();
			Owner.Refresh();
			Dispose();
			base.OnFormClosed(e);
		}

		private void zoomIn()
		{
			if (autoZoom) ZoomToFit();
			setZoomFactor(zoomFactor + 5);
		}

		private void zoomOut()
		{
			if (autoZoom) ZoomToFit();
			setZoomFactor(zoomFactor - 5);
		}

		private void setZoomFactor(int newZoomFactor)
		{
			if (newZoomFactor < 1) newZoomFactor = 1;
			if (newZoomFactor > 250) newZoomFactor = 250;

			zoomFactor = newZoomFactor;

			zoomLabel.Text = LangMan.Get("zoom") + ": " + zoomFactor.ToString() + "%";

			setAutoZoom(false);

			int newWidth = Convert.ToInt32(width * zoomFactor / 100);
			int newHeight = Convert.ToInt32(height * zoomFactor / 100);

			pictureBox.Size = new Size(newWidth, newHeight);

			pictureBox.UpdatePictureBoxLocation(picturePanel);
		}

		private void ZoomToFit()
		{
			double zoomFactorX = picturePanel.Width / (double)width;
			double zoomFactorY = picturePanel.Height / (double)height;
			zoomFactor = zoomFactorX > zoomFactorY ? (int)(zoomFactorY * 100) : (int)(zoomFactorX * 100);
		}

		private void MiniViewForm_MouseEnter(object sender, EventArgs e)
		{
			showUI(true);
		}

		private void MiniViewForm_MouseLeave(object sender, EventArgs e)
		{
			Point relativePoint = PointToClient(Cursor.Position);
			if (relativePoint.Y > 32 && !(relativePoint.Y > ClientSize.Height - 32 && relativePoint.X > ClientSize.Width - 32)) showUI(false);
		}

		private void showUI(bool b)
		{
			if (zoomLabel.Visible != b)
			{
				closeBtn.Visible = b;
				zoomLabel.Visible = b;
				autoZoomBtn.Visible = b;
				opacityBtn.Visible = b;
				zoom100Btn.Visible = b;
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
			infoTooltip.SetToolTip(zoom100Btn, LangMan.Get("zoom-to-actual-size") + " (100%) | Ctrl+0");
			infoTooltip.SetToolTip(autoZoomBtn, LangMan.Get("auto-zoom") + " | Ctrl+Shift+A");
			infoTooltip.SetToolTip(opacityBtn, LangMan.Get("change-window-opacity") + " | Ctrl+O");
			zoomLabel.Text = LangMan.Get("zoom") + ": " + LangMan.Get("auto");
			checkboardBtn.Text = LangMan.Get("checkboard-background");
			newWindowBtn.Text = LangMan.Get("new-window");
			quitPipBtn.Text = LangMan.Get("exit-picture-in-picture");
			infoTooltip.SetToolTip(closeBtn, NativeMan.GetMessageBoxText(NativeMan.DialogBoxCommandID.IDCLOSE) + " | Alt+F4");
		}

		private void setCheckboardBackground(bool b)
		{
			checkboardBackground = b;
			checkboardBtn.Checked = b;
			pictureBox.BackColor = checkboardBackground ? ThemeMan.DarkBackColor : Color.Black;
			pictureBox.ApplyCheckerboardBackground(b, true);
		}

		private void MiniViewForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control)
			{
				if (e.Shift)
				{
					if (e.KeyCode == Keys.P) Close();
					else if (e.KeyCode == Keys.A) autoZoomBtn.PerformClick();
				}
				else
				{
					if (e.KeyCode == Keys.N) owner.NewWindow();
					else if (e.KeyCode == Keys.B)
					{
						owner.setCheckboardBackground(!checkboardBackground, true);
						setCheckboardBackground(!checkboardBackground);
					}
					else if (e.KeyCode == Keys.O) opacityBtn.PerformClick();
					else if (e.KeyCode == Keys.OemMinus) zoomOut();
					else if (e.KeyCode == Keys.Oemplus) zoomIn();
					else if (e.KeyCode == Keys.D0) zoom100Btn.PerformClick();
				}
			}
		}

		private void autoZoomButton_Click(object sender, EventArgs e)
		{
			if (autoZoom)
			{
				ZoomToFit();
				setZoomFactor(zoomFactor);
			}
			else
			{
				setAutoZoom(true);
			}
		}

		private void setAutoZoom(bool b)
		{
			autoZoom = b;

			if (b)
			{
				pictureBox.Dock = DockStyle.Fill;

				zoomLabel.Text = LangMan.Get("zoom") + ": " + LangMan.Get("auto");

				Height = Convert.ToInt32(Width / ratio);
				if (Height == MaximumSize.Height)
				{
					Width = Convert.ToInt32(Height * ratio);
				}
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
				if (autoZoom || (pictureBox.Width <= picturePanel.Width && pictureBox.Height <= picturePanel.Height)) NativeMan.DragWindow(Handle);
				else panelMouseDownLocation = new Point(
					PointToClient(Cursor.Position).X + picturePanel.HorizontalScroll.Value,
					PointToClient(Cursor.Position).Y + picturePanel.VerticalScroll.Value
				);
			}
		}

		private void picturePanel_MouseUp(object sender, MouseEventArgs e)
		{
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
					picturePanel.HorizontalScroll.Value = newX < picturePanel.HorizontalScroll.Maximum ? newX : picturePanel.HorizontalScroll.Maximum;
				}
				else
				{
					picturePanel.HorizontalScroll.Value = picturePanel.HorizontalScroll.Minimum;
				}

				if (newY > picturePanel.VerticalScroll.Minimum)
				{
					picturePanel.VerticalScroll.Value = newY < picturePanel.VerticalScroll.Maximum ? newY : picturePanel.VerticalScroll.Maximum;
				}
				else
				{
					picturePanel.VerticalScroll.Value = picturePanel.VerticalScroll.Minimum;
				}

				pictureBox.Update();
			}
		}

		private void MiniViewForm_ResizeEnd(object sender, EventArgs e)
		{
			if (!autoZoom) pictureBox.UpdatePictureBoxLocation(picturePanel);
			zoomLabel.ForeColor = Width > 240 ? Color.White : Color.Black;
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

		private void resizeBtn_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Point curPos = PointToClient(Cursor.Position);

				int newWidth = curSize.Width + curPos.X - startPos.X;
				if (newWidth < MinimumSize.Width) newWidth = MinimumSize.Width;

				int newHeight;
				if (autoZoom) newHeight = Convert.ToInt32(newWidth / ratio);
				else newHeight = curSize.Height + curPos.Y - startPos.Y;

				if (newHeight == MaximumSize.Height) newWidth = Convert.ToInt32(newHeight * ratio);

				Size = new Size(newWidth, newHeight);
				Update();
			}
		}

		private void opacityBtn_Click(object sender, EventArgs e)
		{
			if (Opacity == 1) Opacity = 0.75;
			else if (Opacity == 0.75) Opacity = 0.5;
			else if (Opacity == 0.5) Opacity = 0.25;
			else if (Opacity == 0.25) Opacity = 1;

			Properties.Settings.Default.PipOpacity = Opacity;
			Properties.Settings.Default.Save();
		}

		private void quitPipBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void zoom100Btn_Click(object sender, EventArgs e)
		{
			if (autoZoom) ZoomToFit();
			setZoomFactor(100);
		}
	}
}