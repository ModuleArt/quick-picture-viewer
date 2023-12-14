using QuickLibrary;
using SimplePsd;
using System.Drawing;
using System.IO;

namespace QuickPictureViewerPlus
{
	public class PsdWrapper : TypeWrapper
	{
		public PsdWrapper()
		{
			TypeName = "PSD";
			ShowTypeOps = false;
		}

		public override FileTypeMan.OpenResult Open(string path)
		{
			try
			{
				CPSD psd = new CPSD();
				int nResult = psd.Load(path);
				switch (nResult)
				{
					case -1:
						return new FileTypeMan.OpenResult
						{
							ErrorMessage = TypeName + " - " + LangMan.Get("unable-open-file") + ": " + Path.GetFileName(path)
						};
					default:
						return new FileTypeMan.OpenResult
						{
							Bmp = Image.FromHbitmap(psd.GetHBitmap())
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
	}
}
