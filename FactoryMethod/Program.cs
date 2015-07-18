using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYPizzaStore();
            PizzaStore californiaPizzaStore = new CaliforniaPizzaStore();

            nyPizzaStore.OrderPizza("Veggie");
            Console.WriteLine();
            
            californiaPizzaStore.OrderPizza("Veggie");
            Console.WriteLine();
            
            Console.ReadLine();
        }
    }
}
