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
using LifeLine.Classes;
using SMDnotify;

namespace LifeLine
{
    public partial class frmCreateAccAcademicStaff : Form
    {
        private List<Panel> listPnl = new List<Panel>();
        private int index=0;
        private string password;
        private string rollName,rollId,username;
        public frmCreateAccAcademicStaff()
        {
            InitializeComponent();
        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            animate.Start();
            listPnl.Add(pnlPrincipalInfo);
            listPnl.Add(pnlPrincipalOther);
            listPnl[index].BringToFront();

            trnsLoad.ShowSync(pnlPrincipalInfo);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtPrincipalFirstName.Text) && string.IsNullOrEmpty(txtPrincipalSurName.Text) && string.IsNullOrEmpty(txtPrincipalNic.Text) && string.IsNullOrEmpty(txtPrincipalGovId.Text))
            {
                Validation.texBoxValidate(false, txtPrincipalGovId, lblPrincipalSurname, "Cannot be empty...");
                Validation.texBoxValidate(false, txtPrincipalNic, lblPrincipalNic, "Cannot be empty...");
                Validation.texBoxValidate(false, txtPrincipalSurName, lblPrincipalSurname, "Cannot be empty...");
                Validation.texBoxValidate(false, txtPrincipalFirstName, lblPrincipalFname, "Cannot be empty...");
            }
            else if(string.IsNullOrEmpty(txtPrincipalFirstName.Text))
                Validation.texBoxValidate(false, txtPrincipalFirstName,lblPrincipalFname, "Cannot be empty...");
            else if (string.IsNullOrEmpty(txtPrincipalSurName.Text))
                Validation.texBoxValidate(false, txtPrincipalSurName, lblPrincipalSurname, "Cannot be empty...");
            else if (string.IsNullOrEmpty(txtPrincipalNic.Text))
                Validation.texBoxValidate(false, txtPrincipalNic, lblPrincipalNic, "Cannot be empty...");
            else if (string.IsNullOrEmpty(txtPrincipalGovId.Text))
                Validation.texBoxValidate(false, txtPrincipalGovId, lblPrincipalGovId, "Cannot be empty...");
            else if (!NicValidation.validate(txtPrincipalNic))
                Validation.texBoxValidate(false, txtPrincipalNic, lblPrincipalNic, "Cannot match..");
            else
                nextForm(pnlPrincipalOther, pnlPrincipalInfo);
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
            trnsTeacher.HideSync(pnlPrincipalOther);
            trnsTeacher.ShowSync(pnlPrincipalInfo);
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
            if (!Regex.IsMatch(txtPrincipalMail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                Validation.texBoxValidate(false, txtPrincipalMail, lblPrincipalGmail, "Cannot match EX: example@mail.xyz");
            else if (!Regex.IsMatch(txtPrincipalTp.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                Validation.texBoxValidate(false, txtPrincipalTp, lblPrincipalTpnumber, "Cannot match EX: 07X XXXX XXX");
            else
            {
                rollId = Invoice.generate("A", DBManager.lastRecord("SELECT MAX(staff_roll_id) FROM other_staff_account"));
                rollName = "Academic";               
                password = RandomPassword.generate(8);
                username = txtPrincipalFirstName.Text.Substring(0, 3) + RandomPassword.generate(2);
                while(username == DBManager.ReadValue("SELECT * FROM ACCOUNT WHERE username = '" + username + "' ", 6))
                    username = txtPrincipalFirstName.Text.Substring(0, 3) + RandomPassword.generate(2);

                int i = DBManager.insrtUpdteDelt("INSERT INTO `other_staff_account`(`staff_roll_id`, `staff_roll_name`, `first_name`, `middle_name`, `surname`, `nic`, `birthday`, `gender`, `gov_index`, `gmail`, `tp_number`, `address`, `city`, `username`, `password`) VALUES ('"+ rollId + "','"+ rollName + "','"+txtPrincipalFirstName.Text+ "','" + txtPrincipalMiddleName.Text + "','" + txtPrincipalSurName.Text + "','" + txtPrincipalNic.Text + "','" + txtPrincipalDof.Text + "','" + txtPrincipalGender.Text + "','" + txtPrincipalGovId.Text + "','" + txtPrincipalMail.Text + "','" + txtPrincipalTp.Text + "','" + txtPrincipalAddress.Text + "','" + txtPrincipalCity.Text + "','" + username + "','" + password + "')");
                if(i == 1)
                {
                    SMDMessage.show("Authentication Details","Username: "+username+"\nPassword: "+password,SMDMessageBoxButtons.OK,SMDMessageBoxIcon.Information);
                    this.Close();
                    Alert.Show("Success","Add a member for the academic staff",Alert.AlertType.success,Color.FromArgb(242, 243, 244));
                }
            }
        }

        private void txtTeachFirstName_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtPrincipalFirstName.Text))
                Validation.texBoxValidate(false, txtPrincipalFirstName, lblPrincipalFname, "Cannot be empty...");
            else
                Validation.texBoxValidate(true, txtPrincipalFirstName, lblPrincipalFname);
        }

        private void txtTeachMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTeachSurName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrincipalSurName.Text))
                Validation.texBoxValidate(false, txtPrincipalSurName, lblPrincipalSurname, "Cannot be empty...");
            else
                Validation.texBoxValidate(true, txtPrincipalSurName, lblPrincipalSurname);
        }

        private void txtTeachNic_TextChanged(object sender, EventArgs e)
        {
            GetNicDetails nic = new GetNicDetails(txtPrincipalNic.Text);
            if (!NicValidation.validate(txtPrincipalNic))
                Validation.texBoxValidate(false, txtPrincipalNic, lblPrincipalNic, "Cannot match");
            else if(nic.Age < 23)
            {
                SMDMessage.show("ERROR","Cannot login this system..",SMDMessageBoxButtons.OK,SMDMessageBoxIcon.Error);
            }
            else
            {               
                txtPrincipalDof.Text = nic.BirthDay;
                txtPrincipalGender.Text = nic.Gender;
                Validation.texBoxValidate(true, txtPrincipalNic, lblPrincipalNic);
            }        
        }

        private void txtTeachFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtPrincipalFirstName, lblPrincipalFname, "Space are not allowed");
            else if(e.Handled = (char.IsDigit(e.KeyChar)))
                Validation.texBoxValidate(false, txtPrincipalFirstName, lblPrincipalFname, "Numbers are not allowed");
            else
                Validation.texBoxValidate(true, txtPrincipalFirstName, lblPrincipalFname);
        }

        private void txtTeachMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtPrincipalMiddleName, lblPrincipalMname, "Space are not allowed");
            else if (e.Handled = (char.IsDigit(e.KeyChar)))
                Validation.texBoxValidate(false, txtPrincipalMiddleName, lblPrincipalMname, "Numbers are not allowed");
            else
                Validation.texBoxValidate(true, txtPrincipalMiddleName, lblPrincipalMname);
        }

        private void txtTeachSurName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtPrincipalSurName, lblPrincipalSurname, "Space are not allowed");
            else if (e.Handled = (char.IsDigit(e.KeyChar)))
                Validation.texBoxValidate(false, txtPrincipalSurName, lblPrincipalSurname, "Numbers are not allowed");
            else
                Validation.texBoxValidate(true, txtPrincipalSurName, lblPrincipalSurname);
        }

        private void txtTeachNic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtPrincipalNic, lblPrincipalNic, "Space are not allowed");
            else
                Validation.texBoxValidate(true, txtPrincipalNic, lblPrincipalNic);
        }

        private void txtTeachTp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtPrincipalTp, lblPrincipalTpnumber, "Space are not allowed");
            else if (e.Handled = (char.IsLetter(e.KeyChar)))
                Validation.texBoxValidate(false, txtPrincipalTp, lblPrincipalTpnumber, "Letters are not allowed");
            else
                Validation.texBoxValidate(true, txtPrincipalTp, lblPrincipalTpnumber);
        }

        private void txtTeachMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtPrincipalMail, lblPrincipalGmail, "Space are not allowed");
            else
                Validation.texBoxValidate(true, txtPrincipalMail, lblPrincipalGmail);
        }

        private void txtTeachAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtPrincipalAddress, lblPrincipalAddress, "Space are not allowed");
            else
                Validation.texBoxValidate(true, txtPrincipalAddress, lblPrincipalAddress);
        }

        private void txtTeachCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtPrincipalCity, lblPrincipalCity, "Space are not allowed");
            else if (e.Handled = (char.IsDigit(e.KeyChar)))
                Validation.texBoxValidate(false, txtPrincipalCity, lblPrincipalCity, "Numbers are not allowed");
            else
                Validation.texBoxValidate(true, txtPrincipalCity, lblPrincipalCity);
        }

        private void txtTeachMail_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtPrincipalMail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                Validation.texBoxValidate(false, txtPrincipalMail, lblPrincipalGmail, "Cannot match EX: example@mail.xyz");
            }
            else
            {
                Validation.texBoxValidate(true, txtPrincipalMail, lblPrincipalGmail);
            }
        }

        private void txtTeachTp_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtPrincipalTp.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                Validation.texBoxValidate(false, txtPrincipalTp, lblPrincipalTpnumber, "Cannot match EX: 07X XXXX XXX");
            }
            else
            {
                Validation.texBoxValidate(true, txtPrincipalTp, lblPrincipalTpnumber);
            }
        }

        private void txtTeachAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTeachGovId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtPrincipalGovId, lblPrincipalGovId, "Space are not allowed");
            else
                Validation.texBoxValidate(true, txtPrincipalGovId, lblPrincipalGovId);
        }

        private void txtTeachGovId_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrincipalGovId.Text))
                Validation.texBoxValidate(false, txtPrincipalGovId, lblPrincipalGovId, "Cannot be empty...");
            else
                Validation.texBoxValidate(true, txtPrincipalGovId, lblPrincipalGovId);
        }
    }
}
