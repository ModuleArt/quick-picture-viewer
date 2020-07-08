using System;
using Microsoft.WindowsAPICodePack.Taskbar;
using System.Reflection;

namespace quick_picture_viewer
{
    public class CustomJumplist
    {
        private JumpList list;

        public CustomJumplist(IntPtr windowHandle)
        {
            //list = JumpList.CreateJumpListForIndividualWindow(TaskbarManager.Instance.ApplicationId, windowHandle);
            list = JumpList.CreateJumpList();
            list.KnownCategoryToDisplay = JumpListKnownCategoryType.Recent;
            BuildList();
        }

        private void BuildList()
        {
            JumpListCustomCategory tasksCategory = new JumpListCustomCategory("Tasks");

            JumpListLink newWindowTask = new JumpListLink(Assembly.GetEntryAssembly().Location, "New window");
            newWindowTask.Arguments = "-1";

            tasksCategory.AddJumpListItems(newWindowTask);
            list.AddCustomCategories(tasksCategory);

            list.Refresh();
        }
    }
}
