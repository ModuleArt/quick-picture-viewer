using QuickLibrary;
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

		public PluginMenuItem(
			Bitmap bmp, 
			string path, 
			bool darkMode, 
			PluginInfo pi, 
			PluginInfo.Function func,
			string applyText,
			string configureText
		)
		{
			this.Text = func.title.Get(Properties.Settings.Default.Language);
			this.dllPath = Path.Combine(PluginManager.pluginsFolder, pi.name, pi.name + ".dll");

			if (func.props.imageRequired)
			{
				this.Enabled = bmp != null;
			}
			
			ToolStripMenuItem apply = new ToolStripMenuItem(applyText);
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
				ToolStripMenuItem conf = new ToolStripMenuItem(configureText + " ...");
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
				if (darkMode)
				{
					conf.Image = Properties.Resources.white_options;
				}
				else
				{
					conf.Image = Properties.Resources.black_options;
				}
				this.DropDownItems.Add(conf);
			}

			this.Image = PluginManager.GetPluginIcon(pi.name, func.name, darkMode);
			if (darkMode)
			{
				this.DropDown.BackColor = ThemeManager.DarkSecondColor;
				apply.Image = Properties.Resources.white_check;
			}
			else
			{
				this.DropDown.BackColor = ThemeManager.LightSecondColor;
				apply.Image = Properties.Resources.black_check;
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
