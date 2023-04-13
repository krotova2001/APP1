using System;
using System.Collections.Generic;

namespace APP1;

public partial class CertificateExp
{
    public int Id { get; set; }

    public string Serial { get; set; } = null!;

    public int Week { get; set; }

    public int Month { get; set; }
}
