namespace AbstractFactory
{
    interface PizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        Pepperoni CreatePepperoni();
        Clams CreateClams();
        Veggie[] CreateVeggies();
    }
}
