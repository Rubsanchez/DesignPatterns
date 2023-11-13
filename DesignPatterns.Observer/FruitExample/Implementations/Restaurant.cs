using DesignPatterns.Observer.FruitExample.Interfaces;
using DesignPatterns.Observer.FruitExample.Models;

namespace DesignPatterns.Observer.FruitExample.Implementations
{
    public class Restaurant : IRestaurant
    {
        private string _name;
        private double _purchaseThreshold;

        public Restaurant(string name, double purchaseThreshold)
        {
            _name = name;
            _purchaseThreshold = purchaseThreshold;
        }

        public void Update(Fruit fruit)
        {
            if (fruit is null)
                return;

            Console.WriteLine($"Notifying {_name} that {fruit.GetType().Name} price change to {fruit.PricePerKg}");

            if (fruit.PricePerKg < _purchaseThreshold)
            {
                Console.WriteLine($"{_name} wants to purchase");
            }
        }
    }
}
