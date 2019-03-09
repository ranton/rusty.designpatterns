using System.Collections.Generic;

namespace Rusty.DesignPatterns.Prototype
{
    public class DogCompound
    {
        private Dictionary<string, Dog> _dogs = new Dictionary<string, Dog>();
        public Dog this[string name]
        {
            get => _dogs[name];
            set => _dogs.Add(name, value);
        }
    }
}