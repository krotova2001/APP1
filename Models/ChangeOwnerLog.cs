using System;
using System.Collections.Generic;

namespace APP1;

public partial class ChangeOwnerLog
{
    public long Id { get; set; }

    public Guid ManagerId { get; set; }

    public string? ManagerName { get; set; }

    public Guid PackId { get; set; }

    public string PackName { get; set; } = null!;

    public Guid ApplIdOld { get; set; }

    public string? ApplNameOld { get; set; }

    public Guid ApplIdNew { get; set; }

    public string? ApplNameNew { get; set; }

    public DateTime ChangeDate { get; set; }
}
