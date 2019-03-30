using System;

namespace Rusty.DesignPatterns.Composite
{
    public class Francis : IPerson
    {
        private decimal _money;

        public void ShowMoney()
        {
            Console.WriteLine("Francis : " + _money);
        }

        public void ReceiveMoney(decimal money)
        {
            _money += money;
        }
    }
}