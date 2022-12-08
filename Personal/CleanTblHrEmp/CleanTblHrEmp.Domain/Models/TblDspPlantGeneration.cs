using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblDspPlantGeneration
{
    public int FpgnIdpk { get; set; }

    public string? FpgnName { get; set; }

    public double? FpgnMw { get; set; }

    public double? FpgnMvar { get; set; }
}
