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
            Description.MinimumSize = new Size(250, Title.MinimumSize.Height);
            Description.MaximumSize = new Size(Title.MaximumSize.Width, 25);
            Description.Text = question.DescriptionOfQuestion;
            Description.TextAlign = ContentAlignment.MiddleCenter;
            Description.Location = new Point(622, 41);

            PictureBox pictureBoxImage = new PictureBox();
            pictureBoxImage.Location = new Point(436, 89);
            pictureBoxImage.Size = new Size(480, 304);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.ImageLocation = question.AuxiliarImage;

            // Buttons Options

            TableLayoutPanel tableLayoutPanelButtonOptions = new TableLayoutPanel();
            tableLayoutPanelButtonOptions.Location = new Point(12, 403);
            tableLayoutPanelButtonOptions.Size = new Size(1339, 121);
            tableLayoutPanelButtonOptions.ColumnCount = 2;
            tableLayoutPanelButtonOptions.RowCount = 2;

            Button buttonOptionA = new Button();
            buttonOptionA.Text = "A";
            buttonOptionA.TextAlign = ContentAlignment.MiddleCenter;
            buttonOptionA.Size = new Size(147, 54);
            buttonOptionA.Dock = DockStyle.Right;

            Button buttonOptionB = new Button();
            buttonOptionB.Text = "B";
            buttonOptionB.TextAlign = ContentAlignment.MiddleCenter;
            buttonOptionB.Size = new Size(147, 54);
            buttonOptionB.Dock = DockStyle.Left;

            Button buttonOptionC = new Button();
            buttonOptionC.Text = "C";
            buttonOptionC.TextAlign = ContentAlignment.MiddleCenter;
            buttonOptionC.Size = new Size(147, 54);
            buttonOptionC.Dock = DockStyle.Right;

            Button buttonOptionD = new Button();
            buttonOptionD.Text = "D";
            buttonOptionD.TextAlign = ContentAlignment.MiddleCenter;
            buttonOptionD.Size = new Size(147, 54);
            buttonOptionD.Dock = DockStyle.Left;

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
