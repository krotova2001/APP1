using System;
using System.Collections.Generic;

namespace APP1;

public partial class SendingDoc
{
    public Guid Id { get; set; }

    public Guid IdSending { get; set; }

    public Guid IdDoc { get; set; }

    public virtual Sending IdSendingNavigation { get; set; } = null!;
}
