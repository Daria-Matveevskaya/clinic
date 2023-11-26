using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.Entities;

public class Employee
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(50)]
    public string Surname { get; set; } = null!;

    [Required, MaxLength(50)]
    public string FirstName { get; set; } = null!;

    [MaxLength(50)]
    public string? PatronymicName { get; set; }

    [Column(TypeName = "nchar(1)"), Required]
    public string GenderAsString { get; set; } = "М";

    [NotMapped]
    public GenderType Gender
    {
        get => GenderAsString == "М" ? GenderType.Male : GenderType.Female;
        set => GenderAsString = (value == GenderType.Male) ? "М" : "Ж";
    }

    public DateTime? BirthDate { get; set; }

    public virtual string FullName { get => string.Concat($"{Surname} {FirstName[0]}.{PatronymicName![0]}", PatronymicName != null ? "." : ""); }

}

public enum GenderType
{
    Male,
    Female
}
