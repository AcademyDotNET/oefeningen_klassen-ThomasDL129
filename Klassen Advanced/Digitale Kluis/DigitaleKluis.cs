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
        private int aantalPogingen = 0;

        public int Code
        {
            get 
            {
                if (CanShowCode)
                {
                    return code;
                }
                else
                {
                    return -666;
                }
            }
            private set { code = value; }
        }
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

        public bool TryCode(int trialCode)
        {
            aantalPogingen++;
            if (trialCode == -666)
            {
                Console.WriteLine("Cheater.");
                return false;
            }
            else if (trialCode == code)
            {
                Console.WriteLine("Dat was de juiste code!");
                Console.WriteLine($"Je hebt {aantalPogingen} pogingen erover gedaan.");
                return true;
            }
            else
            {
                Console.WriteLine("Foute code");
                return false;
            }
        }
    }
}
