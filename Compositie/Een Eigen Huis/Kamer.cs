using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Een_Eigen_Huis
{
    class Kamer
    {
        protected string naam;
        protected double oppervlakte;

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public double Oppervlakte
        {
            get { return oppervlakte; }
            set { oppervlakte = value; }
        }

        public virtual double Prijs { get; } = 400;

        public Kamer(string naam, double oppervlakte)
        {
            Naam = naam;
            Oppervlakte = oppervlakte;
        }
    }
}
