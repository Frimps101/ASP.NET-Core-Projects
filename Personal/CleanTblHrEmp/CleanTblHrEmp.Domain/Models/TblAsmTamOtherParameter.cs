﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblAsmTamOtherParameter
{
    public int OpmIdpk { get; set; }

    public string? OpmName { get; set; }

    public string? OpmShtName { get; set; }

    public bool? OpmActive { get; set; }

    public string? OpmRmks { get; set; }

    public string? OpmCreatedBy { get; set; }

    public int? OpmEditedBy { get; set; }

    public DateTime? OpmCreationDate { get; set; }

    public DateTime? OpmEditedDate { get; set; }
}
