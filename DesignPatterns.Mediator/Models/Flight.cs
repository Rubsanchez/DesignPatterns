using DesignPatterns.Mediator.Interfaces;

namespace DesignPatterns.Mediator.Models
{
    public class Flight
    {
        private IMediator _mediator;

        public Flight(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Land()
        {
            if (!_mediator.IsLandingOk())
            {
                Console.WriteLine($"Waiting disponibility to land");
                return;
            }

            Console.WriteLine($"It can be land");
            _mediator.SetLandingStatus(true);
        }
    }
}
