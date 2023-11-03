using DesignPatterns.AbstractFactory.Models.Ingredients.Cheeses;
using DesignPatterns.AbstractFactory.Models.Ingredients.Doughs;
using DesignPatterns.AbstractFactory.Models.Ingredients.Sauces;
using DesignPatterns.AbstractFactory.Models.Ingredients.Veggies;

namespace DesignPatterns.AbstractFactory.Factories.Florida
{
    public class FLPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new MozzarrellaCheese();
        }

        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public List<IVeggie> CreateVeggies()
        {
            return new List<IVeggie>() { new Onion(), new Garlic() };
        }
    }
}
