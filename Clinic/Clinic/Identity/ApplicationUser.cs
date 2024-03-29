using Clinic.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.Identity;
public class ApplicationUser : IdentityUser
{ 
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
    public string EmployeeFullName { get => Employee!.FullName; }
}
