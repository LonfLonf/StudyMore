using QuizForMe.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizForMe.Models
{
    public class Quiz
    {
        public int QuizId { get; set; }
        public required string QuizTitle { get; set; }
        public required string QuizDescription { get; set; }
        public string? ThumbnailQuizPath { get; set; }
        public int PointsEarned { get; set; }
        public int PointsLosted { get; set; }
        public Themes ThemeOfQuiz { get; set; }
        public required string CreatedAt { get; set; }
        public required List<Question> Questions { get; set; }

    }
}
