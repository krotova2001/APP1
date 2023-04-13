using System;
using System.Collections.Generic;

namespace APP1;

public partial class DdCountry
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Oksm { get; set; }

    public bool IsWipo { get; set; }

    public bool IsOksm { get; set; }
}
