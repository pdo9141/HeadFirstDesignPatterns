using System;

namespace SimpleFactory
{
    class CheesePizza : Pizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing cheese pizza.");
        }

        public void Bake()
        {
            Console.WriteLine("Baking cheese pizza.");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting cheese pizza.");
        }

        public void Box()
        {
            Console.WriteLine("Boxing cheese pizza.");
        }
    }
}
