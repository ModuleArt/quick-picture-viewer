using System;
using System.Drawing;
using System.IO;

namespace quick_picture_viewer
{
	public static class WebpWrapper
	{
		public static string TypeName = "WEBP";
		public static Error CurrentError = 0;
		public enum Error : int
		{
			NoError,
			UnableToOpen
			//UnableToLoadLibrary
		}

		public static Bitmap ParseWebp(string path)
		{
			try
			{
				byte[] rawWebP = File.ReadAllBytes(path);
				using (WebP webp = new WebP())
				{
					WebPDecoderOptions decoderOptions = new WebPDecoderOptions();
					decoderOptions.use_threads = 1;
					decoderOptions.alpha_dithering_strength = 100;
					CurrentError = Error.NoError;
					return webp.Decode(rawWebP, decoderOptions);
				}
			}
			catch (Exception ex)
			{
				CurrentError = Error.UnableToOpen;
				Console.WriteLine(ex.Message);
				return null;
			}
		}

		public static void Save(Bitmap bmp, string path)
		{
			using (WebP webp = new WebP()) webp.Save(bmp, path);
		}
	}
}
