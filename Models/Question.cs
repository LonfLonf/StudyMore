using QuizForMe.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizForMe.Models
{
    public class Question
    {
        public int questionId {  get; set; }
        public string TitleOfQuestion { get; set; }
        public string DescriptionOfQuestion { get; set; }
        public string AuxiliarImage { get; set; }
        public string Option_A { get; set; }
        public string Option_B { get; set; }
        public string Option_C { get; set; }
        public string Option_D { get; set; }
        public char CorrectOption { get; set; }
        public int PointsToEarn { get; set; }
        public int PointsToLost { get; set; }
        public DateTime CreatedAt { get; set; }

        public Themes ThemeOfQuestion { get; set; }
        
        public Quiz QuizOwner { get; set; }
    }
}
