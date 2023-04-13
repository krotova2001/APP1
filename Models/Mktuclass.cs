using System;
using System.Collections.Generic;

namespace APP1;

public partial class Mktuclass
{
    public Guid Id { get; set; }

    public int IdClass { get; set; }

    public string Name { get; set; } = null!;

    public string Des { get; set; } = null!;

    public string InClass { get; set; } = null!;

    public string NotInClass { get; set; } = null!;

    public virtual ICollection<Mktutherm> Mktutherms { get; set; } = new List<Mktutherm>();
}
