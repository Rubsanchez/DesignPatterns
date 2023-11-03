using DesignPatterns.AbstractFactory.Models.Pizzas;

namespace DesignPatterns.AbstractFactory.Factories
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
