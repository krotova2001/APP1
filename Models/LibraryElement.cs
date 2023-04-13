using System;
using System.Collections.Generic;

namespace APP1;

public partial class LibraryElement
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Library> Libraries { get; set; } = new List<Library>();
}
