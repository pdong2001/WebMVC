using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CanBos",
                columns: new[] { "ID", "Address", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Hưng Yên - Việt Nam", "Cán bộ 1", "0987654321" },
                    { 2, "Hưng Yên - Việt Nam", "Cán bộ 2", "0987654321" },
                    { 3, "Hưng Yên - Việt Nam", "Cán bộ 3", "0987654321" },
                    { 4, "Hưng Yên - Việt Nam", "Cán bộ 4", "0987654321" },
                    { 5, "Hưng Yên - Việt Nam", "Cán bộ 5", "0987654321" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CanBos",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
