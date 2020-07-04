using QuickLibrary;
using System;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	static class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			if (Environment.OSVersion.Version.Major >= 6)
			{
				SetProcessDPIAware();
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			string param;
			if (args.Length > 0)
			{
				if (args[0] == "-1")
				{
					param = string.Empty;
				}
				else
				{
					param = args[0];
				}
			}
			else
			{
				param = string.Empty;
			}

			bool darkMode;
			int theme = Properties.Settings.Default.Theme;
			if (theme == 0)
			{
				darkMode = ThemeManager.isDarkTheme();
			}
			else if (theme == 1)
			{
				darkMode = false;
			}
			else
			{
				darkMode = true;
			}

			if (darkMode)
			{
				ThemeManager.allowDarkModeForApp(true);
			}

			Application.Run(new MainForm(param, darkMode));
		}

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();
	}
}
