using System;

namespace FactoryMethod
{
    internal class CaliforniaStyleClamPizza : Pizza
    {
        internal CaliforniaStyleClamPizza()
        {
            base.Name = "Cali Style Clam Pizza";
            base.Dough = "Super Thin Dough";
            base.Sauce = "Chili Sauce";
            base.Cheese = "Pepperjack Cheese";
            base.toppings.Add("Fresh Pacific Clams");
        }
    }
}
