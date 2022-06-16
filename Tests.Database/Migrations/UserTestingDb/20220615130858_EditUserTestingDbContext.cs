using Microsoft.EntityFrameworkCore.Migrations;

namespace Tests.Database.Migrations.UserTestingDb
{
    public partial class EditUserTestingDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_AnswerOptions_AnswerOptionsId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_AnswerOptionsId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "AnswerOptionsId",
                table: "Questions");

            migrationBuilder.AddColumn<bool>(
                name: "StatusPublic",
                table: "Tests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "QuestionsId",
                table: "AnswerOptions",
                type: "int",
                precision: 10,
                scale: 0,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AnswerOptions_QuestionsId",
                table: "AnswerOptions",
                column: "QuestionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerOptions_Questions_QuestionsId",
                table: "AnswerOptions",
                column: "QuestionsId",
                principalTable: "Questions",
                principalColumn: "IdQuestions",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswerOptions_Questions_QuestionsId",
                table: "AnswerOptions");

            migrationBuilder.DropIndex(
                name: "IX_AnswerOptions_QuestionsId",
                table: "AnswerOptions");

            migrationBuilder.DropColumn(
                name: "StatusPublic",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "QuestionsId",
                table: "AnswerOptions");

            migrationBuilder.AddColumn<int>(
                name: "AnswerOptionsId",
                table: "Questions",
                type: "int",
                precision: 10,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_AnswerOptionsId",
                table: "Questions",
                column: "AnswerOptionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_AnswerOptions_AnswerOptionsId",
                table: "Questions",
                column: "AnswerOptionsId",
                principalTable: "AnswerOptions",
                principalColumn: "IdAnswerOptions",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
