using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ArtworkForShare.DAL.Migrations
{
    public partial class yirmibesAralik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Claim_Claimer_ClaimerID",
                table: "Claim");

            migrationBuilder.DropTable(
                name: "Claimer");

            migrationBuilder.DropIndex(
                name: "IX_Claim_ClaimerID",
                table: "Claim");

            migrationBuilder.DropColumn(
                name: "ClaimerID",
                table: "Claim");

            migrationBuilder.AlterColumn<string>(
                name: "MadeImgUrl",
                table: "Claim",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Claim",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EMail",
                table: "Claim",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Fullname",
                table: "Claim",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Claim",
                type: "character varying(18)",
                maxLength: 18,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ActivationCode", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("4db7b308-5cf7-48e2-8318-5a3144e0f5da"), new DateTime(2020, 12, 25, 16, 9, 58, 490, DateTimeKind.Local).AddTicks(5622), new byte[] { 114, 83, 24, 151, 206, 83, 253, 173, 33, 138, 169, 61, 172, 27, 53, 113, 16, 158, 149, 231, 72, 64, 194, 178, 255, 101, 213, 143, 35, 75, 186, 20, 228, 104, 158, 55, 153, 218, 190, 193, 68, 124, 160, 148, 13, 197, 43, 188, 81, 232, 241, 163, 224, 60, 156, 75, 151, 151, 145, 155, 193, 134, 148, 132 }, new byte[] { 156, 252, 154, 22, 39, 103, 44, 210, 150, 237, 47, 234, 62, 173, 104, 105, 248, 8, 82, 14, 156, 154, 194, 186, 139, 42, 160, 240, 52, 90, 218, 204, 160, 87, 108, 220, 186, 64, 74, 222, 57, 255, 156, 202, 109, 251, 60, 225, 204, 194, 191, 43, 136, 155, 38, 102, 21, 142, 228, 26, 51, 35, 50, 8, 159, 137, 188, 175, 127, 19, 52, 50, 211, 135, 93, 160, 78, 202, 99, 167, 117, 166, 244, 24, 153, 165, 102, 196, 89, 143, 144, 162, 143, 142, 103, 140, 13, 183, 78, 63, 227, 222, 224, 170, 91, 17, 108, 48, 236, 7, 159, 231, 71, 145, 199, 244, 234, 217, 36, 88, 161, 190, 161, 3, 157, 144, 41, 151 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Claim");

            migrationBuilder.DropColumn(
                name: "EMail",
                table: "Claim");

            migrationBuilder.DropColumn(
                name: "Fullname",
                table: "Claim");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Claim");

            migrationBuilder.AlterColumn<string>(
                name: "MadeImgUrl",
                table: "Claim",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClaimerID",
                table: "Claim",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Claimer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    Adress = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    ClaimID = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EMail = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Fullname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Phone = table.Column<string>(type: "character varying(18)", maxLength: 18, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claimer", x => x.ID);
                });

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
    }
}
