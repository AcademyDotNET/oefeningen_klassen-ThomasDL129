using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boek
{
    class CoffeeTableBook : Book
    {
        public override double Price
        {
            get { return price; }
            set
            {
                if (value < 35)
                {
                    price = 35;
                }
                else if (value > 100)
                {
                    price = 100;
                }
                else
                {
                    price = value;
                }
            }
        }
    }
}
