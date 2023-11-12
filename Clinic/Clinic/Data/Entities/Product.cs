using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.Entities;

public class Product
{
    [Key]
    [StringLength(200)]
    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime CreateDate { get; set; }

    [StringLength(100)]
    public string CategoryName { get; set; } = null!;

    [ForeignKey("CategoryName")]
    public virtual Category Category { get; set; } = null!;

}
