using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.Entities;

public class Unit
{

    [Key]
    [StringLength(50)]
    public required string Name { get; set; }

    [Required]
    [StringLength(10)]
    public required string Abbreviation { get; set; }

}
