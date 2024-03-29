using Clinic.Data.Entities;
using Clinic.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Clinic.Data
{
    public class ApplicationDbContextInitialiser
    {
        private readonly ILogger<ApplicationDbContextInitialiser> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public ApplicationDbContextInitialiser(ILogger<ApplicationDbContextInitialiser> logger, ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task InitialiseAsync()
        {
            try
            {
                await _context.Database.MigrateAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while initialising the database.");
                throw;
            }
        }

        public async Task SeedAsync()
        {
            try
            {
                await TrySeedAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while seeding the database.");
                throw;
            }
        }

        public async Task TrySeedAsync()
        {
            // Default data
            // Seed, if necessary
            if (!_context.Categories.Any())
            {
                _context.Categories.AddRange(
                    new() { Name = "Препараты" },
                    new() { Name = "Экспресс-тесты на грипп и Covid" },
                    new() { Name = "Расходные материалы" });

                await _context.SaveChangesAsync();
            }

            if (!_context.Products.Any())
            {
                _context.Products.AddRange(
                    new() { Name = "Ацетилсалициловая кислота 500 мг", CategoryName = "Препараты" },
                    new() { Name = "Парацетамол 500 мг", CategoryName = "Препараты" },
                    new() { Name = "Экспресс-тест на грипп", CategoryName = "Экспресс-тесты на грипп и Covid" },
                    new() { Name = "Экспресс-тест на Covid", CategoryName = "Экспресс-тесты на грипп и Covid" },
                    new() { Name = "Перчатки", CategoryName = "Расходные материалы" },
                    new() { Name = "Маска медицинская", CategoryName = "Расходные материалы" });

                await _context.SaveChangesAsync();
            }

            if (!_context.Units.Any())
            {
                _context.Units.AddRange(
                    new() { Name = "Упаковка", Abbreviation = "уп" },
                    new() { Name = "Штука", Abbreviation = "шт" });

                await _context.SaveChangesAsync();
            }

            if (!_context.Providers.Any())
            {
                _context.Providers.AddRange(
                    new() { Id = 1, Name = "Аптека", Address = "ул. Ленина, д. 12", Email = "apteka@mail.ru", Phone = "63-52-41" },
                    new() { Id = 2, Name = "Склад", Address = "ул. Пушкина, д. 15", Email = "sklad@mail.ru", Phone = "96-85-74" });

                await _context.SaveChangesAsync();
            }

            if (!_context.Employees.Any())
            {
                _context.Employees.AddRange(
                    new() { Id = 1, Surname = "Иванов", FirstName = "Георгий", PatronymicName = "Владимирович", GenderAsString = "М", BirthDate = new DateTime(1982, 10, 20) },
                    new() { Id = 2, Surname = "Петрова", FirstName = "Вероника", PatronymicName = "Алексеевна", GenderAsString = "Ж", BirthDate = new DateTime(1990, 3, 18) },
                    new() { Id = 3, Surname = "Антонова", FirstName = "Елена", PatronymicName = "Сергеевна", GenderAsString = "Ж", BirthDate = new DateTime(1980, 3, 23) },
                    new() { Id = 4, Surname = "Николаев", FirstName = "Петр", PatronymicName = "Викторович", GenderAsString = "М", BirthDate = new DateTime(1988, 8, 10) });

                await _context.SaveChangesAsync();
            }

            if (!_context.Recipes.Any())
            {
                _context.Recipes.AddRange(
                    new() { Id = 1, Date = new DateTime(2023, 02, 01), ProviderId = 1 },
                    new() { Id = 2, Date = new DateTime(2023, 03, 01), ProviderId = 2 });

                await _context.SaveChangesAsync();
            }

            if (!_context.RecipeItems.Any())
            {
                _context.RecipeItems.AddRange(
                    new() { Id = 1, RecipeId = 1, ProductName = "Парацетамол 500 мг", UnitName = "Штука", Quantity = 10, ExpirationDate = new DateTime(2023, 12, 01) },
                    new() { Id = 2, RecipeId = 2, ProductName = "Парацетамол 500 мг", UnitName = "Штука", Quantity = 20, ExpirationDate = new DateTime(2023, 12, 01) },
                    new() { Id = 3, RecipeId = 1, ProductName = "Парацетамол 500 мг", UnitName = "Штука", Quantity = 20, ExpirationDate = new DateTime(2024, 12, 01) },
                    new() { Id = 4, RecipeId = 1, ProductName = "Ацетилсалициловая кислота 500 мг", UnitName = "Штука", Quantity = 15, ExpirationDate = new DateTime(2023, 12, 01) },
                    new() { Id = 5, RecipeId = 2, ProductName = "Ацетилсалициловая кислота 500 мг", UnitName = "Штука", Quantity = 25, ExpirationDate = new DateTime(2023, 12, 01) },
                    new() { Id = 6, RecipeId = 2, ProductName = "Ацетилсалициловая кислота 500 мг", UnitName = "Штука", Quantity = 25, ExpirationDate = new DateTime(2024, 12, 01) },
                    new() { Id = 7, RecipeId = 1, ProductName = "Экспресс-тест на грипп", UnitName = "Штука", Quantity = 10, ExpirationDate = new DateTime(2024, 12, 01) },
                    new() { Id = 8, RecipeId = 2, ProductName = "Экспресс-тест на грипп", UnitName = "Штука", Quantity = 12, ExpirationDate = new DateTime(2024, 12, 01) },
                    new() { Id = 9, RecipeId = 1, ProductName = "Экспресс-тест на Covid", UnitName = "Штука", Quantity = 16, ExpirationDate = new DateTime(2024, 12, 01) },
                    new() { Id = 10, RecipeId = 2, ProductName = "Экспресс-тест на Covid", UnitName = "Штука", Quantity = 14, ExpirationDate = new DateTime(2024, 12, 01) },
                    new() { Id = 11, RecipeId = 2, ProductName = "Перчатки", UnitName = "Упаковка", Quantity = 10, ExpirationDate = new DateTime(2026, 12, 01) },
                    new() { Id = 12, RecipeId = 2, ProductName = "Маска медицинская", UnitName = "Упаковка", Quantity = 12, ExpirationDate = new DateTime(2028, 12, 01) });

                await _context.SaveChangesAsync();
            }

            if (!_context.Expenses.Any())
            {
                _context.Expenses.AddRange(
                    new() { Id = 1, Date = new DateTime(2023, 02, 01), EmployeeId = 3 },
                    new() { Id = 2, Date = new DateTime(2023, 03, 01), EmployeeId = 4 });

                await _context.SaveChangesAsync();
            }

            if (!_context.ExpenseItems.Any())
            {
                _context.ExpenseItems.AddRange(
                    new() { Id = 1, ExpenseId = 1, ProductName = "Парацетамол 500 мг", UnitName = "Штука", Quantity = 3, ExpirationDate = new DateTime(2023, 12, 01) },
                    new() { Id = 2, ExpenseId = 1, ProductName = "Ацетилсалициловая кислота 500 мг", UnitName = "Штука", Quantity = 10, ExpirationDate = new DateTime(2023, 12, 01) },
                    new() { Id = 3, ExpenseId = 1, ProductName = "Экспресс-тест на грипп", UnitName = "Штука", Quantity = 2 },
                    new() { Id = 4, ExpenseId = 1, ProductName = "Экспресс-тест на Covid", UnitName = "Штука", Quantity = 8 },
                    new() { Id = 5, ExpenseId = 2, ProductName = "Парацетамол 500 мг", UnitName = "Штука", Quantity = 7, ExpirationDate = new DateTime(2023, 12, 01) },
                    new() { Id = 6, ExpenseId = 2, ProductName = "Ацетилсалициловая кислота 500 мг", UnitName = "Штука", Quantity = 3, ExpirationDate = new DateTime(2023, 12, 01) },
                    new() { Id = 7, ExpenseId = 2, ProductName = "Экспресс-тест на грипп", UnitName = "Штука", Quantity = 3 },
                    new() { Id = 8, ExpenseId = 2, ProductName = "Перчатки", UnitName = "Упаковка", Quantity = 1 },
                    new() { Id = 9, ExpenseId = 2, ProductName = "Маска медицинская", UnitName = "Упаковка", Quantity = 2 });

                await _context.SaveChangesAsync();
            }

            // Default roles
            var defaultRoles = new List<IdentityRole>
            {
                new("Administrator"),
                new("Store"),
                new("User")
            };

            foreach (var role in defaultRoles)
            {
                if (_roleManager.Roles.All(r => r.Name != role.Name))
                {
                    await _roleManager.CreateAsync(role);
                }
            }

            // Default users
            var defaultUsers = new List<ApplicationUser>
            {
                new() { UserName = "Administrator", EmployeeId = 1 },
                new() { UserName = "Store", EmployeeId = 2 },
                new() { UserName = "User", EmployeeId = 3 }
            };

            foreach (var user in defaultUsers)
            {
                if (_userManager.Users.All(u => u.UserName != user.UserName))
                {
                    await _userManager.CreateAsync(user, $"{user.UserName!}1!");
                    if (!string.IsNullOrWhiteSpace(user.UserName))
                    {
                        await _userManager.AddToRolesAsync(user, new[] { user.UserName! });
                    }
                }
            }
        }
    }
}
