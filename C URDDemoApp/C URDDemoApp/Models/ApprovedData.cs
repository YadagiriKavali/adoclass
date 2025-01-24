using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CURDDemoApp.Models
{
    public class ApprovedData
    {
        public int Id { get; set; } // This should be auto-generated
        public string Statement { get; set; }
        public DateTime Date { get; set; }
        public DateTime ToDate { get; set; }
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
        public DateTime RegDate { get; set; }
        public string VerifiedBy { get; set; }
        public string VerificationStatus { get; set; }
        public DateTime VerifiedOn { get; set; }
        public string Remarks { get; set; }
        public string StatusCode { get; set; }
        public string StatusDesc { get; set; }
    }


}
