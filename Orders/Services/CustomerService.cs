using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Models;

namespace Orders.Services
{
    public class CustomerService : ICustomerService
    {
        private IList<Customer> _customers;

        public CustomerService()
        {
            _customers = new List<Customer>();
            _customers.Add(new Customer(1, "Mohamed"));
            _customers.Add(new Customer(2, "Anas"));
            _customers.Add(new Customer(3, "Zain"));
            _customers.Add(new Customer(4, "Mona"));
            _customers.Add(new Customer(5, "Lola"));
        }

        public Customer GetCustomerById(int id)
        {
            return this.GetCustomerByIdAsync(id).Result;
        }

        public Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return Task.FromResult(_customers.AsEnumerable());
        }

        public Task<Customer> GetCustomerByIdAsync(int id)
        {
            return Task.FromResult(_customers.Single(cus => Equals(cus.Id, id)));
        }
    }
}
