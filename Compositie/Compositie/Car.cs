using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compositie
{
    class Car
    {
        public Wheel[] Wheels { get; set; }
        public Engine Engine { get; set; }

        public Car()
        {
            Wheels = new Wheel[4];

            for (int i = 0; i < Wheels.Length; i++)
            {
                Wheels[i] = new Wheel();
            }
        }
    }
}
