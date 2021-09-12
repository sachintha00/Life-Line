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
    public partial class frmGrade6TO11StudentSubjects : Form
    {
        public static string passSubId;
        public frmGrade6TO11StudentSubjects()
        {
            InitializeComponent();
            subjectLoad();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel7_Paint(object sender, PaintEventArgs e)
        {

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

        //private async void transitionLoad()
        //{
        //    pnlSubjects.Visible = false;
        //    //pnlAttend.Visible = false;
        //    //pnlRank.Visible = false;
        //    //pnlProgressTopic.Visible = false;
        //    //pnlprogress.Visible = false;
        //    //dgvArchievement.Visible = false;
        //    //dgvStEvents.Visible = false;

        //    await Task.Run(() =>
        //    {
        //        trnsLoad.ShowSync(pnlSubjects);
        //        trnsLoad.ShowSync(grpTimeTbl);
        //        //trnsLoad.ShowSync(pnlRank);
        //        //trnsLoad.ShowSync(pnlProgressTopic);
        //        //trnsLoad.ShowSync(pnlprogress);
        //        //trnsLoad.ShowSync(dgvArchievement);
        //        //trnsLoad.ShowSync(dgvStEvents);
        //    });
        //}

        private void frmGrade6StudentSubjects_Load(object sender, EventArgs e)
        {
            //transitionLoad();
        }

        private void pbScience_Click_1(object sender, EventArgs e)
        {
            passSubId = "SUB0004";
            BackGround.transparent(new frmGrade6SubjectInside());
        }

        private void pbMaths_Click(object sender, EventArgs e)
        {
            passSubId = "SUB0006";
            BackGround.transparent(new frmGrade6SubjectInside());
        }

        private void pbEnglish_Click_1(object sender, EventArgs e)
        {
            passSubId = "SUB0005";
            BackGround.transparent(new frmGrade6SubjectInside());
        }

        private void pbSinhala_Click_1(object sender, EventArgs e)
        {
            passSubId = "SUB0001";
            BackGround.transparent(new frmGrade6SubjectInside());
        }

        private void pbReligion_Click_1(object sender, EventArgs e)
        {
            passSubId = "SUB0002";
            BackGround.transparent(new frmGrade6SubjectInside());
        }

        private void pbHistory_Click_1(object sender, EventArgs e)
        {
            passSubId = "SUB0003";
            BackGround.transparent(new frmGrade6SubjectInside());
        }

        private void pbGroup1_Click_1(object sender, EventArgs e)
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

        private void pbGroup3_Click_1(object sender, EventArgs e)
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
