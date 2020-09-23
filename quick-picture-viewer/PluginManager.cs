using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace quick_picture_viewer
{
	class PluginManager
	{
		[DllImport("kernel32", SetLastError = true, CharSet = CharSet.Ansi)]
		public static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)]string lpFileName);

		[DllImport("kernel32", SetLastError = true, EntryPoint = "GetProcAddress")]
		public static extern IntPtr GetProcAddressOrdinal(IntPtr hModule, string procName);

		public delegate Bitmap RunFunction(
			Bitmap bmp = null,
			string path = null,
			string[] args = null
		);

		public delegate string[] ConfFunction(
			Bitmap bmp = null,
			string path = null,
			bool darkMode = false,
			string language = "en"
		);

		public delegate void PluginOutput(object sender, OutputEventArgs oea);

		public static PluginInfo[] GetPlugins(bool onlyAvailable)
		{
			List<PluginInfo> plugins = new List<PluginInfo>();
			DirectoryInfo di = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "plugins"));

			List<FileInfo> files = new List<FileInfo>();
			DirectoryInfo[] dirs = di.GetDirectories();
			for (int i = 0; i < dirs.Length; i++)
			{
				files.AddRange(dirs[i].GetFiles());
			}

			for (int i = 0; i < files.Count; i++)
			{
				if (Path.GetExtension(files[i].Name) == ".json")
				{
					string ver = Assembly.GetExecutingAssembly().GetName().Version.ToString();
					int lastDotIndex = ver.LastIndexOf('.');
					ver = ver.Substring(0, lastDotIndex);

					PluginInfo pi = PluginInfo.FromJson(File.ReadAllText(Path.Combine(di.FullName, files[i].DirectoryName, files[i].Name)));

					if (onlyAvailable)
					{
						for (int j = 0; j < pi.targets.Length; j++)
						{
							if (pi.targets[j].name == "quick-picture-viewer" && ver.CompareTo(pi.targets[j].minVersion) >= 0)
							{
								if (pi.targets[j].maxVersion == null || pi.targets[j].maxVersion == "" || ver.CompareTo(pi.targets[j].maxVersion) <= 0)
								{
									plugins.Add(pi);
									break;
								}
							}
						}
					}
					else
					{
						plugins.Add(pi);
					}
				}
			}
			return plugins.ToArray();
		}

		public static Image GetPluginIcon(string pluginName, string funcName, bool darkMode)
		{
			if (darkMode)
			{
				string path = Path.Combine(Directory.GetCurrentDirectory(), "plugins", pluginName, funcName + ".dark.png");
				if (File.Exists(path))
				{
					return Bitmap.FromFile(path);
				}

				path = Path.Combine(Directory.GetCurrentDirectory(), "plugins", pluginName, funcName + ".png");
				if (File.Exists(path))
				{
					return Bitmap.FromFile(path);
				}

				return null;
			}
			else
			{
				string path = Path.Combine(Directory.GetCurrentDirectory(), "plugins", pluginName, funcName + ".light.png");
				if (File.Exists(path))
				{
					return Bitmap.FromFile(path);
				}

				path = Path.Combine(Directory.GetCurrentDirectory(), "plugins", pluginName, funcName + ".png");
				if (File.Exists(path))
				{
					return Bitmap.FromFile(path);
				}

				return null;
			}
		}
	}
}
