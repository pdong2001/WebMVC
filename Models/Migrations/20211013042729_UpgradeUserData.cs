using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class UpgradeUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Domicile = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "AccName", "Address", "DateOfBirth", "Domicile", "Email", "Name", "PhoneNumber", "RegistryDate" },
                values: new object[,]
                {
                    { new Guid("91f48386-51fa-4f88-8f24-29c6b4170e0e"), "Taikhoan1", "Hưng Yên - Việt Nam", new DateTime(1980, 9, 18, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(2660), "Việt nam", "Email.NguoiDung@mail.mail", "Người dùng 1", "0987654321", new DateTime(2021, 10, 13, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8194) },
                    { new Guid("e268e9dc-8e39-40c7-b9f0-f6b78e99180d"), "Taikhoan2", "Hưng Yên - Việt Nam", new DateTime(1980, 9, 18, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8923), "Việt nam", "Email.NguoiDung@mail.mail", "Người dùng 2", "0987654321", new DateTime(2021, 10, 13, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8934) },
                    { new Guid("67f27ccd-066a-4e0d-8129-fcf55ee29d40"), "Taikhoan3", "Hưng Yên - Việt Nam", new DateTime(1980, 9, 18, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8941), "Việt nam", "Email.NguoiDung@mail.mail", "Người dùng 3", "0987654321", new DateTime(2021, 10, 13, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8943) },
                    { new Guid("6f0f20eb-7bc2-4216-aba4-357413f6ac3a"), "Taikhoan4", "Hưng Yên - Việt Nam", new DateTime(1980, 9, 18, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8948), "Việt nam", "Email.NguoiDung@mail.mail", "Người dùng 4", "0987654321", new DateTime(2021, 10, 13, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8949) },
                    { new Guid("31eb339f-d31f-4f01-b3d2-9c3ca8de3499"), "Taikhoan5", "Hưng Yên - Việt Nam", new DateTime(1980, 9, 18, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8955), "Việt nam", "Email.NguoiDung@mail.mail", "Người dùng 5", "0987654321", new DateTime(2021, 10, 13, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8956) },
                    { new Guid("ecf5cfd5-e82a-4a2e-b2e7-92d4f5ea074b"), "Taikhoan6", "Hưng Yên - Việt Nam", new DateTime(1980, 9, 18, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8961), "Việt nam", "Email.NguoiDung@mail.mail", "Người dùng 6", "0987654321", new DateTime(2021, 10, 13, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(8963) },
                    { new Guid("4916d35b-1d58-415b-986c-bd2aeb5a61c4"), "Taikhoan7", "Hưng Yên - Việt Nam", new DateTime(1980, 9, 18, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(9058), "Việt nam", "Email.NguoiDung@mail.mail", "Người dùng 7", "0987654321", new DateTime(2021, 10, 13, 11, 27, 29, 81, DateTimeKind.Local).AddTicks(9060) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
