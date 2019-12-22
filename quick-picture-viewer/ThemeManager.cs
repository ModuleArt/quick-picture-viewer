using Microsoft.Win32;
using System.Drawing;

namespace quick_picture_viewer
{
	class ThemeManager
	{
		public static bool isDarkTheme()
		{
			if (isWindows10())
			{
				string root = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize";
				string str = Registry.GetValue(root, "AppsUseLightTheme", null).ToString();
				return (str == "0");
			}
			else
			{
				return false;
			}
		}

		public static bool isWindows10()
		{
			var reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
			string productName = (string)reg.GetValue("ProductName");
			return productName.StartsWith("Windows 10");
		}

		public static Color getColorizationColor()
		{
			if (isWindows10())
			{
				string root = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\DWM";
				string colorcode = Registry.GetValue(root, "ColorizationColor", null).ToString();
				return System.Drawing.ColorTranslator.FromHtml(colorcode);
			}
			else
			{
				return Color.Blue;
			}
		}
	}
}
