using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IGeometricFigure
    {
        public int Hoogte { get; set; }
        public int Breedte { get; set; }
        public int Oppervlakte { get; set; }

        public int BerekenOppervlakte();
    }
}
