﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblAsmCompAccessory
{
    public int AcsIdpk { get; set; }

    public string? AcsName { get; set; }

    public string? AcsShtName { get; set; }

    public bool? AcsActive { get; set; }

    public string? AcsRmks { get; set; }

    public string? AcsCreatedBy { get; set; }

    public int? AcsEditedBy { get; set; }

    public DateTime? AcsCreationDate { get; set; }

    public DateTime? AcsEditedDate { get; set; }
}
