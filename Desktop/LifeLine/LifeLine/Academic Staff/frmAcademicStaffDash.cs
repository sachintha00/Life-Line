using LifeLine.Classes;
using LifeLine.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeLine
{
    public partial class frmAcademicStaffDash : Form
    {
        private StudentCountWithGender count = new StudentCountWithGender();
        public frmAcademicStaffDash()
        {
            InitializeComponent();
            allSTandTeachCount();
            countStudent();
        }

        private void allSTandTeachCount()
        {
            DataTable dt1 = new DataTable();
            dt1 = DBManager.getdata("SELECT * FROM `student_account`");
            lblAllStudent.Text = "+" + dt1.Rows.Count.ToString();

            DataTable dt2 = new DataTable();
            dt2 = DBManager.getdata("SELECT * FROM `teacher_account`");
            lblAllTeachers.Text = "+" + dt2.Rows.Count.ToString();
        }

        private void countStudent()
        {
            lblGrade6.Text = count.countStudent("Grade6");
            lblGrade7.Text = count.countStudent("Grade7");
            lblGrade8.Text = count.countStudent("Grade8");
            lblGrade9.Text = count.countStudent("Grade9");
            lblGrade10.Text = count.countStudent("Grade10");
            lblGrade11.Text = count.countStudent("Grade11");

            lblGrade12.Text = count.countStudent("Grade12");
            lblGrade13.Text = count.countStudent("Grade13");
        }

        private void chartLoad()
        {
            chrtOLstudent.Series[0].Points.AddXY("Grade 6", count.stwithGenderCount("Male", "Grade6"));
            chrtOLstudent.Series[1].Points.AddXY("Grade 6", count.stwithGenderCount("Female", "Grade6"));
            chrtOLstudent.Series[0].Points.AddXY("Grade 7", count.stwithGenderCount("Male", "Grade7"));
            chrtOLstudent.Series[1].Points.AddXY("Grade 7", count.stwithGenderCount("Female", "Grade7"));
            chrtOLstudent.Series[0].Points.AddXY("Grade 8", count.stwithGenderCount("Male", "Grade8"));
            chrtOLstudent.Series[1].Points.AddXY("Grade 8", count.stwithGenderCount("Female", "Grade8"));
            chrtOLstudent.Series[0].Points.AddXY("Grade 9", count.stwithGenderCount("Male", "Grade9"));
            chrtOLstudent.Series[1].Points.AddXY("Grade 9", count.stwithGenderCount("Female", "Grade9"));
            chrtOLstudent.Series[0].Points.AddXY("Grade 10", count.stwithGenderCount("Male", "Grade10"));
            chrtOLstudent.Series[1].Points.AddXY("Grade 10", count.stwithGenderCount("Female", "Grade10"));
            chrtOLstudent.Series[0].Points.AddXY("Grade 11", count.stwithGenderCount("Male", "Grade11"));
            chrtOLstudent.Series[1].Points.AddXY("Grade 11", count.stwithGenderCount("Female", "Grade11"));

            chrtALstudent.Series[0].Points.AddXY("Grade 12", count.stwithGenderCount("Male", "Grade12"));
            chrtALstudent.Series[1].Points.AddXY("Grade 12", count.stwithGenderCount("Female", "Grade12"));
            chrtALstudent.Series[0].Points.AddXY("Grade 13", count.stwithGenderCount("Male", "Grade13"));
            chrtALstudent.Series[1].Points.AddXY("Grade 13", count.stwithGenderCount("Female", "Grade13"));

            chrtTeacher.Series[0].Points.AddXY("Grade 12", 30);
            chrtTeacher.Series[1].Points.AddXY("Grade 12", 50);
            chrtTeacher.Series[2].Points.AddXY("Grade 13", 40);
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmGrade6StudentDash_Load(object sender, EventArgs e)
        {
            allSTandTeachCount();
            chartLoad();
            countStudent();
        }

        private void guna2ShadowPanel14_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
