using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compositie
{
    class Engine
    {
        public Crankshaft Crankshaft { get; set; }
        public Piston[] Pistons { get; set; }

        public Engine()
        {
            Crankshaft = new Crankshaft();
            Pistons = new Piston[8];

            for (int i = 0; i < 4; i++)
            {
                Pistons[i] = new Piston();
            }
        }
    }
}
