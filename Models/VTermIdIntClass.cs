using System;
using System.Collections.Generic;

namespace APP1;

public partial class VTermIdIntClass
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public Guid IdClass { get; set; }

    public bool IsDelete { get; set; }

    public int IdIntClass { get; set; }

    public int IdTerm { get; set; }

    public Guid? IdAutor { get; set; }
}
