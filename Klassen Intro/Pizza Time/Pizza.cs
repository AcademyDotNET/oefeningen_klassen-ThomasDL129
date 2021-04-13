using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Time
{
    class Pizza
    {
        private string toppings;
        private int diameter;
        private double price;

        public string Toppings
        {
            get { return toppings; }
            set 
            { 
                if(value != string.Empty)
                {
                    toppings = value;
                }
            }
        }
        public int Diameter
        {
            get { return diameter; }
            set 
            { 
                if(value > 0)
                {
                    diameter = value;
                }
            }
        }
        public double Price
        {
            get { return price; }
            set 
            {
                if (value >= 0)
                {
                    price = value;
                }
            }
        }

        public void GeefPizzaWeer()
        {
            Console.WriteLine($"\nPizza:\nToppings: {Toppings}\nDiameter: {Diameter}\nPrijs: {Price}");
        }
    }
}
