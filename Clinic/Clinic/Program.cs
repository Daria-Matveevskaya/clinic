using Clinic.Data;
using Clinic.Forms;
using Clinic.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Clinic
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static async Task Main()
        {
            ApplicationConfiguration.Initialize();

            using var host = CreateHostBuilder().Build();

            // Initialise and seed database
            using var scope = host.Services.CreateScope();
            var initialiser = scope.ServiceProvider.GetRequiredService<ApplicationDbContextInitialiser>();
            
            await initialiser.InitialiseAsync();
            await initialiser.SeedAsync();

            using var loginForm = host.Services.GetRequiredService<LoginForm>();
            loginForm.StartPosition = FormStartPosition.CenterScreen;

            using var mainForm = host.Services.GetRequiredService<MainForm>();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                //mainForm.user = loginForm.user;

                Application.Run(mainForm);
            }
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql("Host=localhost;Port=5432;Database=Clinic;Username=postgres;Password=postgres;"));

                services.AddScoped<ApplicationDbContextInitialiser>();

                services
                .AddIdentityCore<ApplicationUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

                services.AddAuthentication();
                services.AddAuthorizationCore();

                services
                .AddTransient<LoginForm>()
                .AddTransient<MainForm>()
                .AddTransient<UnitForm>()
                .AddTransient<UnitEditForm>()
                .AddTransient<UserForm>()
                .AddTransient<UserEditForm>()
                .AddTransient<StoreForm>()
                .AddTransient<ProductForm>()
                .AddTransient<ProductEditForm>()
                .AddTransient<CategoryForm>()
                .AddTransient<CategoryEditForm>()
                .AddTransient<ProviderForm>()
                .AddTransient<ProviderEditForm>()
                .AddTransient<EmployeeForm>()
                .AddTransient<EmployeeEditForm>()
                .AddTransient<ExpenseEditForm>()
                .AddTransient<RecipeEditForm>();
            });
    }
}