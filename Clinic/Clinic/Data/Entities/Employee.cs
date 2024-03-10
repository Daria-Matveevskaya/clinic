using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.Entities;

/// <summary>
/// Сотрудник
/// </summary>
public class Employee
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Фамилия
    /// </summary>
    [Required, MaxLength(50)]
    public string Surname { get; set; } = null!;

    /// <summary>
    /// Имя
    /// </summary>
    [Required, MaxLength(50)]
    public string FirstName { get; set; } = null!;

    /// <summary>
    /// Отчество
    /// </summary>
    [MaxLength(50)]
    public string? PatronymicName { get; set; }

    /// <summary>
    /// Пол (литера)
    /// </summary>
    [Column(TypeName = "nchar(1)"), Required]
    public string GenderAsString { get; set; } = "М";

    /// <summary>
    /// Пол
    /// Вычисляемое поле (не хранится в БД)
    /// </summary>
    [NotMapped]
    public GenderType Gender
    {
        get => GenderAsString == "М" ? GenderType.Male : GenderType.Female;
        set => GenderAsString = (value == GenderType.Male) ? "М" : "Ж";
    }

    /// <summary>
    /// Дата рождения
    /// </summary>
    public DateTime? BirthDate { get; set; }

    /// <summary>
    /// Полное имя
    /// Вычисляемое поле (не хранится в БД)
    /// </summary>
    [NotMapped]
    public string FullName { get => string.Concat($"{Surname} {FirstName[0]}.{PatronymicName![0]}", PatronymicName != null ? "." : ""); }

}

/// <summary>
/// Обозначения для поля Пол
/// Male - мужской
/// Female - женский
/// </summary>
public enum GenderType
{
    Male,
    Female
}
