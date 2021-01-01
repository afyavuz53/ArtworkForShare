using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtworkForShare.DAL.Migrations
{
    public partial class _30aralik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "User",
                type: "character varying(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "User",
                type: "character varying(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(18)",
                oldMaxLength: 18,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Claim",
                type: "character varying(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Claim",
                type: "character varying(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(18)",
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Artwork",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ActivationCode", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("ce3b0c3f-3afa-423d-9a98-4b8ddce67fc8"), new DateTime(2020, 12, 30, 13, 43, 58, 379, DateTimeKind.Local).AddTicks(6116), new byte[] { 6, 158, 166, 132, 128, 174, 123, 197, 5, 210, 41, 164, 85, 146, 27, 111, 36, 199, 207, 152, 108, 159, 77, 28, 94, 252, 39, 159, 43, 117, 179, 249, 133, 115, 110, 200, 54, 89, 194, 91, 51, 40, 121, 52, 4, 140, 132, 122, 162, 68, 114, 57, 231, 173, 125, 204, 59, 24, 248, 163, 19, 126, 202, 111 }, new byte[] { 212, 95, 158, 96, 66, 174, 229, 122, 95, 236, 157, 54, 150, 68, 167, 87, 26, 202, 205, 105, 157, 73, 168, 102, 28, 247, 235, 121, 212, 126, 161, 181, 157, 154, 134, 115, 174, 219, 134, 8, 170, 222, 92, 53, 194, 26, 38, 237, 114, 31, 71, 234, 94, 147, 189, 9, 63, 160, 191, 243, 145, 33, 130, 219, 131, 43, 225, 27, 2, 83, 65, 194, 22, 192, 192, 79, 244, 230, 13, 237, 22, 87, 206, 34, 65, 253, 225, 211, 156, 8, 125, 31, 229, 114, 119, 34, 8, 191, 3, 196, 242, 149, 123, 110, 178, 38, 24, 94, 136, 63, 179, 241, 107, 32, 28, 101, 160, 41, 130, 55, 35, 230, 24, 138, 206, 255, 76, 53 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "User",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "User",
                type: "character varying(18)",
                maxLength: 18,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(11)",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Claim",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Claim",
                type: "character varying(18)",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Artwork",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ActivationCode", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("ad9cf52b-c1a1-4f67-a10a-54248e41e5f1"), new DateTime(2020, 12, 27, 15, 36, 54, 783, DateTimeKind.Local).AddTicks(3134), new byte[] { 115, 175, 30, 147, 132, 205, 189, 71, 33, 123, 77, 243, 196, 72, 122, 80, 184, 93, 164, 51, 162, 151, 144, 18, 178, 47, 251, 99, 13, 181, 99, 110, 111, 163, 139, 1, 243, 193, 227, 206, 160, 191, 201, 192, 136, 22, 21, 172, 189, 56, 190, 31, 229, 118, 8, 240, 163, 75, 35, 71, 75, 31, 60, 108 }, new byte[] { 100, 17, 33, 102, 35, 168, 29, 246, 217, 15, 51, 69, 73, 252, 5, 67, 116, 30, 76, 123, 124, 229, 70, 34, 6, 151, 211, 94, 222, 169, 133, 188, 99, 15, 236, 46, 64, 59, 18, 170, 70, 126, 147, 45, 96, 233, 198, 249, 159, 174, 44, 229, 224, 154, 64, 20, 25, 146, 189, 247, 121, 174, 181, 59, 174, 28, 184, 206, 226, 96, 72, 18, 37, 231, 245, 186, 182, 141, 155, 108, 165, 85, 230, 181, 167, 171, 48, 86, 93, 54, 162, 245, 105, 184, 165, 246, 100, 121, 223, 26, 25, 5, 13, 138, 99, 2, 140, 123, 118, 96, 173, 139, 3, 45, 221, 197, 187, 144, 19, 167, 135, 124, 28, 189, 19, 46, 36, 232 } });
        }
    }
}
