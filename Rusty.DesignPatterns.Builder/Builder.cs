namespace Rusty.DesignPatterns.Builder
{
    public abstract class Builder<T> where T : class
    {
        public abstract T Build();
    }
}