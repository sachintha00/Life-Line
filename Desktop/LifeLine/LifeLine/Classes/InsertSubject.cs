using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLine.Classes
{
    public class InsertSubject
    {
        public InsertSubject(string rollId)
        {
            DBManager.insrtUpdteDelt("INSERT INTO `student_subject`(`subject_id`, `st_roll_id`) VALUES ('SUB0001','" + rollId + "')");
            DBManager.insrtUpdteDelt("INSERT INTO `student_subject`(`subject_id`, `st_roll_id`) VALUES ('SUB0002','" + rollId + "')");
            DBManager.insrtUpdteDelt("INSERT INTO `student_subject`(`subject_id`, `st_roll_id`) VALUES ('SUB0003','" + rollId + "')");
            DBManager.insrtUpdteDelt("INSERT INTO `student_subject`(`subject_id`, `st_roll_id`) VALUES ('SUB0004','" + rollId + "')");
            DBManager.insrtUpdteDelt("INSERT INTO `student_subject`(`subject_id`, `st_roll_id`) VALUES ('SUB0005','" + rollId + "')");
            DBManager.insrtUpdteDelt("INSERT INTO `student_subject`(`subject_id`, `st_roll_id`) VALUES ('SUB0006','" + rollId + "')");
        }
    }
}
