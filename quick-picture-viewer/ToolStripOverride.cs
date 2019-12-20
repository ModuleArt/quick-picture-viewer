using System.Windows.Forms;

namespace quick_picture_viewer
{
	public class ToolStripOverride : ToolStripSystemRenderer
	{
		public ToolStripOverride() { }

		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e) { }
	}
}
