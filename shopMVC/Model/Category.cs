using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace shopMVC.Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Enter name of category")]
        [StringLength(100)]
        public string NameOfCategory { get; set; }
        [Required(ErrorMessage = "Enter description of category")]
        public string CategoryDesc { get; set; }
        public string NameOfFileIcon { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}