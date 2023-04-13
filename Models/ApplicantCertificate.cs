using System;
using System.Collections.Generic;

namespace APP1;

public partial class ApplicantCertificate
{
    public Guid Id { get; set; }

    public Guid? ApplicantId { get; set; }

    public string ConfidentRegNumber { get; set; } = null!;

    public string? Thumbprint { get; set; }

    public string? SerialNumber { get; set; }

    public string? Certificate { get; set; }

    public DateTime? NotBefore { get; set; }

    public DateTime? NotAfter { get; set; }

    public DateTime? PrivateNotBefore { get; set; }

    public DateTime? PrivateNotAfter { get; set; }

    public DateTime? CreationDate { get; set; }
}
