using QuizForMe.Data;
using QuizForMe.Enums;
using QuizForMe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnumConverter = QuizForMe.Enums.EnumConverter;

namespace QuizForMe
{
    public partial class CreateQuizForm : Form
    {
        private readonly AppDbContext _context = new AppDbContext();
        List<Question> QuestionsList = new List<Question>();
        EnumConverter converter = new EnumConverter();
        EnumConverterToDifficulty converterToDifficulty = new EnumConverterToDifficulty();

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
            string Option_D = OptionDTextBox.Text;
            char CorrectOption = CorrectOptionTextBox.Text.Length > 0 ? CorrectOptionTextBox.Text[0] : '\0';
            int PointsToEarn = 0;
            int PointsToLost = 0;

            try
            {
                int difficultyInt = (int)converterToDifficulty.ConvertStringToEnum(DifficultyComboBox.Text);
                PointsToEarn = GetPointsToEarn(difficultyInt);
                PointsToLost = GetPointsToLost(difficultyInt);
            } 
            catch (ArgumentException ex)
            {
                Debug.WriteLine("Error in Conversion - Error: " + ex.ToString());
                label5.Text = "Question Added Error";
                label5.ForeColor = Color.Red;
                return;
            } 
            catch (Exception ex)
            {
                Debug.WriteLine("Error in Conversion" + ex.ToString());
                label5.Text = "Question Added Error";
                label5.ForeColor = Color.Red;
                return;
            }

            DateTime CreatedAt = DateTime.Now;
            Themes ThemeOfQuestion = converter.ConvertStringToEnum(ThemeQuestionComboBox.Text);

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

            try
            {
                QuestionsList.Add(question);
                label5.Text = "Question Added";
                label5.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
                label5.Text = "Question Added Error";
                label5.ForeColor = Color.Red;
            }

            Clear();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void CreateQuiz_Click_1(object sender, EventArgs e)
        {
            string QuizTitle = TitleOfQuizTextBox.Text;
            string QuizDescription = DescriptioQuizTextBox.Text;
            string PathUrl = URLQuizTextBox.Text;
            Themes theme = Themes.OtherStuff;
            
            try
            {
                theme = converter.ConvertStringToEnum(ThemeQuizComboBox.Text);
            } 
            catch (ArgumentException ex)
            {
                Debug.WriteLine("Error in Convert on Create Quiz" + ex.ToString());
            } 
            catch (Exception ex)
            {
                Debug.WriteLine("Error on Create Quiz" + ex.ToString());
            }
            

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

        public void Clear()
        {
            TitleOfQuestionTextBox.Text = string.Empty;
            DescriptionQuestionTextBox.Text = string.Empty;
            AuxiliarImageTextBox.Text = string.Empty;
            OptionATextBox.Text = string.Empty;
            OptionBTextBox.Text = string.Empty;
            OptionCTextBox.Text = string.Empty;
            OptionDTextBox.Text = string.Empty;
            CorrectOptionTextBox.Text = string.Empty;
            ThemeQuestionComboBox.Text = string.Empty;
            DifficultyComboBox.Text = string.Empty;
        }

        public int GetPointsToEarn(int Difficulty)
        {
            switch (Difficulty)
            {
                case 1: return 10;
                case 2: return 15;
                case 3: return 30;
                case 4: return 50;
                default: return 0;
            }
        }
        public int GetPointsToLost(int Difficulty)
        {
            switch (Difficulty)
            {
                case 1: return 35;
                case 2: return 20;
                case 3: return 15;
                case 4: return 10;
                default: return 0;
            }
        }
    }
}
