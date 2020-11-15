using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QuickLibrary;
using System.IO.Compression;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;

namespace quick_picture_viewer
{
	public partial class PluginManForm : QlibFixedForm
	{
		private MainForm owner;
		private string[] codenames;
		private string[] pluginsLinks;

		public PluginManForm(bool darkMode)
		{
			if (darkMode)
			{
				HandleCreated += new EventHandler(ThemeManager.formHandleCreated);
			}

			InitializeComponent();
			SetDraggableControls(new List<Control>() { titlePanel, titleLabel });
			SetDarkMode(darkMode);
		}

		private void SetDarkMode(bool dark)
		{
			if (dark)
			{
				addPluginBtn.BackColor = ThemeManager.DarkSecondColor;
				addPluginBtn.Image = Properties.Resources.white_open;
				morePluginsBtn.BackColor = ThemeManager.DarkSecondColor;
				morePluginsBtn.Image = Properties.Resources.white_plugin;
				deleteBtn.Image = Properties.Resources.white_trash;
				pluginWebsiteBtn.Image = Properties.Resources.white_website;
			}

			DarkMode = dark;
			closeBtn.DarkMode = dark;
			contextMenuStrip1.SetDarkMode(dark);
			listView1.SetDarkMode(dark);
		}

		private void PluginManForm_Load(object sender, EventArgs e)
		{
			owner = Owner as MainForm;
			InitLanguage();

			RefreshPluginsList();
			AutoSizeColumns();
		}

		private void RefreshPluginsList()
		{
			if (listView1.Items != null && listView1.Items.Count > 0)
			{
				listView1.Items.Clear();
			}
			if (imageList1.Images != null && imageList1.Images.Count > 0)
			{
				imageList1.Images.Clear();
			}

			PluginInfo[] plugins = PluginManager.GetPlugins(true);
			codenames = new string[plugins.Length];
			pluginsLinks = new string[plugins.Length];
			for (int i = 0; i < plugins.Length; i++)
			{
				codenames[i] = plugins[i].name;
				pluginsLinks[i] = plugins[i].link;

				string authors = "";
				for (int j = 0; j < plugins[i].authors.Length; j++)
				{
					authors += plugins[i].authors[j].name;

					if (j != plugins[i].authors.Length - 1)
					{
						authors += ", ";
					}
				}

				var listViewItem = new ListViewItem(new string[] {
					plugins[i].title + " (" + plugins[i].name + ")",
					plugins[i].description.Get(Properties.Settings.Default.Language),
					authors,
					"v" + plugins[i].version
				});

				Image img = PluginManager.GetPluginIcon(plugins[i].name, plugins[i].functions[0].name, false);
				if (img != null)
				{
					imageList1.Images.Add(imageList1.Images.Count.ToString(), img);
					listViewItem.ImageKey = (imageList1.Images.Count - 1).ToString();
					img.Dispose();
				}

				listView1.Items.Add(listViewItem);
			}
		}

		private void InitLanguage()
		{
			Text = owner.resMan.GetString("plugin-manager");
			listView1.Columns[0].Text = owner.resMan.GetString("plugin");
			listView1.Columns[1].Text = owner.resMan.GetString("desc");
			listView1.Columns[2].Text = owner.resMan.GetString("created-by");
			listView1.Columns[3].Text = owner.resMan.GetString("version");
			addPluginBtn.Text = " " + owner.resMan.GetString("browse-for-plugins");
			deleteBtn.Text = owner.resMan.GetString("delete-plugin");
			openFileDialog1.Title = owner.resMan.GetString("browse-for-plugins");
			morePluginsBtn.Text = " " + owner.resMan.GetString("more-plugins");
			pluginWebsiteBtn.Text = owner.resMan.GetString("plugin-website");
			infoTooltip.SetToolTip(closeBtn, NativeMan.GetMessageBoxText(NativeMan.DialogBoxCommandID.IDCLOSE) + " | Alt+F4");
		}

		private void PluginManForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void addPluginBtn_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				ZipFile.ExtractToDirectory(openFileDialog1.FileName, PluginManager.pluginsFolder);
				RefreshPluginsList();
			}
			openFileDialog1.Dispose();
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedIndices != null && listView1.SelectedIndices.Count > 0)
			{
				deletePlugin(listView1.SelectedIndices[0]);
			}
		}

		private void deletePlugin(int numberInList)
		{
			DialogResult window = MessageBox.Show(
				owner.resMan.GetString("delete-plugin-warning"),
				owner.resMan.GetString("warning"),
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (window == DialogResult.Yes)
			{
				listView1.Items[numberInList].Remove();
				imageList1.Images[numberInList].Dispose();
				
				string pluginFolder = Path.Combine(PluginManager.pluginsFolder, codenames[numberInList]);
				if (FileSystem.DirectoryExists(pluginFolder))
				{
					FileSystem.DeleteDirectory(pluginFolder, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin, UICancelOption.DoNothing);
				}
				else
				{
					MessageBox.Show(owner.resMan.GetString("plugin-not-found"), owner.resMan.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				RefreshPluginsList();
			}
		}

		private void morePluginsBtn_Click(object sender, EventArgs e)
		{
			Process.Start("https://moduleart.github.io/quick-picture-viewer#plugins");
		}

		private void pluginWebsiteBtn_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedIndices != null && listView1.SelectedIndices.Count > 0)
			{
				Process.Start(pluginsLinks[listView1.SelectedIndices[0]]);
			}
		}

		private void AutoSizeColumns()
		{
			float x = listView1.Width / 100f;
			
			listView1.Columns[0].Width = (int)(x * 25) + 1;
			listView1.Columns[1].Width = (int)(x * 36);
			listView1.Columns[2].Width = (int)(x * 25);
			listView1.Columns[3].Width = (int)(x * 14);

			//int sum = listView1.Columns[0].Width + listView1.Columns[1].Width + listView1.Columns[2].Width + listView1.Columns[3].Width;
			//listView1.Columns[0].Width += Width - 25 - sum;
		}

		private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
		{
			e.Cancel = true;
			e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
		}
	}
}
