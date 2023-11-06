using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.Entities;

public class Product
{
    [Key]
    [StringLength(200)]
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public DateTime CreateDate { get; set; }

    [Required]
    [StringLength(100)]
    public required string CategoryName { get; set; }

    [ForeignKey("CategoryName")]
    public virtual Category Category { get; set; } = null!;

}
