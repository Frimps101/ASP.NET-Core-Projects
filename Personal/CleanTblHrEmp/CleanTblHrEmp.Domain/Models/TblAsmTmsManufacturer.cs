﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblAsmTmsManufacturer
{
    public int MftIdpk { get; set; }

    public string? MftName { get; set; }

    public string? MftShtName { get; set; }

    public bool? MftActive { get; set; }

    public string? MftRmks { get; set; }

    public string? MftCreatedBy { get; set; }

    public int? MftEditedBy { get; set; }

    public DateTime? MftCreationDate { get; set; }

    public DateTime? MftEditedDate { get; set; }
}
