﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblPfmUnitInitiative
{
    public int UinIdpk { get; set; }

    public string? UinName { get; set; }

    public string? UinShtName { get; set; }

    public int? UinOrder { get; set; }

    public bool? UinActive { get; set; }

    public string? UinRmks { get; set; }

    public string? UinCreatedBy { get; set; }

    public int? UinEditedBy { get; set; }

    public DateTime? UinCreationDate { get; set; }

    public DateTime? UinEditedDate { get; set; }
}
