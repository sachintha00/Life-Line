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
using Guna.UI.WinForms;
using SMDnotify;
using System.Dynamic;
using LifeLine.Classes;
using SMDRandomPassword;
using SMDMessageBox;
using Zen.Barcode;
using System.Drawing.Printing;
using LifeLine.QR;
using Microsoft.VisualBasic.ApplicationServices;
using SMDLogic;

namespace LifeLine
{
    public partial class frmCreateAccStudent : Form
    {
        List<Panel> listPnl = new List<Panel>();
        int index=0;
        private string password;
        private string rollName, username,stdof,rollIdGuardian,stGrade;
        public static string rollId;
        private int age;
        public frmCreateAccStudent()
        {
            InitializeComponent();
            dtpStDOF.Value = DateTime.Now;
        }
        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            listPnl.Add(pnlStudentInfomation);
            listPnl.Add(pnlStudentOthers);
            listPnl.Add(pnlGuardian);
            listPnl[index].BringToFront();

            trnsLoad.ShowSync(pnlStudentInfomation);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtStFirstName.Text) && string.IsNullOrEmpty(txtStSurName.Text) && (DateTime.Today <=dtpStDOF.Value) && (cmbStGender.SelectedIndex==-1))
            {
                Validation.comboValidate(false, cmbStGender, lblStGender, "Select your gender");
                Validation.DateTimeValidate(false, dtpStDOF, lblStDof, "Select the date of birth...");
                Validation.texBoxValidate(false, txtStSurName, lblStSurname, "Cannot be empty...");
                Validation.texBoxValidate(false, txtStFirstName, lblStFname, "Cannot be empty...");
            }
            else if(string.IsNullOrEmpty(txtStFirstName.Text))
                Validation.texBoxValidate(false, txtStFirstName,lblStFname, "Cannot be empty...");
            else if (string.IsNullOrEmpty(txtStSurName.Text))
                Validation.texBoxValidate(false, txtStSurName, lblStSurname, "Cannot be empty...");
            else if (!NicValidation.validate(txtStNic))
                Validation.texBoxValidate(false, txtStNic, lblStNic, "Cannot match..");
            else if((DateTime.Now <= dtpStDOF.Value))
                Validation.DateTimeValidate(false, dtpStDOF, lblStDof, "Select the date of birth...");
            else if((cmbStGender.SelectedIndex == -1))
                Validation.comboValidate(false, cmbStGender, lblStGender, "Select your gender");
            else if ((Convert.ToInt64(DateTime.Now.Year - dtpStDOF.Value.Year) < 6))
                Validation.DateTimeValidate(false, dtpStDOF, lblStDof, "Sorry!! cannot sign up this system");
            else
                nextForm(pnlStudentOthers,pnlStudentInfomation);
        }

        private void nextForm(GunaElipsePanel pnl, GunaElipsePanel pnl2)
        {
            if(index < listPnl.Count - 1)
            {
                pnl.Visible = false;
                listPnl[++index].BringToFront();
                trnsStudent.HideSync(pnl2);
                trnsStudent.ShowSync(pnl);
                btnBack2.Visible = true;               
                btnBack.Visible = true;   
            }
            if (index == 1)
                btnSkip.Visible = true;
            if (index != 1)
                btnSkip.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            listPnl[--index].BringToFront();
            trnsStudent.HideSync(pnlGuardian);
            trnsStudent.ShowSync(pnlStudentOthers);
            btnBack.BringToFront();
            btnSkip.Visible = true;
            btnBack2.Visible = true;
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            listPnl[++index].BringToFront();
            if (index != 1)
            {
                pnlGuardian.Visible = false;
                trnsStudent.HideSync(pnlStudentOthers);
                trnsStudent.ShowSync(pnlGuardian);
                btnSkip.Visible = false;
                btnBack.BringToFront();
            }
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
            if (!Regex.IsMatch(txtStMail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                Validation.texBoxValidate(false, txtStMail, lblStGmail, "Cannot match EX: example@mail.xyz");
            else if (!Regex.IsMatch(txtStTp.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                Validation.texBoxValidate(false, txtStTp, lblStTpnumber, "Cannot match EX: 07X XXXX XXX");
            else
            {
                rollId = Invoice.generate("S", DBManager.lastRecord("SELECT MAX(st_roll_id) FROM student_account"));
                rollName = StudentRollFind.studentRoll(age);
                stGrade = StudentRollFind.studentGrade(age);
                password = RandomPassword.generate(8);
                username = txtStFirstName.Text.Substring(0, 3) + RandomPassword.generate(2);
                while (username == DBManager.ReadValue("SELECT * FROM ACCOUNT WHERE username = '" + username + "' ", 6))
                    username = txtStFirstName.Text.Substring(0, 3) + RandomPassword.generate(2);
                MessageBox.Show(stGrade);
                int i = DBManager.insrtUpdteDelt("INSERT INTO `student_account`(`st_roll_id`, `st_roll_name`, `st_Grade`, `st_first_name`, `st_middle_name`, `st_surname`, `st_birthday`, `st_nic`, `st_gender`, `st_siblings_details`, `gmail`, `tp_number`, `address`, `city`, `username`, `password`) VALUES ('" + rollId + "','" + rollName + "','" + stGrade + "','" + txtStFirstName.Text + "','" + txtStMiddleName.Text + "','" + txtStSurName.Text + "','" + stdof + "','" + txtStNic.Text + "','" + cmbStGender.SelectedItem.ToString() + "','" + txtStSiblings.Text + "','" + txtStMail.Text + "','" + txtStTp.Text + "','" + txtStAddress.Text + "','" + txtStCity.Text + "','" + username + "','" + password + "')");
                if (i == 1)
                    nextForm(pnlGuardian, pnlStudentOthers);
                else
                    SMDMessage.show("Error","Data not added",SMDMessageBoxButtons.OK,SMDMessageBoxIcon.Error);
            }
        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGuardianFname.Text) && string.IsNullOrEmpty(txtGuardianSname.Text) && string.IsNullOrEmpty(txtGuardianNic.Text) && (cmbRelation.SelectedIndex == -1) && string.IsNullOrEmpty(txtGuardianMobile.Text) && string.IsNullOrEmpty(txtGuardianEmail.Text))
            {
                Validation.texBoxValidate(false, txtGuardianEmail, lblGuardianEmail, "Cannot be empty...");
                Validation.texBoxValidate(false, txtGuardianMobile, lblGuardianMobile, "Cannot be empty...");
                Validation.comboValidate(false, cmbRelation, lblRelation, "Select Relation");
                Validation.texBoxValidate(false, txtGuardianNic, lblGuardianNic, "Cannot be empty...");
                Validation.texBoxValidate(false, txtGuardianSname, lblGuardianSname, "Cannot be empty...");
                Validation.texBoxValidate(false, txtGuardianFname, lblGuardianFname, "Cannot be empty...");
            }
            else if (string.IsNullOrEmpty(txtGuardianFname.Text))
                Validation.texBoxValidate(false, txtGuardianFname, lblGuardianFname, "Cannot be empty...");
            else if (string.IsNullOrEmpty(txtGuardianSname.Text))
                Validation.texBoxValidate(false, txtGuardianSname, lblGuardianSname, "Cannot be empty...");
            else if (string.IsNullOrEmpty(txtGuardianNic.Text))
                Validation.texBoxValidate(false, txtGuardianNic, lblGuardianNic, "Cannot be empty...");
            else if (cmbRelation.SelectedIndex == -1)
                Validation.comboValidate(false, cmbRelation, lblRelation, "Select Relation");
            else if (string.IsNullOrEmpty(txtGuardianMobile.Text))
                Validation.texBoxValidate(false, txtGuardianMobile, lblGuardianMobile, "Cannot be empty...");
            else if (string.IsNullOrEmpty(txtGuardianEmail.Text))
                Validation.texBoxValidate(false, txtGuardianEmail, lblGuardianEmail, "Cannot be empty...");
            else if (!NicValidation.validate(txtGuardianNic))
                Validation.texBoxValidate(false, txtGuardianNic, lblGuardianNic, "Cannot match..");
            else if (!Regex.IsMatch(txtGuardianEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                Validation.texBoxValidate(false, txtGuardianEmail, lblGuardianEmail, "Cannot match EX: example@gmail.xyz");
            else if (!Regex.IsMatch(txtGuardianMobile.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                Validation.texBoxValidate(false, txtGuardianMobile, lblGuardianMobile, "Cannot match EX: 07X XXXX XXX");
            else
            {
                GetNicDetails nic = new GetNicDetails(txtGuardianNic.Text);
                rollIdGuardian = Invoice.generate("G", DBManager.lastRecord("SELECT MAX(Guard_id) FROM student_guardian"));
                int i = DBManager.insrtUpdteDelt("INSERT INTO `student_guardian`(`Guard_id`, `st_roll_id`, `first_name`, `middle_name`, `surname`, `nic`, `birthday`, `gender`, `tp_number`, `gmail`) VALUES ('"+rollIdGuardian+"','"+rollId+"','"+txtGuardianFname.Text+"','"+txtGuardianMname.Text+"','"+txtGuardianSname.Text+ "','"+txtGuardianNic.Text+"','" + nic.BirthDay + "','"+ nic.Gender + "','"+txtGuardianMobile.Text+"','"+txtGuardianEmail.Text+"')");

                if(i==1)
                {
                    BackGround.transparent(new frmQRdesign());
                    this.Close();
                }
            }
        }

        private void dtpStDOF_ValueChanged(object sender, EventArgs e)
        {
            if ((Convert.ToInt64(DateTime.Now.Year - dtpStDOF.Value.Year) < 11))
                Validation.DateTimeValidate(false, dtpStDOF, lblStDof, "Sorry!! cannot sign up this system");
            else
            {
                Validation.DateTimeValidate(true, dtpStDOF, lblStDof);
                stdof = dtpStDOF.Value.Day.ToString() + "/" + dtpStDOF.Value.Month.ToString() + "/" + dtpStDOF.Value.Year.ToString();
                age = DateTime.Now.Year - dtpStDOF.Value.Year;
            }             
        }

        private void txtStFirstName_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtStFirstName.Text))
                Validation.texBoxValidate(false, txtStFirstName, lblStFname, "Cannot be empty...");
            else
                Validation.texBoxValidate(true, txtStFirstName, lblStFname);
        }

        private void txtStMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStSurName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStSurName.Text))
                Validation.texBoxValidate(false, txtStSurName, lblStSurname, "Cannot be empty...");
            else
                Validation.texBoxValidate(true, txtStSurName, lblStSurname);
        }

        private void cmbStGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStGender.SelectedIndex == -1)
                Validation.comboValidate(false, cmbStGender, lblStGender, "Select your gender");
            else
                Validation.comboValidate(true, cmbStGender, lblStGender);
        }

        private void txtStNic_TextChanged(object sender, EventArgs e)
        {
            if (!NicValidation.validate(txtStNic))
                Validation.texBoxValidate(false, txtStNic, lblStNic, "Cannot match");
            else
            {
                GetNicDetails nic = new GetNicDetails(txtStNic.Text);
                if ((nic.Year != dtpStDOF.Value.Year.ToString()) || (nic.MonthInNumber != dtpStDOF.Value.Month) || (nic.Day != dtpStDOF.Value.Day))
                {
                    try { dtpStDOF.Value = Convert.ToDateTime(nic.MonthInNumber + "/" + nic.Day + "/" + nic.Year); }
                    catch (FormatException) { }
                }
                if ((cmbStGender.SelectedIndex == -1) || (nic.Gender != cmbStGender.SelectedText))
                {
                    if(nic.Gender == "Male"){ cmbStGender.SelectedIndex = 0; }
                    else{ cmbStGender.SelectedIndex = 1; }
                    cmbStGender.Enabled = false;
                    dtpStDOF.Enabled = false;
                }
                Validation.texBoxValidate(true, txtStNic, lblStNic);
            }        
        }

        private void txtStSiblings_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtStFirstName, lblStFname, "Space are not allowed");
            else if(e.Handled = (char.IsDigit(e.KeyChar)))
                Validation.texBoxValidate(false, txtStFirstName, lblStFname, "Numbers are not allowed");
            else
                Validation.texBoxValidate(true, txtStFirstName, lblStFname);
        }

        private void txtStMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtStMiddleName, lblStMname, "Space are not allowed");
            else if (e.Handled = (char.IsDigit(e.KeyChar)))
                Validation.texBoxValidate(false, txtStMiddleName, lblStMname, "Numbers are not allowed");
            else
                Validation.texBoxValidate(true, txtStMiddleName, lblStMname);
        }

        private void txtStSurName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtStSurName, lblStSurname, "Space are not allowed");
            else if (e.Handled = (char.IsDigit(e.KeyChar)))
                Validation.texBoxValidate(false, txtStSurName, lblStSurname, "Numbers are not allowed");
            else
                Validation.texBoxValidate(true, txtStSurName, lblStSurname);
        }

        private void txtStNic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtStNic, lblStNic, "Space are not allowed");
            else
                Validation.texBoxValidate(true, txtStNic, lblStNic);
        }

        private void txtStSiblings_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtStSiblings, lblStSiblings, "Space are not allowed");
            else
                Validation.texBoxValidate(true, txtStSiblings, lblStSiblings);
        }

        private void txtStTp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtStTp, lblStTpnumber, "Space are not allowed");
            else if (e.Handled = (char.IsLetter(e.KeyChar)))
                Validation.texBoxValidate(false, txtStTp, lblStTpnumber, "Letters are not allowed");
            else
                Validation.texBoxValidate(true, txtStTp, lblStTpnumber);
        }

        private void txtStMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtStMail, lblStGmail, "Space are not allowed");
            else
                Validation.texBoxValidate(true, txtStMail, lblStGmail);
        }

        private void txtStAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtStAddress, lblStAddress, "Space are not allowed");
            else
                Validation.texBoxValidate(true, txtStAddress, lblStAddress);
        }

        private void txtStCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtStCity, lblStCity, "Space are not allowed");
            else if (e.Handled = (char.IsDigit(e.KeyChar)))
                Validation.texBoxValidate(false, txtStCity, lblStCity, "Numbers are not allowed");
            else
                Validation.texBoxValidate(true, txtStCity, lblStCity);
        }

        private void txtStMail_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtStMail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                Validation.texBoxValidate(false, txtStMail, lblStGmail, "Cannot match EX: example@mail.xyz");
            }
            else
            {
                Validation.texBoxValidate(true, txtStMail, lblStGmail);
            }
        }

        private void txtStTp_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtStTp.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                Validation.texBoxValidate(false, txtStTp, lblStTpnumber, "Cannot match EX: 07X XXXX XXX");
            }
            else
            {
                Validation.texBoxValidate(true, txtStTp, lblStTpnumber);
            }
        }

        private void txtStAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGuardianFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtGuardianFname, lblGuardianFname, "Space are not allowed");
            else if (e.Handled = (char.IsDigit(e.KeyChar)))
                Validation.texBoxValidate(false, txtGuardianFname, lblGuardianFname, "Numbers are not allowed");
            else
                Validation.texBoxValidate(true, txtGuardianFname, lblGuardianFname);
        }

        private void txtGuardianMname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtGuardianMname, lblGuardianMname, "Space are not allowed");
            else if (e.Handled = (char.IsDigit(e.KeyChar)))
                Validation.texBoxValidate(false, txtGuardianMname, lblGuardianMname, "Numbers are not allowed");
            else
                Validation.texBoxValidate(true, txtGuardianMname, lblGuardianMname);
        }

        private void txtGuardianSname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtGuardianSname, lblGuardianSname, "Space are not allowed");
            else if (e.Handled = (char.IsDigit(e.KeyChar)))
                Validation.texBoxValidate(false, txtGuardianSname, lblGuardianSname, "Numbers are not allowed");
            else
                Validation.texBoxValidate(true, txtGuardianSname, lblGuardianSname);
        }

        private void txtGuardianNic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtGuardianNic, lblGuardianNic, "Space are not allowed");
            else
                Validation.texBoxValidate(true, txtGuardianNic, lblGuardianNic);
        }

        private void txtGuardianMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtGuardianMobile, lblGuardianMobile, "Space are not allowed");
            else if (e.Handled = (char.IsLetter(e.KeyChar)))
                Validation.texBoxValidate(false, txtGuardianMobile, lblGuardianMobile, "Letters are not allowed");
            else
                Validation.texBoxValidate(true, txtGuardianMobile, lblGuardianMobile);
        }

        private void txtGuardianEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtGuardianEmail, lblGuardianEmail, "Space are not allowed");
            else
                Validation.texBoxValidate(true, txtGuardianEmail, lblGuardianEmail);
        }

        private void cmbRelation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStGender.SelectedIndex == -1)
                Validation.comboValidate(false, cmbRelation, lblRelation, "Select Relation..");
            else
                Validation.comboValidate(true, cmbRelation, lblRelation);
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtGuardianMobile_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtGuardianMobile.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                Validation.texBoxValidate(false, txtGuardianMobile, lblGuardianMobile, "Cannot match EX: 07X XXXX XXX");
            }
            else
            {
                Validation.texBoxValidate(true, txtGuardianMobile, lblGuardianMobile);
            }
        }

        private void txtGuardianEmail_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtGuardianEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                Validation.texBoxValidate(false, txtGuardianEmail, lblGuardianEmail, "Cannot match EX: example@mail.xyz");
            }
            else
            {
                Validation.texBoxValidate(true, txtGuardianEmail, lblGuardianEmail);
            }
        }

        private void txtGuardianNic_TextChanged(object sender, EventArgs e)
        {
            if (!NicValidation.validate(txtGuardianNic))
                Validation.texBoxValidate(false, txtGuardianNic, lblGuardianNic, "Cannot match");
            else
                Validation.texBoxValidate(true, txtGuardianNic, lblGuardianNic);
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            if (index == 1)
            {
                listPnl[--index].BringToFront();
                trnsStudent.HideSync(pnlStudentOthers);
                trnsStudent.ShowSync(pnlStudentInfomation);
                btnBack.BringToFront();
                btnBack2.Visible = true;
                btnSkip.Visible = true;
            }
        }
    }
}
