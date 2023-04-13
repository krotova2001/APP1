using System;
using System.Collections.Generic;

namespace APP1;

public partial class PackageTrustee
{
    public Guid Id { get; set; }

    public Guid PackageId { get; set; }

    public Guid? ApplicantId { get; set; }

    public string Applicant { get; set; } = null!;

    public int RowId { get; set; }

    public string ConfidentRegNumber { get; set; } = null!;

    public string? IdentRegNumber { get; set; }

    public string? Snils { get; set; }

    public byte[]? Certificate { get; set; }

    public virtual Applicant? ApplicantNavigation { get; set; }

    public virtual Package Package { get; set; } = null!;
}
