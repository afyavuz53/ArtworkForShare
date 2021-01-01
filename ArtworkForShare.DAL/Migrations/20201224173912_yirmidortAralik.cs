using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtworkForShare.DAL.Migrations
{
    public partial class yirmidortAralik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Claimer_Claim_ClaimID",
                table: "Claimer");

            migrationBuilder.DropIndex(
                name: "IX_Claimer_ClaimID",
                table: "Claimer");

            migrationBuilder.DropIndex(
                name: "IX_Claimer_Fullname",
                table: "Claimer");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ActivationCode", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("39d1b598-dcfc-44ca-9f2c-1b769a3083aa"), new DateTime(2020, 12, 24, 20, 39, 11, 908, DateTimeKind.Local).AddTicks(9550), new byte[] { 233, 221, 45, 41, 200, 105, 60, 145, 149, 42, 194, 31, 95, 62, 167, 70, 29, 183, 249, 83, 136, 125, 178, 221, 39, 150, 6, 205, 196, 211, 124, 80, 134, 70, 169, 186, 194, 212, 139, 76, 48, 61, 91, 3, 43, 199, 102, 50, 209, 92, 208, 205, 228, 34, 98, 137, 164, 215, 74, 204, 75, 122, 227, 127 }, new byte[] { 89, 19, 244, 184, 23, 35, 195, 137, 67, 190, 59, 27, 60, 29, 100, 163, 82, 225, 224, 216, 77, 65, 12, 118, 60, 131, 254, 29, 193, 28, 223, 142, 14, 135, 53, 46, 151, 67, 211, 145, 206, 254, 212, 224, 184, 104, 184, 103, 28, 92, 204, 165, 19, 121, 51, 26, 88, 73, 55, 222, 247, 59, 101, 201, 25, 177, 235, 182, 135, 114, 147, 18, 62, 216, 206, 58, 164, 180, 192, 56, 122, 199, 106, 53, 241, 144, 51, 58, 0, 201, 252, 59, 28, 54, 176, 5, 39, 182, 16, 16, 212, 148, 73, 20, 24, 238, 120, 38, 85, 247, 200, 134, 57, 152, 221, 152, 71, 249, 217, 195, 222, 53, 226, 176, 62, 247, 199, 14 } });

            migrationBuilder.CreateIndex(
                name: "IX_Claim_ClaimerID",
                table: "Claim",
                column: "ClaimerID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Claim_Claimer_ClaimerID",
                table: "Claim",
                column: "ClaimerID",
                principalTable: "Claimer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Claim_Claimer_ClaimerID",
                table: "Claim");

            migrationBuilder.DropIndex(
                name: "IX_Claim_ClaimerID",
                table: "Claim");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ActivationCode", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("a9a170fe-2e6d-4a89-b953-5aef050d48a8"), new DateTime(2020, 12, 13, 15, 17, 46, 816, DateTimeKind.Local).AddTicks(2906), new byte[] { 63, 105, 79, 7, 95, 209, 189, 75, 152, 145, 20, 20, 68, 144, 127, 111, 28, 182, 68, 213, 173, 81, 78, 137, 88, 195, 24, 198, 120, 248, 99, 208, 2, 87, 194, 250, 0, 180, 210, 128, 163, 162, 71, 225, 75, 8, 25, 68, 52, 144, 7, 31, 55, 150, 41, 190, 79, 209, 68, 51, 232, 159, 86, 166 }, new byte[] { 52, 127, 201, 216, 183, 61, 17, 231, 245, 75, 222, 182, 237, 215, 235, 99, 12, 164, 233, 131, 186, 107, 122, 242, 6, 101, 191, 212, 154, 77, 225, 220, 110, 253, 42, 243, 122, 86, 182, 184, 161, 192, 126, 212, 197, 159, 164, 231, 214, 122, 108, 47, 180, 233, 99, 184, 194, 27, 122, 179, 232, 236, 196, 8, 54, 0, 116, 56, 160, 75, 91, 77, 9, 72, 87, 118, 219, 46, 143, 220, 0, 34, 81, 224, 201, 159, 126, 147, 10, 155, 140, 38, 137, 12, 93, 237, 4, 21, 133, 34, 142, 243, 170, 146, 206, 53, 57, 93, 153, 19, 20, 195, 137, 67, 123, 122, 163, 127, 36, 222, 52, 113, 7, 151, 37, 224, 43, 229 } });

            migrationBuilder.CreateIndex(
                name: "IX_Claimer_ClaimID",
                table: "Claimer",
                column: "ClaimID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Claimer_Fullname",
                table: "Claimer",
                column: "Fullname",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Claimer_Claim_ClaimID",
                table: "Claimer",
                column: "ClaimID",
                principalTable: "Claim",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
