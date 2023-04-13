using System;
using System.Collections.Generic;

namespace APP1;

public partial class VDocumentType
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

    public DateTime? CreateDate { get; set; }

    public DateTime? RegDate { get; set; }

    public DateTime? TransferDate { get; set; }

    public int Type { get; set; }

    public string DocTypeName { get; set; } = null!;

    public string? AppName { get; set; }

    public string? SignDate { get; set; }

    public string? PackageRegNumber { get; set; }

    public string? WebLayoutFileName { get; set; }

    public Guid? ParentDocumentId { get; set; }

    public string? MultimediaSign { get; set; }
}
