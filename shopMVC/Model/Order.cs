using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shopMVC.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required(ErrorMessage = "Enter name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter last name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Enter street")]
        [StringLength(100)]
        public string Street { get; set; }
        [Required(ErrorMessage = "Enter city")]
        [StringLength(100)]
        public string City { get; set; }
        [Required(ErrorMessage = "Enter zipcode")]
        [StringLength(10)]
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
