using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.Entities;

/// <summary>
/// Поставщик
/// </summary>
public class Provider
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Наименование
    /// </summary>
    [MaxLength(200)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Адрес
    /// </summary>
    [MaxLength(100)]
    public string? Address { get; set; }

    /// <summary>
    /// Электронный адрес
    /// </summary>
    [MaxLength(50)]
    public string? Email { get; set; }

    /// <summary>
    /// Номер телефона
    /// </summary>
    [MaxLength(50)]
    public string? Phone { get; set; }
}