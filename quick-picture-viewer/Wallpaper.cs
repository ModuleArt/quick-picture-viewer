using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

namespace quick_picture_viewer
{
	public sealed class Wallpaper
	{
		Wallpaper() { }

		const int SPI_SETDESKWALLPAPER = 20;
		const int SPIF_UPDATEINIFILE = 0x01;
		const int SPIF_SENDWININICHANGE = 0x02;
		const int SPI_GETDESKWALLPAPER = 0x73;
		const int MAX_PATH = 260;

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

		public enum Style : int
		{
			Tile,
			Center,
			Stretch,
			Fill,
			Fit
		}

		public static void Set(Bitmap img, Style style)
		{

			string tempPath = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
			img.Save(tempPath, System.Drawing.Imaging.ImageFormat.Bmp);

			RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
			switch (style)
			{
				case Style.Tile:
					key.SetValue(@"WallpaperStyle", "0");
					key.SetValue(@"TileWallpaper", "1");
					break;
				case Style.Center:
					key.SetValue(@"WallpaperStyle", "0");
					key.SetValue(@"TileWallpaper", "0");
					break;
				case Style.Stretch:
					key.SetValue(@"WallpaperStyle", "2");
					key.SetValue(@"TileWallpaper", "0");
					break;
				case Style.Fit:
					key.SetValue(@"WallpaperStyle", "6");
					key.SetValue(@"TileWallpaper", "0");
					break;
				case Style.Fill:
					key.SetValue(@"WallpaperStyle", "10");
					key.SetValue(@"TileWallpaper", "0");
					break;
			}

			SystemParametersInfo(SPI_SETDESKWALLPAPER,
				0,
				tempPath,
				SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
		}

		public static string Get()
        {
            string currentWallpaper = new string('\0', MAX_PATH);
            SystemParametersInfo(SPI_GETDESKWALLPAPER, currentWallpaper.Length, currentWallpaper, 0);
            return currentWallpaper.Substring(0, currentWallpaper.IndexOf('\0'));
        }

}
}
