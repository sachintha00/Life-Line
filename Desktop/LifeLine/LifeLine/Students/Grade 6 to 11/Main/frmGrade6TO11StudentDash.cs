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
    public partial class frmGrade6TO11StudentDash : Form
    {
        public static string passSubId;
        public frmGrade6TO11StudentDash()
        {
            InitializeComponent();
        }

        private void chartLoad()
        {
            chrtResult.Series[0].Points.AddXY("Sinhala", 60);
            chrtResult.Series[0].Points.AddXY("Religion", 50);
            chrtResult.Series[0].Points.AddXY("History", 80);
            chrtResult.Series[0].Points.AddXY("Science", 95);
            chrtResult.Series[0].Points.AddXY("English", 56);
            chrtResult.Series[0].Points.AddXY("Maths", 78);
            chrtResult.Series[0].Points.AddXY("Commerce", 76);
            chrtResult.Series[0].Points.AddXY("Art", 96);
            chrtResult.Series[0].Points.AddXY("IT", 46);
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmGrade6StudentDash_Load(object sender, EventArgs e)
        {
            populateItem();
            chartLoad();
            subjectLoad();
        }

        private void subjectLoad()
        {
            DataTable dt = new DataTable();
            dt = DBManager.getdata("SELECT * FROM `student_subject` WHERE st_roll_id = '" + frmLogin.passingRollId + "'");
            foreach (DataRow dr in dt.Rows)
            {
                DataTable dt1 = new DataTable();
                dt1 = DBManager.getdata("SELECT * FROM `subject` WHERE subject_id = '" + dr["subject_id"] + "'");
                foreach (DataRow dr1 in dt1.Rows)
                {
                    if (dr1[1].ToString() == "BASKET1(O/L)")
                    {
                        lblGroup1.Text = dr1[2].ToString();
                        break;
                    }
                    if (dr1[1].ToString() == "BASKET2(O/L)")
                    {
                        lblGroup2.Text = dr1[2].ToString();
                        break;
                    }
                    if (dr1[1].ToString() == "BASKET3(O/L)")
                    {
                        lblGroup3.Text = dr1[2].ToString();
                        break;
                    }

                }
            }
        }

        private void populateItem()
        {
            frmEvents[] list = new frmEvents[20];
            
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = new frmEvents();
                list[i].TopLevel = false;
                list[i].Dock = DockStyle.Top;
                list[i].Title = "Today Exams";
                list[i].Message = "The maths exam will be held on 1pm - 3pm";

                guna2ShadowPanel2.Controls.Add(list[i]);
                list[i].Show();
            }
        }

        private void gunaLabel25_Click_1(object sender, EventArgs e)
        {
            passSubId = "SUB0004";
            BackGround.transparent(new frmGrade6SubjectInsideDash());
        }

        private void pbScience_Click(object sender, EventArgs e)
        {
            passSubId = "SUB0006";
            BackGround.transparent(new frmGrade6SubjectInsideDash());
        }

        private void pbEnglish_Click(object sender, EventArgs e)
        {
            passSubId = "SUB0005";
            BackGround.transparent(new frmGrade6SubjectInsideDash());
        }

        private void pbSinhala_Click(object sender, EventArgs e)
        {
            passSubId = "SUB0001";
            BackGround.transparent(new frmGrade6SubjectInsideDash());
        }

        private void pbReligion_Click(object sender, EventArgs e)
        {
            passSubId = "SUB0002";
            BackGround.transparent(new frmGrade6SubjectInsideDash());
        }

        private void pbHistory_Click(object sender, EventArgs e)
        {
            passSubId = "SUB0003";
            BackGround.transparent(new frmGrade6SubjectInsideDash());
        }

        private void pbGroup1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DBManager.getdata("SELECT * FROM `student_subject` WHERE st_roll_id = '" + frmLogin.passingRollId + "'");
            foreach (DataRow dr in dt.Rows)
            {
                DataTable dt1 = new DataTable();
                dt1 = DBManager.getdata("SELECT * FROM `subject` WHERE subject_id = '" + dr["subject_id"] + "'");
                foreach (DataRow dr1 in dt1.Rows)
                {
                    if (dr1[1].ToString() == "BASKET1(O/L)")
                    {
                        passSubId = dr1[0].ToString();
                        break;
                    }

                }
            }
            BackGround.transparent(new frmGrade6SubjectInside());
        }

        private void pbGroup2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DBManager.getdata("SELECT * FROM `student_subject` WHERE st_roll_id = '" + frmLogin.passingRollId + "'");
            foreach (DataRow dr in dt.Rows)
            {
                DataTable dt1 = new DataTable();
                dt1 = DBManager.getdata("SELECT * FROM `subject` WHERE subject_id = '" + dr["subject_id"] + "'");
                foreach (DataRow dr1 in dt1.Rows)
                {
                    if (dr1[1].ToString() == "BASKET2(O/L)")
                    {
                        passSubId = dr1[0].ToString();
                        break;
                    }

                }
            }
            BackGround.transparent(new frmGrade6SubjectInside());
        }

        private void pbGroup3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DBManager.getdata("SELECT * FROM `student_subject` WHERE st_roll_id = '" + frmLogin.passingRollId + "'");
            foreach (DataRow dr in dt.Rows)
            {
                DataTable dt1 = new DataTable();
                dt1 = DBManager.getdata("SELECT * FROM `subject` WHERE subject_id = '" + dr["subject_id"] + "'");
                foreach (DataRow dr1 in dt1.Rows)
                {
                    if (dr1[1].ToString() == "BASKET3(O/L)")
                    {
                        passSubId = dr1[0].ToString();
                        break;
                    }

                }
            }
            BackGround.transparent(new frmGrade6SubjectInside());
        }
    }
}
