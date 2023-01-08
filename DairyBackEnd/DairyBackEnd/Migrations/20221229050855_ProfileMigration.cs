using Microsoft.EntityFrameworkCore.Migrations;

namespace DairyBackEnd.Migrations
{
    public partial class ProfileMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblprofile",
                columns: table => new
                {
                    pid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    uid = table.Column<int>(nullable: false),
                    firstname = table.Column<string>(nullable: true),
                    lastname = table.Column<string>(nullable: true),
                    dob = table.Column<string>(nullable: true),
                    phno = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    pin = table.Column<string>(nullable: true),
                    idno = table.Column<string>(nullable: true),
                    dlno = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    education = table.Column<string>(nullable: true),
                    passno = table.Column<string>(nullable: true),
                    bano = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblprofile", x => x.pid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblprofile");
        }
    }
}
