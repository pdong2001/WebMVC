using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class AddProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("31eb339f-d31f-4f01-b3d2-9c3ca8de3499"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4916d35b-1d58-415b-986c-bd2aeb5a61c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("67f27ccd-066a-4e0d-8129-fcf55ee29d40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6f0f20eb-7bc2-4216-aba4-357413f6ac3a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("91f48386-51fa-4f88-8f24-29c6b4170e0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e268e9dc-8e39-40c7-b9f0-f6b78e99180d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ecf5cfd5-e82a-4a2e-b2e7-92d4f5ea074b"));

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descriptionn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Descriptionn", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Sản phẩm số 1", "", "Sản phẩm 1", 100000 },
                    { 2, "Sản phẩm số 2", "", "Sản phẩm 2", 100000 },
                    { 3, "Sản phẩm số 3", "", "Sản phẩm 3", 100000 },
                    { 4, "Sản phẩm số 4", "", "Sản phẩm 4", 100000 },
                    { 5, "Sản phẩm số 5", "", "Sản phẩm 5", 100000 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "AccName", "Address", "DateOfBirth", "Domicile", "Email", "Name", "PhoneNumber", "RegistryDate" },
                values: new object[,]
                {
                    { new Guid("915f719f-c2fb-47c2-b268-84901cba939f"), "Taikhoan1", "Hưng Yên - Việt Nam", new DateTime(1980, 9, 26, 8, 40, 48, 344, DateTimeKind.Local).AddTicks(2127), "Việt nam", "Email.NguoiDung@mail.mail", "Người dùng 1", "0987654321", new DateTime(2021, 10, 21, 8, 40, 48, 344, DateTimeKind.Local).AddTicks(6813) },
                    { new Guid("13cd80ab-841c-4a19-a85c-c1169b0ffac1"), "Taikhoan2", "Hưng Yên - Việt Nam", new DateTime(1980, 9, 26, 8, 40, 48, 344, DateTimeKind.Local).AddTicks(7514), "Việt nam", "Email.NguoiDung@mail.mail", "Người dùng 2", "0987654321", new DateTime(2021, 10, 21, 8, 40, 48, 344, DateTimeKind.Local).AddTicks(7526) },
                    { new Guid("73e84b7c-8c09-4d8a-80da-6919046ba39f"), "Taikhoan3", "Hưng Yên - Việt Nam", new DateTime(1980, 9, 26, 8, 40, 48, 344, DateTimeKind.Local).AddTicks(7532), "Việt nam", "Email.NguoiDung@mail.mail", "Người dùng 3", "0987654321", new DateTime(2021, 10, 21, 8, 40, 48, 344, DateTimeKind.Local).AddTicks(7534) },
                    { new Guid("0a41dd28-da70-44b2-a372-5e9f688b3c09"), "Taikhoan4", "Hưng Yên - Việt Nam", new DateTime(1980, 9, 26, 8, 40, 48, 344, DateTimeKind.Local).AddTicks(7539), "Việt nam", "Email.NguoiDung@mail.mail", "Người dùng 4", "0987654321", new DateTime(2021, 10, 21, 8, 40, 48, 344, DateTimeKind.Local).AddTicks(7541) },
                    { new Guid("0bcf5595-2df8-4911-ad67-f63869034045"), "Taikhoan5", "Hưng Yên - Việt Nam", new DateTime(1980, 9, 26, 8, 40, 48, 344, DateTimeKind.Local).AddTicks(7547), "Việt nam", "Email.NguoiDung@mail.mail", "Người dùng 5", "0987654321", new DateTime(2021, 10, 21, 8, 40, 48, 344, DateTimeKind.Local).AddTicks(7548) },
                    { new Guid("82861ec6-f9b9-43f9-8379-967a14575bcc"), "Taikhoan6", "Hưng Yên - Việt Nam", new DateTime(1980, 9, 26, 8, 40, 48, 344, DateTimeKind.Local).AddTicks(7566), "Việt nam", "Email.NguoiDung@mail.mail", "Người dùng 6", "0987654321", new DateTime(2021, 10, 21, 8, 40, 48, 344, DateTimeKind.Local).AddTicks(7568) },
                    { new Guid("2a6c6b0d-c375-435a-b961-a8e1d1cfadc3"), "Taikhoan7", "Hưng Yên - Việt Nam", new DateTime(1980, 9, 26, 8, 40, 48, 344, DateTimeKind.Local).AddTicks(7574), "Việt nam", "Email.NguoiDung@mail.mail", "Người dùng 7", "0987654321", new DateTime(2021, 10, 21, 8, 40, 48, 344, DateTimeKind.Local).AddTicks(7575) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0a41dd28-da70-44b2-a372-5e9f688b3c09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0bcf5595-2df8-4911-ad67-f63869034045"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("13cd80ab-841c-4a19-a85c-c1169b0ffac1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2a6c6b0d-c375-435a-b961-a8e1d1cfadc3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("73e84b7c-8c09-4d8a-80da-6919046ba39f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("82861ec6-f9b9-43f9-8379-967a14575bcc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("915f719f-c2fb-47c2-b268-84901cba939f"));

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
    }
}
