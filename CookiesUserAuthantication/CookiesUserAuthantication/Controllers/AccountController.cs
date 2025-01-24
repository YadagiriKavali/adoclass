using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookiesUserAuthantication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CookiesUserAuthantication.Controllers
{
    public class AccountController : Controller
    {
        UserProfileHelper userProfile;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserProfile user)
        {
            if(user.Username==user.Password)
            {
                CookieOptions options = new CookieOptions();
                if (user.RememberMe)
                {
                    options.Expires = DateTime.MaxValue;
                }
                Response.Cookies.Append("Authcookie", user.Username, options);
                return Redirect("/");
            }
            else
            {
                ModelState.AddModelError("", "Invalid UserName Or Password");
            }
            return View("Login");
        }
        public IActionResult LogOut()
        {
            Response.Cookies.Delete("Authcookie");
            return Redirect("/");
        }
    }
}