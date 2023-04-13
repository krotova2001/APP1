using System;
using System.Collections.Generic;

namespace APP1;

public partial class ErrorPackage
{
    public Guid Id { get; set; }

    public Guid PackageId { get; set; }

    public string ErrorMessage { get; set; } = null!;

    public string? StackTraceMessage { get; set; }

    public DateTime CreateDate { get; set; }

    public int? ErrorType { get; set; }

    public virtual Sending IdNavigation { get; set; } = null!;

    public virtual Package Package { get; set; } = null!;
}
