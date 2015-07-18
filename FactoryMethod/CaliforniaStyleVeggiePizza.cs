using System;

namespace FactoryMethod
{
    internal class CaliforniaStyleVeggiePizza : Pizza
    {
        internal CaliforniaStyleVeggiePizza()
        {
            base.Name = "Cali Style Veggie Pizza";
            base.Dough = "Super Thin Dough";
            base.Sauce = "Chili Sauce";
            base.Cheese = "Pepperjack Cheese";
            base.toppings.Add("Pineapple");
            base.toppings.Add("Jalapeno");
            base.toppings.Add("Strawberries");
        }

        override internal void Cut()
        {
            Console.WriteLine("Cutting the pizza into triangle slices");
        }
    }
}
