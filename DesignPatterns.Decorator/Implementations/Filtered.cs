using DesignPatterns.Decorator.Interfaces;

namespace DesignPatterns.Decorator.Implementations
{
    public class Filtered : ICoffee
    {
        public string GetDescription()
        {
            return "Simple filtered";
        }

        public double GetCost()
        {
            return 5.65;
        }
    }
}