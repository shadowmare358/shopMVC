using System.Collections.Generic;

namespace shopMVC.Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string NameOfCategory { get; set; }
        public string CategoryDesc { get; set; }
        public string NameOfFileIcon { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}