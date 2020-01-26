using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	partial class InfoForm : Form
	{
		private string fullPath = null;

		public InfoForm(Bitmap bitmap, string directoryName, string fileName, bool darkMode)
		{
			if (darkMode)
			{
				this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
				this.Shown += new EventHandler(ThemeManager.formHandleCreated);
			}

			InitializeComponent();

			if (darkMode)
			{
				this.BackColor = ThemeManager.BackColorDark;
				this.ForeColor = Color.White;

				fileGroup.ForeColor = Color.White;
				sizeGroup.ForeColor = Color.White;
				dateGroup.ForeColor = Color.White;

				propertiesButton.BackColor = ThemeManager.SecondColorDark;
				propertiesButton.Image = Properties.Resources.white_imgfile;

				okButton.BackColor = ThemeManager.SecondColorDark;

				fileNameTextBox.BackColor = ThemeManager.SecondColorDark;
				fileNameTextBox.ForeColor = Color.White;

				folderTextBox.BackColor = ThemeManager.SecondColorDark;
				folderTextBox.ForeColor = Color.White;

				fullPathTextBox.BackColor = ThemeManager.SecondColorDark;
				fullPathTextBox.ForeColor = Color.White;

				compressionTextBox.BackColor = ThemeManager.SecondColorDark;
				compressionTextBox.ForeColor = Color.White;

				sizeTextBox.BackColor = ThemeManager.SecondColorDark;
				sizeTextBox.ForeColor = Color.White;

				megapixelsTextBox.BackColor = ThemeManager.SecondColorDark;
				megapixelsTextBox.ForeColor = Color.White;

				resolutionTextBox.BackColor = ThemeManager.SecondColorDark;
				resolutionTextBox.ForeColor = Color.White;

				inchesTextBox.BackColor = ThemeManager.SecondColorDark;
				inchesTextBox.ForeColor = Color.White;

				cmTextBox.BackColor = ThemeManager.SecondColorDark;
				cmTextBox.ForeColor = Color.White;

				diskSizeTextBox.BackColor = ThemeManager.SecondColorDark;
				diskSizeTextBox.ForeColor = Color.White;

				createdTextBox.BackColor = ThemeManager.SecondColorDark;
				createdTextBox.ForeColor = Color.White;

				modifiedTextBox.BackColor = ThemeManager.SecondColorDark;
				modifiedTextBox.ForeColor = Color.White;
			}

			if (directoryName != null)
			{
				string path = Path.Combine(directoryName, fileName);
				fullPath = path;

				fileNameTextBox.Text = fileName;
				folderTextBox.Text = directoryName;
				fullPathTextBox.Text = path;

				diskSizeTextBox.Text = bytesToSize(path);

				createdTextBox.Text = File.GetCreationTime(path).ToShortDateString() + " / " + File.GetCreationTime(path).ToLongTimeString();
				modifiedTextBox.Text = File.GetLastWriteTime(path).ToShortDateString() + " / " + File.GetLastWriteTime(path).ToLongTimeString();

				propertiesButton.Enabled = true;
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
			cmTextBox.Text = cmWidth.ToString("0.##") + " x " + cmHeight.ToString("0.##") + " centimeters";
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

		private void InfoForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		private void propertiesButton_Click(object sender, EventArgs e)
		{
			ShellManager.ShowFileProperties(fullPath);
		}
	}
}
