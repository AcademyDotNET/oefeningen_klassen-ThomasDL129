using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportspeler
{
    public enum Reeks {Cadet, Tweedeklas, Eersteklas }
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

        public void StelIn(string spelernaam, int mutsNummer, bool isDoelman, bool isReserve, Reeks reeks)
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
    }
}
