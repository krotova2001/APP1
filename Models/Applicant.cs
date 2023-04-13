using System;
using System.Collections.Generic;

namespace APP1;

public partial class Applicant
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public DateTime? RegDate { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Mail { get; set; }

    public int? ApplicantType { get; set; }

    public string ConfidentRegNumber { get; set; } = null!;

    public string? WebGridSettings { get; set; }

    public bool? IsBlocked { get; set; }

    public int? PostIndex { get; set; }

    public string? State { get; set; }

    public string? Region { get; set; }

    public string? City { get; set; }

    public string? Street { get; set; }

    public string? House { get; set; }

    public string? Building { get; set; }

    public string? Office { get; set; }

    public DateTime? LastEditDate { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? PatentCompanyId { get; set; }

    public string? IdentRegNumber { get; set; }

    public string? FullAddress { get; set; }

    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    public virtual ICollection<PackageTrustee> PackageTrustees { get; set; } = new List<PackageTrustee>();

    public virtual ICollection<Package> Packages { get; set; } = new List<Package>();

    public virtual ICollection<SignatureInfo> SignatureInfos { get; set; } = new List<SignatureInfo>();
}
