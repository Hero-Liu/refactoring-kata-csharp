using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactoringKata
{
    public class Order
    {
        private readonly int id;
        private readonly List<Product> _products = new List<Product>();

        public Order(int id)
        {
            this.id = id;
        }

        public int GetOrderId()
        {
            return id;
        }

        public int GetProductsCount()
        {
            return _products.Count;
        }

        public Product GetProduct(int j)
        {
            return _products[j];
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public string GetFormat()
        {
            var products = string.Join(", ", _products.Select(p => p.GetFormat()).ToList());
            return string.Format("{{\"id\": {0}, \"products\": [{1}]}}", id, products);
        }
    }
}