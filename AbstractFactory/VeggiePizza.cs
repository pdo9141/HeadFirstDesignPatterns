using System;

namespace AbstractFactory
{
    internal class VeggiePizza : Pizza
    {
        internal VeggiePizza(PizzaIngredientFactory ingredientFactory)
        {
            base.ingredientFactory = ingredientFactory;
        }

        internal override void Prepare()
        {
            Console.WriteLine("Preparing " + base.Name);
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            veggies = ingredientFactory.CreateVeggies();
        }
    }
}
