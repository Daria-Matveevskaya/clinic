using Clinic.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clinic.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Unit> Units { get; set; }
    public DbSet<Provider> Providers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<RecipeItem> RecipeItems { get; set; }
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<ExpenseItem> ExpenseItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Clinic;Username=postgres;Password=postgres;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { Name = "Препараты" },
            new Category { Name = "Экспресс-тесты на грипп и Covid" },
            new Category { Name = "Расходные материалы" }
            );

        modelBuilder.Entity<Product>().HasData(
            new Product { Name = "Ацетилсалициловая кислота 500 мг", CategoryName = "Препараты" },
            new Product { Name = "Парацетамол 500 мг", CategoryName = "Препараты" },
            new Product { Name = "Экспресс-тест на грипп", CategoryName = "Экспресс-тесты на грипп и Covid" },
            new Product { Name = "Экспресс-тест на Covid", CategoryName = "Экспресс-тесты на грипп и Covid" },
            new Product { Name = "Перчатки", CategoryName = "Расходные материалы" },
            new Product { Name = "Маска медицинская", CategoryName = "Расходные материалы" }
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

        modelBuilder.Entity<Recipe>().HasData(
            new Recipe { Id = 1, Date = new DateTime(2023, 02, 01), ProviderId = 1 },
            new Recipe { Id = 2, Date = new DateTime(2023, 03, 01), ProviderId = 2 }
            );

        modelBuilder.Entity<RecipeItem>().HasData(
            new RecipeItem { Id = 1, RecipeId = 1, ProductName = "Парацетамол 500 мг", UnitName = "Штука", Quantity = 10, ExpirationDate = new DateTime(2023, 12, 01) },
            new RecipeItem { Id = 2, RecipeId = 2, ProductName = "Парацетамол 500 мг", UnitName = "Штука", Quantity = 20, ExpirationDate = new DateTime(2023, 12, 01) },
            new RecipeItem { Id = 3, RecipeId = 1, ProductName = "Парацетамол 500 мг", UnitName = "Штука", Quantity = 20, ExpirationDate = new DateTime(2024, 12, 01) },
            new RecipeItem { Id = 4, RecipeId = 1, ProductName = "Ацетилсалициловая кислота 500 мг", UnitName = "Штука", Quantity = 15, ExpirationDate = new DateTime(2023, 12, 01) },
            new RecipeItem { Id = 5, RecipeId = 2, ProductName = "Ацетилсалициловая кислота 500 мг", UnitName = "Штука", Quantity = 25, ExpirationDate = new DateTime(2023, 12, 01) },
            new RecipeItem { Id = 6, RecipeId = 2, ProductName = "Ацетилсалициловая кислота 500 мг", UnitName = "Штука", Quantity = 25, ExpirationDate = new DateTime(2024, 12, 01) },
            new RecipeItem { Id = 7, RecipeId = 1, ProductName = "Экспресс-тест на грипп", UnitName = "Штука", Quantity = 10, ExpirationDate = new DateTime(2024, 12, 01) },
            new RecipeItem { Id = 8, RecipeId = 2, ProductName = "Экспресс-тест на грипп", UnitName = "Штука", Quantity = 12, ExpirationDate = new DateTime(2024, 12, 01) },
            new RecipeItem { Id = 9, RecipeId = 1, ProductName = "Экспресс-тест на Covid", UnitName = "Штука", Quantity = 16, ExpirationDate = new DateTime(2024, 12, 01) },
            new RecipeItem { Id = 10, RecipeId = 2, ProductName = "Экспресс-тест на Covid", UnitName = "Штука", Quantity = 14, ExpirationDate = new DateTime(2024, 12, 01) },
            new RecipeItem { Id = 11, RecipeId = 2, ProductName = "Перчатки", UnitName = "Упаковка", Quantity = 10, ExpirationDate = new DateTime(2026, 12, 01) },
            new RecipeItem { Id = 12, RecipeId = 2, ProductName = "Маска медицинская", UnitName = "Упаковка", Quantity = 12, ExpirationDate = new DateTime(2028, 12, 01) }
            );

        modelBuilder.Entity<Expense>().HasData(
            new Expense { Id = 1, Date = new DateTime(2023, 02, 01), EmployeeId = 1 },
            new Expense { Id = 2, Date = new DateTime(2023, 03, 01), EmployeeId = 2 }
            );

        modelBuilder.Entity<ExpenseItem>().HasData(
            new ExpenseItem { Id = 1, ExpenseId = 1, ProductName = "Парацетамол 500 мг", UnitName = "Штука", Quantity = 3, ExpirationDate = new DateTime(2023, 12, 01) },
            new ExpenseItem { Id = 2, ExpenseId = 1, ProductName = "Ацетилсалициловая кислота 500 мг", UnitName = "Штука", Quantity = 10, ExpirationDate = new DateTime(2023, 12, 01) },
            new ExpenseItem { Id = 3, ExpenseId = 1, ProductName = "Экспресс-тест на грипп", UnitName = "Штука", Quantity = 2 },
            new ExpenseItem { Id = 4, ExpenseId = 1, ProductName = "Экспресс-тест на Covid", UnitName = "Штука", Quantity = 8 },
            new ExpenseItem { Id = 5, ExpenseId = 2, ProductName = "Парацетамол 500 мг", UnitName = "Штука", Quantity = 7, ExpirationDate = new DateTime(2023, 12, 01) },
            new ExpenseItem { Id = 6, ExpenseId = 2, ProductName = "Ацетилсалициловая кислота 500 мг", UnitName = "Штука", Quantity = 3, ExpirationDate = new DateTime(2023, 12, 01) },
            new ExpenseItem { Id = 7, ExpenseId = 2, ProductName = "Экспресс-тест на грипп", UnitName = "Штука", Quantity = 3 },
            new ExpenseItem { Id = 8, ExpenseId = 2, ProductName = "Перчатки", UnitName = "Упаковка", Quantity = 1 },
            new ExpenseItem { Id = 9, ExpenseId = 2, ProductName = "Маска медицинская", UnitName = "Упаковка", Quantity = 2 }
            );
    }
}
