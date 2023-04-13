using System;
using System.Collections.Generic;

namespace APP1;

public partial class VDocumentXmlDatum
{
    public Guid Id { get; set; }

    public string? DocumentName { get; set; }

    public string? Description { get; set; }

    public string? FileName { get; set; }

    public string? XmlData { get; set; }

    public string DocumentType { get; set; } = null!;

    public Guid PackageId { get; set; }

    public string PackageName { get; set; } = null!;

    public string? RegNumber { get; set; }

    public Guid ApplicantId { get; set; }

    public string? ApplicantName { get; set; }

    public DateTime? CreateDate { get; set; }
}
