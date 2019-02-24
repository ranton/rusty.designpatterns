using System;

namespace Rusty.DesignPatterns.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IStoreFactory smStoreFactory = new SmStoreFactory();
            Console.WriteLine(nameof(SmStoreFactory)); 
            var shirt = smStoreFactory.GetShirtProduct();
            Console.WriteLine(shirt.ToString());
            var shoe = smStoreFactory.GetShoeProduct();
            Console.WriteLine(shoe.ToString());

            Console.WriteLine("---------------------------------");

            Console.WriteLine(nameof(LandmarkStoreFactory));
            IStoreFactory landmarkStoreFactory = new LandmarkStoreFactory();
            var shirt2 = landmarkStoreFactory.GetShirtProduct();
            Console.WriteLine(shirt2.ToString());
            var shoe2 = landmarkStoreFactory.GetShoeProduct();
            Console.WriteLine(shoe2.ToString());

            Console.ReadLine();
        }
    }

    public interface IStoreFactory
    {
        IShoeProduct GetShoeProduct();
        IShirtProduct GetShirtProduct();
    }

    public interface IShirtProduct
    {
    }

    public interface IShoeProduct
    {
    }

    public class SmStoreFactory : IStoreFactory
    {
        public IShoeProduct GetShoeProduct()
        {
            return new VansShoeProduct();
        }

        public IShirtProduct GetShirtProduct()
        {
            return new BenchShirtProduct();
        }
    }

    public class LandmarkStoreFactory : IStoreFactory
    {
        public IShoeProduct GetShoeProduct()
        {
            return new PedroShoeProduct();
        }

        public IShirtProduct GetShirtProduct()
        {
            return new SupremeShirtProduct();
        }
    }

    public class BenchShirtProduct : IShirtProduct
    {
        public override string ToString()
        {
            return "BenchShirtProduct";
        }
    }

    public class SupremeShirtProduct : IShirtProduct
    {
        public override string ToString()
        {
            return "SupremeShirtProduct";
        }
    }

    public class VansShoeProduct : IShoeProduct
    {
        public override string ToString()
        {
            return "VansShoeProduct";
        }
    }

    public class PedroShoeProduct : IShoeProduct
    {
        public override string ToString()
        {
            return "PedroShoeProduct";
        }
    }
}
