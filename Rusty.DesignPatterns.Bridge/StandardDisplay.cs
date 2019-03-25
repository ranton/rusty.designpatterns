using System;

namespace Rusty.DesignPatterns.Bridge
{
    public class StandardDisplay : ITelevisionDisplayer
    {
        public void Display(decimal inches)
        {
            Console.WriteLine($"{inches} inches tv shows a standard display");
        }
    }
}