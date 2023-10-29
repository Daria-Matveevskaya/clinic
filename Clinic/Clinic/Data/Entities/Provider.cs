using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.Entities;

public class Provider
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(200)]
    public required string Name { get; set; }

    [MaxLength(100)]
    public string? Address { get; set; }

    [MaxLength(50)]
    public string? Email { get; set; }

    [MaxLength(50)]
    public string? Phone { get; set; }
}