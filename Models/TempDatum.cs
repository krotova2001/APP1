using System;
using System.Collections.Generic;

namespace APP1;

public partial class TempDatum
{
    public Guid Id { get; set; }

    public Guid IdOperation { get; set; }

    public Guid IdObject { get; set; }

    public virtual TempDataOperation IdOperationNavigation { get; set; } = null!;
}
