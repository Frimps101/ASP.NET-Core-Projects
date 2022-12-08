using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class TblTbsSettingsLog
{
    public int StlIdpk { get; set; }

    public int? StlSettingIdfk { get; set; }

    public bool? StlValue { get; set; }

    public int? StlCreatedBy { get; set; }

    public DateTime? StlCreationDate { get; set; }
}
