using Microsoft.EntityFrameworkCore.Migrations;

namespace DairyBackEnd.Migrations
{
    public partial class DairyentryMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbldairyentry",
                columns: table => new
                {
                    Did = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(nullable: true),
                    Entry = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbldairyentry", x => x.Did);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbldairyentry");
        }
    }
}
