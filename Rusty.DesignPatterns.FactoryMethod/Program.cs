using System;

namespace Rusty.DesignPatterns.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new DogFactory();
            Animal animal = factory.FactoryMethod();

            Console.WriteLine(animal.ToString());
            Console.ReadLine();
        }
    }
}
