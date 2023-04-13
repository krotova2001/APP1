using System;
using System.Collections.Generic;

namespace APP1;

public partial class ErrorSync
{
    public Guid Id { get; set; }

    public int ErrorType { get; set; }

    public DateTime ErrorDate { get; set; }

    public string ErrorMessage { get; set; } = null!;

    public string? StackTrace { get; set; }

    public Guid? UserId { get; set; }
}
