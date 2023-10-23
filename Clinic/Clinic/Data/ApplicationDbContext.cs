using Clinic.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clinic.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        => optionsBuilder.UseSqlite("Data Source=Clinic.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { Name = "Препараты" },
            new Category { Name = "Экспресс-тесты на грипп и Covid" },
            new Category { Name = "Расходные материалы" }
            );

        modelBuilder.Entity<Product>().HasData(
            new Product { Name = "Ацетилсалициловая кислота 500 мг", CreateDate = DateTime.Now, CategoryName = "Препараты" },
            new Product { Name = "Парацетамол 500 мг", CreateDate = DateTime.Now, CategoryName = "Препараты" },
            new Product { Name = "Экспресс-тест на грипп", CreateDate = DateTime.Now, CategoryName = "Экспресс-тесты на грипп и Covid" },
            new Product { Name = "Экспресс-тест на Covid", CreateDate = DateTime.Now, CategoryName = "Экспресс-тесты на грипп и Covid" },
            new Product { Name = "Перчатки", CreateDate = DateTime.Now, CategoryName = "Расходные материалы" },
            new Product { Name = "Маска медицинская", CreateDate = DateTime.Now, CategoryName = "Расходные материалы" }
            );
    }
}
