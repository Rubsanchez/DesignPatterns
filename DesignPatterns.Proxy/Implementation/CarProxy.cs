using DesignPatterns.Proxy.Interfaces;

namespace DesignPatterns.Proxy.Implementation
{
    public class CarProxy : ICar
    {
        private Car _car = new();
        private Driver _driver;

        public CarProxy(Driver driver)
        {
            _driver = driver;
        }

        public void Drive()
        {
            if (_driver.CanDrive())
                _car.Drive();
            else
                Console.WriteLine("Driver cannot drive");
        }
    }
}
