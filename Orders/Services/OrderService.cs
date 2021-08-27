using Orders.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Orders.Services
{
    public class OrderService : IOrderService
    {
        private List<Order> _orders;

        public OrderService()
        {
            _orders = new List<Order>()
            {
                new Order("1000", "250 Conference brochures", DateTime.Now, 1, Guid.NewGuid().ToString()),
                new Order("2000", "250 T-shirts", DateTime.Now.AddHours(1), 2, Guid.NewGuid().ToString()),
                new Order("3000", "500 Stickers", DateTime.Now.AddHours(-2), 3, Guid.NewGuid().ToString()),
                new Order("4000", "10 Posters", DateTime.Now.AddHours(-3), 4, Guid.NewGuid().ToString()),
                new Order("5000", "2 Jeans", DateTime.Now.AddHours(6), 5, Guid.NewGuid().ToString())
            };
        }

        public Task<Order> GetOrderByIdAsync(string id)
        {
            return Task.FromResult(_orders.Single(ord => Equals(ord.Id, id)));
        }

        public Task<IEnumerable<Order>> GetOrdersAsync()
        {
            return Task.FromResult(_orders.AsEnumerable());
        }
    }
}
