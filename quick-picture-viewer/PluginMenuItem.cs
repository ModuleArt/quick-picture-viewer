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
			string configureText,
			bool alwaysOnTop
		)
		{
			Text = func.title.Get(Properties.Settings.Default.Language);
			dllPath = Path.Combine(PluginMan.pluginsFolder, pi.name, pi.name + ".dll");

			if (func.inputRequired)
			{
				Enabled = bmp != null;
			}
			
			ToolStripMenuItem apply = new ToolStripMenuItem(applyText);
			apply.Click += (s, e) =>
			{
				Bitmap res;
				if (pi.dllType == "cpp")
				{
					IntPtr pluginPtr = PluginMan.LoadLibrary(dllPath);
					IntPtr funcPtr = PluginMan.GetProcAddressOrdinal(pluginPtr, func.name);
					var callback = Marshal.GetDelegateForFunctionPointer<PluginMan.RunFunction>(funcPtr);
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
			DropDownItems.Add(apply);

			if (func.configurable)
			{
				ToolStripMenuItem conf = new ToolStripMenuItem(configureText + " ...");
				conf.Click += (s, e) =>
				{
					if (pi.dllType == "cpp")
					{
						IntPtr pluginPtr = PluginMan.LoadLibrary(dllPath);
						IntPtr funcPtr = PluginMan.GetProcAddressOrdinal(pluginPtr, func.name + "_conf");
						var callback = Marshal.GetDelegateForFunctionPointer<PluginMan.ConfFunction>(funcPtr);
						callback(bmp, path, darkMode, Properties.Settings.Default.Language, alwaysOnTop);
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
							Properties.Settings.Default.Language,
							alwaysOnTop
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
				DropDownItems.Add(conf);
			}

			Image = PluginMan.GetPluginIcon(pi.name, func.name, darkMode);
			if (darkMode)
			{
				DropDown.BackColor = ThemeManager.DarkSecondColor;
				apply.Image = Properties.Resources.white_check;
			}
			else
			{
				DropDown.BackColor = ThemeManager.LightSecondColor;
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
