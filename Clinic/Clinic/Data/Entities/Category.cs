using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.Entities;

public class Category
{
    [Key]
    [StringLength(100)]
    public required string Name { get; set; }

    public virtual ObservableCollectionListSource<Product> Products { get; } = new();
}
