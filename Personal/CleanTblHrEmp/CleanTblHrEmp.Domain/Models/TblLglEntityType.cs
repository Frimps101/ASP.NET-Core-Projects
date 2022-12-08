﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblLglEntityType
{
    public short LetIdpk { get; set; }

    public string? LetName { get; set; }

    public string? LetShtName { get; set; }

    public bool? LetActive { get; set; }

    public string? LetRmks { get; set; }

    public int? LetCreatedBy { get; set; }

    public int? LetLastEditedBy { get; set; }

    public DateTime? LetCreationDate { get; set; }

    public DateTime? LetLastEditedDate { get; set; }
}
