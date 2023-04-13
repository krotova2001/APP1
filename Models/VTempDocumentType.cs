using System;
using System.Collections.Generic;

namespace APP1;

public partial class VTempDocumentType
{
    public Guid Id { get; set; }

    public byte[]? XmlData { get; set; }

    public Guid AuthorId { get; set; }

    public DateTime? CreateDate { get; set; }
}
