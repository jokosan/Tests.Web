using Microsoft.EntityFrameworkCore.Migrations;

namespace Tests.Database.Migrations.UserTestingDb
{
    public partial class StartUserTestingDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnswerOptions",
                columns: table => new
                {
                    IdAnswerOptions = table.Column<int>(type: "int", precision: 10, scale: 0, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Possiblenswer = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CorrectAnswer = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerOptions", x => x.IdAnswerOptions);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    IdTest = table.Column<int>(type: "int", precision: 10, scale: 0, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Img = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.IdTest);
                });

            migrationBuilder.CreateTable(
                name: "UserTests",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TestId = table.Column<int>(type: "int", precision: 10, scale: 0, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    IdQuestions = table.Column<int>(type: "int", precision: 10, scale: 0, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestsId = table.Column<int>(type: "int", precision: 10, scale: 0, nullable: true),
                    QuestionText = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    AnswerOptionsId = table.Column<int>(type: "int", precision: 10, scale: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.IdQuestions);
                    table.ForeignKey(
                        name: "FK_Questions_AnswerOptions_AnswerOptionsId",
                        column: x => x.AnswerOptionsId,
                        principalTable: "AnswerOptions",
                        principalColumn: "IdAnswerOptions",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questions_Tests_TestsId",
                        column: x => x.TestsId,
                        principalTable: "Tests",
                        principalColumn: "IdTest",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_AnswerOptionsId",
                table: "Questions",
                column: "AnswerOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TestsId",
                table: "Questions",
                column: "TestsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "UserTests");

            migrationBuilder.DropTable(
                name: "AnswerOptions");

            migrationBuilder.DropTable(
                name: "Tests");
        }
    }
}
