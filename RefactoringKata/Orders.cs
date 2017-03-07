using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactoringKata
{
    public class Orders
    {
        private List<Order> _orders = new List<Order>();

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public int GetOrdersCount()
        {
            return _orders.Count;
        }

        public Order GetOrder(int i)
        {
            return _orders[i];
        }

        public string GetFormat()
        {
            var ordersSb = _orders.Select(order => order.GetFormat()).ToList();
            return string.Format("{{\"orders\": [{0}]}}", string.Join(", ", ordersSb));
        }
    }
}
