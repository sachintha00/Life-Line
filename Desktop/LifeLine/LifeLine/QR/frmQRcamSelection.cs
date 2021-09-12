using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace LifeLine.QR
{
    public partial class frmQRcamSelection : Form
    {
        public static int cameraChoice;
        FilterInfoCollection filter;
        public frmQRcamSelection()
        {
            InitializeComponent();
        }

        private void frmQRscanner_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filter)
            {
                cmbSelectCamera.Items.Add(filterInfo.Name);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbSelectCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            cameraChoice = cmbSelectCamera.SelectedIndex;
            new frmQRscanner().Show();
            this.Close();
        }
    }
}
