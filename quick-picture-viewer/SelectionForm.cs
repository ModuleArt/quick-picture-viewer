using QuickLibrary;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	public partial class SelectionForm : Form
	{
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		[DllImport("user32.dll", SetLastError = true)]
		internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

		[DllImport("user32.dll", SetLastError = true)]
		static extern UInt32 GetWindowLong(IntPtr hWnd, int nIndex);

		[DllImport("user32.dll")]
		static extern int SetWindowLong(IntPtr hWnd, int nIndex, UInt32 dwNewLong);


		//private Size ContainerSize;
		//private Point ContainerLocation;

		private int gripSize = 12;
		private Pen borderPen = new Pen(new SolidBrush(ThemeMan.AccentColor), 1);
		private Brush gripBrush;

		private Pen whitePen = new Pen(new SolidBrush(Color.White), 1);
		private Pen blackPen = new Pen(new SolidBrush(Color.Black), 1);

		private enum DragGrip
		{
			NoGrip = 0,
			BottomRight = 1
			//TopRight = 2
		}

		private DragGrip CurGrip = DragGrip.NoGrip;
		private bool dragging = false;
		private Point dragStart;
		private Size sizeStart;

		public SelectionForm(bool darkMode)
		{
			whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
			blackPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
			blackPen.DashOffset = 1;

			gripBrush = new SolidBrush(darkMode ? ThemeMan.DarkPaleColor : ThemeMan.LightPaleColor);

			InitializeComponent();
		}

		public void UpdateContainerRect(int x, int y, int w, int h)
		{
			//ContainerLocation = new Point(x, y);
			SetLocation(x, y);
			//ContainerSize = s;
			SetSize(w, h);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			e.Graphics.DrawRectangle(whitePen, new Rectangle(0, 0, Width - 1, Height - 1));			
			e.Graphics.DrawRectangle(blackPen, new Rectangle(0, 0, Width - 1, Height - 1));

			e.Graphics.DrawRectangle(whitePen, new Rectangle(1, 1, Width - 3, Height - 3));
			e.Graphics.DrawRectangle(blackPen, new Rectangle(1, 1, Width - 3, Height - 3));

			e.Graphics.FillRectangle(gripBrush, Width - gripSize - 1, Height - gripSize - 1, gripSize, gripSize);
			e.Graphics.DrawRectangle(borderPen, Width - gripSize - 1, Height - gripSize - 1, gripSize, gripSize);

			//e.Graphics.FillRectangle(gripBrush, Width - gripSize - 1, 0, gripSize, gripSize);
			//e.Graphics.DrawRectangle(borderPen, Width - gripSize - 1, 0, gripSize, gripSize);
		}

		private DragGrip CheckGrip(Point pos)
		{
			if (pos.X >= Width - gripSize && pos.Y >= Height - gripSize)
			{
				return DragGrip.BottomRight;
			}
			//else if (pos.X >= Width - gripSize && pos.Y <= gripSize)
			//{
			//	return DragGrip.TopRight;
			//}
			else
			{
				return DragGrip.NoGrip;
			}
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			dragging = true;
			dragStart = e.Location;
			sizeStart = Size;
			CurGrip = CheckGrip(e.Location);
			if (CurGrip == DragGrip.NoGrip)
			{
				NativeMan.DragWindow(Handle);
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
			if (dragging)
			{
				switch (CurGrip)
				{
					case DragGrip.NoGrip:
						//SetLocation(e.X + Location.X - dragStart.X, e.Y + Location.Y - dragStart.Y);
						break;
					case DragGrip.BottomRight:
						SetSize(sizeStart.Width + e.X - dragStart.X, sizeStart.Height + e.Y - dragStart.Y);
						break;
					//case DragGrip.TopRight:
					//	SetLocation(0, e.Y);
					//	break;
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
				//case DragGrip.TopRight:
				//	Cursor = Cursors.SizeNESW;
				//	break;
			}
		}

		private void SetSize(int w, int h)
		{
			//if (w > ContainerSize.Width - ContainerLocation.X)
			//{
			//	w = ContainerSize.Width - ContainerLocation.X;
			//}
			//if (h > ContainerSize.Height - ContainerLocation.Y)
			//{
			//	h = ContainerSize.Height - ContainerLocation.Y;
			//}
			Size = new Size(w, h);
			Refresh();
		}

		private void SetLocation(int x, int y)
		{
			//if (x > ContainerLocation.X + ContainerSize.Width - MinimumSize.Width)
			//{
			//	x = ContainerLocation.X + ContainerSize.Width - MinimumSize.Width;
			//}
			//if (y > ContainerLocation.Y + ContainerSize.Height - MinimumSize.Height)
			//{
			//	y = ContainerLocation.Y + ContainerSize.Height - MinimumSize.Height;
			//}
			Location = new Point(Owner.ClientRectangle.Location.X + x, ClientRectangle.Location.Y + y);
		}
	}
}
