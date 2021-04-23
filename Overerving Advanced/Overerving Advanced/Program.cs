using System;

namespace Overerving_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            Console.WriteLine(pokemon);

            HiddenBookmark hbm = new HiddenBookmark();
            hbm.Naam = "Google";
            hbm.URL = "www.google.be";
            Bookmark bm = new Bookmark();
            bm.Naam = "Google";
            bm.URL = "www.google.be";
            Console.WriteLine(hbm);
            Console.WriteLine(bm);
        }
    }
}
