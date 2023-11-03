namespace DesignPatterns.PrototypeClone.Interfaces
{
    public interface IPrototype<T>
    {
        T DeepCopy();
    }
}
