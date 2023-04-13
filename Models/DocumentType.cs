using System;
using System.Collections.Generic;

namespace APP1;

public partial class DocumentType
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool Required { get; set; }

    public string? SchemaFileName { get; set; }

    public string? LayoutFileName { get; set; }

    public bool AllowUnReg { get; set; }

    public int Type { get; set; }

    public string? WebLayoutFileName { get; set; }

    public bool? IsEdit { get; set; }

    public bool IsAlone { get; set; }

    public Guid? UserId { get; set; }

    public int ApplicationType { get; set; }

    public string? Xmlschema { get; set; }

    public string? Xmllayout { get; set; }

    public string? XmlwebLayout { get; set; }

    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();
}
