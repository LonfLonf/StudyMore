using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizForMe.Migrations
{
    /// <inheritdoc />
    public partial class SchemaBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    QuizId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QuizTitle = table.Column<string>(type: "TEXT", nullable: false),
                    QuizDescription = table.Column<string>(type: "TEXT", nullable: false),
                    ThumbnailQuizPath = table.Column<string>(type: "TEXT", nullable: true),
                    PointsEarned = table.Column<int>(type: "INTEGER", nullable: false),
                    PointsLosted = table.Column<int>(type: "INTEGER", nullable: false),
                    ThemeOfQuiz = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.QuizId);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TitleOfQuestion = table.Column<string>(type: "TEXT", nullable: false),
                    DescriptionOfQuestion = table.Column<string>(type: "TEXT", nullable: false),
                    AuxiliarImage = table.Column<string>(type: "TEXT", nullable: true),
                    Option_A = table.Column<string>(type: "TEXT", nullable: false),
                    Option_B = table.Column<string>(type: "TEXT", nullable: false),
                    Option_C = table.Column<string>(type: "TEXT", nullable: true),
                    Option_D = table.Column<string>(type: "TEXT", nullable: true),
                    CorrectOption = table.Column<char>(type: "TEXT", nullable: false),
                    PointsToEarn = table.Column<int>(type: "INTEGER", nullable: false),
                    PointsToLost = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ThemeOfQuestion = table.Column<int>(type: "INTEGER", nullable: false),
                    QuizID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_Questions_Quizzes_QuizID",
                        column: x => x.QuizID,
                        principalTable: "Quizzes",
                        principalColumn: "QuizId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuizID",
                table: "Questions",
                column: "QuizID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Quizzes");
        }
    }
}
