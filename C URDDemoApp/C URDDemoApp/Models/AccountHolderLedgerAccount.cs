using System;
using System.Collections.Generic;

namespace CURDDemoApp.Models
{
    public partial class AccountHolderLedgerAccount
    {
        public int AchLedgerAccountId { get; set; }
        public int FkAchLedgerAccountHolderId { get; set; }
        public string AchLedgerAccountNo { get; set; }
        public string AchLedgerAccountName { get; set; }
        public decimal? AchLedgerAccountGeneral { get; set; }
        public decimal? AchLedgerAccountSpecial { get; set; }
        public decimal? AchLedgerAccountReward { get; set; }
        public decimal? AchLedgerAccountCard { get; set; }
        public decimal? AchLedgerAccountCash { get; set; }

        public AccountHolder FkAchLedgerAccountHolder { get; set; }
    }
}
