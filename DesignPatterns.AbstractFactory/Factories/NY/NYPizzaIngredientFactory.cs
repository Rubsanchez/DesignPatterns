using DesignPatterns.AbstractFactory.Models.Ingredients.Cheeses;
using DesignPatterns.AbstractFactory.Models.Ingredients.Doughs;
using DesignPatterns.AbstractFactory.Models.Ingredients.Sauces;
using DesignPatterns.AbstractFactory.Models.Ingredients.Veggies;

namespace DesignPatterns.AbstractFactory.Factories.NY
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public List<IVeggie> CreateVeggies()
        {
            return new List<IVeggie>() { new Onion(), new Garlic() };
        }
    }
}
