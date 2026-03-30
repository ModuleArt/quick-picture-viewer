using QuickLibrary;
using System.Drawing;
using System.IO;
using WebP.Net;

namespace quick_picture_viewer
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
				using (var webp = new WebPObject(rawWebP))
				{
					return new FileTypeMan.OpenResult
					{
						Bmp = new Bitmap(webp.GetImage())
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
			using (var webp = new WebPObject(bmp))
			{
				byte[] rawWebP = webp.GetWebPLossless();

				using var writer = new BinaryWriter(File.OpenWrite(path));
				writer.Write(rawWebP);
			}
		}
	}
}
