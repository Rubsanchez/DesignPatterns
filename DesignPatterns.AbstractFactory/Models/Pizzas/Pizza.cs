using DesignPatterns.AbstractFactory.Models.Ingredients.Cheeses;
using DesignPatterns.AbstractFactory.Models.Ingredients.Doughs;
using DesignPatterns.AbstractFactory.Models.Ingredients.Sauces;
using DesignPatterns.AbstractFactory.Models.Ingredients.Veggies;

namespace DesignPatterns.AbstractFactory.Models.Pizzas
{
    public abstract class Pizza
    {
        public PizzaType Type { get; set; }
        protected IDough Dough;
        protected ISauce Sauce;
        protected ICheese Cheese;
        protected List<IVeggie> Veggies = new();

        public abstract void Prepare();

        public void Bake() => Console.WriteLine("Cook for 20 min");
        public void Cut() => Console.WriteLine("Pizza was cut in same parts");
        public void Box() => Console.WriteLine("Pizza was put in official box");
    }
}