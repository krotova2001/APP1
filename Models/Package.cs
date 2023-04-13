using System;
using System.Collections.Generic;

namespace APP1;

public partial class Package
{
    public Guid Id { get; set; }

    public string? RegNumber { get; set; }

    public Guid ApplicantId { get; set; }

    public DateTime? TransferDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? RegDate { get; set; }

    public string? Description { get; set; }

    public int Status { get; set; }

    public string Name { get; set; } = null!;

    public string Applicant { get; set; } = null!;

    public int TransferMethod { get; set; }

    public string? Number { get; set; }

    public DateTime? LastEditDate { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? FilingDate { get; set; }

    public DateTime? ReceptionDate { get; set; }

    public DateTime? DateOfAnnulment { get; set; }

    public string? RegistrationNumber { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public DateTime? RegistrationExpirationDate { get; set; }

    public DateTime? LastOcdate { get; set; }

    public int ApplicationType { get; set; }

    public string? XmlData { get; set; }

    public virtual Applicant ApplicantNavigation { get; set; } = null!;

    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    public virtual ICollection<ErrorPackage> ErrorPackages { get; set; } = new List<ErrorPackage>();

    public virtual ICollection<PackageTrustee> PackageTrustees { get; set; } = new List<PackageTrustee>();
}
