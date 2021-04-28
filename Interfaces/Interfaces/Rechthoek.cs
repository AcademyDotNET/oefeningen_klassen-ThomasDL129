using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Rechthoek : IGeometricFigure, IComparable
    {
        public Rechthoek(int breedte, int hoogte)
        {
            Breedte = breedte;
            Hoogte = hoogte;
        }
        public int Hoogte { get; set; }
        public int Breedte { get; set; }

        public int Oppervlakte { get; set; }

        public int BerekenOppervlakte()
        {
            Oppervlakte = Hoogte * Breedte;
            return Oppervlakte;
        }

        public int CompareTo(object obj)
        {
            Rechthoek temp = (Rechthoek)obj;

            if (Oppervlakte > temp.Oppervlakte)
            {
                return 1;
            }
            if (Oppervlakte < temp.Oppervlakte)
            {
                return -1;
            }
            return 0;
        }

        public override string ToString()
        {
            return $"Rechthoek met breedte {Breedte} en Hoogte {Hoogte}. Oppervlak = {BerekenOppervlakte()}";
        }
    }
}
