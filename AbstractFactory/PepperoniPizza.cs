using System;

namespace AbstractFactory
{
    internal class PepperoniPizza : Pizza
    {
        internal PepperoniPizza(PizzaIngredientFactory ingredientFactory)
        {
            base.ingredientFactory = ingredientFactory;
        }

        internal override void Prepare()
        {
            Console.WriteLine("Preparing " + base.Name);
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            pepperoni = ingredientFactory.CreatePepperoni();
        }
    }
}
