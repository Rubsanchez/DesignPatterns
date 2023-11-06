namespace DesignPatterns.Facade
{
    public class HomeController
    {
        private WifiController WifiController = new();
        private AirConditionerController AirConditionerController = new();
        private LightController LightController = new();

        public void TurnOn()
        {
            WifiController.TurnOn();
            AirConditionerController.TurnOn();
            LightController.TurnOn();
        }

        public void TurnOff()
        {
            WifiController.TurnOff();
            AirConditionerController.TurnOff();
            LightController.TurnOff();
        }
    }
}
