using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopMVC.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime DateAdding { get; set; }
        public OrderState OrderState { get; set; }
        public decimal OrderPrice { get; set; }

        List<OrderPosition> OrderPositions { get; set; }
    }
    public enum OrderState
    {
        New,
        Completed
    }
}
