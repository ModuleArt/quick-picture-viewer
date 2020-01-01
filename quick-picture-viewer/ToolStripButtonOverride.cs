using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	public class ToolStripButtonOverride : ToolStripButton
	{
		public ToolStripButtonOverride() 
		{
			this.EnabledChanged += new EventHandler(enabledChanged);
		}

		private void enabledChanged(object sender, EventArgs e)
		{
			Console.WriteLine("a");
			if (this.Enabled)
			{

			}
			else
			{
				this.Image = AdjustAlpha(this.Image, 0.25f);
			}
		}
	}
}
