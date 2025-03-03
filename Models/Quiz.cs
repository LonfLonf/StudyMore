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
        public string QuizTitle { get; set; }
        public string QuizDescription { get; set; }
        public string ThumbnailQuizPath { get; set; }
        public int PointsEarned { get; set; }
        public int PointsLosted { get; set; }
        public Themes ThemeOfQuiz { get; set; }
        public List<Question> Questions { get; set; }

    }
}
