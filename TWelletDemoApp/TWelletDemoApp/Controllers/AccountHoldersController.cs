using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TWelletDemoApp.Models;
using X.PagedList;

namespace TWelletDemoApp.Controllers
{
    public class AccountHoldersController : Controller
    {
        private readonly Semi_C3_StandardizedContext _context;

        public AccountHoldersController(Semi_C3_StandardizedContext context)
        {
            _context = context;
        }

        // GET: AccountHolders
        public async Task<IActionResult> Index(int? page)
        {            // Define the page size
            int pageSize = 10;
            // Define the maximum number of records to fetch
            int maxRecords = 100;
            // Fetch the top 100 account holders and order them by CreatedDate
            var accountHolders = await _context.AccountHolder
                .OrderBy(a => a.CreatedDate) // Order by a field (e.g., CreatedDate)
                .Take(maxRecords) // Limit to top 100 records
                .ToListAsync();
            // Convert the account holders to a PagedList
            int pageNumber = page ?? 1;
            var paginatedAccountHolders = accountHolders.ToPagedList(pageNumber, pageSize);
            // Pass the paginated data to the view
            return View(paginatedAccountHolders);

        }
        //[HttpGet]
        //public async Task<IActionResult> GetAccountsRegisteredonaGivenDate(DateTime? date, int page = 1, int pageSize = 10)
        //{
        //    try
        //    {

        //        if (!date.HasValue || date == default(DateTime))
        //        {
        //            ViewBag.ErrorMessage = "Date parameter is mandatory.";
        //            return View(new List<AccountHolderDT>());
        //        }


        //        var accounts = await (from a in _context.AccountHolder
        //                              where a.CreatedDate.HasValue && a.CreatedDate.Value.Date == date.Value.Date
        //                              orderby a.CreatedDate descending
        //                              select new AccountHolderDT
        //                              {
        //                                  AccountHolderMobileno = a.AccountHolderMobileNo,
        //                                  POAType = a.Poatype,
        //                                  POA = a.Poa,
        //                                  POIType = a.Poitype,
        //                                  POI = a.Poi,
        //                                  AccountHolderFullName = a.AccountHolderFullName,
        //                                  IsKycDone = a.IsKycDone == 2 ? "Low KYC" :
        //                                              a.IsKycDone == 0 ? "Medium KYC" : "Full KYC",
        //                                  Poiemail = a.Poiemail,
        //                                  AccountHolderAddress = a.AccountHolderAddress,
        //                                  CreatedDate = a.CreatedDate
        //                              }).ToListAsync();

        //        var pagedList = accounts.ToPagedList(page, pageSize);


        //        ViewData["Date"] = date.Value;
        //        return View(pagedList);
        //    }
        //    catch (Exception ex)
        //    {              
        //        ViewBag.ErrorMessage = "An error occurred while processing your request. Please try again later.";
        //        return View(new List<AccountHolderDT>());
        //    }
        //}

        [HttpGet]
        public async Task<IActionResult> GetAccountsRegisteredonaGivenDate(DateTime? date, string searchTerm, int page = 1, int pageSize = 10)
        {
            try
            {
                // Default date if none is provided
                if (date == null)
                {
                    date = new DateTime(2024, 1, 8);
                }
                // Query for searching and filtering by date
                var usersQuery = _context.AccountHolder.AsQueryable();
                // Apply search filter if search term is not empty
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    usersQuery = usersQuery.Where(u =>
                        u.AccountHolderFullName.Contains(searchTerm) ||
                        u.AccountHolderMobileNo.Contains(searchTerm) ||
                        u.AccountHolderAddress.Contains(searchTerm));
                }
                // Apply date filter
                usersQuery = usersQuery.Where(a => a.CreatedDate.HasValue && a.CreatedDate.Value.Date == date.Value.Date);
                // Exclude mobile numbers that exist in both AccountHolder and Account_Registration_Verification tables
                var registeredMobileNumbers = _context.AccountRegistrationVerifications
                    .Select(arv => arv.Mobilenumber); // Assuming MobileNumber is the column in the Account_Registration_Verification table
                usersQuery = usersQuery.Where(a => !registeredMobileNumbers.Contains(a.AccountHolderMobileNo));
                // Filter for Low KYC users
                usersQuery = usersQuery.Where(a => a.IsKycDone == 2); // Assuming 2 corresponds to Low KYC
                                                                      // Order the results
                usersQuery = usersQuery.OrderBy(u => u.AccountHolderId);
                // Fetch the filtered, ordered list
                var accounts = await usersQuery
                   .Select(a => new AccountHolderDT
                   {
                       AccountHolderId = a.AccountHolderId,
                       AccountHolderMobileno = a.AccountHolderMobileNo,
                       POAType = a.Poatype,
                       POA = a.Poa,
                       POIType = a.Poitype,
                       POI = a.Poi,
                       AccountHolderFullName = a.AccountHolderFullName,
                       IsKycDone = "Low KYC", // Directly setting to "Low KYC"
           Poiemail = a.Poiemail,
                       AccountHolderAddress = a.AccountHolderAddress,
                       CreatedDate = a.CreatedDate,
                   })
                  .ToListAsync();

                // Use ToPagedList for pagination
                var pagedList = accounts.ToPagedList(page, pageSize);

                // Return the paginated result to the view
                return View(pagedList);
            }
            catch (Exception ex)
            {
                // Log the exception
                ViewBag.ErrorMessage = "An error occurred while processing your request. Please try again later. " + ex.Message;

                // Return an empty list in case of an error
                return View(new List<AccountHolderDT>());
            }
        }



        [HttpPost]
        public async Task<IActionResult> Approved(Dictionary<int, string> decision)
        {
            try
            {
                // Loop through the decisions dictionary (where key is AccountHolderId and value is the decision)
                foreach (var entry in decision)
                {
                    int accountHolderId = entry.Key;           // Get AccountHolderId
                    string userDecision = entry.Value;         // Get the user's decision (Approve or Reject)
                    string userRemark = decision.ContainsKey(accountHolderId) ? decision[accountHolderId] : string.Empty; // Get the user's remark                 
                    // Insert record into ApprovedRejectedDetails table
                    AccountRegistrationVerification newEntry = new AccountRegistrationVerification
                    {
                        Account_Holder_ID = accountHolderId,
                        StatusDesc = userDecision,
                        Remarks = userRemark,
                        VerifiedOn = DateTime.Now,             // Add current date-time for reference
                        Name = User.Identity.Name          // Assuming you want to save the name of the user who took the action
                    };
                    var userName = HttpContext.Session.GetString("UserName") ?? "Unknown User";
                    int id = accountHolderId;
                    // Add the new entry to ApprovedRejectedDetails table
                    //_context.AccountRegistrationVerifications.Add(newEntry);
                    // Retrieve AccountHolder details (assuming Verifi is fetched by accountHolderId)
                    var accountHolder = await _context.AccountHolder.FirstOrDefaultAsync(a => a.AccountHolderId == id);
                    if (accountHolder != null)
                    {
                        // Insert a new record into AccountRegistrationVerification table
                        var newVerificationRecord = new AccountRegistrationVerification
                        {
                            Mobilenumber = accountHolder.AccountHolderMobileNo,
                            EntityName = accountHolder.AccountHolderFullName,
                            POAType = accountHolder.Poatype,  // Set the appropriate value
                            POA = accountHolder.Poa,          // Set the appropriate value
                            POIType = accountHolder.Poitype, // Set the appropriate value
                            POI = accountHolder.Poi,          // Set the appropriate value
                            Name = accountHolder.AccountHolderFullName,
                            KYCStatus = userDecision == "Approve" ? "Approved" : "Rejected",  // Set KYC status based on user decision
                            Poiemail = accountHolder.Poiemail,
                            Account_Holder_Address = accountHolder.AccountHolderAddress,
                            RegDate = accountHolder.CreatedDate.HasValue ? accountHolder.CreatedDate.Value : DateTime.MinValue,
                            Verifiedby = $"{userName}",     /*// You can replace this with session username*/
                            VerificationStatus = userDecision, // Set as "Approve" or "Reject"
                            VerifiedOn = DateTime.Now,
                            Remarks = $"{userName} by {newEntry.Remarks}", // Append username to the remark
                            Statement = "UpdateVerificationstatus",
                            StatusDesc = userDecision == "Approve" ? "Success" : "Failed",
                            StatusCode = userDecision == "Approve" ? "1000" : "2000",
                            Account_Holder_ID = accountHolderId
                        };
                        // Add the new record to the AccountRegistrationVerification table
                        _context.AccountRegistrationVerifications.Add(newVerificationRecord);
                    }
                }
                // Save all changes to the database
                await _context.SaveChangesAsync();
                // Show a success message to the user
                TempData["SuccessMessage"] = "The data has been successfully saved.";
            }
            catch (Exception ex)
            {
                // Handle exception and show an error message
                TempData["ErrorMessage"] = $"Error: {ex.Message}";
            }
            // Redirect back to the same view or another one after processing
            return RedirectToAction("GetAccountsRegisteredonaGivenDate");
        }
















        //[HttpGet]
        //public async Task<IActionResult> Approved(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    try
        //    {
        //        var Verifi = await _context.AccountHolder.FindAsync(id);
        //        if (Verifi == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(Verifi);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine(ex.StackTrace);
        //        return View(ex.Message);
        //    }
        //}


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Approved(int id, string Remarks, AccountHolderDT Verifi)
        //{
        //    // Validate that Remarks is not empty
        //    if (string.IsNullOrEmpty(Remarks))
        //    {
        //        ModelState.AddModelError(nameof(Remarks), "Remarks are required.");
        //        return View(Verifi); // Return the view with validation errors
        //    }

        //    // Retrieve existing record (if any) from AccountHolder table
        //    var user = await _context.AccountHolder.FindAsync(id);

        //    if (user == null)
        //    {
        //        return NotFound();
        //    }
        //    var existingAccountHolder = await _context.AccountHolder.FirstOrDefaultAsync(a => a.AccountHolderId == user.AccountHolderId); // Replace `Id` with your identifier         

        //    try
        //    {

        //        bool exists = await _context.AccountRegistrationVerifications
        //            .AnyAsync(arv => arv.Mobilenumber == Verifi.Mobilenumber &&
        //                             arv.EntityName == Verifi.AccountHolderFullName);

        //        if (exists)
        //        {
        //            // If record exists, redirect to "Exist" action
        //            return RedirectToAction("Exist", new { id = Verifi.AccountHolderId, Remarks = "Verification details already exist." });
        //        }
        //        DateTime RegDate;

        //        if (existingAccountHolder.CreatedDate is DateTime dateTimeValue)
        //        {
        //            // Already a DateTime
        //            RegDate = dateTimeValue;
        //        }

        //        else
        //        {
        //            // Attempt to convert other types to DateTime
        //            RegDate = Convert.ToDateTime(existingAccountHolder.CreatedDate);
        //        }


        //        var newRecord = new AccountRegistrationVerification
        //        {
        //            //Id= id,
        //            Mobilenumber = Verifi.AccountHolderMobileno,
        //            EntityName = Verifi.AccountHolderFullName,
        //            POAType = "POA_Type_Example",   // Set appropriate values
        //            POA = "POA_Example",
        //            POIType = "POI_Type_Example",
        //            POI = "POI_Example",
        //            Name = Verifi.AccountHolderFullName,
        //            KYCStatus = "Approved",
        //            Poiemail = Verifi.Poiemail,
        //            Account_Holder_Address = Verifi.AccountHolderAddress,
        //            RegDate = RegDate,

        //            Verifiedby = "Yadagiri",   // You can replace this with session user name
        //            VerificationStatus = "Approved",
        //            VerifiedOn = DateTime.Now,
        //            Remarks = $"{Remarks} by Yadagiri",
        //            Statement = "UpdateVerificationstatus",
        //            StatusDesc = "Success",
        //            StatusCode = "1000",
        //            Account_Holder_ID = id,
        //        };
        //        if (newRecord != null)
        //        {


        //            // Add the new record to the context
        //            _context.AccountRegistrationVerifications.Add(newRecord);

        //            // Save changes to the database
        //            await _context.SaveChangesAsync();
        //            //if (existingAccountHolder != null)
        //            //{
        //            //    // Update the Remarks property
        //            //    existingAccountHolder.Remarks = Remarks;
        //            //    existingAccountHolder.StatusCode = "1000";

        //            //    // Save the changes to the database
        //            //    await _context.SaveChangesAsync();
        //            //}
        //        }
        //        //else
        //        //{
        //        //    ModelState.AddModelError(nameof(newRecord), "Data Not Saved In Database");
        //        //    return View(newRecord); // Return the view with the model
        //        //}


        //    }
        //    catch (DbUpdateConcurrencyException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine(ex.StackTrace);
        //        return View(ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine(ex.StackTrace);
        //    }

        //    return RedirectToAction(nameof(GetAccountsRegisteredonaGivenDate));
        //}






        [HttpGet]
        public async Task<IActionResult> Reject(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            try
            {
                var Verifi = await _context.AccountHolder.FindAsync(id);
                if (Verifi == null)
                {
                    return NotFound();
                }

                return View(Verifi);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return View(ex.Message);
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reject(int id, string Remarks, AccountHolderDT Verifi)
        {
            // Validate that Remarks is not empty
            if (string.IsNullOrEmpty(Remarks))
            {
                ModelState.AddModelError(nameof(Remarks), "Remarks are required.");
                return View(Verifi); // Return the view with validation errors
            }
            // Retrieve existing record (if any) from AccountHolder table
            var user = await _context.AccountHolder.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }
            var existingAccountHolder = await _context.AccountHolder.FirstOrDefaultAsync(a => a.AccountHolderId == user.AccountHolderId); // Replace `Id` with your identifier



            try
            {

                bool exists = await _context.AccountRegistrationVerifications
                    .AnyAsync(arv => arv.Mobilenumber == Verifi.Mobilenumber &&
                                     arv.EntityName == Verifi.AccountHolderFullName);

                if (exists)
                {
                    // If record exists, redirect to "Exist" action
                    return RedirectToAction("Exist", new { id = Verifi.AccountHolderId, Remarks = "Verification details already exist." });
                }
                DateTime RegDate;

                if (existingAccountHolder.CreatedDate is DateTime dateTimeValue)
                {
                    // Already a DateTime
                    RegDate = dateTimeValue;
                }

                else
                {
                    // Attempt to convert other types to DateTime
                    RegDate = Convert.ToDateTime(existingAccountHolder.CreatedDate);
                }



                var newRecord = new AccountRegistrationVerification
                {
                    //Id= id,

                    Mobilenumber = Verifi.AccountHolderMobileno,
                    EntityName = Verifi.AccountHolderFullName,
                    POAType = "POA_Type_Example",   // Set appropriate values
                    POA = "POA_Example",
                    POIType = "POI_Type_Example",
                    POI = "POI_Example",
                    Name = Verifi.AccountHolderFullName,
                    KYCStatus = "Approved",
                    Poiemail = Verifi.Poiemail,
                    Account_Holder_Address = Verifi.AccountHolderAddress,
                    RegDate = RegDate,
                    Verifiedby = "Yadagiri",   // You can replace this with session user name
                    VerificationStatus = "Reject",
                    VerifiedOn = DateTime.Now,
                    Remarks = $"{Remarks} by Yadagiri",
                    Statement = "UpdateVerificationstatus",
                    StatusDesc = "Failed",
                    StatusCode = "2000",
                    Account_Holder_ID = id,
                };

                if (newRecord != null)
                {


                    // Add the new record to the context
                    _context.AccountRegistrationVerifications.Add(newRecord);

                    // Save changes to the database
                    await _context.SaveChangesAsync();
                    //if (existingAccountHolder != null)
                    //{
                    //    // Update the Remarks property
                    //    existingAccountHolder.Remarks = Remarks;
                    //    existingAccountHolder.StatusCode = "2000";

                    //    // Save the changes to the database
                    //    await _context.SaveChangesAsync();
                    //}
                }

            }
            catch (DbUpdateConcurrencyException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return View(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return RedirectToAction(nameof(GetAccountsRegisteredonaGivenDate));
        }



        [HttpGet]

        public async Task<IActionResult> usercount(int? id)
        {


            var userCount = await _context.AccountHolder.CountAsync();

            TempData["userCount"] = userCount;

            return Ok(userCount);
        }

        public async Task<IActionResult> Pending(int? id)
        {


            try
            {


                var pending = await _context.AccountRegistrationVerifications
      .Where(m => m.StatusCode == "1000" || m.StatusCode == "2000")
      .CountAsync();

                TempData["Pending"] = pending;
                return Ok(pending);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                return StatusCode(500, new { message = "An error occurred while processing your request." });
            }
        }
        [HttpGet]
        public async Task<IActionResult> RejectCounts()
        {
            try
            {
                // LINQ query to get the count of rejected items asynchronously
                var rejectedCount = await _context.AccountRegistrationVerifications
                    .Where(m => m.StatusCode == "2000")
                    .CountAsync();
                TempData["rejectedCount"] = rejectedCount;
                // Store the count in TempData
                TempData["rejectedCount"] = rejectedCount;

                // Optionally, return the count as JSON if needed
                //return Json(new { count = rejectedCount });
                return Ok(rejectedCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                return StatusCode(500, new { message = "An error occurred while processing your request." });
            }
        }
        [HttpGet]
        public async Task<IActionResult> ApprovedCount()
        {
            try
            {
                // LINQ query to get the count of rejected items asynchronously
                var rejectedCount = await _context.AccountRegistrationVerifications
                    .Where(m => m.StatusCode == "1000")
                    .CountAsync();
                TempData["rejectedCount"] = rejectedCount;
                // Store the count in TempData
                TempData["rejectedCount"] = rejectedCount;

                // Optionally, return the count as JSON if needed
                //return Json(new { count = rejectedCount });
                return Ok(rejectedCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                return StatusCode(500, new { message = "An error occurred while processing your request." });
            }
        }






























        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountHolder = await _context.AccountHolder
                .FirstOrDefaultAsync(m => m.AccountHolderId == id);
            if (accountHolder == null)
            {
                return NotFound();
            }

            return View(accountHolder);
        }

        // GET: AccountHolders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AccountHolders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AccountHolderId,AccountHolderRegnNo,AccountHolderFullName,AccountHolderNameOnCard,AccountHolderPhoneNo,AccountHolderMobileNo,AccountHolderMobileServiceProvider,AccountHolderEmail,AccountHolderAddress,AccountHolderDob,AccountHolderPhoto,AccountHolderPhotoName,AccountHolderSignature,AccountHolderSignatureName,AccountHolderDurationFrom,AccountHolderDurationTill,AccountHolderCourseFeeAmount,FkAccountHolderCourseId,FkAccountHolderBloodGroupTypeId,FkAccountHolderCreatedBy,FkAccountHolderEntityId,AccountHolderPin,FkAccountHolderHostelId,AccountHolderPan,AccountHolderPinIsReset,IsKycDone,FkAccountHolderStatusTypeId,CreatedDate,AccountHolderPwdEncrypt,GroupId,WalletTypeId,LoginEnable,Mmid,RegisteredbyMobile,CustOf,UpdatedBy,UpdatedDate,IsDistributor,DistributorCode,Tpin,SecurityQuestion,SecurityAnswer,ActualDob,IsTpinenabled,Pan,Aadhaar,Salt,LanguageCode,IsSmallScaleMerchant,CitizenServiceCenterId,PlatForm,RegistrationTypeId,SmsSenderid,IsStatusChecked,UniCode,DigithonDigitalTeacher,DistrictId,Poiname,Poidob,Poigender,Poiphone,Poiemail,Poaco,Poadist,Poahouse,Poaloc,Poapc,Poastate,Poavtc,PoavtcCode,Poastreet,Poalm,Poasubdist,Poapo,WalletUpgradationDate,IsUsageCapEnabled,DailyUsageCapCount,DailyUsageCapAmount,TpinEncrypt,OrderId,Poi,Poa,Poitype,Poatype,Poiverified,Poaverified,BlockChainId,BankCbsAccountNumber,BankCbsCustomerId,BankCbsIfsc,BankCbsAccountType,Uidtoken,TempAadhaar,Aadhaarhash,RiskStatus,LastPasswordSetOn,UpideviceId,Upivpa,ShowOfferDesc,LastCreditAmount,LastCreditOn,LastDebitAmount,LastDebitOn,CurrAddDoorNo,CurrAddStreet,CurrAddLocality,CurrAddLandmark,CurrAddVtc,CurrAddPincode,CurrAddDistrict,CurrAddState,CurrAddCountry,CurrAddIsApproved,AndroidVersionName,AndroidVersionCode,IosversionName,IosversionCode,IsInAppOtpenable,OccupationType,IncomeType")] AccountHolder accountHolder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accountHolder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(accountHolder);
        }

        // GET: AccountHolders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountHolder = await _context.AccountHolder.FindAsync(id);
            if (accountHolder == null)
            {
                return NotFound();
            }
            return View(accountHolder);
        }

        // POST: AccountHolders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AccountHolderId,AccountHolderRegnNo,AccountHolderFullName,AccountHolderNameOnCard,AccountHolderPhoneNo,AccountHolderMobileNo,AccountHolderMobileServiceProvider,AccountHolderEmail,AccountHolderAddress,AccountHolderDob,AccountHolderPhoto,AccountHolderPhotoName,AccountHolderSignature,AccountHolderSignatureName,AccountHolderDurationFrom,AccountHolderDurationTill,AccountHolderCourseFeeAmount,FkAccountHolderCourseId,FkAccountHolderBloodGroupTypeId,FkAccountHolderCreatedBy,FkAccountHolderEntityId,AccountHolderPin,FkAccountHolderHostelId,AccountHolderPan,AccountHolderPinIsReset,IsKycDone,FkAccountHolderStatusTypeId,CreatedDate,AccountHolderPwdEncrypt,GroupId,WalletTypeId,LoginEnable,Mmid,RegisteredbyMobile,CustOf,UpdatedBy,UpdatedDate,IsDistributor,DistributorCode,Tpin,SecurityQuestion,SecurityAnswer,ActualDob,IsTpinenabled,Pan,Aadhaar,Salt,LanguageCode,IsSmallScaleMerchant,CitizenServiceCenterId,PlatForm,RegistrationTypeId,SmsSenderid,IsStatusChecked,UniCode,DigithonDigitalTeacher,DistrictId,Poiname,Poidob,Poigender,Poiphone,Poiemail,Poaco,Poadist,Poahouse,Poaloc,Poapc,Poastate,Poavtc,PoavtcCode,Poastreet,Poalm,Poasubdist,Poapo,WalletUpgradationDate,IsUsageCapEnabled,DailyUsageCapCount,DailyUsageCapAmount,TpinEncrypt,OrderId,Poi,Poa,Poitype,Poatype,Poiverified,Poaverified,BlockChainId,BankCbsAccountNumber,BankCbsCustomerId,BankCbsIfsc,BankCbsAccountType,Uidtoken,TempAadhaar,Aadhaarhash,RiskStatus,LastPasswordSetOn,UpideviceId,Upivpa,ShowOfferDesc,LastCreditAmount,LastCreditOn,LastDebitAmount,LastDebitOn,CurrAddDoorNo,CurrAddStreet,CurrAddLocality,CurrAddLandmark,CurrAddVtc,CurrAddPincode,CurrAddDistrict,CurrAddState,CurrAddCountry,CurrAddIsApproved,AndroidVersionName,AndroidVersionCode,IosversionName,IosversionCode,IsInAppOtpenable,OccupationType,IncomeType")] AccountHolder accountHolder)
        {
            if (id != accountHolder.AccountHolderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accountHolder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountHolderExists(accountHolder.AccountHolderId))
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
            return View(accountHolder);
        }

        // GET: AccountHolders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountHolder = await _context.AccountHolder
                .FirstOrDefaultAsync(m => m.AccountHolderId == id);
            if (accountHolder == null)
            {
                return NotFound();
            }

            return View(accountHolder);
        }

        // POST: AccountHolders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accountHolder = await _context.AccountHolder.FindAsync(id);
            _context.AccountHolder.Remove(accountHolder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountHolderExists(int id)
        {
            return _context.AccountHolder.Any(e => e.AccountHolderId == id);
        }
    }
}
