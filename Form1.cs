using Microsoft.EntityFrameworkCore;
using QuizForMe.Data;
using QuizForMe.Models;
using System.ComponentModel;

namespace QuizForMe
{
    public partial class CreateQuizButton : Form
    {

        private AppDbContext _context;
        public CreateQuizButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateQuizForm ffq = new CreateQuizForm();
            ffq.ShowDialog();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this._context = new AppDbContext();

            this._context.Database.EnsureCreated();

            this._context.Quizzes.Load();

            this.quizBindingSource.DataSource = _context.Quizzes.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this._context.Dispose();
        }

        private void RefreshTable_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            this._context.Quizzes.Load();
            this.quizBindingSource.DataSource = _context.Quizzes.Local.ToBindingList();
            this.dataGridView1.Refresh();
        }

        private async void dataGridView1_CellContentClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            int QuizId = Convert.ToInt32(selectedRow.Cells[0].Value);
            var quiz = await _context.Quizzes.FindAsync(QuizId);

            if (quiz == null)
            {
                throw new Exception("Fudeu");
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "DeleteButtonQuiz")
            {
                _context.Quizzes.Remove(quiz);
                await _context.SaveChangesAsync();
                RefreshDataGrid();
                
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "PlayQuizButton")
            {
                QuizForm quizForm = new QuizForm(quiz);
                quizForm.ShowDialog();
            }
        }
    }
}
