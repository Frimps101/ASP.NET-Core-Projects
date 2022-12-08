﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblSwdProjectShare
{
    public int PshIdpk { get; set; }

    public int? PshProjectIdfk { get; set; }

    public int? PshEmpIdfk { get; set; }

    public bool? PshOwner { get; set; }

    public bool? PshUpdate { get; set; }

    public bool? PshReader { get; set; }

    public bool? PshSign { get; set; }

    public string? PshType { get; set; }

    public bool? PshRead { get; set; }

    public int? PshCreatedBy { get; set; }

    public DateTime? PshCreationDate { get; set; }

    public int? PshEditedBy { get; set; }

    public DateTime? PshEditedDate { get; set; }
}
