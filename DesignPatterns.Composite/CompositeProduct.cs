namespace DesignPatterns.Composite
{
    public class CompositeProduct : Product
    {
        List<Product> _products = new List<Product>();

        public CompositeProduct(string name) : base(name, 0)
        {
        }

        public override void Add(Product product)
        {
            _products.Add(product);
        }

        public override string GetPrice()
        {
            return $"{Name} price is {_products.Sum(x => x.Price):N2}";
        }

        public override void Remove(Product product)
        {
            _products.Remove(product);
        }
    }
}
