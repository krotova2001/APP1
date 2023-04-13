using System;
using System.Collections.Generic;

namespace APP1;

public partial class DocumentTombstone
{
    public Guid Id { get; set; }

    public DateTime? DeletionDate { get; set; }
}
