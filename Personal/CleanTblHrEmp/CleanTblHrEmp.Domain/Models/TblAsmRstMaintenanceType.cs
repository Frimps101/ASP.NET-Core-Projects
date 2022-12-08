﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblAsmRstMaintenanceType
{
    public int MtpIdpk { get; set; }

    public string? MtpName { get; set; }

    public string? MtpShtName { get; set; }

    public bool? MtpPreventiveMaintenance { get; set; }

    public bool? MtpActive { get; set; }

    public string? MtpRmks { get; set; }

    public string? MtpCreatedBy { get; set; }

    public int? MtpEditedBy { get; set; }

    public DateTime? MtpCreationDate { get; set; }

    public DateTime? MtpEditedDate { get; set; }
}
