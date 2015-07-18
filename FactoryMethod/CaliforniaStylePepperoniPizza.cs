using System;

namespace FactoryMethod
{
    internal class CaliforniaStylePepperoniPizza : Pizza
    {
        internal CaliforniaStylePepperoniPizza()
        {
            base.Name = "Cali Style Cheese Pizza";
            base.Dough = "Super Thin Dough";
            base.Sauce = "Chili Sauce";
            base.Cheese = "Pepperjack Cheese";
            base.toppings.Add("Surfer Pepperoni");
        }
    }
}
