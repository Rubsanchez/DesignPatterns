using DesignPatterns.NullObject.Interface;

namespace DesignPatterns.NullObject.Implementations
{
    public class StudentDiscount : IDiscount
    {
        public double CalculateDiscount(double productCost)
        {
            return productCost * 0.5;
        }
    }
}
