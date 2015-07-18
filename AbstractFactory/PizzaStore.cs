using System;

namespace AbstractFactory
{
    internal abstract class PizzaStore
    {
        internal Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            
            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
