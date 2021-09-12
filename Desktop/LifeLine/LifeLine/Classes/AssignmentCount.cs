using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLine.Classes
{
    public static class AssignmentCount
    {
        public static int allCountGrade(string grade)
        {
            DataTable dt = new DataTable();
            dt = DBManager.getdata("SELECT * FROM `student_account` WHERE st_Grade = '" + grade + "'");
            return dt.Rows.Count;
        }

        public static int submitAssCount(string grade,string subID)
        {
            DataTable dt = new DataTable();
            dt = DBManager.getdata("SELECT * FROM `student_assignment_upload` WHERE grade = '" + grade + "' AND subject_id  = '" + subID + "' GROUP BY student_ID");
            return dt.Rows.Count;
        }
    }
}
