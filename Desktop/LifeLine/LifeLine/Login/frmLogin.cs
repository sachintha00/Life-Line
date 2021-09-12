using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using SMDLogic;
using SMDMessageBox;

namespace LifeLine
{
    public partial class frmLogin : Form
    {
        public static string passingRollId;
        public static string passingRollName;
        public frmLogin()
        {
            InitializeComponent();
            shadow.SetShadowForm(this);
            txtUsername.Focus();

            if(Properties.Settings.Default.UserName != string.Empty)
            {
                txtUsername.Text = Properties.Settings.Default.UserName;
                txtPassword.Text = Properties.Settings.Default.Password;
                chkboxRemember.Checked = Properties.Settings.Default.check;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            animate.Start();
        }

        private void rememberMe()
        {
            if(chkboxRemember.Checked == true)
            {
                Properties.Settings.Default.UserName = txtUsername.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.check = chkboxRemember.Checked;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.check = chkboxRemember.Checked;
                Properties.Settings.Default.Save();
            }
        }

        private void login()
        {
            passingRollName = DBManager.ReadValue("SELECT * FROM other_staff_account WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' ", 1);
            passingRollId = DBManager.ReadValue("SELECT * FROM other_staff_account WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' ", 0);

            if (1 == DBManager.chek("SELECT * FROM other_staff_account WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' "))
            {
                passingRollName = DBManager.ReadValue("SELECT * FROM other_staff_account WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' ", 1);
                passingRollId = DBManager.ReadValue("SELECT * FROM other_staff_account WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' ", 0);
            }
            else if (1 == DBManager.chek("SELECT * FROM student_account WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' "))
            {
                passingRollName = DBManager.ReadValue("SELECT * FROM student_account WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' ", 1);
                passingRollId = DBManager.ReadValue("SELECT * FROM student_account WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' ", 0);
            }
            else if (1 == DBManager.chek("SELECT * FROM teacher_account WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' "))
            {
                passingRollName = DBManager.ReadValue("SELECT * FROM teacher_account WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' ", 1);
                passingRollId = DBManager.ReadValue("SELECT * FROM teacher_account WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' ", 0);
            }

            if (!(passingRollName == "Error"))
            {
                rememberMe();
                this.Hide();
                new frmLoard().Show();
            }
            else
                SMDMessage.show("Error", "Username or Password incorrect", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Error);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void btnShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '●';
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            //btnCreateAcc.Checked = true;
            //cntxtMnuCreateAccount.Show(btnCreateAcc, 1, btnCreateAcc.Height);
            BackGround.transparent(new frmCreateAccAcademicStaff());
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

        private void forPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCreateAcc.CheckedBaseColor = Color.Transparent;
            BackGround.transparent(new frmCreateAccPrincipal());
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                login();
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            refreshData();
        }

        private void refreshData()
        {
            if (1 == DBManager.chek("SELECT * FROM other_staff_account"))
            {
                refresh.Stop();
                btnCreateAcc.Visible = false;
            }
            
        }
    }
}
