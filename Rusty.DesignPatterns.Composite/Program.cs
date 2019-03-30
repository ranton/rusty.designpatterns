using System;

namespace Rusty.DesignPatterns.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var children = new Children();
            children.Add(new Belle());
            children.Add(new Letty());
            IPerson[] persons = { new Francis(), new Isa(), children };
            const int payout = 10000;
            var values = Divider.Divide(payout, persons.Length);
            var ctr = values.Length - 1;
            foreach (var person in persons)
            {
                person.ReceiveMoney(values[ctr--]);
            }

            PrintMoney(persons);

            
            Console.ReadLine();
        }

        static void PrintMoney(IPerson[] persons)
        {
            foreach (var p in persons)
            {
                if (p is IGroup x)
                {
                    PrintMoney(x.GetChild().ToArray());
                }
                else
                {
                    p.ShowMoney();
                }
            }
        }
    }
}
