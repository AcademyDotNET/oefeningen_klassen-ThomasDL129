using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportspeler
{
    class Waterpolospeler
    {
        private string spelerNaam;

        public string SpelerNaam
        {
            get { return spelerNaam; }
            set 
            {
                if (value != string.Empty)
                {
                    spelerNaam = value;
                }
            }
        }
        private int mutsNummer;

        public int MutsNummer
        {
            get { return mutsNummer; }
            set 
            {
                if (value > 0 && value <= 13)
                {
                    mutsNummer = value;
                }
            }
        }

    }
}
