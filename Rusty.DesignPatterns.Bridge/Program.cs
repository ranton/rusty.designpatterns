using System;

namespace Rusty.DesignPatterns.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Television thirtyTwoInchesTelevision = new ThirtyTwoInchesTelevision();
            thirtyTwoInchesTelevision.ShowDisplay(new StandardDisplay());
            thirtyTwoInchesTelevision.ShowDisplay(new FourKDisplay());

            Television fortySixInchesTelevision = new FortySixInchesTelevision();
            fortySixInchesTelevision.ShowDisplay(new StandardDisplay());
            fortySixInchesTelevision.ShowDisplay(new FourKDisplay());

            Console.ReadLine();
        }
    }
}
