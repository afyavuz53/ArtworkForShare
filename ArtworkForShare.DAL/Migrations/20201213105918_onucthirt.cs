using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtworkForShare.DAL.Migrations
{
    public partial class onucthirt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProfileImgUrl",
                table: "User",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ActivationCode", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("05ab7bf3-0016-46d5-89c1-c14c2e0f9dae"), new DateTime(2020, 12, 13, 13, 59, 17, 555, DateTimeKind.Local).AddTicks(7462), new byte[] { 160, 190, 185, 75, 115, 152, 234, 47, 130, 32, 155, 227, 250, 214, 6, 177, 53, 65, 102, 244, 231, 163, 68, 16, 62, 116, 251, 195, 129, 198, 119, 191, 102, 31, 136, 172, 58, 249, 199, 65, 180, 29, 1, 143, 104, 195, 68, 35, 200, 227, 36, 177, 27, 215, 130, 94, 29, 121, 222, 174, 189, 253, 243, 1 }, new byte[] { 124, 17, 207, 177, 135, 19, 154, 211, 206, 159, 63, 129, 107, 19, 242, 27, 22, 191, 163, 192, 240, 128, 135, 41, 196, 207, 198, 105, 254, 213, 160, 26, 23, 192, 4, 136, 173, 157, 249, 26, 33, 205, 92, 114, 209, 31, 218, 94, 124, 166, 92, 87, 68, 225, 35, 145, 65, 209, 103, 63, 55, 116, 180, 212, 25, 179, 129, 46, 203, 195, 193, 134, 45, 202, 25, 100, 8, 90, 79, 192, 224, 158, 172, 235, 78, 202, 137, 55, 140, 50, 229, 40, 40, 115, 56, 72, 212, 236, 193, 139, 131, 83, 225, 85, 154, 138, 156, 213, 35, 1, 136, 130, 192, 154, 37, 9, 150, 181, 94, 170, 155, 88, 82, 152, 208, 41, 140, 71 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProfileImgUrl",
                table: "User",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ActivationCode", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("18021378-54ae-49bd-96bc-b919532b88ac"), new DateTime(2020, 12, 13, 13, 51, 35, 503, DateTimeKind.Local).AddTicks(556), new byte[] { 199, 132, 6, 141, 34, 37, 54, 249, 24, 110, 246, 224, 211, 174, 132, 127, 25, 156, 106, 180, 166, 198, 35, 148, 99, 157, 157, 184, 38, 117, 247, 242, 234, 120, 240, 20, 113, 249, 3, 35, 25, 204, 253, 181, 109, 46, 95, 16, 9, 196, 133, 216, 64, 4, 87, 211, 57, 107, 99, 252, 232, 196, 124, 92 }, new byte[] { 209, 151, 85, 167, 146, 140, 15, 97, 46, 216, 110, 44, 80, 138, 50, 50, 54, 133, 70, 104, 186, 228, 167, 97, 50, 121, 208, 184, 229, 79, 179, 22, 66, 74, 177, 175, 116, 255, 126, 144, 178, 239, 160, 56, 206, 123, 83, 139, 116, 33, 53, 49, 133, 142, 191, 21, 99, 51, 147, 113, 123, 12, 108, 137, 131, 77, 236, 78, 186, 128, 139, 41, 101, 38, 43, 50, 225, 128, 203, 215, 255, 205, 68, 139, 107, 4, 224, 21, 186, 180, 191, 243, 84, 23, 228, 23, 144, 204, 143, 92, 210, 23, 65, 160, 37, 243, 55, 172, 59, 213, 119, 3, 166, 21, 1, 250, 183, 95, 68, 207, 18, 148, 222, 205, 199, 77, 250, 0 } });
        }
    }
}
