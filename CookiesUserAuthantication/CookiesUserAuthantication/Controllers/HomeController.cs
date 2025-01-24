using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CookiesUserAuthantication.Models;
using Microsoft.AspNetCore.Http;

namespace CookiesUserAuthantication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AddCookie(string cookiename, string cookievalue, string cookiepath)
        {
            CookieOptions option = new CookieOptions();
            option.Path = cookiepath;
            Response.Cookies.Append(cookiename, cookievalue, option);

            return View("Index");
        }
        [HttpPost]
        public IActionResult GetCookie(string cookiename)
        {
            var value = Request.Cookies[cookiename];
            ViewBag.Cookievalue = value;
            return View("Index");
        }
        public IActionResult DeleteCookie(string cookiename, string cookievalue, string cookiepath)
        {
            CookieOptions option = new CookieOptions();
            option.Path = cookiepath;
            option.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Append(cookiename, "", option);
            return View("Index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult GetAllCookie()
        {
            if(Request.Cookies!=null)
            {
                foreach(var key in Request.Cookies)
                {
                    ViewBag.Cookievalue += key.Key + "-" + key.Value + "-";
                }
            }
            return View("Index");
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
