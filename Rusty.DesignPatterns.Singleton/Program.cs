using System;

namespace Rusty.DesignPatterns.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LazySingleton.Instance.GetHashCode());
            Console.WriteLine(LazySingleton.Instance.GetHashCode());
            Console.ReadLine();
        }
    }
}

