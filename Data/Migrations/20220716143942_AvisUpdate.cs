using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AvisUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avis_Formations_FormationId",
                table: "Avis");

            migrationBuilder.DropColumn(
                name: "NomSeo",
                table: "Avis");

            migrationBuilder.AlterColumn<int>(
                name: "FormationId",
                table: "Avis",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Avis_Formations_FormationId",
                table: "Avis",
                column: "FormationId",
                principalTable: "Formations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avis_Formations_FormationId",
                table: "Avis");

            migrationBuilder.AlterColumn<int>(
                name: "FormationId",
                table: "Avis",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "NomSeo",
                table: "Avis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Avis_Formations_FormationId",
                table: "Avis",
                column: "FormationId",
                principalTable: "Formations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
