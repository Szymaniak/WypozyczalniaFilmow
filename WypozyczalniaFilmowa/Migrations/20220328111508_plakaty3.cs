using Microsoft.EntityFrameworkCore.Migrations;

namespace WypozyczalniaFilmowa.Migrations
{
    public partial class plakaty3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 2,
                column: "Plakat",
                value: "numer-23.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 2,
                column: "Plakat",
                value: null);
        }
    }
}
