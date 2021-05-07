using System;
using System.Collections.Generic;

namespace Bookmark_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            var favorieten = new List<Bookmark>();

            Console.WriteLine("Geef vijf url's op met daarna een weergavenaam op voorkeur.");

            for (int i = 0; i < 5; i++)
            {
                favorieten.Add(new Bookmark());

                Console.WriteLine("URL: ");
                favorieten[i].URL = Console.ReadLine();
                Console.WriteLine("Naam:");
                favorieten[i].Naam = Console.ReadLine();
            }

            int keuze;

            do
            {
                Console.Clear();
                Console.WriteLine("Welke site wil je bezoeken?");

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{i + 1}. {favorieten[i].Naam}");
                }

                keuze = CheckIntInput();

                if (keuze > 0 && keuze <= favorieten.Count)
                {
                    try
                    {
                        favorieten[keuze - 1].OpenSite();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

            } while (keuze != 0);
        }
        private static int CheckIntInput()
        {
            bool validinput;
            int waarde;

            do
            {
                validinput = int.TryParse(Console.ReadLine(), out waarde);
            } while (!validinput);

            return waarde;
        }
    }
}
