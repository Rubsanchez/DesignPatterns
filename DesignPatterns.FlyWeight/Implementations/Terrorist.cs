using DesignPatterns.FlyWeight.Interfaces;

namespace DesignPatterns.FlyWeight.Implementations
{
    public class Terrorist : IPlayer
    {
        private string? _task;
        private string? _weapon;

        public Terrorist()
        {
            _task = "Plant bomb";
        }

        public void AssignWeapon(string weapon)
        {
            _weapon = weapon;
        }

        public void Mission()
        {
            Console.WriteLine($"Terrorist with weapon {_weapon} has {_task} mission");
        }
    }
}
