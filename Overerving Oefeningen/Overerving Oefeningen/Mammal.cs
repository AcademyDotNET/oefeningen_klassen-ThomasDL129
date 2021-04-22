using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerving_Oefeningen
{
    class Mammal : Animal
    {
        public string VachtKleur { get; set; }

        public Mammal(string vachtKleur, int aantalPoten) : base(aantalPoten)
        {
            VachtKleur = vachtKleur;
        }
        public override void ToonInfo()
        {
            base.ToonInfo();
            Console.WriteLine("Vachtkleur:" + VachtKleur);
        }
    }
}
