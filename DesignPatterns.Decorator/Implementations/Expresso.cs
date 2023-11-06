using DesignPatterns.Decorator.Interfaces;

namespace DesignPatterns.Decorator.Implementations
{
    public class Expresso : ICoffee
    {
        public string GetDescription()
        {
            return "Simple expresso";
        }

        public double GetCost()
        {
            return 3.25;
        }
    }
}
