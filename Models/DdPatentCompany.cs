using System;
using System.Collections.Generic;

namespace APP1;

public partial class DdPatentCompany
{
    public string PatentAttorneyCompanyId { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? ContactPhone { get; set; }

    public string? ContactFax { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactComment { get; set; }

    public string? ContactAddrAddressee { get; set; }

    public string? ContactAddrZipCode { get; set; }

    public string? ContactAddrCountryCode { get; set; }

    public string? ContactAddrCountryArea { get; set; }

    public string? ContactAddrCountryReg { get; set; }

    public string? ContactAddrAddrLine1 { get; set; }

    public string? ContactAddrAddrLine2 { get; set; }

    public string? ContactAddrCityName { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string? ContactTelex { get; set; }

    public string? OrganizationalFormCode { get; set; }
}
