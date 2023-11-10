using DesignPatterns.Mediator.Interfaces;
using DesignPatterns.Mediator.Models;

namespace DesignPatterns.Mediator.Implementations
{
    public class Mediator : IMediator
    {
        private Flight _flight;
        private Runway _runway;
        private bool _land;

        public bool IsLandingOk() => _land;

        public void RegisterFlight(Flight flight)
        {
            _flight = flight;
        }

        public void RegisterRunway(Runway runway)
        {
            _runway = runway;
        }

        public void SetLandingStatus(bool status)
        {
            _land = status;
        }
    }
}
