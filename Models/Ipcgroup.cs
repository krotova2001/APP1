using System;
using System.Collections.Generic;

namespace APP1;

public partial class Ipcgroup
{
    public Guid Id { get; set; }

    public string Class { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? Group { get; set; }

    public string? Subgroup { get; set; }

    public string Version { get; set; } = null!;

    public Guid? ClassId { get; set; }

    public virtual Ipcclass? ClassNavigation { get; set; }
}
