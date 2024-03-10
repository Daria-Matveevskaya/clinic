using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.Entities;

/// <summary>
/// Категория товаров
/// </summary>
public class Category
{
    /// <summary>
    /// Наименование
    /// </summary>
    [Key]
    [StringLength(100)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Товары
    /// </summary>
    public virtual ObservableCollectionListSource<Product> Products { get; } = new();
}
