namespace DesignPatterns.Serialization.Models
{
    [Serializable]
    public class Product
    {
        public string Name { get; set; } = string.Empty;
        public Category? Category { get; set; }

        public Product(string name, Category? category)
        {
            Name = name;
            Category = category;
        }

        public override string ToString()
        {
            return $"Product: {Name} - Category: {Category!.Name}";
        }
    }
}