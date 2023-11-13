namespace DesignPatterns.Observer.FormExample.Models
{
    public class Form : IDisposable
    {
        private Button _button;

        public Form(Button button)
        {
            _button = button;
            _button.Clicked += ButtonOnClicked;
        }

        private void ButtonOnClicked(object sender, EventArgs e)
        {
            Console.WriteLine("El boton es clickeado");
        }

        public void Dispose()
        {
            _button.Clicked -= ButtonOnClicked;
        }

        ~Form()
        {
            Console.WriteLine("Form finalizo");
        }
    }
}