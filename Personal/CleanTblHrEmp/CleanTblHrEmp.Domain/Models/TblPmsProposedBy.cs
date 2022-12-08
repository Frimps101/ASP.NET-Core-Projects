﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblPmsProposedBy
{
    public int PrbIdpk { get; set; }

    public string? PrbName { get; set; }

    public string? PrbShtName { get; set; }

    public bool? PrbActive { get; set; }

    public string? PrbRmks { get; set; }

    public int? PrbCreatedBy { get; set; }

    public int? PrbEditedBy { get; set; }

    public DateTime? PrbCreationDate { get; set; }

    public DateTime? PrbEditedDate { get; set; }
}
