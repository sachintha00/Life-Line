using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using SMDnotify;
using ZXing;
using System.Media;

namespace LifeLine.QR
{
    public partial class frmQRscanner : Form
    {

        FilterInfoCollection filter;
        VideoCaptureDevice captureDevice;
        public frmQRscanner()
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

            captureDevice = new VideoCaptureDevice(filter[frmQRcamSelection.cameraChoice].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            tmrStartCapture.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbCapture.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void tmrStartCapture_Tick(object sender, EventArgs e)
        {
            if (pbCapture.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result rs = reader.Decode((Bitmap)pbCapture.Image);
                if (rs != null)
                {
                    //txtAttendance.Text = rs.ToString();
                    string lastRecrd = DBManager.lastRecord("SELECT MAX(attendance_number) FROM `student_attendance` WHERE student_ID = '" + rs.ToString() + "'");
                    if (DBManager.getValue("SELECT * FROM `student_attendance`", lastRecrd, 0, 3) != DateTime.Now.Date.ToString())
                    {
                        int i = DBManager.insrtUpdteDelt("INSERT INTO `student_attendance`(`student_ID`, `attendance`, `date`) VALUES ('" + rs.ToString() + "',1,'" + DateTime.Now.Date.ToString() + "')");
                        if (i == 1)
                        {
                            SoundPlayer ss = new SoundPlayer(@"attendance (online-audio-converter.com).wav");
                            ss.Play();
                        }

                    }
                    //tmrStartCapture.Stop();
                    //if (captureDevice.IsRunning)
                    //{
                    //    captureDevice.Stop();
                    //}
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tmrStartCapture.Stop();
            captureDevice.Stop();
            this.Close();
        }

        private void txtAttendance_TextChanged(object sender, EventArgs e)
        {
            //if (DBManager.getValue("SELECT MAX(attendance_number) FROM `student_attendance`", txtAttendance.Text, 1, 3) != DateTime.Now.Date.ToString())
            //{
            //    //int i = DBManager.insrtUpdteDelt("INSERT INTO `student_attendance`(`student_ID`, `attendance`, `date`) VALUES ('" + txtAttendance.Text + "',1,'" + DateTime.Now.Date.ToString() + "')");
            //    //if (i == 1)
            //    //{

            //    //}
            //    MessageBox.Show("hi");
            //}
        }
    }
}
