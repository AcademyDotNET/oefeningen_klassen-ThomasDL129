using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_Figures
{
    abstract class GeometricFigure
    {
        public int Hoogte { get; set; }
        public int Breedte { get; set; }
        public int Oppervlakte { get; }

        public abstract int BerekenOppervlakte();
    }
}
