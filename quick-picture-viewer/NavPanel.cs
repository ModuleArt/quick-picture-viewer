using System.Drawing;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	public partial class NavPanel : UserControl
	{
		private Point navPanelRelPoint;
		private int extraTopMargin;
		private int extraBottomMargin;
		private MainForm owner;

		public NavPanel(int extraTopMargin, int extraBottomMargin)
		{
			this.extraTopMargin = extraTopMargin;
			this.extraBottomMargin = extraBottomMargin;

			TabStop = false;

			InitializeComponent();
		}

		private void NavPanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				navPanelRelPoint = new Point(e.X, e.Y);
			}
		}

		private void NavPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Point newLoc = new Point(e.X + Location.X - navPanelRelPoint.X, e.Y + Location.Y - navPanelRelPoint.Y);
				if (newLoc.X < 27)
				{
					newLoc.X = 27;
				}
				if (newLoc.Y < 27 + extraTopMargin)
				{
					newLoc.Y = 27 + extraTopMargin;
				}
				if (newLoc.X + Width > Parent.ClientRectangle.Width - 27)
				{
					newLoc.X = Parent.ClientRectangle.Width - 27 - Width;
				}
				if (newLoc.Y + Height > Parent.ClientRectangle.Height - 27 - extraBottomMargin)
				{
					newLoc.Y = Parent.ClientRectangle.Height - 27 - Height - extraBottomMargin;
				}
				Location = newLoc;
			}
		}

		private void NavPanel_Load(object sender, System.EventArgs e)
		{
			owner = Parent as MainForm;

			infoTooltip.SetToolTip(navPrevBtn, owner.resMan.GetString("prev-image") + " | " + owner.resMan.GetString("left-arrow"));
			infoTooltip.SetToolTip(navNextBtn, owner.resMan.GetString("next-image") + " | " + owner.resMan.GetString("right-arrow"));
			infoTooltip.SetToolTip(navSlideshowBtn, owner.resMan.GetString("slideshow") + " | Ctrl+Shift+S");

			Location = new Point(27, Parent.ClientRectangle.Height - extraBottomMargin - Height - 27);
		}

		private void navNextBtn_Click(object sender, System.EventArgs e)
		{
			owner.nextFile();
		}

		private void navSlideshowBtn_Click(object sender, System.EventArgs e)
		{
			owner.toggleSlideshow();
		}

		private void navPrevBtn_Click(object sender, System.EventArgs e)
		{
			owner.prevFile();
		}
	}
}
