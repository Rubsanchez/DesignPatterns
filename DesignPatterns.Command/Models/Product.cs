namespace DesignPatterns.Command.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public void IncreasePrice(int amount)
        {
            Price += amount;
            Console.WriteLine($"{Name} price has increased by {amount}");
        }

        public bool DecreasePrice(int amount)
        {
            if (amount > Price)
                return false;

            Price -= amount;
            Console.WriteLine($"{Name} price has decreased by {amount}");
            return true;
        }

        public override string ToString() => $"{Name} current price is {Price}";
    }
}