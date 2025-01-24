//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Threading.Tasks;
//using CURDDemoApp.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using X.PagedList;

//using Microsoft.AspNetCore.Http;
////using X.PagedList;
//namespace CURDDemoApp.Controllers
//{
//    public class AccountRegistrationsController : Controller
//    {

//        private readonly DSN_USER _context;

//        public AccountRegistrationsController(DSN_USER context)
//        {
//            _context = context;
//        }


//        public async Task<IActionResult> Index(DateTime? date, int page = 1, int pageSize = 10)
//        {
//            if (date == null)
//            {
//                date = new DateTime(2024, 1, 8); // Default date if none is provided
//            }

//            var dateParameter = new SqlParameter("@Date", date);
//            var result = new List<AccountRegistration>();

//            try
//            {
//                var connection = _context.Database.GetDbConnection();

//                if (connection == null)
//                {
//                    throw new InvalidOperationException("Database connection is null.");
//                }

//                using (var command = connection.CreateCommand())
//                {
//                    command.CommandText = "GetAccountsRegisteredonaGivenDate";
//                    command.CommandType = System.Data.CommandType.StoredProcedure;
//                    command.Parameters.Add(dateParameter);

//                    connection.Open();

//                    using (var reader = await command.ExecuteReaderAsync())
//                    {
//                        while (await reader.ReadAsync())
//                        {
//                            result.Add(new AccountRegistration
//                            {
//                                Mobilenumber = reader.IsDBNull(reader.GetOrdinal("Mobilenumber")) ? null : reader.GetString(reader.GetOrdinal("Mobilenumber")),
//                                POAType = reader.IsDBNull(reader.GetOrdinal("POAType")) ? null : reader.GetString(reader.GetOrdinal("POAType")),
//                                POA = reader.IsDBNull(reader.GetOrdinal("POA")) ? null : reader.GetString(reader.GetOrdinal("POA")),
//                                POIType = reader.IsDBNull(reader.GetOrdinal("POIType")) ? null : reader.GetString(reader.GetOrdinal("POIType")),
//                                POI = reader.IsDBNull(reader.GetOrdinal("POI")) ? null : reader.GetString(reader.GetOrdinal("POI")),
//                                Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? null : reader.GetString(reader.GetOrdinal("Name")),
//                                KYCStatus = reader.IsDBNull(reader.GetOrdinal("KYCStatus")) ? null : reader.GetString(reader.GetOrdinal("KYCStatus")),
//                                Poiemail = reader.IsDBNull(reader.GetOrdinal("Poiemail")) ? null : reader.GetString(reader.GetOrdinal("Poiemail")),
//                                Account_Holder_Address = reader.IsDBNull(reader.GetOrdinal("Account_Holder_Address")) ? null : reader.GetString(reader.GetOrdinal("Account_Holder_Address")),
//                                RegDate = reader.IsDBNull(reader.GetOrdinal("RegDate")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("RegDate"))
//                            });
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                // Log the exception and handle accordingly
//                Console.WriteLine(ex.Message);
//                // Optionally: return an error view or message
//            }

//            // Convert the result list to a paged list
//            var pagedList = result.ToPagedList(page, pageSize);

//            return View(pagedList);
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

























//    }
//}