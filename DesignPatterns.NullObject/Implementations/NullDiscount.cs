using DesignPatterns.NullObject.Interface;

namespace DesignPatterns.NullObject.Implementations
{
    public class NullDiscount : IDiscount
    {
        public double CalculateDiscount(double productCost)
        {
            return 0;
        }
    }
}
