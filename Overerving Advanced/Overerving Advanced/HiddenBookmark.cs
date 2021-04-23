using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerving_Advanced
{
    class HiddenBookmark : Bookmark
    {
        public override void OpenSite()
        {
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "-incognito " + URL);  //Voeg bovenaan using System.Diagnostics; toe
        }


        public override string ToString()
        {
            return base.ToString() + "\t---HIDDEN---";
        }
    }
}
