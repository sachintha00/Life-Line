using LifeLine.Classes;
using LifeLine.Students;
using SMDLogic;
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
    public partial class frmGrade6TO11TeacherDash : Form
    {
        public static string passGrd;
        private string Subject, subId;
        public frmGrade6TO11TeacherDash()
        {
            InitializeComponent();

            Subject = DBManager.getValue("SELECT * FROM `teacher_account`", frmLogin.passingRollId, 0, 9);
            subId = DBManager.getValue("SELECT * FROM `subject`", Subject, 2, 0);
        }

        private void chartLoad()
        {
            chrtSubmitedAssignment.Series[0].Points.AddXY("Grade 6", AssignmentCount.allCountGrade("Grade6"));
            chrtSubmitedAssignment.Series[1].Points.AddXY("Grade 6", AssignmentCount.submitAssCount("Grade6", subId));
            chrtSubmitedAssignment.Series[0].Points.AddXY("Grade 7", AssignmentCount.allCountGrade("Grade7"));
            chrtSubmitedAssignment.Series[1].Points.AddXY("Grade 7", AssignmentCount.submitAssCount("Grade7", subId));
            chrtSubmitedAssignment.Series[0].Points.AddXY("Grade 8", AssignmentCount.allCountGrade("Grade8"));
            chrtSubmitedAssignment.Series[1].Points.AddXY("Grade 8", AssignmentCount.submitAssCount("Grade8", subId));
            chrtSubmitedAssignment.Series[0].Points.AddXY("Grade 9", AssignmentCount.allCountGrade("Grade9"));
            chrtSubmitedAssignment.Series[1].Points.AddXY("Grade 9", AssignmentCount.submitAssCount("Grade9", subId));
            chrtSubmitedAssignment.Series[0].Points.AddXY("Grade 10", AssignmentCount.allCountGrade("Grade10"));
            chrtSubmitedAssignment.Series[1].Points.AddXY("Grade 10", AssignmentCount.submitAssCount("Grade10", subId));
            chrtSubmitedAssignment.Series[0].Points.AddXY("Grade 11", AssignmentCount.allCountGrade("Grade11"));
            chrtSubmitedAssignment.Series[1].Points.AddXY("Grade 11", AssignmentCount.submitAssCount("Grade11", subId));
        }

        private void countData()
        {
            DataTable dt1 = new DataTable();
            dt1 = DBManager.getdata("SELECT * FROM `teacher_assignment_upload`");
            lblALLassignment.Text = "+" + dt1.Rows.Count.ToString();

            DataTable dt2 = new DataTable();
            dt2 = DBManager.getdata("SELECT * FROM `teacher_note_upload`");
            lblALLnotes.Text = "+" + dt2.Rows.Count.ToString();

            lblGrade6.Text = AssignmentCount.submitAssCount("Grade6", subId).ToString();
            lblGrade7.Text = AssignmentCount.submitAssCount("Grade7", subId).ToString();
            lblGrade8.Text = AssignmentCount.submitAssCount("Grade8", subId).ToString();
            lblGrade9.Text = AssignmentCount.submitAssCount("Grade9", subId).ToString();
            lblGrade10.Text = AssignmentCount.submitAssCount("Grade10", subId).ToString();
            lblGrade11.Text = AssignmentCount.submitAssCount("Grade11", subId).ToString();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel7_Click(object sender, EventArgs e)
        {
            passGrd = "Grade6";
            BackGround.transparent(new frmGradeInsideDash());
        }

        private void guna2ShadowPanel2_Click(object sender, EventArgs e)
        {
            passGrd = "Grade7";
            BackGround.transparent(new frmGradeInsideDash());
        }

        private void guna2ShadowPanel3_Click(object sender, EventArgs e)
        {
            passGrd = "Grade8";
            BackGround.transparent(new frmGradeInsideDash());
        }

        private void guna2ShadowPanel4_Click(object sender, EventArgs e)
        {
            passGrd = "Grade9";
            BackGround.transparent(new frmGradeInsideDash());
        }

        private void guna2ShadowPanel5_Click(object sender, EventArgs e)
        {
            passGrd = "Grade10";
            BackGround.transparent(new frmGradeInsideDash());
        }

        private void guna2ShadowPanel6_Click(object sender, EventArgs e)
        {
            passGrd = "Grade11";
            BackGround.transparent(new frmGradeInsideDash());
        }

        private void frmGrade6StudentDash_Load(object sender, EventArgs e)
        {
            chartLoad();
            countData();
        }
    }
}
