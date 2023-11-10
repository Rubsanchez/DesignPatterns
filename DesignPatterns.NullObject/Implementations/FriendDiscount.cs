using DesignPatterns.NullObject.Interface;

namespace DesignPatterns.NullObject.Implementations
{
    public class FriendDiscount : IDiscount
    {
        public double CalculateDiscount(double productCost)
        {
            return productCost * 0.6;
        }
    }
}
