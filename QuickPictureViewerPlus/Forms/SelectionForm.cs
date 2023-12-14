using QuickLibrary;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QuickPictureViewerPlus
{
	public partial class SelectionForm : Form
	{
		private int gripSize = 12;
		private Pen borderPen = new Pen(new SolidBrush(ThemeMan.AccentColor), 1);
		private Brush gripBrush;

		private Pen whitePen = new Pen(new SolidBrush(Color.White), 1);
		private Pen blackPen = new Pen(new SolidBrush(Color.Black), 1);

		private enum DragGrip
		{
			NoGrip = 0,
			BottomRight = 1,
			TopLeft = 2,
			Center = 3
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

			MinimumSize = new Size(gripSize * 4, gripSize * 4);

			whitePen.DashStyle = DashStyle.Dot;
			blackPen.DashStyle = DashStyle.Dot;
			blackPen.DashOffset = 1;

			InitializeComponent();

			gripBrush = new SolidBrush(darkMode ? ThemeMan.DarkPaleColor : ThemeMan.LightPaleColor);
			selectionMenu.DarkMode = darkMode;

			cutBtn.Text = LangMan.Get("cut");
			cropBtn.Text = LangMan.Get("crop");
			selectionCopyBtn.Text = LangMan.Get("copy");
			selectionSelectAllBtn.Text = LangMan.Get("select-all");
			editSelectionBtn.Text = LangMan.Get("edit-selection") + " ...";

			if (darkMode)
			{
				cutBtn.Image = Properties.Resources.white_cut;
				cropBtn.Image = Properties.Resources.white_crop;
				selectionCopyBtn.Image = Properties.Resources.white_copy;
				selectionSelectAllBtn.Image = Properties.Resources.white_selectall;
				editSelectionBtn.Image = Properties.Resources.white_editsel;
			}
		}

		public void ShowContextMenu(Point p)
		{
			selectionMenu.Show(p);
		}

		public void UpdateContainerRect()
		{
			SetSize(Width, Height);
			Point curLoc = GetCurLoc();
			SetLocation(curLoc.X, curLoc.Y);
		}

		private Point GetCurLoc()
		{
			return new Point(
				Location.X - Owner.RectangleToScreen(picturePanel.ClientRectangle).X,
				Location.Y - Owner.RectangleToScreen(picturePanel.ClientRectangle).Y
			);
		}

		public void Select(int x, int y, int w, int h)
		{
			SetLocation(picturePanel.Location.X + x, picturePanel.Location.Y + y);
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

			// Center
			DrawGrip(e.Graphics, Width / 2, Height / 2);

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
			if (pos.X >= Width - gripSize - 3 && pos.Y >= Height - gripSize - 3) return DragGrip.BottomRight;
			else if (pos.X <= gripSize + 2 && pos.Y <= gripSize + 2) return DragGrip.TopLeft;
			else if (
				pos.X >= (Width / 2) - gripSize && pos.X <= (Width / 2) + gripSize &&
				pos.Y >= (Height / 2) - gripSize && pos.Y <= (Height / 2) + gripSize
			) return DragGrip.Center;
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
					case DragGrip.Center:
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
						Point curLoc = GetCurLoc();
						int maxX = curLoc.X + Width - MinimumSize.Width;
						int maxY = curLoc.Y + Height - MinimumSize.Height;
						int x = Location.X + e.X - dragStart.X - Owner.PointToScreen(ClientRectangle.Location).X;
						int y = Location.Y + e.Y - dragStart.Y - Owner.PointToScreen(ClientRectangle.Location).Y;
						if (x > maxX) x = maxX;
						if (y > maxY) y = maxY;
						SetLocation(x, y, true);
						break;
				}
			}

			switch (CheckGrip(e.Location))
			{
				case DragGrip.Center:
					Cursor = Cursors.SizeAll;
					break;
				case DragGrip.BottomRight:
					Cursor = Cursors.SizeNWSE;
					break;
				case DragGrip.TopLeft:
					Cursor = Cursors.SizeNWSE;
					break;
				case DragGrip.NoGrip:
					Cursor = Cursors.Default;
					break;
			}
		}

		private void SetSize(int w, int h)
		{
			int curX = Location.X - Owner.PointToScreen(ClientRectangle.Location).X - picturePanel.Location.X;
			int curY = Location.Y - Owner.PointToScreen(ClientRectangle.Location).Y - picturePanel.Location.Y;

			if (w > picturePanel.Width - curX) w = picturePanel.Width - curX;
			if (h > picturePanel.Height - curY) h = picturePanel.Height - curY;

			if (w > picturePanel.Width) w = picturePanel.Width;
			if (h > picturePanel.Height) h = picturePanel.Height;

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
			Point curLoc = GetCurLoc();
			if (keyData == Keys.Left)
			{
				SetLocation(curLoc.X - 1, curLoc.Y);
				return true;
			}
			else if (keyData == Keys.Right)
			{
				SetLocation(curLoc.X + 1, curLoc.Y);
				return true;
			}
			else if (keyData == Keys.Down)
			{
				SetLocation(curLoc.X, curLoc.Y + 1);
				return true;
			}
			else if (keyData == Keys.Up)
			{
				SetLocation(curLoc.X, curLoc.Y - 1);
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void selectionCopyBtn_Click(object sender, EventArgs e)
		{
			if (Owner != null) (Owner as MainForm).CopySelection();
		}

		private void selectionSelectAllBtn_Click(object sender, EventArgs e)
		{
			if (Owner != null) (Owner as MainForm).selectAllBtn_Click(sender, e);
		}

		private void cropBtn_Click(object sender, EventArgs e)
		{
			if (Owner != null) (Owner as MainForm).cropBtn_Click(sender, e);
		}

		private void editSelectionBtn_Click(object sender, EventArgs e)
		{
			if (Owner != null) (Owner as MainForm).selectionLabel_Click(sender, e);
		}

		private void cutBtn_Click(object sender, EventArgs e)
		{
			if (Owner != null) (Owner as MainForm).CutSelection();
		}
	}
}