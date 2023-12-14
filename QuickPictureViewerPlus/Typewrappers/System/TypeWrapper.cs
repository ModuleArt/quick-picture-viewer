namespace QuickPictureViewerPlus
{
	public abstract class TypeWrapper
	{
		public string TypeName;
		public bool ShowTypeOps;
		public abstract FileTypeMan.OpenResult Open(string path);
	}
}
