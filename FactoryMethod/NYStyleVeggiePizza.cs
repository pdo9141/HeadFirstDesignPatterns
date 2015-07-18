using System;

namespace FactoryMethod
{
    class NYStyleVeggiePizza : Pizza
    {
        internal NYStyleVeggiePizza()
        {
            base.Name = "NY Style Veggie Pizza";
            base.Dough = "Think Crust Dough";
            base.Sauce = "Marinara Sauce";
            base.Cheese = "Reggiano Cheese";
            base.toppings.Add("Pepper");
            base.toppings.Add("Onion");
            base.toppings.Add("Garlic");
        }
    }
}
