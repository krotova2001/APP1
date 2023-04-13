using System;
using System.Collections.Generic;

namespace APP1;

public partial class DebugLog
{
    public int Id { get; set; }

    public Guid? ApplicantId { get; set; }

    public Guid? PackageId { get; set; }

    public Guid? DocumentId { get; set; }

    public string Info { get; set; } = null!;

    public DateTime Created { get; set; }
}
