using Clinic.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clinic.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Unit> Units { get; set; }
    public DbSet<Provider> Providers { get; set; }
    public DbSet<Employee> Employees { get; set; }

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
        
        modelBuilder.Entity<Unit>().HasData(
            new Unit { Name = "Упаковка", Abbreviation = "уп" },
            new Unit { Name = "Штука", Abbreviation = "шт" }
            );

        modelBuilder.Entity<Provider>().HasData(
            new Provider { Id = 1, Name = "Аптека", Address = "ул. Ленина, д. 12", Email = "apteka@mail.ru", Phone = "63-52-41" },
            new Provider { Id = 2, Name = "Склад", Address = "ул. Пушкина, д. 15", Email = "sklad@mail.ru", Phone = "96-85-74" }
            );

        modelBuilder.Entity<Employee>().HasData(
            new Employee { Id = 1, Surname = "Иванов", FirstName = "Георгий", PatronymicName = "Владимирович", GenderAsString = "М", BirthDate = new DateTime(1982, 10, 20) },
            new Employee { Id = 2, Surname = "Петрова", FirstName = "Вероника", PatronymicName = "Алексеевна", GenderAsString = "Ж", BirthDate = new DateTime(1990, 3, 18) }
            );
    }
}
