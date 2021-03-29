using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentsWebapiTrial.Migrations
{
    public partial class SeedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "dbStudentDetails",
                columns: new[] { "StudID", "StudAge", "StudCity", "StudName" },
                values: new object[,]
                {
                    { 1, 12, "CTC", "Samu" },
                    { 2, 19, "ZAQ", "Dhamu" },
                    { 3, 13, "TWQ", "Ramu" },
                    { 4, 15, "BBSR", "Pamu" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "dbStudentDetails",
                keyColumn: "StudID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "dbStudentDetails",
                keyColumn: "StudID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "dbStudentDetails",
                keyColumn: "StudID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "dbStudentDetails",
                keyColumn: "StudID",
                keyValue: 4);
        }
    }
}
