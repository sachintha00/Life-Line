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

namespace LifeLine
{
    public partial class frmGrade6SubjectInside : Form
    {
        public frmGrade6SubjectInside()
        {
            InitializeComponent();
            showData();
        }

        private string fileNameFinder(string filePath)
        {
            FileInfo fi = new FileInfo(filePath);
            return fi.Name;
        }

        private void showData()
        {
            string grade = DBManager.getValue("SELECT * FROM `student_account`", frmLogin.passingRollId, 0, 2);

            DataTable dt1 = new DataTable();
            dt1 = DBManager.getdata("SELECT * FROM `teacher_assignment_upload` WHERE grade = '"+ grade + "' AND subject_id = '"+frmGrade6TO11StudentSubjects.passSubId+ "' OR subject_id = '" + frmGrade6TO11StudentDash.passSubId + "'");
            dgvAssignment.AutoGenerateColumns = false;
            dgvAssignment.DataSource = dt1;

            DataTable dt2 = new DataTable();
            dt2 = DBManager.getdata("SELECT * FROM `teacher_note_upload` WHERE grade = '" + grade + "' AND subject_id = '" + frmGrade6TO11StudentSubjects.passSubId + "' OR subject_id = '" + frmGrade6TO11StudentDash.passSubId + "'");
            dgvNote.AutoGenerateColumns = false;
            dgvNote.DataSource = dt2;
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

        private void uploadFile(String file)
        {
            string grade = DBManager.getValue("SELECT * FROM `student_account`", frmLogin.passingRollId,0,2);


            FileStream fstream = File.OpenRead(file);
            byte[] content = new byte[fstream.Length];
            fstream.Read(content,0,(int)fstream.Length);
            fstream.Close();

            if (1 == DBManager.insrtUpdteDelt("INSERT INTO `student_assignment_upload`(`subject_id`, `file_name`, `assignment`, `student_ID`, `grade`) VALUES ('" + frmGrade6TO11StudentSubjects.passSubId + "','"+ fileNameFinder(file) + "',@content,'" + frmLogin.passingRollId + "','" + grade + "')", "@content", content))
                Alert.Show("File Upload","File Upload Successfull",Alert.AlertType.success, Color.FromArgb(242, 243, 244));
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            
        }

        private void lnkUpload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string fileName = dlg.FileName;
                    uploadFile(fileName);
                }
            }
        }

        private void dgvAssignment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0) {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string filename = sfd.FileName;
                        fileDownload(filename, "SELECT assignment FROM `teacher_assignment_upload` WHERE teach_assignment_id = '" + int.Parse(dgvAssignment.Rows[e.RowIndex].Cells[1].FormattedValue.ToString()) + "'");
                    }
                }
            }
        }

        private void fileDownload(string file, string query)
        {
            MySqlDataReader dr = DBManager.ReadAndGet(query);
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

        private void dgvNote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string filename = sfd.FileName;
                        fileDownload(filename, "SELECT * FROM `teacher_note_upload` WHERE teach_note_id = '" + int.Parse(dgvNote.Rows[e.RowIndex].Cells[1].FormattedValue.ToString()) + "'");
                    }
                }
            }
        }
    }
}
