using System;
using System.Collections.Generic;

namespace APP1;

public partial class Mktutherm
{
    public Guid Id { get; set; }

    public int IdTerm { get; set; }

    public string Name { get; set; } = null!;

    public Guid IdClass { get; set; }

    public bool? IsDelete { get; set; }

    public Guid? IdAutor { get; set; }

    public virtual Mktuclass IdClassNavigation { get; set; } = null!;
}
