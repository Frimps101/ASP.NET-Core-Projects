﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblAsmCompEquipmentType
{
    public int EtpIdpk { get; set; }

    public string? EtpName { get; set; }

    public string? EtpShtName { get; set; }

    public int? EtpHardwareTypeIdfk { get; set; }

    public bool? EtpMonitor { get; set; }

    public bool? EtpKeyboard { get; set; }

    public bool? EtpMouse { get; set; }

    public bool? EtpActive { get; set; }

    public string? EtpRmks { get; set; }

    public string? EtpCreatedBy { get; set; }

    public int? EtpEditedBy { get; set; }

    public DateTime? EtpCreationDate { get; set; }

    public DateTime? EtpEditedDate { get; set; }
}
