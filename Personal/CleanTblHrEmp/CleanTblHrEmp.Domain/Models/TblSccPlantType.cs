﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblSccPlantType
{
    public int PtpIdpk { get; set; }

    public string? PtpName { get; set; }

    public string? PtpShtName { get; set; }

    public bool? PtpActive { get; set; }

    public string? PtpRmks { get; set; }

    public int? PtpCreatedBy { get; set; }

    public int? PtpEditedBy { get; set; }

    public DateTime? PtpCreationDate { get; set; }

    public DateTime? PtpEditedDate { get; set; }
}
