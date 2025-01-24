//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using CURDDemoApp.Models;
//using Microsoft.AspNetCore.Http;
//using X.PagedList;

//namespace CURDDemoApp.Controllers
//{
//    public class AccountRegistrationVerificationsController : Controller
//    {
//        private readonly CURDDemoAppContext _context;

//        public AccountRegistrationVerificationsController(CURDDemoAppContext context)
//        {
//            _context = context;
//        }

//        // GET: AccountRegistrationVerifications
//        //public async Task<IActionResult> Index()
//        //{
//        //    return View(await _context.AccountRegistrationVerification.ToListAsync());
//        //public ActionResult Index(DateTime? searchDate, DateTime? searchToDate, int pageNumber = 1)
//        //{
//        //    // Fetch data from the database
//        //    var query = _context.AccountRegistrationVerification.AsQueryable();

//        //    if (searchDate.HasValue)
//        //    {
//        //        query = query.Where(x => x.Date >= searchDate.Value);
//        //    }

//        //    if (searchToDate.HasValue)
//        //    {
//        //        query = query.Where(x => x.Date <= searchToDate.Value);
//        //    }
//        //    else
//        //    {
//        //        // If searchToDate is not provided, show all data up to today
//        //        query = query.Where(x => x.Date <= DateTime.Today);
//        //    }

//        //    // Sort and paginate
//        //    var pagedList = query.OrderBy(x => x.Date)  // Adjust sorting as needed
//        //                          .ToPagedList(pageNumber, 10);

//        //    ViewData["searchDate"] = searchDate;
//        //    ViewData["searchToDate"] = searchToDate;

//        //    return View(pagedList);
//        //}




//        public ActionResult Index(DateTime? searchDate, DateTime? searchToDate, int pageNumber = 1)
//        {
//            try
//            {
//                // Fetch data from the database
//                var query = _context.AccountRegistrationVerification.AsQueryable();

//                // Apply date range filter
//                if (searchDate.HasValue)
//                {
//                    query = query.Where(x => x.Date >= searchDate.Value);
//                }

//                if (searchToDate.HasValue)
//                {
//                    query = query.Where(x => x.Date <= searchToDate.Value);
//                }
//                else
//                {
//                    // If searchToDate is not provided, show all data up to today
//                    query = query.Where(x => x.Date <= DateTime.Today);
//                }

//                // Sort and paginate
//                var pagedList = query.OrderBy(x => x.Date)  // Adjust sorting as needed
//                                      .ToPagedList(pageNumber, 10);

//                // Store the search parameters in ViewData for use in the view
//                ViewData["searchDate"] = searchDate;
//                ViewData["searchToDate"] = searchToDate;

//                return View(pagedList);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Error: {ex.Message}, StackTrace: {ex.StackTrace}");
//                ViewData["ErrorMessage"] = "An error occurred while fetching data. Please try again later.";

               
//                return View(new List<AccountRegistrationVerification>().ToPagedList(pageNumber, 10));
//            }
//            finally
//            {
               
//            }
//        }
//        // GET: AccountRegistrationVerifications/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var accountRegistrationVerification = await _context.AccountRegistrationVerification
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (accountRegistrationVerification == null)
//            {
//                return NotFound();
//            }

//            return View(accountRegistrationVerification);
//        }

//        // GET: AccountRegistrationVerifications/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: AccountRegistrationVerifications/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Id,Statement,Date,ToDate,MobileNumber,EntityName,POAType,POA,POIType,POI,Name,KYCStatus,PoiEmail,AccountHolderAddress,RegDate,VerifiedBy,VerificationStatus,VerifiedOn,Remarks,StatusCode,StatusDesc")] AccountRegistrationVerification accountRegistrationVerification)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(accountRegistrationVerification);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(accountRegistrationVerification);
//        }

//        // GET: AccountRegistrationVerifications/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var accountRegistrationVerification = await _context.AccountRegistrationVerification.FindAsync(id);
//            if (accountRegistrationVerification == null)
//            {
//                return NotFound();
//            }
//            return View(accountRegistrationVerification);
//        }

//        // POST: AccountRegistrationVerifications/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("Id,Statement,Date,ToDate,MobileNumber,EntityName,POAType,POA,POIType,POI,Name,KYCStatus,PoiEmail,AccountHolderAddress,RegDate,VerifiedBy,VerificationStatus,VerifiedOn,Remarks,StatusCode,StatusDesc")] AccountRegistrationVerification accountRegistrationVerification)
//        {
//            if (id != accountRegistrationVerification.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(accountRegistrationVerification);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!AccountRegistrationVerificationExists(accountRegistrationVerification.Id))
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
//            return View(accountRegistrationVerification);
//        }

//        // GET: AccountRegistrationVerifications/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var accountRegistrationVerification = await _context.AccountRegistrationVerification
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (accountRegistrationVerification == null)
//            {
//                return NotFound();
//            }

//            return View(accountRegistrationVerification);
//        }

//        // POST: AccountRegistrationVerifications/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var accountRegistrationVerification = await _context.AccountRegistrationVerification.FindAsync(id);
//            _context.AccountRegistrationVerification.Remove(accountRegistrationVerification);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool AccountRegistrationVerificationExists(int id)
//        {
//            return _context.AccountRegistrationVerification.Any(e => e.Id == id);
//        }
//        [HttpGet]
//        public async Task<IActionResult> Approved(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            try
//            {
//                var accountRegistrationVerification = await _context.AccountRegistrationVerification.FindAsync(id);
//                if (accountRegistrationVerification == null)
//                {
//                    return NotFound();
//                }

//                return View(accountRegistrationVerification);
//            }
//            catch (Exception ex)
//            {
//                // Log the exception (using a logger)
//                Console.WriteLine($"An error occurred while retrieving the account registration verification: {ex.Message}");
//                // Optionally: return a custom error view or message
//                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving the item.");
//            }
//        }


//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Approved(int id, string Remarks, AccountRegistrationVerification accountRegistrationVerification)
//        {
//            // Validate that Remarks is not empty
//            if (string.IsNullOrEmpty(Remarks))
//            {
//                ModelState.AddModelError(nameof(Remarks), "Remarks are required.");
//                return View(accountRegistrationVerification); // Return the view with validation errors
//            }

//            // Retrieve the existing record to update
//            var user = await _context.AccountRegistrationVerification.FindAsync(id);
//            if (user == null)
//            {
//                return NotFound();
//            }

//            // Check if the record already exists in ApprovedData
//            bool exists = await _context.ApprovedData
//                .AnyAsync(ad => ad.MobileNumber == accountRegistrationVerification.MobileNumber &&
//                                ad.EntityName == accountRegistrationVerification.EntityName);

//            if (exists)
//            {
//                // Optionally, you could log or handle this condition before redirecting
//                return RedirectToAction("Exist", new { id = accountRegistrationVerification.Id, Remarks = "Verification details already exist." });
//            }


//            var userName = HttpContext.Session.GetString("UserName") ?? "Unknown User";

//            try
//            {
//                // Update the existing record
//                user.Remarks = $"{Remarks} by {userName}";
//                user.VerifiedBy = userName;
//                user.VerificationStatus = "Approved";
//                user.StatusCode = "1000";
//                user.VerifiedOn = DateTime.Now;
//                user.StatusDesc = "Success";
//                user.EntityName = "T Wallet";
//                user.Statement = "GetAccountsRegisteredonaGivenDate";

//                _context.Update(user);
//                await _context.SaveChangesAsync();

//                // Insert into the ApprovedData table
//                var approvedData = new ApprovedData
//                {
//                    Statement = user.Statement,
//                    RegDate = accountRegistrationVerification.RegDate ?? default(DateTime),
//                    ToDate = accountRegistrationVerification.ToDate ?? default(DateTime),
//                    MobileNumber = accountRegistrationVerification.MobileNumber,
//                    EntityName = accountRegistrationVerification.EntityName,
//                    POAType = accountRegistrationVerification.POAType,
//                    POA = accountRegistrationVerification.POA,
//                    POIType = accountRegistrationVerification.POIType,
//                    POI = accountRegistrationVerification.POI,
//                    Name = accountRegistrationVerification.Name,
//                    KYCStatus = accountRegistrationVerification.KYCStatus,
//                    PoiEmail = accountRegistrationVerification.PoiEmail,
//                    AccountHolderAddress = accountRegistrationVerification.AccountHolderAddress,
//                    VerifiedBy = user.VerifiedBy,
//                    VerificationStatus = user.VerificationStatus,
//                    VerifiedOn = user.VerifiedOn ?? default(DateTime),
//                    Remarks = user.Remarks,
//                    StatusCode = user.StatusCode,
//                    StatusDesc = user.StatusDesc
//                };

//                _context.ApprovedData.Add(approvedData);
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException ex)
//            {
//                // Log the concurrency exception
//                Console.WriteLine($"A concurrency error occurred: {ex.Message}");
//                ModelState.AddModelError(string.Empty, "A concurrency error occurred while updating the item. Please try again.");
//                return View(accountRegistrationVerification); // Return the view with an error message
//            }
//            catch (Exception ex)
//            {
//                // Log the general exception
//                Console.WriteLine($"An error occurred while updating the item: {ex.Message}");
//                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while updating the item.");
//            }

//            return RedirectToAction(nameof(Index));
//        }


//        [HttpGet]
//        public async Task<IActionResult> Exist(int? id, string Remarks)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }
           
//            try
//            {
//                var user = await _context.AccountRegistrationVerification.FindAsync(id);
//                if (user == null)
//                {
//                    return NotFound();
//                }
//                ViewBag.Remarks = Remarks;
//                // Return the user to the view if found
//                return View(user);
//            }

//            catch (Exception ex)
//            {
//                // Log the exception
//                Console.WriteLine($"An error occurred while retrieving the item: {ex.Message}");
//                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving the item.");
//            }
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Exist(int id, string Remarks, AccountRegistrationVerification accountRegistrationVerification)
//        {
//            try
//            {
//                // Retrieve the existing record asynchronously
//                var user = await _context.AccountRegistrationVerification.FindAsync(id);
//                if (user == null)
//                {
//                    return NotFound();
//                }

//                // Get the user name from the session
//                var userName = HttpContext.Session.GetString("UserName") ?? "Unknown User";

//                // Update the user record with the rejection details
//                user.Remarks = Remarks;
//                user.VerifiedBy = userName;
//                user.VerificationStatus = "Rejected";
//                user.VerifiedOn = DateTime.Now;
//                user.Statement = "UpdateVerificationStatus";
//                user.EntityName = "T Wallet";
//                user.StatusCode = "2000";  // Assuming "2000" represents a rejection status
//                user.StatusDesc = "Failed";

//                // Save the changes asynchronously
//                _context.Update(user);
//                await _context.SaveChangesAsync();

//                // Insert into the ApprovedData table
//                var approvedData = new ApprovedData
//                {
//                    Statement = user.Statement,
//                    RegDate = accountRegistrationVerification.RegDate ?? default(DateTime),
//                    ToDate = accountRegistrationVerification.ToDate ?? default(DateTime),
//                    MobileNumber = accountRegistrationVerification.MobileNumber,
//                    EntityName = accountRegistrationVerification.EntityName,
//                    POAType = accountRegistrationVerification.POAType,
//                    POA = accountRegistrationVerification.POA,
//                    POIType = accountRegistrationVerification.POIType,
//                    POI = accountRegistrationVerification.POI,
//                    Name = accountRegistrationVerification.Name,
//                    KYCStatus = accountRegistrationVerification.KYCStatus,
//                    PoiEmail = accountRegistrationVerification.PoiEmail,
//                    AccountHolderAddress = accountRegistrationVerification.AccountHolderAddress,
//                    VerifiedBy = user.VerifiedBy,
//                    VerificationStatus = user.VerificationStatus,
//                    VerifiedOn = user.VerifiedOn ?? default(DateTime),
//                    Remarks = user.Remarks,
//                    StatusCode = user.StatusCode,
//                    StatusDesc = user.StatusDesc
//                };

//                _context.ApprovedData.Add(approvedData);
//                await _context.SaveChangesAsync();

//                // Pass the Remarks to the view using ViewBag
         

//                // Return the view with the user model
//                return RedirectToAction(nameof(Index));
//            }
//            catch (DbUpdateConcurrencyException ex)
//            {
//                // Log the concurrency exception
//                Console.WriteLine($"A concurrency error occurred: {ex.Message}");
//                ModelState.AddModelError(string.Empty, "A concurrency error occurred while updating the item. Please try again.");
//                return View(accountRegistrationVerification); // Return the view with an error message
//            }
//            catch (Exception ex)
//            {
//                // Log the general exception
//                Console.WriteLine($"An error occurred while updating the item: {ex.Message}");
//                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while updating the item.");
//            }
           
//        }



//        // GET action method
//        [HttpGet]
//        public async Task<IActionResult> Reject(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            AccountRegistrationVerification user = null;
//            try
//            {
//                user = await _context.AccountRegistrationVerification.FindAsync(id);
//                if (user == null)
//                {
//                    return NotFound();
//                }
//            }
//            catch (Exception)
//            {
//                // Handle the exception (e.g., log it or display a friendly error message)
//                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving the item.");
//            }
//            finally
//            {

//            }

//            return View(user);
//        }


//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Reject(int id, string Remarks, AccountRegistrationVerification accountRegistrationVerification)
//        {
//            if (string.IsNullOrEmpty(Remarks))
//            {
//                ModelState.AddModelError(nameof(Remarks), "Remarks are required.");
//                return View(); // Return the view with validation errors
//            }

//            AccountRegistrationVerification user = null;
//            var userName = HttpContext.Session.GetString("UserName") ?? "Unknown User";

//            try
//            {
//                user = await _context.AccountRegistrationVerification.FindAsync(id);
//                if (user == null)
//                {
//                    return NotFound();
//                }

//                user.Remarks = $"{Remarks} by {userName}";
//                user.VerifiedBy = $" by {userName}";
//                user.VerificationStatus = "Rejected";
//                user.VerifiedOn = DateTime.Now;
//                user.Statement = "UpdateVerificationstatus";
//                user.EntityName = "T Wallet";
//                user.StatusCode = "2000";
//                user.StatusDesc = "Failed";

//                _context.Update(user);
//                await _context.SaveChangesAsync();


//                var approvedData = new ApprovedData
//                {
//                    Statement = user.Statement,
//                    RegDate = accountRegistrationVerification.RegDate ?? default(DateTime),
//                    ToDate = accountRegistrationVerification.ToDate ?? default(DateTime),
//                    MobileNumber = accountRegistrationVerification.MobileNumber,
//                    EntityName = accountRegistrationVerification.EntityName,
//                    POAType = accountRegistrationVerification.POAType,
//                    POA = accountRegistrationVerification.POA,
//                    POIType = accountRegistrationVerification.POIType,
//                    POI = accountRegistrationVerification.POI,
//                    Name = accountRegistrationVerification.Name,
//                    KYCStatus = accountRegistrationVerification.KYCStatus,
//                    PoiEmail = accountRegistrationVerification.PoiEmail,
//                    AccountHolderAddress = accountRegistrationVerification.AccountHolderAddress,
//                    VerifiedBy = user.VerifiedBy,
//                    VerificationStatus = user.VerificationStatus,
//                    VerifiedOn = user.VerifiedOn ?? default(DateTime),
//                    Remarks = user.Remarks,
//                    StatusCode = user.StatusCode,
//                    StatusDesc = user.StatusDesc
//                };

//                _context.ApprovedData.Add(approvedData);
//                await _context.SaveChangesAsync();


//            }
//            catch (DbUpdateConcurrencyException ex)
//            {

//                ModelState.AddModelError(string.Empty, "A concurrency error occurred while updating the item. Please try again."+ex);
//                return View();
//            }
//            catch (Exception ex)
//            {
//                // Handle other exceptions (e.g., display a friendly error message)
//                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while updating the item."+ ex);
//            }
//            finally
//            {
//                // Optional cleanup code if needed
//            }

//            return RedirectToAction(nameof(Index));
//        }
//    }





//}
