﻿using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.Entities;

public class Unit
{

    [Key]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [StringLength(10)]
    public string Abbreviation { get; set; } = null!;

}
