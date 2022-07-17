using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ReRouting1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReRouting",
                columns: table => new
                {
                    OldUrl = table.Column<string>(nullable: false),
                    NewUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReRouting", x => x.OldUrl);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReRouting");
        }
    }
}
