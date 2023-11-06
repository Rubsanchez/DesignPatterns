using DesignPatterns.Bridge.Interfaces;

namespace DesignPatterns.Bridge
{
    public class Windows10 : ReaderApp
    {
        public Windows10(IDisplayFormatter displayFormatter) : base(displayFormatter)
        {
        }

        public override void Display()
        {
            _displayFormatter.Display($"App used in Windows 10\n{Text}");
        }
    }
}
