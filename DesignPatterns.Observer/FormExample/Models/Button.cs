namespace DesignPatterns.Observer.FormExample.Models
{
    public class Button
    {
        public event EventHandler Clicked;

        public void Click()
        {
            Clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
