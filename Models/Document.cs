using System;
using System.Collections.Generic;

namespace APP1;

public partial class Document
{
    public Guid Id { get; set; }

    public Guid PackageId { get; set; }

    public string? Description { get; set; }

    public byte[]? BinaryData { get; set; }

    public string? FileName { get; set; }

    public string? SignOld { get; set; }

    public string? Number { get; set; }

    public Guid? DocumentId { get; set; }

    public int Status { get; set; }

    public Guid TypeDocumentId { get; set; }

    public string? Name { get; set; }

    public Guid AuthorId { get; set; }

    public string? FilePath { get; set; }

    public string? SignDateOld { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? RegDate { get; set; }

    public DateTime? TransferDate { get; set; }

    public Guid? ParentDocumentId { get; set; }

    public DateTime? LastEditDate { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? MultimediaSignOld { get; set; }

    public byte[]? SignInfoCertOld { get; set; }

    public byte[]? MultimediaSignInfoCertOld { get; set; }

    public Guid? AuthorCertificateId { get; set; }

    public DateTime? SignInfoSignDateOld { get; set; }

    public DateTime? MultimediaSignInfoSignDateOld { get; set; }

    public string? TrusteeSignOld { get; set; }

    public string? XmlData { get; set; }

    public string? Presentation { get; set; }

    public virtual Applicant Author { get; set; } = null!;

    public virtual Document? DocumentNavigation { get; set; }

    public virtual ICollection<Document> InverseDocumentNavigation { get; set; } = new List<Document>();

    public virtual Package Package { get; set; } = null!;

    public virtual ICollection<SignatureInfo> SignatureInfos { get; set; } = new List<SignatureInfo>();

    public virtual DocumentType TypeDocument { get; set; } = null!;
}
