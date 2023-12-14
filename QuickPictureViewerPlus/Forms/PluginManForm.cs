using System;
using System.Drawing;
using System.Windows.Forms;
using QuickLibrary;
using System.IO.Compression;
using System.IO;
using System.Diagnostics;

namespace QuickPictureViewerPlus
{
	public partial class PluginManForm : QlibFixedForm
	{
		private string[] codenames;
		private string[] pluginsLinks;

		public PluginManForm()
		{
			InitializeComponent();
		}

		private void SetDarkMode(bool dark)
		{
			if (dark)
			{
				addPluginBtn.BackColor = ThemeMan.DarkSecondColor;
				addPluginBtn.Image = Properties.Resources.white_open;
				morePluginsBtn.BackColor = ThemeMan.DarkSecondColor;
				morePluginsBtn.Image = Properties.Resources.white_plugin;
				deleteBtn.Image = Properties.Resources.white_trash;
				pluginWebsiteBtn.Image = Properties.Resources.white_website;
				refreshBtn.BackColor = ThemeMan.DarkSecondColor;
				refreshBtn.Image = Properties.Resources.white_sync;
			}
			DarkMode = dark;
			closeBtn.DarkMode = dark;
			contextMenuStrip1.DarkMode = dark;
			listView1.SetDarkMode(dark);
		}

		private void PluginManForm_Load(object sender, EventArgs e)
		{
			SetDarkMode(DarkMode);
			InitLanguage();

			RefreshPluginsList();
			AutoSizeColumns();
		}

		private void RefreshPluginsList()
		{
			if (listView1.Items != null && listView1.Items.Count > 0) listView1.Items.Clear();
			if (imageList1.Images != null && imageList1.Images.Count > 0) imageList1.Images.Clear();

			PluginMan.pluginsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "plugins");
			PluginMan.inputType = "bitmap";

			PluginInfo[] plugins = PluginMan.GetPluginsCache(Properties.Settings.Default.PluginsCache);
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
					if (j != plugins[i].authors.Length - 1) authors += ", ";
				}

				var listViewItem = new ListViewItem(new string[] {
					plugins[i].title,
					plugins[i].description.Get(Properties.Settings.Default.Language),
					authors,
					"v" + plugins[i].version
				});

				Image img = PluginMan.GetPluginIcon(plugins[i].name, plugins[i].functions[0].name, DarkMode);
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
			Text = LangMan.Get("plugin-manager");
			listView1.Columns[0].Text = LangMan.Get("plugin");
			listView1.Columns[1].Text = LangMan.Get("desc");
			listView1.Columns[2].Text = LangMan.Get("created-by");
			listView1.Columns[3].Text = LangMan.Get("version");
			addPluginBtn.Text = " " + LangMan.Get("browse-for-plugins");
			deleteBtn.Text = LangMan.Get("delete-plugin");
			openFileDialog1.Title = LangMan.Get("browse-for-plugins");
			morePluginsBtn.Text = " " + LangMan.Get("more-plugins");
			pluginWebsiteBtn.Text = LangMan.Get("plugin-website");
			infoTooltip.SetToolTip(refreshBtn, LangMan.Get("reload-plugins"));
			infoTooltip.SetToolTip(closeBtn, NativeMan.GetMessageBoxText(NativeMan.DialogBoxCommandID.IDCLOSE) + " | Alt+F4");
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void addPluginBtn_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK) installZip(openFileDialog1.FileName);
			openFileDialog1.Dispose();
		}

		private void installZip(string pathToZip)
		{
			if (Path.GetExtension(pathToZip) == ".zip")
			{
				ZipFile.ExtractToDirectory(pathToZip, Path.Combine(PluginMan.pluginsFolder));
				RefreshPluginsList();
			}
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedIndices != null && listView1.SelectedIndices.Count > 0) deletePlugin(listView1.SelectedIndices[0]);
		}

		private void deletePlugin(int numberInList)
		{
			DialogResult window = DialogMan.ShowConfirm(
				this,
				LangMan.Get("delete-plugin-warning"),
				windowTitle: LangMan.Get("warning"),
				yesBtnText: LangMan.Get("delete-plugin"),
				yesBtnImage: deleteBtn.Image,
				darkMode: DarkMode,
				topMost: TopMost
			);

			if (window == DialogResult.Yes)
			{
				listView1.Items[numberInList].Remove();
				imageList1.Images[numberInList].Dispose();
				
				string pluginFolder = Path.Combine(PluginMan.pluginsFolder, codenames[numberInList]);
				if (File.Exists(pluginFolder))
				{
					FileMan.MoveFileOrFolderToRecycleBin(pluginFolder);
				}
				else
				{
					DialogMan.ShowInfo(
						this,
						LangMan.Get("plugin-not-found"),
						LangMan.Get("error"),
						DarkMode,
						TopMost
					);
				}
				RefreshPluginsList();
			}
		}

		private void morePluginsBtn_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/ModuleArt/qpv-plugins");
		}

		private void pluginWebsiteBtn_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedIndices != null && listView1.SelectedIndices.Count > 0) Process.Start(pluginsLinks[listView1.SelectedIndices[0]]);
		}

		private void AutoSizeColumns()
		{
			float x = listView1.Width / 100f;
			listView1.Columns[0].Width = (int)(x * 20);
			listView1.Columns[1].Width = (int)(x * 40);
			listView1.Columns[2].Width = (int)(x * 30);
			listView1.Columns[3].Width = (int)(x * 10);
		}

		private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
		{
			e.Cancel = true;
			e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
		}

		private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			bool status = false;
			if (listView1.SelectedIndices != null && listView1.SelectedIndices.Count > 0) status = true;
			deleteBtn.Enabled = status;
			pluginWebsiteBtn.Enabled = status;
		}

		private void PluginManForm_DragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
			installZip(files[0]);
		}

		private void PluginManForm_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
		}

		private void refreshBtn_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.PluginsCache = PluginMan.GenerateCacheStr();
			Properties.Settings.Default.Save();
			RefreshPluginsList();
			(Owner as MainForm).ReloadPlugins();
		}
	}
}
