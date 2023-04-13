using System;
using System.Collections.Generic;

namespace APP1;

public partial class News
{
    public Guid NewsId { get; set; }

    public DateTime NewsDateTime { get; set; }

    public string NewsHeader { get; set; } = null!;

    public string NewsText { get; set; } = null!;

    public DateTime NewsPeriod { get; set; }
}
