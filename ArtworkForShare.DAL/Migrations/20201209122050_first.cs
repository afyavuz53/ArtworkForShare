using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ArtworkForShare.DAL.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    UserName = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    ProfileImg = table.Column<byte[]>(type: "bytea", nullable: true),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    EMail = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: true),
                    Phone = table.Column<string>(type: "character varying(18)", maxLength: 18, nullable: true),
                    ActivationCode = table.Column<Guid>(type: "uuid", nullable: false),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Artwork",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    Image = table.Column<byte[]>(type: "bytea", nullable: false),
                    Name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "character varying(400)", maxLength: 400, nullable: true),
                    UserID = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artwork", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Artwork_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Claim",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    Title = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "character varying(400)", maxLength: 400, nullable: true),
                    RequestedImg = table.Column<byte[]>(type: "bytea", nullable: false),
                    MadeImg = table.Column<byte[]>(type: "bytea", nullable: true),
                    BidPrice = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false),
                    State = table.Column<int>(type: "integer", nullable: false),
                    ClaimerID = table.Column<int>(type: "integer", nullable: false),
                    UserID = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claim", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Claim_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Claimer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    Fullname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    EMail = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Adress = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Phone = table.Column<string>(type: "character varying(18)", maxLength: 18, nullable: false),
                    ClaimID = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claimer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Claimer_Claim_ClaimID",
                        column: x => x.ClaimID,
                        principalTable: "Claim",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "ActivationCode", "CreatedDate", "EMail", "FirstName", "IsActive", "LastName", "PasswordHash", "PasswordSalt", "Phone", "ProfileImg", "Role", "UserName" },
                values: new object[] { 1, new Guid("5c2bf141-f71f-4496-a5f3-98c7ea116072"), new DateTime(2020, 12, 9, 15, 20, 49, 902, DateTimeKind.Local).AddTicks(8504), "artworkforshare@mail.com", "ArtworkForShare", true, "ArtworkForShare", new byte[] { 125, 220, 97, 225, 106, 19, 244, 134, 147, 213, 28, 248, 19, 219, 126, 113, 227, 169, 116, 95, 219, 15, 236, 57, 143, 214, 86, 155, 141, 2, 130, 189, 158, 174, 206, 196, 40, 37, 144, 66, 124, 111, 185, 137, 105, 82, 185, 2, 27, 52, 227, 19, 48, 101, 53, 116, 116, 66, 92, 153, 252, 239, 115, 96 }, new byte[] { 248, 62, 217, 118, 185, 243, 131, 22, 120, 189, 80, 59, 31, 186, 91, 237, 11, 67, 210, 247, 217, 30, 41, 206, 169, 118, 52, 242, 168, 101, 70, 211, 251, 56, 5, 219, 251, 76, 83, 196, 1, 220, 189, 154, 53, 200, 31, 62, 8, 223, 229, 183, 168, 7, 24, 168, 253, 17, 16, 213, 192, 214, 79, 8, 1, 246, 59, 104, 158, 111, 229, 4, 27, 57, 178, 36, 161, 85, 190, 216, 244, 162, 189, 43, 30, 62, 79, 148, 102, 75, 107, 147, 210, 90, 80, 104, 169, 220, 166, 146, 201, 70, 64, 7, 216, 113, 114, 123, 231, 118, 116, 39, 88, 199, 17, 254, 16, 100, 16, 84, 116, 248, 81, 137, 116, 40, 81, 225 }, null, null, 2, "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Artwork_UserID",
                table: "Artwork",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Claim_UserID",
                table: "Claim",
                column: "UserID");

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

            migrationBuilder.CreateIndex(
                name: "IX_User_EMail",
                table: "User",
                column: "EMail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserName",
                table: "User",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artwork");

            migrationBuilder.DropTable(
                name: "Claimer");

            migrationBuilder.DropTable(
                name: "Claim");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
