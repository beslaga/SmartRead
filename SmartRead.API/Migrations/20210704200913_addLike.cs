using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRead.API.Migrations
{
    public partial class addLike : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(nullable: false),
                    ClanakId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => new { x.KorisnikId, x.ClanakId });
                    table.ForeignKey(
                        name: "FK_Likes_Clanci_ClanakId",
                        column: x => x.ClanakId,
                        principalTable: "Clanci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Likes_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 4, 22, 9, 13, 237, DateTimeKind.Local).AddTicks(7415), "V3Y6sIgV5t4Zvvke9PgezpL7sYTL7eczSzvDqgbp147jVydKgnJntDhYQY7mEIL50ide2+UOzj7owa4+vogQxw==", "mERDDn6zsDGUZOwGOgrhOw==" });

            migrationBuilder.CreateIndex(
                name: "IX_Likes_ClanakId",
                table: "Likes",
                column: "ClanakId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 6, 26, 14, 27, 15, 712, DateTimeKind.Local).AddTicks(5901), "RPCcKAO7qBhn8dk0vTMLj5bxZaVQ7EL3pk1YtaU5ugMniRt8Yp+b8JueIMVIFS6WWZ/7htU50k67wb9sbFcHiA==", "/4TRrALZzz6gi0epmQEpXw==" });
        }
    }
}
