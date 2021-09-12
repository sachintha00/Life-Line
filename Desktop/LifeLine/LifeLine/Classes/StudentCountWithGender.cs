using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLine.Classes
{
    public class StudentCountWithGender
    {
        public int stwithGenderCount(string gender, string grade)
        {
            DataTable dt = new DataTable();
            dt = DBManager.getdata("SELECT * FROM student_account WHERE st_gender = '"+ gender + "' AND st_Grade = '" + grade + "'");
            return dt.Rows.Count;
        }

        public string countStudent(string grade)
        {
            DataTable dt = new DataTable();
            dt = DBManager.getdata("SELECT * FROM student_account WHERE st_Grade = '" + grade + "' ");
            return dt.Rows.Count.ToString();
        }
    }
}
