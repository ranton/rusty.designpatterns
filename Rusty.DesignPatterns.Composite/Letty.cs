using System;

namespace Rusty.DesignPatterns.Composite
{
    public class Letty : IPerson
    {
        private decimal _money;

        public void ShowMoney()
        {
            Console.WriteLine("Letty : " + _money);
        }

        public void ReceiveMoney(decimal money)
        {
            _money += money;
        }
    }
}