using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentsWebapiTrial.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dbStudentDetails",
                columns: table => new
                {
                    StudID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudAge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbStudentDetails", x => x.StudID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dbStudentDetails");
        }
    }
}
