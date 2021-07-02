using Microsoft.EntityFrameworkCore.Migrations;

namespace GraphQLWithEFCore.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Roll = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Roll" },
                values: new object[] { 1, "Raiyan", "1001" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Roll" },
                values: new object[] { 2, "Sharif", "1002" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Name", "Roll" },
                values: new object[] { 3, "Rohit", "1003" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
