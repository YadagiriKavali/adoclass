using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CURDDemoApp.Models
{
    [Table("Account_Registration_Verification", Schema = "dbo")]
    public class AccountRegistrationVerification
    {
        [Key]
        public int Id { get; set; }
        public string Statement { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? ToDate { get; set; }
        public string MobileNumber { get; set; }
        public string EntityName { get; set; }
        public string POAType { get; set; }
        public string POA { get; set; }
        public string POIType { get; set; }
        public string POI { get; set; }
        public string Name { get; set; }
        public string KYCStatus { get; set; }
        public string PoiEmail { get; set; }
        public string AccountHolderAddress { get; set; }
        public DateTime? RegDate { get; set; }
        public string VerifiedBy { get; set; }
        public string VerificationStatus { get; set; }
        public DateTime? VerifiedOn { get; set; }
        public string Remarks { get; set; }
        public string StatusCode { get; set; }
        public string StatusDesc { get; set; }

        public int ID { get; set; }
        public string Mobilenumber { get; set; }  
       
        public string Poiemail { get; set; }
        public string Account_Holder_Address { get; set; }
   
        public string Verifiedby { get; set; }
       
        
        

    }


}
