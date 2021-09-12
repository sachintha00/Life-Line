using System;
using System.Drawing;
using System.Windows.Forms;
using Zen.Barcode;
using System.Drawing.Printing;

namespace LifeLine.QR
{
    public partial class frmQRdesign : Form
    {
        public frmQRdesign()
        {
            InitializeComponent();
        }

        private void frmQRdesign_Load(object sender, EventArgs e)
        {
            CodeQrBarcodeDraw QRcode = BarcodeDrawFactory.CodeQr;
            pbQRcode.Image = QRcode.Draw(frmCreateAccStudent.rollId,50);
        }

        private void print(Object sender, PrintPageEventArgs arg)
        {
            Rectangle rec = arg.PageBounds;
            Bitmap bm = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bm,new Rectangle(0,0,pnl.Width,pnl.Height));
            arg.Graphics.DrawImage(bm,(rec.Width/2)-(this.pnl.Width/2),this.pnl.Location.Y);
            bm.Dispose();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument pDoc = new PrintDocument();
            pDoc.PrintPage += print;
            pd.Document = pDoc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pDoc.Print();
                }
                catch(Exception)
                {
                    //
                }
            }
            this.Close();
        }
    }
}
