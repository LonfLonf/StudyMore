using Microsoft.EntityFrameworkCore;
using QuizForMe.Data;
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
using static System.Net.Mime.MediaTypeNames;

namespace QuizForMe
{
    public partial class QuizForm : Form
    {
        private Quiz _quizInstance;
        List<Panel> Panels = new List<Panel>();
        Question[] Questions;
        int index = 0;

        private AppDbContext _context = new AppDbContext();

        public QuizForm()
        {
            InitializeComponent();
        }

        public async Task QuizFormAsync(Quiz quiz)
        {
            _quizInstance = quiz;
            Questions = (await GetQuestionsAsync(quiz.QuizId)).ToArray();
            QuizForm_Load();
        }

        private async Task<List<Question>> GetQuestionsAsync(int QuizId)
        {
            return await _context.Questions
                .Where(q => q.QuizID == QuizId)
                .ToListAsync();
        }

        private void QuizForm_Load()
        {
            Debug.WriteLine("FUI CHAMADO NESSA PORRA");
            for (int i = 0; i < Questions.Length; i++)
            {
                Panel panel = CreatePanel(Questions[i]);
                Panels.Add(panel);
                this.Controls.Add(panel);   
            }

            if (Panels.Count > 0)
            {
                Panels[index].BringToFront();
            }
            Debug.WriteLine("METI O PE NESSA PORRA");
        }

        private Panel CreatePanel(Question question)
        {
            Panel panel = new Panel();
            panel.Width = 1339;
            panel.Height = 579;

            Label Title = new Label();
            Title.MinimumSize = new Size(223, Title.MinimumSize.Height);
            Title.MaximumSize = new Size(Title.MaximumSize.Width, 15);
            Title.Text = question.TitleOfQuestion;
            Title.TextAlign = ContentAlignment.MiddleCenter;
            Title.Location = new Point(569, 15);

            Label Description = new Label();
            Description.MinimumSize = new Size(223, Title.MinimumSize.Height);
            Description.MaximumSize = new Size(Title.MaximumSize.Width, 25);
            Description.Text = question.DescriptionOfQuestion;
            Description.TextAlign = ContentAlignment.MiddleCenter;
            Description.Location = new Point(569, 41);

            PictureBox pictureBoxImage = new PictureBox();
            pictureBoxImage.Location = new Point(436, 89);
            pictureBoxImage.Size = new Size(480, 304);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.ImageLocation = question.AuxiliarImage;

            // Buttons Options

            TableLayoutPanel tableLayoutPanelButtonOptions = new TableLayoutPanel();
            tableLayoutPanelButtonOptions.Location = new Point(470, 403);
            tableLayoutPanelButtonOptions.Size = new Size(1339, 121);
            tableLayoutPanelButtonOptions.ColumnCount = 2;
            tableLayoutPanelButtonOptions.RowCount = 2;

            Button buttonOptionA = new Button();
            buttonOptionA.Text = question.Option_A;
            buttonOptionA.TextAlign = ContentAlignment.MiddleCenter;
            buttonOptionA.Size = new Size(200, 54);
            buttonOptionA.Dock = DockStyle.Right;
            buttonOptionA.Click += buttonA_Click;

            Button buttonOptionB = new Button();
            buttonOptionB.Text = question.Option_B;
            buttonOptionB.TextAlign = ContentAlignment.MiddleCenter;
            buttonOptionB.Size = new Size(200, 54);
            buttonOptionB.Dock = DockStyle.Left;
            buttonOptionB.Click += buttonB_Click;

            Button buttonOptionC = new Button();
            buttonOptionC.Text = question.Option_C;
            buttonOptionC.TextAlign = ContentAlignment.MiddleCenter;
            buttonOptionC.Size = new Size(200, 54);
            buttonOptionC.Dock = DockStyle.Right;
            buttonOptionC.Click += buttonC_Click;

            Button buttonOptionD = new Button();
            buttonOptionD.Text = question.Option_D;
            buttonOptionD.TextAlign = ContentAlignment.MiddleCenter;
            buttonOptionD.Size = new Size(200, 54);
            buttonOptionD.Dock = DockStyle.Left;
            buttonOptionD.Click += buttonD_Click;

            tableLayoutPanelButtonOptions.Controls.Add(buttonOptionA,0,0);
            tableLayoutPanelButtonOptions.Controls.Add(buttonOptionB,1,0);
            tableLayoutPanelButtonOptions.Controls.Add(buttonOptionC,0,1);
            tableLayoutPanelButtonOptions.Controls.Add(buttonOptionD,1,1);

            // Buttons Previous/Next
            TableLayoutPanel tableLayoutPanelButtonsPreviousAndNext = new TableLayoutPanel();
            tableLayoutPanelButtonsPreviousAndNext.Location = new Point(530, 530);
            tableLayoutPanelButtonsPreviousAndNext.Size = new Size(300, 27);
            tableLayoutPanelButtonsPreviousAndNext.ColumnCount = 2;
            tableLayoutPanelButtonsPreviousAndNext.RowCount = 1;

            Button buttonPrevious = new Button();
            buttonPrevious.Text = "Previous";
            buttonPrevious.TextAlign = ContentAlignment.MiddleLeft;
            buttonPrevious.Size = new Size(144, 21);
            buttonPrevious.Click += buttonPrevious_Click;

            Button buttonNext = new Button();
            buttonNext.Text = "Next";
            buttonNext.TextAlign = ContentAlignment.MiddleLeft;
            buttonNext.Size = new Size(144, 21);
            buttonNext.Click += buttonNext_Click;

            tableLayoutPanelButtonsPreviousAndNext.Controls.Add(buttonPrevious,0,0);
            tableLayoutPanelButtonsPreviousAndNext.Controls.Add(buttonNext,1,0);

            panel.Controls.Add(Title);
            panel.Controls.Add(Description);
            panel.Controls.Add(tableLayoutPanelButtonOptions);
            panel.Controls.Add(pictureBoxImage);
            panel.Controls.Add(tableLayoutPanelButtonsPreviousAndNext);

            return panel;
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                Panels[index].BringToFront();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (index < Panels.Count - 1)
            {
                index++;
                Panels[index].BringToFront();
            }
        }

        private bool checkCorrectAnswer(char answer)
        {
            return answer == Questions[index].CorrectOption;
        }

        private void handleAnswer(Button button, char answer)
        {
            if (checkCorrectAnswer(answer))
            {
                button.BackColor = Color.Green;
            }
            else
            {
                button.BackColor = Color.Red;  
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            handleAnswer((Button)sender, 'A');
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            handleAnswer((Button)sender, 'B');
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            handleAnswer((Button)sender, 'C');
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            handleAnswer((Button)sender, 'D');
        }
    }
}
