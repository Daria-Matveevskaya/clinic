using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Clinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModifyExpirationDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "RecipeItems",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpirationDate",
                table: "ExpenseItems",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "Quantity" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0 });

            migrationBuilder.UpdateData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "Quantity" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0 });

            migrationBuilder.UpdateData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpirationDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExpirationDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpirationDate", "Quantity" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0 });

            migrationBuilder.UpdateData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpirationDate", "Quantity" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0 });

            migrationBuilder.UpdateData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "ExpirationDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "ExpirationDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "ExpirationDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "RecipeId" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpirationDate", "ProductName", "Quantity" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Парацетамол 500 мг", 20.0 });

            migrationBuilder.UpdateData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpirationDate", "Quantity" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.0 });

            migrationBuilder.UpdateData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductName", "Quantity" },
                values: new object[] { "Ацетилсалициловая кислота 500 мг", 25.0 });

            migrationBuilder.UpdateData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ProductName", "Quantity" },
                values: new object[] { "Ацетилсалициловая кислота 500 мг", 25.0 });

            migrationBuilder.UpdateData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpirationDate", "ProductName", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Экспресс-тест на грипп", 10.0, 1 });

            migrationBuilder.UpdateData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ProductName", "Quantity" },
                values: new object[] { "Экспресс-тест на грипп", 12.0 });

            migrationBuilder.UpdateData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpirationDate", "ProductName", "Quantity", "RecipeId", "UnitName" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Экспресс-тест на Covid", 16.0, 1, "Штука" });

            migrationBuilder.UpdateData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpirationDate", "ProductName", "Quantity", "UnitName" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Экспресс-тест на Covid", 14.0, "Штука" });

            migrationBuilder.InsertData(
                table: "RecipeItems",
                columns: new[] { "Id", "ExpirationDate", "ProductName", "Quantity", "RecipeId", "UnitName" },
                values: new object[,]
                {
                    { 11, new DateTime(2026, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Перчатки", 10.0, 2, "Упаковка" },
                    { 12, new DateTime(2028, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Маска медицинская", 12.0, 2, "Упаковка" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DropColumn(
                name: "ExpirationDate",
                table: "ExpenseItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "RecipeItems",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Quantity",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "Quantity",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "Quantity",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "ExpenseItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "Quantity",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "RecipeId" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpirationDate", "ProductName", "Quantity" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ацетилсалициловая кислота 500 мг", 15.0 });

            migrationBuilder.UpdateData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpirationDate", "Quantity" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.0 });

            migrationBuilder.UpdateData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ProductName", "Quantity" },
                values: new object[] { "Экспресс-тест на грипп", 10.0 });

            migrationBuilder.UpdateData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ProductName", "Quantity" },
                values: new object[] { "Экспресс-тест на грипп", 12.0 });

            migrationBuilder.UpdateData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpirationDate", "ProductName", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Экспресс-тест на Covid", 16.0, 2 });

            migrationBuilder.UpdateData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ProductName", "Quantity" },
                values: new object[] { "Экспресс-тест на Covid", 14.0 });

            migrationBuilder.UpdateData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpirationDate", "ProductName", "Quantity", "RecipeId", "UnitName" },
                values: new object[] { new DateTime(2026, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Перчатки", 10.0, 2, "Упаковка" });

            migrationBuilder.UpdateData(
                table: "RecipeItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpirationDate", "ProductName", "Quantity", "UnitName" },
                values: new object[] { new DateTime(2028, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Маска медицинская", 12.0, "Упаковка" });
        }
    }
}
