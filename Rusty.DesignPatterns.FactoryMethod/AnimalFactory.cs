namespace Rusty.DesignPatterns.FactoryMethod
{
    public class AnimalFactory
    {
        public Animal CreateAnimal(AnimalKind animalType)
        {
            switch (animalType)
            {
                case AnimalKind.Dog:
                    return new Dog();
                case AnimalKind.Cat:
                    return new Cat();
                default:
                    return new Bird();
            }
        }
    }
}