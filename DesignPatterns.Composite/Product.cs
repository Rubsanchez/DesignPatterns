namespace DesignPatterns.Composite
{
    public abstract class Product
    {
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }

        protected Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public abstract void Add(Product product);
        public abstract void Remove(Product product);
        public abstract string GetPrice();
    }
}