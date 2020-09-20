using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	class PluginMenuItem : ToolStripMenuItem
	{
		private string dllPath;

		public PluginMenuItem(Bitmap bmp, string path, bool darkMode, PluginInfo pi, PluginInfo.Function func)
		{
			this.Text = func.title.Get(Properties.Settings.Default.Language);
			this.dllPath = Path.Combine(Directory.GetCurrentDirectory(), "plugins", pi.name, pi.name + ".dll");
			//this.Enabled = enabled;

			ToolStripMenuItem apply = new ToolStripMenuItem("Apply");
			apply.Click += (s, e) =>
			{
				Bitmap res;
				if (pi.dllType == "cpp")
				{
					IntPtr pluginPtr = PluginManager.LoadLibrary(dllPath);
					IntPtr funcPtr = PluginManager.GetProcAddressOrdinal(pluginPtr, func.name);
					var callback = Marshal.GetDelegateForFunctionPointer<PluginManager.RunFunction>(funcPtr);
					res = callback(bmp, path);
				}
				else if (pi.dllType == "cs")
				{
					Assembly assembly = Assembly.LoadFrom(dllPath);
					Type type = assembly.GetType(Path.GetFileNameWithoutExtension(dllPath).Replace("-", "_") + ".Main");
					object instance = Activator.CreateInstance(type);
					res = type.GetMethod(func.name).Invoke(instance, new object[] {
						bmp,
						path
					}) as Bitmap;

					OutputEventArgs oea = new OutputEventArgs
					{
						Bitmap = res
					};
					OnOutput(oea);
				}
			};
			this.DropDownItems.Add(apply);

			if (func.props.configurable)
			{
				ToolStripMenuItem conf = new ToolStripMenuItem("Configure ...");
				conf.Click += (s, e) =>
				{
					if (pi.dllType == "cpp")
					{
						IntPtr pluginPtr = PluginManager.LoadLibrary(dllPath);
						IntPtr funcPtr = PluginManager.GetProcAddressOrdinal(pluginPtr, func.name + "_conf");
						var callback = Marshal.GetDelegateForFunctionPointer<PluginManager.ConfFunction>(funcPtr);
						callback(bmp, path, darkMode, Properties.Settings.Default.Language);
					}
					else if (pi.dllType == "cs")
					{
						Assembly assembly = Assembly.LoadFrom(dllPath);
						Type type = assembly.GetType(Path.GetFileNameWithoutExtension(dllPath).Replace("-", "_") + ".Main");
						object instance = Activator.CreateInstance(type);
						type.GetMethod(func.name + "_conf").Invoke(instance, new object[] {
							bmp,
							path,
							darkMode,
							Properties.Settings.Default.Language
						});
					}
				};
				this.DropDownItems.Add(conf);
			}

			if (darkMode)
			{
				this.Image = Bitmap.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "plugins", pi.name, func.name + ".dark.png"));
			}
			else
			{
				this.Image = Bitmap.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "plugins", pi.name, func.name + ".light.png"));
			}
		}

		protected virtual void OnOutput(OutputEventArgs e)
		{
			Output?.Invoke(this, e);
		}
		public event EventHandler<OutputEventArgs> Output;
	}

	public class OutputEventArgs : EventArgs
	{
		public Bitmap Bitmap { get; set; }
	}
}
