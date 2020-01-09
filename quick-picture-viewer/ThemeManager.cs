using Microsoft.Win32;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace quick_picture_viewer
{
	class ThemeManager
	{
		public static Color MainColorDark = Color.FromArgb(23, 23, 23);
		public static Color BackColorDark = Color.FromArgb(37, 37, 37);
		public static Color SecondColorDark = Color.FromArgb(56, 56, 56);
		public static Color AccentColorDark = Color.FromArgb(73, 169, 207);

		[DllImport("uxtheme.dll", SetLastError = true, ExactSpelling = true, CharSet = CharSet.Unicode)]
		private static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

		public static void setDarkModeToControl(IntPtr handle)
		{
			SetWindowTheme(handle, "DarkMode_Explorer", null);
		}

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

		public static Color getAccentColor()
		{
			if (isWindows10())
			{
				string root = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\DWM";
				string colorcode = Registry.GetValue(root, "AccentColor", null).ToString();
				return System.Drawing.ColorTranslator.FromHtml(colorcode);
			}
			else
			{
				return Color.White;
			}
		}
	}
}
