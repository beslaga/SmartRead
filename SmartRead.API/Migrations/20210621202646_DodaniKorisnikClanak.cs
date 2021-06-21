using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRead.API.Migrations
{
    public partial class DodaniKorisnikClanak : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KorisnikClanci",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(nullable: false),
                    ClanakId = table.Column<int>(nullable: false),
                    BrojPosjeta = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikClanci", x => new { x.KorisnikId, x.ClanakId });
                    table.ForeignKey(
                        name: "FK_KorisnikClanci_Clanci_ClanakId",
                        column: x => x.ClanakId,
                        principalTable: "Clanci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KorisnikClanci_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikClanci_ClanakId",
                table: "KorisnikClanci",
                column: "ClanakId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KorisnikClanci");
        }
    }
}
