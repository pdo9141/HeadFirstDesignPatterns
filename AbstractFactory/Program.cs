using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYPizzaStore();
            
            Console.WriteLine(nyPizzaStore.OrderPizza("Cheese"));
            Console.WriteLine();

            Console.WriteLine(nyPizzaStore.OrderPizza("Pepperoni"));
            Console.WriteLine();

            Console.WriteLine(nyPizzaStore.OrderPizza("Veggie"));
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
