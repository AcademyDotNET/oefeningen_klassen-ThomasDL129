using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren
{
    class Driehoek
    {
        private double hoogte;
        private double basis;
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
        public double Basis
        {
            get { return basis; }
            set
            {
                if (value > 1)
                {
                    basis = value;
                }
            }
        }

        public void ToonOppervlakte()
        {
            Console.WriteLine($"Oppervlakte van {this} is {(Hoogte * Basis) / 2}");
        }
    }
}
