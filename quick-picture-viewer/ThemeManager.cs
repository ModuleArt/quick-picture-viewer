using Microsoft.Win32;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace quick_picture_viewer
{
	class ThemeManager
	{
		public static Color MainColorDark = Color.Black;
		public static Color BackColorDark = Color.FromArgb(32, 32, 32);
		public static Color SecondColorDark = Color.FromArgb(51, 51, 51);
		public static Color AccentColorDark = Color.FromArgb(73, 169, 207);

		private enum WindowCompositionAttribute
		{
			WCA_UNDEFINED = 0,
			WCA_NCRENDERING_ENABLED = 1,
			WCA_NCRENDERING_POLICY = 2,
			WCA_TRANSITIONS_FORCEDISABLED = 3,
			WCA_ALLOW_NCPAINT = 4,
			WCA_CAPTION_BUTTON_BOUNDS = 5,
			WCA_NONCLIENT_RTL_LAYOUT = 6,
			WCA_FORCE_ICONIC_REPRESENTATION = 7,
			WCA_EXTENDED_FRAME_BOUNDS = 8,
			WCA_HAS_ICONIC_BITMAP = 9,
			WCA_THEME_ATTRIBUTES = 10,
			WCA_NCRENDERING_EXILED = 11,
			WCA_NCADORNMENTINFO = 12,
			WCA_EXCLUDED_FROM_LIVEPREVIEW = 13,
			WCA_VIDEO_OVERLAY_ACTIVE = 14,
			WCA_FORCE_ACTIVEWINDOW_APPEARANCE = 15,
			WCA_DISALLOW_PEEK = 16,
			WCA_CLOAK = 17,
			WCA_CLOAKED = 18,
			WCA_ACCENT_POLICY = 19,
			WCA_FREEZE_REPRESENTATION = 20,
			WCA_EVER_UNCLOAKED = 21,
			WCA_VISUAL_OWNER = 22,
			WCA_HOLOGRAPHIC = 23,
			WCA_EXCLUDED_FROM_DDA = 24,
			WCA_PASSIVEUPDATEMODE = 25,
			WCA_USEDARKMODECOLORS = 26,
			WCA_LAST = 27
		};

		private struct WindowCompositionAttribData
		{
			public WindowCompositionAttribute Attribute;
			public IntPtr Data;
			public int SizeOfData;
		}

		[DllImport("uxtheme.dll", SetLastError = true, ExactSpelling = true, CharSet = CharSet.Unicode)]
		private static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

		[DllImport("uxtheme.dll", EntryPoint = "#133", SetLastError = true, ExactSpelling = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool AllowDarkModeForWindow(IntPtr hWnd, bool allow);

		[DllImport("uxtheme.dll", EntryPoint = "#135", SetLastError = true, ExactSpelling = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool AllowDarkModeForApp(bool allow);

		[DllImport("user32.dll")]
		private static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttribData data);

		public static void enableDarkTitlebar(IntPtr handle)
		{
			bool dark = true;

			AllowDarkModeForApp(dark);
			AllowDarkModeForWindow(handle, dark);

			var sizeOfData = Marshal.SizeOf(dark);
			var dataPtr = Marshal.AllocHGlobal(sizeOfData);

			var data = new WindowCompositionAttribData
			{
				Attribute = WindowCompositionAttribute.WCA_USEDARKMODECOLORS,
				Data = dataPtr,
				SizeOfData = sizeOfData

			};
			SetWindowCompositionAttribute(handle, ref data);
		}

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
				int colorInt = Math.Abs(Convert.ToInt32(colorcode));
				return Color.FromArgb(colorInt);
			}
			else
			{
				return Color.White;
			}
		}
	}
}
