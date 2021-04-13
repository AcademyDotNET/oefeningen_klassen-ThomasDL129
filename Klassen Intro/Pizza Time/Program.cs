using System;

namespace Pizza_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new Pizza();
            Pizza pizza2 = new Pizza();
            Pizza pizza3 = new Pizza();

            pizza1.Toppings = "tomaat en mozzarella";
            pizza1.Diameter = 16;
            pizza1.Price = 12.0;

            pizza2.Toppings = "gorgonzola, mozzarella, pecorino en taleggio";
            pizza2.Diameter = 20;
            pizza2.Price = 18.0;

            pizza3.Toppings = "tomaat, mozzarella, champignons en zwarte olijven";
            pizza3.Diameter = 18;
            pizza3.Price = 16.0;

            pizza1.GeefPizzaWeer();
            pizza2.GeefPizzaWeer();
            pizza3.GeefPizzaWeer();
        }
    }
}
