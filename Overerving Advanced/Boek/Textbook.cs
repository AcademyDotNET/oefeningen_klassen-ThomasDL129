using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boek
{
    class Textbook : Book
    {
        public int GradeLevel { get; set; }

        public override double Price
        {
            get { return price; }
            set 
            {
                if (value < 20)
                {
                    price = 20;
                }
                else if (value > 80)
                {
                    price = 80;
                }
                else
                {
                    price = value;
                }
            }
        }
    }
}
