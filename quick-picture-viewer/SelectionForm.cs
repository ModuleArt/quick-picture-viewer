using QuickLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	public partial class SelectionForm : Form
	{
		private int gripSize = 14;
		private Pen borderPen = new Pen(new SolidBrush(ThemeMan.AccentColor), 1);
		private Brush gripBrush;

		private Pen whitePen = new Pen(new SolidBrush(Color.White), 1);
		private Pen blackPen = new Pen(new SolidBrush(Color.Black), 1);

		private enum DragGrip
		{
			NoGrip = 0,
			BottomRight = 1,
			TopLeft = 2
		}

		private DragGrip CurGrip = DragGrip.NoGrip;
		private bool dragging = false;
		private Point dragStart;
		private Size sizeStart;
		private Point locationStart;

		private Panel picturePanel;

		public SelectionForm(Panel srcPanel, bool darkMode)
		{
			picturePanel = srcPanel;

			MinimumSize = new Size(gripSize * 2, gripSize * 2);

			whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
			blackPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
			blackPen.DashOffset = 1;

			gripBrush = new SolidBrush(darkMode ? ThemeMan.DarkPaleColor : ThemeMan.LightPaleColor);

			InitializeComponent();
		}

		public void UpdateContainerRect()
		{
			SetSize(Width, Height);
			SetLocation(
				Location.X - Owner.RectangleToScreen(picturePanel.ClientRectangle).X,
				Location.Y - Owner.RectangleToScreen(picturePanel.ClientRectangle).Y
			);
		}

		public void Select(int x, int y, int w, int h)
		{
			SetLocation(
				picturePanel.Location.X + x, 
				picturePanel.Location.Y + y
			);
			SetSize(w, h);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			// BottomRight
			DrawGrip(e.Graphics, Width - 3, Height - 3);
			e.Graphics.DrawLine(borderPen, Width - 3, Height - gripSize - 2, Width - 3, Height - 3);
			e.Graphics.DrawLine(borderPen, Width - gripSize - 2, Height - 3, Width - 3, Height - 3);

			// TopLeft
			DrawGrip(e.Graphics, 2, 2);
			e.Graphics.DrawLine(borderPen, 2, 2, gripSize + 2, 2);
			e.Graphics.DrawLine(borderPen, 2, 2, 2, gripSize + 2);

			// Frame
			e.Graphics.DrawRectangle(whitePen, new Rectangle(0, 0, Width - 1, Height - 1));
			e.Graphics.DrawRectangle(blackPen, new Rectangle(0, 0, Width - 1, Height - 1));
			e.Graphics.DrawRectangle(whitePen, new Rectangle(1, 1, Width - 3, Height - 3));
			e.Graphics.DrawRectangle(blackPen, new Rectangle(1, 1, Width - 3, Height - 3));
		}

		private void DrawGrip(Graphics g, int x, int y)
		{
			g.FillEllipse(gripBrush, x - gripSize, y - gripSize, gripSize * 2, gripSize * 2);
			g.DrawEllipse(borderPen, x - gripSize, y - gripSize, gripSize * 2, gripSize * 2);
		}

		private DragGrip CheckGrip(Point pos)
		{
			if (pos.X >= Width - gripSize && pos.Y >= Height - gripSize) return DragGrip.BottomRight;
			else if (pos.X <= gripSize && pos.Y <= gripSize) return DragGrip.TopLeft;
			else return DragGrip.NoGrip;
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				dragging = true;
				dragStart = e.Location;
				sizeStart = Size;
				locationStart = Location;
				CurGrip = CheckGrip(e.Location);
			}
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			dragging = false;
			CurGrip = DragGrip.NoGrip;
			Cursor = Cursors.Default;
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && dragging)
			{
				switch (CurGrip)
				{
					case DragGrip.NoGrip:
						SetLocation(
							Location.X + e.X - dragStart.X - Owner.PointToScreen(ClientRectangle.Location).X,
							Location.Y + e.Y - dragStart.Y - Owner.PointToScreen(ClientRectangle.Location).Y
						);
						break;
					case DragGrip.BottomRight:
						SetSize(
							sizeStart.Width + e.X - dragStart.X,
							sizeStart.Height + e.Y - dragStart.Y
						);
						break;
					case DragGrip.TopLeft:
						SetSize(
							sizeStart.Width + locationStart.X - Location.X,
							sizeStart.Height + locationStart.Y - Location.Y
						);
						SetLocation(
							Location.X + e.X - dragStart.X - Owner.PointToScreen(ClientRectangle.Location).X,
							Location.Y + e.Y - dragStart.Y - Owner.PointToScreen(ClientRectangle.Location).Y,
							true
						);
						break;
				}
			}

			switch (CheckGrip(e.Location))
			{
				case DragGrip.NoGrip:
					Cursor = Cursors.SizeAll;
					break;
				case DragGrip.BottomRight:
					Cursor = Cursors.SizeNWSE;
					break;
				case DragGrip.TopLeft:
					Cursor = Cursors.SizeNWSE;
					break;
			}
		}

		private void SetSize(int w, int h)
		{
			int curX = Location.X - Owner.PointToScreen(ClientRectangle.Location).X - picturePanel.Location.X;
			int curY = Location.Y - Owner.PointToScreen(ClientRectangle.Location).Y - picturePanel.Location.Y;

			if (w > picturePanel.Width - curX) w = picturePanel.Width - curX;
			if (h > picturePanel.Height - curY) h = picturePanel.Height - curY;

			Size = new Size(w, h);
			Refresh();
		}

		private void SetLocation(int newX, int newY, bool collapse = false)
		{
			if (newX < picturePanel.Location.X) newX = picturePanel.Location.X;
			if (newY < picturePanel.Location.Y) newY = picturePanel.Location.Y;
			if (newX > picturePanel.Location.X + picturePanel.Width - Width) 
			{
				if (collapse) SetSize(picturePanel.Width - newX + picturePanel.Location.X, Height);
				newX = picturePanel.Location.X + picturePanel.Width - Width;
			}
			if (newY > picturePanel.Location.Y + picturePanel.Height - Height)
			{
				if (collapse) SetSize(Width, picturePanel.Height - newY + picturePanel.Location.Y);
				newY = picturePanel.Location.Y + picturePanel.Height - Height;
			}

			Location = new Point(newX, newY);
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			(Owner as MainForm).MainForm_KeyDown(this, e);
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (Owner != null && (Owner as MainForm).ProcessArrowKeys(keyData)) return true;
			else return base.ProcessCmdKey(ref msg, keyData);
		}
	}
}