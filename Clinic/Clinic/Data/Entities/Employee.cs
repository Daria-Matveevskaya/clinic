using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.Entities;

public class Employee
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(50)]
    public required string Surname { get; set; }

    [Required, MaxLength(50)]
    public required string FirstName { get; set; }

    [MaxLength(50)]
    public string? PatronymicName { get; set; }

    [Column(TypeName = "nchar(1)"), Required]
    public required string GenderAsString { get; set; }

    [NotMapped]
    public GenderType Gender
    {
        get => GenderAsString == "М" ? GenderType.Male : GenderType.Female;
        set => GenderAsString = (value == GenderType.Male) ? "М" : "Ж";
    }

    public DateTime? BirthDate { get; set; }
}

public enum GenderType
{
    Male,
    Female
}
