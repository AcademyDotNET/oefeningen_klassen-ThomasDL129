using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiek
{
    class Land
    {
        private President president;
        private Minister premier;
        private List<Minister> ministers;

        public President President
        {
            get { return president; }
            set { president = value; }
        }
        public Minister Premier
        {
            get { return premier; }
            set { premier = value; }
        }
        public List<Minister> Ministers
        {
            get { return ministers; }
            set { ministers = value; }
        }

        public Land()
        {
            ministers = new List<Minister>();
        }

        public void MaakRegering(President elpresidente, List<Minister> ministerie)
        {
            if (President == null)
            {
                President = elpresidente;
                Premier = ministerie[0];

                for (int i = 1; i < ministerie.Count; i++)
                {
                    Ministers.Add(ministerie[i]);
                }
                Console.WriteLine($"Een nieuwe regime werd gevormt met {President.Name} als president en {Premier.Name} als eerste minister.");
            }
            else
            {
                Console.WriteLine("El Presidente tolereert geen coup op zijn regime.");
            }
        }

        public void JaarVerder()
        {
            President.JaarVerder();
            Console.WriteLine("Een jaar loopt verder...");

            if (President.RestJaren == 0)
            {
                President = null;
                Premier = null;
                Ministers.Clear();
                Console.WriteLine("El Presidente moet afstappen en een nieuwe regering moet gekozen worden.");
            }
        }
    }
}
