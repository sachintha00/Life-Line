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
using SMDLogic;
using SMDnotify;
using MySql.Data.MySqlClient;
using MySql.Data;
using ZXing;
using System.Windows.Forms.VisualStyles;

namespace LifeLine
{
    public partial class frmGradeInside : Form
    {
        public frmGradeInside()
        {
            InitializeComponent();
            showData();
        }
        private string subIdFinder()
        {
            string Subject = DBManager.getValue("SELECT * FROM `teacher_account`", frmLogin.passingRollId, 0, 9);
            return DBManager.getValue("SELECT * FROM `subject`", Subject, 2, 0);
        }

        private string fileNameFinder(string filePath)
        {
            FileInfo fi = new FileInfo(filePath);
            return fi.Name;
        }
        private void showData()
        {
            string subId = subIdFinder();

            DataTable dt1 = new DataTable();
            dt1 = DBManager.getdata("SELECT * FROM `student_assignment_upload` WHERE subject_id = '" + subId + "' AND grade = '" + frmGrade6TO11TeacherGrades.passGrd + "'");
            dgvAssignment.AutoGenerateColumns = false;
            dgvAssignment.DataSource = dt1;
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        //private async void transitionLoad()
        //{
        //    pnlSubjects.Visible = false;
        //    pnlAttend.Visible = false;
        //    pnlRank.Visible = false;
        //    pnlProgressTopic.Visible = false;
        //    pnlprogress.Visible = false;
        //    dgvArchievement.Visible = false;
        //    dgvStEvents.Visible = false;

        //    await Task.Run(() =>
        //    {
        //        trnsLoad.ShowSync(pnlSubjects);
        //        trnsLoad.ShowSync(pnlAttend);
        //        trnsLoad.ShowSync(pnlRank);
        //        trnsLoad.ShowSync(pnlProgressTopic);
        //        trnsLoad.ShowSync(pnlprogress);
        //        trnsLoad.ShowSync(dgvArchievement);
        //        trnsLoad.ShowSync(dgvStEvents);
        //    });
        //}

        private void frmGrade6Maths_Load(object sender, EventArgs e)
        {
            animateSetting.SetAnimateWindow(this);
        }

        private void uploadAssignment(String file)
        {

            FileStream fstream = File.OpenRead(file);
            byte[] content = new byte[fstream.Length];
            fstream.Read(content,0,(int)fstream.Length);
            fstream.Close();

            if (1 == DBManager.insrtUpdteDelt("INSERT INTO `teacher_assignment_upload`(`subject_id`, `file_name`, `assignment`, `grade`)  VALUES ('"+ subIdFinder() + "','"+ fileNameFinder(file) + "',@content,'" + frmGrade6TO11TeacherGrades.passGrd + "')", "@content", content))
                Alert.Show("File Upload","File Upload Successfull",Alert.AlertType.success, Color.FromArgb(242, 243, 244));
        }

        private void uploadNotes(String file)
        {
            FileStream fstream = File.OpenRead(file);
            byte[] content = new byte[fstream.Length];
            fstream.Read(content, 0, (int)fstream.Length);
            fstream.Close();

            if (1 == DBManager.insrtUpdteDelt("INSERT INTO `teacher_note_upload`(`subject_id`, `filename`, `notes`, `grade`) VALUES ('" + subIdFinder() + "','"+ fileNameFinder(file) + "',@content,'" + frmGrade6TO11TeacherGrades.passGrd + "')", "@content", content))
                Alert.Show("File Upload", "File Upload Successfull", Alert.AlertType.success, Color.FromArgb(242, 243, 244));
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            
        }

        private void lnkUpload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dgvAssignment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0) {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string filename = sfd.FileName;
                        fileDownload(filename, int.Parse(dgvAssignment.Rows[e.RowIndex].Cells[1].FormattedValue.ToString()));
                    }
                }
            }
        }

        private void fileDownload(string file, int index)
        {
            MySqlDataReader dr = DBManager.ReadAndGet("SELECT assignment FROM `student_assignment_upload` WHERE st_assignment_id = '" + index + "'");
            if (dr.Read())
            {
                byte[] fileData = (byte[])dr.GetValue(0);
                using (FileStream fs = new FileStream(file,FileMode.Create,FileAccess.ReadWrite))
                {
                    using(BinaryWriter bw = new BinaryWriter(fs))
                    {
                        bw.Write(fileData);
                        bw.Close();
                    }
                }
                Alert.Show("File Download", "File Download Successfull", Alert.AlertType.success, Color.FromArgb(242, 243, 244));
            }
            dr.Close();
        }

        private void lnkLblAssignment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string fileName = dlg.FileName;
                    uploadAssignment(fileName);
                }
            }
        }

        private void lnkLblNotes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string fileName = dlg.FileName;
                    uploadNotes(fileName);
                }
            }
        }
    }
}
