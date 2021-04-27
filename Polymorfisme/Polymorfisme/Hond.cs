using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfisme
{
    class Hond : Dier
    {
        public override void Zegt()
        {
            Console.WriteLine("Waf");
        }

        public override string ToString()
        {
            return "Hond";
        }
    }
}
