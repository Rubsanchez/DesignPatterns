using DesignPatterns.Decorator.Interfaces;

namespace DesignPatterns.Decorator.Decorators
{
    public abstract class CondimentDecorator : ICoffee
    {
        protected ICoffee Coffee;
        protected double Price = default;
        protected string Name = string.Empty;

        protected CondimentDecorator(ICoffee coffee)
        {
            Coffee = coffee;
        }

        public double GetCost()
        {
            return Coffee.GetCost() + Price;
        }

        public string GetDescription()
        {
            return $"{Coffee.GetDescription()}, {Name}";
        }
    }
}
