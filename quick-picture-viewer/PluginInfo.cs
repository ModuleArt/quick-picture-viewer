using Newtonsoft.Json;
using System.IO;

namespace quick_picture_viewer
{
	class PluginInfo
	{
		// STRUCTS

		public struct Author
		{
			public string name;
			public string link;
		}

		public struct Target
		{
			public string name;
			public string minVersion;
			public string maxVersion;
		}

		public struct Hotkey
		{
			public bool ctrl;
			public bool shift;
			public int key;
		}

		public struct MultilangString
		{
			public string en;
			public string ru;

			public string Get(string langCode)
			{
				string value;
				switch (langCode)
				{
					case "ru":
						value = ru;
						break;
					default:
						value = en;
						break;
				}
				return value;
			} 
		}

		public struct Props
		{
			public bool imageRequired;
			public bool configurable;
			public bool returnImage;
		}

		public struct Function
		{
			public string name;
			public MultilangString title;
			public Hotkey hotkey;
			public Props props;
		}

		// VARIABLES

		public string name;
		public string version;
		public string title;
		public MultilangString description;
		public string link;
		public Author[] authors;
		public Target[] targets;
		public Function[] functions;
		public string dllType;

		// CONSTRUCTOR

		public PluginInfo()
		{

		}

		// STATIC METHODS

		public static PluginInfo FromJson(string json)
		{
			return JsonConvert.DeserializeObject<PluginInfo>(json);
		}
	}
}
