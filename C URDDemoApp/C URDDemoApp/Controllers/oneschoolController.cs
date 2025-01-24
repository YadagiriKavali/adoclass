using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CURDDemoApp.Controllers
{
    public class oneschoolController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}