using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLine.Classes
{
    public static class TeacherRollFind
    {
        public static string TeacherRoll(string Subject)
        {
            string GraTeachRollid = string.Empty;
            DataTable dt = new DataTable();
            dt = DBManager.getdata("SELECT * FROM subject WHERE `subject` = '"+Subject+"'");

            foreach (DataRow dr in dt.Rows)
            {
                switch(dr["subject_roll"].ToString())
                {
                    case "MAIN(O/L)":
                    case "BASKET1(O/L)":
                    case "BASKET2(O/L)":
                    case "BASKET3(O/L)":
                        GraTeachRollid = "6-11";
                        break;
                    case "ARTS1(A/L)":
                    case "ARTS2(A/L)":
                    case "ARTS3(A/L)":
                    case "TECH1(A/L)":
                    case "TECH2(A/L)":
                    case "TECH3(A/L)":
                    case "COMMERCE1(A/L)":
                    case "COMMERCE2(A/L)":
                    case "COMMERCE3(A/L)":
                    case "MATHS1(A/L)":
                    case "MATHS2(A/L)":
                    case "MATHS3(A/L)":
                    case "BIO1(A/L)":
                    case "BIO2(A/L)":
                    case "BIO3(A/L)":
                        GraTeachRollid = "12-13";
                        break;
                }
            }
            return GraTeachRollid;
        }
    }
}
