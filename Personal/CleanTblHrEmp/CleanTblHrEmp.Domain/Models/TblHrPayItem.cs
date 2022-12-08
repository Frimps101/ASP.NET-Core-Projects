﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblHrPayItem
{
    public int PtmIdpk { get; set; }

    public string? PtmName { get; set; }

    public string? PtmShtName { get; set; }

    public bool? PtmActive { get; set; }

    public string? PtmRmks { get; set; }

    public int? PtmCreatedBy { get; set; }

    public int? PtmEditedBy { get; set; }

    public DateTime? PtmCreationDate { get; set; }

    public DateTime? PtmEditedDate { get; set; }
}
