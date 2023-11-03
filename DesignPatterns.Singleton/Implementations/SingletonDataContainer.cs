using DesignPatterns.Singleton.Interfaces;

namespace DesignPatterns.Singleton.Implementations
{
    public class SingletonDataContainer : ISingletonContainer
    {
        private Dictionary<string, int> _capitals = new();

        private SingletonDataContainer()
        {
            Console.WriteLine("New SingletonDataContainer instance created");

            var elements = File.ReadAllLines("capitals.txt");
            for (int i = 0; i < elements.Length; i += 2)
            {
                _capitals.Add(elements[i], int.Parse(elements[i + 1]));
            }
        }

        private static Lazy<SingletonDataContainer> _instance = new Lazy<SingletonDataContainer>(() => new SingletonDataContainer());
        public static SingletonDataContainer Instance => _instance.Value;

        public int GetPopulation(string name)
        {
            return _capitals[name];
        }
    }
}