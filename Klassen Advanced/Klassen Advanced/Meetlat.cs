using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen_Advanced
{
    class Meetlat
    {
        private double beginLengte;


        public double LengteInM
        {
            get { return beginLengte; }
        }
        public double LengteInCm
        {
            get { return beginLengte * 100; }
        }
        public double LengteInKm
        {
            get { return beginLengte / 1000; }
        }
        public double LengteInVoet
        {
            get { return beginLengte * 3.2808; }
        }

        public Meetlat(double lengteInMeter)
        {
            beginLengte = lengteInMeter;
        }
    }
}
