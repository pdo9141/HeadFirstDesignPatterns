using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore = new PizzaStore(new SimplePizzaFactory());
            pizzaStore.OrderPizza("Cheese");
            Console.ReadLine();
        }
    }
}
