using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class DropColumCreateDateFromProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Products",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Name",
                keyValue: "Ацетилсалициловая кислота 500 мг",
                column: "CreateDate",
                value: new DateTime(2023, 11, 12, 20, 0, 40, 752, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Name",
                keyValue: "Маска медицинская",
                column: "CreateDate",
                value: new DateTime(2023, 11, 12, 20, 0, 40, 752, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Name",
                keyValue: "Парацетамол 500 мг",
                column: "CreateDate",
                value: new DateTime(2023, 11, 12, 20, 0, 40, 752, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Name",
                keyValue: "Перчатки",
                column: "CreateDate",
                value: new DateTime(2023, 11, 12, 20, 0, 40, 752, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Name",
                keyValue: "Экспресс-тест на грипп",
                column: "CreateDate",
                value: new DateTime(2023, 11, 12, 20, 0, 40, 752, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Name",
                keyValue: "Экспресс-тест на Covid",
                column: "CreateDate",
                value: new DateTime(2023, 11, 12, 20, 0, 40, 752, DateTimeKind.Local).AddTicks(4646));
        }
    }
}
