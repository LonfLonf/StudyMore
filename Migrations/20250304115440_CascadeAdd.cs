using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizForMe.Migrations
{
    /// <inheritdoc />
    public partial class CascadeAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Quizzes_QuizID",
                table: "Questions");

            migrationBuilder.AddColumn<int>(
                name: "QuizOwnerQuizId",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuizOwnerQuizId",
                table: "Questions",
                column: "QuizOwnerQuizId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Quizzes_QuizID",
                table: "Questions",
                column: "QuizID",
                principalTable: "Quizzes",
                principalColumn: "QuizId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Quizzes_QuizOwnerQuizId",
                table: "Questions",
                column: "QuizOwnerQuizId",
                principalTable: "Quizzes",
                principalColumn: "QuizId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Quizzes_QuizID",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Quizzes_QuizOwnerQuizId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_QuizOwnerQuizId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuizOwnerQuizId",
                table: "Questions");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Quizzes_QuizID",
                table: "Questions",
                column: "QuizID",
                principalTable: "Quizzes",
                principalColumn: "QuizId");
        }
    }
}
