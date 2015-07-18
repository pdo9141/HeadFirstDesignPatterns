namespace SimpleFactory
{
    class SimplePizzaFactory
    {
        internal Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case "Cheese":
                    pizza = new CheesePizza();
                    break;
                case "Pepperoni":
                    pizza = new PepperoniPizza();
                    break;
                case "Clam":
                    pizza = new ClamPizza();
                    break;
                case "Veggie":
                    pizza = new VeggiePizza();
                    break;
            }

            return pizza;
        }
    }
}
