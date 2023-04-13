using System;
using System.Collections.Generic;

namespace APP1;

public partial class Message
{
    public Guid Id { get; set; }

    public Guid ApplicantId { get; set; }

    public int Type { get; set; }

    public string Message1 { get; set; } = null!;

    public DateTime Date { get; set; }

    public Guid? TargetId { get; set; }

    public bool IsRead { get; set; }

    public virtual MessageType TypeNavigation { get; set; } = null!;
}
