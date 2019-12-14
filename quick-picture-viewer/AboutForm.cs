using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
			this.versionLabel.Text = String.Format("Version: {0}", Assembly.GetExecutingAssembly().GetName().Version.ToString());
		}
	}
}
