using Guna.UI.WinForms;
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
    public partial class frmGrade12TO13StudentDash : Form
    {
        public static string passSubId;
        private List<GunaLabel> listLbl = new List<GunaLabel>();
        private List<GunaLabel> listLblReslt = new List<GunaLabel>();
        private List<string> tempSubId = new List<string>();
        public frmGrade12TO13StudentDash()
        {
            InitializeComponent();
            listLbl.Add(lblGroup1);
            listLbl.Add(lblGroup2);
            listLbl.Add(lblGroup3);

            listLblReslt.Add(lblFirstSub);
            listLblReslt.Add(lblSecondSub);
            listLblReslt.Add(lblThirdSub);
            subjectLoad();
        }

        private void chartLoad()
        {
            chrtResult.Series[0].Points.AddXY(lblGroup1.Text, 60);
            chrtResult.Series[0].Points.AddXY(lblGroup2.Text, 50);
            chrtResult.Series[0].Points.AddXY(lblGroup3.Text, 50);

            lblFirstSub.Text = lblGroup1.Text;
            lblSecondSub.Text = lblGroup2.Text;
            lblThirdSub.Text = lblGroup3.Text;
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
            int i = 0,j=0;
            DataTable dt = new DataTable();
            dt = DBManager.getdata("SELECT * FROM `student_subject` WHERE st_roll_id = '" + frmLogin.passingRollId + "'");
            foreach (DataRow dr in dt.Rows)
            {
                DataTable dt1 = new DataTable();
                dt1 = DBManager.getdata("SELECT * FROM `subject` WHERE subject_id = '" + dr["subject_id"] + "'");
                foreach (DataRow dr1 in dt1.Rows)
                {
                    listLbl[i++].Text = dr1[2].ToString();
                    listLblReslt[j++].Text = dr1[2].ToString();
                    tempSubId.Add(dr1[0].ToString());
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

        private void pbMaths_Click(object sender, EventArgs e)
        {
            passSubId = tempSubId[0];
            BackGround.transparent(new frmGrade12TO13SubjectInsideDash());
        }

        private void pbEnglish_Click(object sender, EventArgs e)
        {
            passSubId = tempSubId[1];
            BackGround.transparent(new frmGrade12TO13SubjectInsideDash());
        }

        private void pbScience_Click(object sender, EventArgs e)
        {
            passSubId = tempSubId[2];
            BackGround.transparent(new frmGrade12TO13SubjectInsideDash());
        }
    }
}
