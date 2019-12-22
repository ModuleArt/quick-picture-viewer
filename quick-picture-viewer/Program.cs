using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	static class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			if (Environment.OSVersion.Version.Major >= 6) { 
				SetProcessDPIAware(); 
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if(args.Length > 0)
			{
				Application.Run(new MainForm(args[0]));
			}
			else
			{
				Application.Run(new MainForm(string.Empty));
			}
		}

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();
	}
}
