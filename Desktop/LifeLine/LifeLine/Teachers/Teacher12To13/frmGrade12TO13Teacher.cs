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
    public partial class frmGrade12TO13Teacher : Form
    {
        public frmGrade12TO13Teacher()
        {
            InitializeComponent();
            Shadow.SetShadowForm(this);
            loadDetail();

            //SMDChildFormOpen.Open(new frmGrade6TO11TeacherDash(), pnlChildForm, Color.FromArgb(251, 251, 250));

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        private void loadDetail()
        {
            if (DBManager.chek("SELECT * FROM `teacher_account` WHERE teach_roll_id = '" + frmLogin.passingRollId + "'") == 1)
            {
                DataTable dt = DBManager.getdata("SELECT * FROM `teacher_account` WHERE teach_roll_id  = '" + frmLogin.passingRollId + "'");
                foreach (DataRow dr in dt.Rows)
                {
                    lblName.Text = dr[2].ToString()+" "+ dr[3].ToString();

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
            SMDChildFormOpen.Open(new frmGrade6TO11TeacherGrades(), pnlChildForm, Color.FromArgb(251, 251, 250));
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmGrade6TO11TeacherDash(), pnlChildForm, Color.FromArgb(251, 251, 250));
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
