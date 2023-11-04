﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.Entities;

public class Category
{
    [Key]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    public virtual ObservableCollectionListSource<Product> Products { get; } = new();
}
