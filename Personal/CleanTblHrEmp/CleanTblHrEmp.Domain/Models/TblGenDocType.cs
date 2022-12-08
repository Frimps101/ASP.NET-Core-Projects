﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblGenDocType
{
    public int GdtIdpk { get; set; }

    public string? GdtName { get; set; }

    public string? GdtShtName { get; set; }

    public bool? GdtActive { get; set; }

    public string? GdtRmks { get; set; }

    public string? GdtCreatedBy { get; set; }

    public int? GdtEditedBy { get; set; }

    public DateTime? GdtCreationDate { get; set; }

    public DateTime? GdtEditedDate { get; set; }
}
