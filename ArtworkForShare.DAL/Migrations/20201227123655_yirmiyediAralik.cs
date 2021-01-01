using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtworkForShare.DAL.Migrations
{
    public partial class yirmiyediAralik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBanned",
                table: "Artwork",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ActivationCode", "CreatedDate", "PasswordHash", "PasswordSalt", "Role" },
                values: new object[] { new Guid("ad9cf52b-c1a1-4f67-a10a-54248e41e5f1"), new DateTime(2020, 12, 27, 15, 36, 54, 783, DateTimeKind.Local).AddTicks(3134), new byte[] { 115, 175, 30, 147, 132, 205, 189, 71, 33, 123, 77, 243, 196, 72, 122, 80, 184, 93, 164, 51, 162, 151, 144, 18, 178, 47, 251, 99, 13, 181, 99, 110, 111, 163, 139, 1, 243, 193, 227, 206, 160, 191, 201, 192, 136, 22, 21, 172, 189, 56, 190, 31, 229, 118, 8, 240, 163, 75, 35, 71, 75, 31, 60, 108 }, new byte[] { 100, 17, 33, 102, 35, 168, 29, 246, 217, 15, 51, 69, 73, 252, 5, 67, 116, 30, 76, 123, 124, 229, 70, 34, 6, 151, 211, 94, 222, 169, 133, 188, 99, 15, 236, 46, 64, 59, 18, 170, 70, 126, 147, 45, 96, 233, 198, 249, 159, 174, 44, 229, 224, 154, 64, 20, 25, 146, 189, 247, 121, 174, 181, 59, 174, 28, 184, 206, 226, 96, 72, 18, 37, 231, 245, 186, 182, 141, 155, 108, 165, 85, 230, 181, 167, 171, 48, 86, 93, 54, 162, 245, 105, 184, 165, 246, 100, 121, 223, 26, 25, 5, 13, 138, 99, 2, 140, 123, 118, 96, 173, 139, 3, 45, 221, 197, 187, 144, 19, 167, 135, 124, 28, 189, 19, 46, 36, 232 }, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBanned",
                table: "Artwork");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ActivationCode", "CreatedDate", "PasswordHash", "PasswordSalt", "Role" },
                values: new object[] { new Guid("4db7b308-5cf7-48e2-8318-5a3144e0f5da"), new DateTime(2020, 12, 25, 16, 9, 58, 490, DateTimeKind.Local).AddTicks(5622), new byte[] { 114, 83, 24, 151, 206, 83, 253, 173, 33, 138, 169, 61, 172, 27, 53, 113, 16, 158, 149, 231, 72, 64, 194, 178, 255, 101, 213, 143, 35, 75, 186, 20, 228, 104, 158, 55, 153, 218, 190, 193, 68, 124, 160, 148, 13, 197, 43, 188, 81, 232, 241, 163, 224, 60, 156, 75, 151, 151, 145, 155, 193, 134, 148, 132 }, new byte[] { 156, 252, 154, 22, 39, 103, 44, 210, 150, 237, 47, 234, 62, 173, 104, 105, 248, 8, 82, 14, 156, 154, 194, 186, 139, 42, 160, 240, 52, 90, 218, 204, 160, 87, 108, 220, 186, 64, 74, 222, 57, 255, 156, 202, 109, 251, 60, 225, 204, 194, 191, 43, 136, 155, 38, 102, 21, 142, 228, 26, 51, 35, 50, 8, 159, 137, 188, 175, 127, 19, 52, 50, 211, 135, 93, 160, 78, 202, 99, 167, 117, 166, 244, 24, 153, 165, 102, 196, 89, 143, 144, 162, 143, 142, 103, 140, 13, 183, 78, 63, 227, 222, 224, 170, 91, 17, 108, 48, 236, 7, 159, 231, 71, 145, 199, 244, 234, 217, 36, 88, 161, 190, 161, 3, 157, 144, 41, 151 }, 2 });
        }
    }
}
