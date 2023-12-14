using QuickLibrary;

namespace QuickPictureViewerPlus
{
	public static class ShellManager
	{
		public static bool ShowFileProperties(string Filename)
		{
			NativeMan.SHELLEXECUTEINFO info = new NativeMan.SHELLEXECUTEINFO();
			info.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(info);
			info.lpVerb = "properties";
			info.lpFile = Filename;
			info.nShow = NativeMan.SW_SHOW;
			info.fMask = NativeMan.SEE_MASK_INVOKEIDLIST;
			return NativeMan.ShellExecuteEx(ref info);
		}
	}
}
