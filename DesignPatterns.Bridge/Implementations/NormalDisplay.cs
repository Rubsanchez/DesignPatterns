using DesignPatterns.Bridge.Interfaces;

namespace DesignPatterns.Bridge.Implementations
{
    public class NormalDisplay : IDisplayFormatter
    {
        public void Display(string text)
        {
            Console.WriteLine(text);
        }
    }
}
