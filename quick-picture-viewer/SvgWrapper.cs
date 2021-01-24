using Svg;
using System;
using System.Drawing;

namespace quick_picture_viewer
{
	public static class SvgWrapper
	{
		public static string TypeName = "SVG";
		public static Error CurrentError = 0;

		public enum Error
		{
			NoError = 0,
			UnableToOpen = 1
		}

		public static Bitmap ParseSvg(string path, int Width = -1, int Height = -1)
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

				CurrentError = Error.NoError;
				return svgDocument.Draw(Width, Height);
			}
			catch
			{
				CurrentError = Error.UnableToOpen;
				return null;
			}
		}
	}
}
