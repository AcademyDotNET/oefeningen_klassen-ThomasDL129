using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Een_Eigen_Huis
{
    class Salon : Kamer
    {
        public bool HeeftEenSchouw { get; set; }

        public override double Prijs
        {
            get
            {
                if (HeeftEenSchouw)
                {
                    return 500;
                }
                else
                {
                    return 300;
                }
            }
        }

        public Salon(string naam, double oppervlakte, bool schouw) : base(naam, oppervlakte)
        {
            HeeftEenSchouw = schouw;
        }
    }
}
