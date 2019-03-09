namespace Rusty.DesignPatterns.FactoryMethod
{
    public class DogFactory : IFactory
    {
        public Animal FactoryMethod()
        {
            return new Dog();
        }
    }
}