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
    public partial class frmAcademicStaffAccounts : Form
    {
        public frmAcademicStaffAccounts()
        {
            InitializeComponent();
            showStData();
            showTeachData();
            cmbDesignation.SelectedIndex = 0;
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

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            btnCreateAcc.Checked = true;
            cntxtMnuCreateAccount.Show(btnCreateAcc, 1, btnCreateAcc.Height);
        }

        private void btnCreateAcc_MouseEnter(object sender, EventArgs e)
        {
            btnCreateAcc.Checked = false;
        }

        private void forPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCreateAcc.CheckedBaseColor = Color.Transparent;
            BackGround.transparent(new frmCreateAccPrincipal());
        }

        private void forStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCreateAcc.CheckedBaseColor = Color.Transparent;
            BackGround.transparent(new frmCreateAccStudent());
        }

        private void forTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCreateAcc.CheckedBaseColor = Color.Transparent;
            BackGround.transparent(new frmCreateAccTeacher());
        }

        private void cmbDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDesignation.SelectedIndex == 0)
            {
                dgvStudent.Visible = false;
                dgvTeacher.Visible = true;
                showTeachData();
            }
            else
            {
                dgvTeacher.Visible = false;
                dgvStudent.Visible = true;
                showStData();
            }
        }

        private void showStData()
        {
            DataTable dt = new DataTable();
            dt = DBManager.getdata("SELECT * FROM `student_account`");
            dgvStudent.AutoGenerateColumns = false;
            dgvStudent.DataSource = dt;
        }

        private void showTeachData()
        {
            DataTable dt = new DataTable();
            dt = DBManager.getdata("SELECT * FROM `teacher_account`");
            dgvTeacher.AutoGenerateColumns = false;
            dgvTeacher.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(cmbDesignation.SelectedIndex == 0)
            {
                DataTable dt = new DataTable();
                dt = DBManager.getdata("SELECT * FROM `teacher_account` WHERE teach_roll_id LIKE '" + txtSearch.Text + "%' OR teach_nic LIKE '" + txtSearch.Text + "%' OR teach_gender LIKE '" + txtSearch.Text + "%' OR teach_subject LIKE '" + txtSearch.Text + "%'");
                dgvTeacher.DataSource = dt;
            }
            else
            {
                DataTable dt = new DataTable();
                dt = DBManager.getdata("SELECT * FROM `student_account` WHERE st_roll_id LIKE '" + txtSearch.Text + "%' OR st_Grade LIKE '" + txtSearch.Text + "%' OR st_gender LIKE '" + txtSearch.Text + "%' OR city LIKE '" + txtSearch.Text + "%'");
                dgvStudent.DataSource = dt;
            }
        }
    }
}
