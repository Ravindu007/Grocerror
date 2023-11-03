using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Grocerror.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "ItemName" },
                values: new object[] { new DateTime(2023, 11, 3, 18, 47, 10, 767, DateTimeKind.Local).AddTicks(5719), "Milk from DB" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Date", "ItemName", "ListId", "Status" },
                values: new object[] { 2, new DateTime(2023, 11, 3, 18, 47, 10, 767, DateTimeKind.Local).AddTicks(5740), "Coffeee new from DB", 2, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "ItemName" },
                values: new object[] { new DateTime(2023, 11, 3, 17, 53, 57, 284, DateTimeKind.Local).AddTicks(1929), "Milk" });
        }
    }
}
