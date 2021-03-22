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
			NativeMan.SetProcessDpiAwarenessContext(NativeMan.DPI_AWARENESS_CONTEXT.DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			string param;
			if (args.Length > 0) param = args[0] == "-1" ? string.Empty : args[0];
			else param = string.Empty;

			if (Properties.Settings.Default.CallUpgrade)
			{
				Properties.Settings.Default.Upgrade();
				Properties.Settings.Default.CallUpgrade = false;
				Properties.Settings.Default.Save();
			}

			bool darkMode;
			int theme = Properties.Settings.Default.Theme;
			if (theme == 0) darkMode = ThemeMan.isDarkTheme();
			else if (theme == 1) darkMode = false;
			else darkMode = true;

			if (darkMode) ThemeMan.AllowAppDarkMode(true);

			Application.Run(new MainForm(param, darkMode));
		}
	}
}
