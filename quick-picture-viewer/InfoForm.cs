using QuickLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	partial class InfoForm : QlibFixedForm
	{
		private bool darkMode;
		private MainForm owner;
		private Bitmap bitmap;
		private string directoryName;
		private string fileName;

		public InfoForm(Bitmap bitmap, string directoryName, string fileName, bool darkMode)
		{
			if (darkMode)
			{
				this.HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			this.darkMode = darkMode;
			this.bitmap = bitmap;
			this.fileName = fileName;
			this.directoryName = directoryName;

			InitializeComponent();
			SetDraggableControls(new List<Control>() { 
				titlePanel, titleLabel,
				fileNameLabel, folderLabel, fullPathLabel, compressionLabel, extensionLabel, createdLabel, modifiedLabel,
				sizeLabel, megapixelsLabel, resolutionLabel, inchesLabel, cmLabel, diskSizeLabel, ratioLabel
			});
			SetDarkMode(darkMode);
		}

		private void SetDarkMode(bool dark)
		{
			if (dark)
			{
				propertiesButton.BackColor = ThemeManager.DarkSecondColor;
				propertiesButton.Image = Properties.Resources.white_imgfile;

				copyNameButton.Image = Properties.Resources.white_copy;
				copyNameButton.BackColor = ThemeManager.DarkSecondColor;
				copyFolderButton.Image = Properties.Resources.white_copy;
				copyFolderButton.BackColor = ThemeManager.DarkSecondColor;
				copyPathButton.Image = Properties.Resources.white_copy;
				copyPathButton.BackColor = ThemeManager.DarkSecondColor;
			}

			DarkMode = dark;
			closeBtn.SetDarkMode(dark);
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
			string result = "N/A";

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
			else if (bitmap.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Tiff))
			{
				result = "TIFF";
			}
			else if (bitmap.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Icon))
			{
				result = "ICO";
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

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void InfoForm_Load(object sender, EventArgs e)
		{
			owner = this.Owner as MainForm;
			InitLanguage();

			if (directoryName != null)
			{
				string path = Path.Combine(directoryName, fileName);

				fileNameTextBox.Text = fileName;
				folderTextBox.Text = directoryName;
				fullPathTextBox.Text = path;

				diskSizeTextBox.Text = bytesToSize(path);
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

			sizeTextBox.Text = bitmap.Width + " x " + bitmap.Height + " " + owner.resMan.GetString("pixels");
			megapixelsTextBox.Text = ((((float)bitmap.Height * bitmap.Width) / 1000000)).ToString("0.##") + " " + owner.resMan.GetString("megapixels");
			resolutionTextBox.Text = Math.Round(bitmap.HorizontalResolution) + " x " + Math.Round(bitmap.VerticalResolution) + " DPI";
			inchesTextBox.Text = inchesWidth.ToString("0.##") + " x " + inchesHeight.ToString("0.##") + " " + owner.resMan.GetString("inches");
			cmTextBox.Text = cmWidth.ToString("0.##") + " x " + cmHeight.ToString("0.##") + " " + owner.resMan.GetString("centimeters");

			int firstRatio = bitmap.Width / GCD(bitmap.Width, bitmap.Height);
			int secondRatio = bitmap.Height / GCD(bitmap.Width, bitmap.Height);
			ratioTextBox.Text = string.Format("{0} : {1} (", firstRatio, secondRatio);
			if (firstRatio == secondRatio)
			{
				ratioTextBox.Text += owner.resMan.GetString("square");
			}
			else if (firstRatio > secondRatio)
			{
				ratioTextBox.Text += owner.resMan.GetString("landscape");
			}
			else
			{
				ratioTextBox.Text += owner.resMan.GetString("portrait");
			}
			ratioTextBox.Text += ")";

			fileNameTextBox.Focus();
		}

		private void InitLanguage()
		{
			this.Text = owner.resMan.GetString("image-info");
			fileNameLabel.Text = owner.resMan.GetString("file") + ":";
			folderLabel.Text = owner.resMan.GetString("folder") + ":";
			fullPathLabel.Text = owner.resMan.GetString("full-path") + ":";
			diskSizeLabel.Text = owner.resMan.GetString("disk-size") + ":";
			ratioLabel.Text = owner.resMan.GetString("aspect-ratio") + ":";
			resolutionLabel.Text = owner.resMan.GetString("resolution") + ":";
			createdLabel.Text = owner.resMan.GetString("created") + ":";
			modifiedLabel.Text = owner.resMan.GetString("modified") + ":";
			infoTooltip.SetToolTip(copyNameButton, owner.resMan.GetString("copy"));
			infoTooltip.SetToolTip(copyFolderButton, owner.resMan.GetString("copy"));
			infoTooltip.SetToolTip(copyPathButton, owner.resMan.GetString("copy"));
			infoTooltip.SetToolTip(closeBtn, owner.resMan.GetString("close") + " | Alt+F4");
			extensionLabel.Text = owner.resMan.GetString("extension") + ":";
			compressionLabel.Text = owner.resMan.GetString("compression") + ":";
			propertiesButton.Text = " " + owner.resMan.GetString("file-properties");
			sizeLabel.Text = owner.resMan.GetString("size") + " (px):";
			megapixelsLabel.Text = owner.resMan.GetString("size") + " (mp):";
			inchesLabel.Text = owner.resMan.GetString("print-size") + " (in):";
			cmLabel.Text = owner.resMan.GetString("print-size") + " (cm):";
		}
	}
}
