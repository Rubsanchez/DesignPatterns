using DesignPatterns.AbstractFactory.Factories;

namespace DesignPatterns.AbstractFactory.Models.Pizzas
{
    public class CaliforniaPizza : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;

        public CaliforniaPizza(IPizzaIngredientFactory ingredientFactory)
        {
            Type = PizzaType.California;
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing: {Type}");
            Dough = _ingredientFactory.CreateDough();
            Cheese = _ingredientFactory.CreateCheese();
            Sauce = _ingredientFactory.CreateSauce();
            Veggies = _ingredientFactory.CreateVeggies();
        }
    }
}
