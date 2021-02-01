using System.Reflection;
using System.Resources;

namespace quick_picture_viewer
{
	public class LangMan
	{
		private static ResourceManager resMan;

		public static string defaultLang = "en";

		public static void InitResMan(string baseName = null)
		{
			if (baseName == null)
			{
				resMan = new ResourceManager("quick_picture_viewer.languages.lang_" + defaultLang, Assembly.GetExecutingAssembly());
			}
			else
			{
				resMan = new ResourceManager(baseName, Assembly.GetExecutingAssembly());
			}
		}

		public static string GetString(string str)
		{
			return resMan.GetString(str);
		}
	}
}
