using QuickLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	public partial class NavForm : Form
	{
		public int borderSpacing = 27;

		private Point dragStart;
		private MainForm owner;
		private Panel picturePanel;

		public NavForm(Panel srcPanel)
		{
			picturePanel = srcPanel;
			InitializeComponent();
		}

		private Point LocRelToSrcPanel()
		{
			if (owner != null) return new Point(
				Location.X - owner.RectangleToScreen(picturePanel.ClientRectangle).X,
				Location.Y - owner.RectangleToScreen(picturePanel.ClientRectangle).Y
			);
			else return Point.Empty;
		}

		private void navPrevBtn_Click(object sender, EventArgs e)
		{
			owner.PrevFile();
		}

		private void navSlideshowBtn_Click(object sender, EventArgs e)
		{
			owner.toggleSlideshow();
		}

		private void navNextBtn_Click(object sender, EventArgs e)
		{
			owner.NextFile();
		}

		protected override void OnLoad(EventArgs e)
		{
			owner = Owner as MainForm;
			Size = new Size(113, 32);
			SetLocation(picturePanel.Location.X + borderSpacing, picturePanel.Location.Y + picturePanel.Height - Height - borderSpacing);
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				SetLocation(
					Location.X + e.X - dragStart.X - owner.PointToScreen(ClientRectangle.Location).X,
					Location.Y + e.Y - dragStart.Y - owner.PointToScreen(ClientRectangle.Location).Y
				);
			}
		}

		private void SetLocation(int newX, int newY)
		{
			if (newX < picturePanel.Location.X + borderSpacing) newX = picturePanel.Location.X + borderSpacing;
			if (newY < picturePanel.Location.Y + borderSpacing) newY = picturePanel.Location.Y + borderSpacing;
			if (newX > picturePanel.Location.X + picturePanel.Width - Width - borderSpacing) newX = picturePanel.Location.X + picturePanel.Width - Width - borderSpacing;
			if (newY > picturePanel.Location.Y + picturePanel.Height - Height - borderSpacing) newY = picturePanel.Location.Y + picturePanel.Height - Height - borderSpacing;
			Location = new Point(newX, newY);
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left) dragStart = e.Location;
		}

		public void SetSlideshowChecked(bool b)
		{
			if (b)
			{
				navSlideshowBtn.BackColor = ThemeMan.DarkPaleColor;
				navSlideshowBtn.FlatAppearance.MouseOverBackColor = ThemeMan.DarkPaleColor;
				navSlideshowBtn.FlatAppearance.BorderSize = 1;
			}
			else
			{
				navSlideshowBtn.BackColor = ThemeMan.DarkMainColor;
				navSlideshowBtn.FlatAppearance.MouseOverBackColor = navPrevBtn.FlatAppearance.MouseOverBackColor;
				navSlideshowBtn.FlatAppearance.BorderSize = 0;
			}
		}

		public void OwnerResizeBegin()
		{
			Point curLoc = LocRelToSrcPanel();
			Anchor = AnchorStyles.None;
			if (curLoc.X <= borderSpacing) Anchor |= AnchorStyles.Left;
			if (curLoc.X + Width >= owner.ClientRectangle.Width - borderSpacing) Anchor |= AnchorStyles.Right;

			if (curLoc.Y <= picturePanel.Location.Y + borderSpacing) Anchor |= AnchorStyles.Top;
			
			int extraBottomMargin = owner.ClientRectangle.Height - picturePanel.Height - picturePanel.Location.Y;
			if (curLoc.Y + Height >= owner.ClientRectangle.Height - borderSpacing - extraBottomMargin) Anchor |= AnchorStyles.Bottom;
		}

		public void UpdateContainerRect()
		{
			Point curLoc = LocRelToSrcPanel();
			Point newLoc = curLoc;

			if (Anchor.HasFlag(AnchorStyles.Left)) newLoc.X = borderSpacing;
			if (Anchor.HasFlag(AnchorStyles.Right)) newLoc.X = owner.ClientRectangle.Width - borderSpacing - Width;

			if (Anchor.HasFlag(AnchorStyles.Top)) newLoc.Y = picturePanel.Location.Y + borderSpacing;
			if (Anchor.HasFlag(AnchorStyles.Bottom))
			{
				int extraBottomMargin = owner.ClientRectangle.Height - picturePanel.Height - picturePanel.Location.Y;
				newLoc.Y = owner.ClientRectangle.Height - borderSpacing - Height - extraBottomMargin;
			}

			SetLocation(newLoc.X, newLoc.Y);
		}

		public void OwnerResizeEnd()
		{
			Anchor = AnchorStyles.None;
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			owner.MainForm_KeyDown(this, e);
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (owner != null && owner.ProcessArrowKeys(keyData)) return true;
			else return base.ProcessCmdKey(ref msg, keyData);
		}
	}
}
