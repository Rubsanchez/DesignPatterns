using DesignPatterns.Bridge.Interfaces;

namespace DesignPatterns.Bridge
{
    public abstract class ReaderApp
    {
        public string Text { get; set; } = string.Empty;
        protected IDisplayFormatter _displayFormatter;

        public ReaderApp(IDisplayFormatter displayFormatter)
        {
            _displayFormatter = displayFormatter;
        }

        public abstract void Display();
    }
}