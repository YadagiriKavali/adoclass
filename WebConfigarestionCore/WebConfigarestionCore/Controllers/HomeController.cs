using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using WebConfigarestionCore.Models;

namespace WebConfigarestionCore.Controllers
{
    public class HomeController : Controller
    {
        IConfiguration configuration;
        IOptions<myApplicationSettings> settings;
        public  HomeController(IConfiguration configuration ,IOptions<myApplicationSettings>settings,IOptionsSnapshot<myApplicationSettings> settings1)
            //ioptionsSnapshot we can use new  connection new changes it willcome
        {
            this.configuration = configuration;
            this.settings = settings;
        }
            public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
