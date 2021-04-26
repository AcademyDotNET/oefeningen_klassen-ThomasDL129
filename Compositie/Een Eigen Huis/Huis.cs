using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Een_Eigen_Huis
{
    class Huis
    {
        public List<Kamer> Kamers { get; set; }

        public Huis()
        {
            Kamers = new List<Kamer>();
        }

        public double BerekenPrijs()
        {
            double total = 0;

            foreach (var item in Kamers)
            {
                total += item.Prijs;
            }

            return total;
        }
    }
}
