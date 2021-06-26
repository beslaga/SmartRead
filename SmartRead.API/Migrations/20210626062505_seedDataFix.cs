using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRead.API.Migrations
{
    public partial class seedDataFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "Mail", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { new DateTime(2021, 6, 26, 8, 25, 5, 457, DateTimeKind.Local).AddTicks(9346), "maid.beslagic@edu.fit.ba", "zURw1NDtN/j7gT5jQrvE4Kazkys+Sh+YQT9dqX2/q4DaBfon/2U+Ho31PHo1oZQ6PVl4ZXZlTS9U2xmZN8cdaA==", "h6DPHA+fvIHN+cSZEkh10A==", "maid" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "Mail", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { new DateTime(2021, 6, 26, 8, 18, 16, 212, DateTimeKind.Local).AddTicks(8628), null, "r1hjPqyvtGvfjeV94PppEqdXkfJUrtU1kJj9vXjfKxDJXwJfV+d8zAm4BuI3Ic3Bu66/6URSquY0sr6J+dZ4YA==", "Bln2+IqQ3fvkRXDd9bI2BA==", null });
        }
    }
}
