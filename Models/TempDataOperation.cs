using System;
using System.Collections.Generic;

namespace APP1;

public partial class TempDataOperation
{
    public Guid IdOperation { get; set; }

    public int? IdTypeObj { get; set; }

    public Guid? IdUser { get; set; }

    public DateTime? DataOperation { get; set; }

    public virtual TypeTempObj? IdTypeObjNavigation { get; set; }

    public virtual ICollection<TempDatum> TempData { get; set; } = new List<TempDatum>();
}
