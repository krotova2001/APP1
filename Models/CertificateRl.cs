using System;
using System.Collections.Generic;

namespace APP1;

public partial class CertificateRl
{
    public int Id { get; set; }

    public string Serial { get; set; } = null!;

    public string Reason { get; set; } = null!;

    public DateTime DateRevoke { get; set; }
}
