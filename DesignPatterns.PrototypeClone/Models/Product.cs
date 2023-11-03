using DesignPatterns.PrototypeClone.Interfaces;

namespace DesignPatterns.PrototypeClone.Models
{
    public class Product : IPrototype<Product>
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

        public Product DeepCopy()
        {
            return new Product(Name, Category!.DeepCopy());
        }
    }
}