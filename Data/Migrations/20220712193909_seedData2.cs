using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class seedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "La conception de l'architecture est une étape cruciale du développement logiciel");

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Description", "Nom", "NomSeo" },
                values: new object[] { 8, "Android est un système d'exploitation mobile fondé sur le noyau Linux et développé par des informaticiens sponsorisés par Google", "Le langage androïd en plusieurs étapes", "langage-androïd" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Description", "Nom", "NomSeo" },
                values: new object[] { 7, "comment faire du C", "Apprendre le React.JS", "langage-react.js" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "La conception de l'architecture est une étape cruciale du développement logiciel.");
        }
    }
}
