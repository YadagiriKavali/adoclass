using System;
using System.Collections.Generic;

namespace CURDDemoApp.Models
{
    public partial class AccMerchant
    {
        public int AccMerchantId { get; set; }
        public string AccMerchantNumber { get; set; }
        public string AccMerchantName { get; set; }
        public string AccMerchantMobileNumber { get; set; }
        public decimal AccMerchantBalance { get; set; }
        public bool AccMerchantIsOffusEnabled { get; set; }
        public bool AccMerchantIsEnabled { get; set; }
        public int FkAccMerchantEntityId { get; set; }
        public int? AccMerchantCreatedBy { get; set; }
        public DateTime? AccMerchantCreatedOn { get; set; }
        public int? AccMerchantEditedBy { get; set; }
        public DateTime? AccMerchantEditedOn { get; set; }
        public string AccMerchantPin { get; set; }
        public string AccMerchantBankName { get; set; }
        public string AccMerchantBranchName { get; set; }
        public string AccMerchantIfscCode { get; set; }
    }
}
