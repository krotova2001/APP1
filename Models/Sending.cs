using System;
using System.Collections.Generic;

namespace APP1;

public partial class Sending
{
    public Guid IdSending { get; set; }

    public Guid IdPackage { get; set; }

    public DateTime DateTime { get; set; }

    public bool IsPrpc { get; set; }

    public DateTime? LastEditDate { get; set; }

    public DateTime? CreationDate { get; set; }

    public virtual ErrorPackage? ErrorPackage { get; set; }

    public virtual ICollection<SendingDoc> SendingDocs { get; set; } = new List<SendingDoc>();
}
