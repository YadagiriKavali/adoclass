using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TWelletDemoApp.Models
{
    public class AccountHolderDT
    {[Key]
        public int AccountHolderId { get; set; }
        public string AccountHolderMobileno { get; set; }
        public string POAType { get; set; }
        public string POA { get; set; }
        public string POIType { get; set; }
        public string POI { get; set; }
        public string AccountHolderFullName { get; set; }
        public string IsKycDone { get; set; } // Ensure this is a byte type
        public string Poiemail { get; set; }
        public string AccountHolderAddress { get; set; }
        public DateTime? CreatedDate { get; set; }
        [Required(ErrorMessage = "Remark is required.")]
        public string Remarks { get; set; }

        public string Mobilenumber { get; set; }

        public string EntityName { get; set; } 
      
        [StringLength(299)]
        public string Name { get; set; }

        [StringLength(299)]
        public string KYCStatus { get; set; }

       
        public string Account_Holder_Address { get; set; }

        public DateTime RegDate { get; set; }

        [StringLength(299)]
        public string Verifiedby { get; set; }

        [StringLength(299)]
        public string VerificationStatus { get; set; }

        public DateTime? VerifiedOn { get; set; }

        [StringLength(2999)]
      
        public string StatusDesc { get; set; }
        public string StatusCode { get; set; }
        public string Statement { get; set; }

        [Required(ErrorMessage = "Approve is required.")]
        public string Approve { get; set; }

        [Required(ErrorMessage = "Reject is required.")]
        public string Reject { get; set; }




    }
}
