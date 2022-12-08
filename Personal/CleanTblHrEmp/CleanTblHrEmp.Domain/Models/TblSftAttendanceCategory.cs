﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblSftAttendanceCategory
{
    public int AtcIdpk { get; set; }

    public string? AtcName { get; set; }

    public string? AtcShtName { get; set; }

    public bool? AtcPresent { get; set; }

    public bool AtcPresentExternal { get; set; }

    public decimal? AtcWeight { get; set; }

    public decimal? AtcOrder { get; set; }

    public bool? AtcExempt { get; set; }

    public bool? AtcActive { get; set; }

    public string? AtcRmks { get; set; }

    public int? AtcCreatedBy { get; set; }

    public int? AtcEditedBy { get; set; }

    public DateTime? AtcCreationDate { get; set; }

    public DateTime? AtcEditedDate { get; set; }
}
