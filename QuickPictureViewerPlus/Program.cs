using QuickLibrary;
using System;
using System.Windows.Forms;

namespace QuickPictureViewerPlus
{
	internal static class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
            ApplicationConfiguration.Initialize();

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
