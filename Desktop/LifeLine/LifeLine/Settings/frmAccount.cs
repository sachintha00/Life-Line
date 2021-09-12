using SMDgetNicDetails;
using SMDValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDnotify;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace LifeLine
{
    public partial class frmAccount : Form
    {
        private List<Panel> listPnl = new List<Panel>();
        private int index = 0;
        private bool flag = false;
        public frmAccount()
        {
            InitializeComponent();
            loadDetail();
        }

        private void loadDetail()
        {
            if (DBManager.chek("SELECT * FROM `other_staff_account` WHERE staff_roll_id = '" + frmLogin.passingRollId + "'") == 1)
            {
                DataTable dt = DBManager.getdata("SELECT * FROM `other_staff_account` WHERE staff_roll_id = '" + frmLogin.passingRollId + "'");
                foreach (DataRow dr in dt.Rows)
                {
                    txtStFirstName.Text = dr[2].ToString();
                    txtStMiddleName.Text = dr[3].ToString();
                    txtStSurName.Text = dr[4].ToString();
                    txtStAddress.Text = dr[11].ToString();
                    txtStCity.Text = dr[12].ToString();
                    txtStTp.Text = dr[10].ToString();
                    txtStMail.Text = dr[9].ToString();
                    txtStNic.Text = dr[5].ToString();

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
            else if (DBManager.chek("SELECT * FROM `student_account` WHERE st_roll_id = '" + frmLogin.passingRollId + "'") == 1)
            {
                DataTable dt = DBManager.getdata("SELECT * FROM `student_account` WHERE st_roll_id = '" + frmLogin.passingRollId + "'");
                foreach (DataRow dr in dt.Rows)
                {
                    txtStFirstName.Text = dr[3].ToString();
                    txtStMiddleName.Text = dr[4].ToString();
                    txtStSurName.Text = dr[5].ToString();
                    txtStAddress.Text = dr[12].ToString();
                    txtStCity.Text = dr[13].ToString();
                    txtStTp.Text = dr[11].ToString();
                    txtStMail.Text = dr[10].ToString();
                    txtStNic.Text = dr[7].ToString();

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
            else if (DBManager.chek("SELECT * FROM `teacher_account` WHERE teach_roll_id = '" + frmLogin.passingRollId + "'") == 1)
            {
                DataTable dt = DBManager.getdata("SELECT * FROM `teacher_account` WHERE teach_roll_id = '" + frmLogin.passingRollId + "'");
                foreach (DataRow dr in dt.Rows)
                {
                    txtStFirstName.Text = dr[2].ToString();
                    txtStMiddleName.Text = dr[3].ToString();
                    txtStSurName.Text = dr[4].ToString();
                    txtStAddress.Text = dr[12].ToString();
                    txtStCity.Text = dr[13].ToString();
                    txtStTp.Text = dr[11].ToString();
                    txtStMail.Text = dr[10].ToString();
                    txtStNic.Text = dr[5].ToString();

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

        private void frmStudentAccount_Load(object sender, EventArgs e)
        {
            listPnl.Add(pnlStudentInfo1);
            listPnl.Add(pnlStudentInfo2);
            listPnl[index].BringToFront();

            pbProfile.Visible = false;
            lblDetailsTopic.Visible = false;
            pnlContact.Visible = false;
            pnlStudentInfo1.Visible = false;
            pnlStudentInfo2.Visible = false;

            trnsAccount.ShowSync(pbProfile);
            trnsAccount.ShowSync(pnlContact);
            trnsAccount.ShowSync(lblDetailsTopic);
            trnsAccount.ShowSync(pnlStudentInfo1);
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            btnImageSave.Visible = false;
            btnImageSave.BringToFront();
            trnsEditSave.ShowSync(btnImageSave);
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Image";
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                flag = true;
                pbProfile.Image = new Bitmap(ofd.FileName);
                pbProfile.ImageLocation = ofd.FileName.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                listPnl[--index].BringToFront();
                btnNext.BringToFront();
                pnlStudentInfo1.Visible = false;
                btnNext.Visible = false;
                trnsDetailPanel.HideSync(pnlStudentInfo2);
                trnsDetailPanel.ShowSync(pnlStudentInfo1);
                trnsBackNext.ShowSync(btnNext);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index < listPnl.Count - 1)
            {
                listPnl[++index].BringToFront();
                btnBack.BringToFront();
                pnlStudentInfo2.Visible = false;
                btnBack.Visible = false;
                trnsDetailPanel.HideSync(pnlStudentInfo1);
                trnsDetailPanel.ShowSync(pnlStudentInfo2);
                trnsBackNext.ShowSync(btnBack);
            }
        }

        private void btnFnameEdit_Click(object sender, EventArgs e)
        {
            btnFnameSave.Visible = false;
            txtStFirstName.Enabled = true;
            txtStFirstName.Focus();
            btnFnameSave.BringToFront();
            trnsEditSave.ShowSync(btnFnameSave);
        }

        private void btnMnameEdit_Click(object sender, EventArgs e)
        {
            btnMnameSave.Visible = false;
            txtStMiddleName.Enabled = true;
            txtStMiddleName.Focus();
            btnMnameSave.BringToFront();
            trnsEditSave.ShowSync(btnMnameSave);
        }

        private void btnSnameEdit_Click(object sender, EventArgs e)
        {
            btnSnameSave.Visible = false;
            txtStSurName.Enabled = true;
            txtStSurName.Focus();
            btnSnameSave.BringToFront();
            trnsEditSave.ShowSync(btnSnameSave);
        }

        private void btnNicEdit_Click(object sender, EventArgs e)
        {
            btnNicSave.Visible = false;
            txtStNic.Enabled = true;
            txtStNic.Focus();
            btnNicSave.BringToFront();
            trnsEditSave.ShowSync(btnNicSave);
        }

        private void btnGmailEdit_Click(object sender, EventArgs e)
        {
            btnGmailSave.Visible = false;
            txtStMail.Enabled = true;
            txtStMail.Focus();
            btnGmailSave.BringToFront();
            trnsEditSave.ShowSync(btnGmailSave);
        }

        private void btnMobileEdit_Click(object sender, EventArgs e)
        {
            btnMobileSave.Visible = false;
            txtStTp.Enabled = true;
            txtStTp.Focus();
            btnMobileSave.BringToFront();
            trnsEditSave.ShowSync(btnMobileSave);
        }

        private void btnAddressEdit_Click(object sender, EventArgs e)
        {
            btnAddressSave.Visible = false;
            txtStAddress.Enabled = true;
            txtStAddress.Focus();
            btnAddressSave.BringToFront();
            trnsEditSave.ShowSync(btnAddressSave);
        }

        private void btnCityEdit_Click(object sender, EventArgs e)
        {
            btnCitySave.Visible = false;
            txtStCity.Enabled = true;
            txtStCity.Focus();
            btnCitySave.BringToFront();
            trnsEditSave.ShowSync(btnCitySave);
        }

        private void txtStFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtStFirstName, lblStFname, "Space are not allowed");
            else if (e.Handled = (char.IsDigit(e.KeyChar)))
                Validation.texBoxValidate(false, txtStFirstName, lblStFname, "Numbers are not allowed");
            else
                Validation.texBoxValidate(true, txtStFirstName, lblStFname);
        }

        private void txtStFirstName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStFirstName.Text))
                Validation.texBoxValidate(false, txtStFirstName, lblStFname, "Cannot be empty...");
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

        private void txtStSurName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStSurName.Text))
                Validation.texBoxValidate(false, txtStSurName, lblStSurname, "Cannot be empty...");
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

        private void txtStNic_TextChanged(object sender, EventArgs e)
        {
            if (!NicValidation.validate(txtStNic))
                Validation.texBoxValidate(false, txtStNic, lblStNic, "Cannot match");
            else
            {
                Validation.texBoxValidate(true, txtStNic, lblStNic);
            }
        }

        private void txtStMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtStMail, lblStGmail, "Space are not allowed");
            else
                Validation.texBoxValidate(true, txtStMail, lblStGmail);
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

        private void txtStTp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtStTp, lblStTpnumber, "Space are not allowed");
            else if (e.Handled = (char.IsLetter(e.KeyChar)))
                Validation.texBoxValidate(false, txtStTp, lblStTpnumber, "Letters are not allowed");
            else
                Validation.texBoxValidate(true, txtStTp, lblStTpnumber);
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

        private void txtStAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
                Validation.texBoxValidate(false, txtStAddress, lblStAddress, "Space are not allowed");
            else
                Validation.texBoxValidate(true, txtStAddress, lblStAddress);
        }

        private void txtStAddress_TextChanged(object sender, EventArgs e)
        {

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

        private void btnGmailSave_Click(object sender, EventArgs e)
        {
            int status = 0;
            if (frmLogin.passingRollName == "GRADE6-11" || frmLogin.passingRollName == "GRADE12-13")
                status = DBManager.insrtUpdteDelt("UPDATE `student_account` SET gmail='"+txtStMail.Text+"' WHERE st_roll_id = '" + frmLogin.passingRollId + "'");
            else if (frmLogin.passingRollName == "Teacher6-11" || frmLogin.passingRollName == "Teacher12-13")
                status = DBManager.insrtUpdteDelt("UPDATE `teacher_account` SET gmail='" + txtStMail.Text + "' WHERE teach_roll_id = '" + frmLogin.passingRollId + "'");
            else
                status = DBManager.insrtUpdteDelt("UPDATE `other_staff_account` SET gmail='" + txtStMail.Text + "' WHERE staff_roll_id = '" + frmLogin.passingRollId + "'");

            if (status==1)
            {
                Alert.Show("Update Details","Update Successfull....",Alert.AlertType.success, Color.FromArgb(242, 243, 244));
                btnGmailSave.Visible = false;
                txtStMail.Enabled = false;
                btnGmailEdit.BringToFront();
                trnsEditSave.ShowSync(btnGmailEdit);
            }
        }

        private void btnMobileSave_Click(object sender, EventArgs e)
        {
            int status = 0;
            if (frmLogin.passingRollName == "GRADE6-11" || frmLogin.passingRollName == "GRADE12-13")
                status = DBManager.insrtUpdteDelt("UPDATE `student_account` SET tp_number='" + txtStTp.Text + "' WHERE st_roll_id = '" + frmLogin.passingRollId + "'");
            else if (frmLogin.passingRollName == "Teacher6-11" || frmLogin.passingRollName == "Teacher12-13")
                status = DBManager.insrtUpdteDelt("UPDATE `teacher_account` SET teach_tp_number='" + txtStTp.Text + "' WHERE teach_roll_id = '" + frmLogin.passingRollId + "'");
            else
                status = DBManager.insrtUpdteDelt("UPDATE `other_staff_account` SET tp_number='" + txtStTp.Text + "' WHERE staff_roll_id = '" + frmLogin.passingRollId + "'");

            if (status == 1)
            {
                Alert.Show("Update Details", "Update Successfull....", Alert.AlertType.success, Color.FromArgb(242, 243, 244));
                btnMobileSave.Visible = false;
                txtStTp.Enabled = false;
                btnMobileEdit.BringToFront();
                trnsEditSave.ShowSync(btnMobileEdit);
            }
        }

        private void btnFnameSave_Click(object sender, EventArgs e)
        {
            int status = 0;
            if (frmLogin.passingRollName == "GRADE6-11" || frmLogin.passingRollName == "GRADE12-13")
                status = DBManager.insrtUpdteDelt("UPDATE `student_account` SET st_first_name='" + txtStFirstName.Text + "' WHERE st_roll_id = '" + frmLogin.passingRollId + "'");
            else if (frmLogin.passingRollName == "Teacher6-11" || frmLogin.passingRollName == "Teacher12-13")
                status = DBManager.insrtUpdteDelt("UPDATE `teacher_account` SET teach_first_name='" + txtStFirstName.Text + "' WHERE teach_roll_id = '" + frmLogin.passingRollId + "'");
            else
                status = DBManager.insrtUpdteDelt("UPDATE `other_staff_account` SET first_name='" + txtStFirstName.Text + "' WHERE staff_roll_id = '" + frmLogin.passingRollId + "'");

            if (status == 1)
            {
                Alert.Show("Update Details", "Update Successfull....", Alert.AlertType.success, Color.FromArgb(242, 243, 244));
                btnFnameSave.Visible = false;
                txtStFirstName.Enabled = false;
                btnFnameEdit.BringToFront();
                trnsEditSave.ShowSync(btnFnameEdit);
            }
        }

        private void btnSnameSave_Click(object sender, EventArgs e)
        {
            int status = 0;
            if (frmLogin.passingRollName == "GRADE6-11" || frmLogin.passingRollName == "GRADE12-13")
                status = DBManager.insrtUpdteDelt("UPDATE `student_account` SET st_surname='" + txtStSurName.Text + "' WHERE st_roll_id = '" + frmLogin.passingRollId + "'");
            else if (frmLogin.passingRollName == "Teacher6-11" || frmLogin.passingRollName == "Teacher12-13")
                status = DBManager.insrtUpdteDelt("UPDATE `teacher_account` SET teach_surname='" + txtStSurName.Text + "' WHERE teach_roll_id = '" + frmLogin.passingRollId + "'");
            else
                status = DBManager.insrtUpdteDelt("UPDATE `other_staff_account` SET surname='" + txtStSurName.Text + "' WHERE staff_roll_id = '" + frmLogin.passingRollId + "'");

            if (status == 1)
            {
                Alert.Show("Update Details", "Update Successfull....", Alert.AlertType.success, Color.FromArgb(242, 243, 244));
                btnSnameSave.Visible = false;
                txtStSurName.Enabled = false;
                btnSnameEdit.BringToFront();
                trnsEditSave.ShowSync(btnSnameEdit);
            }
        }

        private void btnNicSave_Click(object sender, EventArgs e)
        {
            int status = 0;
            if (frmLogin.passingRollName == "GRADE6-11" || frmLogin.passingRollName == "GRADE12-13")
                status = DBManager.insrtUpdteDelt("UPDATE `student_account` SET st_nic='" + txtStNic.Text + "' WHERE st_roll_id = '" + frmLogin.passingRollId + "'");
            else if (frmLogin.passingRollName == "Teacher6-11" || frmLogin.passingRollName == "Teacher12-13")
                status = DBManager.insrtUpdteDelt("UPDATE `teacher_account` SET teach_nic='" + txtStNic.Text + "' WHERE teach_roll_id = '" + frmLogin.passingRollId + "'");
            else
                status = DBManager.insrtUpdteDelt("UPDATE `other_staff_account` SET nic='" + txtStNic.Text + "' WHERE staff_roll_id = '" + frmLogin.passingRollId + "'");

            if (status == 1)
            {
                Alert.Show("Update Details", "Update Successfull....", Alert.AlertType.success, Color.FromArgb(242, 243, 244));
                btnNicSave.Visible = false;
                txtStNic.Enabled = false;
                btnNicEdit.BringToFront();
                trnsEditSave.ShowSync(btnNicEdit);
            }
        }

        private void btnMnameSave_Click(object sender, EventArgs e)
        {
            int status = 0;
            if (frmLogin.passingRollName == "GRADE6-11" || frmLogin.passingRollName == "GRADE12-13")
                status = DBManager.insrtUpdteDelt("UPDATE `student_account` SET st_middle_name='" + txtStMiddleName.Text + "' WHERE st_roll_id = '" + frmLogin.passingRollId + "'");
            else if (frmLogin.passingRollName == "Teacher6-11" || frmLogin.passingRollName == "Teacher12-13")
                status = DBManager.insrtUpdteDelt("UPDATE `teacher_account` SET teach_middle_name='" + txtStMiddleName.Text + "' WHERE teach_roll_id = '" + frmLogin.passingRollId + "'");
            else
                status = DBManager.insrtUpdteDelt("UPDATE `other_staff_account` SET middle_name='" + txtStMiddleName.Text + "' WHERE staff_roll_id = '" + frmLogin.passingRollId + "'");

            if (status == 1)
            {
                Alert.Show("Update Details", "Update Successfull....", Alert.AlertType.success, Color.FromArgb(242, 243, 244));
                btnMnameSave.Visible = false;
                txtStMiddleName.Enabled = false;
                btnMnameEdit.BringToFront();
                trnsEditSave.ShowSync(btnMnameEdit);
            }
        }

        private void btnAddressSave_Click(object sender, EventArgs e)
        {
            int status = 0;
            if (frmLogin.passingRollName == "GRADE6-11" || frmLogin.passingRollName == "GRADE12-13")
                status = DBManager.insrtUpdteDelt("UPDATE `student_account` SET address='" + txtStAddress.Text + "' WHERE st_roll_id = '" + frmLogin.passingRollId + "'");
            else if (frmLogin.passingRollName == "Teacher6-11" || frmLogin.passingRollName == "Teacher12-13")
                status = DBManager.insrtUpdteDelt("UPDATE `teacher_account` SET address='" + txtStAddress.Text + "' WHERE teach_roll_id = '" + frmLogin.passingRollId + "'");
            else
                status = DBManager.insrtUpdteDelt("UPDATE `other_staff_account` SET address='" + txtStAddress.Text + "' WHERE staff_roll_id = '" + frmLogin.passingRollId + "'");

            if (status == 1)
            {
                Alert.Show("Update Details", "Update Successfull....", Alert.AlertType.success, Color.FromArgb(242, 243, 244));
                btnAddressSave.Visible = false;
                txtStAddress.Enabled = false;
                btnAddressEdit.BringToFront();
                trnsEditSave.ShowSync(btnAddressEdit);
            }
        }

        private void btnImageSave_Click(object sender, EventArgs e)
        {
            byte[] image = null;
            int status = 0;
            if (flag)
            {

                FileStream fstream = new FileStream(pbProfile.ImageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                image = br.ReadBytes((int)fstream.Length);
            }
            else
                image = null;

            if (frmLogin.passingRollName == "GRADE6-11" || frmLogin.passingRollName == "GRADE12-13")
                status = DBManager.insrtUpdteDelt("UPDATE `student_account` SET profile_image=@image WHERE st_roll_id = '" + frmLogin.passingRollId + "'", "@image", image);
            else if (frmLogin.passingRollName == "Teacher6-11" || frmLogin.passingRollName == "Teacher12-13")
                status = DBManager.insrtUpdteDelt("UPDATE `teacher_account` SET profile_image=@image WHERE teach_roll_id = '" + frmLogin.passingRollId + "'", "@image", image);
            else
                status = DBManager.insrtUpdteDelt("UPDATE `other_staff_account` SET profile_image=@image WHERE staff_roll_id = '" + frmLogin.passingRollId + "'", "@image", image);

            if (status == 1)
            {
                Alert.Show("Update Details", "Profile pic Update Successfull....", Alert.AlertType.success, Color.FromArgb(242, 243, 244));
                btnImageSave.Visible = false;
                btnImage.BringToFront();
                trnsEditSave.ShowSync(btnImage);
            }
        }
    }
}
