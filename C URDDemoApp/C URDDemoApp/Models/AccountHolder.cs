﻿using System;
using System.Collections.Generic;

namespace CURDDemoApp.Models
{
    public partial class AccountHolder
    {
        public AccountHolder()
        {
            AccountHolderLedgerAccount = new HashSet<AccountHolderLedgerAccount>();
    
        }

        public int AccountHolderId { get; set; }
        public string AccountHolderRegnNo { get; set; }
        public string AccountHolderFullName { get; set; }
        public string AccountHolderNameOnCard { get; set; }
        public long? AccountHolderPhoneNo { get; set; }
        public string AccountHolderMobileNo { get; set; }
        public short AccountHolderMobileServiceProvider { get; set; }
        public string AccountHolderEmail { get; set; }
        public string AccountHolderAddress { get; set; }
        public string AccountHolderDob { get; set; }
        public byte[] AccountHolderPhoto { get; set; }
        public string AccountHolderPhotoName { get; set; }
        public byte[] AccountHolderSignature { get; set; }
        public string AccountHolderSignatureName { get; set; }
        public DateTime? AccountHolderDurationFrom { get; set; }
        public DateTime? AccountHolderDurationTill { get; set; }
        public decimal? AccountHolderCourseFeeAmount { get; set; }
        public int? FkAccountHolderCourseId { get; set; }
        public byte? FkAccountHolderBloodGroupTypeId { get; set; }
        public short? FkAccountHolderCreatedBy { get; set; }
        public int? FkAccountHolderEntityId { get; set; }
        public string AccountHolderPin { get; set; }
        public int? FkAccountHolderHostelId { get; set; }
        public string AccountHolderPan { get; set; }
        public bool? AccountHolderPinIsReset { get; set; }
        public byte? IsKycDone { get; set; }
        public byte? FkAccountHolderStatusTypeId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public byte[] AccountHolderPwdEncrypt { get; set; }
        public int? GroupId { get; set; }
        public int? WalletTypeId { get; set; }
        public bool? LoginEnable { get; set; }
        public string Mmid { get; set; }
        public string RegisteredbyMobile { get; set; }
        public long? CustOf { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDistributor { get; set; }
        public long? DistributorCode { get; set; }
        public string Tpin { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public DateTime? ActualDob { get; set; }
        public bool? IsTpinenabled { get; set; }
        public string Pan { get; set; }
        public string Aadhaar { get; set; }
        public Guid? Salt { get; set; }
        public int? LanguageCode { get; set; }
        public bool? IsSmallScaleMerchant { get; set; }
        public string CitizenServiceCenterId { get; set; }
        public int? PlatForm { get; set; }
        public int? RegistrationTypeId { get; set; }
        public string SmsSenderid { get; set; }
        public bool? IsStatusChecked { get; set; }
        public int? UniCode { get; set; }
        public string DigithonDigitalTeacher { get; set; }
        public int? DistrictId { get; set; }
        public string Poiname { get; set; }
        public string Poidob { get; set; }
        public string Poigender { get; set; }
        public string Poiphone { get; set; }
        public string Poiemail { get; set; }
        public string Poaco { get; set; }
        public string Poadist { get; set; }
        public string Poahouse { get; set; }
        public string Poaloc { get; set; }
        public string Poapc { get; set; }
        public string Poastate { get; set; }
        public string Poavtc { get; set; }
        public string PoavtcCode { get; set; }
        public string Poastreet { get; set; }
        public string Poalm { get; set; }
        public string Poasubdist { get; set; }
        public string Poapo { get; set; }
        public DateTime? WalletUpgradationDate { get; set; }
        public bool? IsUsageCapEnabled { get; set; }
        public int? DailyUsageCapCount { get; set; }
        public decimal? DailyUsageCapAmount { get; set; }
        public byte[] TpinEncrypt { get; set; }
        public string OrderId { get; set; }
        public string Poi { get; set; }
        public string Poa { get; set; }
        public string Poitype { get; set; }
        public string Poatype { get; set; }
        public string Poiverified { get; set; }
        public string Poaverified { get; set; }
        public string BlockChainId { get; set; }
        public string BankCbsAccountNumber { get; set; }
        public string BankCbsCustomerId { get; set; }
        public string BankCbsIfsc { get; set; }
        public string BankCbsAccountType { get; set; }
        public string Uidtoken { get; set; }
        public string TempAadhaar { get; set; }
        public byte[] Aadhaarhash { get; set; }
        public string RiskStatus { get; set; }
        public DateTime? LastPasswordSetOn { get; set; }
        public string UpideviceId { get; set; }
        public string Upivpa { get; set; }
        public bool? ShowOfferDesc { get; set; }
        public decimal? LastCreditAmount { get; set; }
        public DateTime? LastCreditOn { get; set; }
        public decimal? LastDebitAmount { get; set; }
        public DateTime? LastDebitOn { get; set; }
        public string CurrAddDoorNo { get; set; }
        public string CurrAddStreet { get; set; }
        public string CurrAddLocality { get; set; }
        public string CurrAddLandmark { get; set; }
        public string CurrAddVtc { get; set; }
        public string CurrAddPincode { get; set; }
        public string CurrAddDistrict { get; set; }
        public string CurrAddState { get; set; }
        public string CurrAddCountry { get; set; }
        public bool? CurrAddIsApproved { get; set; }
        public string AndroidVersionName { get; set; }
        public string AndroidVersionCode { get; set; }
        public string IosversionName { get; set; }
        public string IosversionCode { get; set; }
        public bool? IsInAppOtpenable { get; set; }
        public int? OccupationType { get; set; }
        public int? IncomeType { get; set; }

   
        public ICollection<AccountHolderLedgerAccount> AccountHolderLedgerAccount { get; set; }
      
     
        
    }
}
