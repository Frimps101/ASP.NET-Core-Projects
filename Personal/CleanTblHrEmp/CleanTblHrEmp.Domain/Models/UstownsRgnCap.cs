using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class UstownsRgnCap
{
    public string? Town { get; set; }

    public string? ShtName { get; set; }

    public double? Rgnidpk { get; set; }

    public double? Fctyidpk { get; set; }

    public double? Rgncapital { get; set; }
}
