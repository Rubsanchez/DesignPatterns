namespace DesignPatterns.Composite
{
    public class SimpleProduct : Product
    {
        public SimpleProduct(string name, int price) : base(name, price)
        {
        }

        public override void Add(Product product)
        {
            // Operation won't be realized because this is the bottom element at hierarchy
        }

        public override string GetPrice()
        {
            return $"{Name} price is {Price:N2}";
        }

        public override void Remove(Product product)
        {
            // Operation won't be realized because this is the bottom element at hierarchy
        }
    }
}
