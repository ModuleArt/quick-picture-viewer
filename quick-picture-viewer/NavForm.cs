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

		public void UpdateContainerRect()
		{
			SetLocation(LocRelToSrcPanel().X, LocRelToSrcPanel().Y);
		}

		private Point LocRelToSrcPanel()
		{
			return new Point(
				Location.X - Owner.RectangleToScreen(picturePanel.ClientRectangle).X,
				Location.Y - Owner.RectangleToScreen(picturePanel.ClientRectangle).Y
			);
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
					Location.X + e.X - dragStart.X - Owner.PointToScreen(ClientRectangle.Location).X,
					Location.Y + e.Y - dragStart.Y - Owner.PointToScreen(ClientRectangle.Location).Y
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
			if (e.Button == MouseButtons.Left)
			{
				dragStart = e.Location;
			}
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
			if (curLoc.X == borderSpacing) Anchor |= AnchorStyles.Left;
			if (curLoc.Y == picturePanel.Location.Y + borderSpacing) Anchor |= AnchorStyles.Top;
			if (curLoc.X + Width == owner.ClientRectangle.Width - borderSpacing) Anchor |= AnchorStyles.Right;

			int extraBottomMargin = owner.ClientRectangle.Height - picturePanel.Height - picturePanel.Location.Y;
			if (curLoc.Y + Height == owner.ClientRectangle.Height - borderSpacing - extraBottomMargin) Anchor |= AnchorStyles.Bottom;
			if (Anchor == AnchorStyles.None) Anchor = AnchorStyles.Top | AnchorStyles.Left;
		}

		public void OwnerResizeEnd()
		{
			Point curLoc = LocRelToSrcPanel();
			Anchor = AnchorStyles.Top | AnchorStyles.Left;
			if (curLoc.X < borderSpacing) SetLocation(borderSpacing, curLoc.Y);
			if (curLoc.Y < borderSpacing + picturePanel.Location.Y) SetLocation(curLoc.X, borderSpacing + picturePanel.Location.Y);
			if (curLoc.X + Width > owner.ClientRectangle.Width - borderSpacing) SetLocation(owner.ClientRectangle.Width - borderSpacing - Width, curLoc.Y);

			int extraBottomMargin = owner.ClientRectangle.Height - picturePanel.Height - picturePanel.Location.Y;
			if (curLoc.Y + Height > owner.ClientRectangle.Height - borderSpacing - extraBottomMargin) SetLocation(curLoc.X, owner.ClientRectangle.Height - borderSpacing - Height - extraBottomMargin);
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
