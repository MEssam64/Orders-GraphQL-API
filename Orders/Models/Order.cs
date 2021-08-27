using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Models
{
    public class Order
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; private set; }
        public int CustomerId { get; set; }
        public string Id { get; private set; }
        public OrderStatuses Status { get; set; }

        public Order(string name, string description, DateTime created, int customerId, string Id)
        {
            this.Name = name;
            this.Description = description;
            this.Created = created;
            this.CustomerId = customerId;
            this.Id = Id;
            this.Status = OrderStatuses.CREATED;
        }
    }
}
