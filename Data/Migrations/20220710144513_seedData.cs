using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Formations",
                columns: new[] { "Id", "Description", "Nom", "NomSeo" },
                values: new object[,]
                {
                    { 1, "Devenez pro et créer votre site web avec spring boot et angular", "Créer votre site web avec spring boot et angular", "spring-angular" },
                    { 2, "Créer votre application mobile avec flutter étape par étape", "Créer votre application mobile avec flutter", "flutter" },
                    { 3, "comment faire du code propre", "Apprendre le clean code", "clean-code" },
                    { 4, "gérer votre base de donnée", "Devenez pro gestion de base de donnée", "base-de-donnee" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Formations",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
