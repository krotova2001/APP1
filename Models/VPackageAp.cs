using System;
using System.Collections.Generic;

namespace APP1;

public partial class VPackageAp
{
    public string Name { get; set; } = null!;

    public Guid Id { get; set; }

    public string? RegNumber { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? RegDate { get; set; }

    public string? Applicant { get; set; }

    public Guid ApplicantId { get; set; }

    public DateTime? TransferDate { get; set; }

    public string? Description { get; set; }

    public int Status { get; set; }
}
