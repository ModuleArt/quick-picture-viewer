using QuickLibrary;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace QuickPictureViewerPlus
{
	public class DdsTgaWrapper : TypeWrapper
	{
		private static GCHandle TmpGcHandle;

		public DdsTgaWrapper()
		{
			TypeName = "DDS/TGA";
			ShowTypeOps = false;
		}

		public override FileTypeMan.OpenResult Open(string path)
		{
			try
			{
				using (var image = Pfim.Pfimage.FromFile(path))
				{
					PixelFormat format;

					switch (image.Format)
					{
						case Pfim.ImageFormat.Rgba32:
							format = PixelFormat.Format32bppArgb;
							break;
						case Pfim.ImageFormat.Rgb24:
							format = PixelFormat.Format24bppRgb;
							break;
						case Pfim.ImageFormat.Rgba16:
							format = PixelFormat.Format16bppArgb1555;
							break;
						case Pfim.ImageFormat.Rgb8:
							format = PixelFormat.Format8bppIndexed;
							break;
						default:
							return new FileTypeMan.OpenResult
							{
								ErrorMessage = TypeName + " - " + LangMan.Get("unsupported-pixel-format") + ": " + Path.GetFileName(path)
							};
					}

					try
					{
						if (TmpGcHandle != null && TmpGcHandle.IsAllocated) TmpGcHandle.Free();
						TmpGcHandle = GCHandle.Alloc(image.Data, GCHandleType.Pinned);
						var data = Marshal.UnsafeAddrOfPinnedArrayElement(image.Data, 0);

						return new FileTypeMan.OpenResult
						{
							Bmp = new Bitmap(image.Width, image.Height, image.Stride, format, data)
						};
					}
					catch
					{
						return new FileTypeMan.OpenResult
						{
							ErrorMessage = TypeName + " - " + LangMan.Get("memory-error") + ": " + Path.GetFileName(path)
						};
					}
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
