//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using CURDDemoApp.Models;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Http;

//namespace CURDDemoApp.Controllers
//{
//    public class LoginProfilesController : Controller
//    {

//        const string cookieeUserName = "UserName";
//        private readonly CURDDemoAppContext _context;

//        public LoginProfilesController(CURDDemoAppContext context)
//        {
//            _context = context;
//        }

//        // GET: LoginProfiles
//        public async Task<IActionResult> Index()
//        {
//            return View(await _context.LoginProfile.ToListAsync());
//        }

//        // GET: LoginProfiles/Details/5
//        public async Task<IActionResult> Details(string  username)
//        {
//            if (username == null)
//            {
//                return NotFound();
//            }

//            var loginProfile = await _context.LoginProfile
//                .FirstOrDefaultAsync(m => m.UserName == username);
//            if (loginProfile == null)
//            {
//                return NotFound();
//            }

//            return View(loginProfile);
//        }

//        // GET: LoginProfiles/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: LoginProfiles/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("UserId,UserName,Password,isAction,CreatedOn,status,PhoneNo,UserLastName")] LoginProfile loginProfile)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(loginProfile);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(loginProfile);
//        }

//        // GET: LoginProfiles/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var loginProfile = await _context.LoginProfile.FindAsync(id);
//            if (loginProfile == null)
//            {
//                return NotFound();
//            }
//            return View(loginProfile);
//        }

//        // POST: LoginProfiles/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("UserId,UserName,Password,isAction,CreatedOn,status,PhoneNo,UserLastName")] LoginProfile loginProfile)
//        {
//            if (id != loginProfile.UserId)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(loginProfile);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!LoginProfileExists(loginProfile.UserId))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(loginProfile);
//        }





//        // GET: LoginProfiles/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var loginProfile = await _context.LoginProfile
//                .FirstOrDefaultAsync(m => m.UserId == id);
//            if (loginProfile == null)
//            {
//                return NotFound();
//            }

//            return View(loginProfile);
//        }

//        // POST: LoginProfiles/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var loginProfile = await _context.LoginProfile.FindAsync(id);
//            _context.LoginProfile.Remove(loginProfile);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool LoginProfileExists(int id)
//        {
//            return _context.LoginProfile.Any(e => e.UserId == id);
//        }
//        //[HttpGet]
//        //public IActionResult Login()
//        //{

//        //    return View();
//        //}

//        //[HttpPost]
//        //public async Task<IActionResult> Login(LoginProfile login)
//        //{
//        //    if (ModelState.IsValid)
//        //    {
//        //        // Retrieve the user by username (case-sensitive)
//        //        var logins = await _context.LoginProfile
//        //            .FirstOrDefaultAsync(u => u.UserName == login.UserName);

//        //        if (logins != null)
//        //        {
//        //            // Check if password matches (case-sensitive)
//        //            bool passwordMatches = logins.Password == login.Password;
//        //            bool username = logins.UserName == login.UserName;
//        //            bool isactive = logins.isAction == login.isAction;

//        //            // Ensure that isAction is true or false based on your requirement
//        //            bool actionValid = logins.isAction;

//        //            if (passwordMatches && isactive && username)
//        //            {
//        //                // Store the username in TempData
//        //                TempData["UserName"] = login.UserName;

//        //                // Store a success message in TempData
//        //                TempData["SuccessMessage"] = "Login successful!";
//        //                return Json(new { isSuccess = true });
//        //                // Redirect to the Index action of the Users controller
//        //                // return RedirectToAction("Index", "Users");
//        //            }
//        //        }


//        //        // Add model error if authentication fails
//        //        ModelState.AddModelError(string.Empty, "Invalid Username and Password attempt.");
//        //    }

//        //    // Return the view with the login model if invalid
//        //    return View(login);
//        //}
//        [HttpGet]
//        public IActionResult Login()
//        {

//            return View();
//        }

//        [HttpPost]
//        public async Task<IActionResult> Login(LoginProfile login)
//        {
//            if (ModelState.IsValid)
//            {
//                // Retrieve the user by username (case-sensitive)
//                var logins = await _context.LoginProfile
//                    .FirstOrDefaultAsync(u => u.UserName == login.UserName);

//                if (logins != null)
//                {
//                    // Check if password matches (case-sensitive)
//                    bool passwordMatches = logins.Password == login.Password;
//                    bool username = logins.UserName == login.UserName;
//                    bool isActive = logins.isAction == login.isAction;

//                    // Ensure that isAction is true or false based on your requirement
//                    bool actionValid = logins.isAction;

//                    if (passwordMatches && isActive && username)
//                    {
//                        // Store the username in TempData
//                        TempData["UserName"] = login.UserName;

//                        // Store a success message in TempData
//                        TempData["SuccessMessage"] = "Login successful!";

//                        // Set cookies for username and any other needed information
//                        CookieOptions options = new CookieOptions
//                        {
//                            Expires = DateTime.Now.AddMinutes(50), // Set cookie expiration time
//                            HttpOnly = true, // Prevent client-side scripts from accessing the cookie
//                            Secure = true, // Ensures the cookie is only sent over HTTPS
//                            SameSite = SameSiteMode.Strict // Protects against CSRF attacks
//                        };
//                        Response.Cookies.Append("cookieeUserName", login.UserName, options);

//                        // Store the username in the session
//                        HttpContext.Session.SetString("UserName", login.UserName);

//                        return Json(new { isSuccess = true });
//                    }
//                }

//                // Add model error if authentication fails
//                ModelState.AddModelError(string.Empty, "Invalid Username and Password attempt.");
//            }

//            return View(login);
//        }



//        //[HttpPost]
//        //public async Task<IActionResult> Login(LoginProfile login)
//        //{
//        //    if (ModelState.IsValid)
//        //    {
//        //        // Retrieve the user by username (case-sensitive)
//        //        var logins = await _context.LoginProfile
//        //            .FirstOrDefaultAsync(u => u.UserName == login.UserName);

//        //        if (logins != null)
//        //        {
//        //            // Check if password matches (case-sensitive)
//        //            bool passwordMatches = logins.Password == login.Password;
//        //            bool username = logins.UserName == login.UserName;
//        //            bool isactive = logins.isAction == login.isAction;

//        //            // Ensure that isAction is true or false based on your requirement
//        //            bool actionValid = logins.isAction;

//        //            if (passwordMatches && isactive && username)
//        //            {
//        //                // Store the username in TempData
//        //                 TempData["UserName"] = login.UserName;

//        //                // Store a success message in TempData
//        //                TempData["SuccessMessage"] = "Login successful!";
//        //                //set cookies   1.   one Way to Set cookies

//        //                //CookieOptions options = new CookieOptions();
//        //                //options.Expires = DateTime.Now.AddDays(5);
//        //                //Response.Cookies.Append(cookieeUserName, logins.UserName, options);



//        //                //Set cookies for username and any other needed information   2

//        //               CookieOptions options = new CookieOptions
//        //               {
//        //                   Expires = DateTime.Now.AddMinutes(1), // Set cookie expiration timeCookie Expiry: The cookie is set to expire in 30 minutes, but you can adjust this as needed.
//        //                    HttpOnly = true, // Prevent client-side scripts from accessing the cookie
//        //                    Secure = true, // Ensures the cookie is only sent over HTTPS
//        //                    SameSite = SameSiteMode.Strict // Protects against CSRF attacks
//        //                };
//        //                Response.Cookies.Append(cookieeUserName, login.UserName, options);


//        //                return Json(new { isSuccess = true });
//        //            }
//        //        }

//        //        // Add model error if authentication fails
//        //        ModelState.AddModelError(string.Empty, "Invalid Username and Password attempt.");
//        //    }           
//        //    return View(login);
//        //}


//        //[HttpGet]
//        //public IActionResult Forgetpassword()
//        //{
//        //    return View();
//        //}

//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public async Task<IActionResult> Forgetpassword(SetPasswordViewModel model,string newPassword)
//        //{
//        //    if (!ModelState.IsValid)
//        //    {
//        //        return View(model);
//        //    }

//        //    // Find the user by username
//        //    var user = await _context.LoginProfile.SingleOrDefaultAsync(u => u.UserName == model.Username);
//        //    if (user == null)
//        //    {
//        //        // Handle user not found
//        //        ModelState.AddModelError("", "User not found.");
//        //        return View(model);
//        //    }
           
//        //    // Update the user's password
//        //    user.Password =model.newPassword; // Ensure password is hashed
//        //    await _context.SaveChangesAsync();

//        //    return RedirectToAction("Login");
//        //}

//        //public IActionResult SetPasswordConfirmation()
//        //{
//        //    return View();
//        //}




        


//    }
//}

