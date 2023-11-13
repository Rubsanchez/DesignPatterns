using DesignPatterns.Observer.FruitExample.Interfaces;

namespace DesignPatterns.Observer.FruitExample.Models
{
    public abstract class Fruit
    {
        private double _pricePerKg;
        public double PricePerKg
        {
            get => _pricePerKg;
            set
            {
                if (_pricePerKg != value)
                {
                    _pricePerKg = value;
                    Notify();
                }
            }
        }
        private List<IRestaurant> _restaurants = new();

        protected Fruit(double pricePerKg)
        {
            _pricePerKg = pricePerKg;
        }

        public void Attach(IRestaurant restaurant)
        {
            _restaurants.Add(restaurant);
        }

        public void Dettach(IRestaurant restaurant)
        {
            _restaurants.Remove(restaurant);
        }

        public void Notify()
        {
            foreach (var restaurant in _restaurants)
            {
                restaurant.Update(this);
            }
        }

    }
}