using System;
using System.Collections.Generic;
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

    public class DogCompound
    {
        private Dictionary<string, Dog> _dogs = new Dictionary<string, Dog>();
        public Dog this[string name]
        {
            get => _dogs[name];
            set => _dogs.Add(name, value);
        }
    }

    public abstract class DogPrototype
    {
        public abstract DogPrototype Clone();
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

    public interface IPrototype<T> where T : class
    {
        IPrototype<T> Clone();
    }

    public class Dog : IPrototype<Dog>
    {
        public string Breed { get; set; }
        public int Age { get; set; }

        public Dog(string breed, int age)
        {
            Breed = breed;
            Age = age;
        }

        public IPrototype<Dog> Clone()
        {
            return this.MemberwiseClone() as Dog;
        }

        public override string ToString()
        {
            return $"Breed: {this.Breed}, Age: {this.Age}";
        }
    }



}
