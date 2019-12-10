using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	public partial class MainForm : Form
	{
		private string openPath;
		private int zoomFactor = 100;
		private int width = 0;
		private int height = 0;
		private Bitmap originalImage;
		private bool autoZoom = true;

		public MainForm(string openPath)
		{
			this.openPath = openPath;

			InitializeComponent();
		}

		private void openButton_Click_1(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				openFile(openFileDialog1.FileName);
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			if(!string.IsNullOrEmpty(openPath))
			{
				openFile(openPath);
			}
		}

		private void openFile(string path)
		{
			try
			{
				originalImage = new Bitmap(path);
				pictureBox.Image = originalImage;

				width = pictureBox.Image.Size.Width;
				height = pictureBox.Image.Size.Height;
				sizeLabel.Text = "Size: " + width.ToString() + " x " + height.ToString() + " px";
				pathLabel.Text = "File: " + path;

				this.Text = Path.GetFileName(path) + " - Quick Picture Viewer";

				zoomInButton.Enabled = true;
				zoomOutButton.Enabled = true;
			}
			catch (Exception)
			{
				MessageBox.Show("Unable to open this file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void zoomInButton_Click(object sender, EventArgs e)
		{
			zoomIn();
		}

		private void zoomOutButton_Click(object sender, EventArgs e)
		{
			zoomOut();
		}

		private void zoomIn()
		{
			if (zoomFactor < 250)
			{
				setZoomFactor(zoomFactor + 10);
			}
		}

		private void zoomOut()
		{
			if (zoomFactor > 10)
			{
				setZoomFactor(zoomFactor - 10);
			}
		}

		private void setZoomFactor(int newZoomFactor)
		{
			setAutoZoom(false);

			zoomFactor = newZoomFactor;
			zoomLabel.Text = "Zoom: " + zoomFactor.ToString() + "%";

			int newWidth = Convert.ToInt32(width * zoomFactor / 100);
			int newHeight = Convert.ToInt32(height * zoomFactor / 100);

			Size newSize = new Size(newWidth, newHeight);

			Bitmap bmp = new Bitmap(originalImage, newSize);
			pictureBox.Image = bmp;
		}

		private void setAutoZoom(bool b)
		{
			autoZoom = b;
			if (b)
			{
				pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
				pictureBox.Dock = DockStyle.Fill;

				zoomLabel.Text = "Zoom: Auto";
			}
			else
			{
				pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
				pictureBox.Dock = DockStyle.None;

				zoomLabel.Text = "Zoom: " + zoomFactor + "%";
			}
		}

		private void autoZoomButton_Click(object sender, EventArgs e)
		{
			setAutoZoom(!autoZoom);
		}

		private void aboutButton_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show(
				"Quick Picture Viewer\nv" + ProductVersion + "\n\nby Module Art\nAuthor: Jake Volynko\n\nVisit project web page?\nhttps://moduleart.github.io/quick-picture-viewer/", 
				"About", 
				MessageBoxButtons.YesNo, 
				MessageBoxIcon.Asterisk
			) == DialogResult.Yes)
			{
				System.Diagnostics.Process.Start("https://moduleart.github.io/quick-picture-viewer/");
			} 
		}
	}
}
