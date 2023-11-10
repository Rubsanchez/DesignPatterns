using DesignPatterns.Mediator.Models;

namespace DesignPatterns.Mediator.Interfaces
{
    public interface IMediator
    {
        void RegisterRunway(Runway runway);
        void RegisterFlight(Flight flight);
        void SetLandingStatus(bool status);
        bool IsLandingOk();
    }
}