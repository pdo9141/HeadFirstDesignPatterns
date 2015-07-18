using System;

namespace FactoryMethod
{
    class NYStylePepperoniPizza : Pizza
    {
        internal NYStylePepperoniPizza()
        {
            base.Name = "NY Style Pepperoni Pizza";
            base.Dough = "Think Crust Dough";
            base.Sauce = "Marinara Sauce";
            base.Cheese = "Reggiano Cheese";
            base.toppings.Add("Spicy Pepperoni");
        }
    }
}
