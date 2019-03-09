using System;
using System.Security.Cryptography.X509Certificates;

namespace Rusty.DesignPatterns.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            DogCompound dogCompound = new DogCompound();
            dogCompound["beagle"] = new Dog("beagle", 1);
            dogCompound["boxer"] = new Dog("boxer", 5);
            dogCompound["poodle"] = new Dog("poodle", 9);

            Dog newBeagle = dogCompound["beagle"].Clone() as Dog;
            Dog newBoxer = dogCompound["boxer"].Clone() as Dog;
            Dog newPoodle = dogCompound["poodle"].Clone() as Dog;
            newPoodle.Age = 10;

            Console.WriteLine(newBeagle);
            Console.WriteLine(newBoxer);
            Console.WriteLine(newPoodle);

            Console.ReadLine();
        }


    }

    //public class Dog : DogPrototype
    //{
    //    public int Age { get; set; }
    //    public string Breed { get; set; }

    //    public Dog(string breed, int age)
    //    {
    //        Breed = breed;
    //        Age = age;
    //    }

    //    public override DogPrototype Clone()
    //    {
    //        // this is a shallow copy
    //        return MemberwiseClone() as Dog;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Breed: {this.Breed}, Age: {this.Age}";
    //    }
    //}
}
