using QuickLibrary;
using System.Drawing;
using System.IO;

namespace QuickPictureViewerPlus
{
	public class IcoWrapper : TypeWrapper
	{
		public IcoWrapper()
		{
			TypeName = "ICO";
			ShowTypeOps = false;
		}

		public override FileTypeMan.OpenResult Open(string path)
		{
			try
			{
				return new FileTypeMan.OpenResult
				{
					Bmp = new Icon(path, 128, 128).ToBitmap()
				};
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
