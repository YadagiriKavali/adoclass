using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TWelletDemoApp.Models;

namespace TWelletDemoApp.Controllers
{
    public class LoginProfilesController : Controller
    {
        private readonly Semi_C3_StandardizedContext _context;

        public LoginProfilesController(Semi_C3_StandardizedContext context)
        {
            _context = context;
        }

        // GET: Login
        public async Task<IActionResult> Index()
        {
            return View(await _context.NameMatchLogin.ToListAsync());
        }

        // GET: Login/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nameMatchLogin = await _context.NameMatchLogin
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (nameMatchLogin == null)
            {
                return NotFound();
            }

            return View(nameMatchLogin);
        }

        // GET: Login/Create
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,EmpId,Email,UserName,Password,CreatedOn")] NameMatchLogin nameMatchLogin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nameMatchLogin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nameMatchLogin);
        }

        // GET: Login/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nameMatchLogin = await _context.NameMatchLogin.FindAsync(id);
            if (nameMatchLogin == null)
            {
                return NotFound();
            }
            return View(nameMatchLogin);
        }

        // POST: Login/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,EmpId,Email,UserName,Password,CreatedOn")] NameMatchLogin nameMatchLogin)
        {
            if (id != nameMatchLogin.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nameMatchLogin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NameMatchLoginExists(nameMatchLogin.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(nameMatchLogin);
        }

        // GET: Login/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nameMatchLogin = await _context.NameMatchLogin
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (nameMatchLogin == null)
            {
                return NotFound();
            }

            return View(nameMatchLogin);
        }

        // POST: Login/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nameMatchLogin = await _context.NameMatchLogin.FindAsync(id);
            _context.NameMatchLogin.Remove(nameMatchLogin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NameMatchLoginExists(int id)
        {
            return _context.NameMatchLogin.Any(e => e.UserId == id);
        }

        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Login(NameMatchLogin login)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // Retrieve the user by username (case-sensitive)
        //        var logins = await _context.NameMatchLogin
        //            .FirstOrDefaultAsync(u => u.UserName == login.UserName);

        //        if (logins != null)
        //        {
        //            // Check if password matches (case-sensitive)
        //            bool passwordMatches = logins.Password == login.Password;
        //            bool username = logins.UserName == login.UserName;


        //            // Ensure that isAction is true or false based on your requirement

        //            if (passwordMatches  && username)
        //            {
        //                // Store the username in TempData
        //                TempData["UserName"] = login.UserName;

        //                // Store a success message in TempData
        //                TempData["SuccessMessage"] = "Login successful!";

        //                // Set cookies for username and any other needed information
        //                CookieOptions options = new CookieOptions
        //                {
        //                    Expires = DateTime.Now.AddMinutes(50), // Set cookie expiration time
        //                    HttpOnly = true, // Prevent client-side scripts from accessing the cookie
        //                    Secure = true, // Ensures the cookie is only sent over HTTPS
        //                    SameSite = SameSiteMode.Strict // Protects against CSRF attacks
        //                };
        //                Response.Cookies.Append("cookieeUserName", login.UserName, options);

        //                // Store the username in the session
        //                HttpContext.Session.SetString("UserName", login.UserName);

        //                return RedirectToAction("GetAccountsRegisteredonaGivenDate", "AccountHolders");
        //            }
        //        }

        //        // Add model error if authentication fails
        //        ModelState.AddModelError(string.Empty, "Invalid Username and Password attempt.");
        //    }


        //    return View("Login");
        //}

        [HttpPost]
        public async Task<IActionResult> Login(NameMatchLogin login)
        {
            if (ModelState.IsValid)
            {
                // Retrieve the user by username (case-sensitive)
                var logins = await _context.NameMatchLogin
                    .FirstOrDefaultAsync(u => u.UserName == login.UserName);

                if (logins != null)
                {
                    // Check if password matches (case-sensitive)
                    bool passwordMatches = logins.Password == login.Password;

                    if (passwordMatches)
                    {
                        // Store the username in TempData
                        TempData["UserName"] = login.UserName;

                        // Store a success message in TempData
                        TempData["SuccessMessage"] = "Login successful!";

                        // Set cookies for username and any other needed information
                        CookieOptions options = new CookieOptions
                        {
                            Expires = DateTime.Now.AddMinutes(50),
                            HttpOnly = true,
                            Secure = true,
                            SameSite = SameSiteMode.Strict
                        };
                        Response.Cookies.Append("cookieeUserName", login.UserName, options);

                        // Store the username in the session
                        HttpContext.Session.SetString("UserName", login.UserName);

                        // Use ViewBag to pass the success flag to the view
                        ViewBag.LoginSuccess = true;

                        // Return the view with the login model and success flag
                        return View(login);
                    }
                }

                ModelState.AddModelError(string.Empty, "Invalid Username and Password attempt.");
            }

            // If the login fails or model state is invalid, return the view with the model
            return View(login);
        }












    }
}
