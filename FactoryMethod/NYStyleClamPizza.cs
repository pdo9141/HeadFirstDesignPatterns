using System;

namespace FactoryMethod
{
    internal class NYStyleClamPizza : Pizza
    {
        internal NYStyleClamPizza()
        {
            base.Name = "NY Style Clam Pizza";
            base.Dough = "Think Crust Dough";
            base.Sauce = "Marinara Sauce";
            base.Cheese = "Reggiano Cheese";
            base.toppings.Add("Fresh Eastern Clams");
        }
    }
}
