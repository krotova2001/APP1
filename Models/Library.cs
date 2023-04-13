using System;
using System.Collections.Generic;

namespace APP1;

public partial class Library
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? FileName { get; set; }

    public Guid LibraryElementId { get; set; }

    public virtual LibraryElement LibraryElement { get; set; } = null!;
}
