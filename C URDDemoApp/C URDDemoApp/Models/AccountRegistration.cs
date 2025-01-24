using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CURDDemoApp.Models
{
    public class AccountRegistration
    {
        [Key]
        public int Id { get; set; }
        public string Mobilenumber { get; set; }
        public string POAType { get; set; }
        public string POA { get; set; }
        public string POIType { get; set; }
        public string POI { get; set; }
        public string Name { get; set; }
        public string KYCStatus { get; set; }
        public string Poiemail { get; set; }
        public string Account_Holder_Address { get; set; }
        public DateTime? RegDate { get; set; }
    }
}
