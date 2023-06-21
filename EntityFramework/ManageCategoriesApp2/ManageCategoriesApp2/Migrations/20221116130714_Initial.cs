using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace ManageCategoriesApp2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catagories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catagories", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Name 1" });

            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "Name 2" });

            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "Name 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catagories");
        }
    }
}
