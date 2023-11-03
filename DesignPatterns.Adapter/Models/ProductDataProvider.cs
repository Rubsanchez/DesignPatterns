namespace DesignPatterns.Adapter.Models
{
    public static class ProductDataProvider
    {
        public static List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product ("Iphone", 500),
                new Product ("Xiaomi Mi A2", 100),
                new Product ("OnePlus Nord", 200),
            };
        }
    }
}
