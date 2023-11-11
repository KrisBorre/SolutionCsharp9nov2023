using System.Diagnostics;

namespace ConsoleBookmarkManager11nov2023
{
    public class Bookmark11nov2023
    {
        public string Naam { get; set; }        
        public string URL { get; set; }
        
        public virtual void OpenSite()
        {
            Process.Start(@"C:\Program Files\Internet Explorer\iexplore.exe", URL);
        }

        public override string ToString()
        {
            return $"{Naam} ({URL})";
        }
    }
}
