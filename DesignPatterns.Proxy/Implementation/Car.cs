using DesignPatterns.Proxy.Interfaces;

namespace DesignPatterns.Proxy.Implementation
{
    public class Car : ICar
    {
        public void Drive()
        {
            Console.WriteLine("The car is being driven");
        }
    }
}
