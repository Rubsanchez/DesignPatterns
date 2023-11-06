using DesignPatterns.Decorator.Interfaces;

namespace DesignPatterns.Decorator.Decorators
{
    public class ChocolateDecorator : CondimentDecorator
    {
        protected ChocolateDecorator(ICoffee coffee) : base(coffee)
        {
            Name = "Chocolate";
            Price = 0.50;
        }
    }
}
