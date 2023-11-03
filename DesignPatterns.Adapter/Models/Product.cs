namespace DesignPatterns.Adapter.Models
{
    public class Product
    {
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; } = 0;

        public Product()
        {
        }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}