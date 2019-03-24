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

    public class Singleton
    {
        private static readonly Singleton _instance = new Singleton();

        public static Singleton Instance => _instance;
    }

    public sealed class LazySingleton
    {
        private static readonly Lazy<LazySingleton>
            lazy =
                new Lazy<LazySingleton>
                    (() => new LazySingleton());

        public static LazySingleton Instance => lazy.Value;

        private LazySingleton()
        {
        }
    }
}

