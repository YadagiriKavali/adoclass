//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Threading.Tasks;
//using CURDDemoApp.Models;
//using Microsoft.AspNetCore.Mvc;

//using Microsoft.EntityFrameworkCore;



//namespace CURDDemoApp.Controllers
//{
//    public class AccountHolderController : Controller
//    {

//        private readonly DSN_USER _context;

//        public AccountHolderController(DSN_USER context)
//        {
//            _context = context;
//        }


//        public async Task<IActionResult> Index(DateTime? date)
//        {
//            // Use the provided date or default to today's date if not provided
//            DateTime selectedDate = date ?? DateTime.Today;

//            var query = @"
//                select a.Mobilenumber, POAType, POA, POIType, POI,
//                       a.Name, a.KYCStatus, a.Poiemail, Account_Holder_Address, a.RegDate 
//                from 
//                (select Account_Holder_ID, Account_Holder_Mobileno Mobilenumber, 
//                        case when FK_Account_Holder_Entity_ID in (84) then 'T Wallet' else 'TA Wallet' end EntityName,
//                        Account_Holder_FullName Name, 
//                        case when Is_KYC_Done=2 then 'Low KYC' when Is_KYC_Done=0 then 'Medium KYC' else 'Full KYC' end KYCStatus,
//                        Poiemail, Account_Holder_Address, Created_Date RegDate 
//                 from Account_Holder with(nolock) 
//                 //where CAST(Created_Date as date) = @Date) a 
//                 join Account_Holder_Details b on a.Account_Holder_ID = b.Account_holder_ID
//                 order by RegDate desc";

//            var parameters = new[] { new SqlParameter("@Date", selectedDate) };

//            var accountHolders = await _context.AccountRegistration
//                .FromSql(query, parameters)
//                .ToListAsync();

//            return View(accountHolders);
//        }
//    }
//}