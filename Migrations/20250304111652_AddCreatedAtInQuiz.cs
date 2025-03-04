using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizForMe.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedAtInQuiz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedAt",
                table: "Quizzes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Quizzes");
        }
    }
}
