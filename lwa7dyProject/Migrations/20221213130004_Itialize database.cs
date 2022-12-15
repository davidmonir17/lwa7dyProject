using Microsoft.EntityFrameworkCore.Migrations;

namespace lwa7dyProject.Migrations
{
    public partial class Itializedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "depertments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_depertments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    NationalId = table.Column<int>(type: "int", maxLength: 14, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_employees_depertments_DepId",
                        column: x => x.DepId,
                        principalTable: "depertments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "depertments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "IT" });

            migrationBuilder.InsertData(
                table: "depertments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Developer" });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "Id", "Address", "DepId", "Name", "NationalId" },
                values: new object[] { 1, "El zaher cairo", 1, "david", 1111111 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "Id", "Address", "DepId", "Name", "NationalId" },
                values: new object[] { 2, "El zaher cairo", 2, "ahmed", 1111551 });

            migrationBuilder.CreateIndex(
                name: "IX_employees_DepId",
                table: "employees",
                column: "DepId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "depertments");
        }
    }
}
