using QuizForMe.Data;
using QuizForMe.Enums;
using QuizForMe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizForMe
{
    public partial class CreateQuizForm : Form
    {
        private readonly AppDbContext _context = new AppDbContext();
        List<Question> QuestionsList = new List<Question>();

        public CreateQuizForm()
        {
            InitializeComponent();
        }

        private void CreateQuizForm_Load(object sender, EventArgs e)
        {

        }


        private void CreateQuiz_Click(object sender, EventArgs e)
        {
            string TitleOfQuestion = TitleOfQuestionTextBox.Text;
            string DescriptionOfQuestion = DescriptionQuestionTextBox.Text;
            string AuxiliarImage = AuxiliarImageTextBox.Text;
            string Option_A = OptionATextBox.Text;
            string Option_B = OptionBTextBox.Text;
            string Option_C = OptionCTextBox.Text;
            string Option_D = OptionCTextBox.Text;
            char CorrectOption = CorrectOptionTextBox.Text.Length > 0 ? CorrectOptionTextBox.Text[0] : '\0';
            int PointsToEarn = 0;
            int PointsToLost = 0;
            DateTime CreatedAt = DateTime.Now;
            Themes ThemeOfQuestion = Themes.ComputerScience;

            Question question = new Question()
            {
                TitleOfQuestion = TitleOfQuestion,
                DescriptionOfQuestion = DescriptionOfQuestion,
                AuxiliarImage = AuxiliarImage,
                Option_A = Option_A,
                Option_B = Option_B,
                Option_C = Option_C,
                Option_D = Option_D,
                CorrectOption = CorrectOption,
                PointsToEarn = PointsToEarn,
                PointsToLost = PointsToLost,
                CreatedAt = CreatedAt,
                ThemeOfQuestion = ThemeOfQuestion,
            };

            QuestionsList.Add(question);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void CreateQuiz_Click_1(object sender, EventArgs e)
        {
            string QuizTitle = TitleOfQuizTextBox.Text; 
            string QuizDescription = DescriptioQuizTextBox.Text;
            string PathUrl = URLQuizTextBox.Text;
            Themes theme = Themes.ComputerScience;

            Quiz quiz = new Quiz()
            {
                QuizTitle = QuizTitle,
                QuizDescription = QuizDescription,
                ThumbnailQuizPath = PathUrl,
                ThemeOfQuiz = theme,
                Questions = QuestionsList
            };

            if (QuestionsList.Count > 0)
            {
                _context.Quizzes.Add(quiz);
                await _context.SaveChangesAsync();
            }
        }
    }
}
