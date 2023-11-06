namespace DesignPatterns.Facade
{
    public class WifiController
    {
        public void TurnOn()
        {
            Console.WriteLine("Wifi is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Wifi is off");
        }
    }
}