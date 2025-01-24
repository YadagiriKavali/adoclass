//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;
//using TWelletDemoApp.Models;

//namespace TWelletDemoApp.Data

//{
//    public partial class Semi_C3_StandardizedContext : DbContext
//    {
//        public Semi_C3_StandardizedContext()
//        {
//        }

//        public Semi_C3_StandardizedContext(DbContextOptions<Semi_C3_StandardizedContext> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<AadhaarCustomers> AadhaarCustomers { get; set; }
//        public virtual DbSet<AccMerchant> AccMerchant { get; set; }
//        public virtual DbSet<AccountHolder> AccountHolder { get; set; }
//        public virtual DbSet<AccountHolderLedgerAccount> AccountHolderLedgerAccount { get; set; }
//        public virtual DbSet<AccountHolderStatusType> AccountHolderStatusType { get; set; }
//        public virtual DbSet<AccWallet> AccWallet { get; set; }
//        public virtual DbSet<AuditUsers> AuditUsers { get; set; }
//        public virtual DbSet<BasicMobileTransaction> BasicMobileTransaction { get; set; }
//        public virtual DbSet<BasicRegistrationMobile> BasicRegistrationMobile { get; set; }
//        public virtual DbSet<BasicRegistrationMobileEmail> BasicRegistrationMobileEmail { get; set; }
//        public virtual DbSet<BlockedCard> BlockedCard { get; set; }
//        public virtual DbSet<BlockedReasonType> BlockedReasonType { get; set; }
//        public virtual DbSet<BlockedUsers> BlockedUsers { get; set; }
//        public virtual DbSet<BloodGroupType> BloodGroupType { get; set; }
//        public virtual DbSet<BotRequestXml> BotRequestXml { get; set; }
//        public virtual DbSet<BtFile> BtFile { get; set; }
//        public virtual DbSet<BtLogChanges> BtLogChanges { get; set; }
//        public virtual DbSet<Bulkfile> Bulkfile { get; set; }
//        public virtual DbSet<BusinessTransactionsAdministrator> BusinessTransactionsAdministrator { get; set; }
//        public virtual DbSet<BusinessTransactionsFinancial> BusinessTransactionsFinancial { get; set; }
//        public virtual DbSet<BusinessTransactionsNonFinancial> BusinessTransactionsNonFinancial { get; set; }
//        public virtual DbSet<BusinessTrxnsAmountLimit> BusinessTrxnsAmountLimit { get; set; }
//        public virtual DbSet<CardRequestTemp> CardRequestTemp { get; set; }
//        public virtual DbSet<CardStatusType> CardStatusType { get; set; }
//        public virtual DbSet<CardType> CardType { get; set; }
//        public virtual DbSet<CcavenueCreditDetails> CcavenueCreditDetails { get; set; }
//        public virtual DbSet<ChargeBackDetails> ChargeBackDetails { get; set; }
//        public virtual DbSet<ConfigParameters> ConfigParameters { get; set; }
//        public virtual DbSet<Course> Course { get; set; }
//        public virtual DbSet<CyberplatCreditDetails> CyberplatCreditDetails { get; set; }
//        public virtual DbSet<DatabaseMailFailure> DatabaseMailFailure { get; set; }
//        public virtual DbSet<Department> Department { get; set; }
//        public virtual DbSet<DvlCardDetails> DvlCardDetails { get; set; }
//        public virtual DbSet<DvlRequestXml> DvlRequestXml { get; set; }
//        public virtual DbSet<DvlResponseMessage> DvlResponseMessage { get; set; }
//        public virtual DbSet<DvlSellerDetails> DvlSellerDetails { get; set; }
//        public virtual DbSet<DvlUnregisteredFundTransfers> DvlUnregisteredFundTransfers { get; set; }
//        public virtual DbSet<EmployeeWorkLoad> EmployeeWorkLoad { get; set; }
//        public virtual DbSet<Entities> Entities { get; set; }
//        public virtual DbSet<EntitiesInactive> EntitiesInactive { get; set; }
//        public virtual DbSet<Features> Features { get; set; }
//        public virtual DbSet<FiuValues> FiuValues { get; set; }
//        public virtual DbSet<Groups> Groups { get; set; }
//        public virtual DbSet<HelpDeskStatus> HelpDeskStatus { get; set; }
//        public virtual DbSet<Hmwssbupload> Hmwssbupload { get; set; }
//        public virtual DbSet<Hostel> Hostel { get; set; }
//        public virtual DbSet<ImpsTrxns> ImpsTrxns { get; set; }
//        public virtual DbSet<ImpsTrxnsRejected> ImpsTrxnsRejected { get; set; }
//        public virtual DbSet<LogTerminals> LogTerminals { get; set; }
//        public virtual DbSet<LogWeb> LogWeb { get; set; }
//        public virtual DbSet<MerchantConfig> MerchantConfig { get; set; }
//        public virtual DbSet<MerchantEntityConfiguration> MerchantEntityConfiguration { get; set; }
//        public virtual DbSet<MerchantInfo> MerchantInfo { get; set; }
//        public virtual DbSet<MerchantsAudit> MerchantsAudit { get; set; }
//        public virtual DbSet<MobileVenodrs> MobileVenodrs { get; set; }
//        public virtual DbSet<NbinMaster> NbinMaster { get; set; }
//        public virtual DbSet<NeftFileMapping> NeftFileMapping { get; set; }
//        public virtual DbSet<NotfServiceTypes> NotfServiceTypes { get; set; }
//        public virtual DbSet<NotifMailConfig> NotifMailConfig { get; set; }
//        public virtual DbSet<NotifMailList> NotifMailList { get; set; }
//        public virtual DbSet<PayQwikCampaigns> PayQwikCampaigns { get; set; }
//        public virtual DbSet<PayQwikCampaignTypes> PayQwikCampaignTypes { get; set; }
//        public virtual DbSet<PayQwikCardDetails> PayQwikCardDetails { get; set; }
//        public virtual DbSet<PayQwikCouponsIssued> PayQwikCouponsIssued { get; set; }
//        public virtual DbSet<PayQwikCyberPlatTransactions> PayQwikCyberPlatTransactions { get; set; }
//        public virtual DbSet<PayQwikRegistrationEmail> PayQwikRegistrationEmail { get; set; }
//        public virtual DbSet<PayQwikRegistrationMobile> PayQwikRegistrationMobile { get; set; }
//        public virtual DbSet<PayQwikRequestXml> PayQwikRequestXml { get; set; }
//        public virtual DbSet<PayQwikResponseMessage> PayQwikResponseMessage { get; set; }
//        public virtual DbSet<PayQwikUnregisteredFundTransfers> PayQwikUnregisteredFundTransfers { get; set; }
//        public virtual DbSet<Pictures> Pictures { get; set; }
//        public virtual DbSet<PosAuthenticationType> PosAuthenticationType { get; set; }
//        public virtual DbSet<PostingStatusType> PostingStatusType { get; set; }
//        public virtual DbSet<RechargeModeType> RechargeModeType { get; set; }
//        public virtual DbSet<Resources> Resources { get; set; }
//        public virtual DbSet<ResourcesMvc> ResourcesMvc { get; set; }
//        public virtual DbSet<ResourcesNew> ResourcesNew { get; set; }
//        public virtual DbSet<ResourcesTemp> ResourcesTemp { get; set; }
//        public virtual DbSet<ResourceTypes> ResourceTypes { get; set; }
//        public virtual DbSet<RewardsConfig> RewardsConfig { get; set; }
//        public virtual DbSet<RoleFeatures> RoleFeatures { get; set; }
//        public virtual DbSet<Roles> Roles { get; set; }
//        public virtual DbSet<RolesResources> RolesResources { get; set; }
//        public virtual DbSet<SemiC3AadhaarWalletInfo> SemiC3AadhaarWalletInfo { get; set; }
//        public virtual DbSet<SemiC3Campaigns> SemiC3Campaigns { get; set; }
//        public virtual DbSet<SemiC3config> SemiC3config { get; set; }
//        public virtual DbSet<SemiC3CouponsIssued> SemiC3CouponsIssued { get; set; }
//        public virtual DbSet<SemiC3FeeCollectionInstitute> SemiC3FeeCollectionInstitute { get; set; }
//        public virtual DbSet<SemiC3FeeCollectionTypes> SemiC3FeeCollectionTypes { get; set; }
//        public virtual DbSet<SemiC3GatewayRequestXml> SemiC3GatewayRequestXml { get; set; }
//        public virtual DbSet<SemiC3GatewayResponseMessage> SemiC3GatewayResponseMessage { get; set; }
//        public virtual DbSet<SemiC3HmwssbMisTransactions> SemiC3HmwssbMisTransactions { get; set; }
//        public virtual DbSet<SemiC3ImpsWalletwiseRequestlog> SemiC3ImpsWalletwiseRequestlog { get; set; }
//        public virtual DbSet<SemiC3languageKeyWords20052017> SemiC3languageKeyWords20052017 { get; set; }
//        public virtual DbSet<SemiC3languageKeyWordsIos02may2017> SemiC3languageKeyWordsIos02may2017 { get; set; }
//        public virtual DbSet<SemiC3languageKeyWordsTa> SemiC3languageKeyWordsTa { get; set; }
//        public virtual DbSet<SemiC3PointsInfoMaster> SemiC3PointsInfoMaster { get; set; }
//        public virtual DbSet<SemiC3RequestUpiXml> SemiC3RequestUpiXml { get; set; }
//        public virtual DbSet<SemiC3RequestXml> SemiC3RequestXml { get; set; }
//        public virtual DbSet<SemiC3RequestXmlOld1> SemiC3RequestXmlOld1 { get; set; }
//        public virtual DbSet<SemiC3ResponseUpiMessage> SemiC3ResponseUpiMessage { get; set; }
//        public virtual DbSet<SemiC3RewardPointsInfo> SemiC3RewardPointsInfo { get; set; }
//        public virtual DbSet<SemiC3ShgwalletInfo> SemiC3ShgwalletInfo { get; set; }
//        public virtual DbSet<SemiC3SmsLogs> SemiC3SmsLogs { get; set; }
//        public virtual DbSet<SemiC3TaDevelopers> SemiC3TaDevelopers { get; set; }
//        public virtual DbSet<SemiC3TaProjects> SemiC3TaProjects { get; set; }
//        public virtual DbSet<SemiC3TaProjectsSubCategory> SemiC3TaProjectsSubCategory { get; set; }
//        public virtual DbSet<SemiC3UnregisteredFundTransfers> SemiC3UnregisteredFundTransfers { get; set; }
//        public virtual DbSet<SemiC3UpiTrxnDetails> SemiC3UpiTrxnDetails { get; set; }
//        public virtual DbSet<SemiC3UpiTrxnDetails201802091136> SemiC3UpiTrxnDetails201802091136 { get; set; }
//        public virtual DbSet<SemiC3WalletsPaymentGatewayRequestsLog> SemiC3WalletsPaymentGatewayRequestsLog { get; set; }
//        public virtual DbSet<ServiceProviders> ServiceProviders { get; set; }
//        public virtual DbSet<SessionTypes> SessionTypes { get; set; }
//        public virtual DbSet<SettlementDetails> SettlementDetails { get; set; }
//        public virtual DbSet<SettlementMerchantRequest> SettlementMerchantRequest { get; set; }
//        public virtual DbSet<Settlements> Settlements { get; set; }
//        public virtual DbSet<Tasettlements> Tasettlements { get; set; }
//        public virtual DbSet<TawebResources12mar17> TawebResources12mar17 { get; set; }
//        public virtual DbSet<TawebResourcesTa> TawebResourcesTa { get; set; }
//        public virtual DbSet<Terminals> Terminals { get; set; }
//        public virtual DbSet<TerminalsBts> TerminalsBts { get; set; }
//        public virtual DbSet<TerminalTypes> TerminalTypes { get; set; }
//        public virtual DbSet<TransactionType> TransactionType { get; set; }
//        public virtual DbSet<TrxnsAdjustments> TrxnsAdjustments { get; set; }
//        public virtual DbSet<TrxnsElectricityBillDetails> TrxnsElectricityBillDetails { get; set; }
//        public virtual DbSet<TrxnsFailed> TrxnsFailed { get; set; }
//        public virtual DbSet<TrxnsFlightTicket> TrxnsFlightTicket { get; set; }
//        public virtual DbSet<TrxnsHotelTicket> TrxnsHotelTicket { get; set; }
//        public virtual DbSet<TrxnsMoibleRechargeChangedStatus> TrxnsMoibleRechargeChangedStatus { get; set; }
//        public virtual DbSet<TrxnsSwitchLog> TrxnsSwitchLog { get; set; }
//        public virtual DbSet<UploadCourseFeeDues> UploadCourseFeeDues { get; set; }
//        public virtual DbSet<Users> Users { get; set; }
//        public virtual DbSet<UserStatusType> UserStatusType { get; set; }
//        public virtual DbSet<UserTypes> UserTypes { get; set; }
//        public virtual DbSet<VbRequestXml> VbRequestXml { get; set; }
//        public virtual DbSet<VbResponseMessage> VbResponseMessage { get; set; }

//        // Unable to generate entity type for table 'dbo.SemiC3_Issue_FoodCoupon_Instrument_Requests'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FIU_TRFLPE'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_TWallet_Payment'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Merchant_Config_CDMA_20082022'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CCAvenue_TotalReport_for_Invoice_Recon'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_Submitted'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ReversibleAmountscc_1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SHG_MandalMaster'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myFileList1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_UPI_Refund_Transctions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Applicaton_ResponseCodes'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CyberplatCsv_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3LanguageKeyWords_IOS_25052017PM'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MeesevaCentersInc'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Account_Holder_PayQwik_10012018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Fraud_Monitoring'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RUPAY_Escrow_Reconcilied_BATCH_Records'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Recon_Dashboard_ABS2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SHG_PaymentDetails'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.UPICreditCardTransactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.files1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_YesBank_Biller_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FIU_ARFBRC'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_Scholarship_Bulk_Registrations'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPS_May2024_Data_Others'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ReversibleReportTrxnID'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_VijayaBank_AccountStatement'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ScholarShip_SCDD_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AEPS_CashWithDrawal_Transaction'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXNS_ElectricityBillDetails_backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SHG_SHGMaster'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myFileListRazp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Meeseva_Registrations'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FIU_ARFACC'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Account_Holder_TA30082021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_TWallet_Cashout'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_Payments_02082019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SLA_Transaction_Timestamps_History'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DBServerCPUUtilization'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DatabaseAuditLog'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RBI_Monthly_Report_12_2020'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.sp_SemiC3_CitizenService_Dashboard_Input'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2023TABalance'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_WalletLogin_OfferMessage_Configs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SHG_VOMaster'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.filesRazp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FIU_ARFTRN'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_TWallet_IMPS'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Playstore_Links_Ratings'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAUDIT2023TACredit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RBI_Monthly_Report_Latest'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myFileList1Razp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_DMT_Beneficiary_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FIU_ARFINP'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CCAvenueChargesSlab_TWallet'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_TWallet_WallettoWallet'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_PaymentGateway_Forced_Reversals'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXNS_Agent_PullFunds'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXNS_MOBILE_RECHARGE'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_02092021_POA'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FIU_ARFLPE'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Customer_IncomeList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemC3_Email_Receipts'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myFileListSMSLog'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PAYU_Settlement_Dates'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.StateDistrictMaster'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PAYU_Recon_File_Delete'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Test1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempTDSStat'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.files1Razp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.StateMaster'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IMPSStatus_SemiC3Status'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBI_Datadump_CustomerData_11052023_Min_GT_10000_Debit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_HelpCenters_List'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPS_April2024_Data_Others'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.filesSMSLog'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.UPI_Rupay_CreditCard_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallet_Password_History'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Blocking_Debits_Removed'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PAYU_WalletPG_MIS'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IMPSStatus_NPCIStatus'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAuditTAGBalance'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_Eagle_EYE_History_April_2024'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SMSLogs_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SID_Type'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Distributor_Groups_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked_TWallet_05062018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Agent_Incentive_Feb2018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Adds_Slot'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Card_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Payment_RequestTypes_List'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IPAY3'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Bill_Avenues_Payments'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_District_Master'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Sms_credit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.UNSCList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Account_Holder_Balance_Verification'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TSPDCL_Del_Debit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Rupay_Refunds_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.BlockedMachineID'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RBI_Monthly_Report_04_2019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.EmployeeWorkLoadReplies'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBI_Transaction_Dump_LastTrxnDate'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Hotlist_Cards'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AccountClosure_Requests'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.PayUCallBackOrderList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SMSLogFilesprocessed'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBI_Datadump_CustomerData_11052023_Form60Leftout'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MedKYCWorkbook_UpgradetoKYC'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ESCROW_Credits'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_YesBank_Payments'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Account_WalletTypes'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Manual_FullKYC_Attachments'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.AccountHolderPAN_RBI_03032020'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_CenterList_UnReg'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.NEFT_MAPPING_SETTING'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TSPDCL_Del_JournalEntry'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PAYU_Consolidated_SettlementFile'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAUDIT2021TAGCredit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Seamless_Integration_BankCodes'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.PAYUCBFilesprocessed'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.GHMCOrderID'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_LoadMoney_PG_Settlement_Holiday_List'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SMSDaakPendingReversal'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_Eagle_EYE_History_02092018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TSTSDATA03102018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_DMT_Beneficiary_Details_Inactive'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DelTrxns_Credit_GovtCenter'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Semic3_TransactionDetails_02032020'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Students_Reg_Data'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Franchise_BalanceAlert'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallet_Loging_Failed_Attempts_Backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_NEFT_File_Refunded'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TSPSC_AADHAAR_Transaction_Abstract'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.APEPDCL_Request_Response_Logs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IPAY_Biller_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_ESD_SLA_PA_Level2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AutoPay_Reminders'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ServiceProvides_YesBank'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallet_LastLoginTime'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Entity_Transaction_Limits'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked_TWallet_29092017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Group_Status'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TesTSettlement'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked_TWallet_05092017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IPAY'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TrxnUniqueID'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_FullKYC_Requests_Old'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_VijayaBank_AccountStatement2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Merchant_Department_QRPayments'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IPay_ReversibleCodes'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Customer_Notifications'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Entity_Status'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AccountClosure_Requests_Backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXNS_MERCHANT_TXRNS'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SMS_Configuration_Table'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Email_Service'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.OSSCentersList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3LanguageKeyWords_lblFateway'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ServiceProvides_BillAvenues'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_Payments_24042021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_BillAvenues_BBPS_Response_Codes'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked_TWallet_10092017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Escrow_Credits'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PAYU_Recon_File_Del'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_Payments_14062019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Adds_Type'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_Payments_Testing'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_FundTransfer'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Rupay_Refunds'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TAWeb_Role_Resources'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.VisiontekFPShopDetails'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.UPI_TPAP_Blocked_Mobile_list'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.PAN_TransactionLogs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_Eagle_EYE_History_11062024'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TransactionAnalysts_Domain'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ServiceProvides_BillAvenues_29112023'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Merchant_Payment_CustomerAuthentication'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_YesBank_PushStatusUpdates'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_AgencyList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AADHAAR_KYC_Customers_Suspected'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CMS_New'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallet_JunkNames'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_FundTransfer_Benificiary_List'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.tawallet192667450-226843-000'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Disputes_26072017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.testtsts'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_Departments'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.EagleEye_RCA'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_AADHAARLogs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Customer_Auto_Debit_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_CenterList_FPShopRegistrations'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_CCSTS_Citizen_AADHAAR_Token'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_BillerAvenues_CategoryList_26112021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Occupation_Income_Logs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_FullKYC_Requests'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_Districts'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021TransactionDetails_Final_Rebuild'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_APEPDCL_MIS_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ElecData'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IMPSStatus'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_State'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.sp_SemiC3_BillAvenues_Info_Input'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.testtshg'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Eseva_MIS_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Debit_Lien_Amount'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DVLAccountUnblockedon28012016'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Response_Languages'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TSSPDCL_Charges_Exempted'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AutoPay_Reminders_Payments'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ScholarshipActivity01022020'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Issue_Gift_Instrument_Categories'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PAN_Batch_Verification_Logs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Razorpay_Consolidate_Settlements'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Recovery_Process_Backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Semic3_Citizen_Service_Payments_11022020'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TrxnUniqueID1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Frachaise_MIS_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_FlameK18_Campaign'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3LanguageSupport'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Email_Logs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_HealthCoupons_Employee_Organisations_Maker_Checker'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DVL_Password'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Registrations_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_NEFT_File_EscrowCredits'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_Registrations'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.AADHAAR_Reference_Mapper_TA'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Distributor_Groups_old'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PAYU_MIS_Trasactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Login_Failed_Attempts'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.APGWS_ABS_Level2_Credit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABSTable3'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TrxnUniqueID2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CCAvenue_Credit_Details_TAGITI'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallet_ProfileTPIN_Failed_Attempts'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_CCAvenue_ChargeBack_OrderTrack'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Text'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_GHMC_MIS_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DVLFinalBlocked28012016'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PushNotification_Messages'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TrxnUniqueID3'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Test_CustComp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AEPS_Group_Mobiles'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TAWallet_Bulk_Registrations'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CCAvenueTransactionSummary'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Entities_ClosedAccounts'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ERO_Master'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_CenterList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Request_XML_old'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TAWeb_Role_Resources_Old'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Recon_Reinitiate'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.EchallanFailures'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Merchant_Adhoc_Payment_Requests'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DatesTeset'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Account_Holder_TAGITI'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IPAY_Biller'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Department_TransactionStatusUpdate_Logs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CCAvenuePayout'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RBI_Monthly_Report_2018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FY20212022Top100Customers'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MerchantKYCDetails_LargeScale'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_Transactions_Approval'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SplitPaymentRequests'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Promotions_Campaigns_Info'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.AutoNachSettlementInsert_11112019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.NEw123'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_YesBank_Biller_24012023'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXNS_MOBILE_RECHARGE_TAGITI'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SMS_Logs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Meeseva_MIS_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CCAvenueFilesprocessed'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Original_RBIAudit2021CustomerData'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXNS_Credit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Suspicious_Transactions_ConfigurationTypes'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Limits_ExcemptedMobiles'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked_05092017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.APGWS_ABS_Level2_Credit_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TSNPDCL_MIS_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXNS_BusTicket_Replica'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ScholarshipDiscrepancies'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.sp_SemiC3_MerchantSettlement_input'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ServiceProvides_YesBank_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IMPS_ESD_VLE_Commissions_April2020'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempPaymentOrdersDr'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempFraudReport'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TSSPDCL_MIS_report_13_16_042017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_Payments_06112019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Fraudulent_Risk_Parameters'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_TWallet_TPVTPT'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Blocking_Debits'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ServiceProvides_BillAvenues_18052021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TWalletRegReport310082017180700'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.GHMCOrderIDs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3LanguageKeyWords_24052017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBICategories'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ChallanTeam_Data'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.InactiveMobile_23102020'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempMerchantRecords'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPS_April2024_Data_Self'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallet_Kadamba_Payment_Requests'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Portal_List'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Escrow_MerchantRegisteredDetails'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FDMS_Email_Outbound_Input'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CP_Broadband_Operators'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Checksum_Difference_Accounts_BalanceUpdate'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ScholarshipTemp2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Registration_Mobile'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.PANRecords'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ServiceProvides_20201119'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Semic3_Feedback_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.AADHAAR_Reference_Mapper_TAG'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TrxnTypesCharges_13062018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ReferencePhoto'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SMS_Templates'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CP_DTH_Operators'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MerchantSettlement'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.tawallet469471035-301947-000'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Customer_Groups'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Pincode_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ESD_DayEnd_Statement_Maker_24112022'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Merchant_MDR_Charges'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Issue_HealthCoupon_Instrument'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Physical_Consent_Submitted_Agents'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Merchant_Adhoc_Payment_Requests_Failed'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_UPI_PSP_Configurations'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.EntityDashboard_Input'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CP_Electricity_Operators'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_TWallet_MinKYC'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ChargeBackOrders14AUG2017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Billavenues_CircleList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.BillavenuesInvoiceRecon'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallet_ProfileTPIN_Failed_Attempts_Backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Application_Performance_SLA'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXNS_Water_BillDetails_Reinitiated'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Login_with_External_Integration_History'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.temp12345'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Android_MenuList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_PG_Promotion_LuckyDraw'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SampDebit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Issue_FoodCoupon_Instrument_Reload_Attachments'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_Payments_05122022'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Rupay_Payment_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_GHMC_Bill_Payments'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_Paymentgateway_disputes_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TS_FPSHOP_DATA'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AADHAAR_KYCResponse'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SampTable'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SampCredit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Card_Details_9908288955'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Issue_Fuel_Instrument'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.BlockedIMPSDestinations'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CCAvenueDisputes_AxisbankReport_14092017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RBI_Daily_Report_Test'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TestLogs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_MerchantSettlement_20171116'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RBI_Monthly_Interim_Data'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Form60'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.LoadCounter'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAUDIT2021TAGDebit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Semic3_Feedback'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_ESD_SLA_Level2_Live_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RBI_Monthly_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Pincode_Temp_New'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Tsspdclupload'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Statements_Tobe_Submitted_RBI'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_StringMatching'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Issue_FoodCoupon_Instrument'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAuditMigratedBatch1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Rep'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_VijayaBank_AccountStatement_Oct_Dec_03122018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Risk_Profile_Configurations'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_KYCStatus_Converted'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FDMS_Email_Sent_Logs_Archive'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXNS_NEFT_STATUS_Table'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SMSDaak_Automated_Reversals_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Promotions_Campaigns_Info_Backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Account_Holder_Validation_Master'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_CummFundMinKYC'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ServiceProvides_BillAvenues_12082022'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempSCDD_Work5'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Test_NEFT'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_WalkInCustomer_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021TransactionDetails_Final_GT1L_686571'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DisputeOrderID_PDF'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_CustomerComplaints'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MerchantDetailedSettlementReport'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Mobile_Group_Map_With_Vendor'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempOPT'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AutoReversal_Step2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Account_Holder_Entity_Migration'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Account_Holder_Validation_Master_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ESD_ESCROW_PrefundDeposit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TSPSC_MIS_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_Payments_07052024'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RiskCategorization_of_Wallet'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Suspicious_Transactions_Abstract'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Flight_PassengerDetails'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempOPT1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_VijayaBank_AccountStatement_Backup_12112019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Temp_IMPS_ESD_VLE_Commissions_Reports'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Account_Holder_Ledger_Account_Rec'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Login_with_External_Integration'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_FullKYC_Requests_Rejected'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Account_Holder_Validation_Master_History'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CCAvenuePendingOrders'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021_Final_GT1L'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempPaymentOrdersCr'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Wallets_PaymentGateway_WalletLinking_Request'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Table2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ExceptionHandling'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Flight_Booking_StatusCodes'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.psopdf'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IRCTC_Refunds'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Eseva_MIS_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TA_Card_BIN_List'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Employee_Holiday_list'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TAG_Account_Holder_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Issue_HealthCoupon_Instrument_Reload'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_APCPDCL_MIS_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AEPS_Bank_MIS_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_FASTAG_VehicleClass'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.BulkRegPayism06012017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_FlightImages'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBI_Data_Debit_TAG_Dump_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ProductionChanges'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2023TAGBalance'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.EscrowStatement3Months'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ServiceProvides_BillAvenues_20052024'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Entity_Failure_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TSTS_MIS_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TestCivilSuppliesPaymentTransactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SecurityQuestions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CitiTopup05022024'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempJsonEmp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IMPS_Recon_Tracking_Report_Scheduler'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.mySMSLogFileList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_Payments_02012023'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DeletedSessions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_FundTransfer_PreRegistered_Beneficiaries'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MedKYCBackup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DisputesList24072017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempSPDCLReqRes1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Semic3_Abhibus_Whitelisted_Numbers'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Employee_Organizations'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SMSLogfiles'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Distributor_Groups'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_UPI_PSP_Integration'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TAWebResources_Old'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CCavenu_RevesalOreder_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IMPS_CallBack_Status_Update'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Semic3_TransactionDetails_03022020_03392020'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MMIDBeneficiaryDuplicate'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_MerchantSettlement_1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.APGWS_ABS_Level1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallets_PaymentGateway_Refund'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_ESD_SLA_Level1_Live'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DummyTable'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_NEFT_File_Retured'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Employee_Organizations_Allowances_Reload'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Statement3Month'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.sp_SemiC3_Wallets_PaymentGatewayPayments_Input'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempIMPsRev'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallet_Kadamba_TopUp_Requests'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.PayismBulkReg060117'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_CDMA_MIS_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Issue_Gift_Instrument'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Account_Holder_Ledger_Account_08052018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Track_sp_Blitz'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Employee_Organizations_Attachments'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TempCenters_20170931'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Registrations_Restrictions_Exemptions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Cyber_Plast_Validation_check'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CP_Landline_Operators'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_MNRL_Matched_Wallet_List'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPS_Charges_CashbackAmount'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ZeroBalance_Wallets_Level1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Employee_Organizations_Employees_List'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Deactivated_Surrendered_MobileNumbers'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempSCDD_Work2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked_TWallet_24022018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myCCASUFileList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_InactiveCustomer_Due_diligence'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.abhibus_Excel_upload'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPS_Failed_Txns'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Cyber_Plast_Payment_request'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CP_Gas_Operators'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ZeroBalance_Wallets_Level2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_IDNo2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAUDIT2023_PrevData_Final'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Employee_Organizations_Employees_MakerChecker'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Issue_HealthCoupon_Instrument_Reload_Attachments'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.AADHAAR_logs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_ESD_SLA_Enabled'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_APCPDCL_MIS_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CCASUfiles'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Employee_Organizations_Reimbursement_Requests'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AEPS_Services_Enabled_Agents_23082019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CP_Insurance_Operators'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_CenterList_Testcenter'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Released_scholarship_wallets'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.NachReconiciledRecords'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempElect_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Employee_Organizations_Employees_Rejected'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MedKYCFinalStep1TrxnData'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPSChargesPendingDebit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.bulkposting'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Account_Holder_EsevaGovt_Centers'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_Eagle_EYE_History_April2021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_ESD_SLA_PA_Level1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SLA_Transaction_Timestamps'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.BulkDisputesBlocking_Backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TSPIES_Challan_Payment'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Employee_Organizations_Employees_Reloading_Requests'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IMPSStatus_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Issue_Gift_Instrument_Status'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempCCCharges'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempIPAYVEndorResponse'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Employee_Organizations_Maker_Checker'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPS_Reversible_ResponseCodes'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Notfi_SMTP_config'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked_TWallet_06112017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Busticket_Manual_Reversals'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021TransactionDetails_Final_GT1L_96539'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TAWallet_Agent_AreaManager_Mapping'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_FreeIMPS_Merchant_List'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ScholarshipResult'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SMSDaak_Pending_Cashback_Credit_SMS'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Employee_Organizations_Prefund_Account_Entries'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_KYCUpgradedData_Backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.PayQwik_CustomerCare_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RTCConnection_Old'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.AccountDayClosingBalance_PrefundedMerchant'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_03092021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RXNS_Debit_Del_20170616'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ServiceProvides'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TA_Developers_Projects'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Telangana_CityWise_TWalletMerchants'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PayU_Computed_NetSettledAmount_TA'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021TransactionDetails_Final_Rebuild_data_Backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Merchant_Config27112018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Employee_Organizations_Prefund_Account_Entries_Rejected'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Wallets_PG_Tracking'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Issue_HealthCoupon_Instrument_Requests'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MedKYCWorkbook_old'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.OfflineLoadMoneyBankList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IMPS_DigitalPartner_Transaction_Charges_Commissions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TA_Peer_Review'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_HMWSSB_Water_Tanker_Payments'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempBulkGift'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Suspicious_Transactions_Configuration_Requests'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TAGITICredit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Bot_Access_Token_Generation'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Employee_Organizations_Prefund_Account_LedgerStatement'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CCAvChargesDebit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_HMWSSB_SWC_MIS_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RBI_Monthly_Report_2018_06102019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.tawallet1905064611-323923-000'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.NamesList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Rupay_Summary_Excel_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Rupay_Loging_Failed_Attempts'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Entity_Mail_Receipients'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked_TWallet_22082017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021TransactionDetails_Final_KYCDowngraded'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AADHAAR_EKYC_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Track_Reversals_Timeline'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TAGITIDebit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAUDIT2023TAGCredit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ChargeBack_Automation_Process_02102019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Issue_Fuel_Allowance_Instrument'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_CKYC_Detail_20'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ElectricityBoardDetails'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.PayQwik_Coupons_Issuednew'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.HMWSSB_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PAYU_Recon_File'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.APGWS_ABS_Level1_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AutoReversal_Step1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TWalletTSRTCPaymentRequests'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Issue_Fuel_Allowance_Instrument_Reload'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CP_PostPaidMobileOperators'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Suspicious_Transactions_Configuration'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RTCConnection'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DVL_TransactionDetails'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MedKYCWorkbook_Downgraded'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallets_PaymentGateway_Responses'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked_TWallet_26102018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.EmployeeWorkLoad_20181228'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.NBIN_MASTER_OLD'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAuditTABalance'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.AutoNachSettlementInsert'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.BlockedAccountIMPSDestinations'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Issue_Fuel_Allowance_Instrument_Reload_Attachments'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CP_Datacard_Operators'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TestCircleList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_Eagle_EYE_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MedKYCWorkbook2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3LanguageKeyWords_IOS_27052017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AbhiBus_Bookings'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAUDIT2021TACredit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_VCIP_Whitelisted_Mobilenumbers'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_NullOVD'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Recon_Dashboard_ABS3'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MerchantStatus'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Issue_Fuel_Allowance_Instrument_Requests'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAUDIT2023_PrevData'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.tempgtloc'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.NucleusIMPSRecon'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_03092021_2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBI_MonthlyReport'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SMSTemplates'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAUDIT2023TAGDebit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_Growth_Indicators'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_WalletLogin_Counter'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CP_Mobile_Operators'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_EntityWiseLimits'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_VPA_Registration'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Rupay_Loging_Failed_Attempts_Backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ESD_DayEnd_Statement_05112019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.WalletAccountDetails'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IMPS_Transaction_Charges'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Debit_Lien_Amount_Recovery_History'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021OpeningBalance'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_InvalidMobile'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.AADHAAR_Merge2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempUPICreditReinitiate'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Temp177'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_CenterList_Extract'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Issue_Gift_Instrument_BulkRequest'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPS_Trxns_TAGITI'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMEIBasedDisputesAccounts'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myPAYUCBFileList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.UNSC_Sanctioned_list'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ACH_Ledger_Account_Unbloked_02042019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TMT_EntityWise_TransactionCount_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.tempempjson'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXNS_FAILED_Credit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RBI_Monthly_Report_9_2020'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_Payments_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AADHAAR_Service_Transaction'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PAYU_Recon_File_TA'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Account_KycStatus'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked_TWallet_31012018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IFSCMASTER_New'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PAYU_Recon_File_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Notification_Templates'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021TransactionDetails_Final_GT1L_Data'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AADHAAR_Cash_Disbursement'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.PAYUCBfiles'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPS_Recovered'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallet_Kadamba_TopUp_Requests_TSS_DELETED'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MedKYCFinalStep1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DVL_Merchant_Trxns'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TetmpUPI_PSP_Integration'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Rupay_Tokenization'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit_KYC_Data_Comparision'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RBI_Mail'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Merchant_Unique_Ref_Codes'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Sheet1$'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_BillAvenues_Biller_17072021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IFSCMASTER'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_FullKYC_Requests_del22062021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.NonPANdata'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Esrow_CorePortion_Deposits'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempTSSPDCLBillPay'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Rupay_GiftVouchers_EventsList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Razorpay_ReconFile'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.AccountClosure_Requests'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ElectricityBoardDetails_20180806'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallet_Platform_Type'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myPAYUFileList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_BillerAvenues_CategoryList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RBI_Monthly_Report_2018_07_2019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Rupay_RawData'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_UPI_MISData'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_Scholarship_Tracking_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallet_Registration_Type'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.PAYUfiles'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked_Unblocked'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PG_ElectricityBillDetails_MIS'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_KYCUpgradedData'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_Eagle_EYE'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ServiceProvides_BillAvenues_03012022'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FDMS_Email_Sent_Logs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DB_Maintenance_ActtivityLog'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Abhibus_ConcessionList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AEPS_Request_Response_Logs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.BBPS_CreditCard_MIS'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CCAvenuePendingOrderFilesprocessed'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.AccountDayClosingBalance11112016'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.BulkDisputesBlocking'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myPAYUConFileList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AEPS_Bank_IIN'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Temp_UPI_Trxns'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Bill_Avenues_PushStatusUpdates'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Issue_Gift_Instrument_BulkRequest_Maker'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Payment_Fraud_Reporting'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ESD_DayEnd_Statement_Del10052022'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_BillAvenues_Biller'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myFileListNEFT'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.PAYUConfiles'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_ESD_SLA_Level1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Blocked_AccountHolder_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Hotel_BookingCodes'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TryCatchWebExceptions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_VPA_Registration_History'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AccountClosure_Requests_9703346784'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempReversals'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Medium'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_VLE_TDS_Cumulative_Abstract_Report_Freezed'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ESD_DayEnd_Statement'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.InactiveExpiryWallets'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallet_Account_StatusTypes'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myFileListBa'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_Payments_04032023'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SmsStaak_RevesalOreder_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_Payments_20122022'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPS_Inward_Recovery'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Merchant_Groups_ORROld'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Abhibus_BookingCancelled_MIS'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_NullID'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBI_Data_Debit_TAG_Dump'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RBI_Monthly_Report_New'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RBI_Monthly_Report_2018_02_2021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.filesBa'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Ledger_Balance_Calculation_Functionalities'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.December2018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PAYU_DebitCardCharges_Reversal_01042017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Failure_Transaction_Monitoring_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallets_PaymentGateway_PartialRefundsRequests_PostSettlement'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TSOnline_MIS_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AutoReversalsRequests'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Account_Holder_DowngradedWallet_22122017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPSAbstract'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_BillAvenues_MIS_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TS_FPSHOP_DATA_07072019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MedKYCWorkbook_ExistingStatus'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SMS_Counts'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.KYCDetailsforGivenNumber'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Tempeelec'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IFSCList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IdentityTypes'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_NEFT_File'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_VijayaBank_AccountStatement1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_CKYC_Repository'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.PAYUConFilesprocessed'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Employee_Organizations_Expense_Management'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempUIDTokenUpdate'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ThirdPartyApp_Merchant_Payments'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_NullID_Removed'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SMSDaak_Pending_Cashback_Credit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DVL_Registration_Mobile'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Refund_Eseva'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Abhibus_PlacesList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBI_Datadump_TransactionData_11052023'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Blocking_Debits_Exceptions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Sample_bill_Images'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DVL_Registration_Email'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemIC3_Citizen_Service_IMPS_MIS_Recover'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ServiceProvides_BillAvenues_17052021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Account_Holder_CurrentAddress_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_NEFT_PendingCredits'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Device_Registrations'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CCAvenue_Transaction_Charges_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_GateWay_Utility_BillPayment'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021TransactionDetails_Final_KYCUpgraded_Prior'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallet_Upgradation_Requests'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IPAY_BBPS_Categories'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempTSSPDCL'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MeesevaCenters_17012019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Test_Comp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_NullID_40047'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Account_Holder_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TAWeb_Role_Resources_12Mar17'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_NEFTFiles_Processed'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Generic_OTP_Master'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TSNPDCLBillEnquiryResponse'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempComplaint'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IPAY_BBPS_BillerInfo_Old'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_Growth_Indicators_NewServices'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Customer_LoadMoney_Risk_Profile'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.WalletFullKYC_VCIP_HolidayList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.PrefundedMerchant_Transaction_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempRegInput'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBI_Datadump_CustomerData_11052023_Min_GT_10000'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SmsDaak_ReversalOrder_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemIC3_UPIMerchantTrxns_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_CPFIR_Info'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2023ransactionDetails'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TA_KYC_Agents_NZB'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.trans_47201472703332_310816'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Temp_Citizen_Service_TransactionStatus'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FDMS_Email_Received_Logs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallets_PaymentGateway_WalletLinking_Tracking'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ServiceProvides_BillAvenues_26102023'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IMPS_Holidays_List'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_EAMCET_MIS_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021TransactionDetails_Final_GT1L_686571_Selected'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.tempUnusedName'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3LanguageKeyWords_28052017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Issue_Gift_Instrument_BulkRequest_Rejected'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Mobile_MMID'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_TAWallet_KYC'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IMPS_Service_Wallet_Critical_Alert'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_Bulk_Registrations'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXNS_DistributorComission'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXNS_Debit_29022020_01032020'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021TransactionDetails_Final_GT1L_Backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Del_NucleusTrxns'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FDMS_Email_Sent_Logs_Backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ScholarShip_MobileMapping'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.VCIP_ACTIVE_USERS'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Promotions_Campaigns'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Temp_SaveCardDetails'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_TAWallet_MinKYC'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021TransactionDetails_Final_Rebuild_data'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IMPS_ChargesSettlement'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallets_PaymentGateway_Order_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Employee_Organizations_Expense_Management_Attachements'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_PageRedirection_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ThirdPartyApp_Merchant_Payments_Backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXNS_Credit_29022020_01032020'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Card_Details_30092022'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DVL_Session_Table'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempSPDCLERO'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked_TWallet_24102017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Merchant_Config_31072021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.LastMonthClosingBalance'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ACH_Unbloked_02042019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PayU_Computed_NetSettledAmount'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_31082021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallets_PaymentGatewayRequests_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempAccountClosing_IMPSTemp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Abhibus_Booking_MIS'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_CPFIR_NatureofFraud'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_CUSTOMER_NEFT_IMPS_CREDIT_REQUESTS_Rejected_old'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXNS_TDS_Deduction'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Agent_incentives_Feb_2018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_StudentScholarship_List'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RazorPay_PaymentGateway_TrxnDetails'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TWalletRegistrations'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_SMS_Log'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_BillAvenues_Biller_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SEMIC3_MERCHNATS_ENTRIES'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempBlocked'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Web_Sessions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_IDType2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SMSDaak_AccessTokenList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TWalletScholarshipPending'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBI_Datadump_CustomerData_11052023_Final'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MNRLList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TWalletLoadMoney'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IMPS_XML_Request_Response_Logs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Disputes_Orders_20170825'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Merchant_Groups'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Semic3_TransactionDetails'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABSTable10'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_FSS_BillerInfo'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempWalletStatement'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Customer_Notifications_Archived'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.VijayaBankStatement_Modificcations'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TSRTC_SPLHIRE'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Registration_Email'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.OctLogs2018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TWalletPayment'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.LeftKYC'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRxns_debit_wROG_cHGdEBIT'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIDataGT1LAKH20000'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Customer_Groups_Branches'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SMS_Registered_Templates'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Issue_Gift_Instrument_BulkRequest_UTR'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PaymentGateway_TrxnDetails'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_CustomerCare_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_KYCDowngradedData'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TWalletIMPS'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallet_BankCBS_TopUp_Requests'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_Nizamabad_PostMatric_Data_Result'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Downtime_Updates'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked_TWallet'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempCheckWallet'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Rupay_Summary_Excel'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RazorPay_MIS_Payouts_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_CPFIR_PaymentChannelUsed'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Recon_Dashboard_ABS1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPSExceptionLogs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SIM_Binding_Device_Tokens'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myFileListUPI'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit_KYC_Data_Comparision_KYC_MinKYC'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TASK_MIS_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FY20222023Top100Customers'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021TransactionDetails_Final_GT1L_LM_Instances'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IMPS_Verification'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FDMS_Email_Sent_Logs_NotSent'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TSTS'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TAPARTNER_REDIRECT_INPUT'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TWallet_DIGITHON_CashPrizes'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemIC3_Cashwithdrawal_Repost'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.tempgetexisistingdata'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempSCDD_Work3'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Del_Nucleus_JE'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked_TWallet_06092017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.filesUPI'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_OTP'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Device_Registrations_History'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_NullID_Unexpired'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.APGWS_Dashboard'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_QRPayment_QRCodes'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TA_Partner_Agency_Payments'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBI'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TWalletRegistraion_Telangana_AP'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPS_May2024_Data_Self'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempSCDD_Work4'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Track_Reversals_Timeline_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.PGName'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.APGWS_Credits_Debits'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FPShopCommissions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.PendingMeesevaReg'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Eseva_NewBankAccounts'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Account_holder_transactionlimits_Downgrade'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Temporary'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Employee_ProjectDetails'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.LowKYCforVCIP'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Account_Holder_Hash_Calculation'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.NEFTFilesprocessed'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.tempclosed'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.PurchaseofGoodsServicesatphysicalstores'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IPAYWebHook_Callback_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_BillAvenues_Biller_20062023'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IPay_Pending_CallBackProcessing'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_BillAvenues_Biller_Prepaid_22122022'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PayU_Success_NotCredited'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021TransactionDetails_Final_Abs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallets_PaymentGateway_PartialRefunds'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DummyLogs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked_TWallet_15052019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked_TWallet_27082017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MyTempIMPS_TCC_RET'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ulb_list'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Utility_Bill_Payments'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempAPSFL'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Rupay_Tokenization_History'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_Blocked_Users'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_WrongScholarship_Accounts'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TAConnect_Merchant'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_API_Testing_Response'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_Services_LiveDate'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_CPFIR_PaymentSystemCategory'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AADHAAR_HashData'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TA_Partner_Agency_Service_List'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Roles_Resources_16052020'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TSSPDCL_Statement'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_LoginFailedAttempts_from_Previous_SuccessfulLogin'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TMT_EntityWise_Balance_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempAbhibusData'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPS_Reconciliation_Records'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CCAvenue_ICICI_Disputes_14092017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TAConnect_Payerlist'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MerchantSettlement_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3LanguageKeyWords_IOS'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_Applications'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Account_Holder_TransactionLimits'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallets_PaymentGateway_WalletLinking'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_BillAvenues_MIS_Awaited'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FDMS_Email_Sent_Logs_MS1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.GatewayResponse'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPS_RRN'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Rupay_Consolidate_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CyberplatCsv'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FDMS_Email_Config'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TAConnect_Payerlist_BackUp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPS_Unrec_Tempp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Response_Message'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_UPI_TrxnDetails_Reinitiate_Credits'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPSChargesReverted'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.STDTempOrderID'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SMSDaakCSV'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TAConnect_PayerProfiles'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MyTempResponse_logs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.VB_TransactionDetails'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Telangana_15K_Digiton'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021TransactionDetails_Final_del'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempCash'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TWalletSMSLogsJun2024'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_TWallet'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TEstSPDCL'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Hotels_Flights_Reconciliation'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempSPDCLReqRES'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Rupay_Security_Questions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FDMS_Email_Sent_Logs_ProdWebService'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TAConnect_Payers_Category1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempUPIPSPInput'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemIC3_SMS_Channels'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TemptsnpdclReqRes'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.VB_TPIN'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myFileListsdTFolio'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TemUPIJIO2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AEPS_Services_Enabled_Agents'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPS_BankNodeOffline_Records'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXNS_BusTicket'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Employee_LeaveRequest'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBI_KYC_Upgrade'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_FreeIMPS_Availed'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempFraudPayuLog'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Escrow_MerchantRegisteredCount'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Entity_Transaction_Types'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TAConnect_Payers_Category2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TMT_EntityWise_WalletReg_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Account_Holder_Details_Downgrade'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ACH_Table_KYC_MinKYC_12092021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.APGWS_ABS_Level2_Debit_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Merchant_Cashback_Campaigns'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Echallan_MIS_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ServiceProvides_BillAvenues_12022021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.filessdTFolio'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SMSDaakPendingStatus'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TSRTC_MIS_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_ESD_SLA_Level2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Session_Table'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3CCAvenueOrders'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_Payments_Backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.AccountDayClosingBalance'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TAConnect_PaymentTypes'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PAYU_Failure_Reinitiate'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_CKYC_Detail_30'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TAWebResources'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_Nizamabad_PostMatric_Data'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021TransactionDetails_Final_GT1L'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Prefunded_Merchant_LowBalance_Alert'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Suspicious_Transactions_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SIM_Binding_Device_Tokens_History'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CCAvenueChargesSlab_Old'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MerchantDetailedSettlementReport_temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TAConnect_TrxnDetails'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.PayQwik_Session_Table'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TrxnTypesCharges'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MyTempRequest_Logs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_GramawardSachivalayam_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_CPFIR_PaymentSystemInvolved'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CardRequest'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TCC_AcceptedRecords'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ScholarshipTemp1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SMS_Channels_SenderID'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Telangana_15K_Digiton_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked_TWallet_12032018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXNS_MOBILE_RECHARGE_RECON'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_FoodCoupons_Employee_Organisations_Maker_Checker'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.UPI_Charges_Exercise'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_ESD_SLA_Level2_Live'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.APGWS_ABS_Level2_Debit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_VCIP_Slot_Info'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DB_Disk_Utilization'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_AgencyList_20022024'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ThirdPartyApp_Merchants'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FIU_ARFRPT'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TAWeb_Role_Resources_10Mar'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_NEFT_Rejected'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempFPSHopPayment'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myFileListRp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Customer_Data_Alter'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PAYU_Consolidated_SettlementFile_TA'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.U_Acc_Backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MyTemp210_Response_Logs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Table_1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Rupay_Card_Info'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Promotions_Campaigns_Backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_OperationsTeam_WorkingOn_Holidays'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_Payments_04042024'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_DMT_Customer_Enrolment'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3LanguageKeyWords_22082018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.filesRp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallet_BankCBS_PullFunds'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MyTemp200_Request_Logs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXNS_ElectricityBillDetails_APSPDCL_13022019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_Eagle_EYE_History_IMPS_25052021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_CPFIR_PaymentTransactionInstrument'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FreName'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Rupay_Card_Info_Permanent_Blocked'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_BillAvenues_MIS'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RazorPay_MIS_Transction_Details_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MyTemptemp2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Rupay_Card_Info_Backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DB_RAM_Usage'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SMS_Accounts'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempMerchantQRCOde'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.PendingMeesevaReg1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TWalletServicesList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IFSCMASTER_2020'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AEPS_Transaction_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABSTable11'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_InstantPay_BrowsePlan_CircleList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.tempDRCrGt10000'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.tempUnreg'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TAWallet_Agent_AreaManager_Mapping_backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AEPS_Groups_MainAccount_Settlement'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SMSDaak_ChargesReversal'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Send_AdhocSMS'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Chargeback_SatusUpdate'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked_TWallet_25042018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked_TWallet_30102017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RUPAY_Escrow_Reconcilied_Records'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Escrow_Debits'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPS_Service_Availability'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXNS_Debit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TADisputes_26072017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempSPDCLTempParame'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallets_PaymentGateway_WalletLinking_History'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_CKYC_FileFormat'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RazorPay_MIS_Transction_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TA_Partner_Agency_Payments31012023'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Customer_Data'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Account_holder_28062019_TA_AGENTS'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Merchant_Cashback_Campaigns_Rejected'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_CKYC_Header_10'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallet_Loging_Failed_Attempts'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_Eagle_EYE_History'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemIC3_Settled_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ThirdPartyApp_Merchant_Payments_Input'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Credit_Entries'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Issue_FoodCoupon_Instrument_Reload'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3LanguageKeyWords'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_CKYC_Detail_70'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Recovery_Process_20192412'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TAGDisputes_26072017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_Payments_17052023'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SWC_BulkPost_Response'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Transaction_limit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TSNPDCL_Department_Auth_Token'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempReversTracking'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TSPIES_Challan_details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Wallet_KYC_Status_Changes_Track'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.UPI_TPAP_Blocked_Devices_list'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TDS_Monthly_Statement'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_NullID_Bal'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_OtpMaster_dvl'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3LanguageSupport_10Mar'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_30082021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Sample'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myNEFTFileList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SMSDaak_AutomatedReversals'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3TANEFT'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Citizen_Service_Reports_Input'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.AADHAAR_REf'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CCAvenueChargesDebit'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_Eagle_EYE_History_12072024'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.PAN_Audit_10082018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_WalletFullKYC_VCIP'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ESD_ESCROW_PrefundDeposit_12122023'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Disputes_26072017_Original'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.NEFTfiles'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.NONPANDataRep'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.PAYUFilesprocessed'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TFolio_MIS_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXNS_JournalEntry'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXNS_Water_BillDetails'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ChargeBack_Automation_Process'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.NBIN_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Cyberplot_RevesalOreder_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myFileListES'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MedKYCWorkbook_Backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXN_Status_Table'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myESFileList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_CurrentUserActivity'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MedKYCWorkbook'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.tempWatertankerpayments'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AEPS_Transaction_Types'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MobileRechargeCallback'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempFPMerchPay'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CCAvenueChargesSlab'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.BankOfflineCode'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Update_MIS_Dates_Requests'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.filesES'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ServiceProvides_BillAvenues_25012024'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_Payments'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.JETest'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TAWebResources_10Mar'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.BillAvenuesBillers_26062023'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IMPS_DuplicateRRN_Check'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TWallet_Scholarship_Registration'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Sch'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ESfiles'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_FoodCoupons_Employee_Organisations_Attachments'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Response_Codes'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TAWeb_Role_Resources_TA'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Customer_Occupation'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.EscrowStatement_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_ServiceTypes'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Account_Holder_Closed_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SHG_AccountHolder_Mapping'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ESFiles_Processed'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TS_FPSHOP_DATA_Update_details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPS_Logs_Trxn_12092017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myAbhibusFileList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_CUSTOMER_NEFT_IMPS_CREDIT_REQUESTS_Old'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_CenterList23'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MyTempTryCatchWebExceptions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DRTest'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CCASUFilesprocessed'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ESD_DayEnd_Statement_Maker'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPS_NPCI_Reconcilation_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPS_Final_reconciledRecords'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_Weekly_Abstract'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Abhibusfiles'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IMPS_WhiteListedMobiles'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.NumberMall_Transaction_Details'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_UPITokenSystem'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Merchant_Cashback_Campaigns_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021TransactionDetails_Final_GT1L_96539_Selected'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RuPay_Web_Audit_log'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Temp_sp_CyberCell_Dispute'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3LanguageKeyWords_22062018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TAConnect_Category_22082018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_Eagle_EYE_History_May2024'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IMPS_ESD_VLE_Commissions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_Payments_Receipts'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_PDS_Consolidate_Commission_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempVCIP_Auth'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_ControlledReleasedMobiles'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_BulkRegistrations'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABSTable1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TestCommission'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_deployments'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABSTable13'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.APGWS_Dashboard_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Escrow_Liability'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AccountClosure_Requests_06062019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TemPBLEQRDETAILS'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABSTable2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.UnexpiredActive'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PAYU_Recon_File_Removed'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.APGWS_Credits_Debits_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MedKYCWorkbook_MediumKYC'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IFSCMASTER_Backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_YesBank_BBPS_MIS_Data'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_VLE_TDS_Cumulative_Abstract_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RBI_MonthlyStatement_2021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.AccountHoldernonPANFullKYC'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempRRN'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_WalletFullKYC_VCIP_del22062021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABSTable4'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.MediumKYCWorkBook_KYCActivity'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempAbhiBooking'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_VijayaBank_AccountStatement_04102019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SMSDaakTransactionTypes'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.tempLedgertableIP'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PushNotification_DeviceID'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempVCIp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_ESD_SLA_Level1_Live_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AgentConsent_Activity'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_NullID_40047_19738'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_BillAvenues_Biller_12102023'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABSTable5'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_Payments_31012019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_MNRL_Matched_Wallet_List_2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.sp_Semic3_Adding_MerchantAmount_to_NachSettlement_Test'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PG_Configuration'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.AADHAAR_TWalletLog'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.tempspdclpartner'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PAYU_Settlement_Dates_TA'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.tempRupayRep'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABSTable6'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FDMS_Email_Sent_Logs_MS2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_MerchantSettlement_10Aug2017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempEAStatement'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_YesBank_Biller'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Account_Holder_PayQwik_10012018_22102020'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Telangana_CityWise_TWalletCustomers'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_BillAvenues_BillerInfo'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IMPS_Merged_Banks'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.BusTicekts_ManualReversalFromSemiC3'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.NoPhoneCustomers'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IMPS_Benificiary_List'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_YesBank_MIS_Data'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TAConnect_Category'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Labour_Department_MIS_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABSTable7'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PAN_Update_Requests'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempBillAvenueStatusUpdate'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Account_Holder_Payqwik_28092021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IT_Circle_Info'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_RBI_Daily_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IMPS_Dropped_Requests'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABSTable8'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_CenterList_oss'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.POA_AADHAAR'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ReActivateRequest'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TA_KYC_Agents'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Scholarship_Khammam_19022020'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myFileListBDB'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABSTable9'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SFIO_Mobilenumbers'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_Promotional_Incentives'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DBWaitsCollections'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Recovery_Process_9182968456'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.AADHAARRegistrationDetails'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PreGeneratedAccountNumbers'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Merchant_Cashback_Campaigns_Transactions'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.AADHAAR_Merge'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempStatDispute'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Service_CenterList_19072017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TestingAPEPDCL'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABSTable12'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.filesbdb'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempInput'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_UPI_ExcemptedMobiles'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PAYU_ChargesBack_Report'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.BDB_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_FoodCoupons_Employee_Organisations'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Balance_Maintaince'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Account_Holder_Hash_Verification'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.AccountClousre_DailyEntityUpdation'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempLogs'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myFileListsd'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TRXNS_ExternalSystems'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Pending_which_are_to_be_Reversed'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Merchant_Trxns'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PREFUNDED_MERCHANT_NEFT'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.PSPName'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.VBNEFTFiles'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Web_Entries'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_VijayaBank_AccountStatement_11122019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IMPS_Bank_Master'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.filessd'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Bill_Avenues_Payments_Jan_Feb2024'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Adds_List'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_FPSHOP_Dealers_Commission'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_BLEQRDetails'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TA_Partner_Agency_List'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AdhocCenters_MerchantPayment'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SMSDaak_NewFormat'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBI_Datadump_CustomerData_11052023'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Citizen_Services_BTNumbers'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Rupay_Tokenization_Old'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myFileListcp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Account_Holder_Details_PO_12_Backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Task'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TAPPFoilioRegActiveUsersFeb2023'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.AADHAAR_Reference_Mapper'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SMSDaakCSV_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Response_Message_old1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FIU_TRFRPT'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_TWallet_REG'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3LanguageKeyWords_IOS_TA'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ServiceProvides_BillAvenues_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ServiceProvides_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myFileListIRCTC'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DisputeOrderID'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ExternalSystems'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FIU_TRFBRC'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Account_Holder_TAGITI30082021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_TWallet_REG1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TSNPDCL_July_Jagithyala'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Rupay_exp_Cards'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TrxnTypesCharges_20180608'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.filescp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_UNSC_List'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CCAvenue_23082017'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_Eagle_EYE_History_10052021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempAPSFL05112019'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.IncCenters'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.DigithonDistrictMaster'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Suspect_Accounts_blocked_TWallet_02082018'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.noti'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_AADHAAR_KYC_Customers'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.filesIRCTC'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempFraudRisk'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_YesBank_Biller_backup'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FIU_TRFTRN'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Cashout_TransactionReports_Level1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.ABS_TWallet_LoadMoney'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Hmwssb_old_Merchant_Config'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_UNSCList_Matched_List'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TEMPIMPS_Bank_Master'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Change_Mobilenumber'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_OtpMaster'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TADeposits_TrxnDetails'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.TempBalAPI'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_ServiceProvides_BillAvenues_29012021'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_MerchantSettlement'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Merchant_Inactive_Info'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.CCAvenue_Credit_Details_RetryJob'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_IRCTC_Refunds_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FIU_TRFPIN'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_TWallet_SMS_Log_Temp'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Cashout_TransactionReports_Level2'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Unregistered_FundTransfers1'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Merchant_Cashback_Campaigns_Transactions_Declined'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.RBIAudit2021CustomerData_NullID_Unexpired_Total'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SHG_DETAILS'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.myFileList'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.FIU_TRFINP'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Cashout_TransactionReports_Level3'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Recovery_Process'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PAYU_ChargesBack_Report_TA'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Bulk_Merchant_Registration'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_India_PincodeMaster'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Cooperative_Societies_Bank'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.Account_Holder_Details_TAG'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_PAYU_InstantPay_Reinitiate'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_Manual_FullKYC_Requests'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.SemiC3_SHG_DistrictMaster'. Please see the warning messages.
//        // Unable to generate entity type for table 'dbo.files'. Please see the warning messages.

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=10.1.1.4;Initial Catalog=Semi_C3_Standardized;User Id=tapreprod;Password=$t@ging@TA");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<AadhaarCustomers>(entity =>
//            {
//                entity.HasKey(e => e.AadhaarCustomerId);

//                entity.ToTable("Aadhaar_Customers");

//                entity.Property(e => e.AadhaarCustomerId).HasColumnName("Aadhaar_Customer_ID");

//                entity.Property(e => e.AadhaarNumber)
//                    .IsRequired()
//                    .HasColumnName("Aadhaar_Number")
//                    .HasMaxLength(12)
//                    .IsUnicode(false);

//                entity.Property(e => e.AadhaarVerificationDate)
//                    .HasColumnName("Aadhaar_Verification_Date")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.AkuaCustomerId).HasColumnName("AKUA_Customer_ID");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnName("Created_Date")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.EmailAddress)
//                    .HasColumnName("Email_Address")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.EntityId).HasColumnName("EntityID");

//                entity.Property(e => e.MobileNumber)
//                    .HasColumnName("Mobile_Number")
//                    .HasMaxLength(12)
//                    .IsUnicode(false);

//                entity.Property(e => e.ReferenceNumber)
//                    .IsRequired()
//                    .HasColumnName("Reference_Number")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<AccMerchant>(entity =>
//            {
//                entity.ToTable("Acc_Merchant");

//                entity.Property(e => e.AccMerchantId).HasColumnName("Acc_Merchant_ID");

//                entity.Property(e => e.AccMerchantBalance).HasColumnName("Acc_Merchant_Balance");

//                entity.Property(e => e.AccMerchantBankName).HasColumnName("Acc_Merchant_Bank_Name");

//                entity.Property(e => e.AccMerchantBranchName)
//                    .HasColumnName("Acc_Merchant_Branch_Name")
//                    .HasMaxLength(50);

//                entity.Property(e => e.AccMerchantCreatedBy).HasColumnName("Acc_Merchant_Created_By");

//                entity.Property(e => e.AccMerchantCreatedOn)
//                    .HasColumnName("Acc_Merchant_Created_on")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.AccMerchantEditedBy).HasColumnName("Acc_Merchant_Edited_By");

//                entity.Property(e => e.AccMerchantEditedOn)
//                    .HasColumnName("Acc_Merchant_Edited_on")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.AccMerchantIfscCode)
//                    .HasColumnName("Acc_Merchant_IFSC_Code")
//                    .HasMaxLength(50);

//                entity.Property(e => e.AccMerchantIsEnabled).HasColumnName("Acc_Merchant_Is_Enabled");

//                entity.Property(e => e.AccMerchantIsOffusEnabled).HasColumnName("Acc_Merchant_Is_Offus_Enabled");

//                entity.Property(e => e.AccMerchantMobileNumber)
//                    .HasColumnName("Acc_Merchant_Mobile_Number")
//                    .HasMaxLength(15);

//                entity.Property(e => e.AccMerchantName)
//                    .IsRequired()
//                    .HasColumnName("Acc_Merchant_Name")
//                    .HasMaxLength(100);

//                entity.Property(e => e.AccMerchantNumber)
//                    .IsRequired()
//                    .HasColumnName("Acc_Merchant_Number")
//                    .HasMaxLength(20);

//                entity.Property(e => e.AccMerchantPin)
//                    .HasColumnName("Acc_Merchant_Pin")
//                    .HasMaxLength(50);

//                entity.Property(e => e.FkAccMerchantEntityId).HasColumnName("FK_Acc_Merchant_Entity_ID");
//            });

//            modelBuilder.Entity<AccountHolder>(entity =>
//            {
//                entity.ToTable("Account_Holder");

//                entity.HasIndex(e => e.Aadhaar)
//                    .HasName("NonClusteredIndex-20180314-122613");

//                entity.HasIndex(e => e.AccountHolderMobileNo)
//                    .HasName("NonClusteredIndex-20170805-155940");

//                entity.HasIndex(e => e.FkAccountHolderEntityId)
//                    .HasName("NonClusteredIndex-20170601-184021");

//                entity.HasIndex(e => e.PlatForm)
//                    .HasName("NonClusteredColumnStoreIndex-20170601-180710");

//                entity.HasIndex(e => new { e.FkAccountHolderEntityId, e.CreatedDate })
//                    .HasName("IX_Account_Holder_Created_Date");

//                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderMobileNo, e.FkAccountHolderEntityId })
//                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID");

//                entity.HasIndex(e => new { e.AccountHolderId, e.FkAccountHolderEntityId, e.AccountHolderMobileNo })
//                    .HasName("IX_Account_Holder_Account_Holder_MobileNo4");

//                entity.HasIndex(e => new { e.AccountHolderId, e.FkAccountHolderEntityId, e.WalletTypeId })
//                    .HasName("IX_Account_Holder_FK_Acct_Holder_Entity_ID_WalletTypeID");

//                entity.HasIndex(e => new { e.AccountHolderMobileNo, e.FkAccountHolderEntityId, e.Uidtoken })
//                    .HasName("IX_Account_Holder_UIDToken");

//                entity.HasIndex(e => new { e.FkAccountHolderEntityId, e.CustOf, e.AccountHolderMobileNo })
//                    .HasName("IX_Account_Holder_Account_Holder_MobileNo32");

//                entity.HasIndex(e => new { e.IsKycDone, e.CreatedDate, e.FkAccountHolderEntityId })
//                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID9");

//                entity.HasIndex(e => new { e.IsKycDone, e.FkAccountHolderStatusTypeId, e.AccountHolderMobileNo })
//                    .HasName("IX_Account_Holder_Account_Holder_MobileNo31");

//                entity.HasIndex(e => new { e.WalletTypeId, e.FkAccountHolderEntityId, e.CreatedDate })
//                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID_Created_Date3");

//                entity.HasIndex(e => new { e.AccountHolderFullName, e.AccountHolderMobileNo, e.WalletTypeId, e.IsDistributor })
//                    .HasName("IX_Account_Holder_WalletTypeID_Is_Distributor");

//                entity.HasIndex(e => new { e.AccountHolderId, e.Aadhaar, e.TempAadhaar, e.FkAccountHolderEntityId })
//                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID5");

//                entity.HasIndex(e => new { e.AccountHolderMobileNo, e.FkAccountHolderEntityId, e.Aadhaar, e.Uidtoken })
//                    .HasName("IX_Account_Holder_UIDToken2");

//                entity.HasIndex(e => new { e.AccountHolderMobileNo, e.WalletTypeId, e.FkAccountHolderEntityId, e.CreatedDate })
//                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID_Created_Date");

//                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderFullName, e.AccountHolderMobileNo, e.WalletTypeId, e.FkAccountHolderEntityId })
//                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID_20190202");

//                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderMobileNo, e.Aadhaar, e.Uidtoken, e.FkAccountHolderEntityId })
//                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID1");

//                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderMobileNo, e.AccountHolderPwdEncrypt, e.Salt, e.FkAccountHolderEntityId })
//                    .HasName("IX_Account_Holder_FK_Account_lder_Entity_ID7");

//                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderMobileNo, e.LoginEnable, e.Salt, e.FkAccountHolderEntityId })
//                    .HasName("IX_Account_Holder_FK_Account_Hr_Entity_ID");

//                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderFullName, e.AccountHolderMobileNo, e.FkAccountHolderStatusTypeId, e.WalletTypeId, e.FkAccountHolderEntityId })
//                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID10");

//                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderFullName, e.FkAccountHolderEntityId, e.IsKycDone, e.WalletTypeId, e.AccountHolderMobileNo })
//                    .HasName("IX_Account_Holder_Account_Holder_MobileNo");

//                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderMobileNo, e.IsKycDone, e.WalletTypeId, e.CustOf, e.IsUsageCapEnabled, e.FkAccountHolderEntityId })
//                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID90");

//                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderRegnNo, e.AccountHolderFullName, e.AccountHolderMobileNo, e.IsKycDone, e.FkAccountHolderStatusTypeId, e.FkAccountHolderEntityId })
//                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID8");

//                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderFullName, e.AccountHolderMobileNo, e.IsKycDone, e.FkAccountHolderStatusTypeId, e.LoginEnable, e.Aadhaar, e.FkAccountHolderEntityId })
//                    .HasName("IX_Account_Entity_ID25");

//                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderMobileNo, e.IsKycDone, e.WalletTypeId, e.CustOf, e.Tpin, e.IsTpinenabled, e.FkAccountHolderEntityId })
//                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID_TPINKYC");

//                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderMobileNo, e.IsKycDone, e.WalletTypeId, e.IsUsageCapEnabled, e.DailyUsageCapCount, e.DailyUsageCapAmount, e.FkAccountHolderEntityId })
//                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID44");

//                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderMobileNo, e.IsKycDone, e.WalletTypeId, e.Mmid, e.CustOf, e.Tpin, e.IsTpinenabled, e.FkAccountHolderEntityId })
//                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID89");

//                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderFullName, e.AccountHolderMobileNo, e.IsKycDone, e.WalletTypeId, e.CustOf, e.IsUsageCapEnabled, e.DailyUsageCapCount, e.DailyUsageCapAmount, e.FkAccountHolderEntityId })
//                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID2");

//                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderFullName, e.AccountHolderMobileNo, e.IsKycDone, e.WalletTypeId, e.Mmid, e.CustOf, e.Tpin, e.IsTpinenabled, e.FkAccountHolderEntityId })
//                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID88");

//                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderFullName, e.AccountHolderPhoneNo, e.AccountHolderMobileNo, e.FkAccountHolderEntityId, e.IsKycDone, e.FkAccountHolderStatusTypeId, e.WalletTypeId, e.CustOf, e.Mmid })
//                    .HasName("IX_Account_Holder_MMID");

//                entity.Property(e => e.AccountHolderId).HasColumnName("Account_Holder_ID");

//                entity.Property(e => e.Aadhaar)
//                    .HasColumnName("AADHAAR")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Aadhaarhash).HasColumnName("AADHAARHASH");

//                entity.Property(e => e.AccountHolderAddress)
//                    .IsRequired()
//                    .HasColumnName("Account_Holder_Address")
//                    .HasMaxLength(255);

//                entity.Property(e => e.AccountHolderCourseFeeAmount)
//                    .HasColumnName("Account_Holder_CourseFee_Amount")
//                    .HasDefaultValueSql("((0))");

//                entity.Property(e => e.AccountHolderDob)
//                    .HasColumnName("Account_Holder_DOB")
//                    .HasMaxLength(30);

//                entity.Property(e => e.AccountHolderDurationFrom)
//                    .HasColumnName("Account_Holder_DurationFrom")
//                    .HasColumnType("date");

//                entity.Property(e => e.AccountHolderDurationTill)
//                    .HasColumnName("Account_Holder_DurationTill")
//                    .HasColumnType("date");

//                entity.Property(e => e.AccountHolderEmail)
//                    .HasColumnName("Account_Holder_Email")
//                    .HasMaxLength(100);

//                entity.Property(e => e.AccountHolderFullName)
//                    .IsRequired()
//                    .HasColumnName("Account_Holder_FullName")
//                    .HasMaxLength(100);

//                entity.Property(e => e.AccountHolderMobileNo)
//                    .HasColumnName("Account_Holder_MobileNo")
//                    .HasMaxLength(12)
//                    .IsUnicode(false);

//                entity.Property(e => e.AccountHolderMobileServiceProvider).HasColumnName("Account_Holder_Mobile_Service_Provider");

//                entity.Property(e => e.AccountHolderNameOnCard)
//                    .IsRequired()
//                    .HasColumnName("Account_Holder_NameOnCard")
//                    .HasMaxLength(100);

//                entity.Property(e => e.AccountHolderPan)
//                    .HasColumnName("Account_Holder_PAN")
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.AccountHolderPhoneNo).HasColumnName("Account_Holder_PhoneNo");

//                entity.Property(e => e.AccountHolderPhoto)
//                    .HasColumnName("Account_Holder_Photo")
//                    .HasColumnType("image");

//                entity.Property(e => e.AccountHolderPhotoName)
//                    .HasColumnName("Account_Holder_Photo_Name")
//                    .HasMaxLength(50);

//                entity.Property(e => e.AccountHolderPin)
//                    .HasColumnName("Account_Holder_PIN")
//                    .HasMaxLength(50);

//                entity.Property(e => e.AccountHolderPinIsReset).HasColumnName("Account_Holder_PIN_Is_Reset");

//                entity.Property(e => e.AccountHolderPwdEncrypt)
//                    .HasColumnName("Account_Holder_Pwd_encrypt")
//                    .HasColumnType("varbinary(max)");

//                entity.Property(e => e.AccountHolderRegnNo)
//                    .IsRequired()
//                    .HasColumnName("Account_Holder_RegnNo")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.AccountHolderSignature)
//                    .HasColumnName("Account_Holder_Signature")
//                    .HasColumnType("image");

//                entity.Property(e => e.AccountHolderSignatureName)
//                    .HasColumnName("Account_Holder_Signature_Name")
//                    .HasMaxLength(50);

//                entity.Property(e => e.ActualDob)
//                    .HasColumnName("ActualDOB")
//                    .HasColumnType("date");

//                entity.Property(e => e.AndroidVersionCode)
//                    .HasMaxLength(29)
//                    .IsUnicode(false);

//                entity.Property(e => e.AndroidVersionName)
//                    .HasMaxLength(29)
//                    .IsUnicode(false);

//                entity.Property(e => e.BankCbsAccountNumber)
//                    .HasColumnName("BankCBS_AccountNumber")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.BankCbsAccountType)
//                    .HasColumnName("BankCBS_AccountType")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.BankCbsCustomerId)
//                    .HasColumnName("BankCBS_CustomerID")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.BankCbsIfsc)
//                    .HasColumnName("BankCBS_IFSC")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.BlockChainId)
//                    .HasColumnName("BlockChainID")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.CitizenServiceCenterId)
//                    .HasColumnName("CitizenServiceCenterID")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnName("Created_Date")
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.CurrAddCountry)
//                    .HasMaxLength(2999)
//                    .IsUnicode(false);

//                entity.Property(e => e.CurrAddDistrict)
//                    .HasMaxLength(2999)
//                    .IsUnicode(false);

//                entity.Property(e => e.CurrAddDoorNo)
//                    .HasMaxLength(2999)
//                    .IsUnicode(false);

//                entity.Property(e => e.CurrAddIsApproved).HasDefaultValueSql("((0))");

//                entity.Property(e => e.CurrAddLandmark)
//                    .HasMaxLength(2999)
//                    .IsUnicode(false);

//                entity.Property(e => e.CurrAddLocality)
//                    .HasMaxLength(2999)
//                    .IsUnicode(false);

//                entity.Property(e => e.CurrAddPincode)
//                    .HasMaxLength(2999)
//                    .IsUnicode(false);

//                entity.Property(e => e.CurrAddState)
//                    .HasMaxLength(2999)
//                    .IsUnicode(false);

//                entity.Property(e => e.CurrAddStreet)
//                    .HasMaxLength(2999)
//                    .IsUnicode(false);

//                entity.Property(e => e.CurrAddVtc)
//                    .HasColumnName("CurrAddVTC")
//                    .HasMaxLength(2999)
//                    .IsUnicode(false);

//                entity.Property(e => e.DigithonDigitalTeacher)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

//                entity.Property(e => e.FkAccountHolderBloodGroupTypeId).HasColumnName("FK_Account_Holder_BloodGroupType_ID");

//                entity.Property(e => e.FkAccountHolderCourseId).HasColumnName("FK_Account_Holder_Course_ID");

//                entity.Property(e => e.FkAccountHolderCreatedBy).HasColumnName("FK_Account_Holder_CreatedBy");

//                entity.Property(e => e.FkAccountHolderEntityId).HasColumnName("FK_Account_Holder_Entity_ID");

//                entity.Property(e => e.FkAccountHolderHostelId).HasColumnName("FK_Account_Holder_Hostel_ID");

//                entity.Property(e => e.FkAccountHolderStatusTypeId).HasColumnName("FK_Account_Holder_StatusType_ID");

//                entity.Property(e => e.GroupId).HasColumnName("GroupID");

//                entity.Property(e => e.IosversionCode)
//                    .HasColumnName("IOSVersionCode")
//                    .HasMaxLength(29)
//                    .IsUnicode(false);

//                entity.Property(e => e.IosversionName)
//                    .HasColumnName("IOSVersionName")
//                    .HasMaxLength(29)
//                    .IsUnicode(false);

//                entity.Property(e => e.IsDistributor)
//                    .HasColumnName("Is_Distributor")
//                    .HasDefaultValueSql("('False')");

//                entity.Property(e => e.IsInAppOtpenable).HasColumnName("IsInAppOTPEnable");

//                entity.Property(e => e.IsKycDone)
//                    .HasColumnName("Is_KYC_Done")
//                    .HasDefaultValueSql("((0))");

//                entity.Property(e => e.IsSmallScaleMerchant).HasColumnName("is_SmallScaleMerchant");

//                entity.Property(e => e.IsStatusChecked).HasColumnName("IS_StatusChecked");

//                entity.Property(e => e.IsTpinenabled).HasColumnName("IsTPINEnabled");

//                entity.Property(e => e.IsUsageCapEnabled)
//                    .HasColumnName("isUsageCapEnabled")
//                    .HasDefaultValueSql("('False')");

//                entity.Property(e => e.LastCreditAmount).HasColumnType("decimal(30, 2)");

//                entity.Property(e => e.LastCreditOn).HasColumnType("datetime");

//                entity.Property(e => e.LastDebitAmount).HasColumnType("decimal(30, 2)");

//                entity.Property(e => e.LastDebitOn).HasColumnType("datetime");

//                entity.Property(e => e.LastPasswordSetOn).HasColumnType("datetime");

//                entity.Property(e => e.LoginEnable).HasDefaultValueSql("('True')");

//                entity.Property(e => e.Mmid)
//                    .HasColumnName("MMID")
//                    .HasMaxLength(7)
//                    .IsUnicode(false);

//                entity.Property(e => e.OrderId)
//                    .HasColumnName("OrderID")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Pan)
//                    .HasColumnName("PAN")
//                    .HasMaxLength(15)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poa)
//                    .HasColumnName("POA")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poaco)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poadist)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poahouse)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poalm)
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poaloc)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poapc)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poapo)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poastate)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poastreet)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poasubdist)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poatype)
//                    .HasColumnName("POAType")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poaverified)
//                    .HasColumnName("POAVerified")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poavtc)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.PoavtcCode)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poi)
//                    .HasColumnName("POI")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poidob)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poiemail)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poigender)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poiname)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poiphone)
//                    .HasMaxLength(15)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poitype)
//                    .HasColumnName("POIType")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poiverified)
//                    .HasColumnName("POIVerified")
//                    .HasMaxLength(29)
//                    .IsUnicode(false);

//                entity.Property(e => e.RegisteredbyMobile)
//                    .HasMaxLength(12)
//                    .IsUnicode(false);

//                entity.Property(e => e.RegistrationTypeId).HasColumnName("RegistrationTypeID");

//                entity.Property(e => e.RiskStatus)
//                    .HasMaxLength(299)
//                    .IsUnicode(false)
//                    .HasDefaultValueSql("('Low Risk')");

//                entity.Property(e => e.SecurityAnswer)
//                    .HasMaxLength(2999)
//                    .IsUnicode(false);

//                entity.Property(e => e.SecurityQuestion)
//                    .HasMaxLength(2999)
//                    .IsUnicode(false);

//                entity.Property(e => e.ShowOfferDesc).HasDefaultValueSql("((1))");

//                entity.Property(e => e.SmsSenderid)
//                    .HasColumnName("SMS_SENDERID")
//                    .HasMaxLength(12)
//                    .IsUnicode(false);

//                entity.Property(e => e.TempAadhaar)
//                    .HasColumnName("TempAADHAAR")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tpin)
//                    .HasColumnName("TPIN")
//                    .HasMaxLength(6)
//                    .IsUnicode(false);

//                entity.Property(e => e.TpinEncrypt).HasColumnName("TPIN_Encrypt");

//                entity.Property(e => e.Uidtoken)
//                    .HasColumnName("UIDToken")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

//                entity.Property(e => e.UpideviceId)
//                    .HasColumnName("UPIDeviceID")
//                    .HasMaxLength(2999)
//                    .IsUnicode(false);

//                entity.Property(e => e.Upivpa)
//                    .HasColumnName("UPIVPA")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.WalletTypeId)
//                    .HasColumnName("WalletTypeID")
//                    .HasDefaultValueSql("('0')");

//                entity.Property(e => e.WalletUpgradationDate).HasColumnType("datetime");

//                entity.HasOne(d => d.FkAccountHolderEntity)
//                    .WithMany(p => p.AccountHolder)
//                    .HasForeignKey(d => d.FkAccountHolderEntityId)
//                    .HasConstraintName("FK_Ach_EntityID");
//            });

//            modelBuilder.Entity<AccountHolderLedgerAccount>(entity =>
//            {
//                entity.HasKey(e => e.AchLedgerAccountId);

//                entity.ToTable("Account_Holder_Ledger_Account");

//                entity.HasIndex(e => new { e.AchLedgerAccountGeneral, e.FkAchLedgerAccountHolderId })
//                    .HasName("AccountID");

//                entity.HasIndex(e => new { e.FkAchLedgerAccountHolderId, e.AchLedgerAccountNo })
//                    .HasName("IX_Account_Holder_Ledger_Account_ACH_Ledger_Account_No");

//                entity.Property(e => e.AchLedgerAccountId).HasColumnName("ACH_Ledger_Account_ID");

//                entity.Property(e => e.AchLedgerAccountCard)
//                    .HasColumnName("ACH_Ledger_Account_Card")
//                    .HasColumnType("decimal(10, 2)")
//                    .HasDefaultValueSql("((0.00))");

//                entity.Property(e => e.AchLedgerAccountCash)
//                    .HasColumnName("ACH_Ledger_Account_Cash")
//                    .HasColumnType("decimal(10, 2)")
//                    .HasDefaultValueSql("((0.00))");

//                entity.Property(e => e.AchLedgerAccountGeneral)
//                    .HasColumnName("ACH_Ledger_Account_General")
//                    .HasColumnType("decimal(10, 2)")
//                    .HasDefaultValueSql("((0.00))");

//                entity.Property(e => e.AchLedgerAccountName)
//                    .HasColumnName("ACH_Ledger_Account_Name")
//                    .HasMaxLength(100);

//                entity.Property(e => e.AchLedgerAccountNo)
//                    .HasColumnName("ACH_Ledger_Account_No")
//                    .HasMaxLength(20);

//                entity.Property(e => e.AchLedgerAccountReward)
//                    .HasColumnName("ACH_Ledger_Account_Reward")
//                    .HasColumnType("decimal(10, 2)")
//                    .HasDefaultValueSql("((0.00))");

//                entity.Property(e => e.AchLedgerAccountSpecial)
//                    .HasColumnName("ACH_Ledger_Account_Special")
//                    .HasColumnType("decimal(10, 2)")
//                    .HasDefaultValueSql("((0.00))");

//                entity.Property(e => e.FkAchLedgerAccountHolderId).HasColumnName("FK_ACH_Ledger_Account_Holder_ID");

//                entity.HasOne(d => d.FkAchLedgerAccountHolder)
//                    .WithMany(p => p.AccountHolderLedgerAccount)
//                    .HasForeignKey(d => d.FkAchLedgerAccountHolderId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Account_Holder_Ledger_Account_Account_Holder1");
//            });

//            modelBuilder.Entity<AccountHolderStatusType>(entity =>
//            {
//                entity.HasKey(e => e.StatusTypeId);

//                entity.ToTable("Account_Holder_StatusType");

//                entity.Property(e => e.StatusTypeId).HasColumnName("StatusType_ID");

//                entity.Property(e => e.StatusTypeDescription)
//                    .IsRequired()
//                    .HasColumnName("StatusType_Description")
//                    .HasMaxLength(50);
//            });

//            modelBuilder.Entity<AccWallet>(entity =>
//            {
//                entity.ToTable("Acc_Wallet");

//                entity.HasIndex(e => e.AccWalletName)
//                    .HasName("UniqueWalletName")
//                    .IsUnique();

//                entity.Property(e => e.AccWalletId).HasColumnName("Acc_Wallet_ID");

//                entity.Property(e => e.AccWalletBalance).HasColumnName("Acc_Wallet_Balance");

//                entity.Property(e => e.AccWalletCardBlockNo).HasColumnName("Acc_Wallet_Card_Block_No");

//                entity.Property(e => e.AccWalletCreatedBy).HasColumnName("Acc_Wallet_Created_By");

//                entity.Property(e => e.AccWalletCreatedOn)
//                    .HasColumnName("Acc_Wallet_Created_on")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.AccWalletEditedBy).HasColumnName("Acc_Wallet_Edited_By");

//                entity.Property(e => e.AccWalletEditedOn)
//                    .HasColumnName("Acc_Wallet_Edited_on")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.AccWalletIsEnabled).HasColumnName("Acc_Wallet_Is_Enabled");

//                entity.Property(e => e.AccWalletIsOffusEnabled).HasColumnName("Acc_Wallet_Is_Offus_Enabled");

//                entity.Property(e => e.AccWalletName)
//                    .IsRequired()
//                    .HasColumnName("Acc_Wallet_Name")
//                    .HasMaxLength(100);

//                entity.Property(e => e.AccWalletNumber)
//                    .IsRequired()
//                    .HasColumnName("Acc_Wallet_Number")
//                    .HasMaxLength(20);
//            });

//            modelBuilder.Entity<AuditUsers>(entity =>
//            {
//                entity.HasKey(e => e.AuditId);

//                entity.ToTable("Audit_Users");

//                entity.HasIndex(e => new { e.AuditDateTime, e.AuditMessage, e.FkAuditUserId })
//                    .HasName("IX_Audit_Users_FK_Audit_User_ID");

//                entity.Property(e => e.AuditId).HasColumnName("Audit_ID");

//                entity.Property(e => e.AuditDateTime)
//                    .HasColumnName("Audit_DateTime")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.AuditException).HasColumnName("Audit_Exception");

//                entity.Property(e => e.AuditMessage)
//                    .IsRequired()
//                    .HasColumnName("Audit_Message")
//                    .HasColumnType("nvarchar(max)");

//                entity.Property(e => e.FkAuditUserId).HasColumnName("FK_Audit_User_ID");
//            });

//            modelBuilder.Entity<BasicMobileTransaction>(entity =>
//            {
//                entity.HasKey(e => e.TxnId);

//                entity.ToTable("Basic_Mobile_Transaction");

//                entity.Property(e => e.TxnId)
//                    .HasColumnName("Txn_Id")
//                    .ValueGeneratedNever();

//                entity.Property(e => e.FkBrmMobileNum)
//                    .IsRequired()
//                    .HasColumnName("FK_BRM_Mobile_num")
//                    .HasMaxLength(15);

//                entity.Property(e => e.TxnAmount).HasColumnName("Txn_Amount");

//                entity.Property(e => e.TxnDate)
//                    .HasColumnName("Txn_Date")
//                    .HasColumnType("datetime");

//                entity.HasOne(d => d.FkBrmMobileNumNavigation)
//                    .WithMany(p => p.BasicMobileTransaction)
//                    .HasForeignKey(d => d.FkBrmMobileNum)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Mobile_Transaction_Basic_Registration_Mobile");
//            });

//            modelBuilder.Entity<BasicRegistrationMobile>(entity =>
//            {
//                entity.HasKey(e => e.BrmMobileNum);

//                entity.ToTable("Basic_Registration_Mobile");

//                entity.Property(e => e.BrmMobileNum)
//                    .HasColumnName("BRM_Mobile_num")
//                    .HasMaxLength(15)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.BrmAddress)
//                    .IsRequired()
//                    .HasColumnName("BRM_Address")
//                    .HasMaxLength(200);

//                entity.Property(e => e.BrmBalance).HasColumnName("BRM_Balance");

//                entity.Property(e => e.BrmCustomerName)
//                    .HasColumnName("BRM_CustomerName")
//                    .HasMaxLength(50);

//                entity.Property(e => e.BrmDate)
//                    .HasColumnName("BRM_Date")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.BrmGender)
//                    .IsRequired()
//                    .HasColumnName("BRM_Gender")
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.BrmLastLoginDate)
//                    .HasColumnName("BRM_Last_Login_Date")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.BrmMachineId)
//                    .IsRequired()
//                    .HasColumnName("BRM_Machine_Id")
//                    .HasMaxLength(100);

//                entity.Property(e => e.BrmMobileOtp)
//                    .HasColumnName("BRM_Mobile_OTP")
//                    .HasMaxLength(15);

//                entity.Property(e => e.BrmPassword)
//                    .IsRequired()
//                    .HasColumnName("BRM_Password")
//                    .HasMaxLength(50);

//                entity.Property(e => e.BrmPhoto)
//                    .HasColumnName("BRM_Photo")
//                    .HasColumnType("image");
//            });

//            modelBuilder.Entity<BasicRegistrationMobileEmail>(entity =>
//            {
//                entity.HasKey(e => e.BrmEmailId);

//                entity.ToTable("Basic_Registration_mobile_Email");

//                entity.Property(e => e.BrmEmailId)
//                    .HasColumnName("BRM_Email_Id")
//                    .HasMaxLength(100)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.BrmEmailOtp)
//                    .HasColumnName("BRM_Email_OTP")
//                    .HasMaxLength(15);

//                entity.Property(e => e.BrmReqReceivingTime)
//                    .HasColumnName("BRM_Req_receiving_time")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.FkBrmMobileNum)
//                    .IsRequired()
//                    .HasColumnName("FK_BRM_Mobile_num")
//                    .HasMaxLength(15);

//                entity.Property(e => e.IsEmailActive).HasColumnName("IsEmail_Active");

//                entity.HasOne(d => d.FkBrmMobileNumNavigation)
//                    .WithMany(p => p.BasicRegistrationMobileEmail)
//                    .HasForeignKey(d => d.FkBrmMobileNum)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Basic_Registration_mobile_Email_Basic_Registration_Mobile");
//            });

//            modelBuilder.Entity<BlockedCard>(entity =>
//            {
//                entity.Property(e => e.BlockedCardId).HasColumnName("BlockedCard_ID");

//                entity.Property(e => e.BlockedCardBlockedDate)
//                    .HasColumnName("BlockedCard_BlockedDate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.BlockedCardUnBlockedDate)
//                    .HasColumnName("BlockedCard_UnBlockedDate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.FkBlockedCardBlockedBy).HasColumnName("fk_BlockedCard_Blocked_By");

//                entity.Property(e => e.FkBlockedCardCardId).HasColumnName("fk_BlockedCard_Card_ID");

//                entity.Property(e => e.FkBlockedCardEntityId).HasColumnName("FK_BlockedCard_Entity_ID");

//                entity.Property(e => e.FkBlockedCardUnBlockedBy).HasColumnName("fk_BlockedCard_UnBlocked_By");

//                entity.HasOne(d => d.FkBlockedCardCard)
//                    .WithMany(p => p.BlockedCard)
//                    .HasForeignKey(d => d.FkBlockedCardCardId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_BlockedCard_CardRequest");
//            });

//            modelBuilder.Entity<BlockedReasonType>(entity =>
//            {
//                entity.Property(e => e.BlockedReasonTypeId)
//                    .HasColumnName("BlockedReason_Type_ID")
//                    .ValueGeneratedOnAdd();

//                entity.Property(e => e.BlockedReasonTypeName)
//                    .IsRequired()
//                    .HasColumnName("BlockedReason_Type_Name")
//                    .HasMaxLength(100);
//            });

//            modelBuilder.Entity<BlockedUsers>(entity =>
//            {
//                entity.HasKey(e => e.BlockedUserId);

//                entity.Property(e => e.BlockedUserId).HasColumnName("BlockedUser_ID");

//                entity.Property(e => e.BlockedUserBlockedDate)
//                    .HasColumnName("BlockedUser_BlockedDate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.BlockedUserBlockedFrom)
//                    .HasColumnName("BlockedUser_BlockedFrom")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.BlockedUserBlockedTill)
//                    .HasColumnName("BlockedUser_BlockedTill")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.FkBuBlockedBy).HasColumnName("FK_BU_BlockedBy");

//                entity.Property(e => e.FkBuBlockedReasonTypeId).HasColumnName("FK_BU_BlockedReason_Type_ID");

//                entity.Property(e => e.FkBuUnBlockedBy).HasColumnName("FK_BU_UnBlockedBy");

//                entity.Property(e => e.FkBuUserId).HasColumnName("FK_BU_User_ID");

//                entity.HasOne(d => d.FkBuBlockedReasonType)
//                    .WithMany(p => p.BlockedUsers)
//                    .HasForeignKey(d => d.FkBuBlockedReasonTypeId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_BlockedUsers_BlockedReasonType");
//            });

//            modelBuilder.Entity<BloodGroupType>(entity =>
//            {
//                entity.Property(e => e.BloodGroupTypeId)
//                    .HasColumnName("BloodGroupType_ID")
//                    .ValueGeneratedOnAdd();

//                entity.Property(e => e.BloodGroupTypeName)
//                    .IsRequired()
//                    .HasColumnName("BloodGroupType_Name")
//                    .HasMaxLength(100);
//            });

//            modelBuilder.Entity<BotRequestXml>(entity =>
//            {
//                entity.ToTable("Bot_RequestXML");

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.InsertedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.RequestXml)
//                    .HasColumnName("Request_XML")
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<BtFile>(entity =>
//            {
//                entity.ToTable("BT_FILE");

//                entity.Property(e => e.BtFileId).HasColumnName("BT_FILE_ID");

//                entity.Property(e => e.BtFileCreatedDate)
//                    .HasColumnName("BT_FILE_CREATED_DATE")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.BtFileFilename)
//                    .IsRequired()
//                    .HasColumnName("BT_FILE_FILENAME")
//                    .HasMaxLength(50);

//                entity.Property(e => e.BtFileIsUpdatedInPos).HasColumnName("BT_FILE_IS_UPDATED_IN_POS");

//                entity.Property(e => e.BtFilePosUpdatedDate)
//                    .HasColumnName("BT_FILE_POS_UPDATED_DATE")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.BtFileTerminalId).HasColumnName("BT_FILE_TERMINAL_ID");
//            });

//            modelBuilder.Entity<BtLogChanges>(entity =>
//            {
//                entity.ToTable("BT_LOG_CHANGES");

//                entity.Property(e => e.BtLogChangesId).HasColumnName("BT_LOG_CHANGES_ID");

//                entity.Property(e => e.BtLogChangesBusinesstrxntypeId).HasColumnName("BT_LOG_CHANGES_BUSINESSTRXNTYPE_ID");

//                entity.Property(e => e.BtLogChangesChangedBy).HasColumnName("BT_LOG_CHANGES_CHANGED_BY");

//                entity.Property(e => e.BtLogChangesChangedDate)
//                    .HasColumnName("BT_LOG_CHANGES_CHANGED_DATE")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.BtLogChangesCurrentAmount)
//                    .HasColumnName("BT_LOG_CHANGES_CURRENT_AMOUNT")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.BtLogChangesCurrentAuthenticateId).HasColumnName("BT_LOG_CHANGES_CURRENT_AUTHENTICATE_ID");

//                entity.Property(e => e.BtLogChangesCurrentBiometricToggle)
//                    .HasColumnName("BT_LOG_CHANGES_CURRENT_BIOMETRIC_TOGGLE")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.BtLogChangesCurrentLimit)
//                    .HasColumnName("BT_LOG_CHANGES_CURRENT_LIMIT")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.BtLogChangesCurrentPinToggle)
//                    .HasColumnName("BT_LOG_CHANGES_CURRENT_PIN_TOGGLE")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.BtLogChangesPreviousAmount)
//                    .HasColumnName("BT_LOG_CHANGES_PREVIOUS_AMOUNT")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.BtLogChangesPreviousAuthenticateId).HasColumnName("BT_LOG_CHANGES_PREVIOUS_AUTHENTICATE_ID");

//                entity.Property(e => e.BtLogChangesPreviousBiometricToggle)
//                    .HasColumnName("BT_LOG_CHANGES_PREVIOUS_BIOMETRIC_TOGGLE")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.BtLogChangesPreviousLimit)
//                    .HasColumnName("BT_LOG_CHANGES_PREVIOUS_LIMIT")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.BtLogChangesPreviousPinToggle)
//                    .HasColumnName("BT_LOG_CHANGES_PREVIOUS_PIN_TOGGLE")
//                    .HasColumnType("decimal(10, 2)");
//            });

//            modelBuilder.Entity<Bulkfile>(entity =>
//            {
//                entity.ToTable("BULKFILE");

//                entity.Property(e => e.BulkFileId).HasColumnName("Bulk_File_ID");

//                entity.Property(e => e.BulkFileAmount).HasColumnName("Bulk_File_Amount");

//                entity.Property(e => e.BulkFileDate)
//                    .HasColumnName("Bulk_File_Date")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.BulkFileName)
//                    .IsRequired()
//                    .HasColumnName("Bulk_File_Name");

//                entity.Property(e => e.BulkFileTrxns).HasColumnName("Bulk_File_Trxns");
//            });

//            modelBuilder.Entity<BusinessTransactionsAdministrator>(entity =>
//            {
//                entity.HasKey(e => e.BtAdministratorId);

//                entity.Property(e => e.BtAdministratorId)
//                    .HasColumnName("BT_Administrator_ID")
//                    .ValueGeneratedNever();

//                entity.Property(e => e.BtAdministratorCreatedBy).HasColumnName("BT_Administrator_CreatedBy");

//                entity.Property(e => e.BtAdministratorCreatedOn)
//                    .HasColumnName("BT_Administrator_CreatedOn")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.BtAdministratorDescription)
//                    .HasColumnName("BT_Administrator_Description")
//                    .HasMaxLength(100);

//                entity.Property(e => e.BtAdministratorEditedBy).HasColumnName("BT_Administrator_EditedBy");

//                entity.Property(e => e.BtAdministratorEditedOn)
//                    .HasColumnName("BT_Administrator_EditedOn")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.BtAdministratorName)
//                    .IsRequired()
//                    .HasColumnName("BT_Administrator_Name")
//                    .HasMaxLength(50);

//                entity.Property(e => e.BtAdministratorStatus).HasColumnName("BT_Administrator_Status");
//            });

//            modelBuilder.Entity<BusinessTransactionsFinancial>(entity =>
//            {
//                entity.HasKey(e => e.BtFinancialId);

//                entity.Property(e => e.BtFinancialId).HasColumnName("BT_Financial_ID");

//                entity.Property(e => e.BtFinancialAmount)
//                    .HasColumnName("BT_Financial_Amount")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.BtFinancialBioMetricToggleAmt)
//                    .HasColumnName("BT_Financial_BioMetric_ToggleAmt")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.BtFinancialDescription).HasColumnName("BT_Financial_Description");

//                entity.Property(e => e.BtFinancialIsAmountRequired)
//                    .IsRequired()
//                    .HasColumnName("BT_Financial_IsAmountRequired")
//                    .HasDefaultValueSql("((1))");

//                entity.Property(e => e.BtFinancialIsForDisplay)
//                    .HasColumnName("BT_Financial_IsFor_Display")
//                    .HasDefaultValueSql("((1))");

//                entity.Property(e => e.BtFinancialIsForEdit)
//                    .IsRequired()
//                    .HasColumnName("BT_Financial_IsForEdit")
//                    .HasDefaultValueSql("((1))");

//                entity.Property(e => e.BtFinancialLimit)
//                    .HasColumnName("BT_Financial_Limit")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.BtFinancialName)
//                    .IsRequired()
//                    .HasColumnName("BT_Financial_Name")
//                    .HasMaxLength(100);

//                entity.Property(e => e.BtFinancialPinToggleAmt)
//                    .HasColumnName("BT_Financial_PIN_ToggleAmt")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.BtFinancialPtid).HasColumnName("BT_Financial_PTID");

//                entity.Property(e => e.FkBtFinancialBtNonFinancialId).HasColumnName("Fk_BT_Financial_BT_NonFinancial_ID");

//                entity.Property(e => e.FkBtFinancialCreatedBy).HasColumnName("FK_BT_Financial__CreatedBy");

//                entity.Property(e => e.FkBtFinancialCreatedOn)
//                    .HasColumnName("FK_BT_Financial__CreatedOn")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.FkBtFinancialCreditMerchantAccountId).HasColumnName("FK_BT_Financial_Credit_Merchant_Account_ID");

//                entity.Property(e => e.FkBtFinancialEditedBy).HasColumnName("FK_BT_Financial__EditedBy");

//                entity.Property(e => e.FkBtFinancialEditedOn)
//                    .HasColumnName("FK_BT_Financial__EditedOn")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.FkBtFinancialEntityId).HasColumnName("FK_BT_Financial_Entity_ID");

//                entity.Property(e => e.FkBtFinancialPosAuthenticationTypeId)
//                    .HasColumnName("FK_BT_Financial_POS_AuthenticationType_ID")
//                    .HasDefaultValueSql("((1))");

//                entity.Property(e => e.FkBtFinancialTrxnTypeId).HasColumnName("FK_BT_Financial_TrxnType_ID");

//                entity.HasOne(d => d.FkBtFinancialBtNonFinancial)
//                    .WithMany(p => p.BusinessTransactionsFinancial)
//                    .HasForeignKey(d => d.FkBtFinancialBtNonFinancialId)
//                    .HasConstraintName("FK_BT_Financial_BT_Reg_TrxnType");

//                entity.HasOne(d => d.FkBtFinancialPosAuthenticationType)
//                    .WithMany(p => p.BusinessTransactionsFinancial)
//                    .HasForeignKey(d => d.FkBtFinancialPosAuthenticationTypeId)
//                    .HasConstraintName("FK_BT_Financial_POS_AuthenticationType");

//                entity.HasOne(d => d.FkBtFinancialTrxnType)
//                    .WithMany(p => p.BusinessTransactionsFinancial)
//                    .HasForeignKey(d => d.FkBtFinancialTrxnTypeId)
//                    .HasConstraintName("FK_BT_Financial_TransactionType");
//            });

//            modelBuilder.Entity<BusinessTransactionsNonFinancial>(entity =>
//            {
//                entity.HasKey(e => e.BtNonFinancialId);

//                entity.Property(e => e.BtNonFinancialId).HasColumnName("BT_NonFinancial_ID");

//                entity.Property(e => e.BtNonFinancialCreatedBy).HasColumnName("BT_NonFinancial_CreatedBy");

//                entity.Property(e => e.BtNonFinancialCreatedOn)
//                    .HasColumnName("BT_NonFinancial_CreatedOn")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.BtNonFinancialDescription).HasColumnName("BT_NonFinancial_Description");

//                entity.Property(e => e.BtNonFinancialEditedBy).HasColumnName("BT_NonFinancial_EditedBy");

//                entity.Property(e => e.BtNonFinancialEditedOn)
//                    .HasColumnName("BT_NonFinancial_EditedOn")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.BtNonFinancialIsForDisplay).HasColumnName("BT_NonFinancial_IsForDisplay");

//                entity.Property(e => e.BtNonFinancialName)
//                    .IsRequired()
//                    .HasColumnName("BT_NonFinancial_Name")
//                    .HasMaxLength(200);

//                entity.Property(e => e.BtNonFinancialStatus).HasColumnName("BT_NonFinancial_Status");

//                entity.Property(e => e.Category)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.FkBtNonFinancialAuthenticationId).HasColumnName("FK_BT_NonFinancial_Authentication_ID");
//            });

//            modelBuilder.Entity<BusinessTrxnsAmountLimit>(entity =>
//            {
//                entity.HasKey(e => e.BusinessTrxnsLimitId);

//                entity.Property(e => e.BusinessTrxnsLimitId)
//                    .HasColumnName("BusinessTrxns_Limit_ID")
//                    .ValueGeneratedOnAdd();

//                entity.Property(e => e.Amount)
//                    .IsRequired()
//                    .HasMaxLength(50);

//                entity.Property(e => e.FkBusinessTrxnTypeId).HasColumnName("FK_BusinessTrxnType_ID");

//                entity.Property(e => e.IsSmsRequired).HasColumnName("IsSms_Required");
//            });

//            modelBuilder.Entity<CardRequestTemp>(entity =>
//            {
//                entity.HasKey(e => e.CardReqId);

//                entity.ToTable("CardRequest_Temp");

//                entity.Property(e => e.CardReqId).HasColumnName("CardReq_ID");

//                entity.Property(e => e.CardReqAuthorisedDate)
//                    .HasColumnName("CardReq_AuthorisedDate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.CardReqBlockedDate)
//                    .HasColumnName("CardReq_BlockedDate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.CardReqCardNo).HasColumnName("CardReq_CardNo");

//                entity.Property(e => e.CardReqDeAuthorisedDate)
//                    .HasColumnName("CardReq_DeAuthorisedDate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.CardReqFileName).HasColumnName("CardReq_FileName");

//                entity.Property(e => e.CardReqGeneratedDate)
//                    .HasColumnName("CardReq_GeneratedDate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.CardReqHotlistedDate)
//                    .HasColumnName("CardReq_HotlistedDate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.CardReqIsCardDuplicate).HasColumnName("CardReq_IsCardDuplicate");

//                entity.Property(e => e.CardReqIsEmbossed).HasColumnName("CardReq_IsEmbossed");

//                entity.Property(e => e.CardReqIsPrinted).HasColumnName("CardReq_IsPrinted");

//                entity.Property(e => e.CardReqRequestedDate)
//                    .HasColumnName("CardReq_RequestedDate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.CardReqUnBlockedDate)
//                    .HasColumnName("CardReq_UnBlockedDate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.FkCardReqAccountHolderId).HasColumnName("FK_CardReq_Account_Holder_ID");

//                entity.Property(e => e.FkCardReqAuthorisedBy).HasColumnName("FK_CardReq_AuthorisedBy");

//                entity.Property(e => e.FkCardReqBlockedBy).HasColumnName("FK_CardReq_BlockedBy");

//                entity.Property(e => e.FkCardReqCardStatusTypeId).HasColumnName("FK_CardReq_CardStatusType_ID");

//                entity.Property(e => e.FkCardReqCardType).HasColumnName("FK_CardReq_CardType");

//                entity.Property(e => e.FkCardReqDeAuthorisedBy).HasColumnName("FK_CardReq_DeAuthorisedBy");

//                entity.Property(e => e.FkCardReqEntityId).HasColumnName("FK_CardReq_Entity_ID");

//                entity.Property(e => e.FkCardReqGeneratedBy).HasColumnName("FK_CardReq_GeneratedBy");

//                entity.Property(e => e.FkCardReqHotlistedBy).HasColumnName("FK_CardReq_HotlistedBy");

//                entity.Property(e => e.FkCardReqRequestedBy).HasColumnName("FK_CardReq_RequestedBy");

//                entity.Property(e => e.FkCardReqUnBlockedBy).HasColumnName("FK_CardReq_UnBlockedBy");

//                entity.HasOne(d => d.FkCardReqAccountHolder)
//                    .WithMany(p => p.CardRequestTemp)
//                    .HasForeignKey(d => d.FkCardReqAccountHolderId)
//                    .HasConstraintName("FK_CardRequest_Account_Holder");

//                entity.HasOne(d => d.FkCardReqCardStatusType)
//                    .WithMany(p => p.CardRequestTemp)
//                    .HasForeignKey(d => d.FkCardReqCardStatusTypeId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_CardRequest_CardStatusType");

//                entity.HasOne(d => d.FkCardReqCardTypeNavigation)
//                    .WithMany(p => p.CardRequestTemp)
//                    .HasForeignKey(d => d.FkCardReqCardType)
//                    .HasConstraintName("FK_CardRequest_CardType");
//            });

//            modelBuilder.Entity<CardStatusType>(entity =>
//            {
//                entity.Property(e => e.CardStatusTypeId)
//                    .HasColumnName("CardStatusType_ID")
//                    .ValueGeneratedOnAdd();

//                entity.Property(e => e.CardStatusTypeName)
//                    .IsRequired()
//                    .HasColumnName("CardStatusType_Name")
//                    .HasMaxLength(100);
//            });

//            modelBuilder.Entity<CardType>(entity =>
//            {
//                entity.Property(e => e.CardTypeId)
//                    .HasColumnName("CardType_ID")
//                    .ValueGeneratedOnAdd();

//                entity.Property(e => e.CardTypeName)
//                    .IsRequired()
//                    .HasColumnName("CardType_Name")
//                    .HasMaxLength(100);
//            });

//            modelBuilder.Entity<CcavenueCreditDetails>(entity =>
//            {
//                entity.HasKey(e => e.CcavenueCreditsId);

//                entity.ToTable("CCAvenue_Credit_Details");

//                entity.HasIndex(e => e.FkAccountHolderId);

//                entity.HasIndex(e => new { e.MobileNum, e.FkEntityId });

//                entity.HasIndex(e => new { e.OrderId, e.CreatedDate })
//                    .HasName("IX_CCAvenue_Credit_Details_created_date");

//                entity.HasIndex(e => new { e.OrderId, e.TrxnCrUniqueId })
//                    .HasName("IX_CCAvenue_Credit_Details_TRXN_CR_UNIQUE_ID");

//                entity.HasIndex(e => new { e.OrderId, e.TrxnCrUniqueId, e.FkEntityId })
//                    .HasName("IX_CCAvenue_Credit_Details_Fk_EntityID");

//                entity.HasIndex(e => new { e.TrxnCrUniqueId, e.BankRefNo, e.OrderStatus, e.CreatedDate });

//                entity.HasIndex(e => new { e.CardName, e.Amount, e.PaymentMode, e.TrxnCrUniqueId, e.CreatedDate, e.OrderId })
//                    .HasName("IX_CCAvenue_Credit_Details_order_id6");

//                entity.Property(e => e.CcavenueCreditsId).HasColumnName("CCAvenue_Credits_ID");

//                entity.Property(e => e.Amount)
//                    .HasColumnName("amount")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.BankRefNo)
//                    .HasColumnName("bank_ref_no")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.BillingName)
//                    .HasColumnName("billing_name")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.BillingTel)
//                    .HasColumnName("billing_tel")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.CallbackStatus)
//                    .HasMaxLength(600)
//                    .IsUnicode(false);

//                entity.Property(e => e.CardName)
//                    .HasColumnName("card_name")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnName("created_date")
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.Currency)
//                    .HasColumnName("currency")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.DeliveryTel)
//                    .HasColumnName("delivery_tel")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.DiscountValue)
//                    .HasColumnName("discount_value")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FailureMessage)
//                    .HasColumnName("failure_message")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.FkAccountHolderId).HasColumnName("FK_Account_HolderID");

//                entity.Property(e => e.FkEntityId).HasColumnName("Fk_EntityID");

//                entity.Property(e => e.MerchantParam3)
//                    .HasColumnName("merchant_param3")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerchantParam4)
//                    .HasColumnName("merchant_param4")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.MobileNum)
//                    .HasColumnName("Mobile_Num")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.OrderId)
//                    .HasColumnName("order_id")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.OrderStatus)
//                    .HasColumnName("order_status")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.PaymentMode)
//                    .HasColumnName("payment_mode")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.SessionId)
//                    .HasColumnName("Session_ID")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Status)
//                    .HasColumnName("status")
//                    .HasMaxLength(2999)
//                    .IsUnicode(false);

//                entity.Property(e => e.StatusCode)
//                    .HasColumnName("status_code")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.StatusMessage)
//                    .HasColumnName("status_message")
//                    .HasMaxLength(2000)
//                    .IsUnicode(false);

//                entity.Property(e => e.TrackingId)
//                    .HasColumnName("tracking_id")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.TrxnCrUniqueId)
//                    .HasColumnName("TRXN_CR_UNIQUE_ID")
//                    .HasMaxLength(50);

//                entity.HasOne(d => d.FkAccountHolder)
//                    .WithMany(p => p.CcavenueCreditDetails)
//                    .HasForeignKey(d => d.FkAccountHolderId)
//                    .HasConstraintName("FK_CCAvenue_Credit_Details_Account_Holder");
//            });

//            modelBuilder.Entity<ChargeBackDetails>(entity =>
//            {
//                entity.HasKey(e => e.OrderId);

//                entity.Property(e => e.OrderId)
//                    .HasColumnName("OrderID")
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

//                entity.Property(e => e.CardName)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.CbId).ValueGeneratedOnAdd();

//                entity.Property(e => e.CcavenueRefNum)
//                    .HasColumnName("ccavenueRefNum")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Date)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.ModifiedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.PayableAmount).HasColumnType("decimal(18, 0)");

//                entity.Property(e => e.PaymentType)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.ServiceTax).HasColumnType("decimal(18, 0)");

//                entity.Property(e => e.Tdr)
//                    .HasColumnName("TDR")
//                    .HasColumnType("decimal(18, 0)");

//                entity.Property(e => e.Tdramount)
//                    .HasColumnName("TDRAmount")
//                    .HasColumnType("decimal(18, 0)");

//                entity.Property(e => e.TransactionType)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.TxnType)
//                    .HasColumnName("Txn_Type")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<ConfigParameters>(entity =>
//            {
//                entity.HasKey(e => e.ConfigParameterId);

//                entity.ToTable("Config_Parameters");

//                entity.Property(e => e.ConfigParameterId)
//                    .HasColumnName("Config_Parameter_ID")
//                    .ValueGeneratedNever();

//                entity.Property(e => e.ParameterName)
//                    .IsRequired()
//                    .HasColumnName("Parameter_Name")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.ParameterValue)
//                    .IsRequired()
//                    .HasColumnName("Parameter_Value")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<Course>(entity =>
//            {
//                entity.Property(e => e.CourseId).HasColumnName("Course_ID");

//                entity.Property(e => e.CourseName)
//                    .IsRequired()
//                    .HasColumnName("Course_Name");

//                entity.Property(e => e.FkCourseDeptId).HasColumnName("FK_Course_Dept_ID");

//                entity.HasOne(d => d.FkCourseDept)
//                    .WithMany(p => p.Course)
//                    .HasForeignKey(d => d.FkCourseDeptId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Course_Department");
//            });

//            modelBuilder.Entity<CyberplatCreditDetails>(entity =>
//            {
//                entity.HasKey(e => e.CyberplatCreditsId);

//                entity.ToTable("Cyberplat_Credit_Details");

//                entity.Property(e => e.CyberplatCreditsId).HasColumnName("Cyberplat_Credits_ID");

//                entity.Property(e => e.Amount)
//                    .HasColumnName("amount")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.BankRefNo)
//                    .HasColumnName("bank_ref_no")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.BillingName)
//                    .HasColumnName("billing_name")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.BillingTel)
//                    .HasColumnName("billing_tel")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.CardName)
//                    .HasColumnName("card_name")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnName("created_date")
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.Currency)
//                    .HasColumnName("currency")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.DeliveryTel)
//                    .HasColumnName("delivery_tel")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.DiscountValue)
//                    .HasColumnName("discount_value")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FailureMessage)
//                    .HasColumnName("failure_message")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.FkAccountHolderId).HasColumnName("FK_Account_HolderID");

//                entity.Property(e => e.MerchantParam3)
//                    .HasColumnName("merchant_param3")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerchantParam4)
//                    .HasColumnName("merchant_param4")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.MobileNum)
//                    .HasColumnName("Mobile_Num")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.OrderId)
//                    .HasColumnName("order_id")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.OrderStatus)
//                    .HasColumnName("order_status")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.PaymentMode)
//                    .HasColumnName("payment_mode")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.SessionId)
//                    .HasColumnName("Session_ID")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Status)
//                    .HasColumnName("status")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.StatusCode)
//                    .HasColumnName("status_code")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.StatusMessage)
//                    .HasColumnName("status_message")
//                    .HasMaxLength(2000)
//                    .IsUnicode(false);

//                entity.Property(e => e.TrackingId)
//                    .HasColumnName("tracking_id")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.TrxnCrUniqueId)
//                    .HasColumnName("TRXN_CR_UNIQUE_ID")
//                    .HasMaxLength(50);

//                entity.HasOne(d => d.FkAccountHolder)
//                    .WithMany(p => p.CyberplatCreditDetails)
//                    .HasForeignKey(d => d.FkAccountHolderId)
//                    .HasConstraintName("FK_Cyberplat_Credit_Details_Account_Holder");
//            });

//            modelBuilder.Entity<DatabaseMailFailure>(entity =>
//            {
//                entity.ToTable("database_mail_failure");

//                entity.HasIndex(e => e.ErrorTimeLocal);

//                entity.HasIndex(e => e.ErrorTimeUtc);

//                entity.Property(e => e.DatabaseMailFailureId).HasColumnName("database_mail_failure_id");

//                entity.Property(e => e.AppendQueryError).HasColumnName("append_query_error");

//                entity.Property(e => e.AttachQueryResultAsFile).HasColumnName("attach_query_result_as_file");

//                entity.Property(e => e.AttachmentEncoding)
//                    .HasColumnName("attachment_encoding")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.ErrorDescription)
//                    .HasColumnName("error_description")
//                    .IsUnicode(false);

//                entity.Property(e => e.ErrorTimeLocal)
//                    .HasColumnName("error_time_local")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.ErrorTimeUtc)
//                    .HasColumnName("error_time_utc")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.ExcludeQueryOutput).HasColumnName("exclude_query_output");

//                entity.Property(e => e.FileAttachments)
//                    .HasColumnName("file_attachments")
//                    .IsUnicode(false);

//                entity.Property(e => e.HasEmailBeenSentToOperator).HasColumnName("has_email_been_sent_to_operator");

//                entity.Property(e => e.MailBody)
//                    .HasColumnName("mail_body")
//                    .IsUnicode(false);

//                entity.Property(e => e.MailBodyFormat)
//                    .HasColumnName("mail_body_format")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.MailImportance)
//                    .HasColumnName("mail_importance")
//                    .HasMaxLength(6)
//                    .IsUnicode(false);

//                entity.Property(e => e.MailItemId).HasColumnName("mail_item_id");

//                entity.Property(e => e.MailProfileId).HasColumnName("mail_profile_id");

//                entity.Property(e => e.MailRecipients)
//                    .IsRequired()
//                    .HasColumnName("mail_recipients")
//                    .IsUnicode(false);

//                entity.Property(e => e.MailRecipientsBcc)
//                    .HasColumnName("mail_recipients_bcc")
//                    .IsUnicode(false);

//                entity.Property(e => e.MailRecipientsCc)
//                    .HasColumnName("mail_recipients_cc")
//                    .IsUnicode(false);

//                entity.Property(e => e.MailSendRequestAddedToQueueTimeUtc)
//                    .HasColumnName("mail_send_request_added_to_queue_time_utc")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.MailSendRequestRemovedFromQueueTimeUtc)
//                    .HasColumnName("mail_send_request_removed_from_queue_time_utc")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.MailSendRequestUser)
//                    .IsRequired()
//                    .HasColumnName("mail_send_request_user")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.MailSensitivity)
//                    .HasColumnName("mail_sensitivity")
//                    .HasMaxLength(12)
//                    .IsUnicode(false);

//                entity.Property(e => e.MailSubject)
//                    .HasColumnName("mail_subject")
//                    .IsUnicode(false);

//                entity.Property(e => e.Query)
//                    .HasColumnName("query")
//                    .IsUnicode(false);

//                entity.Property(e => e.QueryDatabase)
//                    .HasColumnName("query_database")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.QueryResultHeader).HasColumnName("query_result_header");

//                entity.Property(e => e.QueryResultSeparator)
//                    .HasColumnName("query_result_separator")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.QueryResultWidth).HasColumnName("query_result_width");
//            });

//            modelBuilder.Entity<Department>(entity =>
//            {
//                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

//                entity.Property(e => e.DepartmentFkEntityId).HasColumnName("Department_FK_Entity_ID");

//                entity.Property(e => e.DepartmentName)
//                    .IsRequired()
//                    .HasColumnName("Department_Name");
//            });

//            modelBuilder.Entity<DvlCardDetails>(entity =>
//            {
//                entity.HasKey(e => e.DvlCardId);

//                entity.ToTable("DVL_Card_Details");

//                entity.Property(e => e.DvlCardId).HasColumnName("DVL_Card_Id");

//                entity.Property(e => e.DvlCardBlockReason)
//                    .HasColumnName("DVL_Card_Block_Reason")
//                    .HasMaxLength(2000)
//                    .IsUnicode(false);

//                entity.Property(e => e.DvlCardExpiryDate)
//                    .HasColumnName("DVL_Card_Expiry_Date")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.DvlCardLastAccessedTime)
//                    .HasColumnName("DVL_Card_Last_Accessed_Time")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.DvlCardNumber)
//                    .HasColumnName("DVL_Card_Number")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.DvlCardStartDate)
//                    .HasColumnName("DVL_Card_Start_Date")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.FkAccountHolderId).HasColumnName("FK_Account_Holder_Id");

//                entity.Property(e => e.FkCardReqCardStatusTypeId).HasColumnName("FK_CardReq_CardStatusType_ID");
//            });

//            modelBuilder.Entity<DvlRequestXml>(entity =>
//            {
//                entity.HasKey(e => e.DvlRequestId);

//                entity.ToTable("DVL_Request_XML");

//                entity.Property(e => e.DvlRequestId)
//                    .HasColumnName("DVL_Request_ID")
//                    .ValueGeneratedOnAdd();

//                entity.Property(e => e.AccountHolderMobileNo).HasColumnName("Account_Holder_MobileNo");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.RequestXml)
//                    .HasColumnName("Request_XML")
//                    .IsUnicode(false);

//                entity.Property(e => e.TransactionType)
//                    .HasColumnName("Transaction_Type")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.HasOne(d => d.DvlRequest)
//                    .WithOne(p => p.InverseDvlRequest)
//                    .HasForeignKey<DvlRequestXml>(d => d.DvlRequestId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_DVL_Request_XML_DVL_Request_XML");
//            });

//            modelBuilder.Entity<DvlResponseMessage>(entity =>
//            {
//                entity.HasKey(e => e.DvlResponseId);

//                entity.ToTable("DVL_Response_Message");

//                entity.Property(e => e.DvlResponseId).HasColumnName("DVL_Response_Id");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.FkDvlRequestId).HasColumnName("FK_DVL_Request_Id");

//                entity.Property(e => e.Response).IsUnicode(false);

//                entity.HasOne(d => d.FkDvlRequest)
//                    .WithMany(p => p.DvlResponseMessage)
//                    .HasForeignKey(d => d.FkDvlRequestId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_DVL_Response_Message_DVL_Request_XML1");
//            });

//            modelBuilder.Entity<DvlSellerDetails>(entity =>
//            {
//                entity.ToTable("DVL_Seller_Details");

//                entity.Property(e => e.DvlSellerDetailsId).HasColumnName("DVL_Seller_Details_ID");

//                entity.Property(e => e.Address)
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.BankAccountNumber)
//                    .HasColumnName("Bank_Account_Number")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.BankBranch)
//                    .HasColumnName("Bank_Branch")
//                    .HasMaxLength(500);

//                entity.Property(e => e.BankName)
//                    .HasColumnName("Bank_Name")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.ContactPerson)
//                    .HasColumnName("Contact_Person")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Email).HasMaxLength(200);

//                entity.Property(e => e.IfscCode)
//                    .HasColumnName("IFSC_Code")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerchantId).HasColumnName("MerchantID");

//                entity.Property(e => e.MobileNumber)
//                    .HasColumnName("Mobile_Number")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Name)
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.OfficeNumber)
//                    .HasColumnName("Office_Number")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SellerId)
//                    .HasColumnName("SellerID")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.SellerType)
//                    .HasColumnName("Seller_Type")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Website).HasMaxLength(200);
//            });

//            modelBuilder.Entity<DvlUnregisteredFundTransfers>(entity =>
//            {
//                entity.HasKey(e => e.PkTransactionId);

//                entity.ToTable("DVL_Unregistered_FundTransfers");

//                entity.Property(e => e.PkTransactionId)
//                    .HasColumnName("PK_Transaction_ID")
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.Amount).HasColumnType("decimal(8, 2)");

//                entity.Property(e => e.FromAccountHolderId)
//                    .IsRequired()
//                    .HasColumnName("From_Account_Holder_ID")
//                    .HasMaxLength(10);

//                entity.Property(e => e.TempToAccountNo)
//                    .HasColumnName("Temp_To_Account_No")
//                    .ValueGeneratedOnAdd();

//                entity.Property(e => e.ToMobileNumber)
//                    .IsRequired()
//                    .HasColumnName("To_MobileNumber")
//                    .HasMaxLength(15);

//                entity.Property(e => e.TrnDate)
//                    .HasColumnName("Trn_Date")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.TrnState).HasColumnName("Trn_State");
//            });

//            modelBuilder.Entity<EmployeeWorkLoad>(entity =>
//            {
//                entity.HasIndex(e => new { e.WorkLoadDate, e.EmployeeId });

//                entity.Property(e => e.EmployeeId)
//                    .HasColumnName("EmployeeID")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.InsertedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.Intime)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.Outtime)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.TasksCompleted).IsUnicode(false);

//                entity.Property(e => e.TasksWorkingon).IsUnicode(false);

//                entity.Property(e => e.WorkLoadDate).HasColumnType("date");
//            });

//            modelBuilder.Entity<Entities>(entity =>
//            {
//                entity.HasKey(e => e.EntityId);

//                entity.Property(e => e.EntityId).HasColumnName("Entity_ID");

//                entity.Property(e => e.EntitieBlockedBy).HasColumnName("Entitie_Blocked_by");

//                entity.Property(e => e.EntitieBlockedOn)
//                    .HasColumnName("Entitie_Blocked_on")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.EntitieCreatedBy).HasColumnName("Entitie_Created_by");

//                entity.Property(e => e.EntitieCreatedOn)
//                    .HasColumnName("Entitie_Created_on")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.EntitieEditedBy).HasColumnName("Entitie_Edited_by");

//                entity.Property(e => e.EntitieEditedOn)
//                    .HasColumnName("Entitie_Edited_on")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.EntitieImage)
//                    .HasColumnName("Entitie_Image")
//                    .HasColumnType("image");

//                entity.Property(e => e.EntitieImageName)
//                    .HasColumnName("Entitie_Image_Name")
//                    .HasMaxLength(300);

//                entity.Property(e => e.EntitiyAuthorizedBy)
//                    .HasColumnName("Entitiy_Authorized_by")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.EntitiyAuthorizedOn)
//                    .HasColumnName("Entitiy_Authorized_on")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.EntityAddress)
//                    .HasColumnName("Entity_Address")
//                    .HasMaxLength(300);

//                entity.Property(e => e.EntityCode).HasColumnName("Entity_Code");

//                entity.Property(e => e.EntityIsActive).HasColumnName("Entity_IsActive");

//                entity.Property(e => e.EntityName)
//                    .IsRequired()
//                    .HasColumnName("Entity_Name")
//                    .HasMaxLength(100);

//                entity.Property(e => e.FkEntityGroupId).HasColumnName("FK_Entity_Group_ID");

//                entity.Property(e => e.ShortName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.HasOne(d => d.FkEntityGroup)
//                    .WithMany(p => p.Entities)
//                    .HasForeignKey(d => d.FkEntityGroupId)
//                    .HasConstraintName("FK_Entity_GroupID");
//            });

//            modelBuilder.Entity<EntitiesInactive>(entity =>
//            {
//                entity.HasKey(e => e.EntityId);

//                entity.ToTable("Entities_Inactive");

//                entity.Property(e => e.EntityId).HasColumnName("Entity_ID");

//                entity.Property(e => e.EntitieBlockedBy).HasColumnName("Entitie_Blocked_by");

//                entity.Property(e => e.EntitieBlockedOn)
//                    .HasColumnName("Entitie_Blocked_on")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.EntitieCreatedBy).HasColumnName("Entitie_Created_by");

//                entity.Property(e => e.EntitieCreatedOn)
//                    .HasColumnName("Entitie_Created_on")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.EntitieEditedBy).HasColumnName("Entitie_Edited_by");

//                entity.Property(e => e.EntitieEditedOn)
//                    .HasColumnName("Entitie_Edited_on")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.EntitieImage)
//                    .HasColumnName("Entitie_Image")
//                    .HasColumnType("image");

//                entity.Property(e => e.EntitieImageName)
//                    .HasColumnName("Entitie_Image_Name")
//                    .HasMaxLength(300);

//                entity.Property(e => e.EntitiyAuthorizedBy)
//                    .HasColumnName("Entitiy_Authorized_by")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.EntitiyAuthorizedOn)
//                    .HasColumnName("Entitiy_Authorized_on")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.EntityAddress)
//                    .HasColumnName("Entity_Address")
//                    .HasMaxLength(300);

//                entity.Property(e => e.EntityCode).HasColumnName("Entity_Code");

//                entity.Property(e => e.EntityIsActive).HasColumnName("Entity_IsActive");

//                entity.Property(e => e.EntityName)
//                    .IsRequired()
//                    .HasColumnName("Entity_Name")
//                    .HasMaxLength(100);

//                entity.Property(e => e.FkEntityGroupId).HasColumnName("FK_Entity_Group_ID");

//                entity.Property(e => e.ShortName)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.HasOne(d => d.FkEntityGroup)
//                    .WithMany(p => p.EntitiesInactive)
//                    .HasForeignKey(d => d.FkEntityGroupId)
//                    .HasConstraintName("FK_Entity_GrpID");
//            });

//            modelBuilder.Entity<Features>(entity =>
//            {
//                entity.Property(e => e.Id).HasColumnName("ID");

//                entity.Property(e => e.FkResourceId).HasColumnName("FK_ResourceId");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(500);
//            });

//            modelBuilder.Entity<FiuValues>(entity =>
//            {
//                entity.HasKey(e => e.FiuId);

//                entity.ToTable("FIU_Values");

//                entity.Property(e => e.PriorityRating).IsUnicode(false);

//                entity.Property(e => e.SourceOfAlertId)
//                    .HasColumnName("SourceOfAlertID")
//                    .HasMaxLength(2)
//                    .IsUnicode(false);

//                entity.Property(e => e.SourceOfAlertValue).IsUnicode(false);

//                entity.Property(e => e.UpdatedDate)
//                    .HasColumnType("date")
//                    .HasDefaultValueSql("(getdate())");
//            });

//            modelBuilder.Entity<Groups>(entity =>
//            {
//                entity.HasKey(e => e.GroupId);

//                entity.HasIndex(e => e.GroupId)
//                    .HasName("Unique_Group_Code")
//                    .IsUnique();

//                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

//                entity.Property(e => e.GroupAuthorizedBy).HasColumnName("Group_Authorized_by");

//                entity.Property(e => e.GroupAuthorizedOn)
//                    .HasColumnName("Group_Authorized_on")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.GroupBlockedBy).HasColumnName("Group_Blocked_by");

//                entity.Property(e => e.GroupBlockedOn)
//                    .HasColumnName("Group_Blocked_on")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.GroupCode).HasColumnName("Group_Code");

//                entity.Property(e => e.GroupCreatedBy).HasColumnName("Group_Created_by");

//                entity.Property(e => e.GroupCreatedOn)
//                    .HasColumnName("Group_Created_on")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.GroupDesc).HasColumnName("Group_Desc");

//                entity.Property(e => e.GroupEditedBy).HasColumnName("Group_Edited_by");

//                entity.Property(e => e.GroupEditedOn)
//                    .HasColumnName("Group_Edited_on")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.GroupIsOffUsEnable).HasColumnName("Group_Is_OffUs_Enable");

//                entity.Property(e => e.GroupName)
//                    .IsRequired()
//                    .HasColumnName("Group_Name")
//                    .HasMaxLength(200);

//                entity.Property(e => e.GroupStatus).HasColumnName("Group_Status");
//            });

//            modelBuilder.Entity<HelpDeskStatus>(entity =>
//            {
//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.Name)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<Hmwssbupload>(entity =>
//            {
//                entity.HasKey(e => e.TransactionId);

//                entity.ToTable("HMWSSBUpload");

//                entity.Property(e => e.TransactionId)
//                    .HasMaxLength(299)
//                    .IsUnicode(false)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.AcknowledgementNo)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Can)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.InstrumentDate)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.InstrumentIssuerName)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.InstrumentNo)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.ModeOfPayment)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.PostedDate)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Reconciled).HasDefaultValueSql("('0')");

//                entity.Property(e => e.TransDate)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.TransactionAmount)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<Hostel>(entity =>
//            {
//                entity.Property(e => e.HostelId).ValueGeneratedNever();

//                entity.Property(e => e.HostelType)
//                    .IsRequired()
//                    .HasMaxLength(50);
//            });

//            modelBuilder.Entity<ImpsTrxns>(entity =>
//            {
//                entity.HasKey(e => e.ImpsSno);

//                entity.ToTable("IMPS_Trxns");

//                entity.HasIndex(e => e.FkTrxnUniqueid);

//                entity.HasIndex(e => e.ImpsTrxnDate)
//                    .HasName("#IMPS_Trxn_date");

//                entity.HasIndex(e => e.Impscredit)
//                    .HasName("#Statu1");

//                entity.HasIndex(e => e.MsgId)
//                    .HasName("NonClusteredIndex-20230709-083949");

//                entity.HasIndex(e => e.Rrn)
//                    .HasName("RRN");

//                entity.HasIndex(e => e.Status)
//                    .HasName("#Statu");

//                entity.HasIndex(e => new { e.FkEntityId, e.FkTrxnUniqueid })
//                    .HasName("IX_IMPS_Trxns_Fk_Trxn_Uniquei1d");

//                entity.HasIndex(e => new { e.FkSenderAcNumber, e.FkTrxnUniqueid });

//                entity.HasIndex(e => new { e.Rrn, e.Status, e.FkEntityId })
//                    .HasName("IX_IMPS_Trxns_Status_Fk_Entity_ID");

//                entity.HasIndex(e => new { e.SenderMobileNumber, e.FkEntityId, e.Impscredit });

//                entity.HasIndex(e => new { e.FkTrxnUniqueid, e.FkEntityId, e.Impscredit, e.Rrn })
//                    .HasName("IX_IMPS_Trxns_RRN4");

//                entity.HasIndex(e => new { e.ImpsSno, e.Status, e.Impscredit, e.Rrn })
//                    .HasName("IX_IMPS_Trxns_IMPSCredit_RRN");

//                entity.HasIndex(e => new { e.Amount, e.Tacharges, e.EntityCharges, e.Asocharges, e.Rrn })
//                    .HasName("IX_IMPS_Trxns_RRN");

//                entity.HasIndex(e => new { e.ImpsTrxnDate, e.Amount, e.ReceiverAcNumber, e.FkEntityId, e.SenderMobileNumber })
//                    .HasName("IX_IMPS_Trxns_Sender_Mobile_Number1");

//                entity.HasIndex(e => new { e.ImpsTrxnDate, e.Amount, e.Status, e.FkSenderAcNumber, e.Impscredit })
//                    .HasName("IX_IMPS_Trxns_Fk_Sender_Ac_Number_IMPSCredit");

//                entity.HasIndex(e => new { e.ImpsTrxnDate, e.Amount, e.Status, e.Impscredit, e.CustomerMobilenumber })
//                    .HasName("IX_IMPS_Trxns_IMPSCredit_CustomerMobilenumber");

//                entity.HasIndex(e => new { e.ReceiverAcNumber, e.ReceiverMobileNumber, e.SenderMobileNumber, e.Amount, e.ImpsTrxnDate })
//                    .HasName("IX_IMPS_Trxns_Sender_Mobile_Number_Amount_IMPS_Trxn_date");

//                entity.HasIndex(e => new { e.Status, e.Impscredit, e.FkEntityId, e.ImpsTrxnDate, e.Amount })
//                    .HasName("IX_IMPS_Trxns_Fk_Entity_ID_IMPS_Trxn_date_Amount");

//                entity.HasIndex(e => new { e.Amount, e.Status, e.FkTrxnUniqueid, e.Rrn, e.Impscredit, e.ImpsTrxnDate })
//                    .HasName("IX_IMPS_Trxns_IMPS_Trxn_date");

//                entity.HasIndex(e => new { e.FkSenderAcNumber, e.SenderMobileNumber, e.ReceiverIfsc, e.FkEntityId, e.Impscredit, e.ReceiverAcNumber })
//                    .HasName("IX_IMPS_Trxns_Receiver_Ac_Number");

//                entity.HasIndex(e => new { e.FkSenderAcNumber, e.Amount, e.ReceiverAcNumber, e.ReceiverIfsc, e.ReceiverMobileNumber, e.ReceiverMmid, e.ImpsTrxnDate })
//                    .HasName("IX_IMPS_Trxns_IMPS_Trxn_date_1");

//                entity.HasIndex(e => new { e.ImpsTrxnDate, e.Amount, e.Status, e.ReceiverAcNumber, e.ReceiverIfsc, e.Impscredit, e.SenderMobileNumber, e.FkEntityId })
//                    .HasName("IX_IMPS_Trxns_Sender_Mobile_Number_Fk_Entity_ID2");

//                entity.HasIndex(e => new { e.ImpsTrxnDate, e.Amount, e.Status, e.ReceiverMobileNumber, e.ReceiverMmid, e.Impscredit, e.SenderMobileNumber, e.FkEntityId })
//                    .HasName("IX_IMPS_Trxns_Sender_Mobile_Number_Fk_Entity_ID");

//                entity.HasIndex(e => new { e.ImpsTrxnDate, e.Status, e.ReceiverAcNumber, e.ReceiverIfsc, e.ReceiverMobileNumber, e.ReceiverMmid, e.Impscredit, e.FkSenderAcNumber, e.Amount })
//                    .HasName("IX_IMPS_Trxns_Fk_Sender_Ac_Number_Amount");

//                entity.Property(e => e.ImpsSno).HasColumnName("IMPS_SNO");

//                entity.Property(e => e.AdcashBack)
//                    .HasColumnName("ADCashBack")
//                    .HasColumnType("decimal(30, 2)");

//                entity.Property(e => e.Addr)
//                    .HasColumnName("addr")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.Adtds)
//                    .HasColumnName("ADTDS")
//                    .HasColumnType("decimal(30, 2)");

//                entity.Property(e => e.AgentTds)
//                    .HasColumnName("AgentTDS")
//                    .HasColumnType("decimal(30, 2)");

//                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.AmountValue)
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.Amountcurr)
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.Asocharges).HasColumnName("ASOCharges");

//                entity.Property(e => e.CardAccIdCode)
//                    .HasColumnName("cardAccIdCode")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.CardAccpTrId)
//                    .HasColumnName("cardAccpTrId")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.Code)
//                    .HasColumnName("code")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.CredType)
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.CustRef)
//                    .HasColumnName("custRef")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.CustomerMobilenumber)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.DetailAcnum)
//                    .HasColumnName("DetailACNUM")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.DetailAcrype)
//                    .HasColumnName("DetailACRYPE")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.DetailIfsc)
//                    .HasColumnName("DetailIFSC")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.DetailMmid)
//                    .HasColumnName("DetailMMID")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.DetailMobile)
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.DeviceLocation)
//                    .HasColumnName("DeviceLOCATION")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.DeviceMobile)
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.FkEntityId).HasColumnName("Fk_Entity_ID");

//                entity.Property(e => e.FkSenderAcNumber).HasColumnName("Fk_Sender_Ac_Number");

//                entity.Property(e => e.FkTrxnUniqueid)
//                    .IsRequired()
//                    .HasColumnName("Fk_Trxn_Uniqueid")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Gst)
//                    .HasColumnName("GST")
//                    .HasColumnType("decimal(30, 2)");

//                entity.Property(e => e.ImpsTrxnDate)
//                    .HasColumnName("IMPS_Trxn_date")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Impscredit)
//                    .HasColumnName("IMPSCredit")
//                    .HasDefaultValueSql("('False')");

//                entity.Property(e => e.InitiationMode)
//                    .HasColumnName("initiationMode")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.MdcashBack)
//                    .HasColumnName("MDCashBack")
//                    .HasColumnType("decimal(30, 2)");

//                entity.Property(e => e.Mdtds)
//                    .HasColumnName("MDTDS")
//                    .HasColumnType("decimal(30, 2)");

//                entity.Property(e => e.MsgId)
//                    .HasColumnName("msgId")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.Name)
//                    .HasColumnName("name")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.Note)
//                    .HasColumnName("note")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.Npcicharge)
//                    .HasColumnName("NPCICharge")
//                    .HasColumnType("decimal(30, 2)");

//                entity.Property(e => e.OrgId)
//                    .HasColumnName("orgId")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.Pan)
//                    .HasColumnName("PAN")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.PayeeaddrType)
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.Payeecode)
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.PayeeseqNum)
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.Payeetype)
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.PayerAcnum)
//                    .HasColumnName("PayerACNUM")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.PayerActype)
//                    .HasColumnName("PayerACTYPE")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.PayerIfsc)
//                    .HasColumnName("PayerIFSC")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.PayerMmid)
//                    .HasColumnName("PayerMMID")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.PayerMobnum)
//                    .HasColumnName("PayerMOBNUM")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.Payertype)
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.Pin)
//                    .HasColumnName("PIN")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.ProdType)
//                    .HasColumnName("prodType")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.Purpose)
//                    .HasColumnName("purpose")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.ReceiverAcNumber)
//                    .HasColumnName("Receiver_Ac_Number")
//                    .HasMaxLength(50);

//                entity.Property(e => e.ReceiverIfsc)
//                    .HasColumnName("Receiver_IFSC")
//                    .HasMaxLength(20);

//                entity.Property(e => e.ReceiverMmid)
//                    .HasColumnName("Receiver_MMID")
//                    .HasMaxLength(7);

//                entity.Property(e => e.ReceiverMobileNumber)
//                    .HasColumnName("Receiver_Mobile_Number")
//                    .HasMaxLength(12);

//                entity.Property(e => e.RefCategory)
//                    .HasColumnName("refCategory")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.RefId)
//                    .HasColumnName("refId")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayeeIfsc)
//                    .HasColumnName("RespPayeeIFSC")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayeeacNum)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayeeaccType)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayeeaddr)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayeeapprovalNum)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayeecode)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayeeorgAmount)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayeeregName)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayeerespCode)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayeeresult)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayeereversalRespCode)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayeeseqNum)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayeesettAmount)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayeesettCurrency)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayerIfsc)
//                    .HasColumnName("RespPayerIFSC")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayeracNum)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayeraccType)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayeraddr)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayerapprovalNum)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayercode)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayerorgAmount)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayerregName)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayerrespCode)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayerreversalRespCode)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayerseqNum)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayersettAmount)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RespPayersettCurrency)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Rrn)
//                    .HasColumnName("RRN")
//                    .HasMaxLength(12)
//                    .IsUnicode(false)
//                    .HasDefaultValueSql("(right(((datename(year,getdate())+CONVERT([char](3),right('00'+datename(dayofyear,getdate()),(3)),(0)))+CONVERT([char](2),replace(CONVERT([varchar],getdate(),(114)),':',''),(0)))+CONVERT([char](6),CONVERT([int],CONVERT([numeric](7,0),rand()*(899999),(0))+(100000),(0)),(0)),(12)))");

//                entity.Property(e => e.SenderIfsc)
//                    .HasColumnName("Sender_IFSC")
//                    .HasMaxLength(10);

//                entity.Property(e => e.SenderMobileNumber)
//                    .IsRequired()
//                    .HasColumnName("Sender_Mobile_Number")
//                    .HasMaxLength(12);

//                entity.Property(e => e.SeqNum)
//                    .HasColumnName("seqNum")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.Status)
//                    .IsRequired()
//                    .HasMaxLength(50);

//                entity.Property(e => e.Tacharges).HasColumnName("TACharges");

//                entity.Property(e => e.Tashare)
//                    .HasColumnName("TAShare")
//                    .HasColumnType("decimal(30, 2)");

//                entity.Property(e => e.Ts)
//                    .HasColumnName("TS")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.TxnerrCode)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Txnid)
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.Txnresult)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Txntype)
//                    .HasMaxLength(999)
//                    .IsUnicode(false);

//                entity.Property(e => e.Ver)
//                    .HasColumnName("ver")
//                    .HasMaxLength(999)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<ImpsTrxnsRejected>(entity =>
//            {
//                entity.HasKey(e => e.ImpsSno);

//                entity.ToTable("IMPS_Trxns_Rejected");

//                entity.HasIndex(e => new { e.ErrorDescription, e.FkEntityId, e.ImpsTrxnDate })
//                    .HasName("IX_IMPS_Trxns_Rejected_Fk_Entity_ID_IMPS_Trxn_date");

//                entity.Property(e => e.ImpsSno).HasColumnName("IMPS_SNO");

//                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.Asocharges).HasColumnName("ASOCharges");

//                entity.Property(e => e.CustomerMobilenumber)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.ErrorDescription)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.FkEntityId).HasColumnName("Fk_Entity_ID");

//                entity.Property(e => e.FkSenderAcNumber).HasColumnName("Fk_Sender_Ac_Number");

//                entity.Property(e => e.FkTrxnUniqueid)
//                    .IsRequired()
//                    .HasColumnName("Fk_Trxn_Uniqueid")
//                    .HasMaxLength(50);

//                entity.Property(e => e.ImpsTrxnDate)
//                    .HasColumnName("IMPS_Trxn_date")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Impscredit)
//                    .HasColumnName("IMPSCredit")
//                    .HasDefaultValueSql("('False')");

//                entity.Property(e => e.Pin)
//                    .HasColumnName("PIN")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.ReceiverAcNumber)
//                    .HasColumnName("Receiver_Ac_Number")
//                    .HasMaxLength(50);

//                entity.Property(e => e.ReceiverIfsc)
//                    .HasColumnName("Receiver_IFSC")
//                    .HasMaxLength(20);

//                entity.Property(e => e.ReceiverMmid)
//                    .HasColumnName("Receiver_MMID")
//                    .HasMaxLength(7);

//                entity.Property(e => e.ReceiverMobileNumber)
//                    .HasColumnName("Receiver_Mobile_Number")
//                    .HasMaxLength(12);

//                entity.Property(e => e.Rrn)
//                    .HasColumnName("RRN")
//                    .HasMaxLength(12)
//                    .IsUnicode(false)
//                    .HasDefaultValueSql("(right(((datename(year,getdate())+CONVERT([char](3),right('00'+datename(dayofyear,getdate()),(3)),(0)))+CONVERT([char](2),replace(CONVERT([varchar],getdate(),(114)),':',''),(0)))+CONVERT([char](6),CONVERT([int],CONVERT([numeric](7,0),rand()*(899999),(0))+(100000),(0)),(0)),(12)))");

//                entity.Property(e => e.SenderIfsc)
//                    .HasColumnName("Sender_IFSC")
//                    .HasMaxLength(10);

//                entity.Property(e => e.SenderMobileNumber)
//                    .IsRequired()
//                    .HasColumnName("Sender_Mobile_Number")
//                    .HasMaxLength(12);

//                entity.Property(e => e.Status)
//                    .IsRequired()
//                    .HasMaxLength(50);

//                entity.Property(e => e.Tacharges).HasColumnName("TACharges");
//            });

//            modelBuilder.Entity<LogTerminals>(entity =>
//            {
//                entity.HasKey(e => e.LogTerminalId);

//                entity.ToTable("Log_Terminals");

//                entity.Property(e => e.LogTerminalId).HasColumnName("LogTerminal_ID");

//                entity.Property(e => e.FkLogTerminalTerminalId).HasColumnName("FK_LogTerminal_Terminal_ID");

//                entity.Property(e => e.LogTerminalDateTime)
//                    .HasColumnName("LogTerminal_DateTime")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.LogTerminalIsAlive).HasColumnName("LogTerminal_IsAlive");

//                entity.Property(e => e.LogTerminalIsFtpfilesReceived).HasColumnName("LogTerminal_IsFTPFiles_Received");

//                entity.Property(e => e.LogTerminalIsOffTrxnsProcessed).HasColumnName("LogTerminal_IsOffTrxns_Processed");

//                entity.HasOne(d => d.FkLogTerminalTerminal)
//                    .WithMany(p => p.LogTerminals)
//                    .HasForeignKey(d => d.FkLogTerminalTerminalId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_TerminalLog_Terminals");
//            });

//            modelBuilder.Entity<LogWeb>(entity =>
//            {
//                entity.ToTable("Log_Web");

//                entity.Property(e => e.LogWebId).HasColumnName("LogWeb_ID");

//                entity.Property(e => e.FkLogWebUserLoginId).HasColumnName("FK_LogWeb_User_LoginId");

//                entity.Property(e => e.LogWebDateTime)
//                    .IsRequired()
//                    .HasColumnName("LogWeb_DateTime")
//                    .HasMaxLength(2);

//                entity.Property(e => e.LogWebException).HasColumnName("LogWeb_Exception");

//                entity.Property(e => e.LogWebLogger)
//                    .IsRequired()
//                    .HasColumnName("LogWeb_Logger");

//                entity.Property(e => e.LogWebMessage)
//                    .IsRequired()
//                    .HasColumnName("LogWeb_Message");
//            });

//            modelBuilder.Entity<MerchantConfig>(entity =>
//            {
//                entity.HasKey(e => e.MerConfigId);

//                entity.ToTable("Merchant_Config");

//                entity.Property(e => e.MerConfigId).HasColumnName("MerConfig_ID");

//                entity.Property(e => e.FkMerConfigMerchantId).HasColumnName("Fk_MerConfig_Merchant_ID");

//                entity.Property(e => e.IsPrefundedMerchant).HasDefaultValueSql("((0))");

//                entity.Property(e => e.MerConfigAccountNumber)
//                    .IsRequired()
//                    .HasColumnName("MerConfig_Account_Number")
//                    .HasMaxLength(20);

//                entity.Property(e => e.MerConfigAuthorizedDate)
//                    .HasColumnName("MerConfig_Authorized_Date")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.MerConfigAuthrorizedBy).HasColumnName("MerConfig_AuthrorizedBy");

//                entity.Property(e => e.MerConfigBalance)
//                    .HasColumnName("MerConfig_Balance")
//                    .HasDefaultValueSql("((0.00))");

//                entity.Property(e => e.MerConfigBankName)
//                    .IsRequired()
//                    .HasColumnName("MerConfig_Bank_Name");

//                entity.Property(e => e.MerConfigBranchCode)
//                    .HasColumnName("MerConfig_Branch_Code")
//                    .HasMaxLength(5);

//                entity.Property(e => e.MerConfigBranchName)
//                    .IsRequired()
//                    .HasColumnName("MerConfig_Branch_Name")
//                    .HasMaxLength(50);

//                entity.Property(e => e.MerConfigCreatedBy).HasColumnName("MerConfig_Created_by");

//                entity.Property(e => e.MerConfigCreatedOn)
//                    .HasColumnName("MerConfig_CreatedOn")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.MerConfigEditedBy).HasColumnName("MerConfig_Edited_by");

//                entity.Property(e => e.MerConfigEditedOn)
//                    .HasColumnName("MerConfig_EditedOn")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.MerConfigIfscCode)
//                    .IsRequired()
//                    .HasColumnName("MerConfig_IFSC_Code")
//                    .HasMaxLength(15);

//                entity.Property(e => e.MerConfigIsAuthorized).HasColumnName("MerConfig_Is_Authorized");

//                entity.Property(e => e.MerConfigNumOfEntityId).HasColumnName("MerConfig_Num_Of_EntityID");
//            });

//            modelBuilder.Entity<MerchantEntityConfiguration>(entity =>
//            {
//                entity.HasKey(e => e.MemId);

//                entity.ToTable("Merchant_Entity_Configuration");

//                entity.Property(e => e.MemId).HasColumnName("MEM_ID");

//                entity.Property(e => e.FkMemConfigId).HasColumnName("FK_MEM_Config_ID");

//                entity.Property(e => e.FkMemEntityId).HasColumnName("FK_MEM_Entity_ID");

//                entity.Property(e => e.MemMappedOn)
//                    .HasColumnName("MEM_MappedOn")
//                    .HasColumnType("datetime");

//                entity.HasOne(d => d.FkMemConfig)
//                    .WithMany(p => p.MerchantEntityConfiguration)
//                    .HasForeignKey(d => d.FkMemConfigId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_MEM_Config_ID");
//            });

//            modelBuilder.Entity<MerchantInfo>(entity =>
//            {
//                entity.HasKey(e => e.MerchantId);

//                entity.ToTable("Merchant_Info");

//                entity.Property(e => e.MerchantId).HasColumnName("Merchant_ID");

//                entity.Property(e => e.Category)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.CenterId)
//                    .HasColumnName("CenterID")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Charges).HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

//                entity.Property(e => e.FoodCategory).HasDefaultValueSql("((0))");

//                entity.Property(e => e.GovtMerchant)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerchantAddress)
//                    .IsRequired()
//                    .HasColumnName("Merchant_Address");

//                entity.Property(e => e.MerchantContactPerson)
//                    .HasColumnName("Merchant_contact_Person")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerchantCreatedBy).HasColumnName("Merchant_CreatedBy");

//                entity.Property(e => e.MerchantCreatedon)
//                    .HasColumnName("Merchant_Createdon")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.MerchantEditedBy).HasColumnName("Merchant_EditedBy");

//                entity.Property(e => e.MerchantEditedOn)
//                    .HasColumnName("Merchant_EditedOn")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.MerchantEmailid)
//                    .IsRequired()
//                    .HasColumnName("Merchant_Emailid");

//                entity.Property(e => e.MerchantEnableOffus).HasColumnName("Merchant_Enable_Offus");

//                entity.Property(e => e.MerchantIsPasswordReset).HasColumnName("Merchant_IsPasswordReset");

//                entity.Property(e => e.MerchantLocation)
//                    .HasColumnName("Merchant_Location")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerchantLoginId)
//                    .HasColumnName("Merchant_LoginID")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerchantMobileNo).HasColumnName("Merchant_MobileNo");

//                entity.Property(e => e.MerchantName)
//                    .HasColumnName("Merchant_Name")
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerchantPan)
//                    .HasColumnName("Merchant_PAN")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerchantPwd)
//                    .IsRequired()
//                    .HasColumnName("Merchant_PWD");

//                entity.Property(e => e.MerchantStatus).HasColumnName("Merchant_Status");

//                entity.Property(e => e.ReferenceMobileNumber)
//                    .HasColumnName("Reference_Mobile_number")
//                    .HasMaxLength(12)
//                    .IsUnicode(false);

//                entity.Property(e => e.ReferralCode)
//                    .HasMaxLength(12)
//                    .IsUnicode(false);

//                entity.Property(e => e.RegistrationNumber)
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.RequestId).HasColumnName("Request_Id");

//                entity.Property(e => e.RetailMerchant).HasDefaultValueSql("((0))");

//                entity.Property(e => e.SendSmsforTxn).HasColumnName("SendSMSForTxn");
//            });

//            modelBuilder.Entity<MerchantsAudit>(entity =>
//            {
//                entity.HasKey(e => e.MerchantAuditId);

//                entity.Property(e => e.MerchantAuditId).HasColumnName("MerchantAudit_ID");

//                entity.Property(e => e.FkMerchantAuditMid).HasColumnName("FK_MerchantAudit_MID");

//                entity.Property(e => e.MerchantAuditDateTime)
//                    .HasColumnName("MerchantAudit_DateTime")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.MerchantAuditException).HasColumnName("MerchantAudit_Exception");

//                entity.Property(e => e.MerchantAuditMessage)
//                    .IsRequired()
//                    .HasColumnName("MerchantAudit_Message");
//            });

//            modelBuilder.Entity<MobileVenodrs>(entity =>
//            {
//                entity.HasKey(e => e.MobileVendorsId);

//                entity.ToTable("Mobile_Venodrs");

//                entity.Property(e => e.MobileVendorsId)
//                    .HasColumnName("Mobile_Vendors_ID")
//                    .ValueGeneratedNever();

//                entity.Property(e => e.MobileVendorName)
//                    .IsRequired()
//                    .HasColumnName("Mobile_Vendor_Name")
//                    .HasMaxLength(150)
//                    .IsUnicode(false);

//                entity.Property(e => e.Status).HasColumnName("status");
//            });

//            modelBuilder.Entity<NbinMaster>(entity =>
//            {
//                entity.HasKey(e => e.PkId);

//                entity.ToTable("NBIN_MASTER");

//                entity.Property(e => e.PkId)
//                    .HasColumnName("Pk_Id")
//                    .ValueGeneratedNever();

//                entity.Property(e => e.BankName).HasMaxLength(500);

//                entity.Property(e => e.BankType).HasMaxLength(500);

//                entity.Property(e => e.Ifsc)
//                    .HasColumnName("IFSC")
//                    .HasMaxLength(2999)
//                    .IsUnicode(false);

//                entity.Property(e => e.Nbin).HasColumnName("NBIN");
//            });

//            modelBuilder.Entity<NeftFileMapping>(entity =>
//            {
//                entity.HasKey(e => e.NfmFieldId);

//                entity.ToTable("Neft_File_Mapping");

//                entity.Property(e => e.NfmFieldId).HasColumnName("NFM_FIELD_ID");

//                entity.Property(e => e.NfmBankFieldName)
//                    .IsRequired()
//                    .HasColumnName("NFM_BANK_FIELD_NAME")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NfmC3FieldName)
//                    .IsRequired()
//                    .HasColumnName("NFM_C3_FIELD_NAME")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NfmFieldStatus).HasColumnName("NFM_FIELD_STATUS");
//            });

//            modelBuilder.Entity<NotfServiceTypes>(entity =>
//            {
//                entity.HasKey(e => e.ServcTypeId);

//                entity.ToTable("Notf_Service_Types");

//                entity.Property(e => e.ServcTypeId).HasColumnName("Servc_Type_Id");

//                entity.Property(e => e.ServcTypeName)
//                    .IsRequired()
//                    .HasColumnName("Servc_Type_Name")
//                    .HasMaxLength(50);
//            });

//            modelBuilder.Entity<NotifMailConfig>(entity =>
//            {
//                entity.HasKey(e => e.NmconfigId);

//                entity.ToTable("Notif_Mail_Config");

//                entity.Property(e => e.NmconfigId).HasColumnName("NMConfig_ID");

//                entity.Property(e => e.EntityId).HasColumnName("EntityID");

//                entity.Property(e => e.FkNmconfSdListTypeId).HasColumnName("FK_NMConf_SdList_Type_ID");

//                entity.Property(e => e.FkNmconfigNotifListId).HasColumnName("FK_NMConfig_Notif_list_ID");

//                entity.Property(e => e.NmconfigConditionValue).HasColumnName("NMConfig_Condition_Value");

//                entity.Property(e => e.NmconfigSendersList).HasColumnName("NMConfig_Senders_List");

//                entity.Property(e => e.NmconfigStatus).HasColumnName("NMConfig_Status");

//                entity.HasOne(d => d.FkNmconfigNotifList)
//                    .WithMany(p => p.NotifMailConfig)
//                    .HasForeignKey(d => d.FkNmconfigNotifListId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Notif_Mail_Config_Notif_Mail_List1");
//            });

//            modelBuilder.Entity<NotifMailList>(entity =>
//            {
//                entity.ToTable("Notif_Mail_List");

//                entity.Property(e => e.NotifMailListId).HasColumnName("Notif_Mail_List_ID");

//                entity.Property(e => e.EntityId).HasColumnName("EntityID");

//                entity.Property(e => e.FkNotifMailServiceType).HasColumnName("FK_Notif_Mail_Service_Type");

//                entity.Property(e => e.NotifMailListCondValue).HasColumnName("Notif_Mail_List_Cond_Value");

//                entity.Property(e => e.NotifMailListDesc)
//                    .IsRequired()
//                    .HasColumnName("Notif_Mail_List_Desc");

//                entity.Property(e => e.NotifMailListName)
//                    .IsRequired()
//                    .HasColumnName("Notif_Mail_List_Name")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NotifMailListStatus).HasColumnName("Notif_Mail_List_Status");

//                entity.HasOne(d => d.FkNotifMailServiceTypeNavigation)
//                    .WithMany(p => p.NotifMailList)
//                    .HasForeignKey(d => d.FkNotifMailServiceType)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Notif_Mail_List_Notf_Service_Types");
//            });

//            modelBuilder.Entity<PayQwikCampaigns>(entity =>
//            {
//                entity.HasKey(e => e.PqCampaignId);

//                entity.ToTable("PayQwik_Campaigns");

//                entity.Property(e => e.PqCampaignId).HasColumnName("PQ_Campaign_Id");

//                entity.Property(e => e.CampaignCode)
//                    .HasColumnName("Campaign_Code")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.CampaignName)
//                    .HasColumnName("Campaign_Name")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.CouponAmount)
//                    .HasColumnName("Coupon_Amount")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.CouponCode)
//                    .HasColumnName("Coupon_Code")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.EndDate).HasColumnType("datetime");

//                entity.Property(e => e.StartDate).HasColumnType("datetime");

//                entity.Property(e => e.TargetAmount)
//                    .HasColumnName("Target_Amount")
//                    .HasColumnType("decimal(10, 2)");
//            });

//            modelBuilder.Entity<PayQwikCampaignTypes>(entity =>
//            {
//                entity.HasKey(e => e.PqCampaignTypeId);

//                entity.ToTable("PayQwik_Campaign_Types");

//                entity.Property(e => e.PqCampaignTypeId).HasColumnName("PQ_Campaign_Type_Id");

//                entity.Property(e => e.CampaignCode)
//                    .HasColumnName("Campaign_Code")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.CampaignName)
//                    .HasColumnName("Campaign_Name")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");
//            });

//            modelBuilder.Entity<PayQwikCardDetails>(entity =>
//            {
//                entity.HasKey(e => e.PqCardId);

//                entity.ToTable("PayQwik_Card_Details");

//                entity.Property(e => e.PqCardId)
//                    .HasColumnName("PQ_Card_Id")
//                    .ValueGeneratedNever();

//                entity.Property(e => e.FkAccountHolderId).HasColumnName("FK_Account_Holder_Id");

//                entity.Property(e => e.PqCardAccessName)
//                    .HasColumnName("PQ_CardAccess_Name")
//                    .HasMaxLength(15);

//                entity.Property(e => e.PqCardLastAccessedTime)
//                    .HasColumnName("PQ_Card_Last_Accessed_Time")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.PqCardValidFromTime)
//                    .HasColumnName("PQ_Card_ValidFrom_Time")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.PqCardValidTillTime)
//                    .HasColumnName("PQ_Card_ValidTill_Time")
//                    .HasColumnType("datetime");
//            });

//            modelBuilder.Entity<PayQwikCouponsIssued>(entity =>
//            {
//                entity.HasKey(e => e.PqCouponId);

//                entity.ToTable("PayQwik_Coupons_Issued");

//                entity.Property(e => e.PqCouponId).HasColumnName("PQ_Coupon_Id");

//                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.CouponCode)
//                    .HasColumnName("Coupon_Code")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

//                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

//                entity.Property(e => e.FkAccountHolderId).HasColumnName("FK_Account_Holder_Id");

//                entity.Property(e => e.MobileNumber)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.RedemptionDate).HasColumnType("datetime");
//            });

//            modelBuilder.Entity<PayQwikCyberPlatTransactions>(entity =>
//            {
//                entity.HasKey(e => e.TransactionSysId);

//                entity.ToTable("PayQwik_CyberPlat_Transactions");

//                entity.Property(e => e.TransactionSysId).HasColumnName("TransactionSysID");

//                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.CyberPlatState)
//                    .HasColumnName("CyberPlat_State")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.CyberPlatTransactionTime)
//                    .HasColumnName("CyberPlat_Transaction_Time")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.CyberplatAuthCode)
//                    .HasColumnName("Cyberplat_Auth_Code")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.CyberplatTransactionId)
//                    .HasColumnName("Cyberplat_Transaction_ID")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.DebitDateActual)
//                    .HasColumnName("Debit_Date_Actual")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.DebitUniqueId)
//                    .HasColumnName("Debit_Unique_ID")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.FkAccountHolderId).HasColumnName("FK_Account_Holder_ID");

//                entity.Property(e => e.RechargeMobileNumber)
//                    .HasColumnName("Recharge_Mobile_Number")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.ServiceProvider)
//                    .HasColumnName("Service_Provider")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.HasOne(d => d.FkAccountHolder)
//                    .WithMany(p => p.PayQwikCyberPlatTransactions)
//                    .HasForeignKey(d => d.FkAccountHolderId)
//                    .HasConstraintName("FK_PayQwik_Account_ID");
//            });

//            modelBuilder.Entity<PayQwikRegistrationEmail>(entity =>
//            {
//                entity.HasKey(e => e.PkRegisteredEmailId);

//                entity.ToTable("PayQwik_Registration_Email");

//                entity.HasIndex(e => e.FkBrmAccountHolderId);

//                entity.Property(e => e.PkRegisteredEmailId)
//                    .HasColumnName("PK_Registered_Email_Id")
//                    .HasMaxLength(200)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.BrmEmailOtp)
//                    .IsRequired()
//                    .HasColumnName("BRM_Email_OTP")
//                    .HasMaxLength(10);

//                entity.Property(e => e.BrmReqReceivingTime)
//                    .HasColumnName("BRM_Req_receiving_time")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.FkBrmAccountHolderId).HasColumnName("FK_BRM_Account_Holder_ID");

//                entity.Property(e => e.IsEmailActive).HasColumnName("IsEmail_Active");
//            });

//            modelBuilder.Entity<PayQwikRegistrationMobile>(entity =>
//            {
//                entity.HasKey(e => e.FkAccountHolderId);

//                entity.ToTable("PayQwik_Registration_Mobile");

//                entity.Property(e => e.FkAccountHolderId)
//                    .HasColumnName("FK_Account_Holder_ID")
//                    .ValueGeneratedNever();

//                entity.Property(e => e.BrmMobileOtp)
//                    .IsRequired()
//                    .HasColumnName("BRM_Mobile_OTP")
//                    .HasMaxLength(15);

//                entity.Property(e => e.BrmReqReceivingTime)
//                    .HasColumnName("BRM_Req_receiving_time")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Gender).HasMaxLength(10);

//                entity.Property(e => e.IsKycDone).HasColumnName("IsKYC_Done");

//                entity.Property(e => e.IsProfileActive).HasColumnName("IsProfile_Active");

//                entity.Property(e => e.MachineId)
//                    .HasColumnName("Machine_Id")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.RewardPoints)
//                    .HasColumnName("Reward_Points")
//                    .HasDefaultValueSql("((0))");
//            });

//            modelBuilder.Entity<PayQwikRequestXml>(entity =>
//            {
//                entity.HasKey(e => e.PayQwikRequestId);

//                entity.ToTable("PayQwik_Request_XML");

//                entity.Property(e => e.PayQwikRequestId).HasColumnName("PayQwik_Request_Id");

//                entity.Property(e => e.AccountHolderMobileNo).HasColumnName("Account_Holder_MobileNo");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.MachineId)
//                    .HasColumnName("MachineID")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.RequestXml)
//                    .HasColumnName("Request_XML")
//                    .IsUnicode(false);

//                entity.Property(e => e.TransactionType)
//                    .HasColumnName("Transaction_Type")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<PayQwikResponseMessage>(entity =>
//            {
//                entity.HasKey(e => e.PayQwikResponseId);

//                entity.ToTable("PayQwik_Response_Message");

//                entity.Property(e => e.PayQwikResponseId).HasColumnName("PayQwik_Response_Id");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.FkPayQwikRequestId).HasColumnName("FK_PayQwik_Request_Id");

//                entity.Property(e => e.Response).IsUnicode(false);

//                entity.HasOne(d => d.FkPayQwikRequest)
//                    .WithMany(p => p.PayQwikResponseMessage)
//                    .HasForeignKey(d => d.FkPayQwikRequestId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_PayQwik_Response_Message_PayQwik_Request_XML");
//            });

//            modelBuilder.Entity<PayQwikUnregisteredFundTransfers>(entity =>
//            {
//                entity.HasKey(e => e.PkTransactionId);

//                entity.ToTable("PayQwik_Unregistered_FundTransfers");

//                entity.Property(e => e.PkTransactionId)
//                    .HasColumnName("PK_Transaction_ID")
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.Amount).HasColumnType("decimal(8, 2)");

//                entity.Property(e => e.FromAccountHolderId)
//                    .IsRequired()
//                    .HasColumnName("From_Account_Holder_ID")
//                    .HasMaxLength(10);

//                entity.Property(e => e.Status)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.TempToAccountNo)
//                    .HasColumnName("Temp_To_Account_No")
//                    .ValueGeneratedOnAdd();

//                entity.Property(e => e.ToMobileNumber)
//                    .IsRequired()
//                    .HasColumnName("To_MobileNumber")
//                    .HasMaxLength(15);

//                entity.Property(e => e.TrnDate)
//                    .HasColumnName("Trn_Date")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.TrnState).HasColumnName("Trn_State");
//            });

//            modelBuilder.Entity<Pictures>(entity =>
//            {
//                entity.HasKey(e => e.PictureName);

//                entity.Property(e => e.PictureName)
//                    .HasColumnName("pictureName")
//                    .HasMaxLength(40)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.PicFileName)
//                    .HasColumnName("picFileName")
//                    .HasMaxLength(100);
//            });

//            modelBuilder.Entity<PosAuthenticationType>(entity =>
//            {
//                entity.ToTable("POS_AuthenticationType");

//                entity.Property(e => e.PosAuthenticationTypeId).HasColumnName("POS_AuthenticationType_ID");

//                entity.Property(e => e.PosAuthenticationTypeName)
//                    .IsRequired()
//                    .HasColumnName("POS_AuthenticationType_Name")
//                    .HasMaxLength(50);
//            });

//            modelBuilder.Entity<PostingStatusType>(entity =>
//            {
//                entity.Property(e => e.PostingStatusTypeId)
//                    .HasColumnName("PostingStatusType_ID")
//                    .ValueGeneratedOnAdd();

//                entity.Property(e => e.PostingStatusTypeName)
//                    .IsRequired()
//                    .HasColumnName("PostingStatusType_Name")
//                    .HasMaxLength(100);
//            });

//            modelBuilder.Entity<RechargeModeType>(entity =>
//            {
//                entity.Property(e => e.RechargeModeTypeId)
//                    .HasColumnName("RechargeModeType_ID")
//                    .ValueGeneratedOnAdd();

//                entity.Property(e => e.RechargeModeTypeName)
//                    .IsRequired()
//                    .HasColumnName("RechargeModeType_Name")
//                    .HasMaxLength(100);
//            });

//            modelBuilder.Entity<Resources>(entity =>
//            {
//                entity.HasKey(e => e.ResourceId);

//                entity.Property(e => e.ResourceId)
//                    .HasColumnName("Resource_ID")
//                    .ValueGeneratedNever();

//                entity.Property(e => e.FkParentResourceId).HasColumnName("FK_Parent_Resource_ID");

//                entity.Property(e => e.FkResourceTypeId).HasColumnName("FK_Resource_Type_ID");

//                entity.Property(e => e.ResourceDisplayName)
//                    .IsRequired()
//                    .HasColumnName("Resource_Display_Name")
//                    .HasMaxLength(100);

//                entity.Property(e => e.ResourceMenuItemId).HasColumnName("Resource_MenuItem_ID");

//                entity.Property(e => e.ResourceName)
//                    .IsRequired()
//                    .HasColumnName("Resource_Name")
//                    .HasMaxLength(100);

//                entity.Property(e => e.ResourcePageName)
//                    .HasColumnName("Resource_Page_Name")
//                    .HasMaxLength(100);

//                entity.HasOne(d => d.FkParentResource)
//                    .WithMany(p => p.InverseFkParentResource)
//                    .HasForeignKey(d => d.FkParentResourceId)
//                    .HasConstraintName("FK_Resources_Resources");
//            });

//            modelBuilder.Entity<ResourcesMvc>(entity =>
//            {
//                entity.ToTable("Resources_MVC");

//                entity.Property(e => e.Action)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Controller)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.DisplayName)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.FkPresourceId).HasColumnName("FK_PResourceID");

//                entity.Property(e => e.FkRoleId).HasColumnName("FK_RoleID");

//                entity.Property(e => e.IsActive)
//                    .HasColumnName("isActive")
//                    .HasDefaultValueSql("('1')");

//                entity.HasOne(d => d.FkPresource)
//                    .WithMany(p => p.InverseFkPresource)
//                    .HasForeignKey(d => d.FkPresourceId)
//                    .HasConstraintName("FK__Resources__FK_PR__2C7A9F12");

//                entity.HasOne(d => d.FkRole)
//                    .WithMany(p => p.ResourcesMvc)
//                    .HasForeignKey(d => d.FkRoleId)
//                    .HasConstraintName("FK__Resources__FK_Ro__2D6EC34B");
//            });

//            modelBuilder.Entity<ResourcesNew>(entity =>
//            {
//                entity.HasKey(e => e.ResourceId);

//                entity.ToTable("Resources_New");

//                entity.Property(e => e.ResourceId).HasColumnName("Resource_ID");

//                entity.Property(e => e.FkParentResourceId).HasColumnName("FK_Parent_Resource_ID");

//                entity.Property(e => e.FkResourceTypeId).HasColumnName("FK_Resource_Type_ID");

//                entity.Property(e => e.ResourceDisplayName)
//                    .IsRequired()
//                    .HasColumnName("Resource_Display_Name")
//                    .HasMaxLength(100);

//                entity.Property(e => e.ResourceMenuItemId).HasColumnName("Resource_MenuItem_ID");

//                entity.Property(e => e.ResourceName)
//                    .IsRequired()
//                    .HasColumnName("Resource_Name")
//                    .HasMaxLength(100);

//                entity.Property(e => e.ResourcePageName)
//                    .HasColumnName("Resource_Page_Name")
//                    .HasMaxLength(100);
//            });

//            modelBuilder.Entity<ResourcesTemp>(entity =>
//            {
//                entity.HasKey(e => e.ResourceIdTemp);

//                entity.ToTable("Resources_Temp");

//                entity.Property(e => e.ResourceIdTemp).HasColumnName("Resource_ID_Temp");

//                entity.Property(e => e.FkParentResourceIdTemp).HasColumnName("FK_Parent_Resource_ID_Temp");

//                entity.Property(e => e.FkResourceTypeIdTemp).HasColumnName("FK_Resource_Type_ID_Temp");

//                entity.Property(e => e.ResourceDisplayNameTemp)
//                    .IsRequired()
//                    .HasColumnName("Resource_Display_Name_Temp")
//                    .HasMaxLength(100);

//                entity.Property(e => e.ResourceMenuItemIdTemp).HasColumnName("Resource_MenuItem_ID_Temp");

//                entity.Property(e => e.ResourceNameTemp)
//                    .IsRequired()
//                    .HasColumnName("Resource_Name_Temp")
//                    .HasMaxLength(100);

//                entity.Property(e => e.ResourcePageNameTemp)
//                    .HasColumnName("Resource_Page_Name_Temp")
//                    .HasMaxLength(100);

//                entity.HasOne(d => d.FkParentResourceIdTempNavigation)
//                    .WithMany(p => p.InverseFkParentResourceIdTempNavigation)
//                    .HasForeignKey(d => d.FkParentResourceIdTemp)
//                    .HasConstraintName("FK_Resources_Resources_Temp");
//            });

//            modelBuilder.Entity<ResourceTypes>(entity =>
//            {
//                entity.ToTable("Resource_Types");

//                entity.Property(e => e.ResourceTypesId)
//                    .HasColumnName("Resource_Types_ID")
//                    .ValueGeneratedNever();

//                entity.Property(e => e.ResourseTypeName)
//                    .IsRequired()
//                    .HasColumnName("Resourse_Type_Name")
//                    .HasMaxLength(100);
//            });

//            modelBuilder.Entity<RewardsConfig>(entity =>
//            {
//                entity.Property(e => e.Id).HasColumnName("ID");

//                entity.Property(e => e.ConfigRewardPoints).HasColumnName("Config_RewardPoints");

//                entity.Property(e => e.ConfigRewardPointsValue).HasColumnName("Config_RewardPoints_Value");

//                entity.Property(e => e.EntiyId).HasColumnName("EntiyID");

//                entity.Property(e => e.RewardPointsMinumumTransactionAmount).HasColumnName("RewardPoints_Minumum_Transaction_Amount");
//            });

//            modelBuilder.Entity<RoleFeatures>(entity =>
//            {
//                entity.Property(e => e.FkFeatureId).HasColumnName("Fk_FeatureId");

//                entity.Property(e => e.FkRoleId).HasColumnName("FK_RoleId");

//                entity.Property(e => e.IsEnabled).HasColumnName("Is_Enabled");
//            });

//            modelBuilder.Entity<Roles>(entity =>
//            {
//                entity.HasKey(e => e.RoleId);

//                entity.Property(e => e.RoleId).HasColumnName("Role_ID");

//                entity.Property(e => e.FkRoleEntityId).HasColumnName("FK_Role_Entity_ID");

//                entity.Property(e => e.FkRoleGroupId).HasColumnName("FK_Role_Group_ID");

//                entity.Property(e => e.FkRoleUserType).HasColumnName("FK_Role_User_Type");

//                entity.Property(e => e.RoleName)
//                    .IsRequired()
//                    .HasColumnName("Role_Name")
//                    .HasMaxLength(100);
//            });

//            modelBuilder.Entity<RolesResources>(entity =>
//            {
//                entity.HasKey(e => e.RoleResourceId);

//                entity.ToTable("Roles_Resources");

//                entity.Property(e => e.RoleResourceId).HasColumnName("Role_Resource_ID");

//                entity.Property(e => e.FkRoleResourceResourceId).HasColumnName("FK_Role_Resource_Resource_ID");

//                entity.Property(e => e.FkRoleResourceRoleId).HasColumnName("FK_Role_Resource_Role_ID");

//                entity.Property(e => e.RoleResourceIsAssigned).HasColumnName("Role_Resource_IsAssigned");

//                entity.HasOne(d => d.FkRoleResourceResource)
//                    .WithMany(p => p.RolesResources)
//                    .HasForeignKey(d => d.FkRoleResourceResourceId)
//                    .HasConstraintName("FK_Roles_Resources_Resources");
//            });

//            modelBuilder.Entity<SemiC3AadhaarWalletInfo>(entity =>
//            {
//                entity.HasKey(e => e.RegId);

//                entity.ToTable("SemiC3_AadhaarWallet_Info");

//                entity.HasIndex(e => new { e.EntityId, e.Uid })
//                    .HasName("IX_SemiC3_AadhaarWallet_Info_UID");

//                entity.Property(e => e.RegId).HasColumnName("RegID");

//                entity.Property(e => e.Aadhaarhash).HasColumnName("AADHAARHASH");

//                entity.Property(e => e.EntityId).HasColumnName("EntityID");

//                entity.Property(e => e.Ifsc)
//                    .HasColumnName("IFSC")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Mmid)
//                    .HasColumnName("MMID")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.RegistrationDate)
//                    .HasColumnType("date")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.TempAadhaar)
//                    .HasColumnName("TempAADHAAR")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Uid)
//                    .HasColumnName("UID")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Uidtoken)
//                    .HasColumnName("UIDToken")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.VirtualAccoutNumber)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<SemiC3Campaigns>(entity =>
//            {
//                entity.HasKey(e => e.PqCampaignId);

//                entity.ToTable("SemiC3_Campaigns");

//                entity.Property(e => e.PqCampaignId).HasColumnName("PQ_Campaign_Id");

//                entity.Property(e => e.CampaignCode)
//                    .HasColumnName("Campaign_Code")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.CampaignName)
//                    .HasColumnName("Campaign_Name")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.CouponAmount)
//                    .HasColumnName("Coupon_Amount")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.CouponCode)
//                    .HasColumnName("Coupon_Code")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.EndDate).HasColumnType("datetime");

//                entity.Property(e => e.FkEntityId).HasColumnName("Fk_Entity_ID");

//                entity.Property(e => e.StartDate).HasColumnType("datetime");

//                entity.Property(e => e.TargetAmount)
//                    .HasColumnName("Target_Amount")
//                    .HasColumnType("decimal(10, 2)");
//            });

//            modelBuilder.Entity<SemiC3config>(entity =>
//            {
//                entity.ToTable("SemiC3Config");

//                entity.Property(e => e.Id).HasColumnName("ID");

//                entity.Property(e => e.FkEntityId).HasColumnName("Fk_EntityID");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.Value)
//                    .IsRequired()
//                    .HasMaxLength(200)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<SemiC3CouponsIssued>(entity =>
//            {
//                entity.HasKey(e => e.PqCouponId);

//                entity.ToTable("SemiC3_Coupons_Issued");

//                entity.Property(e => e.PqCouponId).HasColumnName("PQ_Coupon_Id");

//                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.CouponCode)
//                    .HasColumnName("Coupon_Code")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

//                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

//                entity.Property(e => e.FkAccountHolderId).HasColumnName("FK_Account_Holder_Id");

//                entity.Property(e => e.MobileNumber)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.RedemptionDate).HasColumnType("datetime");
//            });

//            modelBuilder.Entity<SemiC3FeeCollectionInstitute>(entity =>
//            {
//                entity.HasKey(e => e.PkId);

//                entity.ToTable("SemiC3_Fee_Collection_Institute");

//                entity.Property(e => e.PkId).HasColumnName("PK_ID");

//                entity.Property(e => e.Address).HasMaxLength(500);

//                entity.Property(e => e.InstituteName)
//                    .HasColumnName("institute_name")
//                    .HasMaxLength(100);

//                entity.Property(e => e.MerchantId)
//                    .HasColumnName("merchant_ID")
//                    .HasMaxLength(100);
//            });

//            modelBuilder.Entity<SemiC3FeeCollectionTypes>(entity =>
//            {
//                entity.HasKey(e => e.PkFeeId);

//                entity.ToTable("SemiC3_Fee_Collection_Types");

//                entity.Property(e => e.PkFeeId).HasColumnName("PK_Fee_ID");

//                entity.Property(e => e.FeeType)
//                    .HasColumnName("Fee_Type")
//                    .HasMaxLength(500);
//            });

//            modelBuilder.Entity<SemiC3GatewayRequestXml>(entity =>
//            {
//                entity.HasKey(e => e.SemiC3RequestId);

//                entity.ToTable("SemiC3_Gateway_Request_XML");

//                entity.Property(e => e.SemiC3RequestId).HasColumnName("SemiC3_Request_Id");

//                entity.Property(e => e.AccountHolderMobileNo).HasColumnName("Account_Holder_MobileNo");

//                entity.Property(e => e.AchId).HasColumnName("Ach_ID");

//                entity.Property(e => e.CenterId)
//                    .HasColumnName("CenterID")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.DecryptedGatewayRequestXml)
//                    .HasColumnName("Decrypted_Gateway_Request_XML")
//                    .IsUnicode(false);

//                entity.Property(e => e.EncryptedGatewayRequestXml)
//                    .HasColumnName("Encrypted_Gateway_Request_XML")
//                    .IsUnicode(false);

//                entity.Property(e => e.FkEntityId).HasColumnName("FK_Entity_ID");

//                entity.Property(e => e.MachineId)
//                    .HasColumnName("MachineID")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.ReqId).HasColumnName("ReqID");

//                entity.Property(e => e.TransactionType)
//                    .HasColumnName("Transaction_Type")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<SemiC3GatewayResponseMessage>(entity =>
//            {
//                entity.HasKey(e => e.SemiC3ResponseId);

//                entity.ToTable("SemiC3_Gateway_Response_Message");

//                entity.Property(e => e.SemiC3ResponseId).HasColumnName("SemiC3_Response_Id");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.FkSemiC3RequestId).HasColumnName("FK_SemiC3_Request_Id");

//                entity.Property(e => e.Response).IsUnicode(false);
//            });

//            modelBuilder.Entity<SemiC3HmwssbMisTransactions>(entity =>
//            {
//                entity.HasKey(e => e.TransactionId);

//                entity.ToTable("SemiC3_HMWSSB_MIS_Transactions");

//                entity.Property(e => e.TransactionId)
//                    .HasMaxLength(299)
//                    .IsUnicode(false)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.AcknowledgementNo)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Can)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.InsertedDatetime)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.InstrumentDate)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.InstrumentIssuerName)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.InstrumentNo)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.ModeOfPayment)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.PostedDate)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Reconciled).HasDefaultValueSql("('0')");

//                entity.Property(e => e.TransDate)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.TransactionAmount)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<SemiC3ImpsWalletwiseRequestlog>(entity =>
//            {
//                entity.ToTable("SemiC3_Imps_Walletwise_Requestlog");

//                entity.Property(e => e.Id).HasColumnName("ID");

//                entity.Property(e => e.AuthorizedBy)
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.AuthorizedDate).HasColumnType("date");

//                entity.Property(e => e.Date).HasColumnType("date");

//                entity.Property(e => e.Day)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.RequestedBy)
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.RequestedDate).HasColumnType("date");

//                entity.Property(e => e.Status)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.TawalletBatchLimit).HasColumnName("TAWalletBatchLimit");

//                entity.Property(e => e.TwalletBatchLimit).HasColumnName("TWalletBatchLimit");
//            });

//            modelBuilder.Entity<SemiC3languageKeyWords20052017>(entity =>
//            {
//                entity.ToTable("SemiC3LanguageKeyWords_20052017");

//                entity.Property(e => e.KeywordName).HasMaxLength(50);

//                entity.Property(e => e.LanguageCode)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.PageName)
//                    .HasMaxLength(250)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<SemiC3languageKeyWordsIos02may2017>(entity =>
//            {
//                entity.HasKey(e => e.KeywordName);

//                entity.ToTable("SemiC3LanguageKeyWords_IOS_02MAY2017");

//                entity.Property(e => e.KeywordName)
//                    .HasMaxLength(100)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.Id)
//                    .HasColumnName("ID")
//                    .ValueGeneratedOnAdd();

//                entity.Property(e => e.KeywordValueEnglish).HasColumnName("KeywordValue_English");

//                entity.Property(e => e.KeywordValueHindi).HasColumnName("KeywordValue_Hindi");

//                entity.Property(e => e.KeywordValueKannada).HasColumnName("KeywordValue_Kannada");

//                entity.Property(e => e.KeywordValueTelugu).HasColumnName("KeywordValue_Telugu");

//                entity.Property(e => e.KeywordValueUrdu).HasColumnName("KeywordValue_Urdu");
//            });

//            modelBuilder.Entity<SemiC3languageKeyWordsTa>(entity =>
//            {
//                entity.ToTable("SemiC3LanguageKeyWords_TA");

//                entity.Property(e => e.KeywordName).HasMaxLength(50);

//                entity.Property(e => e.LanguageCode)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.PageName)
//                    .HasMaxLength(250)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<SemiC3PointsInfoMaster>(entity =>
//            {
//                entity.HasKey(e => e.InfoId);

//                entity.ToTable("SemiC3_PointsInfo_Master");

//                entity.Property(e => e.InfoId).HasColumnName("Info_ID");

//                entity.Property(e => e.FkAccountHolderId).HasColumnName("FK_Account_Holder_Id");

//                entity.Property(e => e.LastUpdatedOn)
//                    .HasColumnName("Last_UpdatedOn")
//                    .HasColumnType("date");

//                entity.Property(e => e.LoyaltyPoints).HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.RewardPoints)
//                    .HasColumnType("decimal(10, 2)")
//                    .HasDefaultValueSql("((0))");

//                entity.Property(e => e.TotalRewardPoints).HasColumnType("decimal(10, 2)");
//            });

//            modelBuilder.Entity<SemiC3RequestUpiXml>(entity =>
//            {
//                entity.HasKey(e => e.SemiC3RequestUpiId);

//                entity.ToTable("SemiC3_Request_UPI_XML");

//                entity.Property(e => e.SemiC3RequestUpiId).HasColumnName("SemiC3_Request_UPI_Id");

//                entity.Property(e => e.AccountHolderMobileNo).HasColumnName("Account_Holder_MobileNo");

//                entity.Property(e => e.AchId).HasColumnName("Ach_ID");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.FkEntityId).HasColumnName("FK_Entity_ID");

//                entity.Property(e => e.MachineId)
//                    .HasColumnName("MachineID")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.Platform)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.ReqId).HasColumnName("ReqID");

//                entity.Property(e => e.RequestXml)
//                    .HasColumnName("Request_XML")
//                    .IsUnicode(false);

//                entity.Property(e => e.TransactionType)
//                    .HasColumnName("Transaction_Type")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<SemiC3RequestXml>(entity =>
//            {
//                entity.HasKey(e => e.SemiC3RequestId);

//                entity.ToTable("SemiC3_Request_XML");

//                entity.HasIndex(e => new { e.AccountHolderMobileNo, e.MachineId, e.RequestXml, e.FkEntityId })
//                    .HasName("IX_SemiC3_Request_XML_FK_Entity_ID");

//                entity.HasIndex(e => new { e.MachineId, e.RequestXml, e.AccountHolderMobileNo, e.FkEntityId })
//                    .HasName("IX_SemiC3_Request_XML_Account_Holder_MobileNo_FK_Entity_ID");

//                entity.Property(e => e.SemiC3RequestId).HasColumnName("SemiC3_Request_Id");

//                entity.Property(e => e.AccountHolderMobileNo).HasColumnName("Account_Holder_MobileNo");

//                entity.Property(e => e.AchId)
//                    .HasColumnName("Ach_ID")
//                    .HasMaxLength(12)
//                    .IsUnicode(false);

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.FkEntityId).HasColumnName("FK_Entity_ID");

//                entity.Property(e => e.MachineId)
//                    .HasColumnName("MachineID")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.RequestFrom)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RequestXml)
//                    .HasColumnName("Request_XML")
//                    .HasColumnType("varchar(max)");

//                entity.Property(e => e.ServerName)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.TransactionType)
//                    .HasColumnName("Transaction_Type")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<SemiC3RequestXmlOld1>(entity =>
//            {
//                entity.HasKey(e => e.SemiC3RequestId);

//                entity.ToTable("SemiC3_Request_XML_Old1");

//                entity.Property(e => e.SemiC3RequestId).HasColumnName("SemiC3_Request_Id");

//                entity.Property(e => e.AccountHolderMobileNo).HasColumnName("Account_Holder_MobileNo");

//                entity.Property(e => e.AchId)
//                    .HasColumnName("Ach_ID")
//                    .HasMaxLength(12)
//                    .IsUnicode(false);

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.FkEntityId).HasColumnName("FK_Entity_ID");

//                entity.Property(e => e.MachineId)
//                    .HasColumnName("MachineID")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.RequestFrom)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RequestXml)
//                    .HasColumnName("Request_XML")
//                    .IsUnicode(false);

//                entity.Property(e => e.ServerName)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.TransactionType)
//                    .HasColumnName("Transaction_Type")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<SemiC3ResponseUpiMessage>(entity =>
//            {
//                entity.HasKey(e => e.SemiC3ResponseUpiId);

//                entity.ToTable("SemiC3_Response_UPI_Message");

//                entity.Property(e => e.SemiC3ResponseUpiId).HasColumnName("SemiC3_Response_UPI_Id");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.FkSemiC3RequestId).HasColumnName("FK_SemiC3_Request_Id");
//            });

//            modelBuilder.Entity<SemiC3RewardPointsInfo>(entity =>
//            {
//                entity.ToTable("SemiC3_RewardPoints_Info");

//                entity.Property(e => e.Id).HasColumnName("ID");

//                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

//                entity.Property(e => e.FkAccountHolderId).HasColumnName("FK_Account_Holder_Id");

//                entity.Property(e => e.FkEntityId).HasColumnName("FK_EntityID");

//                entity.Property(e => e.FkTrxnAmount)
//                    .HasColumnName("FK_TRXN_Amount")
//                    .HasColumnType("decimal(10, 2)")
//                    .HasDefaultValueSql("((0.00))");

//                entity.Property(e => e.FkTrxnUniqueId)
//                    .IsRequired()
//                    .HasColumnName("FK_TRXN_UniqueID")
//                    .HasMaxLength(100);

//                entity.Property(e => e.IssuedDate).HasColumnType("datetime");

//                entity.Property(e => e.ReversedDate).HasColumnType("date");

//                entity.Property(e => e.RewardPoints).HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.Status)
//                    .IsRequired()
//                    .HasMaxLength(10)
//                    .HasDefaultValueSql("(N'Issued')");

//                entity.HasOne(d => d.FkEntity)
//                    .WithMany(p => p.SemiC3RewardPointsInfo)
//                    .HasForeignKey(d => d.FkEntityId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_SemiC3_RewardPoints_Info_Account_Holder");
//            });

//            modelBuilder.Entity<SemiC3ShgwalletInfo>(entity =>
//            {
//                entity.HasKey(e => e.RegId);

//                entity.ToTable("SemiC3_SHGWallet_Info");

//                entity.Property(e => e.RegId).HasColumnName("RegID");

//                entity.Property(e => e.Aadhaar1)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Aadhaar2)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Aadhaarhash1).HasColumnName("AADHAARHASH1");

//                entity.Property(e => e.Aadhaarhash2).HasColumnName("AADHAARHASH2");

//                entity.Property(e => e.EntityId).HasColumnName("EntityID");

//                entity.Property(e => e.RegistrationDate)
//                    .HasColumnType("date")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.Shgid)
//                    .HasColumnName("SHGID")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.TempAadhaar1)
//                    .HasColumnName("TempAADHAAR1")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.TempAadhaar2)
//                    .HasColumnName("TempAADHAAR2")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Uid1token)
//                    .HasColumnName("UID1Token")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Uid2token)
//                    .HasColumnName("UID2Token")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.VirtualAccoutNumber)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Void)
//                    .HasColumnName("VOID")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<SemiC3SmsLogs>(entity =>
//            {
//                entity.ToTable("SemiC3_SMS_Logs");

//                entity.Property(e => e.Id).HasColumnName("ID");

//                entity.Property(e => e.AccountHolderMobileNo)
//                    .HasColumnName("Account_Holder_MobileNo")
//                    .HasMaxLength(12);

//                entity.Property(e => e.LogDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.Message).HasMaxLength(500);

//                entity.Property(e => e.RequestType).HasMaxLength(50);

//                entity.Property(e => e.SmsStatus).HasColumnName("SMS_Status");

//                entity.Property(e => e.StatusCode).HasMaxLength(50);

//                entity.Property(e => e.StatusDescription).HasMaxLength(50);
//            });

//            modelBuilder.Entity<SemiC3TaDevelopers>(entity =>
//            {
//                entity.ToTable("SemiC3_TA_Developers");

//                entity.Property(e => e.Id).HasColumnName("ID");

//                entity.Property(e => e.AlternateEmail)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.DeveloperName)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.DeveloperType)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.EmployeeId)
//                    .HasColumnName("EmployeeID")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.InsertedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.IsActive).HasDefaultValueSql("('1')");

//                entity.Property(e => e.IsReviewee).HasDefaultValueSql("('0')");

//                entity.Property(e => e.OfficeEmail)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<SemiC3TaProjects>(entity =>
//            {
//                entity.ToTable("SemiC3_TA_Projects");

//                entity.Property(e => e.Id).HasColumnName("ID");

//                entity.Property(e => e.Application)
//                    .HasMaxLength(2999)
//                    .IsUnicode(false);

//                entity.Property(e => e.CreatedBy)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.CreatedDate).HasColumnType("date");

//                entity.Property(e => e.InsertedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.IsActive).HasDefaultValueSql("('1')");

//                entity.Property(e => e.ProjectName)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.ProjectType)
//                    .HasMaxLength(2999)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<SemiC3TaProjectsSubCategory>(entity =>
//            {
//                entity.ToTable("SemiC3_TA_Projects_SubCategory");

//                entity.Property(e => e.Id).HasColumnName("ID");

//                entity.Property(e => e.CreatedBy)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.InsertedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.IsActive).HasDefaultValueSql("('1')");

//                entity.Property(e => e.SubCategoryName)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<SemiC3UnregisteredFundTransfers>(entity =>
//            {
//                entity.HasKey(e => e.PkTransactionId);

//                entity.ToTable("SemiC3_Unregistered_FundTransfers");

//                entity.Property(e => e.PkTransactionId)
//                    .HasColumnName("PK_Transaction_ID")
//                    .HasMaxLength(20)
//                    .IsUnicode(false)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.Amount).HasColumnType("decimal(8, 2)");

//                entity.Property(e => e.ExternalSystem).HasDefaultValueSql("('False')");

//                entity.Property(e => e.FkEntityId).HasColumnName("FK_Entity_ID");

//                entity.Property(e => e.FromAccountHolderId)
//                    .IsRequired()
//                    .HasColumnName("From_Account_Holder_ID")
//                    .HasMaxLength(10);

//                entity.Property(e => e.Status)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.TempToAccountNo)
//                    .HasColumnName("Temp_To_Account_No")
//                    .ValueGeneratedOnAdd();

//                entity.Property(e => e.ToMobileNumber)
//                    .IsRequired()
//                    .HasColumnName("To_MobileNumber")
//                    .HasMaxLength(15);

//                entity.Property(e => e.TrnDate)
//                    .HasColumnName("Trn_Date")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.TrnState).HasColumnName("Trn_State");
//            });

//            modelBuilder.Entity<SemiC3UpiTrxnDetails>(entity =>
//            {
//                entity.HasKey(e => e.RequestId);

//                entity.ToTable("SemiC3_UPI_TrxnDetails");

//                entity.HasIndex(e => e.MsgId)
//                    .HasName("IX_SemiC3_UPI_TrxnDetails_MsgID1");

//                entity.HasIndex(e => new { e.AccountHolderId, e.TrxnStatus });

//                entity.HasIndex(e => new { e.Channel, e.MsgId })
//                    .HasName("IX_SemiC3_UPI_TrxnDetails_MsgID3");

//                entity.HasIndex(e => new { e.UpiActualResponse, e.TrxnDateTime })
//                    .HasName("IX_SemiC3_UPI_TrxnDetails_TrxnDateTime");

//                entity.HasIndex(e => new { e.RequestId, e.TrxnDateTime, e.TrxnStatus })
//                    .HasName("IX_SemiC3_UPI_TrxnDetails_TrxnDateTime_TrxnStatus");

//                entity.HasIndex(e => new { e.MobileNumber, e.EntityId, e.Amount, e.MsgId })
//                    .HasName("IX_SemiC3_UPI_TrxnDetails_MsgID2");

//                entity.HasIndex(e => new { e.EntityId, e.Amount, e.MobileNumber, e.TrxnDateTime, e.TrxnStatus })
//                    .HasName("IX_SemiC3_UPI_TrxnDetails_MobileNumber_TrxnDateTime_TrxnStatus");

//                entity.Property(e => e.RequestId).HasColumnName("RequestID");

//                entity.Property(e => e.AccountHolderId).HasColumnName("AccountHolderID");

//                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.AvailableFundingLimit).HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.Bt).HasColumnName("BT");

//                entity.Property(e => e.Channel)
//                    .HasMaxLength(299)
//                    .IsUnicode(false)
//                    .HasDefaultValueSql("('VIJAYABANK_UPIChannel')");

//                entity.Property(e => e.CollectMoneyRrn)
//                    .HasColumnName("CollectMoneyRRN")
//                    .HasMaxLength(15)
//                    .IsUnicode(false);

//                entity.Property(e => e.CurrentBalance).HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.CustomerLocationDetails)
//                    .HasMaxLength(2999)
//                    .IsUnicode(false);

//                entity.Property(e => e.EntityId).HasColumnName("EntityID");

//                entity.Property(e => e.MachineId)
//                    .HasColumnName("MachineID")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerchantId)
//                    .HasColumnName("MerchantID")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.MobileNumber)
//                    .HasMaxLength(12)
//                    .IsUnicode(false);

//                entity.Property(e => e.MsgId)
//                    .HasColumnName("MsgID")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.OrderId)
//                    .HasColumnName("OrderID")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.PayerName)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Remarks)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Request)
//                    .HasMaxLength(2999)
//                    .IsUnicode(false);

//                entity.Property(e => e.SessionId).HasColumnName("SessionID");

//                entity.Property(e => e.TerminalId)
//                    .HasColumnName("TerminalID")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.TrxnAuthDate).HasColumnType("datetime");

//                entity.Property(e => e.TrxnDateTime)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.TrxnStatus)
//                    .HasMaxLength(299)
//                    .IsUnicode(false)
//                    .HasDefaultValueSql("('Processed')");

//                entity.Property(e => e.TrxnUniqueId)
//                    .HasColumnName("TrxnUniqueID")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpiActualResponse)
//                    .HasColumnName("UPI_Actual_response")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpiResponseCode)
//                    .HasColumnName("UPI_ResponseCode")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpiTrxnId)
//                    .HasColumnName("UPI_TrxnID")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpiTrxnRrn)
//                    .HasColumnName("UPI_Trxn_RRN")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.Vpaid)
//                    .HasColumnName("VPAID")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<SemiC3UpiTrxnDetails201802091136>(entity =>
//            {
//                entity.HasKey(e => e.RequestId);

//                entity.ToTable("SemiC3_UPI_TrxnDetails_201802091136");

//                entity.Property(e => e.RequestId).HasColumnName("RequestID");

//                entity.Property(e => e.AccountHolderId).HasColumnName("AccountHolderID");

//                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.AvailableFundingLimit).HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.Bt).HasColumnName("BT");

//                entity.Property(e => e.CollectMoneyRrn)
//                    .HasColumnName("CollectMoneyRRN")
//                    .HasMaxLength(15)
//                    .IsUnicode(false);

//                entity.Property(e => e.CurrentBalance).HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.EntityId).HasColumnName("EntityID");

//                entity.Property(e => e.MachineId)
//                    .HasColumnName("MachineID")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerchantId)
//                    .HasColumnName("MerchantID")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.MobileNumber)
//                    .HasMaxLength(12)
//                    .IsUnicode(false);

//                entity.Property(e => e.OrderId)
//                    .HasColumnName("OrderID")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.PayeeMobileNumber)
//                    .HasMaxLength(15)
//                    .IsUnicode(false);

//                entity.Property(e => e.PayerVpaid)
//                    .HasColumnName("PayerVPAID")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.Remarks)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Request)
//                    .HasMaxLength(2999)
//                    .IsUnicode(false);

//                entity.Property(e => e.SessionId).HasColumnName("SessionID");

//                entity.Property(e => e.TerminalId)
//                    .HasColumnName("TerminalID")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.TrxnDateTime)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.TrxnStatus)
//                    .HasMaxLength(299)
//                    .IsUnicode(false)
//                    .HasDefaultValueSql("('Processed')");

//                entity.Property(e => e.TrxnUniqueId)
//                    .HasColumnName("TrxnUniqueID")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpiActualResponse)
//                    .HasColumnName("UPI_Actual_response")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpiResponseCode)
//                    .HasColumnName("UPI_ResponseCode")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.UpiorderId)
//                    .HasColumnName("UPIOrderID")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.Vpaid)
//                    .HasColumnName("VPAID")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<SemiC3WalletsPaymentGatewayRequestsLog>(entity =>
//            {
//                entity.ToTable("SemiC3_Wallets_PaymentGateway_RequestsLog");

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.AgencyCode).HasColumnName("Agency_Code");

//                entity.Property(e => e.DecXml)
//                    .HasColumnName("Dec_Xml")
//                    .IsUnicode(false);

//                entity.Property(e => e.EncXml)
//                    .HasColumnName("Enc_XML")
//                    .IsUnicode(false);

//                entity.Property(e => e.RequestedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");
//            });

//            modelBuilder.Entity<ServiceProviders>(entity =>
//            {
//                entity.HasKey(e => e.ServiceProviderId);

//                entity.ToTable("Service_Providers");

//                entity.Property(e => e.ServiceProviderId).HasColumnName("Service_Provider_ID");

//                entity.Property(e => e.ServiceFee)
//                    .IsRequired()
//                    .HasColumnName("Service_Fee")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.ServiceProviderKey)
//                    .IsRequired()
//                    .HasColumnName("Service_Provider_Key")
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.ServiceProviderName)
//                    .IsRequired()
//                    .HasColumnName("Service_Provider_Name")
//                    .HasMaxLength(1000)
//                    .IsUnicode(false);

//                entity.Property(e => e.ServiceType)
//                    .IsRequired()
//                    .HasColumnName("Service_Type")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<SessionTypes>(entity =>
//            {
//                entity.HasKey(e => e.SessionTypeId);

//                entity.Property(e => e.SessionTypeId)
//                    .HasColumnName("SessionType_ID")
//                    .ValueGeneratedOnAdd();

//                entity.Property(e => e.SessionTypeMessage)
//                    .IsRequired()
//                    .HasColumnName("SessionType_Message");
//            });

//            modelBuilder.Entity<SettlementDetails>(entity =>
//            {
//                entity.ToTable("Settlement_Details");

//                entity.Property(e => e.SettlementDetailsId).HasColumnName("Settlement_Details_ID");

//                entity.Property(e => e.AccountNo)
//                    .IsRequired()
//                    .HasColumnName("ACCOUNT_NO")
//                    .HasMaxLength(20);

//                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

//                entity.Property(e => e.BranchCode)
//                    .IsRequired()
//                    .HasColumnName("BRANCH_CODE")
//                    .HasMaxLength(5);

//                entity.Property(e => e.DtActual)
//                    .HasColumnName("DT_ACTUAL")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.EntityName)
//                    .IsRequired()
//                    .HasMaxLength(100);

//                entity.Property(e => e.FkSettlementId).HasColumnName("FK_SETTLEMENT_ID");

//                entity.Property(e => e.GroupName)
//                    .IsRequired()
//                    .HasMaxLength(2000);

//                entity.Property(e => e.Inr)
//                    .IsRequired()
//                    .HasColumnName("INR")
//                    .HasMaxLength(3)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerchantName)
//                    .IsRequired()
//                    .HasMaxLength(500);

//                entity.Property(e => e.StDescription)
//                    .IsRequired()
//                    .HasColumnName("ST_DESCRIPTION");

//                entity.Property(e => e.TrnxType)
//                    .IsRequired()
//                    .HasColumnName("Trnx_Type")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<SettlementMerchantRequest>(entity =>
//            {
//                entity.HasKey(e => e.RequestId);

//                entity.HasIndex(e => e.AuthorizationStatus);

//                entity.Property(e => e.RequestId).HasColumnName("Request_id");

//                entity.Property(e => e.Aadhaar).IsUnicode(false);

//                entity.Property(e => e.AadhaarNo)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.AddressProof).IsUnicode(false);

//                entity.Property(e => e.Agencyorderid)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.AllowUnRegisteredPayments).HasDefaultValueSql("((0))");

//                entity.Property(e => e.Attachment1).IsUnicode(false);

//                entity.Property(e => e.Attachment2).IsUnicode(false);

//                entity.Property(e => e.AuthorisedDate).HasColumnType("datetime");

//                entity.Property(e => e.BloodGrpTypeId).HasColumnName("BloodGrpTypeID");

//                entity.Property(e => e.CategorizedPayers).HasDefaultValueSql("((0))");

//                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

//                entity.Property(e => e.CenterId)
//                    .HasColumnName("CenterID")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.CourseFeeAmount).HasDefaultValueSql("('0')");

//                entity.Property(e => e.CourseId)
//                    .HasColumnName("CourseID")
//                    .HasDefaultValueSql("((0))");

//                entity.Property(e => e.CreatedBy).HasDefaultValueSql("('5')");

//                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

//                entity.Property(e => e.Dob)
//                    .HasColumnName("DOB")
//                    .HasMaxLength(25)
//                    .IsUnicode(false);

//                entity.Property(e => e.EntityId).HasColumnName("EntityID");

//                entity.Property(e => e.FkUniqueReferenceCode)
//                    .HasColumnName("FK_Unique_Reference_Code")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Gender)
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.HolderHostelId)
//                    .HasColumnName("Holder_Hostel_Id")
//                    .HasDefaultValueSql("((0))");

//                entity.Property(e => e.IsPrefunded).HasColumnName("Is_prefunded");

//                entity.Property(e => e.IsTaconnectMerchant)
//                    .HasColumnName("IsTAConnectMerchant")
//                    .HasDefaultValueSql("((0))");

//                entity.Property(e => e.LoginEnable).HasDefaultValueSql("('1')");

//                entity.Property(e => e.MachineId)
//                    .HasColumnName("MachineID")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerConfigAccountNumber)
//                    .HasColumnName("MerConfig_Account_Number")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerConfigBankName)
//                    .HasColumnName("MerConfig_Bank_Name")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerConfigBranchCode)
//                    .HasColumnName("MerConfig_Branch_Code")
//                    .HasMaxLength(5);

//                entity.Property(e => e.MerConfigBranchName)
//                    .HasColumnName("MerConfig_Branch_Name")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerConfigIfscCode)
//                    .HasColumnName("MerConfig_IFSC_Code")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerConfigNumOfEntityId).HasColumnName("MerConfig_Num_Of_EntityID");

//                entity.Property(e => e.MerchantAddress)
//                    .HasColumnName("Merchant_Address")
//                    .HasMaxLength(2999)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerchantContactPerson)
//                    .HasColumnName("Merchant_contact_Person")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerchantEmailid)
//                    .HasColumnName("Merchant_Emailid")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerchantEnableOffus).HasColumnName("Merchant_Enable_Offus");

//                entity.Property(e => e.MerchantIsPasswordReset).HasColumnName("Merchant_IsPasswordReset");

//                entity.Property(e => e.MerchantLoginid)
//                    .HasColumnName("Merchant_Loginid")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerchantLogo).IsUnicode(false);

//                entity.Property(e => e.MerchantMobileNo)
//                    .HasColumnName("Merchant_MobileNo")
//                    .HasMaxLength(11)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerchantName)
//                    .HasColumnName("Merchant_Name")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerchantPan)
//                    .HasColumnName("Merchant_PAN")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.MerchantPwd).HasColumnName("Merchant_PWD");

//                entity.Property(e => e.MerchantRequestedBy).HasColumnName("Merchant_RequestedBy");

//                entity.Property(e => e.MerchantRequestedon)
//                    .HasColumnName("Merchant_Requestedon")
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.MerchantStatus).HasColumnName("Merchant_Status");

//                entity.Property(e => e.MerchantType).HasDefaultValueSql("('0')");

//                entity.Property(e => e.MobileOtp)
//                    .HasColumnName("MobileOTP")
//                    .HasMaxLength(6)
//                    .IsUnicode(false);

//                entity.Property(e => e.PanAttachment)
//                    .HasColumnName("PAN_Attachment")
//                    .IsUnicode(false);

//                entity.Property(e => e.PdbankAccountHolderName)
//                    .HasColumnName("PDBankAccountHolderName")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.PdbankAccountNo)
//                    .HasColumnName("PDBankAccountNo")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.PdbankIfsc)
//                    .HasColumnName("PDBankIFSC")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.PdbankName)
//                    .HasColumnName("PDBankName")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Photos).IsUnicode(false);

//                entity.Property(e => e.Platform).HasDefaultValueSql("((1))");

//                entity.Property(e => e.Poa)
//                    .HasColumnName("POA")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poadist)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poahouse)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poalm)
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poaloc)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poapc)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poapo)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poastate)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poastreet)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poasubdist)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poatype)
//                    .HasColumnName("POAType")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poavtc)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.PoavtcCode)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poi)
//                    .HasColumnName("POI")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.Poitype)
//                    .HasColumnName("POIType")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.ReferralCode)
//                    .HasMaxLength(12)
//                    .IsUnicode(false);

//                entity.Property(e => e.RegistrationNumber)
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.RejectedDate).HasColumnType("datetime");

//                entity.Property(e => e.Rejectedby)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.RoleId).HasColumnName("RoleID");

//                entity.Property(e => e.Rrn)
//                    .HasColumnName("RRN")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.SendSmsforTxn).HasColumnName("SendSMSForTxn");

//                entity.Property(e => e.WalletTypeId).HasColumnName("WalletTypeID");
//            });

//            modelBuilder.Entity<Settlements>(entity =>
//            {
//                entity.HasKey(e => e.SettlementId);

//                entity.Property(e => e.SettlementId)
//                    .HasColumnName("Settlement_ID")
//                    .ValueGeneratedNever();

//                entity.Property(e => e.FkSettlementUserId).HasColumnName("Fk_Settlement_User_Id");

//                entity.Property(e => e.SettlementCreditAmount).HasColumnName("Settlement_Credit_Amount");

//                entity.Property(e => e.SettlementDate)
//                    .HasColumnName("Settlement_Date")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.SettlementDebitAmount).HasColumnName("Settlement_Debit_Amount");

//                entity.Property(e => e.SettlementFileIsProcessed).HasColumnName("Settlement_File_IsProcessed");

//                entity.Property(e => e.SettlementFileIsSent).HasColumnName("Settlement_File_IsSent");

//                entity.Property(e => e.SettlementFileName)
//                    .IsRequired()
//                    .HasColumnName("Settlement_File_Name")
//                    .HasMaxLength(50);

//                entity.Property(e => e.SettlementFkEntityId).HasColumnName("Settlement_FK_Entity_ID");

//                entity.Property(e => e.SettlementFkGroupId).HasColumnName("Settlement_FK_Group_ID");

//                entity.Property(e => e.SettlementNumberCredits).HasColumnName("Settlement_Number_Credits");

//                entity.Property(e => e.SettlementNumberDebits).HasColumnName("Settlement_Number_Debits");

//                entity.Property(e => e.SettlementTransferedAmount).HasColumnName("Settlement_Transfered_Amount");

//                entity.Property(e => e.SettlementTransferedTrxns).HasColumnName("Settlement_Transfered_Trxns");

//                entity.HasOne(d => d.FkSettlementUser)
//                    .WithMany(p => p.Settlements)
//                    .HasForeignKey(d => d.FkSettlementUserId)
//                    .HasConstraintName("Fk_Settlement_User_Id");
//            });

//            modelBuilder.Entity<Tasettlements>(entity =>
//            {
//                entity.HasKey(e => e.Utr);

//                entity.ToTable("TASettlements");

//                entity.Property(e => e.Utr)
//                    .HasColumnName("UTR")
//                    .HasMaxLength(200)
//                    .IsUnicode(false)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.Amount)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.DateOfSettlement)
//                    .HasColumnName("date_of_settlement")
//                    .HasColumnType("date");

//                entity.Property(e => e.DateOfTransactions)
//                    .HasColumnName("date_of_transactions")
//                    .HasColumnType("date");

//                entity.Property(e => e.InsertDate)
//                    .HasColumnName("Insert_date")
//                    .HasColumnType("date")
//                    .HasDefaultValueSql("(CONVERT([date],getdate(),(0)))");

//                entity.Property(e => e.MerchantId).HasColumnName("Merchant_id");

//                entity.HasOne(d => d.Merchant)
//                    .WithMany(p => p.Tasettlements)
//                    .HasForeignKey(d => d.MerchantId)
//                    .HasConstraintName("FK__TASettlem__Merch__6A2B921E");
//            });

//            modelBuilder.Entity<TawebResources12mar17>(entity =>
//            {
//                entity.HasKey(e => e.ResourceId);

//                entity.ToTable("TAWebResources_12Mar17");

//                entity.Property(e => e.ResourceId).HasColumnName("Resource_ID");

//                entity.Property(e => e.MeesevaFranchise)
//                    .HasMaxLength(2)
//                    .IsUnicode(false);

//                entity.Property(e => e.ResourceDisplayName)
//                    .HasColumnName("Resource_Display_Name")
//                    .HasMaxLength(500);

//                entity.Property(e => e.ResourceImagePath)
//                    .HasColumnName("Resource_Image_Path")
//                    .HasMaxLength(500);

//                entity.Property(e => e.ResourcePageName)
//                    .HasColumnName("Resource_Page_Name")
//                    .HasMaxLength(500);

//                entity.Property(e => e.ResourceParentResourceId)
//                    .HasColumnName("Resource_Parent_Resource_ID")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Tagwallet).HasColumnName("TAGWallet");

//                entity.Property(e => e.Tawallet).HasColumnName("TAWallet");

//                entity.Property(e => e.Twallet).HasColumnName("TWallet");
//            });

//            modelBuilder.Entity<TawebResourcesTa>(entity =>
//            {
//                entity.HasKey(e => e.ResourceId);

//                entity.ToTable("TAWebResources_TA");

//                entity.Property(e => e.ResourceId).HasColumnName("Resource_ID");

//                entity.Property(e => e.MeesevaFranchise)
//                    .HasMaxLength(2)
//                    .IsUnicode(false);

//                entity.Property(e => e.ResourceDisplayName)
//                    .HasColumnName("Resource_Display_Name")
//                    .HasMaxLength(500);

//                entity.Property(e => e.ResourceImagePath)
//                    .HasColumnName("Resource_Image_Path")
//                    .HasMaxLength(500);

//                entity.Property(e => e.ResourcePageName)
//                    .HasColumnName("Resource_Page_Name")
//                    .HasMaxLength(500);

//                entity.Property(e => e.ResourceParentResourceId)
//                    .HasColumnName("Resource_Parent_Resource_ID")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Tagwallet).HasColumnName("TAGWallet");

//                entity.Property(e => e.Tawallet).HasColumnName("TAWallet");

//                entity.Property(e => e.Twallet).HasColumnName("TWallet");
//            });

//            modelBuilder.Entity<Terminals>(entity =>
//            {
//                entity.HasKey(e => e.TerminalId);

//                entity.Property(e => e.TerminalId).HasColumnName("Terminal_ID");

//                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

//                entity.Property(e => e.EditedOn).HasColumnType("datetime");

//                entity.Property(e => e.FkTerminalEntityId).HasColumnName("FK_Terminal_Entity_ID");

//                entity.Property(e => e.FkTerminalGroupId).HasColumnName("FK_Terminal_Group_ID");

//                entity.Property(e => e.FkTerminalMerchantId).HasColumnName("FK_Terminal_Merchant_ID");

//                entity.Property(e => e.FkTerminalTerminalTypeId).HasColumnName("FK_Terminal_Terminal_Type_ID");

//                entity.Property(e => e.TerminalAuthorizedBy).HasColumnName("Terminal_Authorized_By");

//                entity.Property(e => e.TerminalAuthorizedOn)
//                    .HasColumnName("Terminal_Authorized_On")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.TerminalDescription).HasColumnName("Terminal_Description");

//                entity.Property(e => e.TerminalDtHotlistedUpdate)
//                    .HasColumnName("Terminal_DT_HotlistedUpdate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.TerminalDtTerminalUpdated)
//                    .HasColumnName("Terminal_DT_TerminalUpdated")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.TerminalIp)
//                    .IsRequired()
//                    .HasColumnName("Terminal_IP")
//                    .HasMaxLength(100);

//                entity.Property(e => e.TerminalIsActive).HasColumnName("Terminal_Is_Active");

//                entity.Property(e => e.TerminalIsHotlistedSent).HasColumnName("Terminal_IsHotlistedSent");

//                entity.Property(e => e.TerminalIsTerminalUpdated).HasColumnName("Terminal_IsTerminalUpdated");

//                entity.Property(e => e.TerminalIsUpdated)
//                    .HasColumnName("Terminal_Is_updated")
//                    .HasDefaultValueSql("((0))");

//                entity.Property(e => e.TerminalMacIp)
//                    .IsRequired()
//                    .HasColumnName("Terminal_MacIP")
//                    .HasMaxLength(100);

//                entity.Property(e => e.TerminalName)
//                    .IsRequired()
//                    .HasColumnName("Terminal_Name")
//                    .HasMaxLength(100);

//                entity.HasOne(d => d.FkTerminalGroup)
//                    .WithMany(p => p.Terminals)
//                    .HasForeignKey(d => d.FkTerminalGroupId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Terminal_Groups");

//                entity.HasOne(d => d.FkTerminalTerminalType)
//                    .WithMany(p => p.Terminals)
//                    .HasForeignKey(d => d.FkTerminalTerminalTypeId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Terminal_TerminalType");
//            });

//            modelBuilder.Entity<TerminalsBts>(entity =>
//            {
//                entity.HasKey(e => e.TerminalBtId);

//                entity.ToTable("Terminals_BTs");

//                entity.Property(e => e.TerminalBtId).HasColumnName("Terminal_BT_ID");

//                entity.Property(e => e.FkBusinessTrxnTypeNumber).HasColumnName("FK_BusinessTrxnType_Number");

//                entity.Property(e => e.FkTerminalId).HasColumnName("FK_Terminal_ID");

//                entity.Property(e => e.TerminalBtIsAssigned).HasColumnName("Terminal_BT_IsAssigned");

//                entity.Property(e => e.TerminalBtMenuType)
//                    .HasColumnName("Terminal_BT_Menu_Type")
//                    .HasMaxLength(4)
//                    .HasDefaultValueSql("((0))");

//                entity.Property(e => e.TerminalBtPtid).HasColumnName("Terminal_BT_PTID");

//                entity.HasOne(d => d.FkTerminal)
//                    .WithMany(p => p.TerminalsBts)
//                    .HasForeignKey(d => d.FkTerminalId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Terminals_BTs_Terminals");
//            });

//            modelBuilder.Entity<TerminalTypes>(entity =>
//            {
//                entity.HasKey(e => e.TerminalTypeId);

//                entity.ToTable("Terminal_Types");

//                entity.Property(e => e.TerminalTypeId).HasColumnName("Terminal_Type_ID");

//                entity.Property(e => e.TerminalTypeDesc).HasColumnName("Terminal_Type_Desc");

//                entity.Property(e => e.TerminalTypeName)
//                    .IsRequired()
//                    .HasColumnName("Terminal_Type_Name")
//                    .HasMaxLength(100);

//                entity.Property(e => e.TerminalTypeStatus).HasColumnName("Terminal_Type_Status");

//                entity.Property(e => e.TerminalTypesCreatedBy).HasColumnName("Terminal_Types_CreatedBy");

//                entity.Property(e => e.TerminalTypesCreatedOn)
//                    .HasColumnName("Terminal_Types_CreatedOn")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.TerminalTypesEditedBy).HasColumnName("Terminal_Types_EditedBy");

//                entity.Property(e => e.TerminalTypesEditedOn)
//                    .HasColumnName("Terminal_Types_EditedOn")
//                    .HasColumnType("datetime");
//            });

//            modelBuilder.Entity<TransactionType>(entity =>
//            {
//                entity.HasKey(e => e.TrxnTypeId);

//                entity.Property(e => e.TrxnTypeId)
//                    .HasColumnName("TrxnType_ID")
//                    .ValueGeneratedOnAdd();

//                entity.Property(e => e.TrxnTypeName)
//                    .IsRequired()
//                    .HasColumnName("TrxnType_Name")
//                    .HasMaxLength(100);
//            });

//            modelBuilder.Entity<TrxnsAdjustments>(entity =>
//            {
//                entity.HasKey(e => e.TrxnAdjId);

//                entity.ToTable("TRXNS_Adjustments");

//                entity.Property(e => e.TrxnAdjId)
//                    .HasColumnName("TRXN_ADJ_ID")
//                    .HasDefaultValueSql("(newid())");

//                entity.Property(e => e.FkTrxnAdjAccountHolderId).HasColumnName("FK_TRXN_ADJ_Account_Holder_ID");

//                entity.Property(e => e.FkTrxnAdjAdjustedBy).HasColumnName("FK_TRXN_ADJ_ADJUSTED_BY");

//                entity.Property(e => e.FkTrxnAdjAuthorisedBy).HasColumnName("FK_TRXN_ADJ_AUTHORISED_BY");

//                entity.Property(e => e.FkTrxnAdjEntityId).HasColumnName("FK_TRXN_ADJ_Entity_ID");

//                entity.Property(e => e.FkTrxnAdjGroupId).HasColumnName("FK_TRXN_ADJ_GROUP_ID");

//                entity.Property(e => e.FkTrxnAdjTrxnUniqueId)
//                    .IsRequired()
//                    .HasColumnName("FK_TRXN_ADJ_TRXN_UNIQUE_ID")
//                    .HasMaxLength(50);

//                entity.Property(e => e.FkTrxnAdjWalletId).HasColumnName("FK_TRXN_ADJ_Wallet_ID");

//                entity.Property(e => e.TrxnAdjAmt)
//                    .HasColumnName("TRXN_ADJ_AMT")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.TrxnAdjCbal)
//                    .HasColumnName("TRXN_ADJ_CBAL")
//                    .HasDefaultValueSql("((0))");

//                entity.Property(e => e.TrxnAdjDescription)
//                    .IsRequired()
//                    .HasColumnName("TRXN_ADJ_DESCRIPTION");

//                entity.Property(e => e.TrxnAdjDtAdjusted)
//                    .HasColumnName("TRXN_ADJ_DT_ADJUSTED")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.TrxnAdjDtAuthorised)
//                    .HasColumnName("TRXN_ADJ_DT_AUTHORISED")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.TrxnAdjDtUpdatedInCard)
//                    .HasColumnName("TRXN_ADJ_DT_UPDATED_IN_CARD")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.TrxnAdjIsUpdatedInCard).HasColumnName("TRXN_ADJ_IS_UPDATED_IN_CARD");

//                entity.Property(e => e.TrxnAdjLoadedId)
//                    .HasColumnName("TRXN_ADJ_LOADED_ID")
//                    .HasMaxLength(50);
//            });

//            modelBuilder.Entity<TrxnsElectricityBillDetails>(entity =>
//            {
//                entity.ToTable("TRXNS_ElectricityBillDetails");

//                entity.HasIndex(e => e.AccountHolderId)
//                    .HasName("TRXNS_ElectricityBillDetails_AccountHolderID");

//                entity.HasIndex(e => e.FkTrxnUniqueId)
//                    .HasName("TRXNS_ElectricityBillDetails_FK_TRXN_UNIQUE_ID");

//                entity.HasIndex(e => e.OrderId)
//                    .HasName("TRXNS_ElectricityBillDetails_OrderID");

//                entity.HasIndex(e => new { e.ConsumerName, e.Discom });

//                entity.HasIndex(e => new { e.TrxnDate, e.Amount, e.TrxnStatus, e.Scno })
//                    .HasName("IX_TRXNS_ElectricityBillDetails_SCNO");

//                entity.HasIndex(e => new { e.Uscno, e.Amount, e.OrderId, e.Discom })
//                    .HasName("IX_TRXNS_ElectricityBillDetails_DISCOM");

//                entity.HasIndex(e => new { e.FkTrxnUniqueId, e.EntityId, e.TrxnDate, e.Discom, e.CallBackProcessed })
//                    .HasName("IX_TRXNS_ElectricityBillDetails_TRXN_DATE_DISCOM_CallBackProcessed");

//                entity.HasIndex(e => new { e.FkTrxnUniqueId, e.TrxnStatus, e.OrderId, e.TrxnDate, e.Discom })
//                    .HasName("IX_TRXNS_ElectricityBillDetails_TRXN_DATE_DISCOM");

//                entity.HasIndex(e => new { e.Id, e.EntityId, e.AccountHolderId, e.Counter, e.FkTrxnUniqueId })
//                    .HasName("IX_TRXNS_ElectricityBillDetails_FK_TRXN_UNIQUE_ID");

//                entity.HasIndex(e => new { e.TrxnDate, e.Ero, e.Scno, e.Uscno, e.Amount, e.TrxnStatus, e.AccountHolderId, e.Discom, e.Prepaid, e.EntityId })
//                    .HasName("IX_TRXNS_ElectBillDetails_EntityID");

//                entity.Property(e => e.Id).HasColumnName("ID");

//                entity.Property(e => e.AccountHolderId).HasColumnName("AccountHolderID");

//                entity.Property(e => e.Acdamt)
//                    .HasColumnName("ACDAMT")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

//                entity.Property(e => e.Arrears)
//                    .HasColumnName("ARREARS")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.CallBackAmount)
//                    .HasColumnName("CallBackAMOUNT")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.CallBackProcessed)
//                    .HasMaxLength(299)
//                    .IsUnicode(false)
//                    .HasDefaultValueSql("('N')");

//                entity.Property(e => e.CallBackPtprno)
//                    .HasColumnName("CallBackPTPRNO")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.CallBackResponse).IsUnicode(false);

//                entity.Property(e => e.CallBackScno)
//                    .HasColumnName("CallBackSCNO")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.CallBackTrdate)
//                    .HasColumnName("CallBackTRDATE")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.CallBackUscno)
//                    .HasColumnName("CallBackUSCNO")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Charges).HasColumnType("decimal(30, 2)");

//                entity.Property(e => e.Checkoutamount)
//                    .HasColumnName("CHECKOUTAMOUNT")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.Cicrcle)
//                    .IsRequired()
//                    .HasColumnName("CICRCLE")
//                    .HasMaxLength(50);

//                entity.Property(e => e.ConsumerAddress)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.ConsumerName)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Counter).HasDefaultValueSql("((1))");

//                entity.Property(e => e.Currentdemand)
//                    .HasColumnName("CURRENTDEMAND")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.DeptTrxnId)
//                    .HasColumnName("DEPT_TRXN_ID")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Discdate)
//                    .HasColumnName("DISCDATE")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Discom)
//                    .HasColumnName("DISCOM")
//                    .HasMaxLength(299)
//                    .IsUnicode(false)
//                    .HasDefaultValueSql("('TSSPDCL')");

//                entity.Property(e => e.Duedate)
//                    .HasColumnName("DUEDATE")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.EntityId).HasColumnName("EntityID");

//                entity.Property(e => e.Ero)
//                    .IsRequired()
//                    .HasColumnName("ERO")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Esdshare)
//                    .HasColumnName("ESDShare")
//                    .HasColumnType("decimal(30, 2)");

//                entity.Property(e => e.FkTrxnUniqueId)
//                    .IsRequired()
//                    .HasColumnName("FK_TRXN_UNIQUE_ID")
//                    .HasMaxLength(50);

//                entity.Property(e => e.FpshopShare)
//                    .HasColumnName("FPShopShare")
//                    .HasColumnType("decimal(30, 2)");

//                entity.Property(e => e.Gst)
//                    .HasColumnName("GST")
//                    .HasColumnType("decimal(30, 2)");

//                entity.Property(e => e.MerchantId).HasColumnName("MerchantID");

//                entity.Property(e => e.OrderId)
//                    .HasColumnName("OrderID")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Prepaid).HasDefaultValueSql("('0')");

//                entity.Property(e => e.Rcfees)
//                    .HasColumnName("RCFEES")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.Rdgdate)
//                    .HasColumnName("RDGDATE")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.Request)
//                    .HasMaxLength(8000)
//                    .IsUnicode(false);

//                entity.Property(e => e.Response)
//                    .HasColumnName("RESPONSE")
//                    .HasMaxLength(7999)
//                    .IsUnicode(false);

//                entity.Property(e => e.ReversalDate).HasColumnType("datetime");

//                entity.Property(e => e.Scno)
//                    .IsRequired()
//                    .HasColumnName("SCNO")
//                    .HasMaxLength(50);

//                entity.Property(e => e.TrxnDate)
//                    .HasColumnName("TRXN_DATE")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.TrxnStatus)
//                    .IsRequired()
//                    .HasColumnName("TRXN_STATUS")
//                    .HasMaxLength(500);

//                entity.Property(e => e.Uscno)
//                    .IsRequired()
//                    .HasColumnName("USCNO")
//                    .HasMaxLength(50);

//                entity.HasOne(d => d.AccountHolder)
//                    .WithMany(p => p.TrxnsElectricityBillDetails)
//                    .HasForeignKey(d => d.AccountHolderId)
//                    .HasConstraintName("FK_Elec_ACHID");
//            });

//            modelBuilder.Entity<TrxnsFailed>(entity =>
//            {
//                entity.ToTable("TRXNS_Failed");

//                entity.Property(e => e.TrxnsFailedId)
//                    .HasColumnName("TRXNS_Failed_ID")
//                    .ValueGeneratedNever();

//                entity.Property(e => e.TrxnsFailedAmt)
//                    .HasColumnName("TRXNS_Failed_AMT")
//                    .HasMaxLength(18);

//                entity.Property(e => e.TrxnsFailedBt)
//                    .IsRequired()
//                    .HasColumnName("TRXNS_Failed_BT")
//                    .HasMaxLength(2);

//                entity.Property(e => e.TrxnsFailedCbal)
//                    .IsRequired()
//                    .HasColumnName("TRXNS_Failed_CBAL")
//                    .HasMaxLength(18);

//                entity.Property(e => e.TrxnsFailedDtProcessed)
//                    .HasColumnName("TRXNS_Failed_DT_Processed")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.TrxnsFailedMode)
//                    .IsRequired()
//                    .HasColumnName("TRXNS_Failed_MODE")
//                    .HasMaxLength(1);

//                entity.Property(e => e.TrxnsFailedScid)
//                    .IsRequired()
//                    .HasColumnName("TRXNS_Failed_SCID")
//                    .HasMaxLength(16);

//                entity.Property(e => e.TrxnsFailedStatusCode).HasColumnName("TRXNS_Failed_StatusCode");

//                entity.Property(e => e.TrxnsFailedTid)
//                    .IsRequired()
//                    .HasColumnName("TRXNS_Failed_TID")
//                    .HasMaxLength(2);

//                entity.Property(e => e.TrxnsFailedTno)
//                    .IsRequired()
//                    .HasColumnName("TRXNS_Failed_TNO")
//                    .HasMaxLength(4);

//                entity.Property(e => e.TrxnsFailedUrl)
//                    .IsRequired()
//                    .HasColumnName("TRXNS_Failed_URL");
//            });

//            modelBuilder.Entity<TrxnsFlightTicket>(entity =>
//            {
//                entity.HasKey(e => e.FlReferenceNo);

//                entity.ToTable("TRXNS_FlightTicket");

//                entity.HasIndex(e => e.FkFlAccountId);

//                entity.Property(e => e.FlReferenceNo)
//                    .HasColumnName("FL_ReferenceNo")
//                    .HasMaxLength(50)
//                    .IsUnicode(false)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.BookingStatus)
//                    .HasColumnName("Booking_Status")
//                    .HasDefaultValueSql("((0))");

//                entity.Property(e => e.FkFlAccountId).HasColumnName("FK_FL_AccountID");

//                entity.Property(e => e.FkFlBtNumber).HasColumnName("FK_FL_BT_Number");

//                entity.Property(e => e.FkFlBttypeId).HasColumnName("FK_FL_BTType_ID");

//                entity.Property(e => e.FkFlLedgeraccountId).HasColumnName("FK_FL_LEDGERACCOUNT_ID");

//                entity.Property(e => e.FkFlTrxnUniqueid)
//                    .HasColumnName("FK_FL_TRXN_UNIQUEID")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.FkFlTrxntypeId).HasColumnName("FK_FL_TRXNType_ID");

//                entity.Property(e => e.FlActualBaseFareRet)
//                    .HasColumnName("FL_ActualBaseFareRet")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlActualbasefare)
//                    .HasColumnName("FL_ACTUALBASEFARE")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlAddress)
//                    .HasColumnName("FL_ADDRESS")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlAdultTaxBreakup)
//                    .HasColumnName("FL_AdultTaxBreakup")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlAdultpax).HasColumnName("FL_ADULTPAX");

//                entity.Property(e => e.FlAffiliateId)
//                    .HasColumnName("FL_AffiliateId")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlAirEquipType)
//                    .HasColumnName("FL_AirEquipType")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlAirLineName)
//                    .HasColumnName("FL_AirLineName")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlAirportTax)
//                    .HasColumnName("FL_AirportTAX")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlAirportTaxChild)
//                    .HasColumnName("FL_AirportTaxChild")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlAirportTaxInfant)
//                    .HasColumnName("FL_AirportTaxInfant")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlArrivalAirportCode)
//                    .HasColumnName("FL_ArrivalAirportCode")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlArrivalDateTime)
//                    .HasColumnName("FL_ArrivalDateTime")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.FlArrivalDateTimeZone)
//                    .HasColumnName("FL_ArrivalDateTimeZone")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlBookedFrom)
//                    .HasColumnName("FL_BookedFrom")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlBookedname)
//                    .HasColumnName("FL_BOOKEDNAME")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlBookindate)
//                    .HasColumnName("FL_BOOKINDATE")
//                    .HasColumnType("date");

//                entity.Property(e => e.FlBookingClassFareAdultCommission)
//                    .HasColumnName("FL_BookingClassFare_AdultCommission")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlBookingClassFareAdultFare)
//                    .HasColumnName("FL_BookingClassFare_AdultFare")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlBookingClassFareBookingclass)
//                    .HasColumnName("FL_BookingClassFare_Bookingclass")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlBookingClassFareChildCommission)
//                    .HasColumnName("FL_BookingClassFare_ChildCommission")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlBookingClassFareChildFare)
//                    .HasColumnName("FL_BookingClassFare_ChildFare")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlBookingClassFareClassType)
//                    .HasColumnName("FL_BookingClassFare_ClassType")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlBookingClassFareCommissionOnTcharge)
//                    .HasColumnName("FL_BookingClassFare_CommissionOnTCharge")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlBookingClassFareFarebasiscode)
//                    .HasColumnName("FL_BookingClassFare_Farebasiscode")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlBookingClassFareInfantFare)
//                    .HasColumnName("FL_BookingClassFare_InfantFare")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlBookingClassFareRule)
//                    .HasColumnName("FL_BookingClassFare_Rule")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlBookingDate)
//                    .HasColumnName("FL_BookingDate")
//                    .HasColumnType("date");

//                entity.Property(e => e.FlBookingclassAvailability).HasColumnName("FL_BOOKINGCLASS_Availability");

//                entity.Property(e => e.FlBookingclassIntBic).HasColumnName("FL_BOOKINGCLASS_IntBIC");

//                entity.Property(e => e.FlBookingclassResBookDesigCode)
//                    .HasColumnName("FL_BOOKINGCLASS_ResBookDesigCode")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlCabin)
//                    .HasColumnName("FL_Cabin")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlCancelBookingStatus).HasColumnName("FL_Cancel_BookingStatus");

//                entity.Property(e => e.FlCancelCancelStatus).HasColumnName("FL_Cancel_CancelStatus");

//                entity.Property(e => e.FlCancelCancellationCharges)
//                    .HasColumnName("FL_Cancel_CancellationCharges")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlCancelCancellationId)
//                    .HasColumnName("FL_Cancel_CancellationId")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlCancelEtickets)
//                    .HasColumnName("FL_Cancel_Etickets")
//                    .IsUnicode(false);

//                entity.Property(e => e.FlCancelFinalRefundAmount)
//                    .HasColumnName("FL_Cancel_FinalRefundAmount")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlCancelMessage)
//                    .HasColumnName("FL_Cancel_Message")
//                    .IsUnicode(false);

//                entity.Property(e => e.FlCancelRefundStatus).HasColumnName("FL_Cancel_RefundStatus");

//                entity.Property(e => e.FlCancelRemarks)
//                    .HasColumnName("FL_Cancel_Remarks")
//                    .IsUnicode(false);

//                entity.Property(e => e.FlCancelResponseStatus)
//                    .HasColumnName("FL_Cancel_ResponseStatus")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlChildTaxBreakup)
//                    .HasColumnName("FL_ChildTaxBreakup")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlChildpax).HasColumnName("FL_CHILDPAX");

//                entity.Property(e => e.FlCity)
//                    .HasColumnName("FL_CITY")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlConveinencefe)
//                    .HasColumnName("FL_CONVEINENCEFE")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlConveniencefee)
//                    .HasColumnName("FL_Conveniencefee")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlConveniencefeeRet)
//                    .HasColumnName("FL_ConveniencefeeRet")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlDepartureAirportCode)
//                    .HasColumnName("FL_DepartureAirportCode")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlDepartureDateTime)
//                    .HasColumnName("FL_DepartureDateTime")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.FlDepartureDateTimeZone)
//                    .HasColumnName("FL_DepartureDateTimeZone")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlDestination)
//                    .HasColumnName("FL_DESTINATION")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlDestinationname)
//                    .HasColumnName("FL_DESTINATIONNAME")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlDiscount)
//                    .HasColumnName("FL_Discount")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlDob)
//                    .HasColumnName("FL_DOB")
//                    .HasColumnType("date");

//                entity.Property(e => e.FlDuration)
//                    .HasColumnName("FL_Duration")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlEmailid)
//                    .HasColumnName("FL_EMAILID")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlEntityId).HasColumnName("FL_EntityID");

//                entity.Property(e => e.FlEproductPrice)
//                    .HasColumnName("FL_EProductPrice")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlEproductPriceRet)
//                    .HasColumnName("FL_EProductPriceRet")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlFlightIdRet)
//                    .HasColumnName("FL_FlightIdRet")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlFlightNumber)
//                    .HasColumnName("FL_FlightNumber")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlFlighttype).HasColumnName("FL_FLIGHTTYPE");

//                entity.Property(e => e.FlFlightuid)
//                    .HasColumnName("FL_Flightuid")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlImageFileName)
//                    .HasColumnName("FL_ImageFileName")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlImagePathRet)
//                    .HasColumnName("FL_ImagePathRet")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlImagepath)
//                    .HasColumnName("FL_IMAGEPATH")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlInfantTaxBreakup)
//                    .HasColumnName("FL_InfantTaxBreakup")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlInfantpax).HasColumnName("FL_INFANTPAX");

//                entity.Property(e => e.FlIntAirpChg)
//                    .HasColumnName("FL_IntAirpChg")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlIntBaseFare)
//                    .HasColumnName("FL_IntBaseFare")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlIntConx)
//                    .HasColumnName("FL_IntConx")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlIntDaysOperates)
//                    .HasColumnName("FL_IntDaysOperates")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlIntDepartureAirportName)
//                    .HasColumnName("FL_IntDepartureAirportName")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlIntEndTerminal)
//                    .HasColumnName("FL_IntEndTerminal")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlIntFltTm)
//                    .HasColumnName("FL_IntFltTm")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlIntGenTrafRestriction)
//                    .HasColumnName("FL_IntGenTrafRestriction")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlIntInsideAvailOption)
//                    .HasColumnName("FL_IntInsideAvailOption")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlIntJourneyTime)
//                    .HasColumnName("FL_IntJourneyTime")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlIntLinkSellAgrmnt)
//                    .HasColumnName("FL_IntLinkSellAgrmnt")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlIntLsaind)
//                    .HasColumnName("FL_IntLSAInd")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlIntMarketingAirlineCode)
//                    .HasColumnName("FL_IntMarketingAirlineCode")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlIntMile)
//                    .HasColumnName("FL_IntMile")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlIntNumStops).HasColumnName("FL_IntNumStops");

//                entity.Property(e => e.FlIntOperatingAirlineName)
//                    .HasColumnName("FL_IntOperatingAirlineName")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlIntPassengerType)
//                    .HasColumnName("FL_IntPassengerType")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlIntStartTerminal)
//                    .HasColumnName("FL_IntStartTerminal")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlIntTax)
//                    .HasColumnName("FL_IntTax")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlIsLccret).HasColumnName("FL_IsLCCRet");

//                entity.Property(e => e.FlIsNonStopFlight).HasColumnName("FL_IsNonStopFlight");

//                entity.Property(e => e.FlIslcc).HasColumnName("FL_ISLCC");

//                entity.Property(e => e.FlItineraryNumber)
//                    .HasColumnName("FL_itineraryNumber")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlJourneydate)
//                    .HasColumnName("FL_JOURNEYDATE")
//                    .HasColumnType("date");

//                entity.Property(e => e.FlKey)
//                    .HasColumnName("FL_KEY")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlKeyret)
//                    .HasColumnName("FL_KEYRET")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlMobile)
//                    .HasColumnName("FL_MOBILE")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlOctax)
//                    .HasColumnName("FL_OCTAX")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlOperatingAirlineCode)
//                    .HasColumnName("FL_OperatingAirlineCode")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlOperatingAirlineFlightNumber)
//                    .HasColumnName("FL_OperatingAirlineFlightNumber")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlOrderId)
//                    .HasColumnName("FL_OrderID")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlPassengertype)
//                    .HasColumnName("FL_PASSENGERTYPE")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlPassportdetails)
//                    .HasColumnName("FL_PASSPORTDETAILS")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlPassworduid)
//                    .HasColumnName("FL_Passworduid")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlPostMarkup).HasColumnName("FL_PostMarkup");

//                entity.Property(e => e.FlPostalcode)
//                    .HasColumnName("FL_POSTALCODE")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlPromoCode)
//                    .HasColumnName("FL_PromoCode")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlPromoCodeAmount)
//                    .HasColumnName("FL_PromoCodeAmount")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlProvidername)
//                    .HasColumnName("FL_PROVIDERNAME")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlResApireferenceNo)
//                    .HasColumnName("FL_RES_APIReferenceNo")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlResBookingStatus).HasColumnName("FL_RES_BookingStatus");

//                entity.Property(e => e.FlResEticketNo)
//                    .HasColumnName("FL_RES_EticketNo")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlResGdfpnrno)
//                    .HasColumnName("FL_RES_GDFPNRNo")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlResMessage)
//                    .HasColumnName("FL_RES_Message")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlResRefundResponse)
//                    .HasColumnName("FL_RES_RefundResponse")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlResResponseStatus)
//                    .HasColumnName("FL_RES_ResponseStatus")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlResTransactionId)
//                    .HasColumnName("FL_RES_TransactionId")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetAdultTaxBreakup)
//                    .HasColumnName("FL_RET_AdultTaxBreakup")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlRetAirEquipType)
//                    .HasColumnName("FL_RET_AirEquipType")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetAirLineName)
//                    .HasColumnName("FL_RET_AirLineName")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetAirportTax)
//                    .HasColumnName("FL_RET_AirportTAX")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlRetAirportTaxChild)
//                    .HasColumnName("FL_RET_AirportTaxChild")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlRetAirportTaxInfant)
//                    .HasColumnName("FL_RET_AirportTaxInfant")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlRetArrivalAirportCode)
//                    .HasColumnName("FL_RET_ArrivalAirportCode")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetArrivalDateTime)
//                    .HasColumnName("FL_RET_ArrivalDateTime")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.FlRetArrivalDateTimeZone)
//                    .HasColumnName("FL_RET_ArrivalDateTimeZone")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetBookingClassFareAdultCommission)
//                    .HasColumnName("FL_RET_BookingClassFare_AdultCommission")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlRetBookingClassFareAdultFare)
//                    .HasColumnName("FL_RET_BookingClassFare_AdultFare")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlRetBookingClassFareBookingclass)
//                    .HasColumnName("FL_RET_BookingClassFare_Bookingclass")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetBookingClassFareChildCommission)
//                    .HasColumnName("FL_RET_BookingClassFare_ChildCommission")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlRetBookingClassFareChildFare)
//                    .HasColumnName("FL_RET_BookingClassFare_ChildFare")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlRetBookingClassFareClassType)
//                    .HasColumnName("FL_RET_BookingClassFare_ClassType")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetBookingClassFareCommissionOnTcharge)
//                    .HasColumnName("FL_RET_BookingClassFare_CommissionOnTCharge")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlRetBookingClassFareFarebasiscode)
//                    .HasColumnName("FL_RET_BookingClassFare_Farebasiscode")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetBookingClassFareInfantFare)
//                    .HasColumnName("FL_RET_BookingClassFare_InfantFare")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlRetBookingClassFareRule)
//                    .HasColumnName("FL_RET_BookingClassFare_Rule")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetBookingclassAvailability).HasColumnName("FL_RET_BOOKINGCLASS_Availability");

//                entity.Property(e => e.FlRetBookingclassIntBic).HasColumnName("FL_RET_BOOKINGCLASS_IntBIC");

//                entity.Property(e => e.FlRetBookingclassResBookDesigCode)
//                    .HasColumnName("FL_RET_BOOKINGCLASS_ResBookDesigCode")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetCabin)
//                    .HasColumnName("FL_RET_Cabin")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetChildTaxBreakup)
//                    .HasColumnName("FL_RET_ChildTaxBreakup")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlRetDepartureAirportCode)
//                    .HasColumnName("FL_RET_DepartureAirportCode")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetDepartureDateTime)
//                    .HasColumnName("FL_RET_DepartureDateTime")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.FlRetDepartureDateTimeZone)
//                    .HasColumnName("FL_RET_DepartureDateTimeZone")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetDiscount)
//                    .HasColumnName("FL_RET_Discount")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlRetDuration)
//                    .HasColumnName("FL_RET_Duration")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetFlightNumber)
//                    .HasColumnName("FL_RET_FlightNumber")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetImageFileName)
//                    .HasColumnName("FL_RET_ImageFileName")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetInfantTaxBreakup)
//                    .HasColumnName("FL_RET_InfantTaxBreakup")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlRetIntAirpChg)
//                    .HasColumnName("FL_RET_IntAirpChg")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetIntConx)
//                    .HasColumnName("FL_RET_IntConx")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetIntDaysOperates)
//                    .HasColumnName("FL_RET_IntDaysOperates")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetIntDepartureAirportName)
//                    .HasColumnName("FL_RET_IntDepartureAirportName")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetIntEndTerminal)
//                    .HasColumnName("FL_RET_IntEndTerminal")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetIntFltTm)
//                    .HasColumnName("FL_RET_IntFltTm")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetIntGenTrafRestriction)
//                    .HasColumnName("FL_RET_IntGenTrafRestriction")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetIntInsideAvailOption)
//                    .HasColumnName("FL_RET_IntInsideAvailOption")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetIntJourneyTime)
//                    .HasColumnName("FL_RET_IntJourneyTime")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetIntLinkSellAgrmnt)
//                    .HasColumnName("FL_RET_IntLinkSellAgrmnt")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetIntLsaind)
//                    .HasColumnName("FL_RET_IntLSAInd")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetIntMarketingAirlineCode)
//                    .HasColumnName("FL_RET_IntMarketingAirlineCode")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetIntMile)
//                    .HasColumnName("FL_RET_IntMile")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetIntNumStops).HasColumnName("FL_RET_IntNumStops");

//                entity.Property(e => e.FlRetIntOperatingAirlineName)
//                    .HasColumnName("FL_RET_IntOperatingAirlineName")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetIntStartTerminal)
//                    .HasColumnName("FL_RET_IntStartTerminal")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetItineraryNumber)
//                    .HasColumnName("FL_RET_itineraryNumber")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetOperatingAirlineCode)
//                    .HasColumnName("FL_RET_OperatingAirlineCode")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetOperatingAirlineFlightNumber)
//                    .HasColumnName("FL_RET_OperatingAirlineFlightNumber")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetRph)
//                    .HasColumnName("FL_RET_RPH")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRetStopQuantity).HasColumnName("FL_RET_StopQuantity");

//                entity.Property(e => e.FlRetViaFlight).HasColumnName("FL_RET_ViaFlight");

//                entity.Property(e => e.FlReturnFlightSegments)
//                    .HasColumnName("FL_ReturnFlightSegments")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlReturndate)
//                    .HasColumnName("FL_RETURNDATE")
//                    .HasColumnType("date");

//                entity.Property(e => e.FlRph)
//                    .HasColumnName("FL_RPH")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRule)
//                    .HasColumnName("FL_Rule")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlRuleret)
//                    .HasColumnName("FL_RULERET")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlScharge)
//                    .HasColumnName("FL_SCHARGE")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlSchargeRet)
//                    .HasColumnName("FL_SChargeRet")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlSltax)
//                    .HasColumnName("FL_SLTAX")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlSmsusagecount).HasColumnName("FL_SMSUSAGECOUNT");

//                entity.Property(e => e.FlSource)
//                    .HasColumnName("FL_SOURCE")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlSourcename)
//                    .HasColumnName("FL_SOURCENAME")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlState)
//                    .HasColumnName("FL_STATE")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlStopQuantity).HasColumnName("FL_StopQuantity");

//                entity.Property(e => e.FlTax)
//                    .HasColumnName("FL_TAX")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlTaxRet)
//                    .HasColumnName("FL_TaxRet")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlTcharge)
//                    .HasColumnName("FL_TCHARGE")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlTchargeRet)
//                    .HasColumnName("FL_TChargeRet")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlTdiscount)
//                    .HasColumnName("FL_TDISCOUNT")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlTdiscountRet)
//                    .HasColumnName("FL_TDiscountRet")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlTelephone)
//                    .HasColumnName("FL_TELEPHONE")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlTmarkup)
//                    .HasColumnName("FL_TMARKUP")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlTmarkupRet)
//                    .HasColumnName("FL_TMarkupRet")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlTotalFare)
//                    .HasColumnName("FL_TotalFare")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlTpartnerCommissionRet)
//                    .HasColumnName("FL_TPartnerCommissionRet")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlTpartnercommision)
//                    .HasColumnName("FL_TPARTNERCOMMISION")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlTransactionId)
//                    .HasColumnName("FL_TransactionId")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlTravelcalss)
//                    .HasColumnName("FL_TRAVELCALSS")
//                    .HasMaxLength(5)
//                    .IsUnicode(false);

//                entity.Property(e => e.FlTriptype).HasColumnName("FL_TRIPTYPE");

//                entity.Property(e => e.FlTrxnId)
//                    .HasColumnName("FL_TrxnID")
//                    .HasMaxLength(100)
//                    .IsUnicode(false)
//                    .HasDefaultValueSql("(newid())");

//                entity.Property(e => e.FlTsdiscount)
//                    .HasColumnName("FL_TSDISCOUNT")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlTsdiscountRet)
//                    .HasColumnName("FL_TSdiscountRet")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FlUser).HasColumnName("FL_User");

//                entity.Property(e => e.FlUserType).HasColumnName("FL_UserType");

//                entity.Property(e => e.FlViaFlight).HasColumnName("FL_ViaFlight");

//                entity.Property(e => e.Id).ValueGeneratedOnAdd();

//                entity.Property(e => e.InsertedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.TrxnDate)
//                    .HasColumnName("TRXN_DATE")
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.HasOne(d => d.FkFlAccount)
//                    .WithMany(p => p.TrxnsFlightTicket)
//                    .HasForeignKey(d => d.FkFlAccountId)
//                    .HasConstraintName("FK_Flight_ACHID");

//                entity.HasOne(d => d.FlEntity)
//                    .WithMany(p => p.TrxnsFlightTicket)
//                    .HasForeignKey(d => d.FlEntityId)
//                    .HasConstraintName("FK__TRXNS_Fli__FL_En__2E4D6855");
//            });

//            modelBuilder.Entity<TrxnsHotelTicket>(entity =>
//            {
//                entity.HasKey(e => e.HlBookingRefNo);

//                entity.ToTable("TRXNS_HotelTicket");

//                entity.Property(e => e.HlBookingRefNo)
//                    .HasColumnName("HL_BookingRefNo")
//                    .HasMaxLength(100)
//                    .IsUnicode(false)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.ArrivalDate).HasColumnType("datetime");

//                entity.Property(e => e.BookingStatus)
//                    .HasColumnName("Booking_Status")
//                    .HasDefaultValueSql("((0))");

//                entity.Property(e => e.ChildrenAges)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.CityName)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.DepartureDate).HasColumnType("datetime");

//                entity.Property(e => e.DestinationId)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.EmailId)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.EmergencyMobileNo)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.Fare).HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.FkHlAccountId).HasColumnName("FK_HL_AccountID");

//                entity.Property(e => e.FkHlBtNumber).HasColumnName("FK_HL_BT_Number");

//                entity.Property(e => e.FkHlBttypeId).HasColumnName("FK_HL_BTType_ID");

//                entity.Property(e => e.FkHlLedgeraccountId).HasColumnName("FK_HL_LEDGERACCOUNT_ID");

//                entity.Property(e => e.FkHlTrxnUniqueid)
//                    .HasColumnName("FK_HL_TRXN_UNIQUEID")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.FkHlTrxntypeId).HasColumnName("FK_HL_TRXNType_ID");

//                entity.Property(e => e.HlCancelBookingStatus).HasColumnName("HL_Cancel_BookingStatus");

//                entity.Property(e => e.HlCancelCancelStatus).HasColumnName("HL_Cancel_CancelStatus");

//                entity.Property(e => e.HlCancelCancellationId)
//                    .HasColumnName("HL_Cancel_CancellationId")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.HlCancelFinalRefundAmount)
//                    .HasColumnName("HL_Cancel_FinalRefundAmount")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.HlCancelMessage)
//                    .HasColumnName("HL_Cancel_Message")
//                    .IsUnicode(false);

//                entity.Property(e => e.HlCancelPaymentId)
//                    .HasColumnName("HL_Cancel_PaymentID")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.HlCancelRefundStatus).HasColumnName("HL_Cancel_RefundStatus");

//                entity.Property(e => e.HlCancelRemarks)
//                    .HasColumnName("HL_Cancel_Remarks")
//                    .IsUnicode(false);

//                entity.Property(e => e.HlCancelTransactionId)
//                    .HasColumnName("HL_Cancel_TransactionID")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.HlEntityId).HasColumnName("HL_EntityID");

//                entity.Property(e => e.HlMobile)
//                    .HasColumnName("HL_Mobile")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.HlOrderId)
//                    .HasColumnName("HL_OrderID")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.HlRequestDatatime)
//                    .HasColumnName("HL_RequestDatatime")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.HlTotalFare)
//                    .HasColumnName("HL_TotalFare")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.HlTrxnId)
//                    .HasColumnName("HL_TrxnID")
//                    .HasDefaultValueSql("(newid())");

//                entity.Property(e => e.HotelId)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.HotelName)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).ValueGeneratedOnAdd();

//                entity.Property(e => e.InsertedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.PinCode)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.Provider)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.RoomType)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.State)
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.TrxnDate)
//                    .HasColumnName("TRXN_DATE")
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.HasOne(d => d.FkHlAccount)
//                    .WithMany(p => p.TrxnsHotelTicket)
//                    .HasForeignKey(d => d.FkHlAccountId)
//                    .HasConstraintName("FK_Hotel_ACHID");

//                entity.HasOne(d => d.HlEntity)
//                    .WithMany(p => p.TrxnsHotelTicket)
//                    .HasForeignKey(d => d.HlEntityId)
//                    .HasConstraintName("FK__TRXNS_Hot__HL_En__47A32604");
//            });

//            modelBuilder.Entity<TrxnsMoibleRechargeChangedStatus>(entity =>
//            {
//                entity.HasKey(e => e.FkMrTrxnUniqueId);

//                entity.ToTable("TRXNS_MOIBLE_RECHARGE_CHANGED_STATUS");

//                entity.Property(e => e.FkMrTrxnUniqueId)
//                    .HasColumnName("FK_MR_TRXN_UNIQUE_ID")
//                    .HasMaxLength(299)
//                    .IsUnicode(false)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.AuthorizationStatus)
//                    .HasColumnName("AUTHORIZATION_STATUS")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.AuthorizedBy)
//                    .HasColumnName("AUTHORIZED BY")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.AuthorizedDate)
//                    .HasColumnName("AUTHORIZED DATE")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.ChangedStatus)
//                    .HasColumnName("CHANGED_STATUS")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.ExistedStatus)
//                    .HasColumnName("EXISTED_STATUS")
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.MrDtProcessed)
//                    .HasColumnName("MR_DT_PROCESSED")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Reason)
//                    .HasColumnName("REASON")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.Rejectedreason)
//                    .HasColumnName("REJECTEDREASON")
//                    .HasMaxLength(2999)
//                    .IsUnicode(false);

//                entity.Property(e => e.StatusChangeRequestedDate)
//                    .HasColumnName("STATUS_CHANGE_REQUESTED_DATE")
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");
//            });

//            modelBuilder.Entity<TrxnsSwitchLog>(entity =>
//            {
//                entity.HasKey(e => e.TrxnsLogId);

//                entity.ToTable("TRXNS_SWITCH_LOG");

//                entity.Property(e => e.TrxnsLogId)
//                    .HasColumnName("TRXNS_Log_ID")
//                    .HasDefaultValueSql("(newid())");

//                entity.Property(e => e.TrxnsLogAmt)
//                    .HasColumnName("TRXNS_Log_AMT")
//                    .HasMaxLength(18);

//                entity.Property(e => e.TrxnsLogBt)
//                    .IsRequired()
//                    .HasColumnName("TRXNS_Log_BT")
//                    .HasMaxLength(10);

//                entity.Property(e => e.TrxnsLogCbal)
//                    .IsRequired()
//                    .HasColumnName("TRXNS_Log_CBAL")
//                    .HasMaxLength(18);

//                entity.Property(e => e.TrxnsLogClientIp)
//                    .IsRequired()
//                    .HasColumnName("TRXNS_Log_Client_IP")
//                    .HasMaxLength(15);

//                entity.Property(e => e.TrxnsLogDtActual)
//                    .HasColumnName("TRXNS_Log_DT_ACTUAL")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.TrxnsLogDtProcessed)
//                    .HasColumnName("TRXNS_Log_DT_Processed")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.TrxnsLogEcode)
//                    .HasColumnName("TRXNS_Log_ECode")
//                    .HasMaxLength(10);

//                entity.Property(e => e.TrxnsLogGcode)
//                    .HasColumnName("TRXNS_Log_GCode")
//                    .HasMaxLength(10);

//                entity.Property(e => e.TrxnsLogGlAccountId).HasColumnName("TRXNS_Log_GL_ACCOUNT_ID");

//                entity.Property(e => e.TrxnsLogIsAdjusted)
//                    .HasColumnName("TRXNS_Log_IS_ADJUSTED")
//                    .HasDefaultValueSql("((1))");

//                entity.Property(e => e.TrxnsLogMacIp)
//                    .HasColumnName("TRXNS_Log_MAC_IP")
//                    .HasMaxLength(40);

//                entity.Property(e => e.TrxnsLogMid)
//                    .HasColumnName("TRXNS_Log_MID")
//                    .HasMaxLength(10);

//                entity.Property(e => e.TrxnsLogMode)
//                    .IsRequired()
//                    .HasColumnName("TRXNS_Log_MODE")
//                    .HasMaxLength(1);

//                entity.Property(e => e.TrxnsLogScid)
//                    .IsRequired()
//                    .HasColumnName("TRXNS_Log_SCID")
//                    .HasMaxLength(16);

//                entity.Property(e => e.TrxnsLogTid).HasColumnName("TRXNS_Log_TID");

//                entity.Property(e => e.TrxnsLogTmlType)
//                    .HasColumnName("TRXNS_Log_TML_TYPE")
//                    .HasMaxLength(10);

//                entity.Property(e => e.TrxnsLogTno)
//                    .IsRequired()
//                    .HasColumnName("TRXNS_Log_TNO")
//                    .HasMaxLength(10);

//                entity.Property(e => e.TrxnsLogUniqueId)
//                    .HasColumnName("TRXNS_Log_UNIQUE_ID")
//                    .HasMaxLength(50);

//                entity.Property(e => e.TrxnsLogUrl)
//                    .IsRequired()
//                    .HasColumnName("TRXNS_Log_URL");
//            });

//            modelBuilder.Entity<UploadCourseFeeDues>(entity =>
//            {
//                entity.HasKey(e => e.UploadCfdId);

//                entity.ToTable("Upload_CourseFeeDues");

//                entity.Property(e => e.UploadCfdId).HasColumnName("UPLOAD_CFD_ID");

//                entity.Property(e => e.FkUploadCfdAccountHolderId).HasColumnName("FK_UPLOAD_CFD_Account_Holder_ID");

//                entity.Property(e => e.FkUploadCfdAuthBy).HasColumnName("FK_UPLOAD_CFD_AUTH_BY");

//                entity.Property(e => e.FkUploadCfdBtType).HasColumnName("FK_UPLOAD_CFD_BT_TYPE");

//                entity.Property(e => e.FkUploadCfdPostingstatus).HasColumnName("FK_UPLOAD_CFD_POSTINGSTATUS");

//                entity.Property(e => e.FkUploadCfdTrxnType).HasColumnName("FK_UPLOAD_CFD_TRXN_TYPE");

//                entity.Property(e => e.FkUploadCfdUploadedBy).HasColumnName("FK_UPLOAD_CFD_UPLOADED_BY");

//                entity.Property(e => e.UploadCfdAmount)
//                    .HasColumnName("UPLOAD_CFD_AMOUNT")
//                    .HasColumnType("decimal(10, 2)");

//                entity.Property(e => e.UploadCfdAuthDate)
//                    .HasColumnName("UPLOAD_CFD_AUTH_DATE")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.UploadCfdReferenceNo)
//                    .IsRequired()
//                    .HasColumnName("UPLOAD_CFD_REFERENCE_NO")
//                    .HasMaxLength(50);

//                entity.Property(e => e.UploadCfdUniqueId)
//                    .IsRequired()
//                    .HasColumnName("UPLOAD_CFD_UNIQUE_ID")
//                    .HasMaxLength(20);

//                entity.Property(e => e.UploadCfdUploadedDate)
//                    .HasColumnName("UPLOAD_CFD_UPLOADED_DATE")
//                    .HasColumnType("datetime");

//                entity.HasOne(d => d.FkUploadCfdAuthByNavigation)
//                    .WithMany(p => p.UploadCourseFeeDuesFkUploadCfdAuthByNavigation)
//                    .HasForeignKey(d => d.FkUploadCfdAuthBy)
//                    .HasConstraintName("FK_Upload_CourseFeeDues_Users");

//                entity.HasOne(d => d.FkUploadCfdPostingstatusNavigation)
//                    .WithMany(p => p.UploadCourseFeeDues)
//                    .HasForeignKey(d => d.FkUploadCfdPostingstatus)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Upload_CourseFeeDues_PostingStatusType");

//                entity.HasOne(d => d.FkUploadCfdTrxnTypeNavigation)
//                    .WithMany(p => p.UploadCourseFeeDues)
//                    .HasForeignKey(d => d.FkUploadCfdTrxnType)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Upload_CourseFeeDues_TransactionType");

//                entity.HasOne(d => d.FkUploadCfdUploadedByNavigation)
//                    .WithMany(p => p.UploadCourseFeeDuesFkUploadCfdUploadedByNavigation)
//                    .HasForeignKey(d => d.FkUploadCfdUploadedBy)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Upload_CourseFeeDues_Users1");
//            });

//            modelBuilder.Entity<Users>(entity =>
//            {
//                entity.HasKey(e => e.UserId);

//                entity.HasIndex(e => e.UserMailId);

//                entity.Property(e => e.UserId).HasColumnName("User_ID");

//                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

//                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

//                entity.Property(e => e.FkUserCreatedBy).HasColumnName("FK_User_CreatedBy");

//                entity.Property(e => e.FkUserEditedBy).HasColumnName("FK_User_EditedBy");

//                entity.Property(e => e.FkUserEntityId).HasColumnName("FK_User_Entity_ID");

//                entity.Property(e => e.FkUserGroupId).HasColumnName("FK_User_Group_ID");

//                entity.Property(e => e.FkUserRoleId).HasColumnName("FK_User_Role_ID");

//                entity.Property(e => e.FkUserStatusTypeId).HasColumnName("FK_User_StatusType_ID");

//                entity.Property(e => e.FkUserTypeId).HasColumnName("FK_User_Type_ID");

//                entity.Property(e => e.LastPasswordSetOn).HasColumnType("datetime");

//                entity.Property(e => e.MerchantId).HasColumnName("MerchantID");

//                entity.Property(e => e.OptionalEmail)
//                    .HasMaxLength(299)
//                    .IsUnicode(false);

//                entity.Property(e => e.OrgId).HasColumnName("OrgID");

//                entity.Property(e => e.RoleCode)
//                    .HasColumnName("Role_Code")
//                    .HasMaxLength(99)
//                    .IsUnicode(false);

//                entity.Property(e => e.StateId).HasColumnName("StateID");

//                entity.Property(e => e.UserCurrentPassword)
//                    .IsRequired()
//                    .HasColumnName("User_CurrentPassword")
//                    .HasMaxLength(500);

//                entity.Property(e => e.UserDesignation)
//                    .IsRequired()
//                    .HasColumnName("User_Designation")
//                    .HasMaxLength(50);

//                entity.Property(e => e.UserDurationFrom)
//                    .HasColumnName("User_DurationFrom")
//                    .HasColumnType("date");

//                entity.Property(e => e.UserDurationTo)
//                    .HasColumnName("User_DurationTo")
//                    .HasColumnType("date");

//                entity.Property(e => e.UserIsReset).HasColumnName("User_IsReset");

//                entity.Property(e => e.UserMailId)
//                    .HasColumnName("User_Mail_ID")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.UserMobileNumber)
//                    .IsRequired()
//                    .HasColumnName("User_Mobile_Number")
//                    .HasMaxLength(20);

//                entity.Property(e => e.UserName)
//                    .IsRequired()
//                    .HasColumnName("User_Name")
//                    .HasMaxLength(50);

//                entity.Property(e => e.UserPhoto)
//                    .HasColumnName("User_Photo")
//                    .HasColumnType("image");

//                entity.Property(e => e.UserPhotoName)
//                    .HasColumnName("User_PhotoName")
//                    .HasMaxLength(255);

//                entity.Property(e => e.UserSignature)
//                    .HasColumnName("User_Signature")
//                    .HasColumnType("image");

//                entity.Property(e => e.UserSignatureName)
//                    .HasColumnName("User_Signature_Name")
//                    .HasMaxLength(255);

//                entity.HasOne(d => d.FkUserEntity)
//                    .WithMany(p => p.Users)
//                    .HasForeignKey(d => d.FkUserEntityId)
//                    .HasConstraintName("FK_User_EntityID");

//                entity.HasOne(d => d.FkUserGroup)
//                    .WithMany(p => p.Users)
//                    .HasForeignKey(d => d.FkUserGroupId)
//                    .HasConstraintName("FK_User_GroupID");

//                entity.HasOne(d => d.FkUserStatusType)
//                    .WithMany(p => p.Users)
//                    .HasForeignKey(d => d.FkUserStatusTypeId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_UserStatus_TypeID");

//                entity.HasOne(d => d.FkUserType)
//                    .WithMany(p => p.Users)
//                    .HasForeignKey(d => d.FkUserTypeId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_User_TypeID");
//            });

//            modelBuilder.Entity<UserStatusType>(entity =>
//            {
//                entity.HasKey(e => e.StatusTypeId);

//                entity.Property(e => e.StatusTypeId)
//                    .HasColumnName("StatusType_ID")
//                    .ValueGeneratedOnAdd();

//                entity.Property(e => e.StatusTypeDescription)
//                    .IsRequired()
//                    .HasColumnName("StatusType_Description")
//                    .HasMaxLength(50);
//            });

//            modelBuilder.Entity<UserTypes>(entity =>
//            {
//                entity.HasKey(e => e.UserTypeId);

//                entity.ToTable("User_Types");

//                entity.Property(e => e.UserTypeId)
//                    .HasColumnName("User_Type_ID")
//                    .ValueGeneratedNever();

//                entity.Property(e => e.UserTypeName)
//                    .IsRequired()
//                    .HasColumnName("User_Type_Name")
//                    .HasMaxLength(100);
//            });

//            modelBuilder.Entity<VbRequestXml>(entity =>
//            {
//                entity.HasKey(e => e.VbRequestId);

//                entity.ToTable("VB_Request_XML");

//                entity.Property(e => e.VbRequestId).HasColumnName("VB_Request_ID");

//                entity.Property(e => e.AccountNo)
//                    .HasColumnName("Account_No")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.Opcode)
//                    .HasColumnName("OPCode")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.RequestJson)
//                    .HasColumnName("Request_JSON")
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<VbResponseMessage>(entity =>
//            {
//                entity.HasKey(e => e.VbResponseId);

//                entity.ToTable("VB_Response_Message");

//                entity.Property(e => e.VbResponseId).HasColumnName("VB_Response_Id");

//                entity.Property(e => e.CreatedDate)
//                    .HasColumnType("datetime")
//                    .HasDefaultValueSql("(getdate())");

//                entity.Property(e => e.FkVbRequestId).HasColumnName("FK_VB_Request_Id");

//                entity.Property(e => e.Response).IsUnicode(false);
//            });
//        }
//    }
//}
