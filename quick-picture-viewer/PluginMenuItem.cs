using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	class PluginMenuItem : ToolStripMenuItem
	{
		public string dllPath;
		public string funcName;

		public PluginMenuItem(string text, string pluginName, string funcName, bool enabled, bool darkMode)
		{
			this.Text = text;
			this.dllPath = Path.Combine(Directory.GetCurrentDirectory(), "plugins", pluginName + ".dll");
			this.funcName = funcName;
			this.Enabled = enabled;

			if (darkMode)
			{
				this.Image = Bitmap.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "plugins", pluginName, funcName + ".dark.png"));
			}
			else
			{
				this.Image = Bitmap.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "plugins", pluginName, funcName + ".light.png"));
			}
		}
	}
}
