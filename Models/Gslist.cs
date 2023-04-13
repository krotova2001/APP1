using System;
using System.Collections.Generic;

namespace APP1;

public partial class Gslist
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public int? IdClass { get; set; }

    public string? GslistTerms { get; set; }

    public int? IsTempData { get; set; }

    public Guid? DocId { get; set; }

    public DateTime CreationDate { get; set; }
}
