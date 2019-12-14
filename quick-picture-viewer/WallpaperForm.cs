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
	partial class WallpaperForm : Form
	{
		Bitmap bmp;

		public WallpaperForm(Bitmap bmp)
		{
			InitializeComponent();
			this.bmp = bmp;
			//this.sizeLabel.Text = String.Format("Size: {0} x {1} px", bmp.Width, bmp.Height);
		}

		#region Assembly Attribute Accessors

		public string AssemblyTitle
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
				if (attributes.Length > 0)
				{
					AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
					if (titleAttribute.Title != "")
					{
						return titleAttribute.Title;
					}
				}
				return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
			}
		}

		public string AssemblyVersion
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}

		public string AssemblyDescription
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyDescriptionAttribute)attributes[0]).Description;
			}
		}

		public string AssemblyProduct
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyProductAttribute)attributes[0]).Product;
			}
		}

		public string AssemblyCopyright
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
			}
		}

		public string AssemblyCompany
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyCompanyAttribute)attributes[0]).Company;
			}
		}
		#endregion

		private void okButton_Click(object sender, EventArgs e)
		{
			if (stretchedRadio.Checked)
			{
				Wallpaper.Set(bmp, Wallpaper.Style.Stretch);
			}
			else if (tiledRadio.Checked)
			{
				Wallpaper.Set(bmp, Wallpaper.Style.Tile);
			}
			else if (centeredRadio.Checked)
			{
				Wallpaper.Set(bmp, Wallpaper.Style.Center);
			}
			else if (fillRadio.Checked)
			{
				Wallpaper.Set(bmp, Wallpaper.Style.Fill);
			}
			else if (fitRadio.Checked)
			{
				Wallpaper.Set(bmp, Wallpaper.Style.Fit);
			}
		}
	}
}
