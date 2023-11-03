using DesignPatterns.AbstractFactory.Models.Ingredients.Cheeses;
using DesignPatterns.AbstractFactory.Models.Ingredients.Doughs;
using DesignPatterns.AbstractFactory.Models.Ingredients.Sauces;
using DesignPatterns.AbstractFactory.Models.Ingredients.Veggies;

namespace DesignPatterns.AbstractFactory.Factories
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        List<IVeggie> CreateVeggies();
    }
}
