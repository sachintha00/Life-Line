namespace LifeLine.Students
{
    partial class frmEvents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvents));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pcbEventPic = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.lblMessage = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEventPic)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // pcbEventPic
            // 
            this.pcbEventPic.BaseColor = System.Drawing.Color.White;
            this.pcbEventPic.Image = ((System.Drawing.Image)(resources.GetObject("pcbEventPic.Image")));
            this.pcbEventPic.Location = new System.Drawing.Point(34, 21);
            this.pcbEventPic.Name = "pcbEventPic";
            this.pcbEventPic.Size = new System.Drawing.Size(51, 51);
            this.pcbEventPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEventPic.TabIndex = 0;
            this.pcbEventPic.TabStop = false;
            this.pcbEventPic.UseTransfarantBackground = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(113, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(68, 35);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMessage.Location = new System.Drawing.Point(115, 47);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(238, 45);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "gunaLabel2";
            // 
            // frmEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 110);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pcbEventPic);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEvents";
            this.Text = "frmEvents";
            this.Load += new System.EventHandler(this.frmEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbEventPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel lblMessage;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI.WinForms.GunaCirclePictureBox pcbEventPic;
    }
}