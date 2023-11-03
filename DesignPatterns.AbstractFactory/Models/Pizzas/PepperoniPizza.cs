using DesignPatterns.AbstractFactory.Factories;

namespace DesignPatterns.AbstractFactory.Models.Pizzas
{
    public class PepperoniPizza : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            Type = PizzaType.Pepperoni;
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
