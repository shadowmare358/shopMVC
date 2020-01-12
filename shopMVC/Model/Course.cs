using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shopMVC.Model
{
    public class Course
    {
        public int CourseId { get; set; }
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Enter name of course")]
        [StringLength(100)]
        public string CourseName { get; set; }
        [Required(ErrorMessage = "Enter autor name")]
        [StringLength(100)]
        public string CourseAuthor { get; set; }
        public DateTime DateOfAdding { get; set; }
        [StringLength(100)]
        public string NameFileImg { get; set; }
        public string CourseDescription { get; set; }
        public decimal CoursePrice { get; set; }
        public bool Bestseller { get; set; }
        public bool Hidden { get; set; }

        public virtual Category Category { get; set; }
    }
}
