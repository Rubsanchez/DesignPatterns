using DesignPatterns.Bridge.Interfaces;

namespace DesignPatterns.Bridge.Implementations
{
    public class ReverseDisplay : IDisplayFormatter
    {
        public void Display(string text)
        {
            Console.WriteLine(text.Reverse().ToArray());
        }
    }
}
