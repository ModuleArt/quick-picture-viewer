using QuickLibrary;
using System.Drawing;
using System.IO;

namespace quick_picture_viewer
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
				using (var ms = new MemoryStream(File.ReadAllBytes(path)))
				using (var tmp = new Bitmap(ms))
				{
					return new FileTypeMan.OpenResult
					{
						Bmp = new Bitmap(tmp)
					};
				}
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
