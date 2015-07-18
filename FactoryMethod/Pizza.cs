using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    internal abstract class Pizza
    {
        protected string Name { get; set; }
        protected string Dough { get; set; }
        protected string Sauce { get; set; }
        protected string Cheese { get; set; }
        protected List<string> toppings = new List<string>();

        internal void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing " + Dough);
            Console.WriteLine("Pouring " + Sauce);
            Console.WriteLine("Adding " + Cheese);

            if (toppings != null && toppings.Count > 0)
            {
                Console.Write("Adding toppings:  ");
                foreach (string topping in toppings)
                    Console.Write(String.Format("{0}, ", topping));
            }
        }

        internal void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        internal virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        internal void Box()
        {
            Console.WriteLine("Place pizza in offical PizzaStore box");
        }
    }
}
