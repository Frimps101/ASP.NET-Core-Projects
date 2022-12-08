﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblPfmTarget
{
    public int TgtIdpk { get; set; }

    public string? TgtName { get; set; }

    public string? TgtShtName { get; set; }

    public bool? TgtActive { get; set; }

    public string? TgtRmks { get; set; }

    public string? TgtCreatedBy { get; set; }

    public int? TgtEditedBy { get; set; }

    public DateTime? TgtCreationDate { get; set; }

    public DateTime? TgtEditedDate { get; set; }
}
