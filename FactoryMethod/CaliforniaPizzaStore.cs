namespace FactoryMethod
{
    class CaliforniaPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case "Cheese":
                    pizza = new CaliforniaStyleCheesePizza();
                    break;
                case "Pepperoni":
                    pizza = new CaliforniaStylePepperoniPizza();
                    break;
                case "Clam":
                    pizza = new CaliforniaStyleClamPizza();
                    break;
                case "Veggie":
                    pizza = new CaliforniaStyleVeggiePizza();
                    break;
            }

            return pizza;
        }
    }
}
