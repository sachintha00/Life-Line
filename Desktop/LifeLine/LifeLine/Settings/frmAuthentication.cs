using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDnotify;
using SMDValidation;

namespace LifeLine
{
    public partial class frmAuthentication : Form
    {
        public frmAuthentication()
        {
            InitializeComponent();
        }

        private void frmStudentAuthentication_Load(object sender, EventArgs e)
        {
            transitionLoad();
        }

        private async void transitionLoad()
        {
            grbOld.Visible = false;
            grbNew.Visible = false;

            await Task.Run(() =>
            {
                transAuthenticaion.ShowSync(grbOld);
                transAuthenticaion.ShowSync(grbNew);
            });
        }

        private void loginUpdate()
        {
            if (txtNewPassword.Text != txtCofirmPassword.Text)
                Validation.texBoxValidate(false, txtCofirmPassword, lblComPassword, "Dosen't match password");
            else
            {
                if (!string.IsNullOrEmpty(txtUsername.Text))
                {
                    switch (frmLogin.passingRollName)
                    {
                        case "Principal":
                            break;
                        case "Teacher":
                            break;
                        case "Academic":
                            string sqlcmd1 = "UPDATE other_staff_account SET username = '" + txtUsername.Text + "' WHERE staff_roll_id = '" + frmLogin.passingRollId + "'";
                            if (DBManager.insrtUpdteDelt(sqlcmd1) == 1)
                            {
                                Alert.Show("Success", "Change your Username", Alert.AlertType.success, Color.FromArgb(242, 243, 244));
                            }
                            enableTxt(false);
                            break;
                    }
                }
                if (!string.IsNullOrEmpty(txtCofirmPassword.Text) && !string.IsNullOrEmpty(txtNewPassword.Text))
                {
                    switch (frmLogin.passingRollName)
                    {
                        case "Principal":
                            break;
                        case "Teacher":
                            break;
                        case "Academic":
                            string sqlcmd1 = "UPDATE other_staff_account SET password = '" + txtCofirmPassword.Text + "' WHERE staff_roll_id = '" + frmLogin.passingRollId + "'";
                            if (DBManager.insrtUpdteDelt(sqlcmd1) == 1)
                            {
                                Alert.Show("Success", "Change your Password", Alert.AlertType.success, Color.FromArgb(242, 243, 244));
                            }
                            enableTxt(false);
                            break;
                    }
                }
            }
        }

        private void enableTxt(bool state)
        {
            txtUsername.Enabled = state;
            txtNewPassword.Enabled = state;
            txtCofirmPassword.Enabled = state;
        }
        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == DBManager.getValue("SELECT * FROM other_staff_account", frmLogin.passingRollId, 0, 14))
            {
                Validation.texBoxValidate(true, txtOldPassword, lblOldPw);
                enableTxt(true);
                txtUsername.Focus();
            }
            else if (txtOldPassword.Text == DBManager.getValue("SELECT * FROM student_account", frmLogin.passingRollId, 0, 14))
            {
                Validation.texBoxValidate(true, txtOldPassword, lblOldPw);
                enableTxt(true);
                txtUsername.Focus();
            }
            else if (txtOldPassword.Text == DBManager.getValue("SELECT * FROM teacher_account", frmLogin.passingRollId, 0, 15))
            {
                Validation.texBoxValidate(true, txtOldPassword, lblOldPw);
                enableTxt(true);
                txtUsername.Focus();
            }
            else
            {
                Validation.texBoxValidate(false, txtOldPassword, lblOldPw, "Password is incorrect");
                enableTxt(false);
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtNewPassword.Focus();
        }

        private void txtNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCofirmPassword.Focus();
        }

        private void txtCofirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loginUpdate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            loginUpdate();
        }

        private void txtCofirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtCofirmPassword.Text)
                Validation.texBoxValidate(false, txtCofirmPassword, lblComPassword, "Dosen't match password");
            else
                Validation.texBoxValidate(true, txtCofirmPassword, lblComPassword);
        }
    }
}
