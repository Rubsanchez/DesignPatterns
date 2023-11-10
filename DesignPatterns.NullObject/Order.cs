using DesignPatterns.NullObject.Interface;

namespace DesignPatterns.NullObject
{
    public class Order
    {
        private IDiscount _discount;
        private int _productPrice;

        public Order()
        {
        }

        public Order(IDiscount discount, int productCost)
        {
            _discount = discount;
            _productPrice = productCost;
        }

        public double GetDiscount() => _discount.CalculateDiscount(_productPrice);

        public Order GetOrderByProductName(string productName) => new Order();
    }
}
