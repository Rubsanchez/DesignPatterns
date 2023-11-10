using DesignPatterns.Mediator.Interfaces;

namespace DesignPatterns.Mediator.Models
{
    public class Runway
    {
        private IMediator _mediator;

        public Runway(IMediator mediator)
        {
            _mediator = mediator;
            _mediator.SetLandingStatus(false);
        }

        public void Land()
        {
            Console.WriteLine($"Permission to land");
            _mediator.SetLandingStatus(true);
        }

    }
}
