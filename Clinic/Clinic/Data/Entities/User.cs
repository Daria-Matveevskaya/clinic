using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.Entities;

/// <summary>
/// Пользователь
/// </summary>
public class User
{
    /// <summary>
    /// Логин
    /// </summary>
    [Key]
    [StringLength(50)]
    public string Login { get; set; } = null!;

    /// <summary>
    /// Пароль
    /// </summary>
    public string Password { get; set; } = null!;

    /// <summary>
    /// Идентификатор сотрудника
    /// </summary>
    public int EmployeeId { get; set; }

    /// <summary>
    /// Сотрудник
    /// </summary>
    [ForeignKey("EmployeeId")]
    public virtual Employee Employee { get; set; } = null!;
}
