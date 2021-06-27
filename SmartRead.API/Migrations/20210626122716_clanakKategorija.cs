using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRead.API.Migrations
{
    public partial class clanakKategorija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClanakKategorije",
                columns: table => new
                {
                    ClanakId = table.Column<int>(nullable: false),
                    KategorijaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClanakKategorije", x => new { x.ClanakId, x.KategorijaId });
                    table.ForeignKey(
                        name: "FK_ClanakKategorije_Clanci_ClanakId",
                        column: x => x.ClanakId,
                        principalTable: "Clanci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClanakKategorije_Kategorije_KategorijaId",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 6, 26, 14, 27, 15, 712, DateTimeKind.Local).AddTicks(5901), "RPCcKAO7qBhn8dk0vTMLj5bxZaVQ7EL3pk1YtaU5ugMniRt8Yp+b8JueIMVIFS6WWZ/7htU50k67wb9sbFcHiA==", "/4TRrALZzz6gi0epmQEpXw==" });

            migrationBuilder.CreateIndex(
                name: "IX_ClanakKategorije_KategorijaId",
                table: "ClanakKategorije",
                column: "KategorijaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClanakKategorije");

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 6, 26, 8, 25, 5, 457, DateTimeKind.Local).AddTicks(9346), "zURw1NDtN/j7gT5jQrvE4Kazkys+Sh+YQT9dqX2/q4DaBfon/2U+Ho31PHo1oZQ6PVl4ZXZlTS9U2xmZN8cdaA==", "h6DPHA+fvIHN+cSZEkh10A==" });
        }
    }
}
