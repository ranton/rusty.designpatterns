using System;

namespace Rusty.DesignPatterns.Composite
{
    public class Belle : IPerson
    {
        private decimal _money;

        public void ShowMoney()
        {
            Console.WriteLine("Belle : " + _money);
        }

        public void ReceiveMoney(decimal money)
        {
            _money += money;
        }
    }
}