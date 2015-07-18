using System;

namespace AbstractFactory
{
    internal class ClamPizza : Pizza
    {
        internal ClamPizza(PizzaIngredientFactory ingredientFactory)
        {
            base.ingredientFactory = ingredientFactory;
        }

        internal override void Prepare()
        {
            Console.WriteLine("Preparing " + base.Name);
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            clams = ingredientFactory.CreateClams();
        }
    }
}
