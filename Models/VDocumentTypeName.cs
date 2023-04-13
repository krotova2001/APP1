using System;
using System.Collections.Generic;

namespace APP1;

public partial class VDocumentTypeName
{
    public Guid Id { get; set; }

    public Guid PackageId { get; set; }

    public string? Description { get; set; }

    public byte[]? BinaryData { get; set; }

    public string? FileName { get; set; }

    public string? Sign { get; set; }

    public string? Number { get; set; }

    public Guid? DocumentId { get; set; }

    public int Status { get; set; }

    public Guid TypeDocumentId { get; set; }

    public string? XmlData { get; set; }

    public string? Name { get; set; }

    public Guid AuthorId { get; set; }

    public string? FilePath { get; set; }

    public string? SignDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? RegDate { get; set; }

    public DateTime? TransferDate { get; set; }

    public string TypeName { get; set; } = null!;

    public int Type { get; set; }

    public string? MultimediaSign { get; set; }

    public byte[]? SignInfoCert { get; set; }

    public DateTime? SignInfoSignDate { get; set; }

    public byte[]? MultimediaSignInfoCert { get; set; }

    public DateTime? MultimediaSignInfoSignDate { get; set; }
}
