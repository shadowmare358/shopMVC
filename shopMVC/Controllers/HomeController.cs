﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace shopMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //zmiana w gałęzi logowanie
            return View();
        }
    }
}