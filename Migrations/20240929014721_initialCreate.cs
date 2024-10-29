using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SongebobFanClub.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Salary = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "ID", "FirstName", "LastName", "Position", "Salary" },
                values: new object[] { 1, "Spongebob", "SquarePants", "FryCook", "$1.45" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "ID", "FirstName", "LastName", "Position", "Salary" },
                values: new object[] { 2, "Squidward", "Tentacles", "Cashier", "$30,000" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "ID", "FirstName", "LastName", "Position", "Salary" },
                values: new object[] { 3, "Eugene", "Krabs", "Boss", "$2,000,000" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
