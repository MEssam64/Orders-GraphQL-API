using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Orders.Models;

namespace Orders.Services
{
    public interface ICustomerService
    {
        Customer GetCustomerById(int id);

        Task<Customer> GetCustomerByIdAsync(int id);

        Task<IEnumerable<Customer>> GetCustomersAsync();
    }
}
