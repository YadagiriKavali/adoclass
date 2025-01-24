//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using CURDDemoApp.Models;
//using X.PagedList;


namespace CURDDemoApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly CURDDemoAppContext _context;

        public UsersController(CURDDemoAppContext context)
        {
            _context = context;
        }

        // GET: Users
        // Add this namespace

        //public async Task<IActionResult> Index(string searchTerm, int? page)
        //{
        //    int pageSize = 10; // Number of items per page
        //    int pageNumber = page ?? 1; // Default to page 1 if no page is provided

        //    // Fetch users and apply sorting
        //    var usersQuery = _context.User.AsQueryable();

        //    if (!string.IsNullOrEmpty(searchTerm))
        //    {
        //        // Apply search filter
        //        usersQuery = usersQuery
        //            .Where(u => u.FirstName.Contains(searchTerm) || u.LastName.Contains(searchTerm) || u.Address.Contains(searchTerm));
        //    }

        //    // Sort the users by FirstName
        //    usersQuery = usersQuery.OrderBy(u => u.FirstName);

        //    // Convert the query to a list
        //    var userList = await usersQuery.ToListAsync();

        //    // Create a paged list from the result
        //    var pagedUsers = userList.ToPagedList(pageNumber, pageSize);

        //    // Pass the search term to the view for displaying in search input
        //    ViewBag.SearchTerm = searchTerm;

        //    return View(pagedUsers);
        //}


//    // GET: Users/Details/5
//    public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var user = await _context.User
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (user == null)
//            {
//                return NotFound();
//            }

//            return View(user);
//        }

//        // GET: Users/Create
//        //public IActionResult Create()
//        //{
//        //    return View();
//        //}

//        //// POST: Users/Create
//        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Address,State,POI,POINumber,status,Remarks,authorBy,CreatedOn")] User user)
//        //{
//        //    if (ModelState.IsValid)
//        //    {
//        //        _context.Add(user);
//        //        await _context.SaveChangesAsync();
//        //        return RedirectToAction(nameof(Index));
//        //    }
//        //    return View(user);
//        //}

//        // GET: Users/Edit/5
//        //public async Task<IActionResult> Edit(int? id)
//        //{
//        //    if (id == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    var user = await _context.User.FindAsync(id);
//        //    if (user == null)
//        //    {
//        //        return NotFound();
//        //    }
//        //    return View(user);
//        //}

//        //// POST: Users/Edit/5
//        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Address,State,POI,POINumber,status,Remarks,authorBy,CreatedOn")] User user)
//        //{
//        //    if (id != user.Id)
//        //    {
//        //        return NotFound();
//        //    }

//        //    if (ModelState.IsValid)
//        //    {
//        //        try
//        //        {
//        //            _context.Update(user);
//        //            await _context.SaveChangesAsync();
//        //        }
//        //        catch (DbUpdateConcurrencyException)
//        //        {
//        //            if (!UserExists(user.Id))
//        //            {
//        //                return NotFound();
//        //            }
//        //            else
//        //            {
//        //                throw;
//        //            }
//        //        }
//        //        return RedirectToAction(nameof(Index));
//        //    }
//        //    return View(user);
//        //}

//        // GET: Users/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var user = await _context.User
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (user == null)
//            {
//                return NotFound();
//            }

//            return View(user);
//        }

//        // POST: Users/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var user = await _context.User.FindAsync(id);
//            _context.User.Remove(user);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool UserExists(int id)
//        {
//            return _context.User.Any(e => e.Id == id);
//        }


//        public async Task<IActionResult> Approved(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var user = await _context.User.FindAsync(id);
//            if (user == null)
//            {
//                return NotFound();
//            }

//            return View(user);
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]

//        public async Task<IActionResult> Approved(int id, string Remarks)
//        {
//            var user = await _context.User.FindAsync(id);
//            if (user == null)
//            {
//                return NotFound();
//            }

//            user.Remarks = $"{Remarks} by {TempData["UserName"]}";
//            user.authorBy = $" by {TempData["UserName"]}";
//            user.status = "200"; // Assuming 200 indicates approval

//            try
//            {
//                _context.Update(user);
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException ex)
//            {
//                Console.WriteLine(ex);
//            }

//            return RedirectToAction(nameof(Index));
//        }

//        public async Task<IActionResult> Reject(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var user = await _context.User.FindAsync(id);
//            if (user == null)
//            {
//                return NotFound();
//            }

//            return View(user);
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]

//        public async Task<IActionResult> Reject(int id, string Remarks)
//        {
//            var user = await _context.User.FindAsync(id);
//            if (user == null)
//            {
//                return NotFound();
//            }
//            user.Remarks = $"{Remarks} by {TempData["UserName"]}";
//            user.authorBy = $" by {TempData["UserName"]}";
//            user.status = "100"; // Assuming 200 indicates approval

//            try
//            {
//                _context.Update(user);
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException ex)
//            {
//                Console.WriteLine(ex);
//            }

//            return RedirectToAction(nameof(Index));
//        }



//        [HttpGet]

//        public async Task<IActionResult> usercount(int id, string Remarks)
//        {


//            var userCount = await _context.User.CountAsync();

//            TempData["userCount"] = userCount;

//            return Ok(userCount);
//        }


//        [HttpGet]
//        public IActionResult RejectCounts()
//        {
//            // Query the database to get the count of rejected items
//            int rejectedCount = _context.User
//                .Where(m => m.status == "100")
//                .Count();

//            // Return the count as JSON
//            return Json(rejectedCount);
//        }

//        [HttpGet]
//        public IActionResult Appoved()
//        {
//            // Query the database to get the count of rejected items
//            int appoverdCount = _context.User
//                .Where(m => m.status == "200")
//                .Count();

//            // Return the count as JSON
//            return Json(appoverdCount);
//        }
//    }
//}
