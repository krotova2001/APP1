using System;
using System.Collections.Generic;

namespace APP1;

public partial class ErrorMessage
{
    public Guid Id { get; set; }

    public string InnerText { get; set; } = null!;

    public Guid SenderId { get; set; }

    public Guid SenderApplication { get; set; }
}
