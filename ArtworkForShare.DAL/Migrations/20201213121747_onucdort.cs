using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtworkForShare.DAL.Migrations
{
    public partial class onucdort : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestedImgUrl",
                table: "Claim",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Artwork",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ActivationCode", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("a9a170fe-2e6d-4a89-b953-5aef050d48a8"), new DateTime(2020, 12, 13, 15, 17, 46, 816, DateTimeKind.Local).AddTicks(2906), new byte[] { 63, 105, 79, 7, 95, 209, 189, 75, 152, 145, 20, 20, 68, 144, 127, 111, 28, 182, 68, 213, 173, 81, 78, 137, 88, 195, 24, 198, 120, 248, 99, 208, 2, 87, 194, 250, 0, 180, 210, 128, 163, 162, 71, 225, 75, 8, 25, 68, 52, 144, 7, 31, 55, 150, 41, 190, 79, 209, 68, 51, 232, 159, 86, 166 }, new byte[] { 52, 127, 201, 216, 183, 61, 17, 231, 245, 75, 222, 182, 237, 215, 235, 99, 12, 164, 233, 131, 186, 107, 122, 242, 6, 101, 191, 212, 154, 77, 225, 220, 110, 253, 42, 243, 122, 86, 182, 184, 161, 192, 126, 212, 197, 159, 164, 231, 214, 122, 108, 47, 180, 233, 99, 184, 194, 27, 122, 179, 232, 236, 196, 8, 54, 0, 116, 56, 160, 75, 91, 77, 9, 72, 87, 118, 219, 46, 143, 220, 0, 34, 81, 224, 201, 159, 126, 147, 10, 155, 140, 38, 137, 12, 93, 237, 4, 21, 133, 34, 142, 243, 170, 146, 206, 53, 57, 93, 153, 19, 20, 195, 137, 67, 123, 122, 163, 127, 36, 222, 52, 113, 7, 151, 37, 224, 43, 229 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestedImgUrl",
                table: "Claim",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Artwork",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ActivationCode", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("05ab7bf3-0016-46d5-89c1-c14c2e0f9dae"), new DateTime(2020, 12, 13, 13, 59, 17, 555, DateTimeKind.Local).AddTicks(7462), new byte[] { 160, 190, 185, 75, 115, 152, 234, 47, 130, 32, 155, 227, 250, 214, 6, 177, 53, 65, 102, 244, 231, 163, 68, 16, 62, 116, 251, 195, 129, 198, 119, 191, 102, 31, 136, 172, 58, 249, 199, 65, 180, 29, 1, 143, 104, 195, 68, 35, 200, 227, 36, 177, 27, 215, 130, 94, 29, 121, 222, 174, 189, 253, 243, 1 }, new byte[] { 124, 17, 207, 177, 135, 19, 154, 211, 206, 159, 63, 129, 107, 19, 242, 27, 22, 191, 163, 192, 240, 128, 135, 41, 196, 207, 198, 105, 254, 213, 160, 26, 23, 192, 4, 136, 173, 157, 249, 26, 33, 205, 92, 114, 209, 31, 218, 94, 124, 166, 92, 87, 68, 225, 35, 145, 65, 209, 103, 63, 55, 116, 180, 212, 25, 179, 129, 46, 203, 195, 193, 134, 45, 202, 25, 100, 8, 90, 79, 192, 224, 158, 172, 235, 78, 202, 137, 55, 140, 50, 229, 40, 40, 115, 56, 72, 212, 236, 193, 139, 131, 83, 225, 85, 154, 138, 156, 213, 35, 1, 136, 130, 192, 154, 37, 9, 150, 181, 94, 170, 155, 88, 82, 152, 208, 41, 140, 71 } });
        }
    }
}
