using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Een_Eigen_Huis
{
    class Gang : Kamer
    {
        public override double Prijs
        {
            get
            {
                return Oppervlakte * 10;
            }
        }
        public Gang(string naam, double oppervlakte) : base(naam, oppervlakte)
        {

        }
    }
}
