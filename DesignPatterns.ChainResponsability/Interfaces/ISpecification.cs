namespace DesignPatterns.ChainResponsability.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }
}
