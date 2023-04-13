using System;
using System.Collections.Generic;

namespace APP1;

public partial class Ipcclass
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Version { get; set; } = null!;

    public int Level { get; set; }

    public Guid? ParentId { get; set; }

    public virtual ICollection<Ipcclass> InverseParent { get; set; } = new List<Ipcclass>();

    public virtual ICollection<Ipcgroup> Ipcgroups { get; set; } = new List<Ipcgroup>();

    public virtual Ipcclass? Parent { get; set; }
}
