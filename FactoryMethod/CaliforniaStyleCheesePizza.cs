using System;

namespace FactoryMethod
{
    internal class CaliforniaStyleCheesePizza : Pizza
    {
        internal CaliforniaStyleCheesePizza()
        {
            base.Name = "Cali Style Cheese Pizza";
            base.Dough = "Super Thin Dough";
            base.Sauce = "Chili Sauce";
            base.Cheese = "Pepperjack Cheese";
        }
    }
}
