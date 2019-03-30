using System.Collections.Generic;

namespace Rusty.DesignPatterns.Composite
{
    public interface IGroup
    {
        void Remove(IPerson item);
        void Add(IPerson item);
        void DistributeMoney(decimal money);
        List<IPerson> GetChild();
    }
}