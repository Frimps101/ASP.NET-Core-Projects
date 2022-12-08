﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class VwGenIssueShare
{
    public int IshIdpk { get; set; }

    public int? IshIssueLogIdfk { get; set; }

    public int? IshEmpIdfk { get; set; }

    public bool? IshOwner { get; set; }

    public bool? IshUpdate { get; set; }

    public bool? IshReader { get; set; }

    public bool? IshSign { get; set; }

    public string? IshType { get; set; }

    public bool? IshRead { get; set; }

    public int EmpIdpk { get; set; }

    public string? EmpStaffNo { get; set; }

    public string? EmpLastName { get; set; }

    public string? EmpFirstName { get; set; }

    public string EmpOthernames { get; set; } = null!;

    public string EmpLegacyName { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? EmpName1 { get; set; }

    public string? EmpName2 { get; set; }

    public string? EmpName3 { get; set; }

    public string? EmpName4 { get; set; }

    public int DptIdpk { get; set; }

    public string DptName { get; set; } = null!;

    public string DptShtName { get; set; } = null!;

    public int SxnIdpk { get; set; }

    public string SxnName { get; set; } = null!;

    public string SxnShtName { get; set; } = null!;

    public int UntIdpk { get; set; }

    public string UntName { get; set; } = null!;

    public string UntShtName { get; set; } = null!;

    public int LocIdpk { get; set; }

    public string LocName { get; set; } = null!;

    public string LocShtName { get; set; } = null!;

    public int JbtIdpk { get; set; }

    public string JbtName { get; set; } = null!;

    public string JbtShtName { get; set; } = null!;

    public int IlgIdpk { get; set; }

    public DateTime? IlgDueDate { get; set; }

    public DateTime? IlgCompletionDate { get; set; }

    public DateTime? IlgUpdateDate { get; set; }
}
