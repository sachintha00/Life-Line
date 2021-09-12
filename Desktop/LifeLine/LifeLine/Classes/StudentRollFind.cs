using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLine.Classes
{
    public static class StudentRollFind
    {
        
        public static string studentGrade(int age)
        {
            string Grade = string.Empty;
            switch(age)
            {
                case 11:
                    Grade = "Grade6";
                    break;
                case 12:
                    Grade = "Grade7";
                    break;
                case 13:
                    Grade = "Grade8";
                    break;
                case 14:
                    Grade = "Grade9";
                    break;
                case 15:
                    Grade = "Grade10";
                    break;
                case 16:
                    Grade = "Grade11";
                    break;
                case 17:
                    Grade = "Grade12";
                    break;
                case 18:
                    Grade = "Grade13";
                    break;
            }

           return Grade;
        }

        public static string studentRoll(int age)
        {
            string roll = string.Empty;
            if (age < 17)
                roll = "GRADE6-11";
            else
                roll = "GRADE12-13";

            return roll;
        }
    }
}
