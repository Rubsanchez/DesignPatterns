using DesignPatterns.Decorator.Interfaces;

namespace DesignPatterns.Decorator.Decorators
{
    public class MilkDecorator : CondimentDecorator
    {
        protected MilkDecorator(ICoffee coffee) : base(coffee)
        {
            Name = "Milk";
            Price = 0.25;
        }
    }
}
