namespace LifeLine.QR
{
    partial class frmQRscanner
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
            this.elips = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.cmbSelectCamera = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tmrStartCapture = new System.Windows.Forms.Timer(this.components);
            this.pbCapture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // elips
            // 
            this.elips.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconSize = 15F;
            this.btnClose.Location = new System.Drawing.Point(594, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(206)))));
            this.btnClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(82, 48);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbSelectCamera
            // 
            this.cmbSelectCamera.BackColor = System.Drawing.Color.Transparent;
            this.cmbSelectCamera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSelectCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectCamera.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSelectCamera.FocusedState.Parent = this.cmbSelectCamera;
            this.cmbSelectCamera.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSelectCamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSelectCamera.FormattingEnabled = true;
            this.cmbSelectCamera.HoverState.Parent = this.cmbSelectCamera;
            this.cmbSelectCamera.ItemHeight = 30;
            this.cmbSelectCamera.ItemsAppearance.Parent = this.cmbSelectCamera;
            this.cmbSelectCamera.Location = new System.Drawing.Point(177, 289);
            this.cmbSelectCamera.Name = "cmbSelectCamera";
            this.cmbSelectCamera.ShadowDecoration.Parent = this.cmbSelectCamera;
            this.cmbSelectCamera.Size = new System.Drawing.Size(285, 36);
            this.cmbSelectCamera.TabIndex = 2;
            this.cmbSelectCamera.Visible = false;
            // 
            // tmrStartCapture
            // 
            this.tmrStartCapture.Enabled = true;
            this.tmrStartCapture.Tick += new System.EventHandler(this.tmrStartCapture_Tick);
            // 
            // pbCapture
            // 
            this.pbCapture.Location = new System.Drawing.Point(120, 289);
            this.pbCapture.Name = "pbCapture";
            this.pbCapture.ShadowDecoration.Parent = this.pbCapture;
            this.pbCapture.Size = new System.Drawing.Size(431, 381);
            this.pbCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCapture.TabIndex = 3;
            this.pbCapture.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(187, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 69);
            this.label2.TabIndex = 6;
            this.label2.Text = "Point your card with the QR code to the camera and note the attendance";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(156, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "MARKING ATTENDANCE";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::LifeLine.Properties.Resources.logo;
            this.gunaPictureBox1.Location = new System.Drawing.Point(56, 115);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(94, 85);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 7;
            this.gunaPictureBox1.TabStop = false;
            // 
            // frmQRscanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 746);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCapture);
            this.Controls.Add(this.cmbSelectCamera);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQRscanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQRscanner";
            this.Load += new System.EventHandler(this.frmQRscanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elips;
        private Guna.UI2.WinForms.Guna2PictureBox pbCapture;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSelectCamera;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private System.Windows.Forms.Timer tmrStartCapture;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}