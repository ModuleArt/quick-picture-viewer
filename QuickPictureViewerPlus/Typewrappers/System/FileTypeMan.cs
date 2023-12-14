using System.Drawing;
using System.IO;

namespace QuickPictureViewerPlus
{
	public static class FileTypeMan
	{
		public class OpenResult
		{
			public string ErrorMessage { get; set; }
			public string TypeName { get; set; }
			public Bitmap Bmp { get; set; }
			public bool ShowTypeOps { get; set; }
		}

		public static OpenResult Open(string path, string targetExtension = null)
		{
			TypeWrapper tw;
			switch (targetExtension != null ? targetExtension : Path.GetExtension(path).ToLower())
			{
				case ".webp":
					tw = new WebpWrapper();
					break;
				case ".svg":
					tw = new SvgWrapper();
					break;
				case ".psd":
					tw = new PsdWrapper();
					break;
				case ".ico":
					tw = new IcoWrapper();
					break;
				case ".cr2":
					tw = new Cr2Wrapper();
					break;
				case ".dds":
				case ".tga":
					tw = new DdsTgaWrapper();
					break;
				default:
					tw = new BitmapWrapper();
					break;
			}
			OpenResult res = tw.Open(path);
			if (string.IsNullOrEmpty(res.ErrorMessage)) return new OpenResult
			{
				ErrorMessage = null,
				TypeName = tw.TypeName,
				Bmp = res.Bmp,
				ShowTypeOps = tw.ShowTypeOps
			};
			else return new OpenResult
			{
				ErrorMessage = res.ErrorMessage,
				TypeName = tw.TypeName,
				Bmp = null,
				ShowTypeOps = false
			};
		}

		public static void Save(Bitmap bmp, string path, string format)
		{

		}
	}
}
