using ConsoleBookmarkManager11nov2023;
using System.Diagnostics;

namespace ConsoleBookmarkHidden11nov2023
{
    public class HiddenBookmark11nov2023 : Bookmark11nov2023
    {
        public override void OpenSite()
        {
            Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe", "-private-window " + URL);
        }

        public override string ToString()
        {
            return base.ToString() + "  ---HIDDEN---";
        }
    }
}
