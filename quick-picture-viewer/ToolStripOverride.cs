using System;
using System.Drawing;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	public class ToolStripOverride : ToolStripSystemRenderer
	{
		//private bool darkMode;

		public ToolStripOverride(bool darkMode) 
		{
			//this.darkMode = darkMode;
		}

		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e) { }

		//protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
		//{
		//	if (darkMode)
		//	{
		//		Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
		//		Color c = e.Item.Selected ? ThemeManager.MainColorDark : ThemeManager.BackColorDark;
		//		using (SolidBrush brush = new SolidBrush(c))
		//		{
		//			e.Graphics.FillRectangle(brush, rc);
		//		}
		//	}
		//}

	}
}
