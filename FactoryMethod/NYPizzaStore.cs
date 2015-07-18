namespace FactoryMethod
{
    class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case "Cheese":
                    pizza = new NYStyleCheesePizza();
                    break;
                case "Pepperoni":
                    pizza = new NYStylePepperoniPizza();
                    break;
                case "Clam":
                    pizza = new NYStyleClamPizza();
                    break;
                case "Veggie":
                    pizza = new NYStyleVeggiePizza();
                    break;
            }

            return pizza;
        }
    }
}
