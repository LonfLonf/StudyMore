namespace QuizForMe
{
    public partial class CreateQuizButton : Form
    {
        public CreateQuizButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormForQuiz ffq = new FormForQuiz();
            ffq.ShowDialog();
        }
    }
}
