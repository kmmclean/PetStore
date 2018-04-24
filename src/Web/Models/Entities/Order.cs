using System;
using System.Collections.Generic;

namespace PetStore.Web.Models.Entities
{
    public class Order
    {
        public long Id { get; set; }
        public string CustomerId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public List<OrderItem> Items { get; set; }
    }
}