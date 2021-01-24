using SimplePsd;
using System.Drawing;

namespace quick_picture_viewer
{
	public static class PsdWrapper
	{
		public static string TypeName = "PSD";
		public static Error CurrentError = 0;
		public enum Error
		{
			NoError = 0,
			UnableToOpen = 1
		}

		public static Bitmap ParsePsd(string path)
		{
			try
			{
				CPSD psd = new CPSD();
				int nResult = psd.Load(path);
				switch (nResult)
				{
					case -1:
						CurrentError = Error.UnableToOpen;
						return null;
					default:
						CurrentError = Error.NoError;
						return Image.FromHbitmap(psd.GetHBitmap());
				}
			}
			catch
			{
				CurrentError = Error.UnableToOpen;
				return null;
			}
		}
	}
}
