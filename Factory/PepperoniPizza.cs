using System;

namespace SimpleFactory
{
    class PepperoniPizza : Pizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing pepperoni pizza.");
        }

        public void Bake()
        {
            Console.WriteLine("Baking pepperoni pizza.");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting pepperoni pizza.");
        }

        public void Box()
        {
            Console.WriteLine("Boxing pepperoni pizza.");
        }
    }
}
