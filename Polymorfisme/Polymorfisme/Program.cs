using System;
using System.Collections.Generic;

namespace Polymorfisme
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var lijst = new List<Dier>();

                LijstVullen(lijst);
                Menu(lijst);
            }

        }

        private static void Menu(List<Dier> lijst)
        {
            var quitMenu = false;
            while (!quitMenu)
            {
                PrintMenu();

                var input = Console.ReadLine().ToLower();
                Console.Clear();
                switch (input)
                {
                    case "a":
                        VerwijderuitLijst(lijst);
                        break;
                    case "b":
                        GewichtGemiddelde(lijst);
                        break;
                    case "c":
                        DierenPraten(lijst);
                        break;
                    case "d":
                        quitMenu = true;
                        lijst.Clear();
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
            }
        }

        private static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Wat wil je graag doen?");
            Console.WriteLine("a. Dier verwijderen\nb. Diergewicht gemiddelde\nc. Dier praten\nd. Opnieuw beginnen\n");
        }

        private static void LijstVullen(List<Dier> lijst)
        {
            var quitAdding = false;

            while (!quitAdding)
            {
                PrintAdding();

                var input = Console.ReadLine();
                Console.Clear();
                switch (input)
                {
                    case "1":
                        lijst.Add(VoegHondToe());
                        break;
                    case "2":
                        lijst.Add(VoegKatToe());
                        break;
                    case "q":
                        quitAdding = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private static void PrintAdding()
        {
            Console.Clear();
            Console.WriteLine("Welke dieren wil je toevoegen? ('q' om te stoppen");
            Console.WriteLine("1. Hond");
            Console.WriteLine("2. Kat");
        }

        private static void DierenPraten(List<Dier> lijst)
        {
            //foreach (var item in lijst)
            //{
            //    item.Zegt();
            //}

            Console.WriteLine("Welke dieren moeten praten?\n1. Honden\n2. Katten\n0. Allemaal");
            int keuze = Convert.ToInt32(Console.ReadLine());

            switch (keuze)
            {
                case 1:
                    foreach (var item in lijst)
                    {
                        //if (item is Hond)
                        if(item.GetType() == typeof(Hond))
                        {
                            item.Zegt();
                        }
                    }
                    break;
                case 2:
                    foreach (var item in lijst)
                    {
                        //if (item is Kat)
                        if(item.GetType() == typeof(Kat))
                        {
                            item.Zegt();
                        }
                    }
                    break;
                case 0:
                    foreach (var item in lijst)
                    {
                        item.Zegt();
                    }
                    break;
                default:
                    break;
            }
        }

        private static void GewichtGemiddelde(List<Dier> lijst)
        {
            int totaal = 0;
            foreach (var item in lijst)
            {
                totaal += item.Gewicht;
            }
            Console.WriteLine(totaal / lijst.Count);
        }

        private static void VerwijderuitLijst(List<Dier> lijst)
        {
            Console.WriteLine("Welk dier wil je verwijderen uit de lijst?");
            lijst.RemoveAt(Convert.ToInt32(Console.ReadLine()) - 1);
        }

        private static Hond VoegHondToe()
        {
            Console.WriteLine("Wat is het gewicht?");
            Hond hond = new Hond();
            hond.Gewicht = Convert.ToInt32(Console.ReadLine());

            return hond;
        }

        private static Kat VoegKatToe()
        {
            Console.WriteLine("Wat is het gewicht?");
            Kat kat = new Kat();
            kat.Gewicht = Convert.ToInt32(Console.ReadLine());

            return kat;
        }
    }
}
