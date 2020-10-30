using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    product_name = table.Column<string>(nullable: true),
                    price = table.Column<float>(nullable: false),
                    valid_from = table.Column<DateTime>(nullable: true),
                    valid_to = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "price", "product_name", "valid_from", "valid_to" },
                values: new object[] { 10, 500f, "PlayStation 5", new DateTime(2020, 6, 1, 7, 47, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "price", "product_name", "valid_from", "valid_to" },
                values: new object[] { 11, 400f, "xBox One", new DateTime(2020, 6, 1, 7, 47, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "price", "product_name", "valid_from", "valid_to" },
                values: new object[] { 12, 1500f, "Smart TV OLED", new DateTime(2020, 6, 1, 7, 47, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "price", "product_name", "valid_from", "valid_to" },
                values: new object[] { 13, 500f, "Tastatura RGB", new DateTime(2020, 6, 1, 7, 47, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "price", "product_name", "valid_from", "valid_to" },
                values: new object[] { 14, 1500f, "Monitor 4k", new DateTime(2020, 6, 1, 7, 47, 0, 0, DateTimeKind.Unspecified), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
