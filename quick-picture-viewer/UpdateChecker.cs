using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick_picture_viewer
{
	public class UpdateChecker
	{
		private IReleasesClient _releaseClient;
		internal GitHubClient Github;

		internal string CurrentVersion;
		internal string RepositoryOwner;
		internal string RepostoryName;
		internal Release LatestRelease;

		public UpdateChecker(string owner, string name)
		{
			string version = System.Windows.Forms.Application.ProductVersion;

			Github = new GitHubClient(new ProductHeaderValue(name + @"-UpdateCheck"));
			_releaseClient = Github.Release;

			RepositoryOwner = owner;
			RepostoryName = name;
			CurrentVersion = version;
		}

		public async Task<bool> CheckUpdate()
		{
			var releases = await _releaseClient.GetAll(RepositoryOwner, RepostoryName);
			LatestRelease = releases[0];

			string[] curDots = CurrentVersion.Split('.');
			int curMajor = Convert.ToInt32(curDots[0]);
			int curMinor = Convert.ToInt32(curDots[1]);
			int curPatch = Convert.ToInt32(curDots[2]);

			for (int i = 0; i < releases.Count; i++)
			{
				string[] dots = releases[i].TagName.Substring(1, releases[i].TagName.Length - 1).Split('.');
				int major = Convert.ToInt32(dots[0]);
				int minor = Convert.ToInt32(dots[1]);
				int patch = Convert.ToInt32(dots[2]);

				if (major > curMajor)
				{
					return true;
				}
				else if (major == curMajor)
				{
					if (minor > curMinor)
					{
						return true;
					}
					else if (minor == curMinor)
					{
						if (patch > curPatch)
						{
							return true;
						}
					}
				}
			}

			return false;
		}

		public async Task<string> RenderReleaseNotes()
		{
			if (LatestRelease == null) { 
				throw new InvalidOperationException(); 
			}
			return await Github.Miscellaneous.RenderRawMarkdown(LatestRelease.Body);
		}

		public void DownloadAsset(string assetname)
		{
			const string template = "https://github.com/{0}/{1}/releases/download/{2}/{3}";
			var url = string.Format(template, RepositoryOwner, RepostoryName, LatestRelease.TagName, assetname);

			System.Diagnostics.Process.Start(url);
		}
	}
}
