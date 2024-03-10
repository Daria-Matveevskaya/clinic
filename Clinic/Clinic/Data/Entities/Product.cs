using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.Entities;

/// <summary>
/// Товар
/// </summary>
public class Product
{
    /// <summary>
    /// Наименование
    /// </summary>
    [Key]
    [StringLength(200)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Описание
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Наименование категории
    /// </summary>
    [StringLength(100)]
    public string CategoryName { get; set; } = null!;

    /// <summary>
    /// Категория
    /// </summary>
    [ForeignKey("CategoryName")]
    public virtual Category Category { get; set; } = null!;

}
