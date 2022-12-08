﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblAsmCompAccessoryValue
{
    public int AcvIdpk { get; set; }

    public string? AcvName { get; set; }

    public string? AcvShtName { get; set; }

    public bool? AcvActive { get; set; }

    public string? AcvRmks { get; set; }

    public string? AcvCreatedBy { get; set; }

    public int? AcvEditedBy { get; set; }

    public DateTime? AcvCreationDate { get; set; }

    public DateTime? AcvEditedDate { get; set; }
}
