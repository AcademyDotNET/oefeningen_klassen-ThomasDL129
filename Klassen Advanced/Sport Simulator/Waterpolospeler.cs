using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Simulator
{
    public enum Reeks { Cadet, Tweedeklas, Eersteklas }
    class Waterpolospeler
    {
        private string spelerNaam;
        private int mutsNummer;
        private bool isDoelman;
        private bool isReserve;
        private Reeks reeks;

        public string SpelerNaam
        {
            get { return spelerNaam; }
            set
            {
                if (value != string.Empty)
                {
                    spelerNaam = value;
                }
            }
        }
        public int MutsNummer
        {
            get { return mutsNummer; }
            set
            {
                if (value > 0 && value <= 13)
                {
                    mutsNummer = value;
                }
            }
        }
        public bool IsDoelman
        {
            get { return isDoelman; }
            set { isDoelman = value; }
        }
        public bool IsReserve
        {
            get { return isReserve; }
            set { isReserve = value; }
        }
        public Reeks Reeks
        {
            get { return reeks; }
            set { reeks = value; }
        }

        public Waterpolospeler(string spelernaam, int mutsNummer, bool isDoelman, bool isReserve, Reeks reeks)
        {
            SpelerNaam = spelernaam;
            MutsNummer = mutsNummer;
            IsDoelman = isDoelman;
            IsReserve = isReserve;
            Reeks = reeks;
        }

        public void Gooibal()
        {
            Console.WriteLine($"{SpelerNaam} gooit de bal.");
        }

        public void Watertrappen()
        {
            Console.WriteLine($"{SpelerNaam} zwemt wat verder.");
        }

        public void GeefSpelerWeer()
        {
            Console.WriteLine($"\nSpeler info:\nnaam: {SpelerNaam}\nnummer: {mutsNummer}\ndoelman: {IsDoelman}\nop reserve: {IsReserve}\nreeks: {Reeks}");
        }

        public static void SimuleerSpeler(Waterpolospeler testspeler)
        {
            for(int i = 0; i < 3; i++)
            {
                testspeler.Gooibal();
                testspeler.Watertrappen();
            }
        }

        public static void SimuleerWedstrijd(Waterpolospeler speler1, Waterpolospeler speler2)
        {
            Random r = new Random();

            if (r.Next(1, 3) == 1)
            {
                Console.WriteLine("\nSpeler 1 wint.");
                speler1.GeefSpelerWeer();
            }
            else
            {
                Console.WriteLine("\nSpeler 2 wint.");
                speler2.GeefSpelerWeer();
            }
        }
        public static Waterpolospeler BesteSpeler(Waterpolospeler speler1, Waterpolospeler speler2)
        {
            Random r = new Random();

            if (r.Next(1, 3) == 1)
            {
                Console.WriteLine("\nSpeler 1 is de beste speler.");
                return speler1;
            }
            else
            {
                Console.WriteLine("\nSpeler 2 is de beste speler.");
                return speler2;
            }
        }
    }
}
