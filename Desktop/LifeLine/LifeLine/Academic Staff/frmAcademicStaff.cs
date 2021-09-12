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
using LifeLine.QR;
using SMDLogic;

namespace LifeLine
{
    public partial class frmAcademicStaff : Form
    {
        public frmAcademicStaff()
        {
            InitializeComponent();
            loadDetail();
            Shadow.SetShadowForm(this);

            SMDChildFormOpen.Open(new frmAcademicStaffDash(), pnlChildForm, Color.FromArgb(251, 251, 250));

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        private void loadDetail()
        {
            if (DBManager.chek("SELECT * FROM `other_staff_account` WHERE staff_roll_id = '" + frmLogin.passingRollId + "'") == 1)
            {
                DataTable dt = DBManager.getdata("SELECT * FROM `other_staff_account` WHERE staff_roll_id = '" + frmLogin.passingRollId + "'");
                foreach (DataRow dr in dt.Rows)
                {
                    lblName.Text = dr[2].ToString()+" "+ dr[3].ToString();

                    string image = Convert.ToString(dr[15]);
                    if (image == "System.Byte[]")
                    {
                        MemoryStream mstream = new MemoryStream((byte[])dr[15]);
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

        }

        private void btnSubject2_Click(object sender, EventArgs e)
        {
            //SMDChildFormOpen.Open(new frmGrade6TO11StudentSubjects(), pnlChildForm, Color.FromArgb(251, 251, 250));
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmAcademicStaffDash(), pnlChildForm, Color.FromArgb(251, 251, 250));
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmAcademicStaffAccounts(), pnlChildForm, Color.FromArgb(251, 251, 250));
        }

        private void lnkAttendance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmQRcamSelection().Show();
        }
    }
}
