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
            this._context.Quizzes.Load();
            this.quizBindingSource.DataSource = _context.Quizzes.Local.ToBindingList();
            this.dataGridView1.Refresh();
        }
    }
}
