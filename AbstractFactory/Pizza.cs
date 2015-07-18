using System;
using System.Text;

namespace AbstractFactory
{
    internal abstract class Pizza
    {
        internal string Name { get; set; }
        protected Dough dough;
        protected Sauce sauce;
        protected Cheese cheese;
        protected Pepperoni pepperoni;
        protected Clams clams;
        protected Veggie[] veggies;
        protected PizzaIngredientFactory ingredientFactory;

        internal abstract void Prepare();

        internal void Bake() 
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        internal void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        internal void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dough: " + dough.Name);
            sb.AppendLine("Sauce: " + sauce.Name);
            sb.AppendLine("Cheese: " + cheese.Name);

            if (pepperoni != null)
                sb.AppendLine("Pepperoni: " + pepperoni.Name);

            if (clams != null)
                sb.AppendLine("Clams: " + clams.Name);

            if (veggies != null)
            {
                sb.Append("Veggie: ");
                foreach (Veggie veggie in veggies)
                {
                    sb.Append(String.Format("{0}, ", veggie.Name));
                }
            }

            return sb.ToString();
        }
    }
}
