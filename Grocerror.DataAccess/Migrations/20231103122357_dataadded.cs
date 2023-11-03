using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Grocerror.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dataadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Date", "ItemName", "ListId", "Status" },
                values: new object[] { 1, new DateTime(2023, 11, 3, 17, 53, 57, 284, DateTimeKind.Local).AddTicks(1929), "Milk", 1, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
