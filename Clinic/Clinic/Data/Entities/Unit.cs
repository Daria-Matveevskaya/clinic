using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.Entities;

/// <summary>
/// Единица измерения
/// </summary>
public class Unit
{

    /// <summary>
    /// Наименование
    /// </summary>
    [Key]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Обозначение
    /// </summary>
    [StringLength(10)]
    public string Abbreviation { get; set; } = null!;

}
