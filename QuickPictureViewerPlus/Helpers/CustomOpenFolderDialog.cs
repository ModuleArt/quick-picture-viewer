using Microsoft.WindowsAPICodePack.Dialogs;

namespace QuickPictureViewerPlus
{
	class CustomOpenFolderDialog
	{
		public static string GetFolder(string title)
		{
			CommonOpenFileDialog dialog = new CommonOpenFileDialog();
			dialog.IsFolderPicker = true;
			dialog.Title = title;
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
