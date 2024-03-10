using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Clinic.Data.Entities;

/// <summary>
/// Расход
/// </summary>
public class Expense
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
    /// Идентификатор сотрудника
    /// </summary>
    public int EmployeeId { get; set; }

    /// <summary>
    /// Сотрудник
    /// </summary>
    [ForeignKey("EmployeeId")]
    public virtual Employee Employee { get; set; } = null!;

    /// <summary>
    /// Полное имя сотрудника
    /// Вычисляемое поле (не хранится в БД)
    /// </summary>
    [NotMapped]
    public string EmployeeFullName { get => Employee.FullName; }

    /// <summary>
    /// Список позиций
    /// </summary>
    public virtual ObservableCollectionListSource<ExpenseItem> ExpenseItems { get; } = new();
}
