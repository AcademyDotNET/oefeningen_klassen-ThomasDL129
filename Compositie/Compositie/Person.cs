using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compositie
{
    class Person
    {
        public Head Head { get; set; }
        public Leg[] Legs { get; set; }
        public Hand[] Hands { get; set; }

        public Person()
        {
            Legs = new Leg[2];
            Hands = new Hand[2];

            for (int i = 0; i < 2; i++)
            {
                Legs[i] = new Leg();
                Hands[i] = new Hand();
            }
        }
    }
}
