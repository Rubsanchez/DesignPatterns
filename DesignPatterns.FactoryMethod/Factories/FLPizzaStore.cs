using DesignPatterns.FactoryMethod.Models;

namespace DesignPatterns.FactoryMethod.Factories
{
    public class FLPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaType type)
        {
            return (Pizza)Activator
                .CreateInstance(Type.GetType($"DesignPatterns.FactoryMethod.Models.FL{type}Pizza")!)!;
        }
    }
}
