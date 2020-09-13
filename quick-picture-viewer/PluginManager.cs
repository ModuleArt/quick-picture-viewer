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

		public delegate void RunFunction(
			Bitmap bmp = null, 
			string path = null, 
			bool darkMode = false, 
			string language = "en"
		);

		public static PluginInfo[] GetPlugins()
		{
			List<PluginInfo> plugins = new List<PluginInfo>();
			DirectoryInfo di = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "plugins"));
			FileInfo[] dlls = di.GetFiles();
			for (int i = 0; i < dlls.Length; i++)
			{
				if (Path.GetExtension(dlls[i].Name) == ".json")
				{
					string ver = Assembly.GetExecutingAssembly().GetName().Version.ToString();
					int lastDotIndex = ver.LastIndexOf('.');
					ver = ver.Substring(0, lastDotIndex);

					PluginInfo pi = PluginInfo.FromJson(File.ReadAllText(Path.Combine(di.FullName, dlls[i].Name)));

					if (pi.targets[0])

					plugins.Add();
				}
			}
			return plugins.ToArray();
		}
	}
}
