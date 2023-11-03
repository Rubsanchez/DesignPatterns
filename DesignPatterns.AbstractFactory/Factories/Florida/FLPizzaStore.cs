using DesignPatterns.AbstractFactory.Models.Pizzas;

namespace DesignPatterns.AbstractFactory.Factories.Florida
{
    public class FLPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaType type)
        {
            IPizzaIngredientFactory ingredientFactory = new FLPizzaIngredientFactory();
            return (Pizza)Activator
                .CreateInstance(Type.GetType($"DesignPatterns.AbstractFactory.Models.Pizzas.{type}Pizza")!, ingredientFactory)!;
        }
    }
}
