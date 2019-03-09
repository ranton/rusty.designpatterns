namespace Rusty.DesignPatterns.Prototype
{
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