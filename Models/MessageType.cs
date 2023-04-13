using System;
using System.Collections.Generic;

namespace APP1;

public partial class MessageType
{
    public int Type { get; set; }

    public string? NameType { get; set; }

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
}
