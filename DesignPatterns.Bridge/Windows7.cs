using DesignPatterns.Bridge.Interfaces;

namespace DesignPatterns.Bridge
{
    public class Windows7 : ReaderApp
    {
        public Windows7(IDisplayFormatter displayFormatter) : base(displayFormatter)
        {
        }

        public override void Display()
        {
            _displayFormatter.Display($"App used in Windows 7\n{Text}");
        }
    }
}
