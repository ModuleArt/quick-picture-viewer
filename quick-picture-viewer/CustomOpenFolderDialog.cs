using Microsoft.WindowsAPICodePack.Dialogs;
using QuickLibrary;

namespace quick_picture_viewer
{
	class CustomOpenFolderDialog
	{
		public static string GetFolder()
		{
			CommonOpenFileDialog dialog = new CommonOpenFileDialog();
			dialog.IsFolderPicker = true;
			dialog.Title = LangMan.Get("open-recursive");
			if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
			{
				string p = dialog.FileName;
				dialog.Dispose();
				return p;
			}
			return null;
		}
	}
}
