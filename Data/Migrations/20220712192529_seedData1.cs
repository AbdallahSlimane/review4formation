using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class seedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Description", "Nom", "NomSeo" },
                values: new object[] { 5, "comment faire du C", "Apprendre le C", "langage-C" });

            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Description", "Nom", "NomSeo" },
                values: new object[] { 6, "La conception de l'architecture est une étape cruciale du développement logiciel.", "Découvrez l'architecture des logiciels", "architecture-des-logiciels" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
