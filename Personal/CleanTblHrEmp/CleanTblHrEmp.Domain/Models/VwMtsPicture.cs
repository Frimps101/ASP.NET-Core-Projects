﻿using System;
using System.Collections.Generic;

namespace CleanTblHrEmp.Domain.Models;

public partial class VwMtsPicture
{
    public int PctIdpk { get; set; }

    public int? PctPicLibraryIdfk { get; set; }

    public byte[]? PctPicture { get; set; }

    public bool? PctActive { get; set; }

    public int? PctCreatedBy { get; set; }

    public int? PctEditedBy { get; set; }

    public DateTime PctCreationDate { get; set; }

    public DateTime? PctEditedDate { get; set; }

    public string? PctFormat { get; set; }

    public int PclIdpk { get; set; }

    public string? PclTitle { get; set; }

    public DateTime? PclDateTaken { get; set; }

    public int? PclFolderIdfk { get; set; }

    public int? PclSubfolderIdfk { get; set; }

    public bool? PclActive { get; set; }

    public string? PclRmks { get; set; }

    public int? FldIdpk { get; set; }

    public string? FldName { get; set; }

    public string? FldShtName { get; set; }

    public int? FldOrder { get; set; }

    public bool? FldActive { get; set; }

    public string? FldRmks { get; set; }

    public int? SbfIdpk { get; set; }

    public string? SbfName { get; set; }

    public string? SbfShtName { get; set; }

    public int? SbfFolderIdfk { get; set; }

    public bool? SbfActive { get; set; }

    public string? SbfRmks { get; set; }

    public string? PclDescription { get; set; }
}
