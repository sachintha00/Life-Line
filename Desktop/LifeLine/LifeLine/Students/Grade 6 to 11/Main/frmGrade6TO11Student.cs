using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LifeLine.Classes;
using SMDLogic;
using SMDnotify;

namespace LifeLine
{
    public partial class frmGrade6TO11Student : Form
    {
        public frmGrade6TO11Student()
        {
            InitializeComponent();
            Shadow.SetShadowForm(this);
            loadDetail();
            subjectInsert();

            SMDChildFormOpen.Open(new frmGrade6TO11StudentDash(), pnlChildForm, Color.FromArgb(251, 251, 250));

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        private void displayMsg()
        {
            //Thread.Sleep(10000);
            if (frmBasketSubject.statusBasket)
                Alert.Show("Added Subjects", "Your basket subjects are added succesfull", Alert.AlertType.info, Color.FromArgb(242, 243, 244));
        }

        private void subjectInsert()
        {
            if(DBManager.chek("SELECT * FROM `student_subject` WHERE st_roll_id = '" + frmLogin.passingRollId + "'") == 0)
            {
                InsertSubject isObj = new InsertSubject(frmLogin.passingRollId);
                BackGround.transparent(new frmBasketSubject());
            }
        }

        private void loadDetail()
        {
            if (DBManager.chek("SELECT * FROM `student_account` WHERE st_roll_id = '" + frmLogin.passingRollId + "'") == 1)
            {
                DataTable dt = DBManager.getdata("SELECT * FROM `student_account` WHERE st_roll_id = '" + frmLogin.passingRollId + "'");
                foreach (DataRow dr in dt.Rows)
                {
                    lblName.Text = dr[3].ToString()+" "+ dr[4].ToString();

                    string image = Convert.ToString(dr[16]);
                    if (image == "System.Byte[]")
                    {
                        MemoryStream mstream = new MemoryStream((byte[])dr[16]);
                        try
                        {
                            pbProfile.Image = new Bitmap(mstream);
                        }
                        catch (ArgumentException)
                        {
                            pbProfile.Image = null;
                        }
                    }
                    else
                        pbProfile.Image = null;
                }
            }
        }

        private void frmGrade6Student_Load(object sender, EventArgs e)
        {
            //displayMsg();
        }

        private void btnSubject2_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmGrade6TO11StudentSubjects(), pnlChildForm, Color.FromArgb(251, 251, 250));
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmGrade6TO11StudentDash(), pnlChildForm, Color.FromArgb(251, 251, 250));
        }

        private void btnStSetting_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            BackGround.transparent(new frmSettings());
        }

        private void btnSlider2_Click(object sender, EventArgs e)
        {
            //logoHide();
            //btnslider2Hide(); 
            //transition();
        }

        private void btnSlider_Click_1(object sender, EventArgs e)
        {
            //btnsliderHide();
            //transition();
        }

        private void pnlSlider_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
