using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.Entities;

public class Provider
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(200)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(100)]
    public string? Address { get; set; }

    [MaxLength(50)]
    public string? Email { get; set; }

    [MaxLength(50)]
    public string? Phone { get; set; }
}