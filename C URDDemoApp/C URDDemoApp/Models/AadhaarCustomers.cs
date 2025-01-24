using System;
using System.Collections.Generic;

namespace CURDDemoApp.Models
{
    public partial class AadhaarCustomers
    {
        public int AadhaarCustomerId { get; set; }
        public int AkuaCustomerId { get; set; }
        public string AadhaarNumber { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime AadhaarVerificationDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? EntityId { get; set; }
    }
}
