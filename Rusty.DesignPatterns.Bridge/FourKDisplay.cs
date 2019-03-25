using System;

namespace Rusty.DesignPatterns.Bridge
{
    public class FourKDisplay : ITelevisionDisplayer
    {
        public void Display(decimal inches)
        {
            Console.WriteLine($"{inches} inches tv shows a 4k display");
        }
    }
}