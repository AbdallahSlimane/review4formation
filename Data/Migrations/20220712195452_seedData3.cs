using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class seedData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Android est un système d'exploitation mobile fondé sur le noyau Linux");

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Description", "Nom", "NomSeo" },
                values: new object[] { 9, "Découvrez le code avec PHP", "Apprendre le PHP", "langage-php" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Android est un système d'exploitation mobile fondé sur le noyau Linux et développé par des informaticiens sponsorisés par Google");
        }
    }
}
