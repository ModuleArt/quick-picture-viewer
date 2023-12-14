using QuickLibrary;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QuickPictureViewerPlus
{
	internal class QuickPictureBox : PictureBox
	{ 
		private InterpolationMode interpolationMode = InterpolationMode.Default;

		/// <summary>
		/// Sets the interpolation mode (AKA filtering mode) for the underlying Image
		/// </summary>
		/// <param name="mode">Interpolation mode to use</param>
		public void SetInterpolationMode(InterpolationMode mode)
		{
			interpolationMode = mode;
			Invalidate();
		}

		public void ApplyCheckerboardBackground(bool apply, bool darkMode = false)
		{
			if (!apply)
			{
				BackgroundImage?.Dispose();
				BackgroundImage = null;
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

			BackgroundImage = bmp;
			BackgroundImageLayout = ImageLayout.Tile;
		}

		public void UpdatePictureBoxLocation(Panel picturePanel)
		{
			int x, y;

			if (Width < picturePanel.Width) x = (int)((double)(picturePanel.Width - Width) / (double)2);
			else x = -picturePanel.HorizontalScroll.Value;

			if (Height < picturePanel.Height) y = (int)((double)(picturePanel.Height - Height) / (double)2);
			else y = -picturePanel.VerticalScroll.Value;

			Location = new Point(x, y);

			if (picturePanel != null)
			{
				if (Width > picturePanel.Width && Height > picturePanel.Height) NativeMan.ShowScrollBar(picturePanel.Handle, NativeMan.ScrollBarDirection.SB_BOTH, true);
				else if (Width > picturePanel.Width) NativeMan.ShowScrollBar(picturePanel.Handle, NativeMan.ScrollBarDirection.SB_HORZ, true);
				else if (Height > picturePanel.Height) NativeMan.ShowScrollBar(picturePanel.Handle, NativeMan.ScrollBarDirection.SB_VERT, true);
				else NativeMan.ShowScrollBar(picturePanel.Handle, NativeMan.ScrollBarDirection.SB_BOTH, false);
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			// Set the interpolation mode to nearest-neighbor
			e.Graphics.InterpolationMode = interpolationMode;

			// Call the base class to draw the image with the specified interpolation mode
			base.OnPaint(e);
		}
	}
}
