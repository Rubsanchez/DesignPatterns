using DesignPatterns.FactoryMethod.Factories;

namespace DesignPatterns.FactoryMethod.Models
{
    public abstract class Pizza
    {
        public PizzaType Type { get; set; }
        protected string Dough;
        protected string Sauce;
        protected List<string> Toppings = new();

        public void Prepare()
        {
            Console.WriteLine($"Preparing: {Type}");
            Console.WriteLine($"Putting dough: {Dough}");
            Console.WriteLine($"Adding sauce: {Sauce}");
            Console.WriteLine($"Adding toppings: {string.Join(",", Toppings)}");
        }

        public void Bake() => Console.WriteLine("Cook for 20 min");
        public void Cut() => Console.WriteLine("Pizza was cut in same parts");
        public void Box() => Console.WriteLine("Pizza was put in official box");
    }
}
