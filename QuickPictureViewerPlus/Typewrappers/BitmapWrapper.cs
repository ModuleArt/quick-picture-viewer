using QuickLibrary;
using System.Drawing;
using System.IO;

namespace QuickPictureViewerPlus
{
	public class BitmapWrapper : TypeWrapper
	{
		public BitmapWrapper() 
		{
			ShowTypeOps = false;
		}

		public override FileTypeMan.OpenResult Open(string path)
		{
			try
			{
				return new FileTypeMan.OpenResult
				{
					Bmp = new Bitmap(path)
				};
			}
			catch
			{
				return new FileTypeMan.OpenResult
				{
					ErrorMessage = LangMan.Get("unable-open-file") + ": " + Path.GetFileName(path)
				};
			}
		}
	}
}
