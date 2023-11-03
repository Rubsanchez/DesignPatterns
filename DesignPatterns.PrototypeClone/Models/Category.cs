using DesignPatterns.PrototypeClone.Interfaces;

namespace DesignPatterns.PrototypeClone.Models
{
    public class Category : IPrototype<Category>
    {
        public string Name { get; set; } = string.Empty;

        public Category(string name)
        {
            Name = name;
        }

        public Category DeepCopy()
        {
            return new Category(Name);
        }
    }
}
