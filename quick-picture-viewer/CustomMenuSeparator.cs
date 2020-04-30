using System.Windows.Forms;
using System.Drawing;

namespace quick_picture_viewer
{
	class CustomMenuSeparator : ToolStripSeparator
	{
		public CustomMenuSeparator() {  }

		protected override void OnPaint(PaintEventArgs e)
		{
			int y = e.ClipRectangle.Y + (e.ClipRectangle.Height / 2) - 1;
			e.Graphics.DrawLine(new Pen(Brushes.Gray), e.ClipRectangle.X + 4, y, e.ClipRectangle.Width - 5, y);
		}
	}
}
