namespace DesignPatterns.Proxy
{
    public class Driver
    {
        private int _age;
        private bool _hasLicense;

        public Driver(int age, bool hasLicense)
        {
            _age = age;
            _hasLicense = hasLicense;
        }

        internal bool CanDrive() => _age > 18 && _hasLicense;
    }
}
