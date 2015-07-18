namespace AbstractFactory
{
    class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            switch (type)
            {
                case "Cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.Name = "NY Style Cheese Pizza";
                    break;
                case "Pepperoni":
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.Name = "NY Style Pepperoni Pizza";
                    break;
                case "Clam":
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.Name = "NY Style Clam Pizza";
                    break;
                case "Veggie":
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.Name = "NY Style Veggie Pizza";
                    break;
            }

            return pizza;
        }
    }
}
