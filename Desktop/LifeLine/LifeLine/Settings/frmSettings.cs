using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDLogic;

namespace LifeLine
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
            SMDChildFormOpen.OpenWithActiveForm(new frmAuthentication(), pnlSettChild, Color.White);
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

        private void frmGrade6StudentSubjects_Load(object sender, EventArgs e)
        {
            animateSetting.SetAnimateWindow(this);
        }

        private void btnAuthentication_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.OpenWithActiveForm(new frmAuthentication(), pnlSettChild, Color.White);
        }

        private void btnSettAccount_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.OpenWithActiveForm(new frmAccount(), pnlSettChild, Color.White);
        }
    }
}
