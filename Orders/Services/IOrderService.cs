using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Orders.Models;

namespace Orders.Services
{
    public interface IOrderService
    {
        Task<Order> GetOrderByIdAsync(string id);
        Task<IEnumerable<Order>> GetOrdersAsync();
    }
}
