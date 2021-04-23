using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_Figures
{
    class Vierkant : Rechthoek
    {
        public Vierkant(int hoogte, int breedte)
        {
            breedte = hoogte;
            Breedte = breedte;
            Hoogte = hoogte;
        }
        public Vierkant(int lengte)
        {
            Breedte = lengte;
            Hoogte = lengte;
        }

        public override int BerekenOppervlakte()
        {
            return base.BerekenOppervlakte();
        }
    }
}
