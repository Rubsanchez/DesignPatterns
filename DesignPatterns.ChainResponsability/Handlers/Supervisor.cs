using DesignPatterns.ChainResponsability.Interfaces;
using DesignPatterns.ChainResponsability.Models;

namespace DesignPatterns.ChainResponsability.Handlers
{
    public class Supervisor : Handler
    {
        public Supervisor(ISpecification<Mobile> specification) : base(specification)
        {
        }

        public override void HandleRequest(Mobile mobile)
        {
            if (CanHandle(mobile))
                Console.WriteLine($"{mobile.Name} order realized by {this.GetType().Name}");
            else
                Successor.HandleRequest(mobile);
        }

        public bool CanHandle(Mobile mobile)
        {
            return Specification.IsSatisfied(mobile);
        }
    }
}
