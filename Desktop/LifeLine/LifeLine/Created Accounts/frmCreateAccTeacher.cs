using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDValidation;
using SMDgetNicDetails;
using SMDMessageBox;
using SMDRandomPassword;
using Guna.UI.WinForms;
using MySql.Data.MySqlClient;
using LifeLine.Classes;
using SMDnotify;

namespace LifeLine
{
    public partial class frmCreateAccTeacher : Form
    {
        private List<Panel> listPnl = new List<Panel>();
        private int index=0;
        private string password;
        private string rollName, rollId, username;
        public frmCreateAccTeacher()
        {
            InitializeComponent();
            comboSubject();
        }

        private void comboSubject()
        {
            DataTable dt = new DataTable();
            dt = DBManager.getdata("SELECT * FROM subject");

            foreach (DataRow dr in dt.Rows)
            {
                cmbTeachSubject.Items.Add(dr["subject"].ToString());
            }
        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            animate.Start();
            listPnl.Add(pnlTeacherInfo);
            listPnl.Add(pnlTeacherOther);
            listPnl[index].BringToFront();

            trnsLoad.ShowSync(pnlTeacherInfo);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTeachFirstName.Text) && string.IsNullOrEmpty(txtTeachSurName.Text) && string.IsNullOrEmpty(txtTeachNic.Text) && string.IsNullOrEmpty(txtTeachGovId.Text) && (cmbTeachSubject.SelectedIndex == -1))
            {
                Validation.comboValidate(false, cmbTeachSubject, lblTeachSubject, "Select your Subject");
                Validation.texBoxValidate(false, txtTeachGovId, lblTeachGovId, "Cannot be empty...");
                Validation.texBoxValidate(false, txtTeachNic, lblTeachNic, "Cannot be empty...");
                Validation.texBoxValidate(false, txtTeachSurName, lblTeachSurname, "Cannot be empty...");
                Validation.texBoxValidate(false, txtTeachFirstName, lblTeachFname, "Cannot be empty...");
            }
            else if(string.IsNullOrEmpty(txtTeachFirstName.Text))
                Validation.texBoxValidate(false, txtTeachFirstName,lblTeachFname, "Cannot be empty...");
            else if (string.IsNullOrEmpty(txtTeachSurName.Text))
                Validation.texBoxValidate(false, txtTeachSurName, lblTeachSurname, "Cannot be empty...");
            else if (string.IsNullOrEmpty(txtTeachNic.Text))
                Validation.texBoxValidate(false, txtTeachNic, lblTeachNic, "Cannot be empty...");
            else if (string.IsNullOrEmpty(txtTeachGovId.Text))
                Validation.texBoxValidate(false, txtTeachGovId, lblTeachGovId, "Cannot be empty...");
            else if (!NicValidation.validate(txtTeachNic))
                Validation.texBoxValidate(false, txtTeachNic, lblTeachNic, "Cannot match..");
            else if ((cmbTeachSubject.SelectedIndex == -1))
                Validation.comboValidate(false, cmbTeachSubject, lblTeachSubject, "Select your Subject");
            else    
                nextForm(pnlTeacherOther, pnlTeacherInfo);
        }

        private void nextForm(GunaElipsePanel pnl, GunaElipsePanel pnl2)
        {
            if (index < listPnl.Count - 1)
            {
                pnl.Visible = false;
                listPnl[++index].BringToFront();
                trnsTeacher.HideSync(pnl2);
                trnsTeacher.ShowSync(pnl);
                btnBack.Visible = true;
                btnBack.BringToFront();
            }
            if (index == 1)
                btnSkip.Visible = true;
            if (index != 1)
                btnSkip.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            listPnl[--index].BringToFront();
            trnsTeacher.HideSync(pnlTeacherOther);
            trnsTeacher.ShowSync(pnlTeacherInfo);
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {

        }

        private void txtGuardianFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void wait_Tick(object sender, EventArgs e)
        {

        }

        private void txtStCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtTeachMail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                Validation.texBoxValidate(false, txtTeachMail, lblStGmail, "Cannot match EX: example@mail.xyz");
            else if (!Regex.IsMatch(txtTeachTp.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                Validation.texBoxValidate(false, txtTeachTp, lblStTpnumber, "Cannot match EX: 07X XXXX XXX");
            else
            {
                rollId = Invoice.generate("T", DBManager.lastRecord("SELECT MAX(teach_roll_id) FROM teacher_account"));
                rollName = "Teacher" + TeacherRollFind.TeacherRoll(cmbTeachSubject.SelectedItem.ToString());
                password = RandomPassword.generate(8);
                username = txtTeachFirstName.Text.Substring(0, 3) + RandomPassword.generate(2);
                while (username == DBManager.ReadValue("SELECT * FROM ACCOUNT WHERE username = '" + username + "' ", 6))
                    username = txtTeachFirstName.Text.Substring(0, 3) + RandomPassword.generate(2);

                int i = DBManager.insrtUpdteDelt("INSERT INTO `teacher_account`(`teach_roll_id`, `teach_roll_name`, `teach_first_name`, `teach_middle_name`, `teach_surname`, `teach_nic`, `teach_birthday`, `teach_gender`, `teach_gov_index`, `teach_subject`, `gmail`, `teach_tp_number`, `address`, `teach_city`, `username`, `password`) VALUES ('" + rollId + "','" + rollName + "','" + txtTeachFirstName.Text + "','" + txtTeachMiddleName.Text + "','" + txtTeachSurName.Text + "','" + txtTeachNic.Text + "','" + txtTeachDof.Text + "','" + txtTeachGender.Text + "','" + txtTeachGovId.Text + "','" + cmbTeachSubject.SelectedItem.ToString() + "','" + txtTeachMail.Text + "','" + txtTeachTp.Text + "','" + txtTeachAddress.Text + "','" + txtTeachCity.Text + "','" + username + "','" + password + "')");
                if (i == 1)
                {
                    SMDMessage.show("Authentication Details", "Username: " + username + "\nPassword: " + password, SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Information);
                    this.Close();
                    Alert.Show("Success", "Add a member for the academic staff", Alert.AlertType.success, Color.FromArgb(242, 243, 244));
                }
                else
                    MessageBox.Show("error");
            }
        }

        private void txtTeachFirstName_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTeachFirstName.Text))
                Validation.texBoxValidate(false, txtTeachFirstName, lblTeachFname, "Cannot be empty...");
            else
                Validation.texBoxValidate(true, txtTeachFirstName, lblTeachFname);
        }

        private void txtTeachMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTeachSurName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTeachSurName.Text))
                Validation.texBoxValidate(false, txtTeachSurName, lblTeachSurname, "Cannot be empty...");
            else
                Validation.texBoxValidate(true, txtTeachSurName, lblTeachSurname);
        }

        private void txtTeachNic_TextChanged(object sender, EventArgs e)
        {
            GetNicDetails nic = new GetNicDetails(txtTeachNic.Text);
            if (!NicValidation.validate(txtTeachNic))
                Validation.texBoxValidate(false, txtTeachNic, lblTeachNic, "Cannot match");
            else if(nic.Age < 23)
            {
                SMDMessage.show("ERROR","Cannot login this system..",SMDMessageBoxButtons.OK,SMDMessageBoxIcon.Error);
            }
            else
            {               
                txtTeachDof.Text = nic.BirthDay;
                txtTeachGender.Text = nic.Gender;
                Validation.texBoxValidate(true, txtTeachNic, lblTeachNic);
            }        
        }

        private void txtTeachFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtTeachFirstName, lblTeachFname, "Space are not allowed");
            else if(e.Handled = (char.IsDigit(e.KeyChar)))
                Validation.texBoxValidate(false, txtTeachFirstName, lblTeachFname, "Numbers are not allowed");
            else
                Validation.texBoxValidate(true, txtTeachFirstName, lblTeachFname);
        }

        private void txtTeachMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtTeachMiddleName, lblTeachMname, "Space are not allowed");
            else if (e.Handled = (char.IsDigit(e.KeyChar)))
                Validation.texBoxValidate(false, txtTeachMiddleName, lblTeachMname, "Numbers are not allowed");
            else
                Validation.texBoxValidate(true, txtTeachMiddleName, lblTeachMname);
        }

        private void txtTeachSurName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtTeachSurName, lblTeachSurname, "Space are not allowed");
            else if (e.Handled = (char.IsDigit(e.KeyChar)))
                Validation.texBoxValidate(false, txtTeachSurName, lblTeachSurname, "Numbers are not allowed");
            else
                Validation.texBoxValidate(true, txtTeachSurName, lblTeachSurname);
        }

        private void txtTeachNic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtTeachNic, lblTeachNic, "Space are not allowed");
            else
                Validation.texBoxValidate(true, txtTeachNic, lblTeachNic);
        }

        private void txtTeachTp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtTeachTp, lblStTpnumber, "Space are not allowed");
            else if (e.Handled = (char.IsLetter(e.KeyChar)))
                Validation.texBoxValidate(false, txtTeachTp, lblStTpnumber, "Letters are not allowed");
            else
                Validation.texBoxValidate(true, txtTeachTp, lblStTpnumber);
        }

        private void txtTeachMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtTeachMail, lblStGmail, "Space are not allowed");
            else
                Validation.texBoxValidate(true, txtTeachMail, lblStGmail);
        }

        private void txtTeachAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtTeachAddress, lblStAddress, "Space are not allowed");
            else
                Validation.texBoxValidate(true, txtTeachAddress, lblStAddress);
        }

        private void txtTeachCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtTeachCity, lblStCity, "Space are not allowed");
            else if (e.Handled = (char.IsDigit(e.KeyChar)))
                Validation.texBoxValidate(false, txtTeachCity, lblStCity, "Numbers are not allowed");
            else
                Validation.texBoxValidate(true, txtTeachCity, lblStCity);
        }

        private void txtTeachMail_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtTeachMail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                Validation.texBoxValidate(false, txtTeachMail, lblStGmail, "Cannot match EX: example@mail.xyz");
            }
            else
            {
                Validation.texBoxValidate(true, txtTeachMail, lblStGmail);
            }
        }

        private void txtTeachTp_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtTeachTp.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                Validation.texBoxValidate(false, txtTeachTp, lblStTpnumber, "Cannot match EX: 07X XXXX XXX");
            }
            else
            {
                Validation.texBoxValidate(true, txtTeachTp, lblStTpnumber);
            }
        }

        private void txtTeachAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTeachGovId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtTeachGovId, lblTeachGovId, "Space are not allowed");
            else
                Validation.texBoxValidate(true, txtTeachGovId, lblTeachGovId);
        }

        private void txtTeachGovId_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTeachGovId.Text))
                Validation.texBoxValidate(false, txtTeachGovId, lblTeachGovId, "Cannot be empty...");
            else
                Validation.texBoxValidate(true, txtTeachGovId, lblTeachGovId);
        }

        private void cmbTeachSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbTeachSubject.SelectedIndex == -1))
                Validation.comboValidate(false, cmbTeachSubject, lblTeachSubject, "Select your Subject");
            else
                Validation.comboValidate(true, cmbTeachSubject, lblTeachSubject);
        }
    }
}
