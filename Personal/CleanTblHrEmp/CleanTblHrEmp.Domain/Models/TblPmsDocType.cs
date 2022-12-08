﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblPmsDocType
{
    public int DtpIdpk { get; set; }

    public string? DtpName { get; set; }

    public string? DtpShtName { get; set; }

    public byte? DtpOrder { get; set; }

    public bool? DtpActive { get; set; }

    public string? DtpRmks { get; set; }

    public int? DtpCreatedBy { get; set; }

    public int? DtpEditedBy { get; set; }

    public DateTime? DtpCreationDate { get; set; }

    public DateTime? DtpEditedDate { get; set; }
}
