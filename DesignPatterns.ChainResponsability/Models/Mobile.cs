using DesignPatterns.ChainResponsability.Enums;

namespace DesignPatterns.ChainResponsability.Models
{
    public class Mobile
    {
        public CategoryType Category { get; private set; }
        public double Price { get; private set; }
        public string Name { get; private set; }


        public Mobile(CategoryType category, double price, string name)
        {
            Category = category;
            Price = price;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}, Category: {Category}, Price: {Price}";
        }
    }
}