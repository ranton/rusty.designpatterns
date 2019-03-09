namespace Rusty.DesignPatterns.Prototype
{
    public interface IPrototype<T> where T : class
    {
        IPrototype<T> Clone();
    }
}