using DesignPatterns.FactoryMethod.Models;

namespace DesignPatterns.FactoryMethod.Factories
{
    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(PizzaType name);

        public Pizza OrderPizza(PizzaType type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
