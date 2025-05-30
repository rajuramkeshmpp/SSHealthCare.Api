using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SSHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class forsidebarnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sidebars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sidebars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sidebars",
                columns: new[] { "Id", "Name", "Path", "RoleId" },
                values: new object[,]
                {
                    { 1, "AssignRole", "test", 1 },
                    { 2, "Role", "test", 1 },
                    { 3, "Country", "test", 1 },
                    { 4, "State", "test", 1 },
                    { 5, "District", "test", 1 },
                    { 6, "TaskManager", "test", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sidebars");
        }
    }
}
