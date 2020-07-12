using System.Reflection;
using System.Windows.Shell;

namespace quick_picture_viewer
{
    public class CustomJumplist
    {
        private JumpList list;

        public CustomJumplist()
        {
            JumpItem[] jumpItems = { new JumpTask() { 
                Title = "New window",
                Description = "Create new QuickPictureViewer window",
                ApplicationPath = Assembly.GetEntryAssembly().Location,
                Arguments = "-1",
                IconResourcePath = "quick-picture-viewer.exe"
            } };

            list = new JumpList(jumpItems, true, true);
            list.Apply();
        }
    }
}
