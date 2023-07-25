using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommandQueryResponsibilitySegregation.Migrations
{
    public partial class StudentDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, (byte)20, "Zaminali", "Rustamov" },
                    { 2, (byte)21, "Nicat", "Abdullayev" },
                    { 3, (byte)19, "Ali", "Ibrahimov" },
                    { 4, (byte)21, "Namiq", "Mikayilov" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
