using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TWelletDemoApp.Models
{
    [Table("Account_Registration_Verification", Schema = "dbo")]
    public class AccountRegistrationVerification
    {
        [Key]
        public int Id { get; set; } // Assuming Id is the primary key

        [Required]
        [StringLength(299)]
        public string Mobilenumber { get; set; }

        [StringLength(299)]
        public string EntityName { get; set; }

        [StringLength(299)]
        public string POAType { get; set; }

        [StringLength(299)]
        public string POA { get; set; }

        [StringLength(299)]
        public string POIType { get; set; }

        [StringLength(299)]
        public string POI { get; set; }

        [StringLength(299)]
        public string Name { get; set; }

        [StringLength(299)]
        public string KYCStatus { get; set; }

        [StringLength(299)]
        public string Poiemail { get; set; }

        [StringLength(2999)]
        public string Account_Holder_Address { get; set; }

        public DateTime RegDate { get; set; }

        [StringLength(299)]
        public string Verifiedby { get; set; }

        [StringLength(299)]
        public string VerificationStatus { get; set; }

        public DateTime? VerifiedOn { get; set; }

        [StringLength(2999)]
        public string Remarks { get; set; }
        public string StatusDesc { get; set; }
        public string StatusCode { get; set; }
        public string Statement { get; set; }
        public int Account_Holder_ID { get; set; }
    }
}
