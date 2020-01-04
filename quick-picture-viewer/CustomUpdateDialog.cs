using GitHubUpdate;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	public class CustomUpdateDialog : UpdateNotifyDialog
	{
		public CustomUpdateDialog(UpdateChecker checker, bool alwaysOnTop) : base(checker)
		{
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

			var checkboxes = GetAll(this, typeof(CheckBox)).ToArray();

			CheckBox whatsButton = checkboxes[0] as CheckBox;
			Button cancelButton = CancelButton as Button;
			Button okButton = AcceptButton as Button;

			whatsButton.FlatStyle = FlatStyle.Flat;
			whatsButton.FlatAppearance.BorderSize = 0;
			whatsButton.Location = new Point(whatsButton.Location.X + 3, whatsButton.Location.Y - 2);

			cancelButton.FlatStyle = FlatStyle.Flat;
			cancelButton.FlatAppearance.BorderSize = 0;

			okButton.FlatStyle = FlatStyle.Flat;
			okButton.FlatAppearance.BorderSize = 0;

			if (alwaysOnTop)
			{
				this.TopMost = true;
			}

			if (ThemeManager.isDarkTheme())
			{
				this.BackColor = ThemeManager.BackColorDark;
				this.ForeColor = Color.White;

				whatsButton.BackColor = ThemeManager.SecondColorDark;
				cancelButton.BackColor = ThemeManager.SecondColorDark;
				okButton.BackColor = ThemeManager.SecondColorDark;
			}
			else
			{
				whatsButton.BackColor = SystemColors.ControlLight;
				cancelButton.BackColor = SystemColors.ControlLight;
				okButton.BackColor = SystemColors.ControlLight;
			}
		}

		private IEnumerable<Control> GetAll(Control control, Type type)
		{
			var controls = control.Controls.Cast<Control>();
			return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
		}
	}
}
