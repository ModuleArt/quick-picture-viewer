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

			ThemeManager.allowDarkModeForApp(true);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			string param;
			if(args.Length > 0)
			{
				param = args[0];
			}
			else
			{
				param = string.Empty;
			}
			Application.Run(new MainForm(param, ThemeManager.isDarkTheme()));
		}

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();
	}
}
