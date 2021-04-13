using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren
{
    class Rechthoek
    {
        private double hoogte;
        private double breedte;
        public double Hoogte
        {
            get { return hoogte; }
            set
            {
                if (value > 1)
                {
                    hoogte = value;
                }
            }
        }
        public double Breedte
        {
            get { return breedte; }
            set
            {
                if (value > 1)
                {
                    breedte = value;
                }
            }
        }

        public void ToonOppervlakte()
        {
            Console.WriteLine($"Oppervlakte van {this} is {Hoogte * Breedte}");
        }
    }
}
