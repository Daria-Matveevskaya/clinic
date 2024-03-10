using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.Entities;

/// <summary>
/// Позиция прихода
/// </summary>
public class RecipeItem
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Идентификатор прихода
    /// </summary>
    public int RecipeId { get; set; }

    /// <summary>
    /// Наименование товара
    /// </summary>
    [StringLength(200)]
    public string ProductName { get; set; } = null!;

    /// <summary>
    /// Наименование единицы измерения
    /// </summary>
    [StringLength(50)]
    public string UnitName { get; set; } = null!;

    /// <summary>
    /// Количество
    /// </summary>
    public double Quantity { get; set; }

    /// <summary>
    /// Срок годности
    /// </summary>
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// Приход
    /// </summary>
    [ForeignKey("RecipeId")]
    public virtual Recipe Recipe { get; set; } = null!;

    /// <summary>
    /// Товар
    /// </summary>
    [ForeignKey("ProductName")]
    public virtual Product Product { get; set; } = null!;

    /// <summary>
    /// Единица измерения
    /// </summary>
    [ForeignKey("UnitName")]
    public virtual Unit Unit { get; set; } = null!;
}
