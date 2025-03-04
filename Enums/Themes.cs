using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuizForMe.Enums
{
    public enum Themes
    {
        Mathematics,
        History,
        ComputerScience,
        Philosophy, 
        Programming, 
        MalwareDevelopment,
        CyberSecurity,
        OtherStuff
    }

    public class EnumConverter
    {
        public Themes ConvertStringToEnum(string value)
        {
            if (Enum.TryParse(value, out Themes result))
            {
                return result; 
            }
            else
            {
                throw new ArgumentException("Invalid enum value");
            }
        }
    }
}
