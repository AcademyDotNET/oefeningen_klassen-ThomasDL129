using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitale_Kluis
{
    class DigitaleKluis
    {
        private int code;

        private bool canShowCode;

        public bool CanShowCode
        {
            get { return canShowCode; }
            set { canShowCode = value; }
        }

        public int CodeLevel
        {
            get 
            { 
                return code / 1000; 
            }
        }


        public DigitaleKluis(int getal)
        {
            code = getal;
        }
    }
}
