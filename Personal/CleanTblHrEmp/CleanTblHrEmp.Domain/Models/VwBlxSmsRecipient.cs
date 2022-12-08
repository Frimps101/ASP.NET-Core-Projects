﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class VwBlxSmsRecipient
{
    public int SrpIdpk { get; set; }

    public int? SrpCustomerIdfk { get; set; }

    public string SrpName { get; set; } = null!;

    public string SrpSmsName { get; set; } = null!;

    public string SrpMobNo { get; set; } = null!;

    public string SrpEmail { get; set; } = null!;

    public bool? SrpActive { get; set; }

    public string? SrpRmks { get; set; }

    public int FcustIdpk { get; set; }

    public string? FcustName { get; set; }

    public string? FcustShtName { get; set; }

    public string? CustName { get; set; }

    public string? FcustAddress { get; set; }

    public string? FcustSalutation { get; set; }

    public string? FcustContact { get; set; }

    public string? FcustEmail { get; set; }

    public string? FcustMobNo { get; set; }

    public string? FcustTelNo { get; set; }

    public double? FcustCurntRlr { get; set; }

    public double? FcustCurntTsr { get; set; }

    public bool? FcustActive { get; set; }

    public string? CurntCtpName { get; set; }

    public string? CurntCtpShtName { get; set; }

    public int? CurntCurrIdpk { get; set; }

    public string? CurntCurrName { get; set; }

    public string? CurntCurrShtName { get; set; }

    public string? CurntCurrSymbol { get; set; }

    public bool? CurntCurrForeign { get; set; }

    public bool? CurntCurrActive { get; set; }

    public bool? CurntCtpActive { get; set; }

    public DateTime? FcustSetupDate { get; set; }

    public DateTime? FcustEndDate { get; set; }

    public string? FcustRefNo { get; set; }

    public string FcustSmsName { get; set; } = null!;

    public string FcustEmailName { get; set; } = null!;
}
