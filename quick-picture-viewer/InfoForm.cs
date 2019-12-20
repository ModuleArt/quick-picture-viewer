using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	partial class InfoForm : Form
	{
		public InfoForm(Bitmap bitmap, string directoryName, string fileName)
		{
			InitializeComponent();

			if (directoryName == null)
			{
				fileNameTextBox.Text = "Unknown";
				folderTextBox.Text = "Not exists";
				fullPathTextBox.Text = "Unknown";

				diskSizeTextBox.Text = "Unknown";

				createdTextBox.Text = "Unknown";
				modifiedTextBox.Text = "Unknown";
			}
			else
			{
				string path = Path.Combine(directoryName, fileName);

				fileNameTextBox.Text = fileName;
				folderTextBox.Text = directoryName;
				fullPathTextBox.Text = path;

				diskSizeTextBox.Text = bytesToSize(path);

				createdTextBox.Text = File.GetCreationTime(path).ToShortDateString() + " / " + File.GetCreationTime(path).ToLongTimeString();
				modifiedTextBox.Text = File.GetLastWriteTime(path).ToShortDateString() + " / " + File.GetLastWriteTime(path).ToLongTimeString();
			}

			double inchesWidth = bitmap.Width / bitmap.HorizontalResolution;
			double inchesHeight = bitmap.Height / bitmap.VerticalResolution;
			double cmWidth = inchesWidth * 2.54;
			double cmHeight = inchesHeight * 2.54;

			compressionTextBox.Text = getImageCompression(bitmap);

			sizeTextBox.Text = bitmap.Width + " x " + bitmap.Height + " pixels";
			megapixelsTextBox.Text = ((((float) bitmap.Height * bitmap.Width) / 1000000)).ToString("0.##") + " megapixels";
			resolutionTextBox.Text = Math.Round(bitmap.HorizontalResolution) + " x " + Math.Round(bitmap.VerticalResolution) + " DPI";
			inchesTextBox.Text = inchesWidth.ToString("0.##") + " x " + inchesHeight.ToString("0.##") + " inches";
			cmTextBox.Text = cmWidth.ToString("0.#") + " x " + cmHeight.ToString("0.#") + " centimeters";

			if (ThemeManager.isDarkTheme())
			{
				this.BackColor = Color.FromArgb(32, 32, 32);
				this.ForeColor = Color.White;

				this.fileGroup.ForeColor = Color.White;
				this.sizeGroup.ForeColor = Color.White;
				this.dateGroup.ForeColor = Color.White;
			}
		}

		private string bytesToSize(string path)
		{
			string[] sizes = { "B", "KB", "MB", "GB", "TB" };
			double len = new FileInfo(path).Length;
			int order = 0;
			while (len >= 1024 && order < sizes.Length - 1)
			{
				order++;
				len = len / 1024;
			}

			return String.Format("{0:0.##} {1}", len, sizes[order]);
		}

		private string getImageCompression(Bitmap bitmap)
		{
			string result = "Unknown";

			if (bitmap.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png))
			{
				result = "PNG";
			}
			else if (bitmap.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg))
			{
				result = "JPG";
			}
			else if (bitmap.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Exif))
			{
				result = "EXIF";
			}
			else if (bitmap.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Gif))
			{
				result = "GIF";
			}
			else if (bitmap.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Bmp))
			{
				result = "BMP";
			}

			return result;
		}
	}
}
