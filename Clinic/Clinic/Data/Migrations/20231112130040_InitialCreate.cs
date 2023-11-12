using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Clinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Surname = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    PatronymicName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    GenderAsString = table.Column<string>(type: "nchar(1)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Abbreviation = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CategoryName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryName",
                        column: x => x.CategoryName,
                        principalTable: "Categories",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ProviderId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_Providers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Providers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExpenseId = table.Column<int>(type: "integer", nullable: false),
                    ProductName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    UnitName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Quantity = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpenseItems_Expenses_ExpenseId",
                        column: x => x.ExpenseId,
                        principalTable: "Expenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpenseItems_Products_ProductName",
                        column: x => x.ProductName,
                        principalTable: "Products",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpenseItems_Units_UnitName",
                        column: x => x.UnitName,
                        principalTable: "Units",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RecipeId = table.Column<int>(type: "integer", nullable: false),
                    ProductName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    UnitName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Quantity = table.Column<double>(type: "double precision", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeItems_Products_ProductName",
                        column: x => x.ProductName,
                        principalTable: "Products",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeItems_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeItems_Units_UnitName",
                        column: x => x.UnitName,
                        principalTable: "Units",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "Name", "CategoryName", "CreateDate", "Description" },
                values: new object[,]
                {
                    { "Ацетилсалициловая кислота 500 мг", "Препараты", new DateTime(2023, 11, 12, 20, 0, 40, 752, DateTimeKind.Local).AddTicks(4630), null },
                    { "Маска медицинская", "Расходные материалы", new DateTime(2023, 11, 12, 20, 0, 40, 752, DateTimeKind.Local).AddTicks(4648), null },
                    { "Парацетамол 500 мг", "Препараты", new DateTime(2023, 11, 12, 20, 0, 40, 752, DateTimeKind.Local).AddTicks(4643), null },
                    { "Перчатки", "Расходные материалы", new DateTime(2023, 11, 12, 20, 0, 40, 752, DateTimeKind.Local).AddTicks(4647), null },
                    { "Экспресс-тест на грипп", "Экспресс-тесты на грипп и Covid", new DateTime(2023, 11, 12, 20, 0, 40, 752, DateTimeKind.Local).AddTicks(4644), null },
                    { "Экспресс-тест на Covid", "Экспресс-тесты на грипп и Covid", new DateTime(2023, 11, 12, 20, 0, 40, 752, DateTimeKind.Local).AddTicks(4646), null }
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
                columns: new[] { "Id", "ExpenseId", "ProductName", "Quantity", "UnitName" },
                values: new object[,]
                {
                    { 1, 1, "Парацетамол 500 мг", 2.0, "Штука" },
                    { 2, 1, "Ацетилсалициловая кислота 500 мг", 3.0, "Штука" },
                    { 3, 1, "Экспресс-тест на грипп", 2.0, "Штука" },
                    { 4, 1, "Экспресс-тест на Covid", 8.0, "Штука" },
                    { 5, 2, "Парацетамол 500 мг", 8.0, "Штука" },
                    { 6, 2, "Ацетилсалициловая кислота 500 мг", 8.0, "Штука" },
                    { 7, 2, "Экспресс-тест на грипп", 3.0, "Штука" },
                    { 8, 2, "Перчатки", 1.0, "Упаковка" },
                    { 9, 2, "Маска медицинская", 2.0, "Упаковка" }
                });

            migrationBuilder.InsertData(
                table: "RecipeItems",
                columns: new[] { "Id", "ExpirationDate", "ProductName", "Quantity", "RecipeId", "UnitName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Парацетамол 500 мг", 10.0, 1, "Штука" },
                    { 2, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Парацетамол 500 мг", 20.0, 1, "Штука" },
                    { 3, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ацетилсалициловая кислота 500 мг", 15.0, 1, "Штука" },
                    { 4, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ацетилсалициловая кислота 500 мг", 25.0, 1, "Штука" },
                    { 5, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Экспресс-тест на грипп", 10.0, 2, "Штука" },
                    { 6, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Экспресс-тест на грипп", 12.0, 2, "Штука" },
                    { 7, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Экспресс-тест на Covid", 16.0, 2, "Штука" },
                    { 8, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Экспресс-тест на Covid", 14.0, 2, "Штука" },
                    { 9, new DateTime(2026, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Перчатки", 10.0, 2, "Упаковка" },
                    { 10, new DateTime(2028, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Маска медицинская", 12.0, 2, "Упаковка" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseItems_ExpenseId",
                table: "ExpenseItems",
                column: "ExpenseId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseItems_ProductName",
                table: "ExpenseItems",
                column: "ProductName");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseItems_UnitName",
                table: "ExpenseItems",
                column: "UnitName");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_EmployeeId",
                table: "Expenses",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryName",
                table: "Products",
                column: "CategoryName");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeItems_ProductName",
                table: "RecipeItems",
                column: "ProductName");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeItems_RecipeId",
                table: "RecipeItems",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeItems_UnitName",
                table: "RecipeItems",
                column: "UnitName");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_ProviderId",
                table: "Recipes",
                column: "ProviderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpenseItems");

            migrationBuilder.DropTable(
                name: "RecipeItems");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Providers");
        }
    }
}
