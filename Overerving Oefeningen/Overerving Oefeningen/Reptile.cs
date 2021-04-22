using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerving_Oefeningen
{
    class Reptile : Animal
    {
        public int AantalSchubben { get; set; }

        public Reptile(int aantalSchubben, int aantalPoten) : base(aantalPoten)
        {
            AantalSchubben = aantalSchubben;
        }

        public override void ToonInfo()
        {
            base.ToonInfo();
            Console.WriteLine("Schubben: " + AantalSchubben);
        }
    }
}
