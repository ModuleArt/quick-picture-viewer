using QuickLibrary;
using System.Drawing;
using System.IO;

namespace QuickPictureViewerPlus
{
	public class WebpWrapper : TypeWrapper
	{
		public WebpWrapper() 
		{
			TypeName = "WEBP";
			ShowTypeOps = false;
		}

		public override FileTypeMan.OpenResult Open(string path)
		{
			try
			{
				byte[] rawWebP = File.ReadAllBytes(path);
				using (WebP webp = new WebP())
				{
					WebPDecoderOptions decoderOptions = new WebPDecoderOptions();
					decoderOptions.use_threads = 1;
					decoderOptions.alpha_dithering_strength = 100;
					return new FileTypeMan.OpenResult 
					{
						Bmp = webp.Decode(rawWebP, decoderOptions)
					};
				}
			}
			catch
			{
				return new FileTypeMan.OpenResult
				{
					ErrorMessage = TypeName + " - " + LangMan.Get("unable-open-file") + ": " + Path.GetFileName(path)
				};
			}
		}

		public static void Save(Bitmap bmp, string path)
		{
			using (WebP webp = new WebP()) webp.Save(bmp, path);
		}
	}
}
