using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfisme
{
    abstract class Dier
    {
        public int Gewicht { get; set; }

        public abstract void Zegt();
    }
}
