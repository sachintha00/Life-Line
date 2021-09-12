using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDLogic;
using SMDnotify;
using MySql.Data.MySqlClient;
using MySql.Data;
using ZXing;
using Guna.UI2.WinForms;
using System.Threading;
using SMDMessageBox;

namespace LifeLine
{
    public partial class frmALselectionSubject : Form
    {
        public static bool statusBasket;
        public frmALselectionSubject()
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
        //    pnlSubjects.Visible = false;
        //    pnlAttend.Visible = false;
        //    pnlRank.Visible = false;
        //    pnlProgressTopic.Visible = false;
        //    pnlprogress.Visible = false;
        //    dgvArchievement.Visible = false;
        //    dgvStEvents.Visible = false;

        //    await Task.Run(() =>
        //    {
        //        trnsLoad.ShowSync(pnlSubjects);
        //        trnsLoad.ShowSync(pnlAttend);
        //        trnsLoad.ShowSync(pnlRank);
        //        trnsLoad.ShowSync(pnlProgressTopic);
        //        trnsLoad.ShowSync(pnlprogress);
        //        trnsLoad.ShowSync(dgvArchievement);
        //        trnsLoad.ShowSync(dgvStEvents);
        //    });
        //}

        private void frmGrade6Maths_Load(object sender, EventArgs e)
        {
            animateSetting.SetAnimateWindow(this);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (chckArts.Checked == false && chckBio.Checked == false && chckCommerce.Checked == false && chckMaths.Checked == false && chckTech.Checked == false)
                SMDMessage.show("Not selected","Please select your subject",SMDMessageBoxButtons.OK,SMDMessageBoxIcon.Error);
            else
            {
                if (chckArts.Checked == true)
                    subSelectAL("ARTS");
                else if (chckBio.Checked == true)
                    subSelectAL("BIO");
                else if (chckCommerce.Checked == true)
                    subSelectAL("COMMERCE");
                else if (chckMaths.Checked == true)
                    subSelectAL("MATHS");
                else if (chckTech.Checked == true)
                    subSelectAL("TECH");

                SMDMessage.show("Added Subjects", "Your basket subjects are added succesfull", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Information);
                this.Close();
            }
        }

        private void subSelectAL(string sub)
        {
            DataTable dt = new DataTable();
            dt = DBManager.getdata("SELECT * FROM SUBJECT WHERE subject_roll LIKE '"+sub+"%'");
            foreach (DataRow dr in dt.Rows)
            {
                DBManager.insrtUpdteDelt("INSERT INTO `student_subject`(`subject_id`, `st_roll_id`) VALUES ('" + dr[0] + "','" + frmLogin.passingRollId + "')");
            }
        }
    }
}
