using QuickLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuickPictureViewerPlus
{
	partial class InfoForm : QlibFixedForm
	{
		private Bitmap bitmap;
		private string directoryName;
		private string fileName;

		public InfoForm(Bitmap bitmap, string directoryName, string fileName)
		{
			this.bitmap = bitmap;
			this.fileName = fileName;
			this.directoryName = directoryName;

			InitializeComponent();
			SetDraggableControls(new List<Control>() { 
				fileNameLabel, folderLabel, fullPathLabel, compressionLabel, extensionLabel, createdLabel, modifiedLabel,
				sizeLabel, megapixelsLabel, resolutionLabel, inchesLabel, cmLabel, diskSizeLabel, ratioLabel
			});
		}

		private void SetDarkMode(bool dark)
		{
			if (dark)
			{
				propertiesButton.BackColor = ThemeMan.DarkSecondColor;
				propertiesButton.Image = Properties.Resources.white_imgfile;

				copyNameButton.Image = Properties.Resources.white_copy;
				copyNameButton.BackColor = ThemeMan.DarkSecondColor;
				copyFolderButton.Image = Properties.Resources.white_copy;
				copyFolderButton.BackColor = ThemeMan.DarkSecondColor;
				copyPathButton.Image = Properties.Resources.white_copy;
				copyPathButton.BackColor = ThemeMan.DarkSecondColor;
			}

			DarkMode = dark;
			closeBtn.DarkMode = dark;
			fileNameTextBox.DarkMode = dark;
			folderTextBox.DarkMode = dark;
			fullPathTextBox.DarkMode = dark;
			compressionTextBox.DarkMode = dark;
			extensionTextBox.DarkMode = dark;
			sizeTextBox.DarkMode = dark;
			megapixelsTextBox.DarkMode = dark;
			resolutionTextBox.DarkMode = dark;
			inchesTextBox.DarkMode = dark;
			cmTextBox.DarkMode = dark;
			diskSizeTextBox.DarkMode = dark;
			ratioTextBox.DarkMode = dark;
			createdTextBox.DarkMode = dark;
			modifiedTextBox.DarkMode = dark;
		}

		private int GCD(int a, int b)
		{
			int Remainder;
			while (b != 0)
			{
				Remainder = a % b;
				a = b;
				b = Remainder;
			}
			return a;
		}

		private string getImageCompression(Bitmap bitmap)
		{
			string result = "N/A";

			if (bitmap.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png)) result = "PNG";
			else if (bitmap.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg)) result = "JPG";
			else if (bitmap.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Exif)) result = "EXIF";
			else if (bitmap.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Gif)) result = "GIF";
			else if (bitmap.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Bmp)) result = "BMP";
			else if (bitmap.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Tiff)) result = "TIF";
			else if (bitmap.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Icon)) result = "ICO";

			return result;
		}

		private void propertiesButton_Click(object sender, EventArgs e)
		{
			ShellManager.ShowFileProperties(Path.Combine(directoryName, fileName));
		}

		private void copyNameButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(fileNameTextBox.Text);
		}

		private void copyFolderButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(folderTextBox.Text);
		}

		private void copyPathButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(fullPathTextBox.Text);
		}

		private void InfoForm_Load(object sender, EventArgs e)
		{
			SetDarkMode(DarkMode);
			InitLanguage();

			if (directoryName != null)
			{
				string path = Path.Combine(directoryName, fileName);

				fileNameTextBox.Text = fileName;
				folderTextBox.Text = directoryName;
				fullPathTextBox.Text = path;

				diskSizeTextBox.Text = FileMan.GetFileSizeStr(path);
				extensionTextBox.Text = Path.GetExtension(path).Substring(1, Path.GetExtension(path).Length - 1).ToUpper();

				createdTextBox.Text = File.GetCreationTime(path).ToShortDateString() + " - " + File.GetCreationTime(path).ToLongTimeString();
				modifiedTextBox.Text = File.GetLastWriteTime(path).ToShortDateString() + " - " + File.GetLastWriteTime(path).ToLongTimeString();

				propertiesButton.Visible = true;
			}

			double inchesWidth = bitmap.Width / bitmap.HorizontalResolution;
			double inchesHeight = bitmap.Height / bitmap.VerticalResolution;
			double cmWidth = inchesWidth * 2.54;
			double cmHeight = inchesHeight * 2.54;

			compressionTextBox.Text = getImageCompression(bitmap);

			sizeTextBox.Text = bitmap.Width + " x " + bitmap.Height + " " + LangMan.Get("pixels");
			megapixelsTextBox.Text = ((((float)bitmap.Height * bitmap.Width) / 1000000)).ToString("0.##") + " " + LangMan.Get("megapixels");
			resolutionTextBox.Text = Math.Round(bitmap.HorizontalResolution) + " x " + Math.Round(bitmap.VerticalResolution) + " DPI";
			inchesTextBox.Text = inchesWidth.ToString("0.##") + " x " + inchesHeight.ToString("0.##") + " " + LangMan.Get("inches");
			cmTextBox.Text = cmWidth.ToString("0.##") + " x " + cmHeight.ToString("0.##") + " " + LangMan.Get("centimeters");

			int firstRatio = bitmap.Width / GCD(bitmap.Width, bitmap.Height);
			int secondRatio = bitmap.Height / GCD(bitmap.Width, bitmap.Height);
			ratioTextBox.Text = string.Format("{0} : {1} (", firstRatio, secondRatio);
			if (firstRatio == secondRatio) ratioTextBox.Text += LangMan.Get("square");
			else if (firstRatio > secondRatio) ratioTextBox.Text += LangMan.Get("landscape");
			else ratioTextBox.Text += LangMan.Get("portrait");
			ratioTextBox.Text += ")";
		}

		private void InitLanguage()
		{
			Text = LangMan.Get("image-info");
			fileNameLabel.Text = LangMan.Get("file") + ":";
			folderLabel.Text = LangMan.Get("folder") + ":";
			fullPathLabel.Text = LangMan.Get("full-path") + ":";
			diskSizeLabel.Text = LangMan.Get("disk-size") + ":";
			ratioLabel.Text = LangMan.Get("aspect-ratio") + ":";
			resolutionLabel.Text = LangMan.Get("resolution") + ":";
			createdLabel.Text = LangMan.Get("created") + ":";
			modifiedLabel.Text = LangMan.Get("modified") + ":";
			infoTooltip.SetToolTip(copyNameButton, LangMan.Get("copy"));
			infoTooltip.SetToolTip(copyFolderButton, LangMan.Get("copy"));
			infoTooltip.SetToolTip(copyPathButton, LangMan.Get("copy"));
			extensionLabel.Text = LangMan.Get("extension") + ":";
			compressionLabel.Text = LangMan.Get("compression") + ":";
			propertiesButton.Text = " " + LangMan.Get("file-properties");
			sizeLabel.Text = LangMan.Get("size") + " (px):";
			megapixelsLabel.Text = LangMan.Get("size") + " (mp):";
			inchesLabel.Text = LangMan.Get("print-size") + " (in):";
			cmLabel.Text = LangMan.Get("print-size") + " (cm):";
			infoTooltip.SetToolTip(closeBtn, NativeMan.GetMessageBoxText(NativeMan.DialogBoxCommandID.IDCLOSE) + " | Alt+F4");
		}
	}
}
