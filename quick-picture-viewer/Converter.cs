using System;
using System.IO;

namespace quick_picture_viewer
{
	class Converter
	{
		public static string PathToSize(string path)
		{
			return BytesToSize(new FileInfo(path).Length);
		}

		public static string BytesToSize(double len)
		{
			string[] sizes = { "B", "KB", "MB", "GB", "TB" };
			int order = 0;
			while (len >= 1024 && order < sizes.Length - 1)
			{
				order++;
				len = len / 1024;
			}

			return String.Format("{0:0.##} {1}", len, sizes[order]);
		}
	}
}
