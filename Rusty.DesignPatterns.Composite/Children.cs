using System.Collections.Generic;

namespace Rusty.DesignPatterns.Composite
{
    public class Children : IPerson, IGroup
    {
        private List<IPerson> _components = new List<IPerson>();

        public void ShowMoney()
        {
            foreach (var component in _components)
            {
                component.ShowMoney();
            }
        }

        public void ReceiveMoney(decimal money)
        {
            if (_components.Count > 0)
            {
                this.DistributeMoney(money);
            }
        }

        public void Remove(IPerson item)
        {
            _components.Remove(item);
        }

        public void Add(IPerson item)
        {
            _components.Add(item);
        }

        public void DistributeMoney(decimal money)
        {
            var values = Divider.Divide(money, _components.Count);
            int ctr = values.Length - 1;
            foreach (var component in _components)
            {
                component.ReceiveMoney(values[ctr--]);
            }
        }

        public List<IPerson> GetChild()
        {
            return _components;
        }
    }
}