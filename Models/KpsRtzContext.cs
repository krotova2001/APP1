using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace APP1;

public partial class KpsRtzContext : DbContext
{
    public KpsRtzContext()
    {
    }

    public KpsRtzContext(DbContextOptions<KpsRtzContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Applicant> Applicants { get; set; }

    public virtual DbSet<ApplicantCertificate> ApplicantCertificates { get; set; }

    public virtual DbSet<ApplicantTombstone> ApplicantTombstones { get; set; }

    public virtual DbSet<CategoriesElement> CategoriesElements { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CertificateExp> CertificateExps { get; set; }

    public virtual DbSet<CertificateRl> CertificateRls { get; set; }

    public virtual DbSet<ChangeOwnerLog> ChangeOwnerLogs { get; set; }

    public virtual DbSet<DdCountry> DdCountries { get; set; }

    public virtual DbSet<DdCountryArea> DdCountryAreas { get; set; }

    public virtual DbSet<DdCountryRegion> DdCountryRegions { get; set; }

    public virtual DbSet<DdMessageSender> DdMessageSenders { get; set; }

    public virtual DbSet<DdOrganizationalFormCode> DdOrganizationalFormCodes { get; set; }

    public virtual DbSet<DdOrganizationalFormCode20180423> DdOrganizationalFormCode20180423s { get; set; }

    public virtual DbSet<DdPatentAttorney> DdPatentAttorneys { get; set; }

    public virtual DbSet<DdPatentCompany> DdPatentCompanies { get; set; }

    public virtual DbSet<DdPriority> DdPriorities { get; set; }

    public virtual DbSet<DebugLog> DebugLogs { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<DocumentTombstone> DocumentTombstones { get; set; }

    public virtual DbSet<DocumentType> DocumentTypes { get; set; }

    public virtual DbSet<ErrorMessage> ErrorMessages { get; set; }

    public virtual DbSet<ErrorPackage> ErrorPackages { get; set; }

    public virtual DbSet<ErrorSync> ErrorSyncs { get; set; }

    public virtual DbSet<EventCategory> EventCategories { get; set; }

    public virtual DbSet<EventCategoryToObjectType> EventCategoryToObjectTypes { get; set; }

    public virtual DbSet<EventLog> EventLogs { get; set; }

    public virtual DbSet<EventLogShowElement> EventLogShowElements { get; set; }

    public virtual DbSet<EventLogWriteSubject> EventLogWriteSubjects { get; set; }

    public virtual DbSet<EventType> EventTypes { get; set; }

    public virtual DbSet<Gslist> Gslists { get; set; }

    public virtual DbSet<Ipcclass> Ipcclasses { get; set; }

    public virtual DbSet<Ipcgroup> Ipcgroups { get; set; }

    public virtual DbSet<LastDocumentNumber> LastDocumentNumbers { get; set; }

    public virtual DbSet<Library> Libraries { get; set; }

    public virtual DbSet<LibraryElement> LibraryElements { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<MessageType> MessageTypes { get; set; }

    public virtual DbSet<Mktuclass> Mktuclasses { get; set; }

    public virtual DbSet<Mktutherm> Mktutherms { get; set; }

    public virtual DbSet<News> News { get; set; }

    public virtual DbSet<ObjectType> ObjectTypes { get; set; }

    public virtual DbSet<Package> Packages { get; set; }

    public virtual DbSet<PackageTombstone> PackageTombstones { get; set; }

    public virtual DbSet<PackageTrustee> PackageTrustees { get; set; }

    public virtual DbSet<PpCode> PpCodes { get; set; }

    public virtual DbSet<Sending> Sendings { get; set; }

    public virtual DbSet<SendingDoc> SendingDocs { get; set; }

    public virtual DbSet<SendingsTombstone> SendingsTombstones { get; set; }

    public virtual DbSet<SignatureInfo> SignatureInfos { get; set; }

    public virtual DbSet<SystemSetting> SystemSettings { get; set; }

    public virtual DbSet<TempDataOperation> TempDataOperations { get; set; }

    public virtual DbSet<TempDatum> TempData { get; set; }

    public virtual DbSet<TempDocument> TempDocuments { get; set; }

    public virtual DbSet<TmType> TmTypes { get; set; }

    public virtual DbSet<TypeTempObj> TypeTempObjs { get; set; }

    public virtual DbSet<VDebugLog> VDebugLogs { get; set; }

    public virtual DbSet<VDocSch> VDocSches { get; set; }

    public virtual DbSet<VDocumentType> VDocumentTypes { get; set; }

    public virtual DbSet<VDocumentTypeName> VDocumentTypeNames { get; set; }

    public virtual DbSet<VDocumentXmlDatum> VDocumentXmlData { get; set; }

    public virtual DbSet<VGslist> VGslists { get; set; }

    public virtual DbSet<VPackageAp> VPackageAps { get; set; }

    public virtual DbSet<VPackageDocument> VPackageDocuments { get; set; }

    public virtual DbSet<VTempDataTypeObj> VTempDataTypeObjs { get; set; }

    public virtual DbSet<VTempDocumentType> VTempDocumentTypes { get; set; }

    public virtual DbSet<VTermIdIntClass> VTermIdIntClasses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Applicant>(entity =>
        {
            entity.ToTable("Applicant", tb =>
                {
                    tb.HasTrigger("Applicant_DeletionTrigger");
                    tb.HasTrigger("Applicant_InsertTrigger");
                    tb.HasTrigger("Applicant_UpdateTrigger");
                });

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Building).HasMaxLength(50);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ConfidentRegNumber)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Fax)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FullAddress).HasMaxLength(512);
            entity.Property(e => e.House).HasMaxLength(50);
            entity.Property(e => e.IdentRegNumber).IsUnicode(false);
            entity.Property(e => e.LastEditDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Mail)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Office).HasMaxLength(50);
            entity.Property(e => e.PatentCompanyId)
                .HasMaxLength(37)
                .IsUnicode(false)
                .HasColumnName("PatentCompanyID");
            entity.Property(e => e.Phone)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.Region)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Street)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.WebGridSettings).HasColumnType("text");
        });

        modelBuilder.Entity<ApplicantCertificate>(entity =>
        {
            entity.ToTable("Applicant_Certificate");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Certificate).IsUnicode(false);
            entity.Property(e => e.ConfidentRegNumber).IsUnicode(false);
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NotAfter).HasColumnType("datetime");
            entity.Property(e => e.NotBefore).HasColumnType("datetime");
            entity.Property(e => e.PrivateNotAfter).HasColumnType("datetime");
            entity.Property(e => e.PrivateNotBefore).HasColumnType("datetime");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Thumbprint)
                .HasMaxLength(64)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ApplicantTombstone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PKDEL_Applicant_Tombstone_Id");

            entity.ToTable("Applicant_Tombstone");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DeletionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CategoriesElement>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.CategoryId, "IX_CategoriesElements_CategoryID");

            entity.HasIndex(e => e.ElementId, "IX_CategoriesElements_ElementID");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.ElementId).HasColumnName("ElementID");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasIndex(e => e.ParentId, "IX_Categories_ParentID");

            entity.HasIndex(e => e.Type, "IX_Categories_Type");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.AuthorId).HasColumnName("AuthorID");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('no name')");
            entity.Property(e => e.ParentId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ParentID");
            entity.Property(e => e.So).HasColumnName("SO");
        });

        modelBuilder.Entity<CertificateExp>(entity =>
        {
            entity.ToTable("CertificateExp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Serial)
                .IsUnicode(false)
                .HasColumnName("serial");
            entity.Property(e => e.Week).HasColumnName("week");
        });

        modelBuilder.Entity<CertificateRl>(entity =>
        {
            entity.ToTable("CertificateRL");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateRevoke)
                .HasColumnType("datetime")
                .HasColumnName("date_revoke");
            entity.Property(e => e.Reason)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.Serial)
                .IsUnicode(false)
                .HasColumnName("serial");
        });

        modelBuilder.Entity<ChangeOwnerLog>(entity =>
        {
            entity.ToTable("ChangeOwnerLog");

            entity.Property(e => e.ApplNameNew)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ApplNameOld)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ChangeDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.ManagerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PackName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DdCountry>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DD_COUNTRY");

            entity.HasIndex(e => e.Code, "DD_COUNTRY_CODE").IsClustered();

            entity.Property(e => e.Code)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsOksm).HasColumnName("IsOKSM");
            entity.Property(e => e.IsWipo).HasColumnName("IsWIPO");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Oksm)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("OKSM");
        });

        modelBuilder.Entity<DdCountryArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DD_COUNTRY_AREA");

            entity.HasIndex(e => e.AreaId, "DD_COUNTRY_AREA_area_id").IsClustered();

            entity.Property(e => e.AreaId)
                .HasMaxLength(37)
                .IsUnicode(false)
                .HasColumnName("area_id");
            entity.Property(e => e.CountryId)
                .HasMaxLength(37)
                .IsUnicode(false)
                .HasColumnName("country_id");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DdCountryRegion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DD_COUNTRY_REGION");

            entity.HasIndex(e => e.AreaId, "DD_COUNTRY_REGION_AREA_ID");

            entity.HasIndex(e => e.RegionId, "DD_COUNTRY_REGION_REGION_ID").IsClustered();

            entity.Property(e => e.AreaId)
                .HasMaxLength(37)
                .IsUnicode(false)
                .HasColumnName("AREA_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.RegionId)
                .HasMaxLength(37)
                .IsUnicode(false)
                .HasColumnName("REGION_ID");
        });

        modelBuilder.Entity<DdMessageSender>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dd_message_sender");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DdOrganizationalFormCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DD_ORGANIZATIONAL_FORM_CODE");

            entity.HasIndex(e => e.Code, "DD_OFC_Code").IsClustered();

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODE");
        });

        modelBuilder.Entity<DdOrganizationalFormCode20180423>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DD_ORGANIZATIONAL_FORM_CODE_2018_04_23");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODE");
        });

        modelBuilder.Entity<DdPatentAttorney>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DD_PATENT_ATTORNEY");

            entity.HasIndex(e => e.Code, "DD_PATENT_ATTORNEY_CODE")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.AttorneyCompetence)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("ATTORNEY_COMPETENCE");
            entity.Property(e => e.AttorneyName)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("ATTORNEY_NAME");
            entity.Property(e => e.Code)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.ContactAddrAddrLine1)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CONTACT_ADDR_ADDR_LINE_1");
            entity.Property(e => e.ContactAddrAddrLine2)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CONTACT_ADDR_ADDR_LINE_2");
            entity.Property(e => e.ContactAddrAddressee)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("CONTACT_ADDR_ADDRESSEE");
            entity.Property(e => e.ContactAddrCityName)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CONTACT_ADDR_CITY_NAME");
            entity.Property(e => e.ContactAddrCountryArea)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CONTACT_ADDR_COUNTRY_AREA");
            entity.Property(e => e.ContactAddrCountryCode)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("CONTACT_ADDR_COUNTRY_CODE");
            entity.Property(e => e.ContactAddrCountryReg)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CONTACT_ADDR_COUNTRY_REG");
            entity.Property(e => e.ContactAddrZipCode)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CONTACT_ADDR_ZIP_CODE");
            entity.Property(e => e.ContactComment)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("CONTACT_COMMENT");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CONTACT_EMAIL");
            entity.Property(e => e.ContactFax)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CONTACT_FAX");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CONTACT_PHONE");
            entity.Property(e => e.ContactTelex)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("CONTACT_TELEX");
            entity.Property(e => e.CorcontactAddrAddrLine1)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("CORCONTACT_ADDR_ADDR_LINE_1");
            entity.Property(e => e.CorcontactAddrAddrLine2)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("CORCONTACT_ADDR_ADDR_LINE_2");
            entity.Property(e => e.CorcontactAddrAddressee)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("CORCONTACT_ADDR_ADDRESSEE");
            entity.Property(e => e.CorcontactAddrCityName)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("CORCONTACT_ADDR_CITY_NAME");
            entity.Property(e => e.CorcontactAddrCountryArea)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("CORCONTACT_ADDR_COUNTRY_AREA");
            entity.Property(e => e.CorcontactAddrCountryCode)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("CORCONTACT_ADDR_COUNTRY_CODE");
            entity.Property(e => e.CorcontactAddrCountryReg)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("CORCONTACT_ADDR_COUNTRY_REG");
            entity.Property(e => e.CorcontactAddrZipCode)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("CORCONTACT_ADDR_ZIP_CODE");
            entity.Property(e => e.CorcontactComment)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("CORCONTACT_COMMENT");
            entity.Property(e => e.CorcontactEmail)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("CORCONTACT_EMAIL");
            entity.Property(e => e.CorcontactFax)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("CORCONTACT_FAX");
            entity.Property(e => e.CorcontactPhone)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("CORCONTACT_PHONE");
            entity.Property(e => e.CorcontactTelex)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("CORCONTACT_TELEX");
            entity.Property(e => e.PatentAttorneyCompanyCode)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PATENT_ATTORNEY_COMPANY_CODE");
            entity.Property(e => e.PatentAttorneyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PATENT_ATTORNEY_ID");
            entity.Property(e => e.ValidFrom)
                .HasColumnType("datetime")
                .HasColumnName("VALID_FROM");
            entity.Property(e => e.ValidTo)
                .HasColumnType("datetime")
                .HasColumnName("VALID_TO");
        });

        modelBuilder.Entity<DdPatentCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DD_PATENT_COMPANY");

            entity.Property(e => e.Code)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.ContactAddrAddrLine1)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CONTACT_ADDR_ADDR_LINE_1");
            entity.Property(e => e.ContactAddrAddrLine2)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CONTACT_ADDR_ADDR_LINE_2");
            entity.Property(e => e.ContactAddrAddressee)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("CONTACT_ADDR_ADDRESSEE");
            entity.Property(e => e.ContactAddrCityName)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CONTACT_ADDR_CITY_NAME");
            entity.Property(e => e.ContactAddrCountryArea)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CONTACT_ADDR_COUNTRY_AREA");
            entity.Property(e => e.ContactAddrCountryCode)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("CONTACT_ADDR_COUNTRY_CODE");
            entity.Property(e => e.ContactAddrCountryReg)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CONTACT_ADDR_COUNTRY_REG");
            entity.Property(e => e.ContactAddrZipCode)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("CONTACT_ADDR_ZIP_CODE");
            entity.Property(e => e.ContactComment)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CONTACT_COMMENT");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CONTACT_EMAIL");
            entity.Property(e => e.ContactFax)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CONTACT_FAX");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CONTACT_PHONE");
            entity.Property(e => e.ContactTelex)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("CONTACT_TELEX");
            entity.Property(e => e.Name)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.OrganizationalFormCode)
                .HasMaxLength(37)
                .IsUnicode(false)
                .HasColumnName("ORGANIZATIONAL_FORM_CODE");
            entity.Property(e => e.PatentAttorneyCompanyId)
                .HasMaxLength(37)
                .IsUnicode(false)
                .HasColumnName("PATENT_ATTORNEY_COMPANY_ID");
            entity.Property(e => e.ValidFrom)
                .HasColumnType("datetime")
                .HasColumnName("VALID_FROM");
            entity.Property(e => e.ValidTo)
                .HasColumnType("datetime")
                .HasColumnName("VALID_TO");
        });

        modelBuilder.Entity<DdPriority>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DD_PRIORITY");

            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<DebugLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DebugLog");

            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Info).HasColumnType("text");
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.ToTable("Document", tb =>
                {
                    tb.HasTrigger("Document_DeletionTrigger");
                    tb.HasTrigger("Document_InsertTrigger");
                    tb.HasTrigger("Document_LastOCDate");
                    tb.HasTrigger("Document_UpdateTrigger");
                });

            entity.HasIndex(e => e.PackageId, "IX_Document_PackageId");

            entity.HasIndex(e => e.Status, "IX_Document_Status");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BinaryData).HasColumnType("image");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.FileName).HasColumnType("ntext");
            entity.Property(e => e.FilePath).HasColumnType("ntext");
            entity.Property(e => e.LastEditDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MultimediaSignInfoCertOld).HasColumnName("MultimediaSignInfoCert_old");
            entity.Property(e => e.MultimediaSignInfoSignDateOld)
                .HasColumnType("datetime")
                .HasColumnName("MultimediaSignInfoSignDate_old");
            entity.Property(e => e.MultimediaSignOld)
                .IsUnicode(false)
                .HasColumnName("MultimediaSign_old");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Presentation).HasColumnType("ntext");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.SignDateOld)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SignDate_old");
            entity.Property(e => e.SignInfoCertOld).HasColumnName("SignInfoCert_old");
            entity.Property(e => e.SignInfoSignDateOld)
                .HasColumnType("datetime")
                .HasColumnName("SignInfoSignDate_old");
            entity.Property(e => e.SignOld)
                .IsUnicode(false)
                .HasColumnName("Sign_old");
            entity.Property(e => e.TransferDate).HasColumnType("datetime");
            entity.Property(e => e.TrusteeSignOld)
                .IsUnicode(false)
                .HasColumnName("TrusteeSign_old");
            entity.Property(e => e.XmlData).HasColumnType("xml");

            entity.HasOne(d => d.Author).WithMany(p => p.Documents)
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Document_Applicant");

            entity.HasOne(d => d.DocumentNavigation).WithMany(p => p.InverseDocumentNavigation)
                .HasForeignKey(d => d.DocumentId)
                .HasConstraintName("FK_Document_Document");

            entity.HasOne(d => d.Package).WithMany(p => p.Documents)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("FK_Document_Package");

            entity.HasOne(d => d.TypeDocument).WithMany(p => p.Documents)
                .HasForeignKey(d => d.TypeDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Document_TypeDocument");
        });

        modelBuilder.Entity<DocumentTombstone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PKDEL_Document_Tombstone_Id");

            entity.ToTable("Document_Tombstone");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DeletionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<DocumentType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TypeDocument");

            entity.ToTable("DocumentType");

            entity.HasIndex(e => e.Required, "IX_DocumentType_Required").IsDescending();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(600);
            entity.Property(e => e.IsEdit)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LayoutFileName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.SchemaFileName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.WebLayoutFileName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Xmllayout)
                .HasColumnType("xml")
                .HasColumnName("XMLLayout");
            entity.Property(e => e.Xmlschema)
                .HasColumnType("xml")
                .HasColumnName("XMLSchema");
            entity.Property(e => e.XmlwebLayout)
                .HasColumnType("xml")
                .HasColumnName("XMLWebLayout");
        });

        modelBuilder.Entity<ErrorMessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ErrorMessage");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InnerText)
                .HasColumnType("text")
                .HasColumnName("inner_text");
            entity.Property(e => e.SenderApplication).HasColumnName("sender_application");
            entity.Property(e => e.SenderId).HasColumnName("sender_id");
        });

        modelBuilder.Entity<ErrorPackage>(entity =>
        {
            entity.ToTable("ErrorPackage", tb => tb.HasTrigger("ai_ErrorPackage"));

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ErrorMessage).HasMaxLength(2000);
            entity.Property(e => e.StackTraceMessage).HasColumnType("ntext");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.ErrorPackage)
                .HasForeignKey<ErrorPackage>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ErrorPackage_Sendings");

            entity.HasOne(d => d.Package).WithMany(p => p.ErrorPackages)
                .HasForeignKey(d => d.PackageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ErrorPackage_Package");
        });

        modelBuilder.Entity<ErrorSync>(entity =>
        {
            entity.ToTable("ErrorSync");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.ErrorDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.ErrorMessage).HasMaxLength(4000);
            entity.Property(e => e.StackTrace).HasColumnType("ntext");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<EventCategory>(entity =>
        {
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.EventType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<EventCategoryToObjectType>(entity =>
        {
            entity.ToTable("EventCategoryToObjectType");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.EventCategory).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.EventCategoryNavigation).WithMany(p => p.EventCategoryToObjectTypes)
                .HasForeignKey(d => d.EventCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventCategoryToObjectType_EventCategories");

            entity.HasOne(d => d.ObjectTypeNavigation).WithMany(p => p.EventCategoryToObjectTypes)
                .HasForeignKey(d => d.ObjectType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventCategoryToObjectType_ObjectTypes");
        });

        modelBuilder.Entity<EventLog>(entity =>
        {
            entity.ToTable("EventLog");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EventCategory).HasDefaultValueSql("(newid())");
            entity.Property(e => e.EventDescription)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.EventObjectId).HasColumnName("EventObjectID");
            entity.Property(e => e.EventObjectName)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.EventType).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("IP");
            entity.Property(e => e.ObjectType).HasDefaultValueSql("(newid())");
            entity.Property(e => e.SubjectName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.SubjectUniqueInfo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");

            entity.HasOne(d => d.EventCategoryNavigation).WithMany(p => p.EventLogs)
                .HasForeignKey(d => d.EventCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventLog_EventCategories");

            entity.HasOne(d => d.EventTypeNavigation).WithMany(p => p.EventLogs)
                .HasForeignKey(d => d.EventType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventLog_EventTypes");

            entity.HasOne(d => d.ObjectTypeNavigation).WithMany(p => p.EventLogs)
                .HasForeignKey(d => d.ObjectType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventLog_ObjectTypes");
        });

        modelBuilder.Entity<EventLogShowElement>(entity =>
        {
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.ElementId).HasColumnName("ElementID");
        });

        modelBuilder.Entity<EventLogWriteSubject>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
        });

        modelBuilder.Entity<EventType>(entity =>
        {
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Type)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<Gslist>(entity =>
        {
            entity.ToTable("GSList");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocId).HasColumnName("doc_id");
            entity.Property(e => e.GslistTerms)
                .HasColumnType("text")
                .HasColumnName("gslist_terms");
            entity.Property(e => e.IdClass).HasColumnName("id_class");
            entity.Property(e => e.IsTempData).HasColumnName("isTempData");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Ipcclass>(entity =>
        {
            entity.ToTable("IPCClass");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Version)
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_IPCClass_IPCClass");
        });

        modelBuilder.Entity<Ipcgroup>(entity =>
        {
            entity.ToTable("IPCGroup");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Class)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Subgroup)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Version)
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.HasOne(d => d.ClassNavigation).WithMany(p => p.Ipcgroups)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK_IPCGroup_IPCClass");
        });

        modelBuilder.Entity<LastDocumentNumber>(entity =>
        {
            entity.HasKey(e => e.MakeDate);

            entity.ToTable("LastDocumentNumber");

            entity.Property(e => e.MakeDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Library>(entity =>
        {
            entity.ToTable("Library");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Description).HasColumnType("ntext");
            entity.Property(e => e.FileName).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(120);

            entity.HasOne(d => d.LibraryElement).WithMany(p => p.Libraries)
                .HasForeignKey(d => d.LibraryElementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Library_LibraryElements");
        });

        modelBuilder.Entity<LibraryElement>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(120);
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Message1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Message");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Messages)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_Messages_MessageType");
        });

        modelBuilder.Entity<MessageType>(entity =>
        {
            entity.HasKey(e => e.Type);

            entity.ToTable("MessageType");

            entity.Property(e => e.Type)
                .ValueGeneratedNever()
                .HasColumnName("type");
            entity.Property(e => e.NameType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name_type");
        });

        modelBuilder.Entity<Mktuclass>(entity =>
        {
            entity.ToTable("MKTUClass");

            entity.HasIndex(e => e.IdClass, "IX_MKTUClass_id_class");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Des)
                .HasColumnType("text")
                .HasColumnName("des");
            entity.Property(e => e.IdClass).HasColumnName("id_class");
            entity.Property(e => e.InClass)
                .HasColumnType("text")
                .HasColumnName("in_class");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
            entity.Property(e => e.NotInClass)
                .HasColumnType("text")
                .HasColumnName("not_in_class");
        });

        modelBuilder.Entity<Mktutherm>(entity =>
        {
            entity.ToTable("MKTUTherms");

            entity.HasIndex(e => e.IdClass, "IX_MKTUTherms_id_class");

            entity.HasIndex(e => e.IsDelete, "IX_MKTUTherms_is_delete");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IdAutor).HasColumnName("id_autor");
            entity.Property(e => e.IdClass).HasColumnName("id_class");
            entity.Property(e => e.IdTerm).HasColumnName("id_term");
            entity.Property(e => e.IsDelete)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("is_delete");
            entity.Property(e => e.Name)
                .HasMaxLength(1000)
                .HasColumnName("name");

            entity.HasOne(d => d.IdClassNavigation).WithMany(p => p.Mktutherms)
                .HasForeignKey(d => d.IdClass)
                .HasConstraintName("FK_MKTUTherms_MKTUClass");
        });

        modelBuilder.Entity<News>(entity =>
        {
            entity.Property(e => e.NewsId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.NewsDateTime).HasColumnType("datetime");
            entity.Property(e => e.NewsHeader).HasColumnType("text");
            entity.Property(e => e.NewsPeriod).HasColumnType("datetime");
            entity.Property(e => e.NewsText).HasColumnType("text");
        });

        modelBuilder.Entity<ObjectType>(entity =>
        {
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<Package>(entity =>
        {
            entity.ToTable("Package", tb =>
                {
                    tb.HasTrigger("Package_DeletionTrigger");
                    tb.HasTrigger("Package_InsertTrigger");
                    tb.HasTrigger("Package_UpdateTrigger");
                });

            entity.HasIndex(e => e.ApplicantId, "IX_Package_ApplicantId");

            entity.HasIndex(e => e.TransferDate, "IX_Package_TransferDate").IsDescending();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Applicant)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateOfAnnulment).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(600);
            entity.Property(e => e.FilingDate).HasColumnType("datetime");
            entity.Property(e => e.LastEditDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastOcdate)
                .HasColumnType("datetime")
                .HasColumnName("LastOCDate");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReceptionDate).HasColumnType("datetime");
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.RegNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegistrationDate).HasColumnType("datetime");
            entity.Property(e => e.RegistrationExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.RegistrationNumber).HasMaxLength(50);
            entity.Property(e => e.TransferDate).HasColumnType("datetime");
            entity.Property(e => e.XmlData).HasColumnType("xml");

            entity.HasOne(d => d.ApplicantNavigation).WithMany(p => p.Packages)
                .HasForeignKey(d => d.ApplicantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Package_Applicant");
        });

        modelBuilder.Entity<PackageTombstone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PKDEL_Package_Tombstone_Id");

            entity.ToTable("Package_Tombstone");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DeletionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PackageTrustee>(entity =>
        {
            entity.ToTable("Package_Trustee");

            entity.HasIndex(e => e.ApplicantId, "IX_Package_Trustee_ApplicantId");

            entity.HasIndex(e => e.PackageId, "IX_Package_Trustee_PackageId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Applicant).HasMaxLength(512);
            entity.Property(e => e.ConfidentRegNumber)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.IdentRegNumber).IsUnicode(false);
            entity.Property(e => e.Snils)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("SNILS");

            entity.HasOne(d => d.ApplicantNavigation).WithMany(p => p.PackageTrustees)
                .HasForeignKey(d => d.ApplicantId)
                .HasConstraintName("FK_Package_Trustee_Applicant");

            entity.HasOne(d => d.Package).WithMany(p => p.PackageTrustees)
                .HasForeignKey(d => d.PackageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Package_Trustee_Package");
        });

        modelBuilder.Entity<PpCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pp_Code");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.PpCompetence)
                .HasMaxLength(150)
                .HasColumnName("ppCompetence");
            entity.Property(e => e.PpId).HasColumnName("ppID");
        });

        modelBuilder.Entity<Sending>(entity =>
        {
            entity.HasKey(e => e.IdSending);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("Sendings_DeletionTrigger");
                    tb.HasTrigger("Sendings_InsertTrigger");
                    tb.HasTrigger("Sendings_UpdateTrigger");
                });

            entity.Property(e => e.IdSending)
                .ValueGeneratedNever()
                .HasColumnName("id_sending");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateTime)
                .HasColumnType("datetime")
                .HasColumnName("date_time");
            entity.Property(e => e.IdPackage).HasColumnName("id_package");
            entity.Property(e => e.IsPrpc).HasColumnName("is_prpc");
            entity.Property(e => e.LastEditDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<SendingDoc>(entity =>
        {
            entity.ToTable("SendingDoc");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.IdDoc).HasColumnName("id_doc");
            entity.Property(e => e.IdSending).HasColumnName("id_sending");

            entity.HasOne(d => d.IdSendingNavigation).WithMany(p => p.SendingDocs)
                .HasForeignKey(d => d.IdSending)
                .HasConstraintName("FK_SendingDoc_Sendings1");
        });

        modelBuilder.Entity<SendingsTombstone>(entity =>
        {
            entity.HasKey(e => e.IdSending).HasName("PKDEL_Sendings_Tombstone_id_sending");

            entity.ToTable("Sendings_Tombstone");

            entity.Property(e => e.IdSending)
                .ValueGeneratedNever()
                .HasColumnName("id_sending");
            entity.Property(e => e.DeletionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SignatureInfo>(entity =>
        {
            entity.ToTable("SignatureInfo", tb => tb.HasTrigger("SignatureInfo_DocumentUpdateTrigger"));

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Signature).IsUnicode(false);
            entity.Property(e => e.SigningDate).HasColumnType("datetime");

            entity.HasOne(d => d.Document).WithMany(p => p.SignatureInfos)
                .HasForeignKey(d => d.DocumentId)
                .HasConstraintName("FK_SignatureInfo_Document");

            entity.HasOne(d => d.Trustee).WithMany(p => p.SignatureInfos)
                .HasForeignKey(d => d.TrusteeId)
                .HasConstraintName("FK_SignatureInfo_Applicant");
        });

        modelBuilder.Entity<SystemSetting>(entity =>
        {
            entity.HasKey(e => e.Name);

            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Value).HasColumnType("text");
        });

        modelBuilder.Entity<TempDataOperation>(entity =>
        {
            entity.HasKey(e => e.IdOperation);

            entity.ToTable("TempDataOperation");

            entity.Property(e => e.IdOperation)
                .ValueGeneratedNever()
                .HasColumnName("id_operation");
            entity.Property(e => e.DataOperation)
                .HasColumnType("datetime")
                .HasColumnName("data_operation");
            entity.Property(e => e.IdTypeObj).HasColumnName("id_type_obj");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.IdTypeObjNavigation).WithMany(p => p.TempDataOperations)
                .HasForeignKey(d => d.IdTypeObj)
                .HasConstraintName("FK_TempDataOperation_TypeTempObj1");
        });

        modelBuilder.Entity<TempDatum>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdOperation, e.IdObject });

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.IdOperation).HasColumnName("id_operation");
            entity.Property(e => e.IdObject).HasColumnName("id_object");

            entity.HasOne(d => d.IdOperationNavigation).WithMany(p => p.TempData)
                .HasForeignKey(d => d.IdOperation)
                .HasConstraintName("FK_TempData_TempDataOperation");
        });

        modelBuilder.Entity<TempDocument>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.XmlData).HasColumnType("image");
        });

        modelBuilder.Entity<TmType>(entity =>
        {
            entity.ToTable("tm_types");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<TypeTempObj>(entity =>
        {
            entity.HasKey(e => e.IdTypeObj);

            entity.ToTable("TypeTempObj");

            entity.Property(e => e.IdTypeObj)
                .ValueGeneratedNever()
                .HasColumnName("id_type_obj");
            entity.Property(e => e.NameType)
                .HasMaxLength(250)
                .HasColumnName("name_type");
        });

        modelBuilder.Entity<VDebugLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DebugLog");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Info).HasColumnType("text");
        });

        modelBuilder.Entity<VDocSch>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DocSch");

            entity.Property(e => e.Xmllayout)
                .HasColumnType("image")
                .HasColumnName("XMLLayout");
            entity.Property(e => e.Xmlschema)
                .HasColumnType("image")
                .HasColumnName("XMLSchema");
        });

        modelBuilder.Entity<VDocumentType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DocumentType");

            entity.Property(e => e.AppName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BinaryData).HasColumnType("image");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.DocTypeName).HasMaxLength(120);
            entity.Property(e => e.FileName).HasColumnType("ntext");
            entity.Property(e => e.FilePath).HasColumnType("ntext");
            entity.Property(e => e.MultimediaSign).IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PackageRegNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.Sign).IsUnicode(false);
            entity.Property(e => e.SignDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransferDate).HasColumnType("datetime");
            entity.Property(e => e.WebLayoutFileName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.XmlData).HasColumnType("xml");
        });

        modelBuilder.Entity<VDocumentTypeName>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DocumentTypeName");

            entity.Property(e => e.BinaryData).HasColumnType("image");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.FileName).HasColumnType("ntext");
            entity.Property(e => e.FilePath).HasColumnType("ntext");
            entity.Property(e => e.MultimediaSign).IsUnicode(false);
            entity.Property(e => e.MultimediaSignInfoSignDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.Sign).IsUnicode(false);
            entity.Property(e => e.SignDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SignInfoSignDate).HasColumnType("datetime");
            entity.Property(e => e.TransferDate).HasColumnType("datetime");
            entity.Property(e => e.TypeName).HasMaxLength(120);
            entity.Property(e => e.XmlData).HasColumnType("xml");
        });

        modelBuilder.Entity<VDocumentXmlDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DocumentXmlData");

            entity.Property(e => e.ApplicantName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.DocumentName).HasMaxLength(500);
            entity.Property(e => e.DocumentType).HasMaxLength(120);
            entity.Property(e => e.FileName).HasColumnType("ntext");
            entity.Property(e => e.PackageName).HasMaxLength(200);
            entity.Property(e => e.RegNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.XmlData).HasColumnType("xml");
        });

        modelBuilder.Entity<VGslist>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_GSList");

            entity.Property(e => e.DocId).HasColumnName("doc_id");
            entity.Property(e => e.GslistTerms)
                .HasColumnType("text")
                .HasColumnName("gslist_terms");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdClass).HasColumnName("id_class");
            entity.Property(e => e.IsTempData).HasColumnName("isTempData");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<VPackageAp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Package_ap");

            entity.Property(e => e.Applicant)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(600);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.RegNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransferDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VPackageDocument>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PackageDocuments");

            entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");
            entity.Property(e => e.ApplicantName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BinaryData).HasColumnType("image");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.FileName).HasColumnType("ntext");
            entity.Property(e => e.FilePath).HasColumnType("ntext");
            entity.Property(e => e.LastEditDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PackagePackageId).HasColumnName("PackagePackageID");
            entity.Property(e => e.PackageRegNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegDate).HasColumnType("datetime");
            entity.Property(e => e.Sign).IsUnicode(false);
            entity.Property(e => e.SignDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransferDate).HasColumnType("datetime");
            entity.Property(e => e.XmlData).HasColumnType("image");
        });

        modelBuilder.Entity<VTempDataTypeObj>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_TempDataTypeObj");

            entity.Property(e => e.IdObject).HasColumnName("id_object");
            entity.Property(e => e.IdOperation).HasColumnName("id_operation");
            entity.Property(e => e.IdTypeObj).HasColumnName("id_type_obj");
        });

        modelBuilder.Entity<VTempDocumentType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_TempDocumentType");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.XmlData).HasColumnType("image");
        });

        modelBuilder.Entity<VTermIdIntClass>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_TermIdIntClass");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdAutor).HasColumnName("id_autor");
            entity.Property(e => e.IdClass).HasColumnName("id_class");
            entity.Property(e => e.IdIntClass).HasColumnName("id_int_class");
            entity.Property(e => e.IdTerm).HasColumnName("id_term");
            entity.Property(e => e.IsDelete).HasColumnName("is_delete");
            entity.Property(e => e.Name)
                .HasMaxLength(1000)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
