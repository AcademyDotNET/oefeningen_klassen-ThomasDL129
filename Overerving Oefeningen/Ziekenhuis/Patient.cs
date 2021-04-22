using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ziekenhuis
{
    class Patient
    {
        public string Naam { get; set; }
        public int AantalUurVerblijf { get; set; }


        public Patient(string naam, int aantUren)
        {
            Naam = naam;
            AantalUurVerblijf = aantUren;
        }

        public virtual int BerekenKost()
        {
            return 50 + 20 * AantalUurVerblijf;
        }

        public void ToonInfo()
        {
            Console.WriteLine($"Naam: {Naam}\nVerblijf in uren: {AantalUurVerblijf}\nTotale kost: {BerekenKost()}");
        }
    }
}
