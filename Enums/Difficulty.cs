using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizForMe.Enums
{
    public enum Difficulty
    {
        Easy = 1,
        Medium = 2,
        Hard = 3,
        Master = 4
    }

    public class EnumConverterToDifficulty
    {
        public Difficulty ConvertStringToEnum(string value)
        {
            if (Enum.TryParse(value, out Difficulty result))
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
