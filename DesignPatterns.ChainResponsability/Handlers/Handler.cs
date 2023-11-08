using DesignPatterns.ChainResponsability.Interfaces;
using DesignPatterns.ChainResponsability.Models;

namespace DesignPatterns.ChainResponsability.Handlers
{
    public abstract class Handler
    {
        protected Handler Successor;
        protected ISpecification<Mobile> Specification;

        protected Handler(ISpecification<Mobile> specification)
        {
            Specification = specification;
        }

        public void SetSuccessor(Handler successor)
        {
            Successor = successor;
        }

        public abstract void HandleRequest(Mobile mobile);
    }
}
