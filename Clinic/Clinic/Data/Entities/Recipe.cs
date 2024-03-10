using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Clinic.Data.Entities;

/// <summary>
/// Приход
/// </summary>
public class Recipe
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Дата
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Идентификатор поставщика
    /// </summary>
    public int ProviderId { get; set; }

    /// <summary>
    /// Поставщик
    /// </summary>
    [ForeignKey("ProviderId")]
    public virtual Provider Provider { get; set; } = null!;

    /// <summary>
    /// Наименование поставщика
    /// Вычисляемое поле (не хранится в БД)
    /// </summary>
    public virtual string ProviderName { get => Provider.Name; }

    /// <summary>
    /// Список позиций
    /// </summary>
    public virtual ObservableCollectionListSource<RecipeItem> RecipeItems { get; } = new();
}
