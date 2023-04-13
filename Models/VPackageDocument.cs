using System;
using System.Collections.Generic;

namespace APP1;

public partial class VPackageDocument
{
    public Guid ApplicantId { get; set; }

    public string? ApplicantName { get; set; }

    public Guid PackagePackageId { get; set; }

    public string? PackageRegNumber { get; set; }

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

    public byte[]? XmlData { get; set; }

    public string? Name { get; set; }

    public Guid AuthorId { get; set; }

    public string? FilePath { get; set; }

    public string? SignDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? RegDate { get; set; }

    public DateTime? TransferDate { get; set; }

    public Guid? ParentDocumentId { get; set; }

    public DateTime? LastEditDate { get; set; }

    public DateTime? CreationDate { get; set; }
}
