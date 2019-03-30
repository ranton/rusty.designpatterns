using System;

namespace Rusty.DesignPatterns.Composite
{
    public class Isa : IPerson
    {
        private decimal _money;

        public void ShowMoney()
        {
            Console.WriteLine("Isa : " + _money);
        }

        public void ReceiveMoney(decimal money)
        {
            _money += money;
        }
    }
}