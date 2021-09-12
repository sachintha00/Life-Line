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
    public partial class frmBasketSubject : Form
    {
        public static bool statusBasket;
        private List<Panel> listPnl = new List<Panel>();
        string[] basketSub = new string[3];
        int index = 0;
        public frmBasketSubject()
        {
            InitializeComponent();
            addDataTOcombobx();
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
            listPnl.Add(pnl1st);
            listPnl.Add(pnl2nd);
            listPnl.Add(pnl3rd);
            listPnl[index].BringToFront();
            animateSetting.SetAnimateWindow(this);
        }

        private void nextForm(Guna2Panel pnl, Guna2Panel pnl2)
        {
            if (index < listPnl.Count - 1)
            {
                pnl.Visible = false;
                listPnl[++index].BringToFront();
                trnsStudent.HideSync(pnl2);
                trnsStudent.ShowSync(pnl);
            }
        }

        private void addDataTOcombobx()
        {
            DataTable dt1 = new DataTable();
            dt1 = DBManager.getdata("SELECT * FROM `subject` WHERE subject_roll = 'BASKET1(O/L)'");

            foreach (DataRow dr in dt1.Rows)
            {
                cmb1stBasket.Items.Add(dr["subject"].ToString());
            }

            DataTable dt2 = new DataTable();
            dt2 = DBManager.getdata("SELECT * FROM `subject` WHERE subject_roll = 'BASKET2(O/L)'");

            foreach (DataRow dr in dt2.Rows)
            {
                cmb2ndBasket.Items.Add(dr["subject"].ToString());
            }

            DataTable dt3 = new DataTable();
            dt3 = DBManager.getdata("SELECT * FROM `subject` WHERE subject_roll = 'BASKET3(O/L)'");

            foreach (DataRow dr in dt3.Rows)
            {
                cmb3rdBasket.Items.Add(dr["subject"].ToString());
            }
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            nextForm(pnl2nd, pnl1st);
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            nextForm(pnl3rd, pnl2nd);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < basketSub.Length; i++)
                DBManager.insrtUpdteDelt("INSERT INTO `student_subject`(`subject_id`, `st_roll_id`) VALUES ('"+basketSub[i]+"','"+frmLogin.passingRollId+"')");
            SMDMessage.show("Added Subjects", "Your basket subjects are added succesfull",SMDMessageBoxButtons.OK,SMDMessageBoxIcon.Information);
            this.Close();
        }

        private void cmb1stBasket_SelectedIndexChanged(object sender, EventArgs e)
        {
            basketSub[0] = DBManager.getValue("SELECT * FROM `subject` WHERE subject = '"+cmb1stBasket.SelectedItem.ToString()+"'", "BASKET1(O/L)",1,0);
        }

        private void cmb2ndBasket_SelectedIndexChanged(object sender, EventArgs e)
        {
            basketSub[1] = DBManager.getValue("SELECT * FROM `subject` WHERE subject = '" + cmb2ndBasket.SelectedItem.ToString() + "'", "BASKET2(O/L)", 1, 0);
        }

        private void cmb3rdBasket_SelectedIndexChanged(object sender, EventArgs e)
        {
            basketSub[2] = DBManager.getValue("SELECT * FROM `subject` WHERE subject = '" + cmb3rdBasket.SelectedItem.ToString() + "'", "BASKET3(O/L)", 1, 0);
        }
    }
}
