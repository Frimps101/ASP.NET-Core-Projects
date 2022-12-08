﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblPmsRole
{
    public int RolIdpk { get; set; }

    public string? RolName { get; set; }

    public string? RolShtName { get; set; }

    public bool? RolActive { get; set; }

    public string? RolRmks { get; set; }

    public int? RolCreatedBy { get; set; }

    public int? RolEditedBy { get; set; }

    public DateTime? RolCreationDate { get; set; }

    public DateTime? RolEditedDate { get; set; }
}
