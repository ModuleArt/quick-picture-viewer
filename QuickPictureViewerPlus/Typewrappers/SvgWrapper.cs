using QuickLibrary;
using Svg;
using System;
using System.Drawing;
using System.IO;

namespace QuickPictureViewerPlus
{
	public class SvgWrapper : TypeWrapper
	{
		public SvgWrapper() 
		{
			TypeName = "SVG";
			ShowTypeOps = true;
		}

		public override FileTypeMan.OpenResult Open(string path)
		{
			Bitmap bmp = ParseSvg(path);
			if (bmp != null) return new FileTypeMan.OpenResult
			{
				Bmp = bmp
			};
			else return new FileTypeMan.OpenResult
			{
				ErrorMessage = TypeName + " - " + LangMan.Get("unable-open-file") + ": " + Path.GetFileName(path)
			};
		}

		public static FileTypeMan.OpenResult CustomSizeOpen(string path, int Width = -1, int Height = -1)
		{
			Bitmap bmp = ParseSvg(path, Width, Height);
			if (bmp != null) return new FileTypeMan.OpenResult
			{
				Bmp = bmp
			};
			else return new FileTypeMan.OpenResult
			{
				ErrorMessage = "SVG - " + LangMan.Get("unable-open-file") + ": " + Path.GetFileName(path)
			};
		}

		private static Bitmap ParseSvg(string path, int Width = -1, int Height = -1)
		{
			try
			{
				SvgDocument svgDocument = SvgDocument.Open(path);
				svgDocument.ShapeRendering = SvgShapeRendering.Auto;

				if (Width == -1 && Height == -1)
				{
					Width = Convert.ToInt32(svgDocument.Width.Value);
					Height = Convert.ToInt32(svgDocument.Height.Value);
					float ratio = (float)Width / (float)Height;

					if (Width < 64)
					{
						Width = 64;
						Height = (int)(Width / ratio);
					}

					if (Height < 64)
					{
						Height = 64;
						Width = (int)(Height * ratio);
					}
				}
				return svgDocument.Draw(Width, Height);
			}
			catch
			{
				return null;
			}
		}
	}
}
