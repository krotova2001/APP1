using System;
using System.Collections.Generic;

namespace APP1;

public partial class SignatureInfo
{
    public Guid Id { get; set; }

    public Guid DocumentId { get; set; }

    public string Signature { get; set; } = null!;

    public int Subject { get; set; }

    public int SignerRole { get; set; }

    public byte[]? Certificate { get; set; }

    public DateTime? SigningDate { get; set; }

    public Guid? TrusteeId { get; set; }

    public virtual Document Document { get; set; } = null!;

    public virtual Applicant? Trustee { get; set; }
}
