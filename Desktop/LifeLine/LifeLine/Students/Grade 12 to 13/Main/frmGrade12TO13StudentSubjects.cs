using Guna.UI.WinForms;
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
    public partial class frmGrade12TO13StudentSubjects : Form
    {
        public static string passSubId;
        private List<GunaLabel> listLbl = new List<GunaLabel>();
        private List<string> tempSubId = new List<string>();
        public frmGrade12TO13StudentSubjects()
        {
            InitializeComponent();
            listLbl.Add(lblGroup1);
            listLbl.Add(lblGroup2);
            listLbl.Add(lblGroup3);

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
            int i = 0;
            DataTable dt = new DataTable();
            dt = DBManager.getdata("SELECT * FROM `student_subject` WHERE st_roll_id = '" + frmLogin.passingRollId + "'");
            foreach (DataRow dr in dt.Rows)
            {
                DataTable dt1 = new DataTable();
                dt1 = DBManager.getdata("SELECT * FROM `subject` WHERE subject_id = '" + dr["subject_id"] + "'");
                foreach (DataRow dr1 in dt1.Rows)
                {
                    listLbl[i++].Text = dr1[2].ToString();
                    tempSubId.Add(dr1[0].ToString());
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

        private void pbMaths_Click(object sender, EventArgs e)
        {
            passSubId = tempSubId[0];
            BackGround.transparent(new frmGrade12TO13SubjectInside());
        }

        private void pbEnglish_Click(object sender, EventArgs e)
        {
            passSubId = tempSubId[1];
            BackGround.transparent(new frmGrade12TO13SubjectInside());
        }

        private void pbScience_Click(object sender, EventArgs e)
        {
            passSubId = tempSubId[2];
            BackGround.transparent(new frmGrade12TO13SubjectInside());
        }
    }
}
