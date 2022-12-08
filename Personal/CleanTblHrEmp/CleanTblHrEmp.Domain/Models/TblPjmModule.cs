﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblPjmModule
{
    public int PmdIdpk { get; set; }

    public string? PmdName { get; set; }

    public string? PmdShtName { get; set; }

    public int? PmdProjectIdfk { get; set; }

    public bool? PmdActive { get; set; }

    public string? PmdRmks { get; set; }

    public int? PmdCreatedBy { get; set; }

    public int? PmdEditedBy { get; set; }

    public DateTime? PmdCreationDate { get; set; }

    public DateTime? PmdEditedDate { get; set; }
}
