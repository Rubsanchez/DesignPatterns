using DesignPatterns.AbstractFactory.Models.Pizzas;

namespace DesignPatterns.AbstractFactory.Factories.NY
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaType type)
        {
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            return (Pizza)Activator
                .CreateInstance(Type.GetType($"DesignPatterns.AbstractFactory.Models.Pizzas.{type}Pizza")!, ingredientFactory)!;
        }
    }
}
