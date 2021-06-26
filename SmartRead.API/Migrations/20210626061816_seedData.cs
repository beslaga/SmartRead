using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRead.API.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clanci_Korisnici_AutorId",
                table: "Clanci");

            migrationBuilder.DropForeignKey(
                name: "FK_Korisnici_Drzave_DrzavaId",
                table: "Korisnici");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikClanci_Clanci_ClanakId",
                table: "KorisnikClanci");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikClanci_Korisnici_KorisnikId",
                table: "KorisnikClanci");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikKategorije_Kategorije_KategorijaId",
                table: "KorisnikKategorije");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikKategorije_Korisnici_KorisnikId",
                table: "KorisnikKategorije");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikPrijave_Clanci_ClanakId",
                table: "KorisnikPrijave");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikPrijave_Korisnici_KorisnikId",
                table: "KorisnikPrijave");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikUloge_Korisnici_KorisnikId",
                table: "KorisnikUloge");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikUloge_Uloge_UlogaId",
                table: "KorisnikUloge");

            migrationBuilder.DropForeignKey(
                name: "FK_Uplate_Korisnici_KorisnikId",
                table: "Uplate");

            migrationBuilder.InsertData(
                table: "Drzave",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "Bosna i Hercegovina" },
                    { 2, "Hrvatska" }
                });

            migrationBuilder.InsertData(
                table: "Uloge",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "Administrator" },
                    { 2, "BasicUser" }
                });

            migrationBuilder.InsertData(
                table: "Korisnici",
                columns: new[] { "Id", "DatumRegistracije", "DatumRodjenja", "DrzavaId", "Ime", "Kredit", "Mail", "Obrisan", "PasswordHash", "PasswordSalt", "Prezime", "Slika", "Username" },
                values: new object[] { 1, new DateTime(2021, 6, 26, 8, 18, 16, 212, DateTimeKind.Local).AddTicks(8628), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Maid", 0.0, null, false, "r1hjPqyvtGvfjeV94PppEqdXkfJUrtU1kJj9vXjfKxDJXwJfV+d8zAm4BuI3Ic3Bu66/6URSquY0sr6J+dZ4YA==", "Bln2+IqQ3fvkRXDd9bI2BA==", "Bešlagić", null, null });

            migrationBuilder.InsertData(
                table: "KorisnikUloge",
                columns: new[] { "KorisnikId", "UlogaId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "KorisnikUloge",
                columns: new[] { "KorisnikId", "UlogaId" },
                values: new object[] { 1, 2 });

            migrationBuilder.AddForeignKey(
                name: "FK_Clanci_Korisnici_AutorId",
                table: "Clanci",
                column: "AutorId",
                principalTable: "Korisnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnici_Drzave_DrzavaId",
                table: "Korisnici",
                column: "DrzavaId",
                principalTable: "Drzave",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikClanci_Clanci_ClanakId",
                table: "KorisnikClanci",
                column: "ClanakId",
                principalTable: "Clanci",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikClanci_Korisnici_KorisnikId",
                table: "KorisnikClanci",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikKategorije_Kategorije_KategorijaId",
                table: "KorisnikKategorije",
                column: "KategorijaId",
                principalTable: "Kategorije",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikKategorije_Korisnici_KorisnikId",
                table: "KorisnikKategorije",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikPrijave_Clanci_ClanakId",
                table: "KorisnikPrijave",
                column: "ClanakId",
                principalTable: "Clanci",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikPrijave_Korisnici_KorisnikId",
                table: "KorisnikPrijave",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikUloge_Korisnici_KorisnikId",
                table: "KorisnikUloge",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikUloge_Uloge_UlogaId",
                table: "KorisnikUloge",
                column: "UlogaId",
                principalTable: "Uloge",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Uplate_Korisnici_KorisnikId",
                table: "Uplate",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clanci_Korisnici_AutorId",
                table: "Clanci");

            migrationBuilder.DropForeignKey(
                name: "FK_Korisnici_Drzave_DrzavaId",
                table: "Korisnici");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikClanci_Clanci_ClanakId",
                table: "KorisnikClanci");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikClanci_Korisnici_KorisnikId",
                table: "KorisnikClanci");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikKategorije_Kategorije_KategorijaId",
                table: "KorisnikKategorije");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikKategorije_Korisnici_KorisnikId",
                table: "KorisnikKategorije");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikPrijave_Clanci_ClanakId",
                table: "KorisnikPrijave");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikPrijave_Korisnici_KorisnikId",
                table: "KorisnikPrijave");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikUloge_Korisnici_KorisnikId",
                table: "KorisnikUloge");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikUloge_Uloge_UlogaId",
                table: "KorisnikUloge");

            migrationBuilder.DropForeignKey(
                name: "FK_Uplate_Korisnici_KorisnikId",
                table: "Uplate");

            migrationBuilder.DeleteData(
                table: "Drzave",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "KorisnikUloge",
                keyColumns: new[] { "KorisnikId", "UlogaId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "KorisnikUloge",
                keyColumns: new[] { "KorisnikId", "UlogaId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Uloge",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Uloge",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Drzave",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_Clanci_Korisnici_AutorId",
                table: "Clanci",
                column: "AutorId",
                principalTable: "Korisnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnici_Drzave_DrzavaId",
                table: "Korisnici",
                column: "DrzavaId",
                principalTable: "Drzave",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikClanci_Clanci_ClanakId",
                table: "KorisnikClanci",
                column: "ClanakId",
                principalTable: "Clanci",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikClanci_Korisnici_KorisnikId",
                table: "KorisnikClanci",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikKategorije_Kategorije_KategorijaId",
                table: "KorisnikKategorije",
                column: "KategorijaId",
                principalTable: "Kategorije",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikKategorije_Korisnici_KorisnikId",
                table: "KorisnikKategorije",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikPrijave_Clanci_ClanakId",
                table: "KorisnikPrijave",
                column: "ClanakId",
                principalTable: "Clanci",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikPrijave_Korisnici_KorisnikId",
                table: "KorisnikPrijave",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikUloge_Korisnici_KorisnikId",
                table: "KorisnikUloge",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikUloge_Uloge_UlogaId",
                table: "KorisnikUloge",
                column: "UlogaId",
                principalTable: "Uloge",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Uplate_Korisnici_KorisnikId",
                table: "Uplate",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
