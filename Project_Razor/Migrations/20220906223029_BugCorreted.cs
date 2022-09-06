using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Razor.Migrations
{
    public partial class BugCorreted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "admin",
                keyColumn: "id",
                keyValue: "8af290db-69fa-4fae-ad44-58e3be7bb94a");

            migrationBuilder.InsertData(
                table: "admin",
                columns: new[] { "id", "nome", "senha" },
                values: new object[] { "1f35a5c1-f0c7-483b-8058-ea4adf138ac2", "sa", "1234" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "admin",
                keyColumn: "id",
                keyValue: "1f35a5c1-f0c7-483b-8058-ea4adf138ac2");

            migrationBuilder.InsertData(
                table: "admin",
                columns: new[] { "id", "nome", "senha" },
                values: new object[] { "8af290db-69fa-4fae-ad44-58e3be7bb94a", "sa", "1234" });
        }
    }
}
