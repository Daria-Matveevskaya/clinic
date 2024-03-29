using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Clinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Name",
                keyValue: "Ацетилсалициловая кислота 500 мг");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Name",
                keyValue: "Маска медицинская");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Name",
                keyValue: "Парацетамол 500 мг");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Name",
                keyValue: "Перчатки");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Name",
                keyValue: "Экспресс-тест на грипп");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Name",
                keyValue: "Экспресс-тест на Covid");

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Name",
                keyValue: "Упаковка");

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Name",
                keyValue: "Штука");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Препараты");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Расходные материалы");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Экспресс-тесты на грипп и Covid");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EmployeeId",
                table: "AspNetUsers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Categories",
                column: "Name",
                values: new object[]
                {
                    "Препараты",
                    "Расходные материалы",
                    "Экспресс-тесты на грипп и Covid"
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BirthDate", "FirstName", "GenderAsString", "PatronymicName", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(1982, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Георгий", "М", "Владимирович", "Иванов" },
                    { 2, new DateTime(1990, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Вероника", "Ж", "Алексеевна", "Петрова" }
                });

            migrationBuilder.InsertData(
                table: "Providers",
                columns: new[] { "Id", "Address", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "ул. Ленина, д. 12", "apteka@mail.ru", "Аптека", "63-52-41" },
                    { 2, "ул. Пушкина, д. 15", "sklad@mail.ru", "Склад", "96-85-74" }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Name", "Abbreviation" },
                values: new object[,]
                {
                    { "Упаковка", "уп" },
                    { "Штука", "шт" }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Date", "EmployeeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Name", "CategoryName", "Description" },
                values: new object[,]
                {
                    { "Ацетилсалициловая кислота 500 мг", "Препараты", null },
                    { "Маска медицинская", "Расходные материалы", null },
                    { "Парацетамол 500 мг", "Препараты", null },
                    { "Перчатки", "Расходные материалы", null },
                    { "Экспресс-тест на грипп", "Экспресс-тесты на грипп и Covid", null },
                    { "Экспресс-тест на Covid", "Экспресс-тесты на грипп и Covid", null }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Date", "ProviderId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "ExpenseItems",
                columns: new[] { "Id", "ExpenseId", "ExpirationDate", "ProductName", "Quantity", "UnitName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Парацетамол 500 мг", 3.0, "Штука" },
                    { 2, 1, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ацетилсалициловая кислота 500 мг", 10.0, "Штука" },
                    { 3, 1, null, "Экспресс-тест на грипп", 2.0, "Штука" },
                    { 4, 1, null, "Экспресс-тест на Covid", 8.0, "Штука" },
                    { 5, 2, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Парацетамол 500 мг", 7.0, "Штука" },
                    { 6, 2, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ацетилсалициловая кислота 500 мг", 3.0, "Штука" },
                    { 7, 2, null, "Экспресс-тест на грипп", 3.0, "Штука" },
                    { 8, 2, null, "Перчатки", 1.0, "Упаковка" },
                    { 9, 2, null, "Маска медицинская", 2.0, "Упаковка" }
                });

            migrationBuilder.InsertData(
                table: "RecipeItems",
                columns: new[] { "Id", "ExpirationDate", "ProductName", "Quantity", "RecipeId", "UnitName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Парацетамол 500 мг", 10.0, 1, "Штука" },
                    { 2, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Парацетамол 500 мг", 20.0, 2, "Штука" },
                    { 3, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Парацетамол 500 мг", 20.0, 1, "Штука" },
                    { 4, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ацетилсалициловая кислота 500 мг", 15.0, 1, "Штука" },
                    { 5, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ацетилсалициловая кислота 500 мг", 25.0, 2, "Штука" },
                    { 6, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ацетилсалициловая кислота 500 мг", 25.0, 2, "Штука" },
                    { 7, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Экспресс-тест на грипп", 10.0, 1, "Штука" },
                    { 8, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Экспресс-тест на грипп", 12.0, 2, "Штука" },
                    { 9, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Экспресс-тест на Covid", 16.0, 1, "Штука" },
                    { 10, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Экспресс-тест на Covid", 14.0, 2, "Штука" },
                    { 11, new DateTime(2026, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Перчатки", 10.0, 2, "Упаковка" },
                    { 12, new DateTime(2028, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Маска медицинская", 12.0, 2, "Упаковка" }
                });
        }
    }
}
