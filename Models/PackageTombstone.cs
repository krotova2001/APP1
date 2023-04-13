using System;
using System.Collections.Generic;

namespace APP1;

public partial class PackageTombstone
{
    public Guid Id { get; set; }

    public DateTime? DeletionDate { get; set; }
}
