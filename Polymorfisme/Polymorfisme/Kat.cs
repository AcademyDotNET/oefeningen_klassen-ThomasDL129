using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfisme
{
    class Kat : Dier
    {
        public override void Zegt()
        {
            Console.WriteLine("Meow");
        }

        public override string ToString()
        {
            return "Kat";
        }
    }
}
