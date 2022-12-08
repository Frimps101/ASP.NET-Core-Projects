﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblPjmProjectComment
{
    public int PcmIdpk { get; set; }

    public int? PcmProjectIdfk { get; set; }

    public int? PcmEmpIdfk { get; set; }

    public string? PcmComment { get; set; }

    public bool? PcmActive { get; set; }

    public int? PcmCreatedBy { get; set; }

    public int? PcmEditedBy { get; set; }

    public DateTime? PcmCreationDate { get; set; }

    public DateTime? PcmEditedDate { get; set; }
}
