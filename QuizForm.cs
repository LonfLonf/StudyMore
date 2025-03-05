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
    public partial class QuizForm : Form
    {
        private Quiz _quizInstance;

        public QuizForm()
        {
            InitializeComponent();
        }

        public QuizForm(Quiz quiz)
        {
            _quizInstance = quiz;
            InitializeComponent();
        }
    }
}
