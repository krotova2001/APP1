using System;
using System.Collections.Generic;

namespace APP1;

public partial class TypeTempObj
{
    public int IdTypeObj { get; set; }

    public string? NameType { get; set; }

    public virtual ICollection<TempDataOperation> TempDataOperations { get; set; } = new List<TempDataOperation>();
}
