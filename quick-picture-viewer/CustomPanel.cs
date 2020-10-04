using System.Windows.Forms;

namespace quick_picture_viewer
{
	class CustomPanel : Panel
	{
		public CustomPanel() {  }

		protected override void OnMouseWheel(MouseEventArgs e)
		{
			if (this.VScroll && (Control.ModifierKeys & Keys.Shift) == Keys.Shift && Properties.Settings.Default.MouseWheelScrollAction == 0)
			{
				this.VScroll = false;
				base.OnMouseWheel(e);
				this.VScroll = true;
			}
			else if (
				(this.VScroll && (Control.ModifierKeys & Keys.Control) == Keys.Control) || 
				Properties.Settings.Default.MouseWheelScrollAction == 1 ||
				Properties.Settings.Default.MouseWheelScrollAction == 2
			)
			{
				this.VScroll = false;
				this.HScroll = false;
				base.OnMouseWheel(e);
				this.VScroll = true;
				this.HScroll = true;
			}
			else
			{
				base.OnMouseWheel(e);
			}
		}
	}
}
