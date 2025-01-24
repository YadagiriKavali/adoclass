using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TWelletDemoApp.Models;

namespace TWelletDemoApp.Models
{
    public partial class Semi_C3_StandardizedContext : DbContext
    {
        public Semi_C3_StandardizedContext()
        {
        }

        public Semi_C3_StandardizedContext(DbContextOptions<Semi_C3_StandardizedContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountHolder> AccountHolder { get; set; }
        //public DbSet<AccountRegistrationVerification> AccountRegistrationVerifications { get; set; }
        public virtual DbSet<AccountRegistrationVerification> AccountRegistrationVerifications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=10.1.1.4;Initial Catalog=Semi_C3_Standardized;User Id=tapreprod;Password=$t@ging@TA");
            }
        }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountHolder>(entity =>
            {
                entity.ToTable("Account_Holder");

                entity.HasIndex(e => e.Aadhaar)
                    .HasName("NonClusteredIndex-20180314-122613");

                entity.HasIndex(e => e.AccountHolderMobileNo)
                    .HasName("NonClusteredIndex-20170805-155940");

                entity.HasIndex(e => e.FkAccountHolderEntityId)
                    .HasName("NonClusteredIndex-20170601-184021");

                entity.HasIndex(e => e.PlatForm)
                    .HasName("NonClusteredColumnStoreIndex-20170601-180710");

                entity.HasIndex(e => new { e.FkAccountHolderEntityId, e.CreatedDate })
                    .HasName("IX_Account_Holder_Created_Date");

                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderMobileNo, e.FkAccountHolderEntityId })
                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID");

                entity.HasIndex(e => new { e.AccountHolderId, e.FkAccountHolderEntityId, e.AccountHolderMobileNo })
                    .HasName("IX_Account_Holder_Account_Holder_MobileNo4");

                entity.HasIndex(e => new { e.AccountHolderId, e.FkAccountHolderEntityId, e.WalletTypeId })
                    .HasName("IX_Account_Holder_FK_Acct_Holder_Entity_ID_WalletTypeID");

                entity.HasIndex(e => new { e.AccountHolderMobileNo, e.FkAccountHolderEntityId, e.Uidtoken })
                    .HasName("IX_Account_Holder_UIDToken");

                entity.HasIndex(e => new { e.FkAccountHolderEntityId, e.CustOf, e.AccountHolderMobileNo })
                    .HasName("IX_Account_Holder_Account_Holder_MobileNo32");

                entity.HasIndex(e => new { e.IsKycDone, e.CreatedDate, e.FkAccountHolderEntityId })
                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID9");

                entity.HasIndex(e => new { e.IsKycDone, e.FkAccountHolderStatusTypeId, e.AccountHolderMobileNo })
                    .HasName("IX_Account_Holder_Account_Holder_MobileNo31");

                entity.HasIndex(e => new { e.WalletTypeId, e.FkAccountHolderEntityId, e.CreatedDate })
                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID_Created_Date3");

                entity.HasIndex(e => new { e.AccountHolderFullName, e.AccountHolderMobileNo, e.WalletTypeId, e.IsDistributor })
                    .HasName("IX_Account_Holder_WalletTypeID_Is_Distributor");

                entity.HasIndex(e => new { e.AccountHolderId, e.Aadhaar, e.TempAadhaar, e.FkAccountHolderEntityId })
                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID5");

                entity.HasIndex(e => new { e.AccountHolderMobileNo, e.FkAccountHolderEntityId, e.Aadhaar, e.Uidtoken })
                    .HasName("IX_Account_Holder_UIDToken2");

                entity.HasIndex(e => new { e.AccountHolderMobileNo, e.WalletTypeId, e.FkAccountHolderEntityId, e.CreatedDate })
                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID_Created_Date");

                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderFullName, e.AccountHolderMobileNo, e.WalletTypeId, e.FkAccountHolderEntityId })
                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID_20190202");

                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderMobileNo, e.Aadhaar, e.Uidtoken, e.FkAccountHolderEntityId })
                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID1");

                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderMobileNo, e.AccountHolderPwdEncrypt, e.Salt, e.FkAccountHolderEntityId })
                    .HasName("IX_Account_Holder_FK_Account_lder_Entity_ID7");

                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderMobileNo, e.LoginEnable, e.Salt, e.FkAccountHolderEntityId })
                    .HasName("IX_Account_Holder_FK_Account_Hr_Entity_ID");

                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderFullName, e.AccountHolderMobileNo, e.FkAccountHolderStatusTypeId, e.WalletTypeId, e.FkAccountHolderEntityId })
                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID10");

                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderFullName, e.FkAccountHolderEntityId, e.IsKycDone, e.WalletTypeId, e.AccountHolderMobileNo })
                    .HasName("IX_Account_Holder_Account_Holder_MobileNo");

                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderMobileNo, e.IsKycDone, e.WalletTypeId, e.CustOf, e.IsUsageCapEnabled, e.FkAccountHolderEntityId })
                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID90");

                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderRegnNo, e.AccountHolderFullName, e.AccountHolderMobileNo, e.IsKycDone, e.FkAccountHolderStatusTypeId, e.FkAccountHolderEntityId })
                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID8");

                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderFullName, e.AccountHolderMobileNo, e.IsKycDone, e.FkAccountHolderStatusTypeId, e.LoginEnable, e.Aadhaar, e.FkAccountHolderEntityId })
                    .HasName("IX_Account_Entity_ID25");

                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderMobileNo, e.IsKycDone, e.WalletTypeId, e.CustOf, e.Tpin, e.IsTpinenabled, e.FkAccountHolderEntityId })
                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID_TPINKYC");

                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderMobileNo, e.IsKycDone, e.WalletTypeId, e.IsUsageCapEnabled, e.DailyUsageCapCount, e.DailyUsageCapAmount, e.FkAccountHolderEntityId })
                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID44");

                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderMobileNo, e.IsKycDone, e.WalletTypeId, e.Mmid, e.CustOf, e.Tpin, e.IsTpinenabled, e.FkAccountHolderEntityId })
                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID89");

                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderFullName, e.AccountHolderMobileNo, e.IsKycDone, e.WalletTypeId, e.CustOf, e.IsUsageCapEnabled, e.DailyUsageCapCount, e.DailyUsageCapAmount, e.FkAccountHolderEntityId })
                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID2");

                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderFullName, e.AccountHolderMobileNo, e.IsKycDone, e.WalletTypeId, e.Mmid, e.CustOf, e.Tpin, e.IsTpinenabled, e.FkAccountHolderEntityId })
                    .HasName("IX_Account_Holder_FK_Account_Holder_Entity_ID88");

                entity.HasIndex(e => new { e.AccountHolderId, e.AccountHolderFullName, e.AccountHolderPhoneNo, e.AccountHolderMobileNo, e.FkAccountHolderEntityId, e.IsKycDone, e.FkAccountHolderStatusTypeId, e.WalletTypeId, e.CustOf, e.Mmid })
                    .HasName("IX_Account_Holder_MMID");

                entity.Property(e => e.AccountHolderId).HasColumnName("Account_Holder_ID");

                entity.Property(e => e.Aadhaar)
                    .HasColumnName("AADHAAR")
                    .HasMaxLength(299)
                    .IsUnicode(false);

                entity.Property(e => e.Aadhaarhash).HasColumnName("AADHAARHASH");

                entity.Property(e => e.AccountHolderAddress)
                    .IsRequired()
                    .HasColumnName("Account_Holder_Address")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountHolderCourseFeeAmount)
                    .HasColumnName("Account_Holder_CourseFee_Amount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AccountHolderDob)
                    .HasColumnName("Account_Holder_DOB")
                    .HasMaxLength(30);

                entity.Property(e => e.AccountHolderDurationFrom)
                    .HasColumnName("Account_Holder_DurationFrom")
                    .HasColumnType("date");

                entity.Property(e => e.AccountHolderDurationTill)
                    .HasColumnName("Account_Holder_DurationTill")
                    .HasColumnType("date");

                entity.Property(e => e.AccountHolderEmail)
                    .HasColumnName("Account_Holder_Email")
                    .HasMaxLength(100);

                entity.Property(e => e.AccountHolderFullName)
                    .IsRequired()
                    .HasColumnName("Account_Holder_FullName")
                    .HasMaxLength(100);

                entity.Property(e => e.AccountHolderMobileNo)
                    .HasColumnName("Account_Holder_MobileNo")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AccountHolderMobileServiceProvider).HasColumnName("Account_Holder_Mobile_Service_Provider");

                entity.Property(e => e.AccountHolderNameOnCard)
                    .IsRequired()
                    .HasColumnName("Account_Holder_NameOnCard")
                    .HasMaxLength(100);

                entity.Property(e => e.AccountHolderPan)
                    .HasColumnName("Account_Holder_PAN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AccountHolderPhoneNo).HasColumnName("Account_Holder_PhoneNo");

                entity.Property(e => e.AccountHolderPhoto)
                    .HasColumnName("Account_Holder_Photo")
                    .HasColumnType("image");

                entity.Property(e => e.AccountHolderPhotoName)
                    .HasColumnName("Account_Holder_Photo_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountHolderPin)
                    .HasColumnName("Account_Holder_PIN")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountHolderPinIsReset).HasColumnName("Account_Holder_PIN_Is_Reset");

                entity.Property(e => e.AccountHolderPwdEncrypt)
                    .HasColumnName("Account_Holder_Pwd_encrypt")
                    .HasColumnType("varbinary(max)");

                entity.Property(e => e.AccountHolderRegnNo)
                    .IsRequired()
                    .HasColumnName("Account_Holder_RegnNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AccountHolderSignature)
                    .HasColumnName("Account_Holder_Signature")
                    .HasColumnType("image");

                entity.Property(e => e.AccountHolderSignatureName)
                    .HasColumnName("Account_Holder_Signature_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ActualDob)
                    .HasColumnName("ActualDOB")
                    .HasColumnType("date");

                entity.Property(e => e.AndroidVersionCode)
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.AndroidVersionName)
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.BankCbsAccountNumber)
                    .HasColumnName("BankCBS_AccountNumber")
                    .HasMaxLength(299)
                    .IsUnicode(false);

                entity.Property(e => e.BankCbsAccountType)
                    .HasColumnName("BankCBS_AccountType")
                    .HasMaxLength(299)
                    .IsUnicode(false);

                entity.Property(e => e.BankCbsCustomerId)
                    .HasColumnName("BankCBS_CustomerID")
                    .HasMaxLength(299)
                    .IsUnicode(false);

                entity.Property(e => e.BankCbsIfsc)
                    .HasColumnName("BankCBS_IFSC")
                    .HasMaxLength(299)
                    .IsUnicode(false);

                entity.Property(e => e.BlockChainId)
                    .HasColumnName("BlockChainID")
                    .HasMaxLength(299)
                    .IsUnicode(false);

                entity.Property(e => e.CitizenServiceCenterId)
                    .HasColumnName("CitizenServiceCenterID")
                    .HasMaxLength(299)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrAddCountry)
                    .HasMaxLength(2999)
                    .IsUnicode(false);

                entity.Property(e => e.CurrAddDistrict)
                    .HasMaxLength(2999)
                    .IsUnicode(false);

                entity.Property(e => e.CurrAddDoorNo)
                    .HasMaxLength(2999)
                    .IsUnicode(false);

                entity.Property(e => e.CurrAddIsApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrAddLandmark)
                    .HasMaxLength(2999)
                    .IsUnicode(false);

                entity.Property(e => e.CurrAddLocality)
                    .HasMaxLength(2999)
                    .IsUnicode(false);

                entity.Property(e => e.CurrAddPincode)
                    .HasMaxLength(2999)
                    .IsUnicode(false);

                entity.Property(e => e.CurrAddState)
                    .HasMaxLength(2999)
                    .IsUnicode(false);

                entity.Property(e => e.CurrAddStreet)
                    .HasMaxLength(2999)
                    .IsUnicode(false);

                entity.Property(e => e.CurrAddVtc)
                    .HasColumnName("CurrAddVTC")
                    .HasMaxLength(2999)
                    .IsUnicode(false);

                entity.Property(e => e.DigithonDigitalTeacher)
                    .HasMaxLength(299)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.FkAccountHolderBloodGroupTypeId).HasColumnName("FK_Account_Holder_BloodGroupType_ID");

                entity.Property(e => e.FkAccountHolderCourseId).HasColumnName("FK_Account_Holder_Course_ID");

                entity.Property(e => e.FkAccountHolderCreatedBy).HasColumnName("FK_Account_Holder_CreatedBy");

                entity.Property(e => e.FkAccountHolderEntityId).HasColumnName("FK_Account_Holder_Entity_ID");

                entity.Property(e => e.FkAccountHolderHostelId).HasColumnName("FK_Account_Holder_Hostel_ID");

                entity.Property(e => e.FkAccountHolderStatusTypeId).HasColumnName("FK_Account_Holder_StatusType_ID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.IosversionCode)
                    .HasColumnName("IOSVersionCode")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IosversionName)
                    .HasColumnName("IOSVersionName")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.IsDistributor)
                    .HasColumnName("Is_Distributor")
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.IsInAppOtpenable).HasColumnName("IsInAppOTPEnable");

                entity.Property(e => e.IsKycDone)
                    .HasColumnName("Is_KYC_Done")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSmallScaleMerchant).HasColumnName("is_SmallScaleMerchant");

                entity.Property(e => e.IsStatusChecked).HasColumnName("IS_StatusChecked");

                entity.Property(e => e.IsTpinenabled).HasColumnName("IsTPINEnabled");

                entity.Property(e => e.IsUsageCapEnabled)
                    .HasColumnName("isUsageCapEnabled")
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.LastCreditAmount).HasColumnType("decimal(30, 2)");

                entity.Property(e => e.LastCreditOn).HasColumnType("datetime");

                entity.Property(e => e.LastDebitAmount).HasColumnType("decimal(30, 2)");

                entity.Property(e => e.LastDebitOn).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordSetOn).HasColumnType("datetime");

                entity.Property(e => e.LoginEnable).HasDefaultValueSql("('True')");

                entity.Property(e => e.Mmid)
                    .HasColumnName("MMID")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasMaxLength(299)
                    .IsUnicode(false);

                entity.Property(e => e.Pan)
                    .HasColumnName("PAN")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Poa)
                    .HasColumnName("POA")
                    .HasMaxLength(299)
                    .IsUnicode(false);

                entity.Property(e => e.Poaco)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poadist)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Poahouse)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poalm)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Poaloc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poapc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Poapo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Poastate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poastreet)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poasubdist)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Poatype)
                    .HasColumnName("POAType")
                    .HasMaxLength(299)
                    .IsUnicode(false);

                entity.Property(e => e.Poaverified)
                    .HasColumnName("POAVerified")
                    .HasMaxLength(299)
                    .IsUnicode(false);

                entity.Property(e => e.Poavtc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PoavtcCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poi)
                    .HasColumnName("POI")
                    .HasMaxLength(299)
                    .IsUnicode(false);

                entity.Property(e => e.Poidob)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poiemail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Poigender)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Poiname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poiphone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Poitype)
                    .HasColumnName("POIType")
                    .HasMaxLength(299)
                    .IsUnicode(false);

                entity.Property(e => e.Poiverified)
                    .HasColumnName("POIVerified")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.RegisteredbyMobile)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationTypeId).HasColumnName("RegistrationTypeID");

                entity.Property(e => e.RiskStatus)
                    .HasMaxLength(299)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Low Risk')");

                entity.Property(e => e.SecurityAnswer)
                    .HasMaxLength(2999)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityQuestion)
                    .HasMaxLength(2999)
                    .IsUnicode(false);

                entity.Property(e => e.ShowOfferDesc).HasDefaultValueSql("((1))");

                entity.Property(e => e.SmsSenderid)
                    .HasColumnName("SMS_SENDERID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TempAadhaar)
                    .HasColumnName("TempAADHAAR")
                    .HasMaxLength(299)
                    .IsUnicode(false);

                entity.Property(e => e.Tpin)
                    .HasColumnName("TPIN")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TpinEncrypt).HasColumnName("TPIN_Encrypt");

                entity.Property(e => e.Uidtoken)
                    .HasColumnName("UIDToken")
                    .HasMaxLength(299)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpideviceId)
                    .HasColumnName("UPIDeviceID")
                    .HasMaxLength(2999)
                    .IsUnicode(false);

                entity.Property(e => e.Upivpa)
                    .HasColumnName("UPIVPA")
                    .HasMaxLength(299)
                    .IsUnicode(false);

                entity.Property(e => e.WalletTypeId)
                    .HasColumnName("WalletTypeID")
                    .HasDefaultValueSql("('0')");



                entity.Property(e => e.WalletUpgradationDate).HasColumnType("datetime");
            });

            // Configuration for AccountHolder entity
            modelBuilder.Entity<AccountRegistrationVerification>(entity =>
                {
                    // Specify the table name
                    entity.ToTable("Account_Registration_Verification");

                    // Configure indexes
                    entity.HasKey(e => e.Id);

                    // Configure indexes
                    entity.HasIndex(e => e.Mobilenumber)
                        .HasName("IX_Mobilenumber");

                    entity.HasIndex(e => e.EntityName)
                        .HasName("IX_EntityName");

                    entity.HasIndex(e => e.POAType)
                        .HasName("IX_POAType");

                    entity.HasIndex(e => e.POIType)
                        .HasName("IX_POIType");

                    entity.HasIndex(e => e.KYCStatus)
                        .HasName("IX_KYCStatus");

                    entity.HasIndex(e => e.Poiemail)
                        .HasName("IX_Poiemail");

                    entity.HasIndex(e => e.Verifiedby)
                        .HasName("IX_Verifiedby");

                    entity.HasIndex(e => e.VerificationStatus)
                        .HasName("IX_VerificationStatus");

                    entity.HasIndex(e => e.StatusDesc)
                        .HasName("IX_StatusDesc");

                    // Configure column properties
                    entity.Property(e => e.Mobilenumber)
                        .IsRequired()
                        .HasMaxLength(299);

                    entity.Property(e => e.EntityName)
                        .HasMaxLength(299);

                    entity.Property(e => e.POAType)
                        .HasMaxLength(299);

                    entity.Property(e => e.POA)
                        .HasMaxLength(299);

                    entity.Property(e => e.POIType)
                        .HasMaxLength(299);

                    entity.Property(e => e.POI)
                        .HasMaxLength(299);

                    entity.Property(e => e.Name)
                        .HasMaxLength(299);

                    entity.Property(e => e.KYCStatus)
                        .HasMaxLength(299);

                    entity.Property(e => e.Poiemail)
                        .HasMaxLength(299);

                    entity.Property(e => e.Account_Holder_Address)
                        .HasMaxLength(2999);

                    entity.Property(e => e.Verifiedby)
                        .HasMaxLength(299);

                    entity.Property(e => e.VerificationStatus)
                        .HasMaxLength(299);

                    entity.Property(e => e.VerifiedOn)
                        .HasColumnType("datetime");

                    entity.Property(e => e.Remarks)
                        .HasMaxLength(2999);

                    entity.Property(e => e.StatusDesc)
                        .HasMaxLength(299);

                    entity.Property(e => e.StatusCode)
                        .HasMaxLength(299);

                    entity.Property(e => e.Statement)
                        .HasMaxLength(2999);



                });



            modelBuilder.Entity<NameMatchLogin>(entity =>
            {
                // Specify the table name
                entity.ToTable("NameMatchLogin");

                // Configure indexes
                entity.HasKey(e => e.UserId);

                // Configure indexes
                entity.HasIndex(e => e.UserName)
                    .HasName("IX_Mobilenumber");

                entity.HasIndex(e => e.Password)
                    .HasName("IX_EntityName");

                entity.HasIndex(e => e.EmpId)
                    .HasName("IX_POAType");

                entity.HasIndex(e => e.Email)
                    .HasName("IX_POIType");

               



            });



        }
        

        public DbSet<TWelletDemoApp.Models.AccountHolderDT> AccountHolderDT { get; set; }
        

        public DbSet<TWelletDemoApp.Models.NameMatchLogin> NameMatchLogin { get; set; }
    }
}
