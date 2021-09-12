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
    public partial class frmLoard : Form
    {
        public frmLoard()
        {
            InitializeComponent();  
        }

        public static void loardForm(Form frm)
        {
            frm.ShowDialog();
        }

        private void login()
        {
            switch (frmLogin.passingRollName)
            {
                case "Principal":
                    break;
                case "Teacher6-11":
                    this.Hide();
                    new frmGrade6TO11Teacher().Show();
                    break;
                case "Academic":
                    this.Hide();
                    new frmAcademicStaff().Show();
                    break;
                case "GRADE6-11":
                    this.Hide();
                    new frmGrade6TO11Student().Show();
                    break;
                case "GRADE12-13":
                    this.Hide();
                    new frmGrade12TO13Student().Show();
                    break;
            }
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            if (prgrssLoard.Value == 100)
            {
                timerLoading.Stop();
                login();
            }
            else
            {
                prgrssLoard.Value += 1;
                lblPercentage.Text = (Convert.ToInt32(lblPercentage.Text) + 1).ToString();
            }
        }

        private void frmLoard_Load(object sender, EventArgs e)
        {
            timerLoading.Start();
        }
    }
}
