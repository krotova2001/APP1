using System;
using System.Collections.Generic;

namespace APP1;

public partial class Category
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public Guid ParentId { get; set; }

    public int So { get; set; }

    public int Type { get; set; }

    public Guid? AuthorId { get; set; }
}
