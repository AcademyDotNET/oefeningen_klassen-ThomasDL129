using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Een_Eigen_Huis
{
    class Badkamer : Kamer
    {
        public override double Prijs { get; } = 500;

        public Badkamer(string naam, double oppervlakte):base(naam, oppervlakte)
        {

        }
    }
}
