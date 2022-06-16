using Microsoft.EntityFrameworkCore.Migrations;

namespace Tests.Database.Migrations.UserTestingDb
{
    public partial class RenameTableTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Tests_TestsId",
                table: "Questions");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.CreateTable(
                name: "ListTests",
                columns: table => new
                {
                    IdListTest = table.Column<int>(type: "int", precision: 10, scale: 0, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Img = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    StatusPublic = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListTests", x => x.IdListTest);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_ListTests_TestsId",
                table: "Questions",
                column: "TestsId",
                principalTable: "ListTests",
                principalColumn: "IdListTest",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_ListTests_TestsId",
                table: "Questions");

            migrationBuilder.DropTable(
                name: "ListTests");

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    IdTest = table.Column<int>(type: "int", precision: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Img = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    StatusPublic = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.IdTest);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Tests_TestsId",
                table: "Questions",
                column: "TestsId",
                principalTable: "Tests",
                principalColumn: "IdTest",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
