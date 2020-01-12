using Microsoft.EntityFrameworkCore;
using shopMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopMVC.DAL
{
    public class CoursesContext : DbContext
    {
        public CoursesContext(DbContextOptions<CoursesContext> options) : base(options) { }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPosition> OrderPositions { get; set; }
    }
}
