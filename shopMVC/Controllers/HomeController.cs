using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopMVC.DAL;
using shopMVC.Model;

namespace shopMVC.Controllers
{
    public class HomeController : Controller
    {
        private CoursesContext _coursesContext;
        public HomeController(CoursesContext coursesContext)
        {
            _coursesContext = coursesContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}