using System;

namespace FactoryMethod
{
    internal class NYStyleCheesePizza : Pizza
    {
        internal NYStyleCheesePizza()
        {
            base.Name = "NY Style Cheese Pizza";
            base.Dough = "Think Crust Dough";
            base.Sauce = "Marinara Sauce";
            base.Cheese = "Reggiano Cheese";
        }
    }
}
