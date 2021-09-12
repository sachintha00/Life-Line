using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeLine.Students
{
    public partial class frmEvents : Form
    {
        public frmEvents()
        {
            InitializeComponent();
        }

        private string _title;
        private string _message;
        //private Image _icon;


        public string Title
        {
            get { return _title; }
            set { _title = value; ; lblTitle.Text = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; lblMessage.Text = value; }
        }
        //public Image Icon
        //{
        //    get { return _icon; }
        //    set { _icon = value; pcbEventPic.Image = value; }
        //}

        private void frmEvents_Load(object sender, EventArgs e)
        {

        }
    }
}