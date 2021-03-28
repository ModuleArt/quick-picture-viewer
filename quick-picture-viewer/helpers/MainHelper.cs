using QuickLibrary;
using System.Drawing;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	public static class MainHelper
	{
		public static void ApplyCheckerboardBackground(PictureBox pictureBox, bool apply, bool darkMode = false)
		{
			if (!apply)
			{
				if (pictureBox.BackgroundImage != null) pictureBox.BackgroundImage.Dispose();
				pictureBox.BackgroundImage = null;
				return;
			}
			Color col = darkMode ? Color.FromArgb(76, 76, 76) : Color.FromArgb(191, 191, 191);
			Bitmap bmp = new Bitmap(16, 16);
			using (SolidBrush brush = new SolidBrush(col))
			using (Graphics G = Graphics.FromImage(bmp))
			{
				G.FillRectangle(brush, 0, 0, 8, 8);
				G.FillRectangle(brush, 8, 8, 8, 8);
			}
			pictureBox.BackgroundImage = bmp;
			pictureBox.BackgroundImageLayout = ImageLayout.Tile;
		}

		public static void UpdatePictureBoxLocation(Panel picturePanel, PictureBox pictureBox)
		{
			int x, y;

			if (pictureBox.Width < picturePanel.Width) x = (int)((double)(picturePanel.Width - pictureBox.Width) / (double)2);
			else x = -picturePanel.HorizontalScroll.Value;

			if (pictureBox.Height < picturePanel.Height) y = (int)((double)(picturePanel.Height - pictureBox.Height) / (double)2);
			else y = -picturePanel.VerticalScroll.Value;

			pictureBox.Location = new Point(x, y);

			if (picturePanel != null && pictureBox != null)
			{
				if (pictureBox.Width > picturePanel.Width && pictureBox.Height > picturePanel.Height) NativeMan.ShowScrollBar(picturePanel.Handle, NativeMan.ScrollBarDirection.SB_BOTH, true);
				else if (pictureBox.Width > picturePanel.Width) NativeMan.ShowScrollBar(picturePanel.Handle, NativeMan.ScrollBarDirection.SB_HORZ, true);
				else if (pictureBox.Height > picturePanel.Height) NativeMan.ShowScrollBar(picturePanel.Handle, NativeMan.ScrollBarDirection.SB_VERT, true);
				else NativeMan.ShowScrollBar(picturePanel.Handle, NativeMan.ScrollBarDirection.SB_BOTH, false);
			}
		}
	}
}
