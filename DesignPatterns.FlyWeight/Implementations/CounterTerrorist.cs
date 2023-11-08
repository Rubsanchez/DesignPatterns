using DesignPatterns.FlyWeight.Interfaces;

namespace DesignPatterns.FlyWeight.Implementations
{
    public class CounterTerrorist : IPlayer
    {
        private string? _task;
        private string? _weapon;

        public CounterTerrorist()
        {
            _task = "Disarm bomb";
        }

        public void AssignWeapon(string weapon)
        {
            _weapon = weapon;
        }

        public void Mission()
        {
            Console.WriteLine($"Counter terrorist with weapon {_weapon} has {_task} mission");
        }
    }
}
