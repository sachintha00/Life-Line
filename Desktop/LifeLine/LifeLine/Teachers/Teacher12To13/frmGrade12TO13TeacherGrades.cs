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
    public partial class frmGrade12TO13TeacherGrades : Form
    {
        public static string passGrd;
        public frmGrade12TO13TeacherGrades()
        {
            InitializeComponent();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        //private async void transitionLoad()
        //{
        //    pnlAttend.Visible = false;
        //    pnlRank.Visible = false;
        //    pnlProgressTopic.Visible = false;
        //    pnlprogress.Visible = false;
        //    dgvArchievement.Visible = false;
        //    dgvStEvents.Visible = false;

        //    await Task.Run(() =>
        //    {
        //        trnsLoad.ShowSync(grpTimeTbl);
        //        trnsLoad.ShowSync(pnlRank);
        //        trnsLoad.ShowSync(pnlProgressTopic);
        //        trnsLoad.ShowSync(pnlprogress);
        //        trnsLoad.ShowSync(dgvArchievement);
        //        trnsLoad.ShowSync(dgvStEvents);
        //    });
        //}

        private void frmGrade6StudentSubjects_Load(object sender, EventArgs e)
        {
            //transitionLoad();
        }

        private void guna2ShadowPanel1_Click(object sender, EventArgs e)
        {
            passGrd = "Grade6";
            BackGround.transparent(new frmGradeInside());
        }

        private void guna2ShadowPanel2_Click(object sender, EventArgs e)
        {
            passGrd = "Grade7";
            BackGround.transparent(new frmGradeInside());
        }

        private void guna2ShadowPanel3_Click(object sender, EventArgs e)
        {
            passGrd = "Grade8";
            BackGround.transparent(new frmGradeInside());
        }

        private void guna2ShadowPanel4_Click(object sender, EventArgs e)
        {
            passGrd = "Grade9";
            BackGround.transparent(new frmGradeInside());
        }

        private void guna2ShadowPanel5_Click(object sender, EventArgs e)
        {
            passGrd = "Grade10";
            BackGround.transparent(new frmGradeInside());
        }

        private void guna2ShadowPanel6_Click(object sender, EventArgs e)
        {
            passGrd = "Grade11";
            BackGround.transparent(new frmGradeInside());
        }
    }
}
