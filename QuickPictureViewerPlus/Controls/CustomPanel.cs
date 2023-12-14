using System.Windows.Forms;

namespace QuickPictureViewerPlus
{
	class CustomPanel : Panel
	{
		public CustomPanel() { }

		protected override void OnMouseWheel(MouseEventArgs e)
		{
			if (VScroll && (ModifierKeys & Keys.Shift) == Keys.Shift && Properties.Settings.Default.MouseWheelScrollAction == 0)
			{
				VScroll = false;
				base.OnMouseWheel(e);
				VScroll = true;
			}
			else if (
				(VScroll && (ModifierKeys & Keys.Control) == Keys.Control) || 
				Properties.Settings.Default.MouseWheelScrollAction == 1 ||
				Properties.Settings.Default.MouseWheelScrollAction == 2
			)
			{
				VScroll = false;
				HScroll = false;
				base.OnMouseWheel(e);
				VScroll = true;
				HScroll = true;
			}
			else
			{
				base.OnMouseWheel(e);
			}
		}
	}
}
