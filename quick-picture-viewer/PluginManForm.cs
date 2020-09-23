using System;
using System.Drawing;
using System.Windows.Forms;

namespace quick_picture_viewer
{
	public partial class PluginManForm : Form
	{
		public PluginManForm()
		{
			InitializeComponent();
		}

		private void PluginManForm_Load(object sender, EventArgs e)
		{
			PluginInfo[] plugins = PluginManager.GetPlugins(true);
			for (int i = 0; i < plugins.Length; i++)
			{
				var listViewItem = new ListViewItem(new string[] { 
					plugins[i].title,
					plugins[i].description.Get(Properties.Settings.Default.Language)
				});

				Image img = PluginManager.GetPluginIcon(plugins[i].name, plugins[i].functions[0].name, false);
				if (img != null)
				{
					imageList1.Images.Add(imageList1.Images.Count.ToString(), img);
					listViewItem.ImageKey = (imageList1.Images.Count - 1).ToString();
				}

				listView1.Items.Add(listViewItem);
			}
		}
	}
}
