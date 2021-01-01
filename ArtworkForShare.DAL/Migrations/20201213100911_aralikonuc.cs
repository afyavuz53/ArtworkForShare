using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtworkForShare.DAL.Migrations
{
    public partial class aralikonuc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileImg",
                table: "User");

            migrationBuilder.DropColumn(
                name: "MadeImg",
                table: "Claim");

            migrationBuilder.DropColumn(
                name: "RequestedImg",
                table: "Claim");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Artwork");

            migrationBuilder.AddColumn<string>(
                name: "ProfileImgUrl",
                table: "User",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MadeImgUrl",
                table: "Claim",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequestedImgUrl",
                table: "Claim",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Artwork",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ActivationCode", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("86481915-0449-491d-b8ae-bb4e9727dd33"), new DateTime(2020, 12, 13, 13, 9, 10, 582, DateTimeKind.Local).AddTicks(8254), new byte[] { 173, 193, 192, 22, 196, 185, 22, 159, 155, 149, 220, 150, 128, 43, 80, 200, 110, 93, 106, 184, 251, 103, 81, 160, 23, 94, 68, 213, 187, 161, 145, 120, 73, 155, 57, 186, 64, 144, 145, 48, 173, 19, 79, 211, 151, 250, 23, 193, 85, 102, 27, 212, 183, 95, 121, 56, 128, 85, 131, 114, 235, 78, 248, 38 }, new byte[] { 63, 82, 252, 201, 71, 63, 205, 233, 135, 181, 139, 211, 63, 159, 98, 220, 121, 151, 0, 92, 140, 12, 86, 48, 93, 222, 46, 101, 156, 151, 193, 24, 111, 163, 193, 223, 140, 49, 145, 14, 156, 6, 255, 117, 99, 111, 125, 239, 104, 139, 227, 108, 158, 203, 23, 19, 168, 48, 92, 63, 125, 255, 105, 47, 139, 152, 247, 225, 217, 59, 207, 158, 65, 251, 83, 193, 8, 87, 215, 151, 12, 218, 11, 2, 229, 72, 16, 15, 71, 192, 239, 206, 187, 116, 221, 223, 171, 204, 235, 128, 250, 134, 85, 116, 221, 113, 9, 116, 177, 219, 247, 205, 234, 22, 246, 161, 182, 106, 86, 183, 147, 49, 16, 158, 227, 35, 25, 233 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileImgUrl",
                table: "User");

            migrationBuilder.DropColumn(
                name: "MadeImgUrl",
                table: "Claim");

            migrationBuilder.DropColumn(
                name: "RequestedImgUrl",
                table: "Claim");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Artwork");

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfileImg",
                table: "User",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "MadeImg",
                table: "Claim",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RequestedImg",
                table: "Claim",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Artwork",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ActivationCode", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("d2712842-de8d-4b4a-a35f-0083de8feda5"), new DateTime(2020, 12, 11, 16, 55, 38, 675, DateTimeKind.Local).AddTicks(2283), new byte[] { 194, 52, 49, 1, 184, 85, 176, 6, 14, 214, 216, 223, 159, 245, 219, 131, 36, 195, 40, 94, 249, 192, 93, 230, 170, 4, 55, 57, 202, 220, 233, 241, 186, 233, 138, 21, 16, 246, 27, 184, 18, 128, 156, 255, 135, 192, 60, 161, 240, 114, 194, 213, 35, 222, 116, 49, 91, 1, 202, 162, 152, 160, 64, 2 }, new byte[] { 196, 17, 51, 16, 252, 98, 170, 94, 6, 61, 132, 3, 46, 53, 33, 158, 249, 19, 22, 82, 17, 218, 41, 188, 35, 207, 243, 5, 176, 210, 15, 51, 208, 86, 71, 69, 72, 222, 138, 100, 53, 60, 157, 33, 219, 58, 102, 202, 133, 155, 12, 204, 101, 203, 18, 236, 216, 223, 156, 27, 253, 167, 72, 213, 205, 214, 222, 72, 9, 15, 197, 168, 81, 40, 170, 133, 179, 224, 28, 179, 220, 185, 85, 10, 190, 245, 42, 95, 208, 186, 19, 74, 38, 144, 191, 211, 198, 202, 157, 41, 202, 127, 25, 122, 78, 134, 118, 233, 52, 183, 34, 92, 52, 203, 140, 216, 224, 210, 176, 207, 76, 239, 49, 31, 82, 98, 212, 28 } });
        }
    }
}
