using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerving_Oefeningen
{
    class Animal
    {
        public int AantalPoten { get; set; }

        public Animal(int aantalPoten)
        {
            AantalPoten = aantalPoten;
        }

        public void BeweegVoort()
        {

        }

        public virtual void ToonInfo()
        {
            Console.WriteLine("poten:" + AantalPoten);
        }
    }
}
