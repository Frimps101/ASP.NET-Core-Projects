﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblAsmTmsMaintenanceActivityUpdate
{
    public int MauIdpk { get; set; }

    public DateTime? MauDate { get; set; }

    public int? MauMaintActivityIdfk { get; set; }

    public int? MauJobIdfk { get; set; }

    public string? MauActivityUpdate { get; set; }

    public decimal? MauPercentComplete { get; set; }

    public DateTime? MauCompletionDate { get; set; }

    public bool? MauActive { get; set; }

    public string? MauRmks { get; set; }

    public string? MauCreatedBy { get; set; }

    public int? MauEditedBy { get; set; }

    public DateTime? MauCreationDate { get; set; }

    public DateTime? MauEditedDate { get; set; }
}
