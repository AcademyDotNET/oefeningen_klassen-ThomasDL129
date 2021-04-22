using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hidden_Bookmarks
{
    class HiddenBookmark : Bookmark
    {
        public override void OpenSite()
        {
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "-incognito " + URL);  //Voeg bovenaan using System.Diagnostics; toe
        }

    }
}
